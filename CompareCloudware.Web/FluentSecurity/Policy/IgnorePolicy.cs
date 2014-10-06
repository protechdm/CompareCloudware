using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy
{
    public class IgnorePolicy : ISecurityPolicy
    {
        public PolicyResult Enforce(ISecurityContext context)
        {
            return PolicyResult.CreateSuccessResult(this);
        }
    }
}