using System.Text.Json;
using Domain.Contracts;
using Domain.Entities;
using StackExchange.Redis;

namespace Persistence.Repositories
{
    public class BasketRepository(IConnectionMultiplexer connectionMultiplexer) : IBasketRepository
    {
        private readonly IDatabase _database = connectionMultiplexer.GetDatabase();
        public async Task<bool> DeleteBasketAsync(string id)
            => await _database.KeyDeleteAsync(id);

        public async Task<CustomerBasket> GetBasketAsync(string id)
        {
            var basket = await _database.StringGetAsync(id);

            if(basket.IsNullOrEmpty)
                return null;

            return JsonSerializer.Deserialize<CustomerBasket>(basket);
        }

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket customerBasket, TimeSpan? timeToLive = null)
        {
            var serliazedBasket = JsonSerializer.Serialize(customerBasket);

            var isCreatedOrUpdated = await _database.StringSetAsync(customerBasket.Id, serliazedBasket, timeToLive ?? TimeSpan.FromDays(30));

            return isCreatedOrUpdated ? await GetBasketAsync(customerBasket.Id) : null;
        }
    }
}
