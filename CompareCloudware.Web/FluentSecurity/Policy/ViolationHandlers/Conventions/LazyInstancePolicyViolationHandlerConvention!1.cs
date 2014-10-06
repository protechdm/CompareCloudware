namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using CompareCloudware.Web.FluentSecurity;
    using System;
    using System.Runtime.CompilerServices;

    public abstract class LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> : IPolicyViolationHandlerConvention, IConvention where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        private readonly Func<TPolicyViolationHandler> _policyViolationHandlerFactory;

        protected LazyInstancePolicyViolationHandlerConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory) : this(policyViolationHandlerFactory, pr => true)
        {
        }

        protected LazyInstancePolicyViolationHandlerConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory, Func<PolicyResult, bool> predicate)
        {
            if (policyViolationHandlerFactory == null)
            {
                throw new ArgumentNullException("policyViolationHandlerFactory");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }
            this._policyViolationHandlerFactory = policyViolationHandlerFactory;
            this.Predicate = predicate;
        }

        public IPolicyViolationHandler GetHandlerFor(PolicyViolationException exception)
        {
            return (this.Predicate(exception.PolicyResult) ? ((IPolicyViolationHandler) this._policyViolationHandlerFactory()) : ((IPolicyViolationHandler) default(TPolicyViolationHandler)));
        }

        public Func<PolicyResult, bool> Predicate { get; private set; }
    }
}

