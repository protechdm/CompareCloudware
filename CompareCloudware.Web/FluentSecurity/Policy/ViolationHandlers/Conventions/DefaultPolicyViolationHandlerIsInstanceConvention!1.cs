namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    using System;

    public class DefaultPolicyViolationHandlerIsInstanceConvention<TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler: class, IPolicyViolationHandler
    {
        public DefaultPolicyViolationHandlerIsInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandler) : base(policyViolationHandler)
        {
        }
    }
}

