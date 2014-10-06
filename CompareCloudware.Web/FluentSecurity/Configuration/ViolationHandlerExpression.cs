using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Policy;
using CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions;

namespace CompareCloudware.Web.FluentSecurity.Configuration
{
    public class ViolationHandlerExpression<TSecurityPolicy> : ViolationHandlerExpressionBase where TSecurityPolicy : class, ISecurityPolicy
    {
        internal ViolationHandlerExpression(ViolationConfigurationExpression violationConfigurationExpression) : base(violationConfigurationExpression) { }

        public void IsHandledBy<TPolicyViolationHandler>() where TPolicyViolationHandler : class, IPolicyViolationHandler
        {
            ViolationConfigurationExpression.AddConvention(new PolicyTypeToPolicyViolationHandlerTypeConvention<TSecurityPolicy, TPolicyViolationHandler>());
        }

        public void IsHandledBy<TPolicyViolationHandler>(Func<TPolicyViolationHandler> policyViolationHandlerFactory) where TPolicyViolationHandler : class, IPolicyViolationHandler
        {
            ViolationConfigurationExpression.AddConvention(new PolicyTypeToPolicyViolationHandlerInstanceConvention<TSecurityPolicy, TPolicyViolationHandler>(policyViolationHandlerFactory));
        }
    }

    public class ViolationHandlerExpression : ViolationHandlerExpressionBase
    {
        public Func<PolicyResult, bool> Predicate { get; private set; }

        internal ViolationHandlerExpression(ViolationConfigurationExpression violationConfigurationExpression, Func<PolicyResult, bool> predicate)
            : base(violationConfigurationExpression)
        {
            if (predicate == null) throw new ArgumentNullException("predicate");
            Predicate = predicate;
        }

        public void IsHandledBy<TPolicyViolationHandler>() where TPolicyViolationHandler : class, IPolicyViolationHandler
        {
            ViolationConfigurationExpression.AddConvention(new PredicateToPolicyViolationHandlerTypeConvention<TPolicyViolationHandler>(Predicate));
        }

        public void IsHandledBy<TPolicyViolationHandler>(Func<TPolicyViolationHandler> policyViolationHandlerFactory) where TPolicyViolationHandler : class, IPolicyViolationHandler
        {
            ViolationConfigurationExpression.AddConvention(new PredicateToPolicyViolationHandlerInstanceConvention<TPolicyViolationHandler>(policyViolationHandlerFactory, Predicate));
        }
    }

    public abstract class ViolationHandlerExpressionBase
    {
        public ViolationConfigurationExpression ViolationConfigurationExpression { get; private set; }

        internal ViolationHandlerExpressionBase(ViolationConfigurationExpression violationConfigurationExpression)
        {
            if (violationConfigurationExpression == null) throw new ArgumentNullException("violationConfigurationExpression");
            ViolationConfigurationExpression = violationConfigurationExpression;
        }
    }
}