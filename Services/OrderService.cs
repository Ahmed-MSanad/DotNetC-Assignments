using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.OrderEntities;
using Domain.Exceptions;
using Services.Abstraction;
using Services.Specifications;
using Shared.OrderDtos;

namespace Services
{
    public class OrderService(IUnitOfWork unitOfWork, IMapper mapper, IBasketRepository basketRepository) : IOrderService
    {
        public async Task<OrderResult> CreateOrderAsync(OrderRequest orderRequest, string buyerEmail)
        {
            // TODO: Implement the method to create an order

            // 1. Get the Address
            var address = mapper.Map<Address>(orderRequest.ShippingAddress);

            // 2. Get the Basket
            var basket = await basketRepository.GetBasketAsync(orderRequest.BasketId);

            if (basket is null)
                throw new BasketNotFoundException(orderRequest.BasketId);

            // check if there is already a paymentIntent order related to this basket.PaymentIntentId to avoid creating a new one
            // as each order should related to a unique paymentIntentId.
            var existingOrderSpecs = new OrderWithPaymentIntentIdSpecification(basket.PaymentIntentId);
            var orderRepo = unitOfWork.GetRepository<Order, Guid>();
            var existingOrder = await orderRepo.GetAsync(existingOrderSpecs);
            if(existingOrder is not null)
                orderRepo.Delete(existingOrder);



            var orderItems = new List<OrderItem>();
            var productRepo = unitOfWork.GetRepository<Product, int>();
            foreach (var item in basket.BasketItems)
            {
                var product = await productRepo.GetAsync(item.Id);

                if(product is null)
                    throw new ProductNotFoundException(item.Id);

                var productInOrderItem = new ProductInOrderItem(product.Id, product.Name, product.PictureUrl);

                var orderItem = new OrderItem(productInOrderItem, item.Quantity, product.Price);

                orderItems.Add(orderItem);
            }

            // Delivery Method:

            var deliveryMethod = await unitOfWork.GetRepository<DeliveryMethod, int>().GetAsync(orderRequest.DeliveryMethodId);

            if (deliveryMethod is null)
                throw new DeliveryMethodNotFoundException(orderRequest.DeliveryMethodId);

            // SubTotal:
            var subtotal = orderItems.Sum(item => item.Price * item.Quantity);


            var order = new Order(buyerEmail, address, orderItems, deliveryMethod, subtotal);

            await orderRepo.AddAsync(order);

            await unitOfWork.SaveChangesAsync();

            return mapper.Map<OrderResult>(order);
        }

        public async Task<IEnumerable<DeliveryMethodResult>> GetDeliveryMethodsAsync()
        {
            var deliveryMethods = await unitOfWork.GetRepository<DeliveryMethod, int>().GetAllAsync();

            return mapper.Map<IEnumerable<DeliveryMethodResult>>(deliveryMethods);
        }

        public async Task<OrderResult> GetOrderByIdAsync(Guid id)
        {
            var orderSpecs = new OrderWithIncludeSpecification(id);

            var order = await unitOfWork.GetRepository<Order, Guid>().GetAsync(orderSpecs);

            if (order is null)
            {
                throw new OrderNotFoundException(id);
            }

            return mapper.Map<OrderResult>(order);
        }

        public async Task<IEnumerable<OrderResult>> GetOrdersByEmailAsync(string email)
        {
            var ordersSpecs = new OrderWithIncludeSpecification(email);

            var orders = await unitOfWork.GetRepository<Order, Guid>().GetAllAsync(ordersSpecs);

            if (orders.Count() == 0)
            {
                throw new OrdersWithEmailNotFoundException(email);
            }

            return mapper.Map<IEnumerable<OrderResult>>(orders);
        }
    }
}
