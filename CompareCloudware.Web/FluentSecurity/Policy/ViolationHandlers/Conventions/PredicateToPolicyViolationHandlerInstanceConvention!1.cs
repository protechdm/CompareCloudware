namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using System;

    public class PredicateToPolicyViolationHandlerInstanceConvention<TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        public PredicateToPolicyViolationHandlerInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory, Func<PolicyResult, bool> predicate) : base(policyViolationHandlerFactory, predicate)
        {
        }
    }
}

