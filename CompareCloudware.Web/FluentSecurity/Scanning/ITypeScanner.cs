using System;
using System.Collections.Generic;
using System.Reflection;

namespace CompareCloudware.Web.FluentSecurity.Scanning
{
    internal interface ITypeScanner
    {
        IEnumerable<Type> Scan(IEnumerable<Assembly> assemblies);
    }
}