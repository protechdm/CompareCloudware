namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using System;

    public class PredicateToPolicyViolationHandlerTypeConvention<TPolicyViolationHandler> : LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        public PredicateToPolicyViolationHandlerTypeConvention(Func<PolicyResult, bool> predicate) : base(predicate)
        {
        }
    }
}

