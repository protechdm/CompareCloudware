namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class SearchPageModel : BaseModel
    {
        public SearchPageModel()
        {
            this.ContainerModel = new SearchPageContainerModel();
        }

        public SearchPageModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.ContainerModel = new SearchPageContainerModel();
        }

        public SearchPageContainerModel ContainerModel { get; set; }

        public bool ShowConfirmationDialog { get; set; }
        public string ConfirmationDialogTitle { get; set; }
        public string ConfirmationDialogMessage1 { get; set; }
        public string ConfirmationDialogMessage2 { get; set; }
        public string MonthlyPriceColumnHeader { get; set; }
        public string AnnualPriceColumnHeader { get; set; }

        public string CloudwareProviderColumnHeader { get; set; }
        public string SetupFeeColumnHeader { get; set; }
        public string FreeTrialColumnHeader { get; set; }

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

