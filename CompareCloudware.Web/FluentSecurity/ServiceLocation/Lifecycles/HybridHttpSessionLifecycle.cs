using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal class HybridHttpSessionLifecycle : ILifecycle
    {
        private readonly HttpSessionLifecycle _http;
        private readonly SingletonLifecycle _nonHttp;

        public HybridHttpSessionLifecycle()
        {
            _http = new HttpSessionLifecycle();
            _nonHttp = new SingletonLifecycle();
        }

        public IObjectCache FindCache()
        {
            return _http.HasSession()
                ? _http.FindCache()
                : _nonHttp.FindCache();
        }
    }
}