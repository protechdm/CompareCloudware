namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class GlobalSearchResultsModel : BaseModel
    {
        public GlobalSearchResultsModel()
        {
            this.SearchResultsModelOneColumn = new CompareCloudware.Web.Models.GlobalSearchResultsModelOneColumn();
        }

        public GlobalSearchResultsModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchResultsModelOneColumn = new CompareCloudware.Web.Models.GlobalSearchResultsModelOneColumn();
        }

        [Display(Name="Search Results")]
        public CompareCloudware.Web.Models.GlobalSearchResultsModelOneColumn SearchResultsModelOneColumn { get; set; }

        [Display(Name="Test Value")]
        public string TestValue { get; set; }

        public string Term { get; set; }

    }
}

