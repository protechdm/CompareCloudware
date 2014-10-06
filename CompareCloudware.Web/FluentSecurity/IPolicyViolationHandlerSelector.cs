namespace CompareCloudware.Web.FluentSecurity
{
    public interface IPolicyViolationHandlerSelector
    {
        IPolicyViolationHandler FindHandlerFor(PolicyViolationException exception);
    }
}

