using System;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Core;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.Domain.Contracts.Repositories
{
    public interface ICompareCloudwareContext : IDisposable
    {
        IDbSet<CloudApplication> CloudApplications { get; }
        IDbSet<Vendor> Vendors { get; }
        IDbSet<VendorLogo> VendorLogos { get; }
        IDbSet<Feature> Features { get; }
        IDbSet<CompareCloudware.Domain.Models.OperatingSystem> OperatingSystems { get; }
        IDbSet<MobilePlatform> MobilePlatforms { get; }
        IDbSet<Browser> Browsers { get; }
        IDbSet<LicenceTypeMinimum> LicenceTypeMinimums { get; }
        IDbSet<LicenceTypeMaximum> LicenceTypeMaximums { get; }
        IDbSet<Language> Languages { get; }
        IDbSet<SupportType> SupportTypes { get; }
        IDbSet<SupportDays> SupportDays { get; }
        IDbSet<SupportHours> SupportHours { get; }
        IDbSet<CompareCloudware.Domain.Models.TimeZone> TimeZones { get; }
        IDbSet<SupportTerritory> SupportTerritories { get; }
        IDbSet<Category> Categories { get; }
        IDbSet<CategoryParameters> CategoryParameters { get; }
        IDbSet<MinimumContract> MinimumContracts { get; }
        IDbSet<PaymentFrequency> PaymentFrequencies { get; }
        IDbSet<SetupFee> SetupFees { get; }
        IDbSet<PaymentOption> PaymentOptions { get; }
        IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; }
        IDbSet<FeatureType> FeatureTypes { get; }
        IDbSet<CloudApplicationDocument> CloudApplicationDocuments { get; }
        IDbSet<CloudApplicationDocumentImage> CloudApplicationDocumentImages { get; }
        IDbSet<CloudApplicationDocumentType> CloudApplicationDocumentTypes { get; }
        IDbSet<CloudApplicationDocumentFormat> CloudApplicationDocumentFormats { get; }
        IDbSet<AdvertisingImage> AdvertisingImages { get; }
        IDbSet<AdvertisingImageType> AdvertisingImageTypes { get; }
        IDbSet<Tag> Tags { get; }
        IDbSet<TagType> TagTypes { get; }
        IDbSet<ContentText> ContentText { get; }
        IDbSet<ContentTextType> ContentTextTypes { get; }
        IDbSet<Person> Persons { get; }
        IDbSet<PersonType> PersonTypes { get; }
        IDbSet<Colleague> Colleagues { get; }
        IDbSet<CloudApplicationRequest> CloudApplicationRequests { get; }
        IDbSet<Device> Devices { get; }
        IDbSet<SiteActivity> SiteActivity { get; }
        IDbSet<CloudApplicationProductReview> CloudApplicationProductReviews { get; }
        IDbSet<CloudApplicationUserReview> CloudApplicationUserReviews { get; }
        IDbSet<RequestType> RequestTypes { get; }
        IDbSet<Industry> Industries { get; }
        IDbSet<CloudApplicationFeature> CloudApplicationFeatures { get; }
        IDbSet<CloudApplicationApplication> CloudApplicationApplications { get; }
        int SaveChanges();
        //int GetStations(string startsWith);
        CloudApplication FindById(int cloudApplicationId);
        IDbSet<TermCondition> TermsConditions { get; }
        IDbSet<CloudApplicationVideo> CloudApplicationVideos { get; }

        IDbSet<Profile> Profiles { get; }
        IDbSet<VendorDashboard> VendorDashboards { get; }
        IDbSet<VendorDashboardRole> VendorDashboardRoles { get; }
        IDbSet<VendorDashboardRolePerson> VendorDashboardRolePersons { get; }

        IDbSet<Currency> Currencies { get; }
        IDbSet<Status> Statuses { get; }

        ObjectContext ObjectContext();

        IDbSet<SiteAnalytic> SiteAnalytics { get; }
        IDbSet<SiteAnalyticType> SiteAnalyticTypes { get; }

        IDbSet<SupportCategory> SupportCategories { get; }
        IDbSet<SupportArea> SupportAreas { get; }
        IDbSet<QAStatus> QAStatuses { get; }
        IDbSet<SupportAreaQA> SupportAreaQAs { get; }
        IDbSet<SupportAreaQACategory> SupportAreaQACategories { get; }

        IDbSet<AdvertisingImageServer> AdvertisingImageServer { get; }

        IDbSet<ContentPage> ContentPages { get; }
        IDbSet<SiteMapNode> SiteMapNodes { get; }

        //IDbSet<SiteMapFrequency> SiteMapFrequencies { get; }

    }
}
