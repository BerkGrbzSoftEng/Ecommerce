using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Caching.Memory;
using MemoryCache = System.Runtime.Caching.MemoryCache;

namespace Core.CrossCuting.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        private ObjectCache cache => MemoryCache.Default;
        public T Get<T>(string key)
        {
            return (T)cache[key];
        }

        public void Add(string key, object data, int cacheTime)
        {
            if (data==null)
            {
                return;
            }
            var policy=new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now+TimeSpan.FromMinutes(cacheTime)
            };
            cache.Add(new CacheItem(key, data),policy);

        }

        public bool IsAdd(string key)
        {
            return cache.Contains(key);
        }

        public void Remove(string key)
        {
            cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex=new Regex(pattern,RegexOptions.Singleline|RegexOptions.Compiled|RegexOptions.IgnoreCase);
            var keysToRemove = cache.Where(d => regex.IsMatch(d.Key)).Select(
                d => d.Key).ToList();
            foreach (var item in keysToRemove)
            {
                Remove(item);
            }
        }

        public void Clear()
        {
            foreach (var item in cache)
            {
                Remove(item.Key);
            }
        }
    }
}
