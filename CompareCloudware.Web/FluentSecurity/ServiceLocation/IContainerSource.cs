using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation
{
    public interface IContainerSource
    {
        object Resolve(Type typeToResolve);
        IEnumerable<object> ResolveAll(Type typeToResolve);
    }
}