namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;

    public interface IBaseModel
    {
        ICustomSession CustomSession { get; set; }
    }
}

