namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class GlobalSearchPageModel : BaseModel
    {
        public GlobalSearchPageModel()
        {
            this.ContainerModel = new GlobalSearchPageContainerModel();
        }

        public GlobalSearchPageModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.ContainerModel = new GlobalSearchPageContainerModel();
        }

        public GlobalSearchPageContainerModel ContainerModel { get; set; }

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

