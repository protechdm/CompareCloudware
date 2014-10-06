namespace CompareCloudware.Web.FluentSecurity.Configuration
{
    using CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions;
    using System;

    public class ViolationHandlerExpression<TSecurityPolicy> : ViolationHandlerExpressionBase where TSecurityPolicy: class, ISecurityPolicy
    {
        internal ViolationHandlerExpression(ViolationConfigurationExpression violationConfigurationExpression) : base(violationConfigurationExpression)
        {
        }

        public void IsHandledBy<TPolicyViolationHandler>() where TPolicyViolationHandler: class, IPolicyViolationHandler
        {
            base.ViolationConfigurationExpression.AddConvention(new PolicyTypeToPolicyViolationHandlerTypeConvention<TSecurityPolicy, TPolicyViolationHandler>());
        }

        public void IsHandledBy<TPolicyViolationHandler>(Func<TPolicyViolationHandler> policyViolationHandlerFactory) where TPolicyViolationHandler: class, IPolicyViolationHandler
        {
            base.ViolationConfigurationExpression.AddConvention(new PolicyTypeToPolicyViolationHandlerInstanceConvention<TSecurityPolicy, TPolicyViolationHandler>(policyViolationHandlerFactory));
        }
    }
}

