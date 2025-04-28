using Domain.Entities;

namespace Domain.Contracts
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string id);

        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket, TimeSpan? timeToLive = null);

        Task<bool> DeleteBasketAsync(string id);
    }
}
