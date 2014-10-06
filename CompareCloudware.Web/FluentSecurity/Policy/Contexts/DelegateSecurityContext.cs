using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.Contexts
{
    public class DelegateSecurityContext : SecurityContextWrapper
    {
        internal DelegateSecurityContext(ISecurityPolicy policy, ISecurityContext securityContext)
            : base(securityContext)
        {
            Policy = policy;
        }

        public ISecurityPolicy Policy { get; private set; }
    }
}