using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class PhoneProductionData
    {

        public static bool PumpPhoneData(QueryRepository repository)
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
            string SAMPLE_REVIEW_PDF = @"http://www.samplepdf.com/sample.pdf";
            string SAMPLE_REVIEW_DOC = @"http://www.swiftview.com/tech/letterlegal5.doc";
            string SAMPLE_REVIEW_URL = @"http://www.amazon.co.uk/product-reviews/B000KKNQBK";
            string SAMPLE_REVIEW_URL_BROKEN = @"http://reviews.argos.co.uk/1493-en_gb/058897/broken-reviews.htm";
            CloudApplication ca;

            string PDF_TEST_WHITE_PAPER_FILENAME = "words.pdf";
            string PDF_TEST_CASE_STUDY_FILENAME = "adobeid.pdf";

            bool retVal = true;

            int categoryID = repository.FindCategoryByName("COMMUNICATIONS").CategoryID;

            #region APPLICATIONS

            #region PHONE

            #region SKYPE FREE
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Free",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    //repository.FindSupportTypeByName("CHAT"),
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    //repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    //repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Premium",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 2.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE UNLIMITED SINGLE COUNTRY
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited Single Country",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 0.69M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE UNLIMITED EUROPE
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited Europe",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE UNLIMITED EUROPE MOBILE
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited Europe Mobile",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 24.49M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE UNLIMITED WORLD
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited World",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 8.49M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SKYPE UNLIMITED WORLD PLUS CHINA
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited World Plus China",
                CompanyURL = "www.skype.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY"),
                    repository.FindSupportTypeByName("CHAT"),
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 13.49M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = "Skype is for doing things together, whenever you’re apart. Skype’s text, voice and video make it simple to share experiences with the people that matter to you, wherever they are.                                                                                                                                                        With Skype, you can share a story, celebrate a birthday, learn a language, hold a meeting, work with colleagues – just about anything you need to do together every day. You can use Skype on whatever works best for you - on your phone or computer or a TV with Skype on it. It is free to start using Skype - to speak, see and instant message other people on Skype for example. You can even try out group video, with the latest version of Skype.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7299,
                TwitterName = "SKYPE",
                FacebookName = "SKYPE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN UK
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan UK",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 3.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN US
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan US",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN AFRICA
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan Africa",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN 2
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan 2",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 5.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN 3
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan 3",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 6.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN 4i
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan 4i",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN BUSINESS LITE
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan Business Lite",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE V-PLAN BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan Business",
                CompanyURL = "www.vonage.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = "Vonage is a leading provider of low-cost communications services connecting individuals through broadband devices worldwide. Our technology serves approximately 2.4 million subscribers. We provide feature-rich, affordable communication solutions that offer flexibility, portability and ease-of-use. Our Vonage World plan offers unlimited calling to more than 60 countries with popular features like call waiting, call forwarding and voicemail - for one low monthly rate. Vonage's service is sold on the web and through regional and national retailers including Wal-Mart Stores Inc. and is available to customers in the U.S. (www.vonage.com), Canada (www.vonage.ca) and the United Kingdom (www.vonage.co.uk).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5028,
                TwitterName = "Vonage",
                FacebookName = "Vonage",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN PAY AS YOU GO
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "Pay As You Go",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    //repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0.00M,
                PayAsYouGo = true,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN UK 500
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "UK 500",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    //repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    //repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 7.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN INTERNATIONAL 500
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "International 500",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN ENTREPENEUR CLOUD PBX
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "Entrepeneur Cloud PBX",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 0.00M,
                ApplicationCostPerMonthFree = true,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN GROW CLOUD PBX
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "Grow Cloud PBX",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 6.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CONNEXIN MAX CLOUD PBX
            ca = new CloudApplication()
            {
                Brand = "Connexin",
                ServiceName = "Max Cloud PBX",
                CompanyURL = "www.connexin.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 10.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Connexin"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Connexin",
                FacebookName = "Connexin",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE ONE NET EXPRESS
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "One Net Express",
                CompanyURL = "www.vodafone.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("WIN"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 55.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = "Vodafone made the UK's first mobile call at a few minutes past midnight on 1 January 1985. Within fifteen years, the network was the largest company in Europe and the largest of its kind anywhere in the world.                                                                                             By the turn of the century, almost every second UK citizen had a mobile – and a third of them were connected to Vodafone.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1217,
                TwitterName = "Vodafone",
                FacebookName = "vodafoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE ONE NET BUSINESS COMPLETE
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "One Net Business Complete",
                CompanyURL = "www.vodafone.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("WIN"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 55.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = "Vodafone made the UK's first mobile call at a few minutes past midnight on 1 January 1985. Within fifteen years, the network was the largest company in Europe and the largest of its kind anywhere in the world.                                                                                             By the turn of the century, almost every second UK citizen had a mobile – and a third of them were connected to Vodafone.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1217,
                TwitterName = "Vodafone",
                FacebookName = "vodafoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE ONE NET BUSINESS MOBILE
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "One Net Business Mobile",
                CompanyURL = "www.vodafone.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("WIN"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = "Vodafone made the UK's first mobile call at a few minutes past midnight on 1 January 1985. Within fifteen years, the network was the largest company in Europe and the largest of its kind anywhere in the world.                                                                                             By the turn of the century, almost every second UK citizen had a mobile – and a third of them were connected to Vodafone.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1217,
                TwitterName = "Vodafone",
                FacebookName = "vodafoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE ONE NET BUSINESS OFFICE
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "One Net Business Office",
                CompanyURL = "www.vodafone.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("WIN"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = "Vodafone made the UK's first mobile call at a few minutes past midnight on 1 January 1985. Within fifteen years, the network was the largest company in Europe and the largest of its kind anywhere in the world.                                                                                             By the turn of the century, almost every second UK citizen had a mobile – and a third of them were connected to Vodafone.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1217,
                TwitterName = "Vodafone",
                FacebookName = "vodafoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE RED BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "Red Business",
                CompanyURL = "www.vodafone.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("WIN"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 40.83M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = "Vodafone made the UK's first mobile call at a few minutes past midnight on 1 January 1985. Within fifteen years, the network was the largest company in Europe and the largest of its kind anywhere in the world.                                                                                             By the turn of the century, almost every second UK citizen had a mobile – and a third of them were connected to Vodafone.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1217,
                TwitterName = "Vodafone",
                FacebookName = "vodafoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPTALK UNLIMITED
            ca = new CloudApplication()
            {
                Brand = "VoIPtalk",
                ServiceName = "VoIPtalk Unlimited",
                CompanyURL = "www.voiptalk.org",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //repository.FindMobilePlatformByName("WIN"),
                //repository.FindMobilePlatformByName("Blackberry"),
                //repository.FindMobilePlatformByName("ANDROID"),
                //repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("14.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("VoIPtalk"),
                Description = "Whether you are a home-based business or an enterprise customer, our wide range of VoIP  services allows you to unleash the power of the Internet to transform your communications.  We provide a full range of VoIP solutions which are ideal for businesses looking to implement a reliable and advanced telephone system.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "VoIPtalk",
                FacebookName = "VoIPtalk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPTALK 1000
            ca = new CloudApplication()
            {
                Brand = "VoIPtalk",
                ServiceName = "VoIPtalk 1000",
                CompanyURL = "www.voiptalk.org",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //repository.FindMobilePlatformByName("WIN"),
                //repository.FindMobilePlatformByName("Blackberry"),
                //repository.FindMobilePlatformByName("ANDROID"),
                //repository.FindMobilePlatformByName("IPHONE")
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
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("14.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("VoIPtalk"),
                Description = "Whether you are a home-based business or an enterprise customer, our wide range of VoIP  services allows you to unleash the power of the Internet to transform your communications.  We provide a full range of VoIP solutions which are ideal for businesses looking to implement a reliable and advanced telephone system.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "VoIPtalk",
                FacebookName = "VoIPtalk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPOFFICE HOSTED LITE
            ca = new CloudApplication()
            {
                Brand = "VoIPtalk",
                ServiceName = "VoIPOffice Hosted Lite",
                CompanyURL = "www.voiptalk.org",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //repository.FindMobilePlatformByName("WIN"),
                //repository.FindMobilePlatformByName("Blackberry"),
                //repository.FindMobilePlatformByName("ANDROID"),
                //repository.FindMobilePlatformByName("IPHONE")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 5.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("VoIPtalk"),
                Description = "VoIPOffice is a feature-rich, flexible and cost-effective business telephone system. VoIPOffice offers crystal-clear quality, low call tariffs and a multitude of features that enable your business to communicate more effectively. It's a fully hosted cloud service, eliminating the need to purchase, install and maintain expensive telephony hardware. The entry-level hosted telephony service for small businesses. Call anywhere in the world for a fraction of the usual cost; avoid buying an expensive hardware PBX; and stop using expensive legacy telephone and ISDN lines.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "VoIPtalk",
                FacebookName = "VoIPtalk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPOFFICE HOSTED PRO
            ca = new CloudApplication()
            {
                Brand = "VoIPtalk",
                ServiceName = "VoIPOffice Hosted Pro",
                CompanyURL = "www.voiptalk.org",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //repository.FindMobilePlatformByName("WIN"),
                //repository.FindMobilePlatformByName("Blackberry"),
                //repository.FindMobilePlatformByName("ANDROID"),
                //repository.FindMobilePlatformByName("IPHONE")
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(21),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 8.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("VoIPtalk"),
                Description = "VoIPOffice is a feature-rich, flexible and cost-effective business telephone system. VoIPOffice offers crystal-clear quality, low call tariffs and a multitude of features that enable your business to communicate more effectively. It's a fully hosted cloud service, eliminating the need to purchase, install and maintain expensive telephony hardware. The entry-level hosted telephony service for small businesses. Call anywhere in the world for a fraction of the usual cost; avoid buying an expensive hardware PBX; and stop using expensive legacy telephone and ISDN lines.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "VoIPtalk",
                FacebookName = "VoIPtalk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region GRADWELL SINGLE USER VOIP
            ca = new CloudApplication()
            {
                Brand = "Gradwell",
                ServiceName = "Single User VoIP",
                CompanyURL = "www.gradwell.com",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 4.00M,
                CallsPackageCostPerMonth = 25.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("4.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Gradwell"),
                Description = "Easy to set up. Easy to manage. Perfect for use with Gradwell Broadband or your existing Internet set up.                                                                               Our Internet telephony services (VoIP) can transform your company and push your business to the cutting edge. Whether you need a single number forwarded to your mobile, or a complete business phone system, we can help.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 214880,
                TwitterName = "@GradwellTweets",
                FacebookName = "Gradwell",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region GRADWELL MULTI-USER VOIP
            ca = new CloudApplication()
            {
                Brand = "Gradwell",
                ServiceName = "Multi-User VoIP",
                CompanyURL = "www.gradwell.com",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 8.00M,
                CallsPackageCostPerMonth = 25.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Gradwell"),
                Description = "Easy to set up. Easy to manage. Perfect for use with Gradwell Broadband or your existing Internet set up.                                                                               Our Internet telephony services (VoIP) can transform your company and push your business to the cutting edge. Whether you need a single number forwarded to your mobile, or a complete business phone system, we can help.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 214880,
                TwitterName = "@GradwellTweets",
                FacebookName = "Gradwell",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region RINGCENTRAL HOSTED PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "RingCentral",
                ServiceName = "Hosted Professional",
                CompanyURL = "www.ringcentral.co.uk",
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
                CallsPackageCostPerMonth = 14.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("RingCentral"),
                Description = "RingCentral provides cloud computing based business phone systems designed for today's mobile and distributed business world. The RingCentral technology platform eliminates the need for expensive and technically complex on-premise legacy phone systems. By combining a hosted, multi-extension business phone system with advanced voice and fax functionality, RingCentral simplifies business communication for modern, flexible business environments.                                                                                                                 RingCentral offers businesses the type of world-class phone functionality that, until recently, was available only to large enterprises. RingCentral capabilities include auto-receptionist, flexible extension structure, multiple voicemail boxes, smart call routing, business answering rules, extension dialing, call transfers, and elegant integration with Smartphones. With RingCentral, businesses are able to connect all employees as if they were in the same office, improve communications with customers, and boost productivity. RingCentral provides all the telecommunication capabilities that today's businesses demand, while completely eliminating the need for expensive on-premise phone systems",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 60868,
                TwitterName = "RingCentral",
                FacebookName = "RingCentral",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region RINGCENTRAL HOSTED PLUS
            ca = new CloudApplication()
            {
                Brand = "RingCentral",
                ServiceName = "Hosted Plus",
                CompanyURL = "www.ringcentral.co.uk",
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.99M,
                CallsPackageCostPerMonth = 14.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("RingCentral"),
                Description = "RingCentral provides cloud computing based business phone systems designed for today's mobile and distributed business world. The RingCentral technology platform eliminates the need for expensive and technically complex on-premise legacy phone systems. By combining a hosted, multi-extension business phone system with advanced voice and fax functionality, RingCentral simplifies business communication for modern, flexible business environments.                                                                                                                 RingCentral offers businesses the type of world-class phone functionality that, until recently, was available only to large enterprises. RingCentral capabilities include auto-receptionist, flexible extension structure, multiple voicemail boxes, smart call routing, business answering rules, extension dialing, call transfers, and elegant integration with Smartphones. With RingCentral, businesses are able to connect all employees as if they were in the same office, improve communications with customers, and boost productivity. RingCentral provides all the telecommunication capabilities that today's businesses demand, while completely eliminating the need for expensive on-premise phone systems",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 60868,
                TwitterName = "RingCentral",
                FacebookName = "RingCentral",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region RINGCENTRAL HOSTED POWER
            ca = new CloudApplication()
            {
                Brand = "RingCentral",
                ServiceName = "Hosted Power",
                CompanyURL = "www.ringcentral.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 24.99M,
                CallsPackageCostPerMonth = 14.99M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("RingCentral"),
                Description = "RingCentral provides cloud computing based business phone systems designed for today's mobile and distributed business world. The RingCentral technology platform eliminates the need for expensive and technically complex on-premise legacy phone systems. By combining a hosted, multi-extension business phone system with advanced voice and fax functionality, RingCentral simplifies business communication for modern, flexible business environments.                                                                                                                 RingCentral offers businesses the type of world-class phone functionality that, until recently, was available only to large enterprises. RingCentral capabilities include auto-receptionist, flexible extension structure, multiple voicemail boxes, smart call routing, business answering rules, extension dialing, call transfers, and elegant integration with Smartphones. With RingCentral, businesses are able to connect all employees as if they were in the same office, improve communications with customers, and boost productivity. RingCentral provides all the telecommunication capabilities that today's businesses demand, while completely eliminating the need for expensive on-premise phone systems",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 60868,
                TwitterName = "RingCentral",
                FacebookName = "RingCentral",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BT STANDARD BROADBAND VOICE
            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Standard Broadband Voice",
                CompanyURL = "www.bt.com",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 5.00M,
                CallsPackageCostPerMonth = 12.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("75"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("BT"),
                Description = "Make and receive business calls over your BT Business Broadband. Key benefits include 500 inclusive UK minutes as standard every month, free calls to other users of our business VoIP service and a standard local Geographical number. BT Business offers communications and IT solutions, whatever the size of your business. Business broadband, phone lines, phone systems, networking, web hosting, email and mobile services are just a few of our integrated business solutions, each tailored to your organisational needs",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1181,
                TwitterName = "BT",
                FacebookName = "BT",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BT BROADBAND VOICE CALLS PACKAGE
            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Broadband Voice Calls PAckage",
                CompanyURL = "www.bt.com",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 17.50M,
                //CallsPackageCostPerMonth = 12.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("75"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("BT"),
                Description = "Make and receive business calls over your BT Business Broadband. Key benefits include 500 inclusive UK minutes as standard every month, free calls to other users of our business VoIP service and a standard local Geographical number. BT Business offers communications and IT solutions, whatever the size of your business. Business broadband, phone lines, phone systems, networking, web hosting, email and mobile services are just a few of our integrated business solutions, each tailored to your organisational needs",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1181,
                TwitterName = "BT",
                FacebookName = "BT",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region TPAD
            ca = new CloudApplication()
            {
                Brand = "Tpad",
                ServiceName = "4 User",
                CompanyURL = "www.tpad.com",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    //repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.95M,
                //CallsPackageCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                SetupFee = repository.FindSetupFeeByName("29"),
                MinimumContract = repository.FindMinimumContractByName("36"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Tpad"),
                Description = "Tpad are experts in delivering communication and IT solutions, regardless of the size of your business.                                                    Tpad has built its business on supplying phone systems, phone lines, call plans, SIP trunking, dialler systems, broadband for business, high speed fibre optic connection, email and web hosting. We are specialists at integrating them into your existing infrastructure and tailoring them to your business needs.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 261652,
                TwitterName = "Tpad",
                FacebookName = "Tpad",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE UK MOBILE & LANDLINES
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "UK Mobile & Landlines",
                CompanyURL = "www.yourchoicevoip.com",
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
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 15.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE UNLIMITED PACKAGE
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "UK Mobile & Landlines",
                CompanyURL = "www.yourchoicevoip.com",
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 9.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE INTERNATIONAL SAVER
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "International Saver",
                CompanyURL = "www.yourchoicevoip.com",
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE ASIAN SAVER
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "Asian Saver",
                CompanyURL = "www.yourchoicevoip.com",
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 11.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE HOSTED VOIP 2 USER
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "Hosted VoIP 2 User",
                CompanyURL = "www.yourchoicevoip.com",
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 19.98M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE HOSTED VOIP 5 USER
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "Hosted VoIP 5 User",
                CompanyURL = "www.yourchoicevoip.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 49.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE HOSTED VOIP 10 USER
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "Hosted VoIP 10 User",
                CompanyURL = "www.yourchoicevoip.com",
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
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 99.90M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = "At Your Choice VoIP we are extremely passionate about Communication with a dedicated professionally experienced team that has in excess of 40 years of experience within the Telecommunications industry.                                                                                         We have been part of the evolution of this industry such to the extent we are at the pioneering forefront of the latest VoIP Communications wave.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "yourCHOICE",
                FacebookName = "yourCHOICE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region FREESPEECH.CO.UK PAY AS YOU USE
            ca = new CloudApplication()
            {
                Brand = "freespeech.co.uk",
                ServiceName = "Pay As You Use",
                CompanyURL = "www.freespeech.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("freespeech.co.uk"),
                Description = "Freespeech.co.uk - The UK's low cost VOIP service provider - free broadband phone calls and the cheapest rates to international destinations. No line rental",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "freespeech.co.uk",
                FacebookName = "freespeech.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region FREESPEECH.CO.UK SMALL UNLIMITED
            ca = new CloudApplication()
            {
                Brand = "freespeech.co.uk",
                ServiceName = "Small Unlimited",
                CompanyURL = "www.freespeech.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 15.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("20"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("freespeech.co.uk"),
                Description = "Freespeech.co.uk - The UK's low cost VOIP service provider - free broadband phone calls and the cheapest rates to international destinations. No line rental",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "freespeech.co.uk",
                FacebookName = "freespeech.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region FREESPEECH.CO.UK PBX CONNECT
            ca = new CloudApplication()
            {
                Brand = "freespeech.co.uk",
                ServiceName = "PBX Connect",
                CompanyURL = "www.freespeech.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 15.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("20"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("freespeech.co.uk"),
                Description = "Freespeech.co.uk - The UK's low cost VOIP service provider - free broadband phone calls and the cheapest rates to international destinations. No line rental",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "freespeech.co.uk",
                FacebookName = "freespeech.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MAGICJACK
            ca = new CloudApplication()
            {
                Brand = "magicJack",
                ServiceName = "MagicTalk",
                CompanyURL = "www.magicjack.com",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    //repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    //repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    //repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NO"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                //    //repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PAYPAL"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("magicJack"),
                Description = "Use our Phone Service for free, make all the free calls you please. 100% Risk FREE - you pay nothing.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2082854,
                TwitterName = "magicJack",
                FacebookName = "magicJack",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PRESS1.CO.UK 0844 SWITCHBOARD
            ca = new CloudApplication()
            {
                Brand = "Press1.co.uk",
                ServiceName = "0844 Switchboard",
                CompanyURL = "www.press1.co.uk",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("24.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Press1.co.uk"),
                Description = "UK businesses loose thousands of pounds every year because of busy or unanswered calls. Because our switching platform handles your call, your callers will never get busy tone again! Press 1 provides a virtual telephone switchboard with a simple online IVR system. Virtual UKnumbers available include 0844, 0870, 0845 or local geographic numbers. The optional Recordings Manager allows you to store and manage the messages you can use for playback to callers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "@press1uk",
                FacebookName = "Press1.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PRESS1.CO.UK 0845 SWITCHBOARD
            ca = new CloudApplication()
            {
                Brand = "Press1.co.uk",
                ServiceName = "0845 Switchboard",
                CompanyURL = "www.press1.co.uk",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("24.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Press1.co.uk"),
                Description = "UK businesses loose thousands of pounds every year because of busy or unanswered calls. Because our switching platform handles your call, your callers will never get busy tone again! Press 1 provides a virtual telephone switchboard with a simple online IVR system. Virtual UKnumbers available include 0844, 0870, 0845 or local geographic numbers. The optional Recordings Manager allows you to store and manage the messages you can use for playback to callers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "@press1uk",
                FacebookName = "Press1.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PRESS1.CO.UK 0870 SWITCHBOARD
            ca = new CloudApplication()
            {
                Brand = "Press1.co.uk",
                ServiceName = "0870 Switchboard",
                CompanyURL = "www.press1.co.uk",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("24.99"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("Press1.co.uk"),
                Description = "UK businesses loose thousands of pounds every year because of busy or unanswered calls. Because our switching platform handles your call, your callers will never get busy tone again! Press 1 provides a virtual telephone switchboard with a simple online IVR system. Virtual UKnumbers available include 0844, 0870, 0845 or local geographic numbers. The optional Recordings Manager allows you to store and manage the messages you can use for playback to callers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 562876,
                TwitterName = "@press1uk",
                FacebookName = "Press1.co.uk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO SINGLE USER VOIP
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "Single User VoIP",
                CompanyURL = "www.usomo.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 2.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = "Usomo is a Voice over IP provider, offering a quality business-grade VoIP platform. A company with innovation at its heart, the Usomo platform is constantly evolving and offers a range of features as standard. With numbers starting at just £2.99 per month, Usomo offers a real alternative to traditional telephony methods. Usomo offers a stable platform for any business looking to use VoIP. With self-healing technology and data centres across the country and abroad, Usomo offers a secure platform from which you run your business telecom solutions. Usomo have a knowledgeable UK-based technical support team at hand to answer customer queries. Usomo are committed to maintaining high levels of customer service; the team are there to advise rather than sell.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1507332,
                TwitterName = "usomo",
                FacebookName = "usomo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO MULTI USER
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "Multi User VoIP",
                CompanyURL = "www.usomo.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 2.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = "Usomo is a Voice over IP provider, offering a quality business-grade VoIP platform. A company with innovation at its heart, the Usomo platform is constantly evolving and offers a range of features as standard. With numbers starting at just £2.99 per month, Usomo offers a real alternative to traditional telephony methods. Usomo offers a stable platform for any business looking to use VoIP. With self-healing technology and data centres across the country and abroad, Usomo offers a secure platform from which you run your business telecom solutions. Usomo have a knowledgeable UK-based technical support team at hand to answer customer queries. Usomo are committed to maintaining high levels of customer service; the team are there to advise rather than sell.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1507332,
                TwitterName = "usomo",
                FacebookName = "usomo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO SINGLE USER MOBILE
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "Single User Mobile",
                CompanyURL = "www.usomo.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = "Usomo is a Voice over IP provider, offering a quality business-grade VoIP platform. A company with innovation at its heart, the Usomo platform is constantly evolving and offers a range of features as standard. With numbers starting at just £2.99 per month, Usomo offers a real alternative to traditional telephony methods. Usomo offers a stable platform for any business looking to use VoIP. With self-healing technology and data centres across the country and abroad, Usomo offers a secure platform from which you run your business telecom solutions. Usomo have a knowledgeable UK-based technical support team at hand to answer customer queries. Usomo are committed to maintaining high levels of customer service; the team are there to advise rather than sell.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1507332,
                TwitterName = "usomo",
                FacebookName = "usomo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO 5 PLUS MOBILE
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "5 Plus Mobile",
                CompanyURL = "www.usomo.co.uk",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = "Usomo is a Voice over IP provider, offering a quality business-grade VoIP platform. A company with innovation at its heart, the Usomo platform is constantly evolving and offers a range of features as standard. With numbers starting at just £2.99 per month, Usomo offers a real alternative to traditional telephony methods. Usomo offers a stable platform for any business looking to use VoIP. With self-healing technology and data centres across the country and abroad, Usomo offers a secure platform from which you run your business telecom solutions. Usomo have a knowledgeable UK-based technical support team at hand to answer customer queries. Usomo are committed to maintaining high levels of customer service; the team are there to advise rather than sell.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1507332,
                TwitterName = "usomo",
                FacebookName = "usomo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO 10 PLUS MOBILE
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "10 Plus Mobile",
                CompanyURL = "www.usomo.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 4.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = "Usomo is a Voice over IP provider, offering a quality business-grade VoIP platform. A company with innovation at its heart, the Usomo platform is constantly evolving and offers a range of features as standard. With numbers starting at just £2.99 per month, Usomo offers a real alternative to traditional telephony methods. Usomo offers a stable platform for any business looking to use VoIP. With self-healing technology and data centres across the country and abroad, Usomo offers a secure platform from which you run your business telecom solutions. Usomo have a knowledgeable UK-based technical support team at hand to answer customer queries. Usomo are committed to maintaining high levels of customer service; the team are there to advise rather than sell.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1507332,
                TwitterName = "usomo",
                FacebookName = "usomo",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region COLT
            ca = new CloudApplication()
            {
                Brand = "colt",
                ServiceName = "Business VoIP",
                CompanyURL = "www.colt.net",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 5.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("colt"),
                Description = "At Colt we offer voice services you can rely on and that suit your business perfectly. We work with you to create a complete offering that gives you total peace of mind, and great value for money. It's Telephony the way you want it to be.                                                                                                                                    First and foremost, it's our relationship with you that matters. Our sales team helps you choose the product that suits your needs, and then ensures that it's delivered on time and on budget.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2712,
                TwitterName = "colt",
                FacebookName = "colt",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPFONE
            ca = new CloudApplication()
            {
                Brand = "Voipfone",
                ServiceName = "Virtual Switchboard",
                CompanyURL = "www.voipfone.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("6"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("voipfone"),
                Description = "At Colt we offer voice services you can rely on and that suit your business perfectly. We work with you to create a complete offering that gives you total peace of mind, and great value for money. It's Telephony the way you want it to be.                                                                                                                                    First and foremost, it's our relationship with you that matters. Our sales team helps you choose the product that suits your needs, and then ensures that it's delivered on time and on budget.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "voipfone",
                FacebookName = "voipfone",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUREVOIP SINGLE USER
            ca = new CloudApplication()
            {
                Brand = "sureVoIP",
                ServiceName = "SureVoIP Single User",
                CompanyURL = "www.sureVoIP.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 5.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("25"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sureVoIP"),
                Description = "VoIP is no longer a new technology. It's not difficult, but the benefits are huge. All you need are IP phones and an internet connection. We do the rest.                          Whether you have existing equipment or nothing, SureVoIP can help your business take advantage of the operational and cost benefits of using internet based telephone services.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1139344,
                TwitterName = "sureVoIP",
                FacebookName = "sureVoIP",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUREVOIP HOSTED
            ca = new CloudApplication()
            {
                Brand = "sureVoIP",
                ServiceName = "SureVoIP Hosted",
                CompanyURL = "www.sureVoIP.co.uk",
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
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 25.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("35"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sureVoIP"),
                Description = "VoIP is no longer a new technology. It's not difficult, but the benefits are huge. All you need are IP phones and an internet connection. We do the rest.                          Whether you have existing equipment or nothing, SureVoIP can help your business take advantage of the operational and cost benefits of using internet based telephone services.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1139344,
                TwitterName = "sureVoIP",
                FacebookName = "sureVoIP",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region NTA:LTD
            ca = new CloudApplication()
            {
                Brand = "NTA:LTD",
                ServiceName = "Business VoIP",
                CompanyURL = "www.ntaltd.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 7.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("NTA:LTD"),
                Description = "With NTA you are always in control of your business numbers. We have over 4 million hosted VoIP numbers to choose from or you can simply port your existing numbers from your current provider to our network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "@ntaltd",
                FacebookName = "NTA-Ltd",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;

            
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE BASIC
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Basic",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Sipgate Basic is a free Internet telephone service provider. Real phone numbers across the country, call to and from every telephone in the world and no need for the PC, just use your normal phone. Lift the handset, dial, make your calls - with VoIP hardware from sipgate. Make calls with excellent sound quality. Easy setup, easy to use - just like a regular phone service!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 3
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 3",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 5
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 5",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 22.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 10
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 10",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 39.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 25
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 25",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 79.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 50
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 50",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(26),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 129.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE TEAM 100
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 100",
                CompanyURL = "www.live.sipgate.co.uk",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 149.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = "Move your Phone System to the Web. Sipgate Team offers a complete web-based solution for your telephony, fax, SMS and voicemail. A large range of innovative features and adaptable team elements will make communication a lot more efficient. As a small business, you need a hosted VoIP PBX that you can depend on. sipgate makes your communication run smoothly. It is safe, secure and reliable.You can choose as many phone numbers as you want and you can easily add more numbers at any time. All of the above plans come with one free phone number included. Sign up now for a sipgate team trial account and enjoy 30 days of using 3 free UK phone numbers and full access to all of our options and features without a monthly fee or binding contract.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "sipgate",
                FacebookName = "sipgate",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region TIMICO
            ca = new CloudApplication()
            {
                Brand = "timico",
                ServiceName = "VoIP for Business",
                CompanyURL = "www.timico.co.uk/business/telephony/voip",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("GROUP VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO-RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonthFrom = 7.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                Vendor = repository.FindVendorByName("timico"),
                Description = "Timico is an independent communications service provider specialising in voice and data connectivity solutions for UK businesses. Voice over Internet Protocol (VoIP) enables businesses to optimise their telephony systems and realise cost savings by using the internet instead of traditional telephone networks to carry their voice calls. VoIP for Business is suitable for companies of any size, from start-ups to those with multiple sites and homeworkers, Timico’s hosted VoIP for Business service provides secure, reliable voice connectivity combined with a range of multimedia features. Use the Personal Agent to view, manage and configure your VoIP service to suit your personal preferences, depending on where you’re working at the time. The Personal Agent gives you full control over where and when your calls are delivered, 24 hours a day.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "timico",
                FacebookName = "timico",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("USE EXISTING HANDSET")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE UK LANDLINE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE MOBILE CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INCLUSIVE INTERNATIONAL CALLS")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("DIAL-BY-NAME DIRECTORY")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PC REQUIRED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MUSIC-ON-HOLD")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("AUTO-RECEPTION/CALL HANDLING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("ANSWERING RULES")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CALL CENTRE/INTERACTIVE VOICE RESPONSE")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("VIRTUAL LANDLINE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("LOCAL DIALLING CODE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;


            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("FREEPHONE/LOCAL RATE NUMBER")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("HARDWARE SUPPLIED")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished PHONE");
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
            //ca.CloudApplicationApplications.ForEach(x => x.CloudApplicationApplicationStatus = repository.FindStatusByName("LIVE"));
            //return retVal;
        }
        #endregion

    }
}
