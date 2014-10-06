using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Policy;

namespace CompareCloudware.Web.FluentSecurity
{
    public class DefaultPolicyAppender : IPolicyAppender
    {
        public void UpdatePolicies(ISecurityPolicy securityPolicyToAdd, IList<ISecurityPolicy> policies)
        {
            if (securityPolicyToAdd == null) throw new ArgumentNullException("securityPolicyToAdd");
            if (policies == null) throw new ArgumentNullException("policies");

            if (securityPolicyToAdd is IgnorePolicy)
                policies.Clear();
            else if (securityPolicyToAdd is DenyAnonymousAccessPolicy)
                policies.Clear();
            else if (securityPolicyToAdd is DenyAuthenticatedAccessPolicy)
                policies.Clear();
            else if (securityPolicyToAdd is RequireRolePolicy)
                policies.Clear();
            else if (securityPolicyToAdd is RequireAllRolesPolicy)
                policies.Clear();

            policies.Add(securityPolicyToAdd);
        }
    }
}