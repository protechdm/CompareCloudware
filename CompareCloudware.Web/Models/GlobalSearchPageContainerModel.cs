using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class GlobalSearchPageContainerModel : BaseModel
    {
        public GlobalSearchPageContainerModel()
        {
            this.SearchResultsModel = new GlobalSearchResultsModel();
            this.ChosenCloudApplicationModel = new CloudApplicationModel();
        }

        public GlobalSearchPageContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.SearchResultsModel = new GlobalSearchResultsModel(session);
            this.ChosenCloudApplicationModel = new CloudApplicationModel(session);
        }

        public CloudApplicationModel ChosenCloudApplicationModel { get; set; }
        public GlobalSearchResultsModel SearchResultsModel { get; set; }
    }
}

