using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Objects;
using System.Data.Entity;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.Domain.Models;

using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace CompareCloudware.POCOQueryRepository
{
    public class FakeCloudCompareContext : ICompareCloudwareContext, IDisposable
    {

        private FakeObjectSet<CloudApplication> _cloudApplications;
        private FakeObjectSet<Vendor> _vendors;
        private FakeObjectSet<VendorLogo> _vendorLogos;
        private FakeObjectSet<Feature> _features;
        private FakeObjectSet<CompareCloudware.Domain.Models.OperatingSystem> _operatingSystems;
        private FakeObjectSet<MobilePlatform> _mobilePlatforms;
        private FakeObjectSet<Browser> _browsers;
        private FakeObjectSet<LicenceTypeMinimum> _licenceTypeMinimums;
        private FakeObjectSet<LicenceTypeMaximum> _licenceTypeMaximums;
        private FakeObjectSet<Language> _languages;
        private FakeObjectSet<SupportType> _supportTypes;
        private FakeObjectSet<SupportDays> _supportDays;
        private FakeObjectSet<SupportHours> _supportHours;
        private FakeObjectSet<CompareCloudware.Domain.Models.TimeZone> _timeZones;
        private FakeObjectSet<SupportTerritory> _supportTerritories;
        private FakeObjectSet<Category> _categories;
        private FakeObjectSet<CategoryParameters> _categoryParameters;
        private FakeObjectSet<MinimumContract> _minimumContracts;
        private FakeObjectSet<PaymentFrequency> _paymentFrequencies;
        private FakeObjectSet<SetupFee> _setupFees;
        private FakeObjectSet<PaymentOption> _paymentOptions;
        private FakeObjectSet<FreeTrialPeriod> _freeTrialPeriods;
        private FakeObjectSet<FeatureType> _featureTypes;
        private FakeObjectSet<CloudApplicationDocumentType> _CloudApplicationDocumentTypes;
        private FakeObjectSet<CloudApplicationDocumentFormat> _CloudApplicationDocumentFormats;
        private FakeObjectSet<CloudApplicationDocument> _CloudApplicationDocuments;
        private FakeObjectSet<CloudApplicationDocumentImage> _CloudApplicationDocumentImages;
        private FakeObjectSet<AdvertisingImageType> _advertisingImageTypes;
        private FakeObjectSet<AdvertisingImage> _advertisingImages;
        private FakeObjectSet<Tag> _tags;
        private FakeObjectSet<TagType> _tagTypes;
        private FakeObjectSet<ContentText> _contentText;
        private FakeObjectSet<ContentTextType> _contentTextTypes;
        private FakeObjectSet<Person> _persons;
        private FakeObjectSet<CloudApplicationRequest> _cloudApplicationRequests;
        private FakeObjectSet<Device> _devices;
        private FakeObjectSet<SiteActivity> _siteActivity;
        private FakeObjectSet<CloudApplicationProductReview> _cloudApplicationProductReviews;
        private FakeObjectSet<CloudApplicationUserReview> _cloudApplicationUserReviews;
        private FakeObjectSet<RequestType> _requestTypes;
        private FakeObjectSet<Industry> _industries;
        private FakeObjectSet<CloudApplicationFeature> _cloudApplicationFeatures;
        private FakeObjectSet<CloudApplicationApplication> _cloudApplicationApplications;
        private FakeObjectSet<TermCondition> _termsConditions;
        private FakeObjectSet<CloudApplicationVideo> _cloudApplicationVideos;

        private FakeObjectSet<Profile> _profiles;
        private FakeObjectSet<VendorDashboard> _vendorDashboards;
        private FakeObjectSet<VendorDashboardRole> _vendorDashboardRoles;
        private FakeObjectSet<VendorDashboardRolePerson> _vendorDashboardRolePersons;

        private FakeObjectSet<Currency> _currencies;
        private FakeObjectSet<Status> _statuses;
        private FakeObjectSet<SiteAnalytic> _siteAnalytics;
        private FakeObjectSet<SiteAnalyticType> _siteAnalyticTypes;

        private FakeObjectSet<SupportCategory> _supportCategories;
        private FakeObjectSet<SupportArea> _supportAreas;
        private FakeObjectSet<QAStatus> _qaStatuses;
        private FakeObjectSet<SupportAreaQA> _supportAreaQAs;
        private FakeObjectSet<SupportAreaQACategory> _supportAreaQACategories;

        private FakeObjectSet<AdvertisingImageServer> _advertisingImageServer;

        private FakeObjectSet<ContentPage> _contentPages;
        private FakeObjectSet<SiteMapNode> _siteMapNodes;

        #region ICloudCompareEntities Members

        public IDbSet<CloudApplication> CloudApplications
        {
            get
            {
                return _cloudApplications ?? (_cloudApplications = new FakeObjectSet<CloudApplication>());
            }
            set
            {
                _cloudApplications = value as FakeObjectSet<CloudApplication>;
            }
        }

        public IDbSet<Vendor> Vendors
        {
            get
            {
                return _vendors ?? (_vendors = new FakeObjectSet<Vendor>());
            }
            set
            {
                _vendors = value as FakeObjectSet<Vendor>;
            }
        }

        public IDbSet<VendorLogo> VendorLogos
        {
            get
            {
                return _vendorLogos ?? (_vendorLogos = new FakeObjectSet<VendorLogo>());
            }
            set
            {
                _vendorLogos = value as FakeObjectSet<VendorLogo>;
            }
        }

        public IDbSet<Feature> Features
        {
            get
            {
                return _features ?? (_features = new FakeObjectSet<Feature>());
            }
            set
            {
                _features = value as FakeObjectSet<Feature>;
            }
        }

        public IDbSet<CompareCloudware.Domain.Models.OperatingSystem> OperatingSystems
        {
            get
            {
                return _operatingSystems ?? (_operatingSystems = new FakeObjectSet<CompareCloudware.Domain.Models.OperatingSystem>());
            }
            set
            {
                _operatingSystems = value as FakeObjectSet<CompareCloudware.Domain.Models.OperatingSystem>;
            }
        }

        public IDbSet<MobilePlatform> MobilePlatforms
        {
            get
            {
                return _mobilePlatforms ?? (_mobilePlatforms = new FakeObjectSet<MobilePlatform>());
            }
            set
            {
                _mobilePlatforms = value as FakeObjectSet<MobilePlatform>;
            }
        }

        public IDbSet<Browser> Browsers
        {
            get
            {
                return _browsers ?? (_browsers = new FakeObjectSet<Browser>());
            }
            set
            {
                _browsers = value as FakeObjectSet<Browser>;
            }
        }

        public IDbSet<LicenceTypeMinimum> LicenceTypeMinimums
        {
            get
            {
                return _licenceTypeMinimums ?? (_licenceTypeMinimums = new FakeObjectSet<LicenceTypeMinimum>());
            }
            set
            {
                _licenceTypeMinimums = value as FakeObjectSet<LicenceTypeMinimum>;
            }
        }

        public IDbSet<LicenceTypeMaximum> LicenceTypeMaximums
        {
            get
            {
                return _licenceTypeMaximums ?? (_licenceTypeMaximums = new FakeObjectSet<LicenceTypeMaximum>());
            }
            set
            {
                _licenceTypeMaximums = value as FakeObjectSet<LicenceTypeMaximum>;
            }
        }

        public IDbSet<Language> Languages
        {
            get
            {
                return _languages ?? (_languages = new FakeObjectSet<Language>());
            }
            set
            {
                _languages = value as FakeObjectSet<Language>;
            }
        }

        public IDbSet<SupportType> SupportTypes
        {
            get
            {
                return _supportTypes ?? (_supportTypes = new FakeObjectSet<SupportType>());
            }
            set
            {
                _supportTypes = value as FakeObjectSet<SupportType>;
            }
        }

        public IDbSet<SupportDays> SupportDays
        {
            get
            {
                return _supportDays ?? (_supportDays = new FakeObjectSet<SupportDays>());
            }
            set
            {
                _supportDays = value as FakeObjectSet<SupportDays>;
            }
        }

        public IDbSet<SupportHours> SupportHours
        {
            get
            {
                return _supportHours ?? (_supportHours = new FakeObjectSet<SupportHours>());
            }
            set
            {
                _supportHours = value as FakeObjectSet<SupportHours>;
            }
        }

        public IDbSet<CompareCloudware.Domain.Models.TimeZone> TimeZones
        {
            get
            {
                return _timeZones ?? (_timeZones = new FakeObjectSet<CompareCloudware.Domain.Models.TimeZone>());
            }
            set
            {
                _timeZones = value as FakeObjectSet<CompareCloudware.Domain.Models.TimeZone>;
            }
        }

        public IDbSet<SupportTerritory> SupportTerritories
        {
            get
            {
                return _supportTerritories ?? (_supportTerritories = new FakeObjectSet<SupportTerritory>());
            }
            set
            {
                _supportTerritories = value as FakeObjectSet<SupportTerritory>;
            }
        }

        public IDbSet<Category> Categories
        {
            get
            {
                return _categories ?? (_categories = new FakeObjectSet<Category>());
            }
            set
            {
                _categories = value as FakeObjectSet<Category>;
            }
        }

        public IDbSet<CategoryParameters> CategoryParameters
        {
            get
            {
                return _categoryParameters ?? (_categoryParameters = new FakeObjectSet<CategoryParameters>());
            }
            set
            {
                _categoryParameters = value as FakeObjectSet<CategoryParameters>;
            }
        }

        public IDbSet<MinimumContract> MinimumContracts
        {
            get
            {
                return _minimumContracts ?? (_minimumContracts = new FakeObjectSet<MinimumContract>());
            }
            set
            {
                _minimumContracts = value as FakeObjectSet<MinimumContract>;
            }
        }

        public IDbSet<PaymentFrequency> PaymentFrequencies
        {
            get
            {
                return _paymentFrequencies ?? (_paymentFrequencies = new FakeObjectSet<PaymentFrequency>());
            }
            set
            {
                _paymentFrequencies = value as FakeObjectSet<PaymentFrequency>;
            }
        }

        public IDbSet<SetupFee> SetupFees
        {
            get
            {
                return _setupFees ?? (_setupFees = new FakeObjectSet<SetupFee>());
            }
            set
            {
                _setupFees = value as FakeObjectSet<SetupFee>;
            }
        }

        public IDbSet<PaymentOption> PaymentOptions
        {
            get
            {
                return _paymentOptions ?? (_paymentOptions = new FakeObjectSet<PaymentOption>());
            }
            set
            {
                _paymentOptions = value as FakeObjectSet<PaymentOption>;
            }
        }

        public IDbSet<FreeTrialPeriod> FreeTrialPeriods
        {
            get
            {
                return _freeTrialPeriods ?? (_freeTrialPeriods = new FakeObjectSet<FreeTrialPeriod>());
            }
            set
            {
                _freeTrialPeriods = value as FakeObjectSet<FreeTrialPeriod>;
            }
        }

        public IDbSet<FeatureType> FeatureTypes
        {
            get
            {
                return _featureTypes ?? (_featureTypes = new FakeObjectSet<FeatureType>());
            }
            set
            {
                _featureTypes = value as FakeObjectSet<FeatureType>;
            }
        }

        public IDbSet<CloudApplicationDocument> CloudApplicationDocuments
        {
            get
            {
                return _CloudApplicationDocuments ?? (_CloudApplicationDocuments = new FakeObjectSet<CloudApplicationDocument>());
            }
            set
            {
                _CloudApplicationDocuments = value as FakeObjectSet<CloudApplicationDocument>;
            }
        }

        public IDbSet<CloudApplicationDocumentImage> CloudApplicationDocumentImages
        {
            get
            {
                return _CloudApplicationDocumentImages ?? (_CloudApplicationDocumentImages = new FakeObjectSet<CloudApplicationDocumentImage>());
            }
            set
            {
                _CloudApplicationDocumentImages = value as FakeObjectSet<CloudApplicationDocumentImage>;
            }
        }

        public IDbSet<CloudApplicationDocumentType> CloudApplicationDocumentTypes
        {
            get
            {
                return _CloudApplicationDocumentTypes ?? (_CloudApplicationDocumentTypes = new FakeObjectSet<CloudApplicationDocumentType>());
            }
            set
            {
                _CloudApplicationDocumentTypes = value as FakeObjectSet<CloudApplicationDocumentType>;
            }
        }

        public IDbSet<CloudApplicationDocumentFormat> CloudApplicationDocumentFormats
        {
            get
            {
                return _CloudApplicationDocumentFormats ?? (_CloudApplicationDocumentFormats = new FakeObjectSet<CloudApplicationDocumentFormat>());
            }
            set
            {
                _CloudApplicationDocumentFormats = value as FakeObjectSet<CloudApplicationDocumentFormat>;
            }
        }

        public IDbSet<AdvertisingImage> AdvertisingImages
        {
            get
            {
                return _advertisingImages ?? (_advertisingImages = new FakeObjectSet<AdvertisingImage>());
            }
            set
            {
                _advertisingImages = value as FakeObjectSet<AdvertisingImage>;
            }
        }

        public IDbSet<AdvertisingImageType> AdvertisingImageTypes
        {
            get
            {
                return _advertisingImageTypes ?? (_advertisingImageTypes = new FakeObjectSet<AdvertisingImageType>());
            }
            set
            {
                _advertisingImageTypes = value as FakeObjectSet<AdvertisingImageType>;
            }
        }

        public IDbSet<Tag> Tags
        {
            get
            {
                return _tags ?? (_tags = new FakeObjectSet<Tag>());
            }
            set
            {
                _tags = value as FakeObjectSet<Tag>;
            }
        }

        public IDbSet<TagType> TagTypes
        {
            get
            {
                return _tagTypes ?? (_tagTypes = new FakeObjectSet<TagType>());
            }
            set
            {
                _tagTypes = value as FakeObjectSet<TagType>;
            }
        }

        public IDbSet<ContentText> ContentText
        {
            get
            {
                return _contentText ?? (_contentText = new FakeObjectSet<ContentText>());
            }
            set
            {
                _contentText = value as FakeObjectSet<ContentText>;
            }
        }

        public IDbSet<ContentTextType> ContentTextTypes
        {
            get
            {
                return _contentTextTypes ?? (_contentTextTypes = new FakeObjectSet<ContentTextType>());
            }
            set
            {
                _contentTextTypes = value as FakeObjectSet<ContentTextType>;
            }
        }

        public IDbSet<Person> Persons
        {
            get
            {
                return _persons ?? (_persons = new FakeObjectSet<Person>());
            }
            set
            {
                _persons = value as FakeObjectSet<Person>;
            }
        }

        public IDbSet<CloudApplicationRequest> CloudApplicationRequests
        {
            get
            {
                return _cloudApplicationRequests ?? (_cloudApplicationRequests = new FakeObjectSet<CloudApplicationRequest>());
            }
            set
            {
                _cloudApplicationRequests = value as FakeObjectSet<CloudApplicationRequest>;
            }
        }

        public IDbSet<Device> Devices
        {
            get
            {
                return _devices ?? (_devices = new FakeObjectSet<Device>());
            }
            set
            {
                _devices = value as FakeObjectSet<Device>;
            }
        }

        public IDbSet<SiteActivity> SiteActivity
        {
            get
            {
                return _siteActivity ?? (_siteActivity = new FakeObjectSet<SiteActivity>());
            }
            set
            {
                _siteActivity = value as FakeObjectSet<SiteActivity>;
            }
        }

        public IDbSet<CloudApplicationProductReview> CloudApplicationProductReviews
        {
            get
            {
                return _cloudApplicationProductReviews ?? (_cloudApplicationProductReviews = new FakeObjectSet<CloudApplicationProductReview>());
            }
            set
            {
                _cloudApplicationProductReviews = value as FakeObjectSet<CloudApplicationProductReview>;
            }
        }

        public IDbSet<CloudApplicationUserReview> CloudApplicationUserReviews
        {
            get
            {
                return _cloudApplicationUserReviews ?? (_cloudApplicationUserReviews = new FakeObjectSet<CloudApplicationUserReview>());
            }
            set
            {
                _cloudApplicationUserReviews = value as FakeObjectSet<CloudApplicationUserReview>;
            }
        }

        public IDbSet<RequestType> RequestTypes
        {
            get
            {
                return _requestTypes ?? (_requestTypes = new FakeObjectSet<RequestType>());
            }
            set
            {
                _requestTypes = value as FakeObjectSet<RequestType>;
            }
        }

        public IDbSet<Industry> Industries
        {
            get
            {
                return _industries ?? (_industries = new FakeObjectSet<Industry>());
            }
            set
            {
                _industries = value as FakeObjectSet<Industry>;
            }
        }

        public IDbSet<CloudApplicationFeature> CloudApplicationFeatures
        {
            get
            {
                return _cloudApplicationFeatures ?? (_cloudApplicationFeatures = new FakeObjectSet<CloudApplicationFeature>());
            }
            set
            {
                _cloudApplicationFeatures = value as FakeObjectSet<CloudApplicationFeature>;
            }
        }

        public IDbSet<CloudApplicationApplication> CloudApplicationApplications
        {
            get
            {
                return _cloudApplicationApplications ?? (_cloudApplicationApplications = new FakeObjectSet<CloudApplicationApplication>());
            }
            set
            {
                _cloudApplicationApplications = value as FakeObjectSet<CloudApplicationApplication>;
            }
        }

        public IDbSet<TermCondition> TermsConditions
        {
            get
            {
                return _termsConditions ?? (_termsConditions = new FakeObjectSet<TermCondition>());
            }
            set
            {
                _termsConditions = value as FakeObjectSet<TermCondition>;
            }
        }

        public IDbSet<CloudApplicationVideo> CloudApplicationVideos
        {
            get
            {
                return _cloudApplicationVideos ?? (_cloudApplicationVideos = new FakeObjectSet<CloudApplicationVideo>());
            }
            set
            {
                _cloudApplicationVideos = value as FakeObjectSet<CloudApplicationVideo>;
            }
        }

        public IDbSet<Profile> Profiles
        {
            get
            {
                return _profiles ?? (_profiles = new FakeObjectSet<Profile>());
            }
            set
            {
                _profiles = value as FakeObjectSet<Profile>;
            }
        }

        public IDbSet<VendorDashboard> VendorDashboards
        {
            get
            {
                return _vendorDashboards ?? (_vendorDashboards = new FakeObjectSet<VendorDashboard>());
            }
            set
            {
                _vendorDashboards = value as FakeObjectSet<VendorDashboard>;
            }
        }

        public IDbSet<VendorDashboardRole> VendorDashboardRoles
        {
            get
            {
                return _vendorDashboardRoles ?? (_vendorDashboardRoles = new FakeObjectSet<VendorDashboardRole>());
            }
            set
            {
                _vendorDashboardRoles = value as FakeObjectSet<VendorDashboardRole>;
            }
        }

        public IDbSet<VendorDashboardRolePerson> VendorDashboardRolePersons
        {
            get
            {
                return _vendorDashboardRolePersons ?? (_vendorDashboardRolePersons = new FakeObjectSet<VendorDashboardRolePerson>());
            }
            set
            {
                _vendorDashboardRolePersons = value as FakeObjectSet<VendorDashboardRolePerson>;
            }
        }

        public IDbSet<Currency> Currencies
        {
            get
            {
                return _currencies ?? (_currencies = new FakeObjectSet<Currency>());
            }
            set
            {
                _currencies = value as FakeObjectSet<Currency>;
            }
        }

        public IDbSet<Status> Statuses
        {
            get
            {
                return _statuses ?? (_statuses = new FakeObjectSet<Status>());
            }
            set
            {
                _statuses = value as FakeObjectSet<Status>;
            }
        }

        public IDbSet<SiteAnalytic> SiteAnalytics
        {
            get
            {
                return _siteAnalytics ?? (_siteAnalytics = new FakeObjectSet<SiteAnalytic>());
            }
            set
            {
                _siteAnalytics = value as FakeObjectSet<SiteAnalytic>;
            }
        }

        public IDbSet<SiteAnalyticType> SiteAnalyticTypes
        {
            get
            {
                return _siteAnalyticTypes ?? (_siteAnalyticTypes = new FakeObjectSet<SiteAnalyticType>());
            }
            set
            {
                _siteAnalyticTypes = value as FakeObjectSet<SiteAnalyticType>;
            }
        }

        public IDbSet<SupportCategory> SupportCategories
        {
            get
            {
                return _supportCategories ?? (_supportCategories = new FakeObjectSet<SupportCategory>());
            }
            set
            {
                _supportCategories = value as FakeObjectSet<SupportCategory>;
            }
        }

        public IDbSet<SupportArea> SupportAreas
        {
            get
            {
                return _supportAreas ?? (_supportAreas = new FakeObjectSet<SupportArea>());
            }
            set
            {
                _supportAreas = value as FakeObjectSet<SupportArea>;
            }
        }

        public IDbSet<QAStatus> QAStatuses
        {
            get
            {
                return _qaStatuses ?? (_qaStatuses = new FakeObjectSet<QAStatus>());
            }
            set
            {
                _qaStatuses = value as FakeObjectSet<QAStatus>;
            }
        }

        public IDbSet<SupportAreaQA> SupportAreaQAs
        {
            get
            {
                return _supportAreaQAs ?? (_supportAreaQAs = new FakeObjectSet<SupportAreaQA>());
            }
            set
            {
                _supportAreaQAs = value as FakeObjectSet<SupportAreaQA>;
            }
        }

        public IDbSet<SupportAreaQACategory> SupportAreaQACategories
        {
            get
            {
                return _supportAreaQACategories ?? (_supportAreaQACategories = new FakeObjectSet<SupportAreaQACategory>());
            }
            set
            {
                _supportAreaQACategories = value as FakeObjectSet<SupportAreaQACategory>;
            }
        }

        public IDbSet<AdvertisingImageServer> AdvertisingImageServer
        {
            get
            {
                return _advertisingImageServer ?? (_advertisingImageServer = new FakeObjectSet<AdvertisingImageServer>());
            }
            set
            {
                _advertisingImageServer = value as FakeObjectSet<AdvertisingImageServer>;
            }
        }

        public IDbSet<ContentPage> ContentPages
        {
            get
            {
                return _contentPages ?? (_contentPages = new FakeObjectSet<ContentPage>());
            }
            set
            {
                _contentPages = value as FakeObjectSet<ContentPage>;
            }
        }

        public IDbSet<SiteMapNode> SiteMapNodes
        {
            get
            {
                return _siteMapNodes ?? (_siteMapNodes = new FakeObjectSet<SiteMapNode>());
            }
            set
            {
                _siteMapNodes = value as FakeObjectSet<SiteMapNode>;
            }
        }

        public int SaveChanges()
        {
            foreach (var cloudApplication in CloudApplications)
            {
                ((IValidate)cloudApplication).Validate(ChangeAction.Insert);
            }
            return 1;
        }
        public void Dispose() { }


        #endregion


        //public int GetStations(string startsWith)
        //{
        //    throw new InvalidOperationException();
        //}

        //System.Data.Entity.IDbSet<CloudApplication> ICloudCompareContext.CloudApplications
        //{
        //    get { return _cloudApplications; }
        //}

        //public System.Data.Entity.IDbSet<Vendor> Vendors
        //{
        //    get { return _vendors; }
        //}

        //public System.Data.Entity.IDbSet<Feature> Features
        //{
        //    get { return _features; }
        //}

        public CloudApplication FindById(int cloudApplicationId)
        {
            throw new NotImplementedException();
        }







        public System.Data.Objects.ObjectContext ObjectContext()
        {
            return (this as IObjectContextAdapter).ObjectContext;
        }
    }
}
