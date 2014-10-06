using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Policy;
using CompareCloudware.Web.FluentSecurity.Caching;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IPolicyContainer
    {
        string ControllerName { get; }
        string ActionName { get; }
        IPolicyAppender PolicyAppender { get; }
        IPolicyContainer AddPolicy(ISecurityPolicy securityPolicy);
        IPolicyContainer AddPolicy<TSecurityPolicy>() where TSecurityPolicy : ISecurityPolicy;
        IPolicyContainer RemovePolicy<TSecurityPolicy>(Func<TSecurityPolicy, bool> predicate = null) where TSecurityPolicy : class, ISecurityPolicy;
        IPolicyContainer Cache<TSecurityPolicy>(Cache lifecycle) where TSecurityPolicy : ISecurityPolicy;
        IPolicyContainer Cache<TSecurityPolicy>(Cache lifecycle, By level) where TSecurityPolicy : ISecurityPolicy;
        IPolicyContainer ClearCacheStrategies();
        IPolicyContainer ClearCacheStrategyFor<TSecurityPolicy>() where TSecurityPolicy : ISecurityPolicy;
        IEnumerable<ISecurityPolicy> GetPolicies();
        IEnumerable<PolicyResult> EnforcePolicies(ISecurityContext context);
    }
}