using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal class ThreadLocalStorageLifecycle : ILifecycle
    {
        [ThreadStatic]
        private static ObjectCache _cache;
        private readonly object _locker = new object();

        public IObjectCache FindCache()
        {
            EnsureCacheExists();
            return _cache;
        }

        private void EnsureCacheExists()
        {
            if (_cache != null) return;

            lock (_locker)
            {
                if (_cache == null)
                    _cache = new ObjectCache();
            }
        }
    }
}