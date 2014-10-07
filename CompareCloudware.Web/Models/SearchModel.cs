namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class SearchModel : BaseModel
    {
        public SearchModel()
        {
            this.SearchFiltersModelOneColumn = new CompareCloudware.Web.Models.SearchFiltersModelOneColumn();
            this.SearchFiltersModelTwoColumn = new CompareCloudware.Web.Models.SearchFiltersModelTwoColumn();
            this.SearchResultsModel = new CompareCloudware.Web.Models.SearchResultsModel();
        }

        public SearchModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchFiltersModelOneColumn = new CompareCloudware.Web.Models.SearchFiltersModelOneColumn(session);
            this.SearchFiltersModelTwoColumn = new CompareCloudware.Web.Models.SearchFiltersModelTwoColumn(session);
            this.SearchResultsModel = new CompareCloudware.Web.Models.SearchResultsModel(session);
        }

        public bool DisplayAsSummary { get; set; }

        public CompareCloudware.Web.Models.SearchFiltersModelOneColumn SearchFiltersModelOneColumn { get; set; }

        public CompareCloudware.Web.Models.SearchFiltersModelTwoColumn SearchFiltersModelTwoColumn { get; set; }

        public CompareCloudware.Web.Models.SearchResultsModel SearchResultsModel { get; set; }
    }
}

