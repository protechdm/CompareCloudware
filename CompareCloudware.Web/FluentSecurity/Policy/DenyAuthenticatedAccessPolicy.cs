using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy
{
    public class DenyAuthenticatedAccessPolicy : ISecurityPolicy
    {
        public PolicyResult Enforce(ISecurityContext context)
        {
            if (context.CurrenUserAuthenticated())
            {
                return PolicyResult.CreateFailureResult(this, "Authenticated access denied");
            }
            return PolicyResult.CreateSuccessResult(this);
        }
    }
}