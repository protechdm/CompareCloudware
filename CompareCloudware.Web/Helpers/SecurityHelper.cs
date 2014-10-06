namespace CompareCloudware.Web.Helpers
{
    using CompareCloudware.Web;
    using CompareCloudware.Web.FluentSecurity;
    using System;
    using System.Linq;
    using System.Web.Security;

    public static class SecurityHelper
    {
        public static bool ActionIsAllowedForUser(string controllerName, string actionName)
        {
            IPolicyContainer policyContainer = SecurityConfiguration.Current.PolicyContainers.GetContainerFor(controllerName, actionName);
            if (policyContainer != null)
            {
                ISecurityContext context = SecurityContext.Current;
                return policyContainer.EnforcePolicies(context).All<PolicyResult>(x => !x.ViolationOccured);
            }
            return true;
        }

        public static string[] Test()
        {
            string[] rolesArray = new string[Roles.GetRolesForUser().Count<string>()];
            int index = 0;
            foreach (string o in Roles.GetRolesForUser())
            {
                rolesArray[index] = o;
                index++;
            }
            return rolesArray;
        }

        public static bool UserIsAuthenticated()
        {
            return (Current.User != null);
        }

        public static object[] UserRoles()
        {
            if (Current.User != null)
            {
                return Test();
            }
            return null;
        }
    }
}

