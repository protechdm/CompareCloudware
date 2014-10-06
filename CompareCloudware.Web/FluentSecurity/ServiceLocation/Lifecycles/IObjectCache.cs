using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal interface IObjectCache
    {
        object Get(object key);
        void Set(object key, object instance);
        void Clear();
    }
}