using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

namespace OrchardCore.Infrastructure.Cache
{
    /// <summary>
    /// Provides a distributed cache service that can return existing references in the current scope.
    /// </summary>
    public interface IScopedDistributedCache
    {
        Task<T> GetAsync<T>(string key) where T : ScopedDistributedCacheable;
        Task<T> GetOrCreateAsync<T>(string key, DistributedCacheEntryOptions options, Func<Task<T>> factory) where T : ScopedDistributedCacheable;
        Task SetAsync<T>(string key, T value, DistributedCacheEntryOptions options) where T : ScopedDistributedCacheable;
        Task RemoveAsync(string key);
    }
}
