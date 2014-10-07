using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class CloudApplicationAutoCompleteModel : BaseModel
    {
        public CloudApplicationAutoCompleteModel()
        {
        }

        public CloudApplicationAutoCompleteModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        //public DateTime? AddDate { get; set; }
        //public int ApplicationContentStatusID { get; set; }
        //public decimal ApplicationCostOneOff { get; set; }
        //public decimal ApplicationCostPerAnnum { get; set; }
        //public decimal ApplicationCostPerMonth { get; set; }
        //public string ApplicationCostPerMonthExtra { get; set; }
        //public int ApprovalAssignedPersonID { get; set; }
        //public int ApprovalStatusID { get; set; }
        //public decimal AverageEaseOfUse { get; set; }
        //public decimal AverageFunctionality { get; set; }
        //public decimal AverageOverallRating { get; set; }
        //public decimal AverageValueForMoney { get; set; }
        //public string Brand { get; set; }
        //public List<BrowserModel> Browsers { get; set; }
        //public decimal CallsPackageCostPerMonth { get; set; }
        public CategoryModel Category { get; set; }

        //public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        //public List<LanguageModel> Languages { get; set; }
        //public List<OperatingSystemModel> OperatingSystems { get; set; }
        //public List<SupportTypeModel> SupportTypes { get; set; }

        //[Display(Name="Buy now"), DataType(DataType.Text)]
        public int CloudApplicationID { get; set; }
        //public byte[] CloudApplicationLogo { get; set; }
        //public string CompanyURL { get; set; }
        //public string Description { get; set; }
        //public long FacebookFollowers { get; set; }
        //public string FacebookURL { get; set; }
        //public FreeTrialBuyNowModel FreeTrialBuyNow { get; set; }
        //public FreeTrialPeriodModel FreeTrialPeriod { get; set; }
        //public bool IsPromotional { get; set; }
        //public LicenceTypeMaximumModel LicenceTypeMaximum { get; set; }
        //public LicenceTypeMinimumModel LicenceTypeMinimum { get; set; }
        //public long LinkedInFollowers { get; set; }
        //public string LinkedInURL { get; set; }
        //public int MaximumMeetingAttendees { get; set; }
        //public int MaximumWebinarAttendees { get; set; }
        //public MinimumContractModel MinimumContract { get; set; }
        //public List<MobilePlatformModel> MobilePlatforms { get; set; }
        //public PaymentFrequencyModel PaymentFrequency { get; set; }
        //public List<PaymentOptionModel> PaymentOptions { get; set; }
        //public List<CloudApplicationRatingModel> Ratings { get; set; }
        //public List<CloudApplicationReviewModel> Reviews { get; set; }
        //public virtual byte[] RowVersion { get; set; }
        //public CloudApplicationSearchResultModel CloudApplicationSearchResultModel { get; set; }
        public string ServiceName { get; set; }
        //public SetupFeeModel SetupFee { get; set; }
        //public SupportDaysModel SupportDays { get; set; }
        //public SupportHoursModel SupportHours { get; set; }
        //public List<SupportTerritoryModel> SupportTerritories { get; set; }
        //public List<ThumbnailDocumentModel> ThumbnailDocuments { get; set; }
        public string Title { get; set; }
        //public long TwitterFollowers { get; set; }
        //public string TwitterURL { get; set; }
        public VendorModel Vendor { get; set; }
        //public bool VideoTrainingSupport { get; set; }
        //public List<CloudApplicationModelAlternative> CloudApplicationModelAlternatives { get; set; }

        //public CloudApplicationRatingModel CloudApplicationRatingModel { get; set; }

        public string CategoryTag { get; set; }
        public string ShopTag { get; set; }
        public string ShopTagURL { get; set; }

    }
}

