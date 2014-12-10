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

        public int MPUAdvertisingImageID1 { get; set; }
        public int MPUAdvertisingImageID2 { get; set; }

        public int MPUCloudApplicationID1 { get; set; }
        public int MPUCloudApplicationID2 { get; set; }

        public int SkyscraperAdvertisingImageID1 { get; set; }
        public int SkyscraperAdvertisingImageID2 { get; set; }

        public int SkyscraperCloudApplicationID1 { get; set; }
        public int SkyscraperCloudApplicationID2 { get; set; }

        public string MPUAdvertisingImageCategoryTag1 { get; set; }
        public string MPUAdvertisingImageCategoryTag2 { get; set; }

        public string MPUAdvertisingImageShopTag1 { get; set; }
        public string MPUAdvertisingImageShopTag2 { get; set; }

        public string SkyScraperAdvertisingImageCategoryTag1 { get; set; }
        public string SkyScraperAdvertisingImageCategoryTag2 { get; set; }

        public string SkyScraperAdvertisingImageShopTag1 { get; set; }
        public string SkyScraperAdvertisingImageShopTag2 { get; set; }

    }
}

