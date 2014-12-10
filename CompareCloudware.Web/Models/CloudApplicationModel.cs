using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using EntityFramework;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class CloudApplicationModel : BaseModel
    {
        public CloudApplicationModel()
        {
        }

        public CloudApplicationModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public DateTime? AddDate { get; set; }
        public int ApplicationContentStatusID { get; set; }
        [Display(Name = "One-off cost:")]
        public decimal ApplicationCostOneOff { get; set; }
        [Display(Name = "Cost per annum:")]
        public decimal ApplicationCostPerAnnum { get; set; }
        [Display(Name = "Cost per month:")]
        public decimal ApplicationCostPerMonth { get; set; }
        [Display(Name = "Extra cost:"), MaxLength(5)]
        public string ApplicationCostPerMonthExtra { get; set; }
        public int ApprovalAssignedPersonID { get; set; }
        public int ApprovalStatusID { get; set; }
        public decimal AverageEaseOfUse { get; set; }
        public decimal AverageFunctionality { get; set; }
        public decimal AverageOverallRating { get; set; }
        public decimal AverageValueForMoney { get; set; }
        //[Display(Name = "Brand:"), MaxLength(5)]
        public string Brand { get; set; }
        public List<BrowserModel> Browsers { get; set; }
        [Display(Name = "Calls package cost per month:")]
        public decimal CallsPackageCostPerMonth { get; set; }
        public CategoryModel Category { get; set; }

        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        public List<CloudApplicationApplicationModel> CloudApplicationApplications { get; set; }
        public List<LanguageModel> Languages { get; set; }
        public List<OperatingSystemModel> OperatingSystems { get; set; }
        public List<SupportTypeModel> SupportTypes { get; set; }

        [Display(Name="Buy now"), DataType(DataType.Text)]
        public int CloudApplicationID { get; set; }
        public byte[] CloudApplicationLogo { get; set; }
        //[Display(Name = "Company URL:"), MaxLength(5)]
        public string CompanyURL { get; set; }
        //[Display(Name = "Service overview:"), MaxLength(5)]
        public string Description { get; set; }
        public FreeTrialBuyNowModel FreeTrialBuyNow { get; set; }
        public FreeTrialPeriodModel FreeTrialPeriod { get; set; }
        public bool IsPromotional { get; set; }
        [Display(Name = "Maximum Users:")]
        public LicenceTypeMaximumModel LicenceTypeMaximum { get; set; }
        [Display(Name = "Minimum Users:")]
        public LicenceTypeMinimumModel LicenceTypeMinimum { get; set; }
        public int MaximumMeetingAttendees { get; set; }
        public int MaximumWebinarAttendees { get; set; }
        [Display(Name = "Minimum contract:")]
        public MinimumContractModel MinimumContract { get; set; }
        [Display(Name = "Mobile platforms:")]
        public List<MobilePlatformModel> MobilePlatforms { get; set; }
        [Display(Name = "Payment frequency:")]
        public PaymentFrequencyModel PaymentFrequency { get; set; }
        [Display(Name = "Payment options:")]
        public List<PaymentOptionModel> PaymentOptions { get; set; }
        [Display(Name = "Ratings:")]
        public List<CloudApplicationUserReviewModel> CloudApplicationUserReviews { get; set; }
        [Display(Name = "Reviews:")]
        public List<CloudApplicationProductReviewModel> CloudApplicationProductReviews { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public CloudApplicationSearchResultShopModel CloudApplicationSearchResultModel { get; set; }
        //[Display(Name = "Service name:"), MaxLength(5)]
        public string ServiceName { get; set; }
        [Display(Name = "Setup fee:"), MaxLength(5)]
        public SetupFeeModel SetupFee { get; set; }
        [Display(Name = "Support days:")]
        public SupportDaysModel SupportDays { get; set; }
        [Display(Name = "Support hours:")]
        public SupportHoursModel SupportHours { get; set; }
        [Display(Name = "Customer service locations:")]
        public List<SupportTerritoryModel> SupportTerritories { get; set; }
        [Display(Name = "Documents:")]
        public List<CloudApplicationDocumentModel> CloudApplicationDocuments { get; set; }
        //[Display(Name = "Service title:"), MaxLength(5)]
        public string Title { get; set; }
        
        
        [Display(Name = "Twitter followers:")]
        public long TwitterFollowers { get; set; }
        [Display(Name = "Twitter URL:"), MaxLength(50)]
        public string TwitterURL { get; set; }
        [Display(Name = "Twitter Name:"), MaxLength(50)]
        public string TwitterName { get; set; }
        [Display(Name = "LinkedIn Followers:")]
        public long LinkedInFollowers { get; set; }
        [Display(Name = "LinkedIn URL:"), MaxLength(50)]
        public string LinkedInURL { get; set; }
        [Display(Name = "LinkedIn ID:"), MaxLength(50)]
        public string LinkedInCompanyID { get; set; }
        [Display(Name = "Facebook followers:")]
        public long FacebookFollowers { get; set; }
        [Display(Name = "Facebook URL:"), MaxLength(5)]
        public string FacebookURL { get; set; }
        [Display(Name = "Facebook Name:"), MaxLength(50)]
        public string FacebookName { get; set; }
        
        
        
        public VendorModel Vendor { get; set; }
        [Display(Name = "Video training & support:")]
        public bool VideoTrainingSupport { get; set; }
        public List<CloudApplicationModelAlternative> CloudApplicationModelAlternatives { get; set; }

        public bool DemoOffered { get; set; }

        public CloudApplicationUserReviewModel CloudApplicationUserReviewModel { get; set; }

        [Display(Name = "Video:")]
        public List<CloudApplicationVideoModel> CloudApplicationVideos { get; set; }

        public string TryURL { get; set; }
        public string BuyURL { get; set; }

        public SocialShareModel SocialShareModel;
    }
}

