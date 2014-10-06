using System.Web.Mvc;

namespace CompareCloudware.Web.FluentSecurity
{
    public class ExceptionPolicyViolationHandler : IPolicyViolationHandler
    {
        public ActionResult Handle(PolicyViolationException exception)
        {
            throw exception;
        }
    }
}