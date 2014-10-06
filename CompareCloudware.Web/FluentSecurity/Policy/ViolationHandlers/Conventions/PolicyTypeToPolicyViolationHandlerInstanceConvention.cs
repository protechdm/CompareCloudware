using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class PolicyTypeToPolicyViolationHandlerInstanceConvention<TSecurityPolicy, TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler>
        where TPolicyViolationHandler : class, IPolicyViolationHandler
        where TSecurityPolicy : class, ISecurityPolicy
    {
        public PolicyTypeToPolicyViolationHandlerInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory) : base(policyViolationHandlerFactory, policyResult => policyResult.PolicyType == typeof(TSecurityPolicy)) { }
    }
}