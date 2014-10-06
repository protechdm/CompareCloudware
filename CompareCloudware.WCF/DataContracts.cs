using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CompareCloudware.WCF
{
    #region SearchPageModel
    [DataContract]
    public class SearchPageModel
    {
        //public SearchPageModel()
        //{
        //    this.SearchPageContainerModel = new SearchPageContainerModel();
        //}

        [DataMember]
        public SearchPageContainerModel ContainerModel { get; set; }
    }
    #endregion

    #region SearchPageContainerModel
    [DataContract]
    public class SearchPageContainerModel
    {
        //public SearchPageContainerModel()
        //{
        //    //this.SearchFiltersModel = new SearchFiltersModel();
        //    //this.SearchResultsModel = new SearchResultsModel();
        //    //this.ChosenCloudApplicationModel = new CloudApplicationModel();
        //    this.Test = "SEARCHPAGECONTAINERMODEL";
        //}

        //[DataMember]
        //public SearchFiltersModel SearchFiltersModel { get; set; }
        //[DataMember]
        //public SearchResultsModel SearchResultsModel { get; set; }
        //[DataMember]
        //public CloudApplicationModel ChosenCloudApplicationModel { get; set; }
        [DataMember]
        public string Test { get; set; }

    }
    #endregion

    #region SearchFiltersModel
    [DataContract]
    public class SearchFiltersModel
    {
        public SearchFiltersModel()
        {
            this.SearchFiltersModelOneColumn = new SearchFiltersModelOneColumn();
            this.SearchFiltersModelTwoColumn = new SearchFiltersModelTwoColumn();
        }

        [DataMember]
        public SearchFiltersModelOneColumn SearchFiltersModelOneColumn { get; set; }
        [DataMember]
        public SearchFiltersModelTwoColumn SearchFiltersModelTwoColumn { get; set; }

        [DataMember]
        public bool DisplayAsSummary { get; set; }
        [DataMember]
        public int SearchResultsCount { get; set; }

    }
    #endregion

    #region SearchResultsModel
    [DataContract]
    public class SearchResultsModel
    {
        public SearchResultsModel()
        {
            this.SearchResultsModelOneColumn = new SearchResultsModelOneColumn();
        }

        [DataMember]
        public SearchResultsModelOneColumn SearchResultsModelOneColumn { get; set; }

        [DataMember]
        public string TestValue { get; set; }

    }
    #endregion

    #region CloudApplicationModel
    [DataContract(IsReference = true)]
    public class CloudApplicationModel
    {
        public CloudApplicationModel() { }

        [DataMember]
        public SearchResultModelOneColumn SearchResultModel { get; set; }

        [DataMember]
        public int CloudApplicationID { get; set; }
        [DataMember]
        public VendorModel Vendor { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string CompanyURL { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public byte[] CloudApplicationLogo { get; set; }
        [DataMember]
        public bool IsPromotional { get; set; }
        [DataMember]
        public decimal ApplicationCostPerMonth { get; set; }
        [DataMember]
        public string ApplicationCostPerMonthExtra { get; set; }
        [DataMember]
        public decimal ApplicationCostPerAnnum { get; set; }
        [DataMember]
        public decimal ApplicationCostOneOff { get; set; }
        [DataMember]
        public decimal CallsPackageCostPerMonth { get; set; }
        [DataMember]
        public SetupFeeModel SetupFee { get; set; }
        //public string SetupFee { get; set; }
        [DataMember]
        public FreeTrialPeriodModel FreeTrialPeriod { get; set; }
        //public string FreeTrialPeriod { get; set; }
        //[DataMember]
        //public List<CompareCloudware.WCF.OperatingSystem> OperatingSystems { get; set; }
        [DataMember]
        public List<BrowserModel> Browsers { get; set; }
        [DataMember]
        public List<MobilePlatformModel> MobilePlatforms { get; set; }
        [DataMember]
        public LicenceTypeMinimumModel LicenceTypeMinimum { get; set; }
        [DataMember]
        public LicenceTypeMaximumModel LicenceTypeMaximum { get; set; }
        [DataMember]
        public List<SupportTypeModel> SupportTypes { get; set; }
        [DataMember]
        public SupportDaysModel SupportDays { get; set; }
        [DataMember]
        public SupportHoursModel SupportHours { get; set; }
        [DataMember]
        public List<SupportTerritoryModel> SupportTerritories { get; set; }
        [DataMember]
        public List<LanguageModel> Languages { get; set; }
        [DataMember]
        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        [DataMember]
        public List<ThumbnailDocumentModel> ThumbnailDocuments { get; set; }
        [DataMember]
        public string TwitterURL { get; set; }
        [DataMember]
        public string FacebookURL { get; set; }
        [DataMember]
        public string LinkedInURL { get; set; }
        [DataMember]
        public int TwitterFollowers { get; set; }
        [DataMember]
        public int FacebookFollowers { get; set; }
        [DataMember]
        public int LinkedInFollowers { get; set; }
        [DataMember]
        public decimal AverageOverallRating { get; set; }
        [DataMember]
        public decimal AverageEaseOfUse { get; set; }
        [DataMember]
        public decimal AverageValueForMoney { get; set; }
        [DataMember]
        public decimal AverageFunctionality { get; set; }

        [DataMember]
        public CategoryModel Category { get; set; }
        [DataMember]
        public DateTime? AddDate { get; set; }

        [DataMember]
        public MinimumContractModel MinimumContract { get; set; }
        [DataMember]
        public PaymentFrequencyModel PaymentFrequency { get; set; }
        [DataMember]
        public List<PaymentOptionModel> PaymentOptions { get; set; }

        [DataMember]
        public bool VideoTrainingSupport { get; set; }

        [DataMember]
        public int MaximumMeetingAttendees { get; set; }
        [DataMember]
        public int MaximumWebinarAttendees { get; set; }

        [DataMember]
        public int ApprovalAssignedPersonID { get; set; }
        [DataMember]
        public int ApplicationContentStatusID { get; set; }
        [DataMember]
        public int ApprovalStatusID { get; set; }

        [DataMember]
        public List<CloudApplicationReviewModel> Reviews { get; set; }
        [DataMember]
        public List<CloudApplicationRatingModel> Ratings { get; set; }

        [DataMember]
        public FreeTrialBuyNowModel FreeTrialBuyNow { get; set; }

        [DataMember]
        public virtual byte[] RowVersion { get; set; }

    }
    #endregion

    #region SearchFiltersModelOneColumn
    [DataContract]
    public class SearchFiltersModelOneColumn
    {
        public SearchFiltersModelOneColumn() { }

        [DataMember]
        public int? PreviouslyChosenCategoryID { get; set; }
        [DataMember]
        public int? ChosenCategoryID { get; set; }
        [DataMember]
        public IList<CategoryModel> Categories { get; set; }


        [DataMember]
        public int? ChosenNumberOfUsers { get; set; }
        [DataMember]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersBrowsers { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersFeatures { get; set; }

        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersOperatingSystems { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportTypes { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportDays { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportHours { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersLanguages { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersMobilePlatforms { get; set; }

        [DataMember]
        public IEnumerable<SearchResultModelOneColumn> SearchResults { get; set; }

        [DataMember]
        public string TestValue { get; set; }

    }
    #endregion

    #region SearchFiltersModelTwoColumn
    [DataContract]
    public class SearchFiltersModelTwoColumn
    {
        public SearchFiltersModelTwoColumn() { }

        [DataMember]
        public int? PreviouslyChosenCategoryID { get; set; }
        [DataMember]
        public int? ChosenCategoryID { get; set; }
        [DataMember]
        public IList<CategoryModel> Categories { get; set; }


        [DataMember]
        public int? ChosenNumberOfUsers { get; set; }
        [DataMember]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersBrowsers { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersFeatures { get; set; }

        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersOperatingSystems { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportTypes { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportDays { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportHours { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersLanguages { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersMobilePlatforms { get; set; }

        [DataMember]
        public string TestValue { get; set; }

    }
    #endregion

    #region SearchResultsModelOneColumn
    [DataContract]
    public class SearchResultsModelOneColumn
    {
        public SearchResultsModelOneColumn() { }

        [DataMember]
        public int? PreviouslyChosenCategoryID { get; set; }
        [DataMember]
        public int? ChosenCategoryID { get; set; }
        [DataMember]
        public IList<CategoryModel> Categories { get; set; }


        [DataMember]
        public int? ChosenNumberOfUsers { get; set; }
        [DataMember]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        [DataMember]
        public IEnumerable<SearchResultModelOneColumn> SearchResults { get; set; }
        [DataMember]
        public IEnumerable<SearchResultSummaryModel> SearchResultsSummary { get; set; }

        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersOperatingSystems { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportTypes { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportDays { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportHours { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersLanguages { get; set; }
        [DataMember]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersMobilePlatforms { get; set; }

        [DataMember]
        public bool DisplayAsSummary { get; set; }

        [DataMember]
        public string TestValue { get; set; }

    }
    #endregion

    #region SearchResultModelOneColumn
    [DataContract]
    public class SearchResultModelOneColumn
    {
        public SearchResultModelOneColumn() { }

        [DataMember]
        public int SearchResultID { get; set; }
        [DataMember]
        public bool IsLastInCollection { get; set; }


        [DataMember]
        public int CloudApplicationID { get; set; }
        [DataMember]
        public int VendorID { get; set; }
        [DataMember]
        public string VendorName { get; set; }
        [DataMember]
        public string VendorLogoURL { get; set; }
        [DataMember]
        public byte[] VendorLogo { get; set; }
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal ApplicationCostPerMonth { get; set; }
        [DataMember]
        public string ApplicationCostPerMonthExtra { get; set; }
        [DataMember]
        public decimal ApplicationCostPerAnnum { get; set; }
        [DataMember]
        public decimal ApplicationCostOneOff { get; set; }
        [DataMember]
        public decimal CallsPackageCostPerMonth { get; set; }
        [DataMember]
        public string SetupFee { get; set; }
        [DataMember]
        public string FreeTrialPeriod { get; set; }

        [DataMember]
        public List<OperatingSystemModel> OperatingSystems { get; set; }
        [DataMember]
        public List<SupportTypeModel> SupportTypes { get; set; }
        [DataMember]
        public SupportDaysModel SupportDays { get; set; }
        [DataMember]
        public SupportHoursModel SupportHours { get; set; }
        [DataMember]
        public List<LanguageModel> Languages { get; set; }
        [DataMember]
        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        [DataMember]
        public bool MoreInfoVisible { get; set; }

        //[DataMember]
        //public SearchResultDisplayFormat ResultDisplayFormat { get; set; }

    }
    #endregion

    #region VendorModel
    [DataContract]
    public class VendorModel
    {
        [DataMember]
        public int VendorID { get; set; }
        [DataMember]
        public string VendorName { get; set; }
        [DataMember]
        public string VendorLogoURL { get; set; }
        [DataMember]
        public byte[] VendorLogo { get; set; }

    }
    #endregion

    #region SetupFeeModel
    [DataContract]
    public class SetupFeeModel
    {
        [DataMember]
        public int SetupFeeID { get; set; }
        [DataMember]
        public string SetupFeeName { get; set; }
    }
    #endregion

    #region FreeTrialPeriodModel
    public class FreeTrialPeriodModel
    {
        [DataMember]
        public int FreeTrialPeriodID { get; set; }
        [DataMember]
        public string FreeTrialPeriodName { get; set; }
    }
    #endregion

    #region BrowserModel
    [DataContract]
    public class BrowserModel
    {
        [DataMember]
        public int BrowserID { get; set; }
        [DataMember]
        public string BrowserName { get; set; }
        [DataMember]
        public int BrowserColumnNumber { get; set; }
        [DataMember]
        public int BrowserRowNumber { get; set; }
    }
    #endregion

    #region MobilePlatformModel
    [DataContract]
    public class MobilePlatformModel
    {
        [DataMember]
        public int MobilePlatformID { get; set; }
        [DataMember]
        public string MobilePlatformName { get; set; }
    }
    #endregion

    #region LicenceTypeMinimumModel
    [DataContract]
    public class LicenceTypeMinimumModel
    {
        [DataMember]
        public int LicenceTypeMinimumID { get; set; }
        [DataMember]
        public int LicenceTypeMinimumName { get; set; }
    }
    #endregion

    #region LicenceTypeMaximumModel
    [DataContract]
    public class LicenceTypeMaximumModel
    {
        [DataMember]
        public int LicenceTypeMaximumID { get; set; }
        [DataMember]
        public int LicenceTypeMaximumName { get; set; }
    }
    #endregion

    #region SupportTypeModel
    [DataContract]
    public class SupportTypeModel
    {
        [DataMember]
        public int SupportTypeID { get; set; }
        [DataMember]
        public string SupportTypeName { get; set; }
    }
    #endregion

    #region SupportDaysModel
    [DataContract]
    public class SupportDaysModel
    {
        [DataMember]
        public int SupportDaysID { get; set; }
        [DataMember]
        public string SupportDaysName { get; set; }
    }
    #endregion

    #region SupportHoursModel
    [DataContract]
    public class SupportHoursModel
    {
        [DataMember]
        public int SupportHoursID { get; set; }
        [DataMember]
        public string SupportHoursName { get; set; }
    }
    #endregion

    #region SupportTerritoryModel
    [DataContract]
    public class SupportTerritoryModel
    {
        [DataMember]
        public int SupportTerritoryID { get; set; }
        [DataMember]
        public string SupportTerritoryName { get; set; }
    }
    #endregion

    #region LanguageModel
    [DataContract]
    public class LanguageModel
    {
        [DataMember]
        public int LanguageID { get; set; }
        [DataMember]
        public string LanguageName { get; set; }
    }
    #endregion

    #region CloudApplicationFeatureModel
    [DataContract]
    public class CloudApplicationFeatureModel
    {
        [DataMember]
        public int CloudApplicationFeatureID { get; set; }
        //[DataMember]
        //public CloudApplication CloudApplication { get; set; }
        [DataMember]
        public FeatureModel Feature { get; set; }
        [DataMember]
        public bool Include { get; set; }
        [DataMember]
        public bool IncludeExtraCost { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
        public bool IncludeCount { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public bool IncludeCountSuffix { get; set; }
        [DataMember]
        public string CountSuffix { get; set; }
    }
    #endregion

    #region ThumbnailDocumentModel
    [DataContract]
    public class ThumbnailDocumentModel
    {
        [DataMember]
        public int ThumbnailDocumentID { get; set; }
        [DataMember]
        public string ThumbnailDocumentTitle { get; set; }
        [DataMember]
        public string ThumbnailDocumentURL { get; set; }
        [DataMember]
        public string ThumbnailDocumentPhysicalFilePath { get; set; }
        [DataMember]
        public string ThumbnailDocumentFileName { get; set; }
        [DataMember]
        public CloudApplicationModel CloudApplication { get; set; }
        [DataMember]
        public ThumbnailDocumentTypeModel ThumbnailDocumentType { get; set; }
        [DataMember]
        public byte[] ThumbnailImage { get; set; }
    }
    #endregion

    #region CategoryModel
    [DataContract]
    public class CategoryModel
    {
        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public List<CloudApplicationFeatureModel> CategoryFeatures { get; set; }
        //[DataMember]
        //public List<CloudApplication> CloudApplications { get; set; }

    }
    #endregion

    #region MinimumContractModel
    [DataContract]
    public class MinimumContractModel
    {
        [DataMember]
        public int MinimumContractID { get; set; }
        [DataMember]
        public string MinimumContractName { get; set; }
        //[DataMember]
        //public List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

    #region PaymentFrequencyModel
    [DataContract]
    public class PaymentFrequencyModel
    {
        [DataMember]
        public int PaymentFrequencyID { get; set; }
        [DataMember]
        public string PaymentFrequencyName { get; set; }
    }
    #endregion

    #region PaymentOptionModel
    [DataContract]
    public class PaymentOptionModel
    {
        [DataMember]
        public int PaymentOptionID { get; set; }
        [DataMember]
        public string PaymentOptionName { get; set; }
    }
    #endregion

    #region CloudApplicationReviewModel
    [DataContract]
    public class CloudApplicationReviewModel
    {
        [DataMember]
        public int CloudApplicationReviewID { get; set; }
        [DataMember]
        public string CloudApplicationReviewHeadline { get; set; }
        [DataMember]
        public string CloudApplicationReviewPublisherName { get; set; }
        [DataMember]
        public string CloudApplicationReviewText { get; set; }
        [DataMember]
        public DateTime CloudApplicationReviewDate { get; set; }
        [DataMember]
        public string CloudApplicationReviewURL { get; set; }
        [DataMember]
        public int CloudApplicationID { get; set; }
    }
    #endregion

    #region CloudApplicationRatingModel
    [DataContract]
    public class CloudApplicationRatingModel
    {
        [DataMember]
        public int CloudApplicationRatingID { get; set; }
        [DataMember]
        public string CloudApplicationRatingReviewerName { get; set; }
        [DataMember]
        public string CloudApplicationRatingReviewerTitle { get; set; }
        [DataMember]
        public string CloudApplicationRatingReviewerCompany { get; set; }
        [DataMember]
        public string CloudApplicationRatingText { get; set; }
        [DataMember]
        public decimal CloudApplicationOverallRating { get; set; }
        [DataMember]
        public decimal CloudApplicationEaseOfUse { get; set; }
        [DataMember]
        public decimal CloudApplicationValueForMoney { get; set; }
        [DataMember]
        public decimal CloudApplicationFunctionality { get; set; }
        [DataMember]
        public int CloudApplicationID { get; set; }
    }
    #endregion

    #region FreeTrialBuyNowModel
    [DataContract]
    public class FreeTrialBuyNowModel
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string EMailAddress { get; set; }
        [DataMember]
        public string Telephone { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public int NumberOfEmployees { get; set; }
        [DataMember]
        public bool FreeTrial { get; set; }
        [DataMember]
        public bool BuyNow { get; set; }
    }
    #endregion

    #region CategoryModel
    //[DataContract]
    //public class CategoryModel
    //{
    //    [DataMember]
    //    public int SearchFilterID { get; set; }
    //    [DataMember]
    //    public int CategoryID { get; set; }
    //    [DataMember]
    //    public string CategoryName { get; set; }
    //    [DataMember]
    //    public bool Selected { get; set; }
    //}

    #endregion

    #region NumberOfUsersModel
    [DataContract]
    public class NumberOfUsersModel
    {
        [DataMember]
        public int UserValue { get; set; }
    }
    #endregion

    #region SearchFilterModelOneColumn
    [DataContract]
    public class SearchFilterModelOneColumn
    {
        [DataMember]
        public int SearchFilterID { get; set; }
        [DataMember]
        public CategoryModel Category { get; set; }
        [DataMember]
        public string Col1SearchFilterName { get; set; }
        [DataMember]
        public string Col1SearchFilterType { get; set; }
        [DataMember]
        public bool Col1Selected { get; set; }
    }
    #endregion

    #region SearchFilterModelTwoColumn
    [DataContract]
    public class SearchFilterModelTwoColumn
    {
        [DataMember]
        public int SearchFilterID { get; set; }
        [DataMember]
        public CategoryModel Category { get; set; }
        [DataMember]
        public string Col1SearchFilterName { get; set; }
        [DataMember]
        public string Col1SearchFilterType { get; set; }
        [DataMember]
        public bool Col1Selected { get; set; }
        [DataMember]
        public string Col2SearchFilterName { get; set; }
        [DataMember]
        public string Col2SearchFilterType { get; set; }
        [DataMember]
        public bool Col2Selected { get; set; }
    }
    #endregion

    #region SearchResultSummaryModel
    [DataContract]
    public class SearchResultSummaryModel
    {
        [DataMember]
        public int SearchResultID { get; set; }
        [DataMember]
        public bool IsLastInCollection { get; set; }
        [DataMember]
        public int CloudApplicationID { get; set; }
        [DataMember]
        public int VendorID { get; set; }
        [DataMember]
        public string VendorName { get; set; }
        [DataMember]
        public string VendorLogoURL { get; set; }
        [DataMember]
        public byte[] VendorLogo { get; set; }
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal ApplicationCostPerMonth { get; set; }
        [DataMember]
        public string ApplicationCostPerMonthExtra { get; set; }
        [DataMember]
        public decimal ApplicationCostPerAnnum { get; set; }
        [DataMember]
        public decimal ApplicationCostOneOff { get; set; }
        [DataMember]
        public decimal CallsPackageCostPerMonth { get; set; }
        [DataMember]
        public string SetupFee { get; set; }
        [DataMember]
        public string FreeTrialPeriod { get; set; }
        //[DataMember]
        //public SearchResultDisplayFormat ResultDisplayFormat { get; set; }
        [DataMember]
        public List<CompareCloudware.Domain.Models.OperatingSystem> OperatingSystems { get; set; }
        [DataMember]
        public List<SupportTypeModel> SupportTypes { get; set; }
        [DataMember]
        public SupportDaysModel SupportDays { get; set; }
        [DataMember]
        public SupportHoursModel SupportHours { get; set; }
        [DataMember]
        public List<LanguageModel> Languages { get; set; }
        [DataMember]
        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }

    }
    #endregion

    #region CloudApplication
    //[DataContract]
    //public class CloudApplication
    //{
    //    [DataMember]
    //    public int CloudApplicationID { get; set; }
    //    [DataMember]
    //    public Vendor Vendor { get; set; }
    //    [DataMember]
    //    public string Brand { get; set; }
    //    [DataMember]
    //    public string ServiceName { get; set; }
    //    [DataMember]
    //    public string CompanyURL { get; set; }
    //    [DataMember]
    //    public byte[] CloudApplicationLogo { get; set; }
    //    //[Required]
    //    //[MaxLength(101)]
    //    [DataMember]
    //    public string Title { get; set; }
    //    [DataMember]
    //    public string Description { get; set; }
    //    [DataMember]
    //    public bool IsPromotional { get; set; }
    //    [DataMember]
    //    public decimal ApplicationCostPerMonth { get; set; }
    //    [DataMember]
    //    public string ApplicationCostPerMonthExtra { get; set; }
    //    [DataMember]
    //    public decimal ApplicationCostPerAnnum { get; set; }
    //    [DataMember]
    //    public decimal ApplicationCostOneOff { get; set; }
    //    [DataMember]
    //    public decimal CallsPackageCostPerMonth { get; set; }
    //    [DataMember]
    //    public SetupFee SetupFee { get; set; }
    //    [DataMember]
    //    public FreeTrialPeriod FreeTrialPeriod { get; set; }
    //    [DataMember]
    //    public List<OperatingSystem> OperatingSystems { get; set; }
    //    [DataMember]
    //    public List<Browser> Browsers { get; set; }
    //    [DataMember]
    //    public List<MobilePlatform> MobilePlatforms { get; set; }
    //    [DataMember]
    //    public LicenceTypeMinimum LicenceTypeMinimum { get; set; }
    //    [DataMember]
    //    public LicenceTypeMaximum LicenceTypeMaximum { get; set; }
    //    [DataMember]
    //    public List<SupportType> SupportTypes { get; set; }
    //    [DataMember]
    //    public SupportDays SupportDays { get; set; }
    //    [DataMember]
    //    public SupportHours SupportHours { get; set; }
    //    [DataMember]
    //    public List<SupportTerritory> SupportTerritories { get; set; }
    //    [DataMember]
    //    public List<Language> Languages { get; set; }
    //    [DataMember]
    //    public List<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
    //    [DataMember]
    //    public List<ThumbnailDocument> ThumbnailDocuments { get; set; }
    //    [DataMember]
    //    public string TwitterURL { get; set; }
    //    [DataMember]
    //    public string FacebookURL { get; set; }
    //    [DataMember]
    //    public string LinkedInURL { get; set; }
    //    [DataMember]
    //    public int TwitterFollowers { get; set; }
    //    [DataMember]
    //    public int FacebookFollowers { get; set; }
    //    [DataMember]
    //    public int LinkedInFollowers { get; set; }
    //    [DataMember]
    //    public decimal AverageOverallRating { get; set; }
    //    [DataMember]
    //    public decimal AverageEaseOfUse { get; set; }
    //    [DataMember]
    //    public decimal AverageValueForMoney { get; set; }
    //    [DataMember]
    //    public decimal AverageFunctionality { get; set; }

    //    [DataMember]
    //    public CategoryModel Category { get; set; }
    //    [DataMember]
    //    public DateTime? AddDate { get; set; }

    //    [DataMember]
    //    public MinimumContractModel MinimumContract { get; set; }
    //    [DataMember]
    //    public PaymentFrequencyModel PaymentFrequency { get; set; }
    //    [DataMember]
    //    public List<PaymentOptionModel> PaymentOptions { get; set; }

    //    [DataMember]
    //    public bool VideoTrainingSupport { get; set; }

    //    [DataMember]
    //    public int MaximumMeetingAttendees { get; set; }
    //    [DataMember]
    //    public int MaximumWebinarAttendees { get; set; }

    //    [DataMember]
    //    public int ApprovalAssignedPersonID { get; set; }
    //    [DataMember]
    //    public int ApplicationContentStatusID { get; set; }
    //    [DataMember]
    //    public int ApprovalStatusID { get; set; }

    //    [DataMember]
    //    public List<CloudApplicationReview> Reviews { get; set; }
    //    [DataMember]
    //    public List<CloudApplicationRating> Ratings { get; set; }

    //}
    #endregion

    #region CloudApplicationReview
    //[DataContract]
    //public class CloudApplicationReview
    //{
    //    [DataMember]
    //    public int CloudApplicationReviewID { get; set; }
    //    [DataMember]
    //    public string CloudApplicationReviewHeadline { get; set; }
    //    [DataMember]
    //    public string CloudApplicationReviewPublisherName { get; set; }
    //    [DataMember]
    //    public string CloudApplicationReviewText { get; set; }
    //    [DataMember]
    //    public DateTime CloudApplicationReviewDate { get; set; }
    //    [DataMember]
    //    public string CloudApplicationReviewURL { get; set; }
    //    [DataMember]
    //    public string CloudApplicationReviewPhysicalFileName { get; set; }
    //    [DataMember]
    //    public CloudApplication CloudApplication { get; set; }
    //}
    #endregion

    #region CloudApplicationRating
    //[DataContract]
    //public class CloudApplicationRating
    //{
    //    [DataMember]
    //    public int CloudApplicationRatingID { get; set; }
    //    [DataMember]
    //    public string CloudApplicationRatingReviewerName { get; set; }
    //    [DataMember]
    //    public string CloudApplicationRatingReviewerTitle { get; set; }
    //    [DataMember]
    //    public string CloudApplicationRatingReviewerCompany { get; set; }
    //    [DataMember]
    //    public string CloudApplicationRatingText { get; set; }
    //    [DataMember]
    //    public decimal CloudApplicationOverallRating { get; set; }
    //    [DataMember]
    //    public decimal CloudApplicationEaseOfUse { get; set; }
    //    [DataMember]
    //    public decimal CloudApplicationValueForMoney { get; set; }
    //    [DataMember]
    //    public decimal CloudApplicationFunctionality { get; set; }
    //    [DataMember]
    //    public CloudApplication CloudApplication { get; set; }
    //}
    #endregion

    #region FeatureModel
    //[DataContract(IsReference = true)]
    [DataContract]
    public class FeatureModel
    {
        [DataMember]
        public int FeatureID { get; set; }
        [DataMember]
        public string FeatureName { get; set; }
        //[DataMember]
        //public List<Category> Categories { get; set; }
        [DataMember]
        public int FeatureColumnNumber { get; set; }
        [DataMember]
        public int FeatureRowNumber { get; set; }
    }
    #endregion

    #region ThumbnailDocumentTypeModel
    [DataContract]
    public class ThumbnailDocumentTypeModel
    {
        [DataMember]
        public int ThumbnailDocumentTypeID { get; set; }
        [DataMember]
        public string ThumbnailDocumentTypeName { get; set; }
    }
    #endregion

    #region OperatingSystemModel
    public class OperatingSystemModel
    {
        public virtual int OperatingSystemID { get; set; }
        public virtual string OperatingSystemName { get; set; }
    }
    #endregion
}