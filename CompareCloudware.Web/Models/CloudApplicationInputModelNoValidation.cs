using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace CompareCloudware.Web.Models
{
    public class CloudApplicationInputModelNoValidation 
    {
        //public CloudApplicationInputModel()
        //{
        //}

        //public CloudApplicationInputModel(ICustomSession session)
        //{
        //    base.CustomSession = session;
        //    Categories = new SelectListItemCollection();
        //    Devices = new SelectListItemCollection();
        //    MobilePlatforms = new SelectListItemCollection();
        //    OperatingSystems = new SelectListItemCollection();
        //    Browsers = new SelectListItemCollection();
        //    Languages = new SelectListItemCollection();
        //    SupportTypes = new SelectListItemCollectionSupportTypes();
        //    SupportHours = new SelectListItemCollection();
        //    SupportHoursFrom = new SelectListItemCollection();
        //    SupportHoursTo = new SelectListItemCollection();
        //    SupportDays = new SelectListItemCollection();
        //    NumberOfSupportDays = new SelectListItemCollection();
        //    SupportTerritories = new SelectListItemCollection();
        //    PaymentOptions = new SelectListItemCollection();
        //    LicenceTypeMinimum = new SelectListItemCollection();
        //    LicenceTypeMaximum = new SelectListItemCollection();
        //    FreeTrialPeriods = new SelectListItemCollection();
        //    MinimumContracts = new SelectListItemCollection();
        //    PaymentFrequencies = new SelectListItemCollection();
        //    Features = new SelectListItemCollectionFeatures();
        //    Applications = new SelectListItemCollectionFeatures();
        //    //VideoExtensions = new SelectListItemCollection();
        //    //VideoDomains = new SelectListItemCollection();
        //    CloudApplicationProductReviews = new List<CloudApplicationProductReviewModel>();
        //    CloudApplicationVideos = new List<CloudApplicationVideoModel>();
        //    Vendor = new VendorModel();
        //    //CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
        //    CloudApplicationUserReviewsContainerModel = new CloudApplicationUserReviewsContainerModel();
        //    CloudApplicationDocuments = new List<CloudApplicationDocumentModel>();

        //    Currency = new SelectListItemCollection();
        //    Timezone = new SelectListItemCollection();
        //    Statuses = new SelectListItemCollection();
        
        //}

        public int CloudApplicationID { get; set; }
        ////public bool AddMode { get; set; }
        ////public bool EditMode { get; set; }

        //[Display(Name = "Added:")]
        //public DateTime? AddDate { get; set; }
        //[Display(Name = "Last Updated:")]
        //public DateTime? LastUpdateDate { get; set; }
        ////public int ApplicationContentStatusID { get; set; }
        ////public decimal ApplicationCostOneOff { get; set; }
        ////public decimal ApplicationCostPerAnnum { get; set; }
        ////public decimal ApplicationCostPerMonth { get; set; }
        ////public string ApplicationCostPerMonthExtra { get; set; }
        ////public int ApprovalAssignedPersonID { get; set; }
        ////public int ApprovalStatusID { get; set; }
        ////public decimal AverageEaseOfUse { get; set; }
        ////public decimal AverageFunctionality { get; set; }
        ////public decimal AverageOverallRating { get; set; }
        ////public decimal AverageValueForMoney { get; set; }
        ////public string Brand { get; set; }
        ////public List<BrowserModel> Browsers { get; set; }
        ////public decimal CallsPackageCostPerMonth { get; set; }
        ////public CategoryModel Category { get; set; }

        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection Categories { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection Devices { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection MobilePlatforms { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection OperatingSystems { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection Browsers { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection Languages { get; set; }
        //[UIHint("CustomCheckBoxListSupportTypes")]
        //public SelectListItemCollectionSupportTypes SupportTypes { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection SupportHours { get; set; }

        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection SupportHoursFrom { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection SupportHoursTo { get; set; }
        
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection SupportDays { get; set; }
        //[Display(Name = "Number Of Days")]
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection NumberOfSupportDays { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection SupportTerritories { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection PaymentOptions { get; set; }
        
        //[UIHint("CustomCheckBoxList")]
        //[Display(Name = "Minimum Users:")]
        //public SelectListItemCollection LicenceTypeMinimum { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //[Display(Name = "Maximum Users:")]
        //public SelectListItemCollection LicenceTypeMaximum { get; set; }
        //[Display(Name = "Other:")]
        //public string LicenceTypeMinimumOther { get; set; }
        //[Display(Name = "Other:")]
        //public string LicenceTypeMaximumOther { get; set; }
        
        
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection FreeTrialPeriods { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection MinimumContracts { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //public SelectListItemCollection PaymentFrequencies { get; set; }
        //[UIHint("CustomCheckBoxListFeatures")]
        //public SelectListItemCollectionFeatures Features { get; set; }
        //[UIHint("CustomCheckBoxListFeatures")]
        //public SelectListItemCollectionFeatures Applications { get; set; }
        ////[UIHint("CustomRadioButtonList")]
        ////public SelectListItemCollection VideoExtensions { get; set; }
        ////[UIHint("CustomRadioButtonList")]
        ////public SelectListItemCollection VideoDomains { get; set; }

        //[Display(Name = "Setup fee:"), Range(0,999)]
        //public int SetupFeeWhole { get; set; }
        //[Display(Name = "."), Range(0, 99)]
        //public int SetupFeeFraction { get; set; }
        //[Display(Name = "POA")]
        //public bool SetupFeeIsPOA { get; set; }
        //[Display(Name = "No")]
        //public bool NoSetupFee { get; set; }

        //#region Costs
        //[Display(Name = "Cost per month:"), Range(0,999,ErrorMessage="Cost per month units must be a value between 0 and 999")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthWhole { get; set; }
        //[Display(Name = "."), Range(0,99,ErrorMessage="Cost per month units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthFraction { get; set; }

        //[Display(Name = "From:"), Range(0,999,ErrorMessage="Cost per month 'from' units must be a value between 0 and 999")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthFromWhole { get; set; }
        //[Display(Name = "."), Range(0,99,ErrorMessage="Cost per month 'from' units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthFromFraction { get; set; }

        //[Display(Name = "To:"), Range(0,999,ErrorMessage="Cost per month 'to' units must be a value between 0 and 999")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthToWhole { get; set; }
        //[Display(Name = "."), Range(0, 99,ErrorMessage="Cost per month 'to' units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per month units is required")]
        //public int ApplicationCostPerMonthToFraction { get; set; }

        //[Display(Name = "Extra info:"), StringLength(50,ErrorMessage="The extra info for monthly cost is a maximum of 50 characters")]
        //public string ApplicationCostPerMonthSuffix { get; set; }
        //[Display(Name = "Cost per month POA:")]
        //public bool ApplicationCostPerMonthPOA { get; set; }
        //[Display(Name = "Cost per month offered:")]
        //public bool ApplicationCostPerMonthOffered { get; set; }
        //[Display(Name = "Cost per month free:")]
        //public bool ApplicationCostPerMonthFree { get; set; }
        //[Display(Name = "Cost per month available:")]
        //public bool ApplicationCostPerMonthAvailable { get; set; }
        //[Display(Name = "Cost per month for unlimited users:")]
        //public bool ApplicationCostPerMonthIsForUnlimitedUsers { get; set; }


        //[Display(Name = "Cost per annum:"), Range(0,999,ErrorMessage="Cost per annum units must be a value between 0 and 999")]
        //[Required(ErrorMessage="Cost per annum units is required")]
        //public int ApplicationCostPerAnnumWhole { get; set; }
        //[Display(Name = "."), Range(0, 99,ErrorMessage="Cost per annum units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per annum units is required")]
        //public int ApplicationCostPerAnnumFraction { get; set; }

        //[Display(Name = "From:"), Range(0,999,ErrorMessage="Cost per annum 'from' units must be a value between 0 and 999")]
        //[Required(ErrorMessage = "Cost per annum units is required")]
        //public int ApplicationCostPerAnnumFromWhole { get; set; }
        //[Display(Name = "."), Range(0, 99,ErrorMessage="Cost per annum 'from' units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per annum units is required")]
        //public int ApplicationCostPerAnnumFromFraction { get; set; }

        //[Display(Name = "To:"), Range(0,999,ErrorMessage="Cost per annum 'to' units must be a value between 0 and 999")]
        //[Required(ErrorMessage = "Cost per annum units is required")]
        //public int ApplicationCostPerAnnumToWhole { get; set; }
        //[Display(Name = "."), Range(0, 99,ErrorMessage="Cost per annum 'to' units must be a value between 0 and 99")]
        //[Required(ErrorMessage = "Cost per annum units is required")]
        //public int ApplicationCostPerAnnumToFraction { get; set; }

        //[Display(Name = "Extra info:"), StringLength(50, ErrorMessage = "The extra info for annual cost is a maximum of 50 characters")]
        //public string ApplicationCostPerAnnumSuffix { get; set; }
        //[Display(Name = "Cost per annum POA:")]
        //public bool ApplicationCostPerAnnumPOA { get; set; }
        //[Display(Name = "Cost per annum offered:")]
        //public bool ApplicationCostPerAnnumOffered { get; set; }
        //[Display(Name = "Cost per annum free:")]
        //public bool ApplicationCostPerAnnumFree { get; set; }
        //[Display(Name = "Cost per annum available:")]
        //public bool ApplicationCostPerAnnumAvailable { get; set; }
        //[Display(Name = "Cost per annum for unlimited users:")]
        //public bool ApplicationCostPerAnnumIsForUnlimitedUsers { get; set; }

        //[Display(Name = "PAYG:")]
        //public bool PayAsYouGo { get; set; }

        //[Display(Name = "One-off cost?")]
        //public bool IsOneOffCost { get; set; }

        ////[Display(Name = "One-off cost:"), Range(0, 999)]
        ////public decimal ApplicationCostOneOff { get; set; }

        //[Display(Name = "One-off cost:"), Range(0, 999,ErrorMessage="One off cost units must be a value between 0 and 999")]
        //public int OneOffCostWhole { get; set; }
        //[Display(Name = "."), Range(0, 99,ErrorMessage="One off cost units must be a value between 0 and 99")]
        //public int OneOffCostFraction { get; set; }
        //#endregion

        //#region Crap
        ////public List<LanguageModel> Languages { get; set; }
        ////public List<OperatingSystemModel> OperatingSystems { get; set; }
        ////public List<SupportTypeModel> SupportTypes { get; set; }

        ////[Display(Name="Buy now"), DataType(DataType.Text)]
        ////public byte[] CloudApplicationLogo { get; set; }
        ////public string CompanyURL { get; set; }
        ////public string Description { get; set; }
        ////public long FacebookFollowers { get; set; }
        ////public string FacebookURL { get; set; }
        ////public FreeTrialBuyNowModel FreeTrialBuyNow { get; set; }
        ////public FreeTrialPeriodModel FreeTrialPeriod { get; set; }
        ////public bool IsPromotional { get; set; }
        ////public LicenceTypeMaximumModel LicenceTypeMaximum { get; set; }
        ////public LicenceTypeMinimumModel LicenceTypeMinimum { get; set; }
        ////public long LinkedInFollowers { get; set; }
        ////public string LinkedInURL { get; set; }
        ////public int MaximumMeetingAttendees { get; set; }
        ////public int MaximumWebinarAttendees { get; set; }
        ////public MinimumContractModel MinimumContract { get; set; }
        ////public List<MobilePlatformModel> MobilePlatforms { get; set; }
        ////public PaymentFrequencyModel PaymentFrequency { get; set; }
        ////public List<PaymentOptionModel> PaymentOptions { get; set; }
        ////public List<CloudApplicationRatingModel> Ratings { get; set; }
        ////public List<CloudApplicationReviewModel> Reviews { get; set; }
        ////public virtual byte[] RowVersion { get; set; }
        ////public CloudApplicationSearchResultModel CloudApplicationSearchResultModel { get; set; }
        ////public string ServiceName { get; set; }
        ////public SetupFeeModel SetupFee { get; set; }
        ////public SupportDaysModel SupportDays { get; set; }
        ////public SupportHoursModel SupportHours { get; set; }
        ////public List<SupportTerritoryModel> SupportTerritories { get; set; }
        ////public List<ThumbnailDocumentModel> ThumbnailDocuments { get; set; }
        ////public string Title { get; set; }
        ////public long TwitterFollowers { get; set; }
        ////public string TwitterURL { get; set; }
        ////public VendorModel Vendor { get; set; }
        ////public bool VideoTrainingSupport { get; set; }
        ////public List<CloudApplicationModelAlternative> CloudApplicationModelAlternatives { get; set; }

        ////public bool DemoOffered { get; set; }

        ////public CloudApplicationRatingModel CloudApplicationRatingModel { get; set; }

        ////public List<CloudApplicationVideoModel> Videos { get; set; }
        //#endregion

        //public VendorModel Vendor { get; set; }
        //[Display(Name = "Brand:"), StringLength(100,ErrorMessage="The company brand must be a maximum of 100 characters")]
        //public string Brand { get; set; }
        //[Display(Name = "Service name:"), StringLength(100, ErrorMessage = "The service name must be a maximum of 100 characters")]
        //[Required]
        //public string ServiceName { get; set; }
        //[Display(Name = "Video training & support:")]
        //public bool VideoTrainingSupport { get; set; }
        //public int ApprovalAssignedPersonID { get; set; }
        //public int ApprovalStatusID { get; set; }
        ////[Display(Name = "Calls package cost per month:"), MaxLength(5)]
        //public decimal CallsPackageCostPerMonth { get; set; }
        
        //public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        ////public List<CloudApplicationApplicationModel> CloudApplicationApplications { get; set; }
        
        //public byte[] CloudApplicationLogo { get; set; }
        //[Display(Name = "Company URL:"), StringLength(200,ErrorMessage="The URL must be a maximum of 200 characters")]
        //public string CompanyURL { get; set; }

        //[Display(Name = "Demo:")]
        //public bool DemoOffered { get; set; }

        //[Display(Name = "Service overview:"), StringLength(4000, ErrorMessage = "The service overview must be a maximum of 4000 characters")]
        //[Required]
        //public string Description { get; set; }
        //[Display(Name = "Video:")]
        public CloudApplicationVideosContainerModel CloudApplicationVideosContainerModel { get; set; }
        //[Display(Name = "Service title:"), StringLength(100,ErrorMessage="The service title must be a maximum of 100 characters")]
        //public string Title { get; set; }
        //[Display(Name = "Documents:")]
        //public List<CloudApplicationDocumentModel> CloudApplicationDocuments { get; set; }
        public CloudApplicationDocumentsContainerModel CloudApplicationDocumentsContainerModel { get; set; }
        //[Display(Name = "Reviews:")]
        //public List<CloudApplicationProductReviewModel> CloudApplicationProductReviews { get; set; }
        public CloudApplicationProductReviewsContainerModel CloudApplicationProductReviewsContainerModel { get; set; }
        ////[Display(Name = "Ratings:")]
        ////public List<CloudApplicationUserReviewModel> CloudApplicationUserReviews { get; set; }
        public CloudApplicationUserReviewsContainerModel CloudApplicationUserReviewsContainerModel { get; set; }
        ////[Display(Name = "Facebook Name:"), MaxLength(5)]
        //public int MaximumMeetingAttendees { get; set; }
        ////[Display(Name = "Facebook Name:"), MaxLength(5)]
        //public int MaximumWebinarAttendees { get; set; }
        //[Display(Name = "Options:"), MaxLength(50)]
        //public string Options { get; set; }

        //#region SOCIAL NETWORKING
        //[Display(Name = "Facebook followers:"), Range(0,99999999)]
        //public long FacebookFollowers { get; set; }
        //[Display(Name = "Facebook Name:"), StringLength(50, ErrorMessage = "The Facebook name must be a maximum of 50 characters")]
        //public string FacebookName { get; set; }
        //[Display(Name = "Facebook URL:"), StringLength(50, ErrorMessage = "The Facebook URL must be a maximum of 50 characters")]
        //public string FacebookURL { get; set; }

        //[Display(Name = "Twitter followers:"), Range(0,99999999)]
        //public long TwitterFollowers { get; set; }
        //[Display(Name = "Twitter Name:"), StringLength(50, ErrorMessage = "The Twitter name must be a maximum of 50 characters")]
        //public string TwitterName { get; set; }
        //[Display(Name = "Twitter URL:"), StringLength(50, ErrorMessage = "The Twitter URL must be a maximum of 50 characters")]
        //public string TwitterURL { get; set; }

        //[Display(Name = "LinkedIn Followers:"), Range(0,99999999)]
        //public long LinkedInFollowers { get; set; }
        //[Display(Name = "LinkedIn Company ID:"), Range(0,9999999)]
        //public int LinkedInCompanyID { get; set; }
        //[Display(Name = "LinkedIn URL:"), StringLength(50, ErrorMessage = "The LinkedIn URL must be a maximum of 50 characters")]
        //public string LinkedInURL { get; set; }

        //#endregion

        //public UploadImageModel UploadImageModel { get; set; }

        //public bool HasVideo { get; set; }

        //[UIHint("CustomCheckBoxList")]
        //[Display(Name = "Currency:")]
        //public SelectListItemCollection Currency { get; set; }
        //[UIHint("CustomCheckBoxList")]
        //[Display(Name = "Timezone:")]
        //public SelectListItemCollection Timezone { get; set; }


        //[Display(Name = "Try URL:"), MaxLength(255)]
        //public string TryURL { get; set; }
        //[Display(Name = "Buy URL:"), MaxLength(255)]
        //public string BuyURL { get; set; }

        //[UIHint("CustomCheckBoxList")]
        //[Display(Name = "Status:")]
        //public SelectListItemCollection Statuses { get; set; }
        //[Display(Name = "Apply to all vendor brands :")]
        //public bool ApplyStatusAtVendorLevel { get; set; }


        //[Display(Name = "Apply all product reviews to all vendor brands :")]
        //public bool ApplyProductReviewsAtVendorLevel { get; set; }

        //[Display(Name = "Apply all documents to all vendor brands :")]
        //public bool ApplyDocumentsAtVendorLevel { get; set; }

        //[Display(Name = "Apply all selected languages to all vendor brands :")]
        //public bool ApplyLanguagesAtVendorLevel { get; set; }

        //public bool ApplicationHasActiveSupport { get; set; }

        //public bool SocialNetworkingContainerCollapsed { get; set; }
        //public bool ProductReviewsContainerCollapsed { get; set; }
        //public bool UserReviewsContainerCollapsed { get; set; }
        //public bool DocumentsContainerCollapsed { get; set; }
        //public bool ApplicationLogoContainerCollapsed { get; set; }
        //public bool VideoContainerCollapsed { get; set; }
        //public bool FeaturesContainerCollapsed { get; set; }
        //public bool ApplicationCostsContainerCollapsed { get; set; }
        //public bool SupportDaysContainerCollapsed { get; set; }
        //public bool SupportHoursContainerCollapsed { get; set; }
        //public bool VendorMainDetailsContainerCollapsed { get; set; }
        //public bool CategoriesContainerCollapsed { get; set; }
        //public bool ServiceOverviewContainerCollapsed { get; set; }
        //public bool OperatingSystemsContainerCollapsed { get; set; }
        //public bool SupportTypesContainerCollapsed { get; set; }
        //public bool SupportTerritoriesContainerCollapsed { get; set; }
        //public bool MobilePlatformsContainerCollapsed { get; set; }
        //public bool BrowsersContainerCollapsed { get; set; }
        //public bool LanguagesContainerCollapsed { get; set; }
        //public bool LicenceTypeMinimumContainerCollapsed { get; set; }
        //public bool LicenceTypeMaximumContainerCollapsed { get; set; }
        //public bool VideoTrainingContainerCollapsed { get; set; }
        //public bool FreeTrialPeriodContainerCollapsed { get; set; }
        //public bool SetupFeeContainerCollapsed { get; set; }
        //public bool MinimumContractContainerCollapsed { get; set; }
        //public bool PaymentFrequencyContainerCollapsed { get; set; }
        //public bool PaymentOptionsContainerCollapsed { get; set; }
        //public bool ApplicationCurrencyContainerCollapsed { get; set; }
        //public bool TimezoneContainerCollapsed { get; set; }
        //public bool ApplicationsContainerCollapsed { get; set; }
    }
}

