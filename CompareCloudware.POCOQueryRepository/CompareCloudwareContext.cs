using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using CompareCloudware.Domain.Models;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository.Configurations;

using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace CompareCloudware.POCOQueryRepository
{
    public class CompareCloudwareContext : DbContext, ICompareCloudwareContext
    {
        public IDbSet<CloudApplication> CloudApplications { get; set; }
        public IDbSet<Vendor> Vendors { get; set; }
        public IDbSet<VendorLogo> VendorLogos { get; set; }
        public IDbSet<Feature> Features { get; set; }
        public IDbSet<Domain.Models.OperatingSystem> OperatingSystems { get; set; }
        public IDbSet<MobilePlatform> MobilePlatforms { get; set; }
        public IDbSet<Browser> Browsers { get; set; }
        public IDbSet<LicenceTypeMinimum> LicenceTypeMinimums { get; set; }
        public IDbSet<LicenceTypeMaximum> LicenceTypeMaximums { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<SupportType> SupportTypes { get; set; }
        public IDbSet<SupportDays> SupportDays { get; set; }
        public IDbSet<SupportHours> SupportHours { get; set; }
        public IDbSet<CompareCloudware.Domain.Models.TimeZone> TimeZones { get; set; }
        public IDbSet<SupportTerritory> SupportTerritories { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<CategoryParameters> CategoryParameters { get; set; }
        public IDbSet<MinimumContract> MinimumContracts { get; set; }
        public IDbSet<PaymentFrequency> PaymentFrequencies { get; set; }
        public IDbSet<SetupFee> SetupFees { get; set; }
        public IDbSet<PaymentOption> PaymentOptions { get; set; }
        public IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; set; }
        public IDbSet<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
        public IDbSet<CloudApplicationApplication> CloudApplicationApplications { get; set; }
        public IDbSet<SimpleSearchInputs> SimpleSearchInputs { get; set; }
        public IDbSet<FeatureType> FeatureTypes { get; set; }
        public IDbSet<CloudApplicationProductReview> CloudApplicationProductReviews { get; set; }
        public IDbSet<CloudApplicationUserReview> CloudApplicationUserReviews { get; set; }
        public IDbSet<CloudApplicationDocument> CloudApplicationDocuments { get; set; }
        public IDbSet<CloudApplicationDocumentImage> CloudApplicationDocumentImages { get; set; }
        public IDbSet<CloudApplicationDocumentType> CloudApplicationDocumentTypes { get; set; }
        public IDbSet<CloudApplicationDocumentFormat> CloudApplicationDocumentFormats { get; set; }
        public IDbSet<AdvertisingImage> AdvertisingImages { get; set; }
        public IDbSet<AdvertisingImageType> AdvertisingImageTypes { get; set; }
        public IDbSet<Tag> Tags { get; set; }
        public IDbSet<TagType> TagTypes { get; set; }
        public IDbSet<ContentText> ContentText { get; set; }
        public IDbSet<ContentTextType> ContentTextTypes { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<CloudApplicationRequest> CloudApplicationRequests { get; set; }
        public IDbSet<Device> Devices { get; set; }
        public IDbSet<SiteActivity> SiteActivity { get; set; }
        public IDbSet<RequestType> RequestTypes { get; set; }
        public IDbSet<Industry> Industries { get; set; }
        public IDbSet<TermCondition> TermsConditions { get; set; }
        public IDbSet<CloudApplicationVideo> CloudApplicationVideos { get; set; }

        public IDbSet<Profile> Profiles { get; set; }
        public IDbSet<VendorDashboard> VendorDashboards { get; set; }
        public IDbSet<VendorDashboardRole> VendorDashboardRoles { get; set; }
        public IDbSet<VendorDashboardRolePerson> VendorDashboardRolePersons { get; set; }

        public IDbSet<Currency> Currencies { get; set; }
        public IDbSet<Status> Statuses { get; set; }

        public IDbSet<SiteAnalytic> SiteAnalytics { get; set; }
        public IDbSet<SiteAnalyticType> SiteAnalyticTypes { get; set; }

        public IDbSet<SupportCategory> SupportCategories { get; set; }
        public IDbSet<SupportArea> SupportAreas { get; set; }
        public IDbSet<QAStatus> QAStatuses { get; set; }
        public IDbSet<SupportAreaQA> SupportAreaQAs { get; set; }
        public IDbSet<SupportAreaQACategory> SupportAreaQACategories { get; set; }

        public IDbSet<AdvertisingImageServer> AdvertisingImageServer { get; set; }

        public IDbSet<ContentPage> ContentPages { get; set; }
        public IDbSet<SiteMapNode> SiteMapNodes { get; set; }

        //public IDbSet<SiteMapFrequencyEnum> SiteMapFrequenciesEnum { get; set; }

        public CompareCloudwareContext()
            : base()
        {
           
        }

        public CompareCloudwareContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CompareCloudwareContext>(null);
            //Database.SetInitializer(new DropCreateDatabaseAlways<CompareCloudwareContext>());

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CloudApplicationConfiguration());
            modelBuilder.Configurations.Add(new VendorConfiguration());
            modelBuilder.Configurations.Add(new VendorLogoConfiguration());
            modelBuilder.Configurations.Add(new FeatureConfiguration());
            modelBuilder.Configurations.Add(new OperatingSystemConfiguration());
            modelBuilder.Configurations.Add(new MobilePlatformConfiguration());
            modelBuilder.Configurations.Add(new BrowserConfiguration());
            modelBuilder.Configurations.Add(new LicenceTypeMinimumConfiguration());
            modelBuilder.Configurations.Add(new LicenceTypeMaximumConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new SupportTypeConfiguration());
            modelBuilder.Configurations.Add(new SupportDaysConfiguration());
            modelBuilder.Configurations.Add(new SupportHoursConfiguration());
            modelBuilder.Configurations.Add(new TimeZoneConfiguration());
            modelBuilder.Configurations.Add(new SupportTerritoryConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CategoryParametersConfiguration());
            modelBuilder.Configurations.Add(new MinimumContractConfiguration());
            modelBuilder.Configurations.Add(new PaymentFrequencyConfiguration());
            modelBuilder.Configurations.Add(new SetupFeeConfiguration());
            modelBuilder.Configurations.Add(new PaymentOptionConfiguration());
            modelBuilder.Configurations.Add(new FreeTrialPeriodConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationFeatureConfiguration());
            modelBuilder.Configurations.Add(new FeatureTypeConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationProductReviewConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationUserReviewConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationDocumentConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationDocumentImageConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationDocumentTypeConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationDocumentFormatConfiguration());
            modelBuilder.Configurations.Add(new AdvertisingImageConfiguration());
            modelBuilder.Configurations.Add(new AdvertisingImageTypeConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            modelBuilder.Configurations.Add(new TagTypeConfiguration());
            modelBuilder.Configurations.Add(new ContentTextConfiguration());
            modelBuilder.Configurations.Add(new ContentTextTypeConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationRequestConfiguration());
            modelBuilder.Configurations.Add(new DeviceConfiguration());
            modelBuilder.Configurations.Add(new SiteActivityConfiguration());
            modelBuilder.Configurations.Add(new RequestTypeConfiguration());
            modelBuilder.Configurations.Add(new IndustryConfiguration());
            modelBuilder.Configurations.Add(new TermConditionConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationVideoConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationApplicationConfiguration());

            modelBuilder.Configurations.Add(new ProfileConfiguration());
            modelBuilder.Configurations.Add(new VendorDashboardConfiguration());
            modelBuilder.Configurations.Add(new VendorDashboardRoleConfiguration());
            modelBuilder.Configurations.Add(new VendorDashboardRolePersonConfiguration());

            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());

            modelBuilder.Ignore<SearchResult>();
            modelBuilder.Ignore<TabbedSearchResults>();
            modelBuilder.Ignore<SimpleSearchInputs>();
            modelBuilder.Ignore<TagResult>();

            modelBuilder.Configurations.Add(new SiteAnalyticConfiguration());
            modelBuilder.Configurations.Add(new SiteAnalyticTypeConfiguration());

            modelBuilder.Configurations.Add(new SupportCategoryConfiguration());
            modelBuilder.Configurations.Add(new SupportAreaConfiguration());
            modelBuilder.Configurations.Add(new QAStatusConfiguration());
            modelBuilder.Configurations.Add(new SupportAreaQAConfiguration());
            modelBuilder.Configurations.Add(new SupportAreaQACategoryConfiguration());

            modelBuilder.Configurations.Add(new AdvertisingImageServerConfiguration());

            modelBuilder.Configurations.Add(new SiteMapNodeConfiguration());
            modelBuilder.Configurations.Add(new ContentPageConfiguration());

            modelBuilder.Ignore<SiteMapNode>();

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<CloudApplication>().HasRequired(x => x.CloudApplicationStatus).WithRequiredDependent().WillCascadeOnDelete(false);
            //SimpleSearchInputs.Include(x => x.Categories);
            //this.Configuration.ProxyCreationEnabled = false;
            //this.Configuration.LazyLoadingEnabled = false;

            //modelBuilder.Entity<Tag>()
            //    .HasRequired(t => t.TagCloudApplication)
            //    .WithOptional(t => t.CloudApplicationShopTag)
            //    //    .Map(k => k.MapKey("TagID"))
            //    ;

            //modelBuilder.Entity<CloudApplication>()
            //    .HasRequired(ca => ca.CloudApplicationShopTag)
            //    .WithRequiredDependent(c => c.TagCloudApplication)
            //    //.Map(k => k.MapKey("CloudApplicationShopTagID"))
            //; 
            
            //modelBuilder.Entity<Tag>().HasOptional<CloudApplication>(t => t.CloudApplication).WithOptionalDependent(ca => ca.CloudApplicationShopTag);
        }

        public CloudApplication FindById(int cloudApplicationId)
        {
            return CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationId).SingleOrDefault();
        }

        //IDbSet<CloudApplication> ICloudCompareContext.CloudApplications
        //{
        //    get { return CloudApplications; }
        //}

        //IDbSet<Vendor> ICloudCompareContext.Vendors
        //{
        //    get { return Vendors; }
        //}

        //IDbSet<Feature> ICloudCompareContext.Features
        //{
        //    get { return Features; }
        //}

        public ObjectContext ObjectContext()
        {
            return (this as IObjectContextAdapter).ObjectContext;
        }
    }
}
