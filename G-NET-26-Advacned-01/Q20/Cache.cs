using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01
{
    public class Cache<TKey, TValue>
        where TKey : struct
        where TValue : class
    {
        private class CacheItem
        {
            public TValue Value { get; }
            public DateTimeOffset ExpiryTime { get; }

            public CacheItem(TValue value, DateTimeOffset expiryTime)
            {
                Value = value;
                ExpiryTime = expiryTime;
            }

            public bool IsExpired => DateTimeOffset.UtcNow >= ExpiryTime;
        }

        private readonly Dictionary<TKey, CacheItem> cacheStore = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan? timeToLive = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Cannot cache a null reference.");
            }

            DateTimeOffset expiryTime = timeToLive.HasValue
                ? DateTimeOffset.UtcNow.Add(timeToLive.Value)
                : DateTimeOffset.MaxValue;

            cacheStore[key] = new CacheItem(value, expiryTime);
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            if (cacheStore.TryGetValue(key, out CacheItem item))
            {
                if (item.IsExpired)
                {
                    cacheStore.Remove(key);

                    value = default;
                    return false;
                }

                value = item.Value;
                return true;
            }

            value = default;
            return false;
        }
        public TValue Get(TKey key) =>
            TryGetValue(key, out TValue value) ? value : throw new KeyNotFoundException($"The given key '{key}' was not present in the cache.");

        public void Remove(TKey key) => cacheStore.Remove(key);

        public bool Contains(TKey key) =>
            cacheStore.TryGetValue(key, out CacheItem item) && !item.IsExpired;
     
    }
}  
