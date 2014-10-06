using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class DefaultPolicyViolationHandlerIsInstanceConvention<TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler : class, IPolicyViolationHandler
    {
        public DefaultPolicyViolationHandlerIsInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandler) : base(policyViolationHandler) { }
    }
}