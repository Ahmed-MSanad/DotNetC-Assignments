using AutoMapper;
using Domain.Contracts;
using Domain.Entities;
using Domain.Exceptions;
using Services.Abstraction;
using Shared.BasketDtos;

namespace Services
{
    public class BasketService(IBasketRepository basketRepository, IMapper mapper) : IBasketService
    {
        public Task<bool> DeleteBasketAsync(string id)
            => basketRepository.DeleteBasketAsync(id);

        public async Task<BasketDto> GetBasketAsync(string id)
        {
            var customerBasket = await basketRepository.GetBasketAsync(id);

            return customerBasket is null ? throw new BasketNotFoundException(id) : mapper.Map<BasketDto>(customerBasket);
        }

        public async Task<BasketDto> UpdateBasketAsync(BasketDto basket)
        {
            var mappedBasket = mapper.Map<CustomerBasket>(basket);

            var updatedCustomerBasket = await basketRepository.UpdateBasketAsync(mappedBasket);

            return updatedCustomerBasket is null ? throw new Exception("Can't Update The Basket Now") 
                                                 : mapper.Map<BasketDto>(updatedCustomerBasket);
        }
    }
}
