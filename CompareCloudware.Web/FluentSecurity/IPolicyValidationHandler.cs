using System.Web.Mvc;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IPolicyViolationHandler
    {
        ActionResult Handle(PolicyViolationException exception);
    }
}