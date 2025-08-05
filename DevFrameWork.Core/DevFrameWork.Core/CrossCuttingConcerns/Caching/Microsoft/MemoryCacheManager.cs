using System;
using System.Runtime.Caching;
using System.Text.RegularExpressions;

namespace DevFrameWork.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        protected ObjectCache Cache => MemoryCache.Default;

        public void Add(string key, object data, int cacheTime = 60)
        {
            if (data == null)
            {
                return;
            }

            var policy = new CacheItemPolicy
            {
                // 60 dakika boyunca cache'de dursun.
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime)
            };
            Cache.Add(new CacheItem(key, data), policy);
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }
    }
}
