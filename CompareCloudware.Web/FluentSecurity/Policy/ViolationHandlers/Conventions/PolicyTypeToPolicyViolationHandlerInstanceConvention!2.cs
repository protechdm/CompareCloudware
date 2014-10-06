namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using System;

    public class PolicyTypeToPolicyViolationHandlerInstanceConvention<TSecurityPolicy, TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> where TSecurityPolicy: class, ISecurityPolicy where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        public PolicyTypeToPolicyViolationHandlerInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory) : base(policyViolationHandlerFactory, policyResult => policyResult.PolicyType == typeof(TSecurityPolicy))
        {
        }
    }
}

