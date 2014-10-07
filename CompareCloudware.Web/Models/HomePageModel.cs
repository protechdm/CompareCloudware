namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class HomePageModel : BaseModel
    {
        public HomePageModel()
        {
        }

        public HomePageModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public HomePageModel(ICustomSession session, ContentPageModel cp)
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

        public CarouselModel Carousel { get; set; }
        public ContentTextsModel H1H2ContentText { get; set; }

        public CompareCloudware.Web.Models.TabbedOnpageOptimisationModel TabbedOnpageOptimisationModel { get; set; }

        public CarouselModel CarouselSocial { get; set; }

        public CloudApplicationVideoModel Video { get; set; }

    }
}

