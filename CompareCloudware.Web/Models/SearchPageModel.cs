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


    }
}

