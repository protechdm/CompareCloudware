using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy
{
    internal interface ILazySecurityPolicy : ISecurityPolicy
    {
        Type PolicyType { get; }
        ISecurityPolicy Load();
    }
}