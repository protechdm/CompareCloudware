using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class EmailProductionData
    {

        public static bool PumpEmailData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("EMAIL").CategoryID;

            #region APPLICATIONS

            #region EMAIL

            #region YAHOO SMALL BUSINESS CUSTOM MAILBOX
            ca = new CloudApplication()
            {
                Brand = "YAHOO Small Business",
                ServiceName = "Custom Mailbox",
                CompanyURL = "www.smallbusiness.yahoo.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    //repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    //repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnum = 34.95M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("25.00"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("YAHOO Small Business"),
                Description = "Yahoo! Small Business provides reliable web hosting for your website, domain name registration, web site design templates, e-commerce solutions for your online store ...",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1288,
                TwitterName = "@YSmallBusiness",
                FacebookName = "YahooSmallBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YAHOO SMALL BUSINESS BUSINESS MAIL
            ca = new CloudApplication()
            {
                Brand = "YAHOO Small Business",
                ServiceName = "Business Mail",
                CompanyURL = "www.smallbusiness.yahoo.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    //repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    //repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("25.00"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("YAHOO Small Business"),
                Description = "Yahoo! Small Business provides reliable web hosting for your website, domain name registration, web site design templates, e-commerce solutions for your online store ...",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1288,
                TwitterName = "@YSmallBusiness",
                FacebookName = "YahooSmallBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YAHOO SMALL BUSINESS WEB HOSTING ADVANCED
            ca = new CloudApplication()
            {
                Brand = "YAHOO Small Business",
                ServiceName = "Web Hosting Advanced",
                CompanyURL = "www.smallbusiness.yahoo.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    //repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    //repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonthFrom = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("25.00"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("YAHOO Small Business"),
                Description = "Yahoo! Small Business provides reliable web hosting for your website, domain name registration, web site design templates, e-commerce solutions for your online store ...",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1288,
                TwitterName = "@YSmallBusiness",
                FacebookName = "YahooSmallBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT EXCHANGE ONLINE EXCHANGE ONLINE PLAN 1
            ca = new CloudApplication()
            {
                Brand = "Microsoft Exchange Online",
                ServiceName = "Exchange Online Plan 1",
                CompanyURL = "www.office365.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 2.60M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("Microsoft Exchange Online"),
                Description = "Office 365 adds more power to the Office you already know and use by making it easier to communicate and collaborate with others",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = "@msonline",
                FacebookName = "microsoftfope",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT EXCHANGE ONLINE EXCHANGE ONLINE PLAN 2
            ca = new CloudApplication()
            {
                Brand = "Microsoft Exchange Online",
                ServiceName = "Exchange Online Plan 2",
                CompanyURL = "www.office365.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 5.20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("Microsoft Exchange Online"),
                Description = "Office 365 adds more power to the Office you already know and use by making it easier to communicate and collaborate with others",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = "@msonline",
                FacebookName = "microsoftfope",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MAIL STANDARD 10GIG
            ca = new CloudApplication()
            {
                Brand = "ZOHO Mail",
                ServiceName = "Standard 10Gig",
                CompanyURL = "www.zoho.com/mail",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 2.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                //CallsPackageCostPerMonth = 0M,
                ApplicationCostPerAnnum = 24.00M,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("ZOHO Mail"),
                Description = "Get Business Email With Calendar, Tasks, Notes, Contacts & More",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@ZohoMail",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.01M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MAIL STANDARD 15GIG
            ca = new CloudApplication()
            {
                Brand = "ZOHO Mail",
                ServiceName = "Standard 15Gig",
                CompanyURL = "www.zoho.com/mail",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 3.50M,
                //CallsPackageCostPerMonth = 0M,
                ApplicationCostPerAnnum = 36.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("ZOHO Mail"),
                Description = "Get Business Email With Calendar, Tasks, Notes, Contacts & More",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@ZohoMail",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.015M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MAIL LITE
            ca = new CloudApplication()
            {
                Brand = "ZOHO Mail",
                ServiceName = "Lite",
                CompanyURL = "www.zoho.com/mail",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0M,
                //CallsPackageCostPerMonth = 0M,
                ApplicationCostPerAnnum = 0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("ZOHO Mail"),
                Description = "Get Business Email With Calendar, Tasks, Notes, Contacts & More",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@ZohoMail",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.01M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SMS BASIC
            ca = new CloudApplication()
            {
                Brand = "SMS",
                ServiceName = "Basic",
                CompanyURL = "www.simplymailsolutions.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 1.0M,
                //CallsPackageCostPerMonth = 0M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("SMS"),
                Description = "Simply Mail Solutions is a leading application service provider, you can expect the best in the latest technology ensuring maximum utilization of application functionality. In fact, through empowering your hosting requirements with our servers, SMS can advance your business by providing a FTSE 100 infrastructure. By accessing the same communication tools as your largest competitors, you can 'level the playing field' in many respects. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 211116,
                TwitterName = "@SimplyMS_status",
                FacebookName = "SimplyMailSolutions",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SMS ESSENTIALS
            ca = new CloudApplication()
            {
                Brand = "SMS",
                ServiceName = "Essentials",
                CompanyURL = "www.simplymailsolutions.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 3.33M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("SMS"),
                Description = "Simply Mail Solutions is a leading application service provider, you can expect the best in the latest technology ensuring maximum utilization of application functionality. In fact, through empowering your hosting requirements with our servers, SMS can advance your business by providing a FTSE 100 infrastructure. By accessing the same communication tools as your largest competitors, you can 'level the playing field' in many respects. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 211116,
                TwitterName = "@SimplyMS_status",
                FacebookName = "SimplyMailSolutions",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SMS CLASSIC
            ca = new CloudApplication()
            {
                Brand = "SMS",
                ServiceName = "Classic",
                CompanyURL = "www.simplymailsolutions.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("SMS"),
                Description = "Simply Mail Solutions is a leading application service provider, you can expect the best in the latest technology ensuring maximum utilization of application functionality. In fact, through empowering your hosting requirements with our servers, SMS can advance your business by providing a FTSE 100 infrastructure. By accessing the same communication tools as your largest competitors, you can 'level the playing field' in many respects. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 211116,
                TwitterName = "@SimplyMS_status",
                FacebookName = "SimplyMailSolutions",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SMS EXECUTIVE
            ca = new CloudApplication()
            {
                Brand = "SMS",
                ServiceName = "Executive",
                CompanyURL = "www.simplymailsolutions.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 8.33M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("SMS"),
                Description = "Simply Mail Solutions is a leading application service provider, you can expect the best in the latest technology ensuring maximum utilization of application functionality. In fact, through empowering your hosting requirements with our servers, SMS can advance your business by providing a FTSE 100 infrastructure. By accessing the same communication tools as your largest competitors, you can 'level the playing field' in many respects. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 211116,
                TwitterName = "@SimplyMS_status",
                FacebookName = "SimplyMailSolutions",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUETIE BUSINESS EMAIL
            ca = new CloudApplication()
            {
                Brand = "BlueTie",
                ServiceName = "Business Email",
                CompanyURL = "www.bluetie.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("BlueTie"),
                Description = "BlueTie is the leading provider of hosted email and calendaring solutions for small to mid-sized businesses (SMBs) and service providers worldwide. BlueTie was established in 1999 by serial entrepreneur David Koretz, BlueTie President and CEO, and Tom Golisano, founder and Chairman of Paychex® (NASDAQ:PAYX) — a $2 billion payroll provider serving the SMB market.                                                     BlueTie revolutionized the Software as a Service sector in 1999 by introducing the first hosted suite of small business collaboration. Since then, BlueTie has been one of the fastest growing software providers in the world, supporting more than 230,000 businesses and millions of users under its current paid distribution model (6 billion emails per month). BlueTie is supported by a direct sales force, eCommerce sales, 650 resellers and distribution via dozens of ISPs worldwide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26220,
                TwitterName = "@BlueTieInc",
                FacebookName = "BlueTie",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUETIE EXCHANGE STANDARD
            ca = new CloudApplication()
            {
                Brand = "BlueTie",
                ServiceName = "Exchange Standard",
                CompanyURL = "www.bluetie.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonthFrom = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("BlueTie"),
                Description = "BlueTie is the leading provider of hosted email and calendaring solutions for small to mid-sized businesses (SMBs) and service providers worldwide. BlueTie was established in 1999 by serial entrepreneur David Koretz, BlueTie President and CEO, and Tom Golisano, founder and Chairman of Paychex® (NASDAQ:PAYX) — a $2 billion payroll provider serving the SMB market.                                                     BlueTie revolutionized the Software as a Service sector in 1999 by introducing the first hosted suite of small business collaboration. Since then, BlueTie has been one of the fastest growing software providers in the world, supporting more than 230,000 businesses and millions of users under its current paid distribution model (6 billion emails per month). BlueTie is supported by a direct sales force, eCommerce sales, 650 resellers and distribution via dozens of ISPs worldwide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26220,
                TwitterName = "@BlueTieInc",
                FacebookName = "BlueTie",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BLUETIE EXCHANGE ADVANCED
            ca = new CloudApplication()
            {
                Brand = "BlueTie",
                ServiceName = "Exchange Advanced",
                CompanyURL = "www.bluetie.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonthFrom = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("BlueTie"),
                Description = "BlueTie is the leading provider of hosted email and calendaring solutions for small to mid-sized businesses (SMBs) and service providers worldwide. BlueTie was established in 1999 by serial entrepreneur David Koretz, BlueTie President and CEO, and Tom Golisano, founder and Chairman of Paychex® (NASDAQ:PAYX) — a $2 billion payroll provider serving the SMB market.                                                     BlueTie revolutionized the Software as a Service sector in 1999 by introducing the first hosted suite of small business collaboration. Since then, BlueTie has been one of the fastest growing software providers in the world, supporting more than 230,000 businesses and millions of users under its current paid distribution model (6 billion emails per month). BlueTie is supported by a direct sales force, eCommerce sales, 650 resellers and distribution via dozens of ISPs worldwide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 26220,
                TwitterName = "@BlueTieInc",
                FacebookName = "BlueTie",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GMAIL
            ca = new CloudApplication()
            {
                Brand = "GMail",
                ServiceName = "Business GMail",
                CompanyURL = "www.google.com/apps",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 3.30M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("GMail"),
                Description = "Gmail works on any computer or mobile device with a data connection and offline support lets you keep working even when you’re disconnected. Whether you're at your desk, in a meeting, or on a plane, your email is there.                                                                                                                                        Gmail is designed to make you more productive. 25GB of storage means you never have to delete anything, powerful search lets you find everything, and labels and filters help you stay organized.                                                                                    Your inbox isn't just about messages, it's about people too. Text, voice, and video chat lets you see who’s online and connect instantly. See your contacts’ profile photos, recent updates and shared docs next to each email.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1441,
                TwitterName = "GMail",
                FacebookName = "GMail",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GMAIL
            ca = new CloudApplication()
            {
                Brand = "GMail",
                ServiceName = "Business GMail With Vault",
                CompanyURL = "www.google.com/apps",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 6.60M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("GMail"),
                Description = "Gmail works on any computer or mobile device with a data connection and offline support lets you keep working even when you’re disconnected. Whether you're at your desk, in a meeting, or on a plane, your email is there.                                                                                                                                        Gmail is designed to make you more productive. 25GB of storage means you never have to delete anything, powerful search lets you find everything, and labels and filters help you stay organized.                                                                                    Your inbox isn't just about messages, it's about people too. Text, voice, and video chat lets you see who’s online and connect instantly. See your contacts’ profile photos, recent updates and shared docs next to each email.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1441,
                TwitterName = "GMail",
                FacebookName = "GMail",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.025M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region STAR
            ca = new CloudApplication()
            {
                Brand = "Star",
                ServiceName = "Star Business Email",
                CompanyURL = "http://email.star.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 8.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("Star"),
                Description = "Now you can take away the headaches, distraction and cost of managing email and instant messaging yourself with Star Business Email. By optimising and integrating Microsoft technology and the best email security, Star gives you the email solution that your business deserves",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 285322,
                TwitterName = "Star",
                FacebookName = "Star",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.020M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE BUSINESS EMAIL
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Business Email",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonthFrom = 3.0M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "Business Email Service HyperOffice is a custom business email accessible from any web connected PC, Mac or mobile device in the world with complete Outlook compatibility. An effective business email service allows you to focus on your business rather than worry about managing an email system. We provide a reliable cloud based email solution with no requirement for any expensive hardware or complex software. With our business email service, you can send and receive email, sync with Outlook, access advanced email tools, and stay connected to your business with just an Internet connection. If you prefer, you can even push and manage email from almost every major mobile device in the market. HyperOffice also rises to your advanced business email needs such as email archiving.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonthFrom = 15.0M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = "Business Email Service HyperOffice is a custom business email accessible from any web connected PC, Mac or mobile device in the world with complete Outlook compatibility. An effective business email service allows you to focus on your business rather than worry about managing an email system. We provide a reliable cloud based email solution with no requirement for any expensive hardware or complex software. With our business email service, you can send and receive email, sync with Outlook, access advanced email tools, and stay connected to your business with just an Internet connection. If you prefer, you can even push and manage email from almost every major mobile device in the market. HyperOffice also rises to your advanced business email needs such as email archiving.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 40617,
                TwitterName = "HyperOffice",
                FacebookName = "HyperOffice",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTMAIL BASIC
            ca = new CloudApplication()
            {
                Brand = "FastMail",
                ServiceName = "Basic",
                CompanyURL = "www.fastmail.fm",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 15.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FastMail"),
                Description = "Thousands of companies have chosen FastMail as their business email provider for its rock solid reliability and secure data storage.At FastMail, we’ve been hosting email for over 13 years. With full redundancy all the way down the stack, we’re committed to keeping your email available 24/7. Ensure all mail sent or received is kept in a secure read-only archive, for as long as you need based on your business and industry requirements. It’s administrator-configurable on a per-user basis. Phone, tablet or computer: your email is always there, always in sync. Use our full support for the IMAP, POP and SMTP email standards to connect any native client, or access your email in any web browser through our powerful webmail service. Already have an email address? No problem, we can import your mail and contacts with just a few clicks. You can even send and receive email from your existing address with your new account.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2408388,
                TwitterName = "FastMail",
                FacebookName = "FastMail.FM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 0.002M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTMAIL STANDARD
            ca = new CloudApplication()
            {
                Brand = "FastMail",
                ServiceName = "Standard",
                CompanyURL = "www.fastmail.fm",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 30.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FastMail"),
                Description = "Thousands of companies have chosen FastMail as their business email provider for its rock solid reliability and secure data storage.At FastMail, we’ve been hosting email for over 13 years. With full redundancy all the way down the stack, we’re committed to keeping your email available 24/7. Ensure all mail sent or received is kept in a secure read-only archive, for as long as you need based on your business and industry requirements. It’s administrator-configurable on a per-user basis. Phone, tablet or computer: your email is always there, always in sync. Use our full support for the IMAP, POP and SMTP email standards to connect any native client, or access your email in any web browser through our powerful webmail service. Already have an email address? No problem, we can import your mail and contacts with just a few clicks. You can even send and receive email from your existing address with your new account.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2408388,
                TwitterName = "FastMail",
                FacebookName = "FastMail.FM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 0.1M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "MB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTMAIL PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "FastMail",
                ServiceName = "Professional",
                CompanyURL = "www.fastmail.fm",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 60.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FastMail"),
                Description = "Thousands of companies have chosen FastMail as their business email provider for its rock solid reliability and secure data storage.At FastMail, we’ve been hosting email for over 13 years. With full redundancy all the way down the stack, we’re committed to keeping your email available 24/7. Ensure all mail sent or received is kept in a secure read-only archive, for as long as you need based on your business and industry requirements. It’s administrator-configurable on a per-user basis. Phone, tablet or computer: your email is always there, always in sync. Use our full support for the IMAP, POP and SMTP email standards to connect any native client, or access your email in any web browser through our powerful webmail service. Already have an email address? No problem, we can import your mail and contacts with just a few clicks. You can even send and receive email from your existing address with your new account.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2408388,
                TwitterName = "FastMail",
                FacebookName = "FastMail.FM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 6M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTMAIL ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "FastMail",
                ServiceName = "Enterprise",
                CompanyURL = "www.fastmail.fm",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 300.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FastMail"),
                Description = "Thousands of companies have chosen FastMail as their business email provider for its rock solid reliability and secure data storage.At FastMail, we’ve been hosting email for over 13 years. With full redundancy all the way down the stack, we’re committed to keeping your email available 24/7. Ensure all mail sent or received is kept in a secure read-only archive, for as long as you need based on your business and industry requirements. It’s administrator-configurable on a per-user basis. Phone, tablet or computer: your email is always there, always in sync. Use our full support for the IMAP, POP and SMTP email standards to connect any native client, or access your email in any web browser through our powerful webmail service. Already have an email address? No problem, we can import your mail and contacts with just a few clicks. You can even send and receive email from your existing address with your new account.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2408388,
                TwitterName = "FastMail",
                FacebookName = "FastMail.FM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 60M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBFUSION SMALL BUSINESS
            ca = new CloudApplication()
            {
                Brand = "webfusion",
                ServiceName = "Small Business",
                CompanyURL = "www.webfusion.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 10.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("webfusion"),
                Description = "Established in 1997, Webfusion is one of the UK's leading web hosting groups. We offer cost-effective, feature-rich hosting packages for everyone from businesses, web developers, designers and hobbyists. Click one of the links below to find out more about Webfusion and the services we provide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 365439,
                TwitterName = "webfusion",
                FacebookName = "webfusionuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBFUSION PREMIUM
            ca = new CloudApplication()
            {
                Brand = "webfusion",
                ServiceName = "Premium",
                CompanyURL = "www.webfusion.co.uk",
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(24),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 104.90M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("webfusion"),
                Description = "Established in 1997, Webfusion is one of the UK's leading web hosting groups. We offer cost-effective, feature-rich hosting packages for everyone from businesses, web developers, designers and hobbyists. Click one of the links below to find out more about Webfusion and the services we provide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 365439,
                TwitterName = "webfusion",
                FacebookName = "webfusionuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBFUSION PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "webfusion",
                ServiceName = "Professional",
                CompanyURL = "www.webfusion.co.uk",
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(25),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 249.75M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("webfusion"),
                Description = "Established in 1997, Webfusion is one of the UK's leading web hosting groups. We offer cost-effective, feature-rich hosting packages for everyone from businesses, web developers, designers and hobbyists. Click one of the links below to find out more about Webfusion and the services we provide.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 365439,
                TwitterName = "webfusion",
                FacebookName = "webfusionuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region RACKSPACE EMAIL
            ca = new CloudApplication()
            {
                Brand = "rackspace",
                ServiceName = "Rackspace Email",
                CompanyURL = "www.rackspace.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 1.35M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("rackspace"),
                Description = "Rackspace Email offers you a comprehensive, web-based email service that is fully-managed on your behalf. Take advantage of the latest security, outstanding functionality and 24/7/365 award-winning Fanatical Support - without the hassle of installation and maintenance. By combining the power of web-based technologies with the convenience of outsourced management, you can enjoy high performance at low cost on your way to greater business success. We have delivered enterprise-level hosting services to businesses of all sizes and kinds around the world since 1998 and have grown to serve more than 190,000 customers. Rackspace integrates the industry's best technologies for each customer's specific need and delivers it as a service via our commitment to Fanatical Support. Our core products include Managed Hosting, Cloud Hosting and Email & Apps. There are currently over 4,000 Rackers around the world serving our customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5234,
                TwitterName = "rackspace",
                FacebookName = "rackspace",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region RACKSPACE HOSTED EXCHANGE
            ca = new CloudApplication()
            {
                Brand = "rackspace",
                ServiceName = "Hosted Exchange",
                CompanyURL = "www.rackspace.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 6.75M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("rackspace"),
                Description = "Keep Exchange but lose the server, all from £6.75 per mailbox per month. Exchange from Rackspace offers you a comprehensive, web-based email service that is fully-managed on your behalf. Take advantage of the latest security, outstanding functionality and 24/7/365 award-winning Fanatical Support - without the hassle of installation and maintenance. By combining the power of web-based technologies with the convenience of outsourced management, you can enjoy high performance at low cost on your way to greater business success. We have delivered enterprise-level hosting services to businesses of all sizes and kinds around the world since 1998 and have grown to serve more than 190,000 customers. Rackspace integrates the industry's best technologies for each customer's specific need and delivers it as a service via our commitment to Fanatical Support. Our core products include Managed Hosting, Cloud Hosting and Email & Apps. There are currently over 4,000 Rackers around the world serving our customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5234,
                TwitterName = "rackspace",
                FacebookName = "rackspace",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 6;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ECLIPSE HOSTED EXCHANGE STANDARD
            ca = new CloudApplication()
            {
                Brand = "eclipse",
                ServiceName = "Hosted Exchange Standard",
                CompanyURL = "www.eclipse.net.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 5.49M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("eclipse"),
                Description = "Eclipse make internet services that work for you r business. No more vague and forgettable email addresses or reliance on a mass-market email provider - get your own address, based around your business name. What's more, never have to change email addresses again, even if you change provider.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 201002,
                TwitterName = "eclipse",
                FacebookName = "eclipse",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ECLIPSE HOSTED EXCHANGE PREMIUM
            ca = new CloudApplication()
            {
                Brand = "eclipse",
                ServiceName = "Hosted Exchange Premium",
                CompanyURL = "www.eclipse.net.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 9.49M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("eclipse"),
                Description = "Eclipse make internet services that work for you r business. No more vague and forgettable email addresses or reliance on a mass-market email provider - get your own address, based around your business name. What's more, never have to change email addresses again, even if you change provider.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 201002,
                TwitterName = "eclipse",
                FacebookName = "eclipse",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUSEMAIL STANDARD
            ca = new CloudApplication()
            {
                Brand = "FuseMail",
                ServiceName = "Standard",
                CompanyURL = "www.fusemail.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 2.0M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FuseMail"),
                Description = "FuseMail's business email solution is ideal for busy professionals, letting you create email addresses for your own Web domain as well as create additional mailboxes for all your employees. And rest assured that FuseMail® comes fully loaded with spam- and virus-filtering technology to help ensure that your mailboxes are secure and always online.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1002221,
                TwitterName = "FuseMail",
                FacebookName = "FuseMail",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUSEMAIL PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "FuseMail",
                ServiceName = "Professional",
                CompanyURL = "www.fusemail.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("EMAIL"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 5.0M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FuseMail"),
                Description = "FuseMail's business email solution is ideal for busy professionals, letting you create email addresses for your own Web domain as well as create additional mailboxes for all your employees. And rest assured that FuseMail® comes fully loaded with spam- and virus-filtering technology to help ensure that your mailboxes are secure and always online.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1002221,
                TwitterName = "FuseMail",
                FacebookName = "FuseMail",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTHOSTS PERSONAL
            ca = new CloudApplication()
            {
                Brand = "fasthosts",
                ServiceName = "Personal",
                CompanyURL = "www.fasthosts.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 1.39M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("fasthosts"),
                Description = "Improve productivity, collaborate effectively and communicate securely with Hosted Exchange 2010 email from FastHosts. Fasthosts Personal email package is the ideal way to send professional, personalised email from your domain name.Fasthosts has delivered market-leading online services to the home, home office and SME markets since 1999. We have a successful track record in providing high value, award winning products.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 424505,
                TwitterName = "fasthosts",
                FacebookName = "fasthosts",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.015M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTHOSTS BUSINESS STANDARD
            ca = new CloudApplication()
            {
                Brand = "fasthosts",
                ServiceName = "Business Standard",
                CompanyURL = "www.fasthosts.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 9.99M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("45"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("fasthosts"),
                Description = "Communicate more effectively without breaking the bank. Fasthosts outstanding value Business Standard Exchange email package gives you access to email anywhere and a huge 5GB mailbox.Improve productivity, collaborate effectively and communicate securely with Hosted Exchange 2010 email from FastHosts. Fasthosts Personal email package is the ideal way to send professional, personalised email from your domain name.Fasthosts has delivered market-leading online services to the home, home office and SME markets since 1999. We have a successful track record in providing high value, award winning products.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 424505,
                TwitterName = "fasthosts",
                FacebookName = "fasthosts",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FASTHOSTS BUSINESS PREMIUM
            ca = new CloudApplication()
            {
                Brand = "fasthosts",
                ServiceName = "Business Premium",
                CompanyURL = "www.fasthosts.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 1.39M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("45"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("fasthosts"),
                Description = "Improve productivity in your business with the Business Premium Exchange email package. You’ll get the email and collaboration tools you need, without the hassle of an in-house Exchange server.Improve productivity, collaborate effectively and communicate securely with Hosted Exchange 2010 email from FastHosts. Fasthosts Personal email package is the ideal way to send professional, personalised email from your domain name.Fasthosts has delivered market-leading online services to the home, home office and SME markets since 1999. We have a successful track record in providing high value, award winning products.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 424505,
                TwitterName = "fasthosts",
                FacebookName = "fasthosts",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 16384;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.01M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTERMEDIA
            ca = new CloudApplication()
            {
                Brand = "INTERMEDIA",
                ServiceName = "Hosted Exchange",
                CompanyURL = "www.intermedia.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 1.50M,
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
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("INTERMEDIA"),
                Description = "Intermedia became the world’s largest Exchange hosting company by delivering more than an Exchange mailbox. We deliver an Office in the Cloud™.Intermedia is the world's premier provider of business communications services, including hosted Microsoft Exchange, to small-and-medium-sized businesses. Founded in 1995, Intermedia was the first to offer cloud-based business-class email - including the first to market with hosted Exchange 2010 - and now has over 400,000 premium hosted Exchange mailboxes under management worldwide - more than any other provider.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 8903,
                TwitterName = "INTERMEDIA",
                FacebookName = "INTERMEDIA",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.05M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 INSTANT MAIL
            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Instant Mail",
                CompanyURL = "www.1and1.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 0.69M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("4.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("1&1"),
                Description = "1&1 E-MAIL SOLUTIONS FOR HOME AND BUSINESS. E-mail packages for every business or personal need Fast and secure access to your e-mails, contacts, calendar and data anytime and anywhere Automatic smartphone and tablet synchronisation",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 10298,
                TwitterName = "@1and1_UK",
                FacebookName = "1and1uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 MICROSOFT EXCHANGE
            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Microsoft Exchange",
                CompanyURL = "www.1and1.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("4.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("1&1"),
                Description = "1&1 E-MAIL SOLUTIONS FOR HOME AND BUSINESS. E-mail packages for every business or personal need Fast and secure access to your e-mails, contacts, calendar and data anytime and anywhere Automatic smartphone and tablet synchronisation",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 10298,
                TwitterName = "@1and1_UK",
                FacebookName = "1and1uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 2;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 MAILXCHANGE
            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "MailXChange",
                CompanyURL = "www.1and1.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
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
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING",categoryID),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("4.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("1&1"),
                Description = "1&1 E-MAIL SOLUTIONS FOR HOME AND BUSINESS. E-mail packages for every business or personal need Fast and secure access to your e-mails, contacts, calendar and data anytime and anywhere Automatic smartphone and tablet synchronisation",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 10298,
                TwitterName = "@1and1_UK",
                FacebookName = "1and1uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("NUMBER OF MAILBOXES")).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).Count = 0.02M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE SIZE LIMIT")).CountSuffix = "MB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL ARCHIVING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MIGRATION SERVICE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion
            Console.WriteLine("Finished EMAIL");

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

    }
}
