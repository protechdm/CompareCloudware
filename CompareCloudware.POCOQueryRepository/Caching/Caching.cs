using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Runtime.Caching;
using System.Web.Caching;
using Castle.Core.Logging;

namespace CompareCloudware.POCOQueryRepository.Caching
{
    public class Caching
    {
    }

    public interface ICacheProvider
    {
        object Get(string key);
        void Set(string key, object data, int cacheTime);
        bool IsSet(string key);
        void Invalidate(string key);
    }

    public class DefaultCacheProvider : ICacheProvider
    {
        #region SESSION CACHE
        //private ObjectCache Cache { get { return MemoryCache.Default; } }

        //public object Get(string key)
        //{
        //    return Cache[key];
        //}

        //public void Set(string key, object data, int cacheTime)
        //{
        //    CacheItemPolicy policy = new CacheItemPolicy();
        //    policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);

        //    Cache.Add(new CacheItem(key, data), policy);
        //}

        //public bool IsSet(string key)
        //{
        //    return (Cache[key] != null);
        //}

        //public void Invalidate(string key)
        //{
        //    Cache.Remove(key);
        //}
        #endregion

        public ILogger Logger { get; set; }

        #region APPLICATION CACHE

        private static CacheItemRemovedCallback OnCachedItemRemoved = null; 

        public object Get(string key)
        {
            return System.Web.HttpContext.Current.Cache[key];
        }

        public void Set(string key, object data, int cacheTime)
        {
            OnCachedItemRemoved = new CacheItemRemovedCallback(this.CachedItemRemovedCallback);

            System.Web.HttpContext.Current.Cache.Insert(
                key,
                data,
                null,
                DateTime.Now.AddHours(cacheTime),
                System.Web.Caching.Cache.NoSlidingExpiration,
                CacheItemPriority.Default,
                CachedItemRemovedCallback
                );

            Logger.Debug("Added item to cache - " + key + " at " + DateTime.Now.ToString() + ".");

            //CacheItemPolicy policy = new CacheItemPolicy();
            //policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            //Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsSet(string key)
        {
            return (System.Web.HttpContext.Current.Cache[key] != null);
        }

        public void Invalidate(string key)
        {
            System.Web.HttpContext.Current.Cache.Remove(key);
        }

        private void CachedItemRemovedCallback(string key, Object val,
    CacheItemRemovedReason reason)
        {
            //    
            if (reason == CacheItemRemovedReason.DependencyChanged)
            {
                // Log the cache key name, reason and time details    
                // when the cached object was removed from the cache    
            }
            Logger.Debug("Removed item from cache - " + key + " at " + DateTime.Now.ToString()  + ". Reason - " + reason.ToString());

        }
        #endregion
    }
}