namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class SearchResultsModel : BaseModel
    {
        public SearchResultsModel()
        {
            this.SearchResultsModelOneColumn = new CompareCloudware.Web.Models.SearchResultsModelOneColumn();
        }

        public SearchResultsModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchResultsModelOneColumn = new CompareCloudware.Web.Models.SearchResultsModelOneColumn();
        }

        [Display(Name="Search Results")]
        public CompareCloudware.Web.Models.SearchResultsModelOneColumn SearchResultsModelOneColumn { get; set; }

        [Display(Name="Test Value")]
        public string TestValue { get; set; }

        public string CurrentSortOrder { get; set; }
    
    }
}

