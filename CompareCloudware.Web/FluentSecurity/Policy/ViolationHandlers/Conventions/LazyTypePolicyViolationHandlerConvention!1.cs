namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using CompareCloudware.Web.FluentSecurity;
    using System;
    using System.Runtime.CompilerServices;

    public abstract class LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler> : PolicyViolationHandlerTypeConvention where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        protected LazyTypePolicyViolationHandlerConvention() : this(pr => true)
        {
        }

        protected LazyTypePolicyViolationHandlerConvention(Func<PolicyResult, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }
            this.Predicate = predicate;
        }

        public override Type GetHandlerTypeFor(PolicyViolationException exception)
        {
            return (this.Predicate(exception.PolicyResult) ? typeof(TPolicyViolationHandler) : null);
        }

        public Func<PolicyResult, bool> Predicate { get; private set; }
    }
}

