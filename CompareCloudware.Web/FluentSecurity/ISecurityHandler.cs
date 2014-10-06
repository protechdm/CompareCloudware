using System.Web.Mvc;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface ISecurityHandler
    {
        ActionResult HandleSecurityFor(string controllerName, string actionName, ISecurityContext securityContext);
    }
}