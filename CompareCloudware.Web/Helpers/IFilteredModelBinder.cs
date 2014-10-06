namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Web.Mvc;

    public interface IFilteredModelBinder : IModelBinder
    {
        bool IsMatch(Type modelType);
    }
}

