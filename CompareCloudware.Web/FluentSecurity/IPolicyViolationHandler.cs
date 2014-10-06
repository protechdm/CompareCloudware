namespace CompareCloudware.Web.FluentSecurity
{
    using System.Web.Mvc;

    public interface IPolicyViolationHandler
    {
        ActionResult Handle(PolicyViolationException exception);
    }
}

