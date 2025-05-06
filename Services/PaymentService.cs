using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.OrderEntities;
using Domain.Exceptions;
using Microsoft.Extensions.Configuration;
using Services.Abstraction;
using Shared.BasketDtos;
using Stripe;

namespace Services
{
    public class PaymentService(IUnitOfWork unitOfWork,
        IBasketRepository basketRepository,
        IMapper mapper,
        IConfiguration configuration) : IPaymentService
    {
        public async Task<BasketDto> CreateOrUpdatePaymentIntentAsync(string basketId)
        {
            StripeConfiguration.ApiKey = configuration.GetRequiredSection("Stripe")["SecretKey"];
            
            var basket = await basketRepository.GetBasketAsync(basketId);

            if (basket is null)
                throw new BasketNotFoundException(basketId);

            // is the price in the basket itself the one in the database -> make sure:
            var productRepo = unitOfWork.GetRepository<Domain.Entities.Product, int>();
            foreach (var item in basket.BasketItems)
            {
                var product = await productRepo.GetAsync(item.Id);

                if (product is null)
                    throw new ProductNotFoundException(item.Id);
                
                item.Price = product.Price;
            }

            if(basket.DeliveryMethodId.HasValue)
                throw new ArgumentNullException();

            var deliveryMethod = await unitOfWork.GetRepository<DeliveryMethod, int>().GetAsync(basket.DeliveryMethodId.Value);

            if(deliveryMethod is null)
                throw new DeliveryMethodNotFoundException(basket.DeliveryMethodId.Value);

            basket.ShippingPrice = deliveryMethod.Price;

            var amount = (long)(basket.BasketItems.Sum(item => item.Price * item.Quantity) + basket.ShippingPrice) * 100; // * 100 as we are using cents in stripe

            
            var service = new PaymentIntentService();
            if (string.IsNullOrWhiteSpace(basket.PaymentIntentId)) // then -> create payment over stripe and not update
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = amount,
                    PaymentMethodTypes = ["card"],
                    Currency = "USD", // there are other supported currencies in stripe DOC 
                };

                var paymentIntent = await service.CreateAsync(options);

                basket.PaymentIntentId = paymentIntent.Id;

                basket.ClientSecret = paymentIntent.ClientSecret;
            }
            else // Update -> add or remove items before completing payment
            {
                var options = new PaymentIntentUpdateOptions
                {
                    Amount = amount,
                };

                await service.UpdateAsync(basket.PaymentIntentId, options);
            }

            await basketRepository.UpdateBasketAsync(basket);

            return mapper.Map<BasketDto>(basket);
        }



        public Task UpdateOrderPaymentStatusAsync(string request, string stripeHeader)
        {
            throw new NotImplementedException();
        }
    }
}
