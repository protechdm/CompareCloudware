using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class SearchPageContainerModel : BaseModel
    {
        public SearchPageContainerModel()
        {
            this.SearchFiltersModel = new SearchFiltersModel();
            this.SearchResultsModel = new SearchResultsModel();
            this.ChosenCloudApplicationModel = new CloudApplicationModel();
            this.Test = "SEARCHPAGECONTAINERMODEL";
        }

        public SearchPageContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchFiltersModel = new SearchFiltersModel(session);
            this.SearchResultsModel = new SearchResultsModel(session);
            this.ChosenCloudApplicationModel = new CloudApplicationModel(session);
            this.Test = "SEARCHPAGECONTAINERMODEL";
        }

        public CloudApplicationModel ChosenCloudApplicationModel { get; set; }

        public SearchFiltersModel SearchFiltersModel { get; set; }
        //public SearchFiltersModelTwoColumn SearchFiltersModelTwoColumn { get; set; }

        public SearchResultsModel SearchResultsModel { get; set; }
        //public SearchResultsModelOneColumn SearchResultsModelOneColumn { get; set; }

        public string Test { get; set; }
    }
}

