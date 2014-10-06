using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplication
    public class CloudApplication
    {
        public virtual int CloudApplicationID { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual string Brand { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string CompanyURL { get; set; }
        public virtual byte[] CloudApplicationLogo { get; set; }
        //[Required]
        //[MaxLength(101)]
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        //public virtual bool IsPromotional { get; set; }
        //public virtual bool IsLive { get; set; }
        
        public virtual decimal ApplicationCostPerMonth { get; set; }
        public virtual decimal ApplicationCostPerMonthFrom { get; set; }
        public virtual decimal ApplicationCostPerMonthTo { get; set; }
        public virtual bool ApplicationCostPerMonthPOA { get; set; }
        public virtual bool ApplicationCostPerMonthFree { get; set; }
        public virtual bool ApplicationCostPerMonthAvailable { get; set; }
        public virtual bool ApplicationCostPerMonthOffered { get; set; }
        public virtual string ApplicationCostPerMonthSuffix { get; set; }
        public virtual bool? ApplicationCostPerMonthIsForUnlimitedUsers { get; set; }
        
        public virtual decimal ApplicationCostPerAnnum { get; set; }
        public virtual decimal ApplicationCostPerAnnumFrom { get; set; }
        public virtual decimal ApplicationCostPerAnnumTo { get; set; }
        public virtual bool ApplicationCostPerAnnumPOA { get; set; }
        public virtual bool ApplicationCostPerAnnumFree { get; set; }
        public virtual bool ApplicationCostPerAnnumAvailable { get; set; }
        public virtual bool ApplicationCostPerAnnumOffered { get; set; }
        public virtual decimal ApplicationCostOneOff { get; set; }
        public virtual bool? ApplicationCostPerAnnumIsForUnlimitedUsers { get; set; }

        public virtual bool PayAsYouGo { get; set; }
        //public virtual bool IsScaledPrice { get; set; }
        public virtual decimal CallsPackageCostPerMonth { get; set; }
        public virtual SetupFee SetupFee { get; set; }
        public virtual FreeTrialPeriod FreeTrialPeriod { get; set; }
        public virtual List<OperatingSystem> OperatingSystems { get; set; }
        public virtual List<Browser> Browsers { get; set; }
        public virtual List<Device> Devices { get; set; }
        public virtual List<MobilePlatform> MobilePlatforms { get; set; }
        public virtual LicenceTypeMinimum LicenceTypeMinimum { get; set; }
        public virtual LicenceTypeMaximum LicenceTypeMaximum { get; set; }
        public virtual List<SupportType> SupportTypes { get; set; }
        public virtual SupportDays SupportDays { get; set; }
        public virtual SupportHours SupportHours { get; set; }
        public virtual TimeZone SupportHoursTimeZone { get; set; }
        public virtual List<SupportTerritory> SupportTerritories { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
        public virtual List<CloudApplicationApplication> CloudApplicationApplications { get; set; }
        public virtual List<CloudApplicationDocument> CloudApplicationDocuments { get; set; }
        public virtual string TwitterURL { get; set; }
        public virtual string FacebookURL { get; set; }
        public virtual string LinkedInURL { get; set; }
        public virtual long TwitterFollowers { get; set; }
        public virtual long FacebookFollowers { get; set; }
        public virtual long LinkedInFollowers { get; set; }

        public virtual DateTime? LastTwitterPing { get; set; }
        public virtual DateTime? LastFacebookPing { get; set; }
        public virtual DateTime? LastLinkedInPing { get; set; }

        public virtual string TwitterName { get; set; }
        public virtual string FacebookName { get; set; }
        public virtual int LinkedInCompanyID { get; set; }

        public virtual decimal AverageOverallRating { get; set; }
        public virtual decimal AverageEaseOfUse { get; set; }
        public virtual decimal AverageValueForMoney { get; set; }
        public virtual decimal AverageFunctionality { get; set; }

        public virtual Category Category { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }

        public virtual MinimumContract MinimumContract { get; set; }
        public virtual PaymentFrequency PaymentFrequency { get; set; }
        public virtual List<PaymentOption> PaymentOptions { get; set; }

        public virtual bool VideoTrainingSupport { get; set; }

        public virtual int MaximumMeetingAttendees { get; set; }
        public virtual int MaximumWebinarAttendees { get; set; }

        public virtual int ApprovalAssignedPersonID { get; set; }
        public virtual int ApplicationContentStatusID { get; set; }
        public virtual int ApprovalStatusID { get; set; }

        public virtual List<CloudApplicationProductReview> CloudApplicationProductReviews { get; set; }
        public virtual List<CloudApplicationUserReview> CloudApplicationUserReviews { get; set; }
        public virtual byte[] RowVersion { get; set; }

        public virtual string Options { get; set; }
        public virtual bool SupportOffered { get; set; }

        public virtual bool DemoOffered { get; set; }
        //public virtual bool TestDriveOffered { get; set; }

        public virtual decimal SearchResultWeighting { get; set; }

        public virtual List<CloudApplicationVideo> CloudApplicationVideos { get; set; }

        public virtual Currency CloudApplicationCurrency { get; set; }

        public virtual string TryURL { get; set; }
        public virtual string BuyURL { get; set; }

        public virtual Status CloudApplicationStatus { get; set; }

        //public virtual int? CloudApplicationShopTagID { get; set; }
        public virtual Tag CloudApplicationCategoryTag { get; set; }
        public virtual Tag CloudApplicationShopTag { get; set; }

    }
    #endregion
}
