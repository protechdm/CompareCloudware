namespace CompareCloudware.Web
{
    using CompareCloudware.Web.FluentSecurity;
    using System;
    using System.Web.Mvc;

    public class DefaultPolicyViolationHandler : IPolicyViolationHandler
    {
        public string ViewName = "AccessDenied";

        public ActionResult Handle(PolicyViolationException exception)
        {
            return new ViewResult { ViewName = this.ViewName };
        }
    }
}

