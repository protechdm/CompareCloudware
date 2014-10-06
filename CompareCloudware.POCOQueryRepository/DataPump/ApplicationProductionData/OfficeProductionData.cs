using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class OfficeProductionData
    {

        public static bool PumpOfficeData(QueryRepository repository)
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

            bool retVal = true;

            int categoryID = repository.FindCategoryByName("OFFICE").CategoryID;

            #region APPLICATIONS

            #region OFFICE

            #region MICROSOFT OFFICE 365 SMALL BUSINESS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Microsoft Office 365",
                ServiceName = "Small Business Premium",
                CompanyURL = "www.office365.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = repository.GetLanguages().ToList(),
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 10.10M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Microsoft Office 365"),
                Description = "With Office 365 Small Business Premium you get virtually anywhere access to Office, including Word, PowerPoint, Outlook, and Excel. Plus enterprise-grade email, a public website, HD video conferencing, and more services. Plus the ease of managing it all simply, without IT expertise. Work better together, even on the go. Access your work through a browser, and find all your settings and documents just as you left them on your desktop—whether you’re using your tablet, smartphone, or another device.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = " @Office365",
                FacebookName = "office365",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = .5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 1;


            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 25M;
            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT OFFICE 365 MID-SIZE BUSINESS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Microsoft Office 365",
                ServiceName = "Mid-size Business Premium",
                CompanyURL = "www.office365.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = repository.GetLanguages().ToList(),
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 9.80M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Microsoft Office 365"),
                Description = "With Office 365 Mid-size Business Premium you Get enterprise-grade email, meeting, and collaboration capabilities along with best-in-class Office tools and services—all accessible from virtually anywhere and simple to administer. Your personalized Office experience is there whenever you need it. The virtually anywhere access of Office across devices gives everyone in your business the freedom and flexibility to be more productive wherever they're working. Plus, they can customize their personal Office settings for how they work best. IT.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = " @Office365",
                FacebookName = "office365",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = .5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 300;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 25M;
            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GOOGLE APPS FOR BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Google Apps for Business",
                ServiceName = "Google Apps for Business",
                CompanyURL = "www.google.com/apps",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 5.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Google Apps for Business"),
                Description = "Web based email, calendar & documents that let you work from anywhere.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 85376,
                TwitterName = "@googleapps",
                FacebookName = "GoogleAppsForBusines",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 25M;
            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GOOGLE APPS FOR BUSINESS WITH VAULT
            ca = new CloudApplication()
            {
                Brand = "Google Apps for Business",
                ServiceName = "Google Apps for Business with Vault",
                CompanyURL = "www.google.com/apps",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Google Apps for Business"),
                Description = "Web based email, calendar & documents that let you work from anywhere. With added data archiviing provided by Vault",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 85376,
                TwitterName = "@googleapps",
                FacebookName = "GoogleAppsForBusines",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 25M;
            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO DOCS FREE
            ca = new CloudApplication()
            {
                Brand = "ZOHO docs",
                ServiceName = "Zoho Docs Free",
                CompanyURL = "www.zoho.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("ZOHO docs"),
                Description = "Zoho Docs is an Online Document Management where you can store all your files securely in a centralized location and can access any where online. You can store, create, edit, share, view and upload any type of files like documents, spreadsheets, presentations, pictures, music, videos, etc. You can also collaborate on documents in real-time, which is useful when you work as a team.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2125232,
                TwitterName = "@zohodocs",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO DOCS STANDARD
            ca = new CloudApplication()
            {
                Brand = "ZOHO docs",
                ServiceName = "Zoho Docs Standard",
                CompanyURL = "www.zoho.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 3.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("ZOHO docs"),
                Description = "Zoho Docs is an Online Document Management where you can store all your files securely in a centralized location and can access any where online. You can store, create, edit, share, view and upload any type of files like documents, spreadsheets, presentations, pictures, music, videos, etc. You can also collaborate on documents in real-time, which is useful when you work as a team.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2125232,
                TwitterName = "@zohodocs",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 10;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO DOCS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "ZOHO docs",
                ServiceName = "Zoho Docs Premium",
                CompanyURL = "www.zoho.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 5.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("ZOHO docs"),
                Description = "Zoho Docs is an Online Document Management where you can store all your files securely in a centralized location and can access any where online. You can store, create, edit, share, view and upload any type of files like documents, spreadsheets, presentations, pictures, music, videos, etc. You can also collaborate on documents in real-time, which is useful when you work as a team.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2125232,
                TwitterName = "@zohodocs",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region THINKFREE ONLINE
            ca = new CloudApplication()
            {
                Brand = "Think Free",
                ServiceName = "Think Free Online",
                CompanyURL = "www.thinkfree.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Think Free"),
                Description = "ThinkFree Office is an office program that enables you to create documents, spreadsheets and presentations. Organized as three programs - Write, Calc, and Show - ThinkFree Office is highly compatible with the office program provided by other competitors.ThinkFree Office also offers a friendly user interface. However, the strength of ThinkFree Office transcends these two points.It is different from ordinary office programs that must be installed in a PC before use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2070862,
                TwitterName = "@ThinkFree",
                FacebookName = "thinkfree",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region THINKFREE MOBILE
            ca = new CloudApplication()
            {
                Brand = "Think Free",
                ServiceName = "Think Free Mobile",
                CompanyURL = "www.thinkfree.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Think Free"),
                Description = "ThinkFree Office is an office program that enables you to create documents, spreadsheets and presentations. Organized as three programs - Write, Calc, and Show - ThinkFree Office is highly compatible with the office program provided by other competitors.ThinkFree Office also offers a friendly user interface. However, the strength of ThinkFree Office transcends these two points.It is different from ordinary office programs that must be installed in a PC before use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2070862,
                TwitterName = "@ThinkFree",
                FacebookName = "thinkfree",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FENG OFFICE SKY BASIC
            ca = new CloudApplication()
            {
                Brand = "feng OFFICE",
                ServiceName = "Feng Sky Basic",
                CompanyURL = "www.fengoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                    repository.FindLanguageByName("BULGARIAN"),
                    repository.FindLanguageByName("CATALAN"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("LITHUANIAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH (SPAIN)"),
                    repository.FindLanguageByName("SPANISH (LATIN AMERICA)"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("UKRANIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    //repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("feng OFFICE"),
                Description = "Feng Office is a web-based software that integrates Project Management, Client Relationship Management, Billing, Financing, among other features that help you efficiently run your Professional Services Business.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 245411,
                TwitterName = "@FengOffice",
                FacebookName = "FengOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FENG OFFICE SKY PLUS
            ca = new CloudApplication()
            {
                Brand = "feng OFFICE",
                ServiceName = "Feng Sky Plus",
                CompanyURL = "www.fengoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("BULGARIAN"),
                    repository.FindLanguageByName("CATALAN"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("LITHUANIAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH (SPAIN)"),
                    repository.FindLanguageByName("SPANISH (LATIN AMERICA)"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("UKRANIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("feng OFFICE"),
                Description = "Feng Office is a web-based software that integrates Project Management, Client Relationship Management, Billing, Financing, among other features that help you efficiently run your Professional Services Business.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 245411,
                TwitterName = "@FengOffice",
                FacebookName = "FengOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 15M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FENG OFFICE SKY PRO
            ca = new CloudApplication()
            {
                Brand = "feng OFFICE",
                ServiceName = "Feng Sky Pro",
                CompanyURL = "www.fengoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("BULGARIAN"),
                    repository.FindLanguageByName("CATALAN"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("LITHUANIAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH (SPAIN)"),
                    repository.FindLanguageByName("SPANISH (LATIN AMERICA)"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("UKRANIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("feng OFFICE"),
                Description = "Feng Office is a web-based software that integrates Project Management, Client Relationship Management, Billing, Financing, among other features that help you efficiently run your Professional Services Business.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 245411,
                TwitterName = "@FengOffice",
                FacebookName = "FengOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 30M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FENG OFFICE SKY PREMIUM
            ca = new CloudApplication()
            {
                Brand = "feng OFFICE",
                ServiceName = "Feng Sky Premium",
                CompanyURL = "www.fengoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("BULGARIAN"),
                    repository.FindLanguageByName("CATALAN"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("LITHUANIAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH (SPAIN)"),
                    repository.FindLanguageByName("SPANISH (LATIN AMERICA)"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("UKRANIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("feng OFFICE"),
                Description = "Feng Office is a web-based software that integrates Project Management, Client Relationship Management, Billing, Financing, among other features that help you efficiently run your Professional Services Business.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 245411,
                TwitterName = "@FengOffice",
                FacebookName = "FengOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 80M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZCUBES
            //ca = new CloudApplication()
            //{
            //    Brand = "Z CUBES",
            //    ServiceName = "Enterprise",
            //    CompanyURL = "www.zcubes.com",
            //    OperatingSystems = new List<Domain.Models.OperatingSystem>()
            //    {
            //        repository.FindOperatingSystemByName("WIN"),
            //        repository.FindOperatingSystemByName("MAC"),
            //        //repository.FindOperatingSystemByName("LINUX")
            //    },
            //    //MobilePlatforms = repository.GetAllMobilePlatforms(),
            //    MobilePlatforms = new List<MobilePlatform>()
            //    {
            //        repository.FindMobilePlatformByName("ANDROID"),
            //        repository.FindMobilePlatformByName("IPHONE"),
            //        repository.FindMobilePlatformByName("BLACKBERRY")
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
            //        repository.FindSupportTypeByName("FAQ"),
            //        repository.FindSupportTypeByName("TROUBLETICKET")
            //    },
            //    SupportHours = repository.FindSupportHoursByName("N/A"),
            //    SupportDays = repository.FindSupportDaysByName("N/A"),
            //    SupportTerritories = new List<SupportTerritory>()
            //    {
            //        repository.FindSupportTerritoryByName("GLOBAL"),
            //    },
            //    VideoTrainingSupport = false,
            //    //MaximumMeetingAttendees = 50,
            //    //MaximumWebinarAttendees = 0,
            //    CloudApplicationFeatures = new List<CloudApplicationFeature>()
            //    {
            //        repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
            //        repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
            //        repository.FindFeatureByName("MAILING FEATURES"),
            //        repository.FindFeatureByName("FORMULA MANAGEMENT"),
            //        repository.FindFeatureByName("DATA MANAGEMENT"),
            //        repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
            //        repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
            //        repository.FindFeatureByName("REAL-TIME COLLABORATION"),
            //        repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
            //        repository.FindFeatureByName("LARGE VIDEO FILES"),
            //        repository.FindFeatureByName("OWN BRANDING"),
            //        repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
            //        //repository.FindFeatureByName("EMAIL CLIENT"),
            //        repository.FindFeatureByName("CONTACT MANAGEMENT"),
            //        repository.FindFeatureByName("SHARED CALENDAR"),
            //        repository.FindFeatureByName("WEB MEETINGS"),
            //        repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
            //        repository.FindFeatureByName("WEB PUBLISHING"),
            //        repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
            //        repository.FindFeatureByName("INTERNAL WEBSITE"),
            //        repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
            //        repository.FindFeatureByName("READ & EDIT"),
            //        repository.FindFeatureByName("SAVE WEB CONTENT"),
            //        repository.FindFeatureByName("IMAGE CAPTURE"),
            //        repository.FindFeatureByName("AUTOMATIC SYNC"),
            //        //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
            //        //repository.FindFeatureByName("OFFLINE MODE",categoryID),
            //        repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
            //        repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
            //        repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
            //        repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
            //        repository.FindFeatureByName("MULTI-USER / GUEST USER"),
            //        repository.FindFeatureByName("3RD PARTY APIS",categoryID),
            //        repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
            //    },
            //    ApplicationCostPerMonth = 0.00M,
                //ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthOffered = true,
                //ApplicationCostPerAnnumFree = false,
                //ApplicationCostPerAnnumOffered = false,
            //    //CallsPackageCostPerMonth = 0M,
            //    CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
            //    SetupFee = repository.FindSetupFeeByName("NO"),
            //    MinimumContract = repository.FindMinimumContractByName("N/A"),
            //    PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
            //    PaymentOptions = new List<PaymentOption>()
            //    {
            //        repository.FindPaymentOptionByName("CREDIT CARD"),
            //        repository.FindPaymentOptionByName("PRE-PAY"),
            //    },
            //    FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
            //    Category = repository.FindCategoryByName("OFFICE"),
            //    Vendor = repository.FindVendorByName("Z CUBES"),
            //    Description = "ZCubes is a web platform where you can seamlessly create web pages when you browse, create drawings, paintings, documents and spreadsheets, all on the web, without having to switch between different applications.",
            //    AddDate = DateTime.Now,
            //};

            //InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE CORE COLLABORATION
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Core Collaboration",
                CompanyURL = "www.hyperoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT")
                },
                SupportHours = repository.FindSupportHoursByName("8AM-7PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("EST"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonthFrom = 6.50M,
                ApplicationCostPerMonthTo = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "Whether you want to serve an immediate collaboration need, or are looking at collaboration as a strategic investment, we have just the solution for you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
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
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT")
                },
                SupportHours = repository.FindSupportHoursByName("8AM-7PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("EST"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonthFrom = 10.50M,
                ApplicationCostPerMonthTo = 20.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "Whether you want to serve an immediate collaboration need, or are looking at collaboration as a strategic investment, we have just the solution for you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE ONLINE DOCUMENT MANAGEMENT
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Online Document Management",
                CompanyURL = "www.hyperoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT")
                },
                SupportHours = repository.FindSupportHoursByName("8AM-7PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("EST"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 3.00M,
                ApplicationCostPerMonthTo = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("49.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "Whether you want to serve an immediate collaboration need, or are looking at collaboration as a strategic investment, we have just the solution for you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 16384;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MYOFFICE
            ca = new CloudApplication()
            {
                Brand = "myoffice",
                ServiceName = "Windows Version",
                CompanyURL = "www.myoffice.net",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
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
                //    repository.FindMobilePlatformByName("BLACKBERRY")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(60),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                //ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 34.12M,
                ApplicationCostPerAnnumTo = 49.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("myoffice"),
                Description = "MyOffice is a subscription based cloud computing 'virtual office' designed for small to medium-sized businesses. It combines shared diaries / calendars, contacts, tasks, email, file store, reminders and notes into an integrated suite of online collaboration tools to help you keep in touch with your colleagues.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "myoffice",
                FacebookName = "myoffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 16384M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region QUICKOFFICE HD PRO
            ca = new CloudApplication()
            {
                Brand = "Quickoffice",
                ServiceName = "Quickoffice HD Pro",
                CompanyURL = "www.quickoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    //repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    //repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("19.00"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ONE-OFF"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Quickoffice"),
                Description = "Quickoffice is the leader in mobile office productivity software for smartphones",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 322387,
                TwitterName = "Quickoffice",
                FacebookName = "Quickoffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region QUICKOFFICE PRO
            ca = new CloudApplication()
            {
                Brand = "Quickoffice",
                ServiceName = "Quickoffice Pro",
                CompanyURL = "www.quickoffice.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    repository.FindDeviceByName("LAPTOP"),
                },
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    //repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    //repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("14.99"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ONE-OFF"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Quickoffice"),
                Description = "Quickoffice is the leader in mobile office productivity software for smartphones",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 322387,
                TwitterName = "Quickoffice",
                FacebookName = "Quickoffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 250M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE PRESENTATIONS BASIC
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Presentations Basic",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Presentations is a web-enabled presentation authoring application that helps you create dazzling presentations with half the effort as before",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 100M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE PRESENTATIONS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Presentations Premium",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Presentations is a web-enabled presentation authoring application that helps you create dazzling presentations with half the effort as before",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 500M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE SPREADSHEETS BASIC
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Spreadsheets Basic",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,

                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Spreadsheets is like Microsoft Excel...only easier to use and more powerful!  Share your spreadsheets with anyone without worrying about application or operating system compatibilities. You can also specify who can do what to your spreadsheet and change these rights dynamically.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 100M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE SPREADSHEETS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Spreadsheets Premium",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Spreadsheets is like Microsoft Excel...only easier to use and more powerful!  Share your spreadsheets with anyone without worrying about application or operating system compatibilities. You can also specify who can do what to your spreadsheet and change these rights dynamically.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 500M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE WRITER BASIC
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Writer Basic",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Writer is a web-enabled document authoring application that can be used either as a software on your desktop or as a service within any browser giving you unprecedented choice and flexibility without having to worry about incompatibilties around operating systems, application versions or document formats",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 100M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS LIVE WRITER PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Writer Premium",
                CompanyURL = "www.live-documents.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = "Live Presentations is a web-enabled presentation authoring application that helps you create dazzling presentations with half the effort as before",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167433,
                TwitterName = "@livedocs",
                FacebookName = "",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 500M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region EVERNOTE
            ca = new CloudApplication()
            {
                Brand = "EVERNOTE",
                ServiceName = "Evernote",
                CompanyURL = "www.evernote.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("THAI"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("VIETNAMESE"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    //repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("EVERNOTE"),
                Description = "Evernote is an easy-to-use, free app that helps you remember everything across all of your devices. You can create a plaintext note on your Windows 8 tablet, and then open it on your smartphone or any other devices you use.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 62953,
                TwitterName = "EVERNOTE",
                FacebookName = "EVERNOTE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region EVERNOTE PREMIUM
            ca = new CloudApplication()
            {
                Brand = "EVERNOTE",
                ServiceName = "Evernote Premium",
                CompanyURL = "www.evernote.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("THAI"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("VIETNAMESE"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("PST"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 5.00M,
                ApplicationCostPerAnnum = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("EVERNOTE"),
                Description = "Our goal at Evernote is to help the world remember everything, communicate effectively and get things done. From saving thoughts and ideas to preserving experiences to working efficiently with others, Evernote’s collection of apps make it easy to stay organized and productive.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 62953,
                TwitterName = "EVERNOTE",
                FacebookName = "EVERNOTE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region EVERNOTE BUSINESS
            ca = new CloudApplication()
            {
                Brand = "EVERNOTE",
                ServiceName = "Evernote Business",
                CompanyURL = "www.evernote.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("THAI"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("VIETNAMESE"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("PST"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 10.00M,
                //ApplicationCostPerAnnum = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("EVERNOTE"),
                Description = "Evernote Business includes all the features of Evernote and Evernote Premium, plus special business-only tools and capabilities. Our goal at Evernote is to help the world remember everything, communicate effectively and get things done. From saving thoughts and ideas to preserving experiences to working efficiently with others, Evernote’s collection of apps make it easy to stay organized and productive.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 62953,
                TwitterName = "EVERNOTE",
                FacebookName = "EVERNOTE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region EVERNOTE BUSINESS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "EVERNOTE",
                ServiceName = "Evernote Business Premium",
                CompanyURL = "www.evernote.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("THAI"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("VIETNAMESE"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("PST"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 10.00M,
                //ApplicationCostPerAnnum = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("EVERNOTE"),
                Description = "Evernote Business includes all the features of Evernote and Evernote Premium, plus special business-only tools and capabilities. Our goal at Evernote is to help the world remember everything, communicate effectively and get things done. From saving thoughts and ideas to preserving experiences to working efficiently with others, Evernote’s collection of apps make it easy to stay organized and productive.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 62953,
                TwitterName = "EVERNOTE",
                FacebookName = "EVERNOTE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDEROCKET LITE
            ca = new CloudApplication()
            {
                Brand = "sliderocket",
                ServiceName = "Lite",
                CompanyURL = "www.sliderocket.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    //repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("sliderocket"),
                Description = "SlideRocket is a revolutionary new approach to business communications designed from the start to help you make great presentations that engage your audience and deliver tangible results.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167697,
                TwitterName = "sliderocket",
                FacebookName = "sliderocket",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDEROCKET PRO
            ca = new CloudApplication()
            {
                Brand = "sliderocket",
                ServiceName = "Pro",
                CompanyURL = "www.sliderocket.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("sliderocket"),
                Description = "SlideRocket is a revolutionary new approach to business communications designed from the start to help you make great presentations that engage your audience and deliver tangible results.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167697,
                TwitterName = "sliderocket",
                FacebookName = "sliderocket",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDEROCKET ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "sliderocket",
                ServiceName = "Enterprise",
                CompanyURL = "www.sliderocket.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(100),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 360M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("sliderocket"),
                Description = "SlideRocket is a revolutionary new approach to business communications designed from the start to help you make great presentations that engage your audience and deliver tangible results.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167697,
                TwitterName = "sliderocket",
                FacebookName = "sliderocket",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PREZI PUBLIC
            ca = new CloudApplication()
            {
                Brand = "PREZI",
                ServiceName = "Public",
                CompanyURL = "www.prezi.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("N/A"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("PREZI"),
                Description = "With Prezi, you move seamlessly from brainstorming your ideas to presenting them. Create a more cinematic and engaging experience. Prezi's zooming presentation software lets you choose between the freedom of the cloud, the security of your desktop, or the mobility of the iPad or iPhone. And because Prezi is 3D, you can guide your audience through a truly spatial journey. Zoom out to show the overview of your prezi, zoom in to examine the details of your ideas, or simply move freely through the prezi and react to your audience’s input.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 216295,
                TwitterName = "PREZI",
                FacebookName = "prezicom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = .1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PREZI ENJOY
            ca = new CloudApplication()
            {
                Brand = "PREZI",
                ServiceName = "Enjoy",
                CompanyURL = "www.prezi.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("PREZI"),
                Description = "With Prezi, you move seamlessly from brainstorming your ideas to presenting them. Create a more cinematic and engaging experience. Prezi's zooming presentation software lets you choose between the freedom of the cloud, the security of your desktop, or the mobility of the iPad or iPhone. And because Prezi is 3D, you can guide your audience through a truly spatial journey. Zoom out to show the overview of your prezi, zoom in to examine the details of your ideas, or simply move freely through the prezi and react to your audience’s input.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 216295,
                TwitterName = "PREZI",
                FacebookName = "prezicom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = .5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PREZI PRO
            ca = new CloudApplication()
            {
                Brand = "PREZI",
                ServiceName = "Pro",
                CompanyURL = "www.prezi.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("N/A"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("N/A"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("US"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 159.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("PREZI"),
                Description = "With Prezi, you move seamlessly from brainstorming your ideas to presenting them. Create a more cinematic and engaging experience. Prezi's zooming presentation software lets you choose between the freedom of the cloud, the security of your desktop, or the mobility of the iPad or iPhone. And because Prezi is 3D, you can guide your audience through a truly spatial journey. Zoom out to show the overview of your prezi, zoom in to examine the details of your ideas, or simply move freely through the prezi and react to your audience’s input.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 216295,
                TwitterName = "PREZI",
                FacebookName = "prezicom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IBM SMARTCLOUD ENGAGE CONNECTIONS
            ca = new CloudApplication()
            {
                Brand = "IBM",
                ServiceName = "SmartCloud Engage Connections",
                CompanyURL = "https://www.ibm.com/cloud-computing/social/us/en/startatrial/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("BRAZILIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("CROATIAN"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SLOVAK"),
                    repository.FindLanguageByName("SLOVENIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 4.23M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("POA"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("IBM"),
                Description = "IBM SmartCloud Engage Connections includes collaboration tools such a personal dashboard, file sharing, communities, and instant messaging. Also mobile app for accessing files",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1009,
                TwitterName = "@IBM",
                FacebookName = "IBM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IBM SMARTCLOUD ENGAGE STANDARD
            ca = new CloudApplication()
            {
                Brand = "IBM",
                ServiceName = "SmartCloud Engage Standard",
                CompanyURL = "https://www.ibm.com/cloud-computing/social/us/en/startatrial/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("BRAZILIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("CROATIAN"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SLOVAK"),
                    repository.FindLanguageByName("SLOVENIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 5.64M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("POA"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("IBM"),
                Description = "IBM SmartCloud Engage Connections includes collaboration tools such a personal dashboard, file sharing, communities, and instant messaging. In addition users get access to web meetings for 200 participants with videocasting, desktop and application sharing, and polling. Also mobile apps for accessing files and participating in online meetings",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1009,
                TwitterName = "@IBM",
                FacebookName = "IBM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IBM SMARTCLOUD ENGAGE ADVANCED
            ca = new CloudApplication()
            {
                Brand = "IBM",
                ServiceName = "SmartCloud Engage Advanced",
                CompanyURL = "https://www.ibm.com/cloud-computing/social/us/en/startatrial/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    repository.FindOperatingSystemByName("LINUX"),
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
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("BRAZILIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("CROATIAN"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("DUTCH"),
                    repository.FindLanguageByName("FINNISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("HUNGARIAN"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SLOVAK"),
                    repository.FindLanguageByName("SLOVENIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("CHINESE"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    repository.FindApplicationByName("WORD PROCESSOR"),
                    repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    repository.FindApplicationByName("NOTES"),
                    repository.FindApplicationByName("WEB PUBLISHING"),
                    repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 7.05M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("POA"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("IBM"),
                Description = "IBM SmartCloud Engage Advanced combines enterprise-class email, calendaring, instant messaging, web conferencing, file sharing and social business services in an easy to deploy, simplified package. As a cloud-based service, your collaboration and messaging infrastructure needs are managed by IBM, allowing you to focus on your core business",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1009,
                TwitterName = "@IBM",
                FacebookName = "IBM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;

            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).Count = 25M;
            ca.CloudApplicationApplications.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL STORAGE LIMIT PER USER")).CountSuffix = "GB";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDESHARE PRO BASIC
            ca = new CloudApplication()
            {
                Brand = "slideshare",
                ServiceName = "PRO Basic",
                CompanyURL = "http://www.slideshare.net/business/premium/plans?cmp_src=general&cmp_src_from=footer",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("SLIDESHARE"),
                Description = "SlideShare is the world's largest community for sharing presentations. Go PRO Basic allows you to track 1 presentation with unlimited shares.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "SLIDESHARE",
                FacebookName = "SLIDESHARE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };
            
            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDESHARE PRO SILVER
            ca = new CloudApplication()
            {
                Brand = "slideshare",
                ServiceName = "PRO Silver",
                CompanyURL = "http://www.slideshare.net/business/premium/plans?cmp_src=general&cmp_src_from=footer",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("SLIDESHARE"),
                Description = "SlideShare is the world's largest community for sharing presentations. Go PRO Silver allows you to track 5 presentations with unlimited shares, upload 10 videos and capture 30 leads.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "SLIDESHARE",
                FacebookName = "SLIDESHARE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDESHARE PRO GOLD
            ca = new CloudApplication()
            {
                Brand = "slideshare",
                ServiceName = "PRO Gold",
                CompanyURL = "http://www.slideshare.net/business/premium/plans?cmp_src=general&cmp_src_from=footer",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("SLIDESHARE"),
                Description = "SlideShare is the world's largest community for sharing presentations. Go PRO Gold allows you to track 20 presentations with unlimited shares, upload 20 videos and capture 75 leads - together with advanced presentation display settings.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "SLIDESHARE",
                FacebookName = "SLIDESHARE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDEBOOM PRO BUSINESS
            ca = new CloudApplication()
            {
                Brand = "slideboom",
                ServiceName = "PRO Business",
                CompanyURL = "http://www.slideboom.com/pro_account",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 195.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("SLIDEBOOM"),
                Description = "SlideBoom is a high quality and easy-to-use online slide hosting service developed by iSpring Solutions, Inc. SlideBoom takes care of preserving the original quality of your presentation so there is no need to worry about output audio-visual elements and animation effects. This is one of the reasons why professionals choose SlideBoom. SlideBoom is widely used for converting PowerPoint presentations to Flash and sharing them with colleagues, family and friends. SlideBoom also allows you to search for presentations in 100+ different languages and by 30+ categories,  discuss presentations, join an interest group or create your own - and embed presentations into your blog or website",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "SLIDEBOOM",
                FacebookName = "SLIDEBOOM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CREATELY PUBLIC
            ca = new CloudApplication()
            {
                Brand = "creately",
                ServiceName = "Public",
                CompanyURL = "http://creately.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    //repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("CREATELY"),
                Description = "Creately can be used across all sectors by individuals, corporate teams, developers, software architects, students and teachers alike for various diagramming purposes. Creately contains 100's of thoughtful features to make creately diagramming quick and natural, its a joy to use. One click styling, pretty shapes, curvy connectors and more helps you create beautiful diagrams. Smooth Real-Time collaboration, project management, inline commenting, one click publishing and team management.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "CREATELY",
                FacebookName = "CREATELY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CREATELY TEAM 5
            ca = new CloudApplication()
            {
                Brand = "creately",
                ServiceName = "Team 5",
                CompanyURL = "http://creately.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 5.00M,
                ApplicationCostPerAnnum = 50.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("CREATELY"),
                Description = "Creately can be used across all sectors by individuals, corporate teams, developers, software architects, students and teachers alike for various diagramming purposes. Creately contains 100's of thoughtful features to make creately diagramming quick and natural, its a joy to use. One click styling, pretty shapes, curvy connectors and more helps you create beautiful diagrams. Smooth Real-Time collaboration, project management, inline commenting, one click publishing and team management.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "CREATELY",
                FacebookName = "CREATELY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CREATELY TEAM 10
            ca = new CloudApplication()
            {
                Brand = "creately",
                ServiceName = "Team 10",
                CompanyURL = "http://creately.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 4.50M,
                ApplicationCostPerAnnum = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("CREATELY"),
                Description = "Creately can be used across all sectors by individuals, corporate teams, developers, software architects, students and teachers alike for various diagramming purposes. Creately contains 100's of thoughtful features to make creately diagramming quick and natural, its a joy to use. One click styling, pretty shapes, curvy connectors and more helps you create beautiful diagrams. Smooth Real-Time collaboration, project management, inline commenting, one click publishing and team management.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "CREATELY",
                FacebookName = "CREATELY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CREATELY TEAM 25
            ca = new CloudApplication()
            {
                Brand = "creately",
                ServiceName = "Team 25",
                CompanyURL = "http://creately.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 3.00M,
                ApplicationCostPerAnnum = 29.96M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("CREATELY"),
                Description = "Creately can be used across all sectors by individuals, corporate teams, developers, software architects, students and teachers alike for various diagramming purposes. Creately contains 100's of thoughtful features to make creately diagramming quick and natural, its a joy to use. One click styling, pretty shapes, curvy connectors and more helps you create beautiful diagrams. Smooth Real-Time collaboration, project management, inline commenting, one click publishing and team management.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "CREATELY",
                FacebookName = "CREATELY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LUCIDCHART PERSONAL
            ca = new CloudApplication()
            {
                Brand = "Lucidchart",
                ServiceName = "Personal",
                CompanyURL = "https://www.lucidchart.com/users/registerLevel",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("LUCIDCHART"),
                Description = "We have rethought and redesigned the entire diagramming process to make it as easy as possible. Make flow charts, wireframes, mind maps, and org charts. Drag and drop shapes onto the canvas to quickly start flowcharting and mapping out a process. There's no learning curve with our free flow chart software -- it's easy and intuitive.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "LUCIDCHART",
                FacebookName = "LUCIDCHART",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LUCIDCHART TEAM
            ca = new CloudApplication()
            {
                Brand = "Lucidchart",
                ServiceName = "Team",
                CompanyURL = "https://www.lucidchart.com/users/registerLevel",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(12),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    //repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonthFrom = 2.00M,
                ApplicationCostPerMonthTo = 5.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("LUCIDCHART"),
                Description = "We have rethought and redesigned the entire diagramming process to make it as easy as possible. Make flow charts, wireframes, mind maps, and org charts. Drag and drop shapes onto the canvas to quickly start flowcharting and mapping out a process. There's no learning curve with our free flow chart software -- it's easy and intuitive.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "LUCIDCHART",
                FacebookName = "LUCIDCHART",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 5M;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLIFFY STANDARD
            ca = new CloudApplication()
            {
                Brand = "gliffy",
                ServiceName = "Standard",
                CompanyURL = "http://www.gliffy.com/products/online/pricing/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 4.95M,
                ApplicationCostPerAnnum = 49.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("GLIFFY"),
                Description = "Gliffy is easy to use and requires no complicated software manuals. Just drag-and-drop shapes from an extensive library and point-and-click your way to format. Gliffy's intuitive drag-and-drop interface combines the power of traditional desktop software with the lightweight, low learning curve and flexible features of today's most popular browser-based applications. Gliffy works through your web browser - it's Mac and PC friendly.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "GLIFFY",
                FacebookName = "GLIFFY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = .2M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GLIFFY PRO
            ca = new CloudApplication()
            {
                Brand = "gliffy",
                ServiceName = "Pro",
                CompanyURL = "http://www.gliffy.com/products/online/pricing/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    //repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 99.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("GLIFFY"),
                Description = "Gliffy is easy to use and requires no complicated software manuals. Just drag-and-drop shapes from an extensive library and point-and-click your way to format. Gliffy's intuitive drag-and-drop interface combines the power of traditional desktop software with the lightweight, low learning curve and flexible features of today's most popular browser-based applications. Gliffy works through your web browser - it's Mac and PC friendly.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "GLIFFY",
                FacebookName = "GLIFFY",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "MB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MINDJET INDIVIDUAL
            ca = new CloudApplication()
            {
                Brand = "mindjet",
                ServiceName = "Individual",
                CompanyURL = "http://www.mindjet.com/about/?lang=en_GB",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 14.86M,
                ApplicationCostPerAnnum = 162.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("MINDJET"),
                Description = "More than two million individuals, thousands of small businesses, and 83% of Fortune 100 companies use Mindjet to generate ideas, organize information, store and share data, and manage workflow, maximizing the power of collaboration.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "MINDJET",
                FacebookName = "MINDJET",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MINDJET BUSINESS
            ca = new CloudApplication()
            {
                Brand = "mindjet",
                ServiceName = "Business",
                CompanyURL = "http://www.mindjet.com/about/?lang=en_GB",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonthFrom = 26.33M,
                ApplicationCostPerMonthTo = 59.40M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("MINDJET"),
                Description = "More than two million individuals, thousands of small businesses, and 83% of Fortune 100 companies use Mindjet to generate ideas, organize information, store and share data, and manage workflow, maximizing the power of collaboration.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "MINDJET",
                FacebookName = "MINDJET",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MINDMEISTER PERSONAL
            ca = new CloudApplication()
            {
                Brand = "mindmeister",
                ServiceName = "Personal",
                CompanyURL = "http://www.mindmeister.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    //repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("MINDMEISTER"),
                Description = "MindMeister lets you create, share and collaboratively work on mind maps, making it easy to plan projects, exchange ideas and brainstorm online with friends and colleagues.Brainstorm online with your team, create project outlines within minutes - and Increase innovation and creativity",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "MINDMEISTER",
                FacebookName = "MINDMEISTER",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MINDMEISTER PRO
            ca = new CloudApplication()
            {
                Brand = "mindmeister",
                ServiceName = "Pro",
                CompanyURL = "http://www.mindmeister.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                },
                //SupportHours = repository.FindSupportHoursByName("24"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 9.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("MINDMEISTER"),
                Description = "MindMeister lets you create, share and collaboratively work on mind maps, making it easy to plan projects, exchange ideas and brainstorm online with friends and colleagues.Brainstorm online with your team, create project outlines within minutes - and Increase innovation and creativity",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "MINDMEISTER",
                FacebookName = "MINDMEISTER",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MINDMEISTER BUSINESS
            ca = new CloudApplication()
            {
                Brand = "mindmeister",
                ServiceName = "Business",
                CompanyURL = "http://www.mindmeister.com/",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    //repository.FindDeviceByName("TABLET"),
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    repository.FindMobilePlatformByName("IPAD")
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
                    //repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    repository.FindFeatureByName("STORAGE SIZE LIMIT FOR DOCUMENTS"),
                    //repository.FindFeatureByName("AUTO BACK-UP DRIVE FOR DEVICE CONTENT"),
                    //repository.FindFeatureByName("DATA ARCHIVING & RETRIEVAL"),
                    //repository.FindFeatureByName("COMPANY-WIDE DATA DISCOVERY & EXPORT"),
                    repository.FindFeatureByName("TEAM DOCUMENT SHARED WORKSPACE"),
                    //repository.FindFeatureByName("ACTIVE DIRECTORY SYNCHRONISATION"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE (FOR DESKTOP EDITING)"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("3RD PARTY APIS",categoryID),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                CloudApplicationApplications = new List<CloudApplicationApplication>()
                {
                    //repository.FindApplicationByName("WORD PROCESSOR"),
                    //repository.FindApplicationByName("SPREADSHEET"),
                    //repository.FindApplicationByName("PRESENTATION"),
                    //repository.FindApplicationByName("CONFERENCING"),
                    //repository.FindApplicationByName("NOTES"),
                    //repository.FindApplicationByName("WEB PUBLISHING"),
                    //repository.FindApplicationByName("EMAIL (COMPREHENSIVE CLIENT)"),
                    //repository.FindApplicationByName("EMAIL SECURITY & ANTI-SPAM"),
                    //repository.FindApplicationByName("EMAIL STORAGE LIMIT PER USER"),
                    //repository.FindApplicationByName("EMAIL CONTENT TRANSLATION"),
                    //repository.FindApplicationByName("CONTACT MANAGEMENT"),
                    //repository.FindApplicationByName("SHARED CALENDAR"),
                    repository.FindApplicationByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindApplicationByName("DOCUMENT COLLABORATION (REAL-TIME)"),
                    repository.FindApplicationByName("COLLABORATIVE DIAGRAMMING/MAPPING"),
                    repository.FindApplicationByName("DOCUMENT CONSUMPTION ANALYTICS"),
                },
                ApplicationCostPerMonth = 14.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("MINDMEISTER"),
                Description = "MindMeister lets you create, share and collaboratively work on mind maps, making it easy to plan projects, exchange ideas and brainstorm online with friends and colleagues.Brainstorm online with your team, create project outlines within minutes - and Increase innovation and creativity",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "MINDMEISTER",
                FacebookName = "MINDMEISTER",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //NOTE: STORE AS GIGABYTES WITH COUNT SUFFIX SET TO ACTUAL FORMAT
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE SIZE LIMIT FOR DOCUMENTS")).CountSuffix = "GB";
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("TEAM DOCUMENT SHARED WORKSPACE")).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED DOCUMENT STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SSL SECURITY/ENCRYPTION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished OFFICE");

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
            if (ca.PaymentOptions != null)
            {
                ca.PaymentOptions.ForEach(x => x.PaymentOptionStatus = repository.FindStatusByName("LIVE"));
            }
            ca.CloudApplicationApplications.ForEach(x => x.CloudApplicationApplicationStatus = repository.FindStatusByName("LIVE"));
            //return retVal;
        }
        #endregion

    }
}
