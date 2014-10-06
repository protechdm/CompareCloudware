using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Policy;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IPolicyAppender
    {
        void UpdatePolicies(ISecurityPolicy securityPolicyToAdd, IList<ISecurityPolicy> policies);
    }
}