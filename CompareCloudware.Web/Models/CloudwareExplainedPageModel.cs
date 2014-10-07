namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class CloudwareExplainedPageModel : BaseModel
    {
        public CloudwareExplainedPageModel()
        {
        }

        public CloudwareExplainedPageModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public CloudwareExplainedPageModel(ICustomSession session, ContentPageModel cp)
        {
            base.CustomSession = session;
            if (cp != null)
            {
                base.SetMetaData(cp);
            }
        }

        public ContentTextsModel ContentTextsModel { get; set; }

        public CarouselModel Carousel { get; set; }
        public ContentTextsModel H1H2ContentText { get; set; }

        public CompareCloudware.Web.Models.TabbedOnpageOptimisationModel TabbedOnpageOptimisationModel { get; set; }

        public CarouselModel CarouselSocial { get; set; }

        public CloudApplicationVideoModel Video { get; set; }

        public string CloudwareExplainedHeading { get; set; }

    }
}

