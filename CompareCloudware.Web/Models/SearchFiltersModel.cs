namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class SearchFiltersModel : SearchFiltersModelBase
    {
        public SearchFiltersModel()
        {
            this.SearchFiltersModelOneColumn = new CompareCloudware.Web.Models.SearchFiltersModelOneColumn();
            this.SearchFiltersModelTwoColumn = new CompareCloudware.Web.Models.SearchFiltersModelTwoColumn();
        }

        public SearchFiltersModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchFiltersModelOneColumn = new CompareCloudware.Web.Models.SearchFiltersModelOneColumn();
            this.SearchFiltersModelTwoColumn = new CompareCloudware.Web.Models.SearchFiltersModelTwoColumn();
        }

        public bool DisplayAsSummary { get; set; }

        public CompareCloudware.Web.Models.SearchFiltersModelOneColumn SearchFiltersModelOneColumn { get; set; }

        public CompareCloudware.Web.Models.SearchFiltersModelTwoColumn SearchFiltersModelTwoColumn { get; set; }

        public int SearchResultsCount { get; set; }
    }
}

