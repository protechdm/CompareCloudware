namespace CompareCloudware.Web.FluentSecurity.Policy
{
    using CompareCloudware.Web.FluentSecurity;
    using System;

    internal class LazySecurityPolicy<TSecurityPolicy> : ILazySecurityPolicy, ISecurityPolicy where TSecurityPolicy: ISecurityPolicy
    {
        public PolicyResult Enforce(ISecurityContext context)
        {
            ISecurityPolicy securityPolicy = this.Load();
            if (securityPolicy == null)
            {
                throw new InvalidOperationException(string.Format("A policy of type {0} could not be loaded! Make sure the policy has an empty constructor or is registered in your IoC-container.", this.PolicyType.FullName));
            }
            return securityPolicy.Enforce(context);
        }

        public ISecurityPolicy Load()
        {
            ISecurityServiceLocator externalServiceLocator = SecurityConfiguration.Current.ExternalServiceLocator;
            if (externalServiceLocator != null)
            {
                ISecurityPolicy securityPolicy = externalServiceLocator.Resolve(this.PolicyType) as ISecurityPolicy;
                if (securityPolicy != null)
                {
                    return securityPolicy;
                }
            }
            return (this.PolicyType.HasEmptyConstructor() ? ((ISecurityPolicy) Activator.CreateInstance<TSecurityPolicy>()) : null);
        }

        public Type PolicyType
        {
            get
            {
                return typeof(TSecurityPolicy);
            }
        }
    }
}

