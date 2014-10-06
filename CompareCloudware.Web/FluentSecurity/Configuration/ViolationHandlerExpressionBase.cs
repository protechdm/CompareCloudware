namespace CompareCloudware.Web.FluentSecurity.Configuration
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class ViolationHandlerExpressionBase
    {
        internal ViolationHandlerExpressionBase(CompareCloudware.Web.FluentSecurity.Configuration.ViolationConfigurationExpression violationConfigurationExpression)
        {
            if (violationConfigurationExpression == null)
            {
                throw new ArgumentNullException("violationConfigurationExpression");
            }
            this.ViolationConfigurationExpression = violationConfigurationExpression;
        }

        public CompareCloudware.Web.FluentSecurity.Configuration.ViolationConfigurationExpression ViolationConfigurationExpression { get; private set; }
    }
}

