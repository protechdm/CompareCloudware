using System;
using CompareCloudware.Web.FluentSecurity.Policy;
using CompareCloudware.Web.FluentSecurity.Caching;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IConventionPolicyContainer
    {
        IConventionPolicyContainer AddPolicy(ISecurityPolicy securityPolicy);
        IConventionPolicyContainer AddPolicy<TSecurityPolicy>() where TSecurityPolicy : ISecurityPolicy;
        IConventionPolicyContainer RemovePolicy<TSecurityPolicy>(Func<TSecurityPolicy, bool> predicate = null) where TSecurityPolicy : class, ISecurityPolicy;
        IConventionPolicyContainer Cache<TSecurityPolicy>(Cache lifecycle) where TSecurityPolicy : ISecurityPolicy;
        IConventionPolicyContainer Cache<TSecurityPolicy>(Cache lifecycle, By level) where TSecurityPolicy : ISecurityPolicy;
        IConventionPolicyContainer ClearCacheStrategies();
        IConventionPolicyContainer ClearCacheStrategiesFor<TSecurityPolicy>() where TSecurityPolicy : ISecurityPolicy;
    }
}