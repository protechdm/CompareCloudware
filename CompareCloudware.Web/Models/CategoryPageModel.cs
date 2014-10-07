using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
namespace CompareCloudware.Web.Models
{
    public class CategoryPageModel : BaseModel
    {
        public CategoryPageModel()
        {
        }

        public CategoryPageModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public CategoryPageModel(ICustomSession session, ContentPageModel cp)
        {
            base.CustomSession = session;
            base.SetMetaData(cp);
        }

        public CompareCloudware.Web.Models.SearchInputModel SearchInputModel { get; set; }
        public CompareCloudware.Web.Models.TabbedSearchResultsModel TabbedSearchResultsModel { get; set; }
        public ContentTextsModel ContentTextsModel { get; set; }

        public bool ShowConfirmationDialog { get; set; }
        public string ConfirmationDialogTitle { get; set; }
        public string ConfirmationDialogMessage1 { get; set; }
        public string ConfirmationDialogMessage2 { get; set; }

        public int MPUAdvertisingImageID1 { get; set; }
        public int MPUAdvertisingImageID2 { get; set; }

        public int MPUCloudApplicationID1 { get; set; }
        public int MPUCloudApplicationID2 { get; set; }

        public string MPUAdvertisingImageCategoryTag1 { get; set; }
        public string MPUAdvertisingImageCategoryTag2 { get; set; }

        public string MPUAdvertisingImageShopTag1 { get; set; }
        public string MPUAdvertisingImageShopTag2 { get; set; }

        public CarouselModel Carousel { get; set; }
        public ContentTextsModel H1H2ContentText { get; set; }

        public CompareCloudware.Web.Models.TabbedOnpageOptimisationModel TabbedOnpageOptimisationModel { get; set; }

    }
}

