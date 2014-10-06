using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class ProjectManagementProductionData
    {

        public static bool PumpProjectManagementData(QueryRepository repository)
        {
            string PDF_TEST_WHITE_PAPER_FILEPATH = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            //string PDF_TEST_WHITE_PAPER_FILENAME = "grohe_bathroom_brochure.pdf";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\";
            //int PDF_TEST_WHITE_PAPER_PAGE_COUNT = 257;
            int PDF_TEST_WHITE_PAPER_PAGE_COUNT = 8;
            int IMAGE_FILE_WIDTH = 50;
            int IMAGE_FILE_HEIGHT = 50;
            string PDF_TEST_CASE_STUDY_FILEPATH = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\CaseStudies\\";
            //string PDF_TEST_CASE_STUDY_FILENAME = "pdftown.com_986_ac-electrics.pdf";
            //int PDF_TEST_CASE_STUDY_PAGE_COUNT = 146;
            int PDF_TEST_CASE_STUDY_PAGE_COUNT = 1;
            CloudApplication ca;

            string PDF_TEST_WHITE_PAPER_FILENAME = "words.pdf";
            string PDF_TEST_CASE_STUDY_FILENAME = "adobeid.pdf";

            int categoryID = repository.FindCategoryByName("PROJECT MANAGEMENT").CategoryID;

            bool retVal = true;

            #region APPLICATIONS

            #region PROJECT MANAGEMENT

            #region ZOHO PROJECTS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "ZOHO Projects",
                ServiceName = "Premium",
                CompanyURL = "www.zoho.com/projects",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ZOHO Projects"),
                Description = "Zoho Projects is the integrated project management solution that simplifies and speeds every project, every time. Whether your team is 3 or 30, you can make sure everyone’s on the same page and working toward the same goal. The result is coordinated, unified process that slashes project time, saves money, and enhances project quality. Start working smarter, faster with Zoho Projects today.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohoprojects",
                FacebookName = "ZOHO-Project-Management-Software",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CLIENT INVOICING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PROJECT WIKI")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO PROJECTS ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "ZOHO Projects",
                ServiceName = "Enterprise",
                CompanyURL = "www.zoho.com/projects",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ZOHO Projects"),
                Description = "Zoho Projects is the integrated project management solution that simplifies and speeds every project, every time. Whether your team is 3 or 30, you can make sure everyone’s on the same page and working toward the same goal. The result is coordinated, unified process that slashes project time, saves money, and enhances project quality. Start working smarter, faster with Zoho Projects today.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohoprojects",
                FacebookName = "ZOHO-Project-Management-Software",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 30;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CLIENT INVOICING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PROJECT WIKI")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO PROJECTS EXPRESS
            ca = new CloudApplication()
            {
                Brand = "ZOHO Projects",
                ServiceName = "Express",
                CompanyURL = "www.zoho.com/projects",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    //repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    //repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ZOHO Projects"),
                Description = "Zoho Projects is the integrated project management solution that simplifies and speeds every project, every time. Whether your team is 3 or 30, you can make sure everyone’s on the same page and working toward the same goal. The result is coordinated, unified process that slashes project time, saves money, and enhances project quality. Start working smarter, faster with Zoho Projects today.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohoprojects",
                FacebookName = "ZOHO-Project-Management-Software",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CLIENT INVOICING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PROJECT WIKI")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ATTASK
            ca = new CloudApplication()
            {
                Brand = "@task",
                ServiceName = "Full User",
                CompanyURL = "www.attask.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 39.95M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("@task"),
                Description = "We make software that goes beyond project management and encourages accountability, visibility, and efficiency—making it possible for you to do your best work in an environment that fosters productivity, motivation, and results.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 48453,
                TwitterName = "@AtTask",
                FacebookName = "AtTask",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MAVENLINK FREE
            ca = new CloudApplication()
            {
                Brand = "mavenlink",
                ServiceName = "Free",
                CompanyURL = "www.mavenlink.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    //repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    //repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    //repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("mavenlink"),
                Description = "Go beyond project management and start managing your business. Collaborate, track tasks, enter your time, work within a budget, and send invoices. All in one place. Mavenlink makes it easy to complete projects online with your clients, colleagues, and partners. Centralize your information and communications in a secure, shared workspace. All of Mavenlink's collaboration capabilities are available right from your HTML5-enabled smartphone. See your latest project communications in a single activity stream, view associated files and Google Documents, and reply while you're on the road.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 362958,
                TwitterName = "mavenlink",
                FacebookName = "mavenlink",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 0.5m;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MAVENLINK EXPERT
            ca = new CloudApplication()
            {
                Brand = "mavenlink",
                ServiceName = "Expert",
                CompanyURL = "www.mavenlink.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("mavenlink"),
                Description = "Go beyond project management and start managing your business. Collaborate, track tasks, enter your time, work within a budget, and send invoices. All in one place. Mavenlink makes it easy to complete projects online with your clients, colleagues, and partners. Centralize your information and communications in a secure, shared workspace. All of Mavenlink's collaboration capabilities are available right from your HTML5-enabled smartphone. See your latest project communications in a single activity stream, view associated files and Google Documents, and reply while you're on the road.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 362958,
                TwitterName = "mavenlink",
                FacebookName = "mavenlink",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MAVENLINK GURU
            ca = new CloudApplication()
            {
                Brand = "mavenlink",
                ServiceName = "Guru",
                CompanyURL = "www.mavenlink.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("mavenlink"),
                Description = "Go beyond project management and start managing your business. Collaborate, track tasks, enter your time, work within a budget, and send invoices. All in one place. Mavenlink makes it easy to complete projects online with your clients, colleagues, and partners. Centralize your information and communications in a secure, shared workspace. All of Mavenlink's collaboration capabilities are available right from your HTML5-enabled smartphone. See your latest project communications in a single activity stream, view associated files and Google Documents, and reply while you're on the road.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 362958,
                TwitterName = "mavenlink",
                FacebookName = "mavenlink",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MAVENLINK MAVEN
            ca = new CloudApplication()
            {
                Brand = "mavenlink",
                ServiceName = "Maven",
                CompanyURL = "www.mavenlink.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 187.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("mavenlink"),
                Description = "Go beyond project management and start managing your business. Collaborate, track tasks, enter your time, work within a budget, and send invoices. All in one place. Mavenlink makes it easy to complete projects online with your clients, colleagues, and partners. Centralize your information and communications in a secure, shared workspace. All of Mavenlink's collaboration capabilities are available right from your HTML5-enabled smartphone. See your latest project communications in a single activity stream, view associated files and Google Documents, and reply while you're on the road.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 362958,
                TwitterName = "mavenlink",
                FacebookName = "mavenlink",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLARIZEN
            ca = new CloudApplication()
            {
                Brand = "clarizen",
                ServiceName = "Professional",
                CompanyURL = "www.clarizen.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.95M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("clarizen"),
                Description = "Clarizen’s pure Cloud based project execution platform goes beyond project management, giving your whole team a centralized environment to manage projects, tasks, resources, budgets – as well as associate emails, chat and documents - with in an intuitive, easy to use UI. Project managers and organizations get real-time visibility and clarity, enabling them to make decisions based on data, not guesswork.  Users of the system gain a flexible, task management tool to help them understand priorities and get the important work done on time.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 28265,
                TwitterName = "clarizen",
                FacebookName = "clarizen",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROWORKFLOW STANDARD
            ca = new CloudApplication()
            {
                Brand = "ProWorkflow",
                ServiceName = "Standard",
                CompanyURL = "www.proworkflow.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    //repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ProWorkflow"),
                Description = "ProWorkflow is a fast, easy to use project management, workflow and time tracking solution for small to medium businesses. The application has been designed from the ground up with your most important asset in mind: Your staff! ProWorkflow enables you to keep accurate time-keeping records, organize, plan, and delegate jobs and tasks whilst using the timeline to have an overview of company activity. The information ProWorkflow collects allows you to measure and analyze your company performance so that you can streamline to improve profit margins. Setup a Free Trial Account to see for yourself how easy ProWorkflow is to use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "ProWorkflow",
                FacebookName = "ProWorkflow",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 5;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROWORKFLOW PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "ProWorkflow",
                ServiceName = "Professional",
                CompanyURL = "www.proworkflow.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ProWorkflow"),
                Description = "ProWorkflow is a fast, easy to use project management, workflow and time tracking solution for small to medium businesses. The application has been designed from the ground up with your most important asset in mind: Your staff! ProWorkflow enables you to keep accurate time-keeping records, organize, plan, and delegate jobs and tasks whilst using the timeline to have an overview of company activity. The information ProWorkflow collects allows you to measure and analyze your company performance so that you can streamline to improve profit margins. Setup a Free Trial Account to see for yourself how easy ProWorkflow is to use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "ProWorkflow",
                FacebookName = "ProWorkflow",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROWORKFLOW ADVANCED
            ca = new CloudApplication()
            {
                Brand = "ProWorkflow",
                ServiceName = "Advanced",
                CompanyURL = "www.proworkflow.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 30.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ProWorkflow"),
                Description = "ProWorkflow is a fast, easy to use project management, workflow and time tracking solution for small to medium businesses. The application has been designed from the ground up with your most important asset in mind: Your staff! ProWorkflow enables you to keep accurate time-keeping records, organize, plan, and delegate jobs and tasks whilst using the timeline to have an overview of company activity. The information ProWorkflow collects allows you to measure and analyze your company performance so that you can streamline to improve profit margins. Setup a Free Trial Account to see for yourself how easy ProWorkflow is to use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "ProWorkflow",
                FacebookName = "ProWorkflow",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE CORE COLLABORATION
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Core Collaboration",
                CompanyURL = "www.hyperoffice.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 7.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "HyperOffice's flexibility, simplicity and breadth of functionality makes it suitable for use in a range of business situations. Companies use it as a company intranet software, a hosted email solution, a project management tool, for document management, a mobile collaboration solution or as an alternative to expensive and complex enterprise software like Microsoft SharePoint and Exchange.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = .25M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE ENTERPRISE COLLABORATION
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Enterprise Collaboration",
                CompanyURL = "www.hyperoffice.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "HyperOffice's flexibility, simplicity and breadth of functionality makes it suitable for use in a range of business situations. Companies use it as a company intranet software, a hosted email solution, a project management tool, for document management, a mobile collaboration solution or as an alternative to expensive and complex enterprise software like Microsoft SharePoint and Exchange.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = .25M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE A LA CARTE
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "A La Carte",
                CompanyURL = "www.hyperoffice.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 3.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "HyperOffice's flexibility, simplicity and breadth of functionality makes it suitable for use in a range of business situations. Companies use it as a company intranet software, a hosted email solution, a project management tool, for document management, a mobile collaboration solution or as an alternative to expensive and complex enterprise software like Microsoft SharePoint and Exchange.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = .25M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DOCUMENT SHARING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SHARED WORKSPACE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EDITED DOCUMENT TRACKING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCKFILES")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UPDATE & DEADLINE ALERTS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERACTIVE GANTT CHARTS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TIME BUDGET TRACKING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CLIENT INVOICING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PROJECT WIKI")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CUSTOMISED REPORTS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MS PROJECT COMPATIBLE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MILITARY GRADE DOCUMENT SECURITY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("GUARANTEED RESTORE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("OFFLINE MODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("3RD PARTY APIS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("BUG TRACKER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WORKETC
            ca = new CloudApplication()
            {
                Brand = "WORKetc",
                ServiceName = "Project Management",
                CompanyURL = "www.attask.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("WORKetc"),
                Description = "WORK[etc] helps over 1000 businesses in over 20 countries solve their problem.  We offer real support from talented people.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 983909,
                TwitterName = "WORKetc",
                FacebookName = "WorKetc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIQUIDPLANNER
            ca = new CloudApplication()
            {
                Brand = "LiquidPlanner",
                ServiceName = "Monthly Plan",
                CompanyURL = "www.liquidplanner.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("LiquidPlanner"),
                Description = "Meet the easiest multi-project scheduling system on the planet. LiquidPlanner’s unique, priority-based scheduling engine saves you hours of work each week, and gives you faster, more accurate results than any manual process you’ve used in the past.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 297785,
                TwitterName = "LiquidPlanner",
                FacebookName = "LiquidPlanner",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CELOXIS
            ca = new CloudApplication()
            {
                Brand = "CELOXIS",
                ServiceName = "Hosted Version",
                CompanyURL = "www.celoxis.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 14.95M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("CELOXIS"),
                Description = "Celoxis offers a comprehensive web based project management softwarealong with great integrated tools to manage your resources, collaboration, time sheets, expenses and workflow. If you have outgrown simple to-do list management tools, Celoxis is for you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2506502,
                TwitterName = "CELOXIS",
                FacebookName = "CELOXIS",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = .5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO SINGLE USER
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "Single User",
                CompanyURL = "www.bluecamroo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("AUD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = "Business runs better when everyone is on the same page.  But with customer data, project data and other key information spread across email, spreadsheets and stand-alone systems that don't communicate, many businesses struggle to keep their teams effective.  BlueCamroo is the answer. A single, integrated, affordable web-based solution with a unique, patent-pending CRM concept that combines CRM, Social CRM, Project Management, Team Collaboration, Customer Support, Task Management, Time Tracking, Billing, Online Payments, Expenses Management, Email Marketing and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 649840,
                TwitterName = "@bluecamroo",
                FacebookName = "BlueCamroo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO 3 USERS
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "3 Users",
                CompanyURL = "www.bluecamroo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(3),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("AUD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = "Business runs better when everyone is on the same page.  But with customer data, project data and other key information spread across email, spreadsheets and stand-alone systems that don't communicate, many businesses struggle to keep their teams effective.  BlueCamroo is the answer. A single, integrated, affordable web-based solution with a unique, patent-pending CRM concept that combines CRM, Social CRM, Project Management, Team Collaboration, Customer Support, Task Management, Time Tracking, Billing, Online Payments, Expenses Management, Email Marketing and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 649840,
                TwitterName = "@bluecamroo",
                FacebookName = "BlueCamroo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 6;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO 6 USERS
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "6 Users",
                CompanyURL = "www.bluecamroo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(6),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("AUD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = "Business runs better when everyone is on the same page.  But with customer data, project data and other key information spread across email, spreadsheets and stand-alone systems that don't communicate, many businesses struggle to keep their teams effective.  BlueCamroo is the answer. A single, integrated, affordable web-based solution with a unique, patent-pending CRM concept that combines CRM, Social CRM, Project Management, Team Collaboration, Customer Support, Task Management, Time Tracking, Billing, Online Payments, Expenses Management, Email Marketing and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 649840,
                TwitterName = "@bluecamroo",
                FacebookName = "BlueCamroo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 12;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO 10 USERS
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "10 Users",
                CompanyURL = "www.bluecamroo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("AUD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = "Business runs better when everyone is on the same page.  But with customer data, project data and other key information spread across email, spreadsheets and stand-alone systems that don't communicate, many businesses struggle to keep their teams effective.  BlueCamroo is the answer. A single, integrated, affordable web-based solution with a unique, patent-pending CRM concept that combines CRM, Social CRM, Project Management, Team Collaboration, Customer Support, Task Management, Time Tracking, Billing, Online Payments, Expenses Management, Email Marketing and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 649840,
                TwitterName = "@bluecamroo",
                FacebookName = "BlueCamroo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO 10+ USERS
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "10+ Users",
                CompanyURL = "www.bluecamroo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonthFrom = 268.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("AUD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = "Business runs better when everyone is on the same page.  But with customer data, project data and other key information spread across email, spreadsheets and stand-alone systems that don't communicate, many businesses struggle to keep their teams effective.  BlueCamroo is the answer. A single, integrated, affordable web-based solution with a unique, patent-pending CRM concept that combines CRM, Social CRM, Project Management, Team Collaboration, Customer Support, Task Management, Time Tracking, Billing, Online Payments, Expenses Management, Email Marketing and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 649840,
                TwitterName = "@bluecamroo",
                FacebookName = "BlueCamroo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.IsScaledPrice = true;
            ca.ApplicationCostPerMonthSuffix = "for 15 users";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 30;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTMANAGER.COM STARTER
            ca = new CloudApplication()
            {
                Brand = "PROJECTMANAGER.com",
                ServiceName = "Starter",
                CompanyURL = "www.projectmanager.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 25.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("PROJECTMANAGER.com"),
                Description = "The Best Way to Manage Your Projects.  Trusted by Teams in 100 Countries.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 411289,
                TwitterName = "@ProjectTips",
                FacebookName = "ProjectManagercom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTMANAGER.COM TEAM
            ca = new CloudApplication()
            {
                Brand = "PROJECTMANAGER.com",
                ServiceName = "Team",
                CompanyURL = "www.projectmanager.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("PROJECTMANAGER.com"),
                Description = "The Best Way to Manage Your Projects.  Trusted by Teams in 100 Countries.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 411289,
                TwitterName = "@ProjectTips",
                FacebookName = "ProjectManagercom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTMANAGER.COM BUSINESS
            ca = new CloudApplication()
            {
                Brand = "PROJECTMANAGER.com",
                ServiceName = "Business",
                CompanyURL = "www.projectmanager.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("PROJECTMANAGER.com"),
                Description = "The Best Way to Manage Your Projects.  Trusted by Teams in 100 Countries.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 411289,
                TwitterName = "@ProjectTips",
                FacebookName = "ProjectManagercom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region COLLABORATECLOUD
            //ca = new CloudApplication()
            //{
            //    Brand = "CollaborateCloud",
            //    ServiceName = "Basic Plus",
            //    CompanyURL = "www.collaboratecloud.com",
            //    Devices = new List<Device>()
            //    {
            //        repository.FindDeviceByName("MOBILE"),
            //        repository.FindDeviceByName("TABLET"),
            //        repository.FindDeviceByName("DESKTOP"),
            //        repository.FindDeviceByName("LAPTOP"),
            //    },
            //    OperatingSystems = new List<Domain.Models.OperatingSystem>()
            //    {
            //        repository.FindOperatingSystemByName("OSX"),
            //        repository.FindOperatingSystemByName("WIN XP"),
            //        repository.FindOperatingSystemByName("WIN VISTA"),
            //        repository.FindOperatingSystemByName("WIN 7"),
            //        repository.FindOperatingSystemByName("WIN 8"),
            //        //repository.FindOperatingSystemByName("LINUX"),
            //        repository.FindOperatingSystemByName("APPLE IOS"),
            //        repository.FindOperatingSystemByName("WINDOWS 8 RT"),
            //        repository.FindOperatingSystemByName("ANDROID"),
            //        repository.FindOperatingSystemByName("BBOS"),
            //    },
            //    //MobilePlatforms = repository.GetAllMobilePlatforms(),
            //    MobilePlatforms = new List<MobilePlatform>()
            //    {
            //        repository.FindMobilePlatformByName("ANDROID"),
            //        repository.FindMobilePlatformByName("IPHONE"),
            //        repository.FindMobilePlatformByName("BLACKBERRY"),
            //        //repository.FindMobilePlatformByName("IPAD")
            //    },
            //    Browsers = new List<Browser>()
            //    {
            //        repository.FindBrowserByName("IE6"),
            //        repository.FindBrowserByName("IE7"),
            //        repository.FindBrowserByName("IE8"),
            //        repository.FindBrowserByName("IE9"),
            //        repository.FindBrowserByName("FIREFOX"),
            //        repository.FindBrowserByName("CHROME"),
            //        repository.FindBrowserByName("SAFARI"),
            //    },
            //    LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
            //    LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
            //    Languages = new List<Language>()
            //    {
            //        repository.FindLanguageByName("ENGLISH")
            //    },
            //    SupportTypes = new List<SupportType>()
            //    {
            //        //repository.FindSupportTypeByName("TELEPHONE"),
            //        repository.FindSupportTypeByName("ONLINE"),
            //        //repository.FindSupportTypeByName("EMAIL")
            //    },
            //    SupportHours = repository.FindSupportHoursByName("24 HOURS"),
            //    SupportDays = repository.FindSupportDaysByName("7"),
            //    SupportTerritories = new List<SupportTerritory>()
            //    {
            //        repository.FindSupportTerritoryByName("GLOBAL"),
            //    },
            //    VideoTrainingSupport = false,
            //    //MaximumMeetingAttendees = 50,
            //    //MaximumWebinarAttendees = 0,
            //    CloudApplicationFeatures = new List<CloudApplicationFeature>()
            //    {
            //        repository.FindFeatureByName("NUMBER OF PROJECTS"),
            //        repository.FindFeatureByName("FILE STORAGE"),
            //        repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
            //        repository.FindFeatureByName("DOCUMENT SHARING"),
            //        repository.FindFeatureByName("SHARED WORKSPACE"),
            //        repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
            //        repository.FindFeatureByName("LOCKFILES"),
            //        repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
            //        repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
            //        repository.FindFeatureByName("TIME BUDGET TRACKING"),
            //        //repository.FindFeatureByName("CLIENT INVOICING"),
            //        //repository.FindFeatureByName("PROJECT WIKI"),
            //        repository.FindFeatureByName("CUSTOMISED REPORTS"),
            //        repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
            //        repository.FindFeatureByName("SSL SECURITY"),
            //        repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
            //        repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
            //        //repository.FindFeatureByName("OFFLINE MODE"),
            //        //repository.FindFeatureByName("3RD PARTY APIS"),
            //        //repository.FindFeatureByName("BUG TRACKER"),
            //    },
            //    ApplicationCostPerMonth = 29.00M,
            //    ApplicationCostPerAnnum = 0.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthOffered = false,
                //ApplicationCostPerAnnumFree = false,
                //ApplicationCostPerAnnumOffered = false,
                //CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
            //    //CallsPackageCostPerMonth = 0M,
            //    SetupFee = repository.FindSetupFeeByName("NO"),
            //    MinimumContract = repository.FindMinimumContractByName("12"),
            //    PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
            //    PaymentOptions = new List<PaymentOption>()
            //    {
            //        repository.FindPaymentOptionByName("CREDIT CARD"),
            //        repository.FindPaymentOptionByName("PRE-PAY"),
            //    },
            //    FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
            //    Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            //    Vendor = repository.FindVendorByName("CollaborateCloud"),
            //    Description = "Collaborate Cloud is a social work management platform that empowers organizations to communicate & collaborate within their organization more effectively, be more productive and manage all their work. It lets them setup their own workflows and work the way they want to and still stay organized & on top of everything.",
            //    AddDate = DateTime.Now,
            //    #region Ratings,Reviews,Case Studies,White Papers
            //    UserReviews = new List<CloudApplicationRating>()
            //    {
            //        new CloudApplicationRating()
            //        {
            //            CloudApplicationRatingText = repository.GetDescription(),
            //            CloudApplicationRatingReviewerCompany = "Reviewer Company",
            //            CloudApplicationRatingReviewerSurname = "Reviewer Name",
            //            CloudApplicationRatingReviewerTitle = "Reviewer Title",
            //            CloudApplicationReviewIndustry = repository.GetIndustry(81),
            //            CloudApplicationReviewEmployeeCount = 50,
            //        },
            //        new CloudApplicationRating()
            //        {
            //            CloudApplicationRatingText = repository.GetDescription(),
            //            CloudApplicationRatingReviewerCompany = "Reviewer Company",
            //            CloudApplicationRatingReviewerSurname = "Reviewer Name",
            //            CloudApplicationRatingReviewerTitle = "Reviewer Title",
            //            CloudApplicationReviewIndustry = repository.GetIndustry(81),
            //            CloudApplicationReviewEmployeeCount = 50,
            //        },
            //        new CloudApplicationRating()
            //        {
            //            CloudApplicationRatingText = repository.GetDescription(),
            //            CloudApplicationRatingReviewerCompany = "Reviewer Company",
            //            CloudApplicationRatingReviewerSurname = "Reviewer Name",
            //            CloudApplicationRatingReviewerTitle = "Reviewer Title",
            //            CloudApplicationReviewIndustry = repository.GetIndustry(81),
            //            CloudApplicationReviewEmployeeCount = 50,
            //        },
            //        new CloudApplicationRating()
            //        {
            //            CloudApplicationRatingText = repository.GetDescription(),
            //            CloudApplicationRatingReviewerCompany = "Reviewer Company",
            //            CloudApplicationRatingReviewerSurname = "Reviewer Name",
            //            CloudApplicationRatingReviewerTitle = "Reviewer Title",
            //            CloudApplicationReviewIndustry = repository.GetIndustry(81),
            //            CloudApplicationReviewEmployeeCount = 50,
            //        },
            //    },
            //   ProductReviews = new List<CloudApplicationReview>()
            //    {
            //        new CloudApplicationReview()
            //        {
            //            CloudApplicationReviewText = repository.GetDescription(),
            //            CloudApplicationReviewDate = DateTime.Now,
            //            CloudApplicationReviewPublisherName = FakeData.GetPublisherName(1),
            //            CloudApplicationReviewHeadline = FakeData.GetPublisherHeadline(),
            //        },
            //        new CloudApplicationReview()
            //        {
            //            CloudApplicationReviewText = repository.GetDescription(),
            //            CloudApplicationReviewDate = DateTime.Now,
            //            CloudApplicationReviewPublisherName = FakeData.GetPublisherName(2),
            //            CloudApplicationReviewHeadline = FakeData.GetPublisherHeadline(),
            //        },
            //        new CloudApplicationReview()
            //        {
            //            CloudApplicationReviewText = repository.GetDescription(),
            //            CloudApplicationReviewDate = DateTime.Now,
            //            CloudApplicationReviewPublisherName = FakeData.GetPublisherName(1),
            //            CloudApplicationReviewHeadline = FakeData.GetPublisherHeadline(),
            //        },
            //        new CloudApplicationReview()
            //        {
            //            CloudApplicationReviewText = repository.GetDescription(),
            //            CloudApplicationReviewDate = DateTime.Now,
            //            CloudApplicationReviewPublisherName = FakeData.GetPublisherName(2),
            //            CloudApplicationReviewHeadline = FakeData.GetPublisherHeadline(),
            //        },
            //    },
            //    Documents = new List<Document>()
            //    {
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
            //            DocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
            //        },
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
            //            DocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
            //        },
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
            //            DocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
            //        },
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
            //            DocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
            //        },
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
            //            DocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
            //        },
            //        new Document()
            //        {
            //            DocumentTitle = repository.GetDescription(4),
            //            DocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
            //            //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
            //            DocumentURL = "http://www.bbc.co.uk",
            //            DocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
            //            DocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
            //        },
            //    },
            //    #endregion
            //};

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 45;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            //repository.AddCloudApplication(ca);

            #endregion

            #region COPPER STUDIO
            ca = new CloudApplication()
            {
                Brand = "copper",
                ServiceName = "Studio",
                CompanyURL = "www.copperproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("copper"),
                Description = "Copper is one of the most refined and trusted project management tools available online, and is designed for any team that needs to plan and execute multi-resource projects.                            For over ten years we've helped thousands of organizations manage their projects, tasks, clients, people and files securely in the cloud. If you're reading this, it probably means you'd like to solve a similar problem! ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1055409,
                TwitterName = "copper",
                FacebookName = "CopperProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region COPPER CORPORATE
            ca = new CloudApplication()
            {
                Brand = "copper",
                ServiceName = "Corporate",
                CompanyURL = "www.copperproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(26),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("copper"),
                Description = "Copper is one of the most refined and trusted project management tools available online, and is designed for any team that needs to plan and execute multi-resource projects.                            For over ten years we've helped thousands of organizations manage their projects, tasks, clients, people and files securely in the cloud. If you're reading this, it probably means you'd like to solve a similar problem! ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1055409,
                TwitterName = "copper",
                FacebookName = "CopperProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region COPPER PREMIUM
            ca = new CloudApplication()
            {
                Brand = "copper",
                ServiceName = "Premium",
                CompanyURL = "www.copperproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(100),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 149.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("copper"),
                Description = "Copper is one of the most refined and trusted project management tools available online, and is designed for any team that needs to plan and execute multi-resource projects.                            For over ten years we've helped thousands of organizations manage their projects, tasks, clients, people and files securely in the cloud. If you're reading this, it probably means you'd like to solve a similar problem! ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1055409,
                TwitterName = "copper",
                FacebookName = "CopperProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTPLACE ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "projectplace",
                ServiceName = "Enterprise",
                CompanyURL = "www.projectplace.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 36.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("projectplace"),
                Description = "ProjectPlace is an online collaboration tool that allows you to manage single or multiple projects in a simple and efficient way.Projectplace is a tool that enables you to manage single or multiple projects in a simple and efficient way. The fresh, clean and streamlined interface lets you quickly get your projects up-and-running and involve anyone, wherever they are. Communicate, plan, collaborate, organize, meet and share. Projectplace helps you work together in a smart way, saving time and reaching your goals faster.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26385,
                TwitterName = "projectplace",
                FacebookName = "Projectplace",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Project";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTPLACE MULTI
            ca = new CloudApplication()
            {
                Brand = "projectplace",
                ServiceName = "Multi",
                CompanyURL = "www.projectplace.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 26.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("projectplace"),
                Description = "ProjectPlace is an online collaboration tool that allows you to manage single or multiple projects in a simple and efficient way.Projectplace is a tool that enables you to manage single or multiple projects in a simple and efficient way. The fresh, clean and streamlined interface lets you quickly get your projects up-and-running and involve anyone, wherever they are. Communicate, plan, collaborate, organize, meet and share. Projectplace helps you work together in a smart way, saving time and reaching your goals faster.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26385,
                TwitterName = "projectplace",
                FacebookName = "Projectplace",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 5;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTPLACE TEAM
            ca = new CloudApplication()
            {
                Brand = "projectplace",
                ServiceName = "Team",
                CompanyURL = "www.projectplace.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 16.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("projectplace"),
                Description = "ProjectPlace is an online collaboration tool that allows you to manage single or multiple projects in a simple and efficient way.Projectplace is a tool that enables you to manage single or multiple projects in a simple and efficient way. The fresh, clean and streamlined interface lets you quickly get your projects up-and-running and involve anyone, wherever they are. Communicate, plan, collaborate, organize, meet and share. Projectplace helps you work together in a smart way, saving time and reaching your goals faster.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26385,
                TwitterName = "projectplace",
                FacebookName = "Projectplace",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 1;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Project";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BASECAMP 10
            ca = new CloudApplication()
            {
                Brand = "Basecamp",
                ServiceName = "Basecamp 10",
                CompanyURL = "www.basecamphg.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Basecamp"),
                Description = "Honest prices, no surprises is our motto. Basecamp projects keep everything together.  With an entire project on one page, nothing gets lost and your team always knows where things are.  Nothing else is quite like basecamp.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2832115,
                TwitterName = "Basecamp",
                FacebookName = "Basecamp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 10;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 3;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BASECAMP 40
            ca = new CloudApplication()
            {
                Brand = "Basecamp",
                ServiceName = "Basecamp 40",
                CompanyURL = "www.basecamphg.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 50.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Basecamp"),
                Description = "Honest prices, no surprises is our motto. Basecamp projects keep everything together.  With an entire project on one page, nothing gets lost and your team always knows where things are.  Nothing else is quite like basecamp.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2832115,
                TwitterName = "Basecamp",
                FacebookName = "Basecamp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 40;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BASECAMP 100
            ca = new CloudApplication()
            {
                Brand = "Basecamp",
                ServiceName = "Basecamp 100",
                CompanyURL = "www.basecamphg.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 100.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Basecamp"),
                Description = "Honest prices, no surprises is our motto. Basecamp projects keep everything together.  With an entire project on one page, nothing gets lost and your team always knows where things are.  Nothing else is quite like basecamp.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2832115,
                TwitterName = "Basecamp",
                FacebookName = "Basecamp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 40;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BASECAMP UNLIMITED
            ca = new CloudApplication()
            {
                Brand = "Basecamp",
                ServiceName = "Basecamp Unlimited",
                CompanyURL = "www.basecamphg.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 150.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Basecamp"),
                Description = "Honest prices, no surprises is our motto. Basecamp projects keep everything together.  With an entire project on one page, nothing gets lost and your team always knows where things are.  Nothing else is quite like basecamp.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2832115,
                TwitterName = "Basecamp",
                FacebookName = "Basecamp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TRAFFICLIVE STUDIO
            ca = new CloudApplication()
            {
                Brand = "trafficLIVE",
                ServiceName = "Studio",
                CompanyURL = "www.trafficlive.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("Telephone"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 26.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("trafficLIVE"),
                Description = "Traffic LIVE is software that solves the problem of studio management, project management, time recording and scheduling for creative businesses. Traffic LIVE takes the drudgery out of things. Schedules cover lunch, public holidays and afternoons off for company BBQ’s. It tells you who can do the job and if they are free. It lets you split and re-allocate work as you choose. It tells you if something has happened you need to know about. It lets you babble on jobs to collaborate and communicate as a team. All seem obvious? Maybe, but no other system does it!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "trafficLIVE",
                FacebookName = "trafficLIVE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = .5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TRAFFICLIVE PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "trafficLIVE",
                ServiceName = "Professional",
                CompanyURL = "www.trafficlive.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("Telephone"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 34.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("trafficLIVE"),
                Description = "Traffic LIVE is software that solves the problem of studio management, project management, time recording and scheduling for creative businesses. Traffic LIVE takes the drudgery out of things. Schedules cover lunch, public holidays and afternoons off for company BBQ’s. It tells you who can do the job and if they are free. It lets you split and re-allocate work as you choose. It tells you if something has happened you need to know about. It lets you babble on jobs to collaborate and communicate as a team. All seem obvious? Maybe, but no other system does it!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "trafficLIVE",
                FacebookName = "trafficLIVE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TRAFFICLIVE PREMIUM
            ca = new CloudApplication()
            {
                Brand = "trafficLIVE",
                ServiceName = "Premium",
                CompanyURL = "www.trafficlive.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("Telephone"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 40.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("trafficLIVE"),
                Description = "Traffic LIVE is software that solves the problem of studio management, project management, time recording and scheduling for creative businesses. Traffic LIVE takes the drudgery out of things. Schedules cover lunch, public holidays and afternoons off for company BBQ’s. It tells you who can do the job and if they are free. It lets you split and re-allocate work as you choose. It tells you if something has happened you need to know about. It lets you babble on jobs to collaborate and communicate as a team. All seem obvious? Maybe, but no other system does it!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "trafficLIVE",
                FacebookName = "trafficLIVE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IMANAGEPROJECT BASIC
            ca = new CloudApplication()
            {
                Brand = "iManageProject",
                ServiceName = "Basic",
                CompanyURL = "www.imanageproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("iManageProject"),
                Description = "iManageProject focuses on features of actual use to organizations rather than fancy bells and whistles. Specifically designed to make project management, task tracking and team collaboration hassle free and straightforward, iManageProject aims to bring the power of professional project management to the web. iManageProject is accessible anywhere and anytime for the whole project team. Project team can collaborate and communicate on the plan in real time. Collaborate with clients or your own team using a powerful, state of the art web-based project management software. iManageProject helps your team to be more efficient putting a stress on communication and collaboration. Manage your projects better with iManageProject. Use iManageProject to manage projects and teams efficiently, and virtually from anywhere. Projects can be anything, big or small, from business projects to personal hobbies.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "iManageProject",
                FacebookName = "iManageProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 20;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IMANAGEPROJECT PREMIUM
            ca = new CloudApplication()
            {
                Brand = "iManageProject",
                ServiceName = "Premium",
                CompanyURL = "www.imanageproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("iManageProject"),
                Description = "iManageProject focuses on features of actual use to organizations rather than fancy bells and whistles. Specifically designed to make project management, task tracking and team collaboration hassle free and straightforward, iManageProject aims to bring the power of professional project management to the web. iManageProject is accessible anywhere and anytime for the whole project team. Project team can collaborate and communicate on the plan in real time. Collaborate with clients or your own team using a powerful, state of the art web-based project management software. iManageProject helps your team to be more efficient putting a stress on communication and collaboration. Manage your projects better with iManageProject. Use iManageProject to manage projects and teams efficiently, and virtually from anywhere. Projects can be anything, big or small, from business projects to personal hobbies.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "iManageProject",
                FacebookName = "iManageProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IMANAGEPROJECT CORPORATE
            ca = new CloudApplication()
            {
                Brand = "iManageProject",
                ServiceName = "Corporate",
                CompanyURL = "www.imanageproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 40.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("iManageProject"),
                Description = "iManageProject focuses on features of actual use to organizations rather than fancy bells and whistles. Specifically designed to make project management, task tracking and team collaboration hassle free and straightforward, iManageProject aims to bring the power of professional project management to the web. iManageProject is accessible anywhere and anytime for the whole project team. Project team can collaborate and communicate on the plan in real time. Collaborate with clients or your own team using a powerful, state of the art web-based project management software. iManageProject helps your team to be more efficient putting a stress on communication and collaboration. Manage your projects better with iManageProject. Use iManageProject to manage projects and teams efficiently, and virtually from anywhere. Projects can be anything, big or small, from business projects to personal hobbies.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "iManageProject",
                FacebookName = "iManageProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IMANAGEPROJECT ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "iManageProject",
                ServiceName = "Enterprise",
                CompanyURL = "www.imanageproject.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 80.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("iManageProject"),
                Description = "iManageProject focuses on features of actual use to organizations rather than fancy bells and whistles. Specifically designed to make project management, task tracking and team collaboration hassle free and straightforward, iManageProject aims to bring the power of professional project management to the web. iManageProject is accessible anywhere and anytime for the whole project team. Project team can collaborate and communicate on the plan in real time. Collaborate with clients or your own team using a powerful, state of the art web-based project management software. iManageProject helps your team to be more efficient putting a stress on communication and collaboration. Manage your projects better with iManageProject. Use iManageProject to manage projects and teams efficiently, and virtually from anywhere. Projects can be anything, big or small, from business projects to personal hobbies.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "iManageProject",
                FacebookName = "iManageProject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS TOP SHELF
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Top Shelf",
                CompanyURL = "www.myintervals.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 175.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = "Struggling with tracking time? Drowning in a sea of task and project details? You are in the right place. Intervals is web-based project management software that marries time tracking and task management in a collaborative online space with powerful reporting. Intervals is ideal for small businesses — including designers, web developers, consultants, creative agencies, IT services firms, and communications companies that bill on an hourly or per project basis. Fully hosted online service, no software to install—be up and running in minutes. » Try Intervals Free for 30 Days",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2457907,
                TwitterName = "intervals",
                FacebookName = "intervals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 75;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Premium",
                CompanyURL = "www.myintervals.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 100.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = "Struggling with tracking time? Drowning in a sea of task and project details? You are in the right place. Intervals is web-based project management software that marries time tracking and task management in a collaborative online space with powerful reporting. Intervals is ideal for small businesses — including designers, web developers, consultants, creative agencies, IT services firms, and communications companies that bill on an hourly or per project basis. Fully hosted online service, no software to install—be up and running in minutes. » Try Intervals Free for 30 Days",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2457907,
                TwitterName = "intervals",
                FacebookName = "intervals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 30;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS NOT SO BASIC
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Not So Basic",
                CompanyURL = "www.myintervals.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 50.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = "Struggling with tracking time? Drowning in a sea of task and project details? You are in the right place. Intervals is web-based project management software that marries time tracking and task management in a collaborative online space with powerful reporting. Intervals is ideal for small businesses — including designers, web developers, consultants, creative agencies, IT services firms, and communications companies that bill on an hourly or per project basis. Fully hosted online service, no software to install—be up and running in minutes. » Try Intervals Free for 30 Days",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2457907,
                TwitterName = "intervals",
                FacebookName = "intervals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 40;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS BASIC
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Basic",
                CompanyURL = "www.myintervals.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = "Struggling with tracking time? Drowning in a sea of task and project details? You are in the right place. Intervals is web-based project management software that marries time tracking and task management in a collaborative online space with powerful reporting. Intervals is ideal for small businesses — including designers, web developers, consultants, creative agencies, IT services firms, and communications companies that bill on an hourly or per project basis. Fully hosted online service, no software to install—be up and running in minutes. » Try Intervals Free for 30 Days",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2457907,
                TwitterName = "intervals",
                FacebookName = "intervals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS MINI
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Mini",
                CompanyURL = "www.myintervals.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = "Struggling with tracking time? Drowning in a sea of task and project details? You are in the right place. Intervals is web-based project management software that marries time tracking and task management in a collaborative online space with powerful reporting. Intervals is ideal for small businesses — including designers, web developers, consultants, creative agencies, IT services firms, and communications companies that bill on an hourly or per project basis. Fully hosted online service, no software to install—be up and running in minutes. » Try Intervals Free for 30 Days",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2457907,
                TwitterName = "intervals",
                FacebookName = "intervals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 5;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GENIUSPROJECT
            ca = new CloudApplication()
            {
                Brand = "Geniusproject",
                ServiceName = "On-demand PPM",
                CompanyURL = "www.geniusinside.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BLACKBERRY"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Geniusproject"),
                Description = "Designed to adapt to your organization’s business processes, Genius Project delivers a highly flexible and configurable portfolio and project management software allowing for tailored feature sets for a wide array of project teams and project types.   Genius Project allows your organization to consolidate all of your project information delivering a 360 degree view of your resources, budgets, earnings, and strategic alignment of all of your projects. In addition, Genius Project offers hierarchical and ad-hoc project portfolio capabilities providing better visibility into project statuses and demand for your entire project team.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 102591,
                TwitterName = "Geniusproject",
                FacebookName = "Geniusproject",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLASSCUBES MAX
            ca = new CloudApplication()
            {
                Brand = "glasscubes",
                ServiceName = "Max",
                CompanyURL = "www.glasscubes.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 145.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("glasscubes"),
                Description = "Glasscubes focuses on simplicity, clarity, and ease of use making it truly unique. You'll love using Glasscubes. Project's go well when people can organize and communicate clearly - Glasscubes focuses on this making it easy and transparent to everybody involved. Glasscubes saves everyone time and therefore money getting work done and not wasting time bogged down in emails. Never know if you're looking at the right version of a file? Organize and view all of your content online in a familiar file & folder structure and keep track of all the versions - instantly view any version without anything getting lost in other peoples email boxes.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 500408,
                TwitterName = "@glasscubes",
                FacebookName = "glasscubes",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 40;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLASSCUBES PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "glasscubes",
                ServiceName = "Professional",
                CompanyURL = "www.glasscubes.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 90.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("glasscubes"),
                Description = "Glasscubes focuses on simplicity, clarity, and ease of use making it truly unique. You'll love using Glasscubes. Project's go well when people can organize and communicate clearly - Glasscubes focuses on this making it easy and transparent to everybody involved. Glasscubes saves everyone time and therefore money getting work done and not wasting time bogged down in emails. Never know if you're looking at the right version of a file? Organize and view all of your content online in a familiar file & folder structure and keep track of all the versions - instantly view any version without anything getting lost in other peoples email boxes.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 500408,
                TwitterName = "@glasscubes",
                FacebookName = "glasscubes",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 20;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLASSCUBES STANDARD
            ca = new CloudApplication()
            {
                Brand = "glasscubes",
                ServiceName = "Standard",
                CompanyURL = "www.glasscubes.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("glasscubes"),
                Description = "Glasscubes focuses on simplicity, clarity, and ease of use making it truly unique. You'll love using Glasscubes. Project's go well when people can organize and communicate clearly - Glasscubes focuses on this making it easy and transparent to everybody involved. Glasscubes saves everyone time and therefore money getting work done and not wasting time bogged down in emails. Never know if you're looking at the right version of a file? Organize and view all of your content online in a familiar file & folder structure and keep track of all the versions - instantly view any version without anything getting lost in other peoples email boxes.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 500408,
                TwitterName = "@glasscubes",
                FacebookName = "glasscubes",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 6;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 6;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLASSCUBES BASIC
            ca = new CloudApplication()
            {
                Brand = "glasscubes",
                ServiceName = "Basic",
                CompanyURL = "www.glasscubes.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("glasscubes"),
                Description = "Glasscubes focuses on simplicity, clarity, and ease of use making it truly unique. You'll love using Glasscubes. Project's go well when people can organize and communicate clearly - Glasscubes focuses on this making it easy and transparent to everybody involved. Glasscubes saves everyone time and therefore money getting work done and not wasting time bogged down in emails. Never know if you're looking at the right version of a file? Organize and view all of your content online in a familiar file & folder structure and keep track of all the versions - instantly view any version without anything getting lost in other peoples email boxes.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 500408,
                TwitterName = "@glasscubes",
                FacebookName = "glasscubes",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HARVEST FREE
            ca = new CloudApplication()
            {
                Brand = "HARVEST",
                ServiceName = "Free",
                CompanyURL = "www.getharvest.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    //repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HARVEST"),
                Description = "At Harvest, we believe software should be useful, simple, and fast – so you can work better, get more accomplished, and make smarter decisions for your business. Alternative solutions may charge based on the number of clients, projects or invoices. All Harvest paid plans include unlimited clients, projects and invoices. Other solutions may also charge for any additional users. Harvest Basic starts with 5 users. Business starts with 10 users.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "HARVEST",
                FacebookName = "HARVEST",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HARVEST SOLO
            ca = new CloudApplication()
            {
                Brand = "HARVEST",
                ServiceName = "Solo",
                CompanyURL = "www.getharvest.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(2),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    //repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HARVEST"),
                Description = "At Harvest, we believe software should be useful, simple, and fast – so you can work better, get more accomplished, and make smarter decisions for your business. Alternative solutions may charge based on the number of clients, projects or invoices. All Harvest paid plans include unlimited clients, projects and invoices. Other solutions may also charge for any additional users. Harvest Basic starts with 5 users. Business starts with 10 users.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "HARVEST",
                FacebookName = "HARVEST",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HARVEST TEAM
            ca = new CloudApplication()
            {
                Brand = "HARVEST",
                ServiceName = "Team",
                CompanyURL = "www.getharvest.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    //repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HARVEST"),
                Description = "At Harvest, we believe software should be useful, simple, and fast – so you can work better, get more accomplished, and make smarter decisions for your business. Alternative solutions may charge based on the number of clients, projects or invoices. All Harvest paid plans include unlimited clients, projects and invoices. Other solutions may also charge for any additional users. Harvest Basic starts with 5 users. Business starts with 10 users.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "HARVEST",
                FacebookName = "HARVEST",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HARVEST TEAM PRO
            ca = new CloudApplication()
            {
                Brand = "HARVEST",
                ServiceName = "Team Pro",
                CompanyURL = "www.getharvest.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    //repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HARVEST"),
                Description = "At Harvest, we believe software should be useful, simple, and fast – so you can work better, get more accomplished, and make smarter decisions for your business. Alternative solutions may charge based on the number of clients, projects or invoices. All Harvest paid plans include unlimited clients, projects and invoices. Other solutions may also charge for any additional users. Harvest Basic starts with 5 users. Business starts with 10 users.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "HARVEST",
                FacebookName = "HARVEST",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).Count = 7;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF PROJECTS")).CountSuffix = "Projects";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FILE STORAGE")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished PROJECT MANAGEMENT");
            return retVal;
        }

        #region InsertDocumentLinks
        private static void InsertDocumentLinks(QueryRepository repository, CloudApplication ca)
        {
            string PDF_TEST_WHITE_PAPER_FILEPATH = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            //string PDF_TEST_WHITE_PAPER_FILENAME = "grohe_bathroom_brochure.pdf";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\";
            int PDF_TEST_WHITE_PAPER_PAGE_COUNT = 8;
            int IMAGE_FILE_WIDTH = 50;
            int IMAGE_FILE_HEIGHT = 50;
            string PDF_TEST_CASE_STUDY_FILEPATH = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\CaseStudies\\";
            //string PDF_TEST_CASE_STUDY_FILENAME = "pdftown.com_986_ac-electrics.pdf";
            int PDF_TEST_CASE_STUDY_PAGE_COUNT = 1;
            string SAMPLE_REVIEW_PDF = @"http://www.samplepdf.com/sample.pdf";
            string SAMPLE_REVIEW_DOC = @"http://www.swiftview.com/tech/letterlegal5.doc";
            string SAMPLE_REVIEW_URL = @"http://www.amazon.co.uk/product-reviews/B000KKNQBK";
            string SAMPLE_REVIEW_URL_BROKEN = @"http://reviews.argos.co.uk/1493-en_gb/058897/broken-reviews.htm";

            string PDF_TEST_WHITE_PAPER_FILENAME = "words.pdf";
            string PDF_TEST_CASE_STUDY_FILENAME = "adobeid.pdf";

            #region Ratings,Reviews,Case Studies,White Papers
            ca.CloudApplicationUserReviews = new List<CloudApplicationUserReview>()
                {
                    new CloudApplicationUserReview()
                    {
                        CloudApplicationUserReviewText = repository.GetDescription(),
                        CloudApplicationUserReviewCompany = "Reviewer Company",
                        CloudApplicationUserReviewForename = "Reviewer First Name",
                        CloudApplicationUserReviewSurname = "Reviewer Name",
                        CloudApplicationUserReviewTitle = "Reviewer Title",
                        CloudApplicationUserReviewIndustry = repository.GetIndustry(81),
                        CloudApplicationUserReviewEmployeeCount = 50,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationUserReviewDate = DateTime.Now,
                        CloudApplicationUserReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationUserReview()
                    {
                        CloudApplicationUserReviewText = repository.GetDescription(),
                        CloudApplicationUserReviewCompany = "Reviewer Company",
                        CloudApplicationUserReviewForename = "Reviewer First Name",
                        CloudApplicationUserReviewSurname = "Reviewer Name",
                        CloudApplicationUserReviewTitle = "Reviewer Title",
                        CloudApplicationUserReviewIndustry = repository.GetIndustry(81),
                        CloudApplicationUserReviewEmployeeCount = 50,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationUserReviewDate = DateTime.Now.AddDays(-1),
                        CloudApplicationUserReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationUserReview()
                    {
                        CloudApplicationUserReviewText = repository.GetDescription(),
                        CloudApplicationUserReviewCompany = "Reviewer Company",
                        CloudApplicationUserReviewForename = "Reviewer First Name",
                        CloudApplicationUserReviewSurname = "Reviewer Name",
                        CloudApplicationUserReviewTitle = "Reviewer Title",
                        CloudApplicationUserReviewIndustry = repository.GetIndustry(81),
                        CloudApplicationUserReviewEmployeeCount = 50,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationUserReviewDate = DateTime.Now.AddDays(-2),
                        CloudApplicationUserReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationUserReview()
                    {
                        CloudApplicationUserReviewText = repository.GetDescription(),
                        CloudApplicationUserReviewCompany = "Reviewer Company",
                        CloudApplicationUserReviewForename = "Reviewer First Name",
                        CloudApplicationUserReviewSurname = "Reviewer Name",
                        CloudApplicationUserReviewTitle = "Reviewer Title",
                        CloudApplicationUserReviewIndustry = repository.GetIndustry(81),
                        CloudApplicationUserReviewEmployeeCount = 50,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationUserReviewDate = DateTime.Now.AddDays(-3),
                        CloudApplicationUserReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                };
            ca.CloudApplicationProductReviews = new List<CloudApplicationProductReview>()
                {
                    new CloudApplicationProductReview()
                    {
                        CloudApplicationProductReviewText = repository.GetDescription(),
                        CloudApplicationProductReviewDate = DateTime.Now,
                        CloudApplicationProductReviewPublisherName = FakeData.GetPublisherName(1),
                        CloudApplicationProductReviewHeadline = FakeData.GetPublisherHeadline(),
                        CloudApplicationProductReviewURL = SAMPLE_REVIEW_DOC,
                        CloudApplicationProductReviewURLDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("DOC"),
                        IsDocument = true,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationProductReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationProductReview()
                    {
                        CloudApplicationProductReviewText = repository.GetDescription(),
                        CloudApplicationProductReviewDate = DateTime.Now.AddDays(-1),
                        CloudApplicationProductReviewPublisherName = FakeData.GetPublisherName(2),
                        CloudApplicationProductReviewHeadline = FakeData.GetPublisherHeadline(),
                        CloudApplicationProductReviewURL = SAMPLE_REVIEW_PDF,
                        CloudApplicationProductReviewURLDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        IsDocument = true,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationProductReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationProductReview()
                    {
                        CloudApplicationProductReviewText = repository.GetDescription(),
                        CloudApplicationProductReviewDate = DateTime.Now.AddDays(-2),
                        CloudApplicationProductReviewPublisherName = FakeData.GetPublisherName(1),
                        CloudApplicationProductReviewHeadline = FakeData.GetPublisherHeadline(),
                        CloudApplicationProductReviewURL = SAMPLE_REVIEW_URL,
                        CloudApplicationProductReviewURLDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("HTML"),
                        IsDocument = false,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationProductReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationProductReview()
                    {
                        CloudApplicationProductReviewText = repository.GetDescription(),
                        CloudApplicationProductReviewDate = DateTime.Now.AddDays(-3),
                        CloudApplicationProductReviewPublisherName = FakeData.GetPublisherName(2),
                        CloudApplicationProductReviewHeadline = FakeData.GetPublisherHeadline(),
                        CloudApplicationProductReviewURL = SAMPLE_REVIEW_URL_BROKEN,
                        CloudApplicationProductReviewURLDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("DOC"),
                        IsDocument = true,
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationProductReviewStatus = repository.FindStatusByName("LIVE"),
                    },
                };
            ca.CloudApplicationDocuments = new List<CloudApplicationDocument>()
                {
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-1),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-2),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("WHITE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_WHITE_PAPER_FILEPATH+PDF_TEST_WHITE_PAPER_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_WHITE_PAPER_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_WHITE_PAPER_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_WHITE_PAPER_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-3),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-4),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-5),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                    new CloudApplicationDocument()
                    {
                        CloudApplicationDocumentTitle = repository.GetDescription(4),
                        CloudApplicationDocumentType = repository.FindCloudApplicationDocumentTypeByName("CASE"),
                        //Image = GhostscriptWrapper.GetPageThumb(PDF_TEST_CASE_STUDY_FILEPATH+PDF_TEST_CASE_STUDY_FILENAME,OUTPUT_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg", new Random().Next(1,PDF_TEST_CASE_STUDY_PAGE_COUNT), IMAGE_FILE_WIDTH, IMAGE_FILE_HEIGHT),
                        CloudApplicationDocumentURL = "http://www.bbc.co.uk",
                        CloudApplicationDocumentPhysicalFilePath = PDF_TEST_CASE_STUDY_FILEPATH,
                        CloudApplicationDocumentFileName = PDF_TEST_CASE_STUDY_FILENAME,
                        CloudApplicationDocumentFormat = repository.FindCloudApplicationDocumentFormatByShortName("PDF"),
                        //IsLive = true,
                        UniqueRowID = Guid.NewGuid(),
                        CloudApplicationDocumentReleaseDate = DateTime.Now.AddDays(-6),
                        CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE"),
                    },
                };
            #endregion
        }
        #endregion

        #region SetLiveStatuses
        public static void SetLiveStatuses(CloudApplication ca, QueryRepository repository)
        {

            ca.CloudApplicationStatus = repository.FindStatusByName("LIVE");
            ca.Devices.ForEach(x => x.DeviceStatus = repository.FindStatusByName("LIVE"));
            ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            ca.Languages.ForEach(x => x.LanguageStatus = repository.FindStatusByName("LIVE"));
            ca.SupportTypes.ForEach(x => x.SupportTypeStatus = repository.FindStatusByName("LIVE"));
            if (ca.SupportTerritories != null)
            {
                ca.SupportTerritories.ForEach(x => x.SupportTerritoryStatus = repository.FindStatusByName("LIVE"));
            }
            ca.CloudApplicationFeatures.ForEach(x => x.CloudApplicationFeatureStatus = repository.FindStatusByName("LIVE"));
            ca.PaymentOptions.ForEach(x => x.PaymentOptionStatus = repository.FindStatusByName("LIVE"));
            //ca.CloudApplicationApplications.ForEach(x => x.CloudApplicationApplicationStatus = repository.FindStatusByName("LIVE"));
            //return retVal;
        }
        #endregion

        #region PumpLiquidPlannerLogo
        public static bool PumpLiquidPlannerLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "LiquidPlanner",
                VendorLogoFileName = "liquidplanner logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Project Management\\New Logos\\liquidplanner logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpLiquidPlannerMonthlyPlan
        public static bool PumpLiquidPlannerMonthlyPlan(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("PROJECT MANAGEMENT").CategoryID;

            #region LIQUID PLANNER
            ca = new CloudApplication()
            {
                Brand = "Liquid Planner",
                ServiceName = "Monthly Plan",
                CompanyURL = "www.liquidplanner.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("TIME BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    repository.FindFeatureByName("OFFLINE MODE",categoryID),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 24.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("liquid"),
                Description = "Liquid is an award-winning, UK-based market leader of online accounting software. Our jargon-free, user-friendly business accounting system is designed to save you time and money and make running your business easier. Our software is accredited by both the ICAEW (Institute of Chartered Accountants of England and Wales) and the ICB (Institute of Certified Bookkeepers), and complies with the BASDA Cloud Vendor Charter (Business Application Software Developers Association).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 255216,
                TwitterName = "liquid",
                FacebookName = "liquid",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            return retVal;

        }
        #endregion

    }
}
