using System.Text.Json;
using Domain.Contracts;
using Services.Abstraction;

namespace Services
{
    public class CacheService(ICacheRepository cacheRepository) : ICacheService
    {
        public async Task<string?> GetAsync(string cacheKey)
            => await cacheRepository.GetAsync(cacheKey);

        public async Task SetAsync(string cacheKey, object value, TimeSpan timeToLive)
        {
            var serializedValue = JsonSerializer.Serialize(value);

            await cacheRepository.SetAsync(cacheKey, serializedValue, timeToLive);
        }
    }
}
