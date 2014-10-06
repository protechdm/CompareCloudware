namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using System;

    public class PolicyTypeToPolicyViolationHandlerTypeConvention<TSecurityPolicy, TPolicyViolationHandler> : LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler> where TSecurityPolicy: class, ISecurityPolicy where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        public PolicyTypeToPolicyViolationHandlerTypeConvention() : base(policyResult => policyResult.PolicyType == typeof(TSecurityPolicy))
        {
        }
    }
}

