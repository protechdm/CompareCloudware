namespace CompareCloudware.Web
{
    using CompareCloudware.Web.Controllers;
    using CompareCloudware.Web.FluentSecurity;
    using System;
    using System.Collections.Generic;

    public static class StaticSecurityBootstrapper
    {
        public static ISecurityConfiguration SetupFluentSecurity()
        {
            SecurityConfigurator.Configure(delegate (ConfigurationExpression configuration) {
                configuration.GetAuthenticationStatusFrom(new Func<bool>(SecurityHelper.UserIsAuthenticated));
                configuration.GetRolesFrom(new Func<IEnumerable<object>>(SecurityHelper.UserRoles));
                configuration.ResolveServicesUsing(delegate (Type type) {
                    List<object> results = new List<object>();
                    if (type == typeof(IPolicyViolationHandler))
                    {
                        results.Add(new DefaultPolicyViolationHandler());
                    }
                    return results;
                }, null);
                configuration.For<HomeController>().Ignore();
                configuration.For<AccountController>(ac => ac.LogOn()).DenyAnonymousAccess();
                configuration.For<AccountController>(x => x.LogInAsAdministrator()).DenyAuthenticatedAccess();
                configuration.For<AccountController>(x => x.LogInAsPublisher()).DenyAuthenticatedAccess();
            });
            return SecurityConfiguration.Current;
        }
    }
}

