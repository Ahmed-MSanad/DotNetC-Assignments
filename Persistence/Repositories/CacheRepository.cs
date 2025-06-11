using Domain.Contracts;
using StackExchange.Redis;

namespace Persistence.Repositories
{
    public class CacheRepository(IConnectionMultiplexer connectionMultiplexer) : ICacheRepository
    {
        private readonly IDatabase _database = connectionMultiplexer.GetDatabase();
        public async Task<string?> GetAsync(string cacheKey) // What will be added to the in-memory database will expire(then will be deleted) after some time so there is no need to do delete method
            => await _database.StringGetAsync(cacheKey);

        public async Task SetAsync(string cacheKey, string value, TimeSpan timeToLive)
            => await _database.StringSetAsync(cacheKey, value, timeToLive);
    }
}
