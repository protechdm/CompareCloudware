namespace CompareCloudware.Web.FluentSecurity
{
    using System;
    using System.Web.Mvc;

    public class ExceptionPolicyViolationHandler : IPolicyViolationHandler
    {
        public ActionResult Handle(PolicyViolationException exception)
        {
            throw exception;
        }
    }
}

