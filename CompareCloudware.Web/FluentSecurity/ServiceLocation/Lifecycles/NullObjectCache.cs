using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal class NullObjectCache : IObjectCache
    {
        public object Get(object key)
        {
            return null;
        }

        public void Set(object key, object instance) { }

        public void Clear() { }
    }
}