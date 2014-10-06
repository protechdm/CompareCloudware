using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal class SingletonLifecycle : ILifecycle
    {
        private readonly IObjectCache _cache = new ObjectCache();

        public IObjectCache FindCache()
        {
            return _cache;
        }
    }
}