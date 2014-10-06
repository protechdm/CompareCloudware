using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class WebConferencingProductionData
    {

        public static bool PumpWebConferencingData(QueryRepository repository)
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

            #region APPLICATIONS

            #region WEB CONFERENCING

            #region CISCO WEBEX BASIC FREE
            ca = new CloudApplication()
            {
                Brand = "Cisco webex",
                ServiceName = "Basic Free",
                CompanyURL = "www.webex.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 3000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
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
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Cisco webex"),
                Description = "Collaborate with colleagues across your organisation or halfway across the planet. Meet online and share files, information and expertise. WebEx solutions increase productivity and keep you connected.WebEx products are delivered through the Cisco WebEx cloud. Count on the highest levels of performance and security from this scalable network. Options like password protection offer extra reassurance that your collaborative spaces are safe.Collaborate from wherever you are with WebEx mobile apps for IPhone, iPad, Android or BlackBerry. If you can get online, you can work together.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 3805,
                TwitterName = "@WebEx",
                FacebookName = "webex",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 3;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CISCO WEBEX PREMIUM 8
            ca = new CloudApplication()
            {
                Brand = "Cisco webex",
                ServiceName = "Premium 8",
                CompanyURL = "www.webex.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(8),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 3000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Cisco webex"),
                Description = "Collaborate with colleagues across your organisation or halfway across the planet. Meet online and share files, information and expertise. WebEx solutions increase productivity and keep you connected.WebEx products are delivered through the Cisco WebEx cloud. Count on the highest levels of performance and security from this scalable network. Options like password protection offer extra reassurance that your collaborative spaces are safe.Collaborate from wherever you are with WebEx mobile apps for IPhone, iPad, Android or BlackBerry. If you can get online, you can work together.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 3805,
                TwitterName = "@WebEx",
                FacebookName = "webex",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 8;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CISCO WEBEX PREMIUM 25
            ca = new CloudApplication()
            {
                Brand = "Cisco webex",
                ServiceName = "Premium 25",
                CompanyURL = "www.webex.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 3000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 30.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Cisco webex"),
                Description = "Collaborate with colleagues across your organisation or halfway across the planet. Meet online and share files, information and expertise. WebEx solutions increase productivity and keep you connected.WebEx products are delivered through the Cisco WebEx cloud. Count on the highest levels of performance and security from this scalable network. Options like password protection offer extra reassurance that your collaborative spaces are safe.Collaborate from wherever you are with WebEx mobile apps for IPhone, iPad, Android or BlackBerry. If you can get online, you can work together.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 3805,
                TwitterName = "@WebEx",
                FacebookName = "webex",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CISCO WEBEX ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Cisco webex",
                ServiceName = "Enterprise",
                CompanyURL = "www.webex.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 3000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Cisco webex"),
                Description = "Collaborate with colleagues across your organisation or halfway across the planet. Meet online and share files, information and expertise. WebEx solutions increase productivity and keep you connected.WebEx products are delivered through the Cisco WebEx cloud. Count on the highest levels of performance and security from this scalable network. Options like password protection offer extra reassurance that your collaborative spaces are safe.Collaborate from wherever you are with WebEx mobile apps for IPhone, iPad, Android or BlackBerry. If you can get online, you can work together.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 3805,
                TwitterName = "@WebEx",
                FacebookName = "webex",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GOTOMEETING GOTOMEETING
            ca = new CloudApplication()
            {
                Brand = "GoToMeeting",
                ServiceName = "GoToMeeting",
                CompanyURL = "www.gotomeeting.co.uk",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnum = 276.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 276M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("GoToMeeting"),
                Description = "Easy-to-use GoToMeeting features make online collaboration a breeze. Experience true collaboration. Simple to use. High-quality video conferencing and meeting tools.Work face to face with high-definition video conferencing.Record your meeting sessions – including all phone and microphone audio.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "GoToMeeting",
                FacebookName = "GoToMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GOTOMEETING GOTOWEBINAR
            ca = new CloudApplication()
            {
                Brand = "GoToMeeting",
                ServiceName = "GoToWebinar",
                CompanyURL = "www.gotomeeting.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnum = 566.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 566M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("GoToMeeting"),
                Description = "GoToWebinar's easy-to-use features simplify your Internet conference experience.Schedule your webinar using a brief online form and GoToWebinar will create a hosted registration page and invitation email for you to send, which you can brand with your own logo and image. Practice in advance to make sure everything goes as planned. Attendees click a link in your invitation and then fill out your custom registration form. Then, joining your webinar is as simple as clicking a link in their confirmation or reminder email or on their Outlook calendar entry.Once you start your webinar, it's easy to share your presentation slides or your entire desktop. The pen, highlighter, spotlight and arrow tools help you interact with attendees. And you can record your webinar – including all phone and computer audio – for future review and reuse.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "GoToMeeting",
                FacebookName = "GoToMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GOTOMEETING GOTOTRAINING
            ca = new CloudApplication()
            {
                Brand = "GoToMeeting",
                ServiceName = "GoToTraining",
                CompanyURL = "www.gotomeeting.co.uk",
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 89.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnum = 854.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 854M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("GoToMeeting"),
                Description = "Our online training software gives you all the tools you need for a successful experience. Enter a title, description, date and times and GoToTraining will create a hosted registration page and invitation email for you to send. Or, post session details to an online course catalogue. You can also set up tests, polls and class evaluations and upload materials for your attendees. Organisations with multiple trainers can easily manage and monitor their GoToTraining usage. Plus, your company's trainers can share training materials, tests, surveys and recordings with each other.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "GoToMeeting",
                FacebookName = "GoToMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT LYNC ONLINE PLAN 1
            ca = new CloudApplication()
            {
                Brand = "Microsoft Lync Online",
                ServiceName = "Plan 1",
                CompanyURL = "www.lync.microsoft.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 250,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    //repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    //repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    //repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 1.30M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Microsoft Lync Online"),
                Description = "Microsoft® Lync™ ushers in a new connected user experience transforming every communication into an interaction that is more collaborative, engaging, and accessible from anywhere. For IT, the benefits are equally powerful, with a highly secure and reliable system that works with existing tools and systems for easier management, lower cost of ownership, smoother deployment and migration, and greater choice and flexibility.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = "@msftLync",
                FacebookName = "msftLYNC",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 250;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT LYNC ONLINE PLAN 2
            ca = new CloudApplication()
            {
                Brand = "Microsoft Lync Online",
                ServiceName = "Plan 2",
                CompanyURL = "www.lync.microsoft.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 250,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    //repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 3.60M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Microsoft Lync Online"),
                Description = "Microsoft® Lync™ ushers in a new connected user experience transforming every communication into an interaction that is more collaborative, engaging, and accessible from anywhere. For IT, the benefits are equally powerful, with a highly secure and reliable system that works with existing tools and systems for easier management, lower cost of ownership, smoother deployment and migration, and greater choice and flexibility.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = "@msftLync",
                FacebookName = "msftLYNC",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT LYNC ONLINE PLAN 3
            ca = new CloudApplication()
            {
                Brand = "Microsoft Lync Online",
                ServiceName = "Plan 3",
                CompanyURL = "www.lync.microsoft.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 250,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    //repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 6.20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Microsoft Lync Online"),
                Description = "Microsoft® Lync™ ushers in a new connected user experience transforming every communication into an interaction that is more collaborative, engaging, and accessible from anywhere. For IT, the benefits are equally powerful, with a highly secure and reliable system that works with existing tools and systems for easier management, lower cost of ownership, smoother deployment and migration, and greater choice and flexibility.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1035,
                TwitterName = "@msftLync",
                FacebookName = "msftLYNC",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IBM SMARTCLOUD MEETINGS
            ca = new CloudApplication()
            {
                Brand = "IBM Cloud",
                ServiceName = "IBM Smartcloud Meetings",
                CompanyURL = "www.lotuslive.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 3.46M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("LotusLive"),
                Description = "LotusLive (www.lotuslive.com) is a portfolio of online services, hosted by IBM, that delivers scalable, security-rich email, Web conferencing and collaboration solutions. LotusLive is delivered through the SaaS model. LotusLive services provide users with new ways to work more effectively with people inside and outside their company, including customers, partners and suppliers, at a very predictable monthly rate.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1009,
                TwitterName = "@IBM",
                FacebookName = "LotusLive",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 200;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 200;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region IBM SMARTCLOUD EVENTS
            ca = new CloudApplication()
            {
                Brand = "IBM Cloud",
                ServiceName = "IBM Smartcloud Events",
                CompanyURL = "www.lotuslive.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("LotusLive"),
                Description = "LotusLive (www.lotuslive.com) is a portfolio of online services, hosted by IBM, that delivers scalable, security-rich email, Web conferencing and collaboration solutions. LotusLive is delivered through the SaaS model. LotusLive services provide users with new ways to work more effectively with people inside and outside their company, including customers, partners and suppliers, at a very predictable monthly rate.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1009,
                TwitterName = "@IBM",
                FacebookName = "LotusLive",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKMEETING START
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickMeeting Start",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 8.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 5;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKMEETING PLUS
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickMeeting Plus",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKWEBINAR START
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickWebinar Start",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 32.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKWEBINAR PLUS
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickWebinar Plus",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 64.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 100;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKWEBINAR PRO
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickWebinar Plus",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 130.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 500;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLICKMEETING CLICKWEBINAR EXPERT
            ca = new CloudApplication()
            {
                Brand = "ClickMeeting",
                ServiceName = "ClickWebinar Expert",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 230.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ClickMeeting"),
                Description = "",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1514856,
                TwitterName = "ClickMeeting",
                FacebookName = "ClickMeeting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LOTUSLIVE
            //ca = new CloudApplication()
            //{
            //    Brand = "LotusLive",
            //    ServiceName = "Meetings Unlimited",
            //    CompanyURL = "www.lotuslive.com",
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
            //        repository.FindSupportTypeByName("ONLINE"),
            //        repository.FindSupportTypeByName("COMMUNITY")
            //    },
            //    SupportHours = repository.FindSupportHoursByName("24 HOURS"),
            //    SupportDays = repository.FindSupportDaysByName("7"),
            //    SupportTerritories = new List<SupportTerritory>()
            //    {
            //        repository.FindSupportTerritoryByName("UK"),
            //    },
            //    VideoTrainingSupport = true,
            //    MaximumMeetingAttendees = 15,
            //    MaximumWebinarAttendees = 1000,
            //    CloudApplicationFeatures = new List<CloudApplicationFeature>()
            //    {
            //        repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
            //        repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
            //        repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
            //        repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
            //        repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
            //        //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
            //        repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
            //        repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
            //        //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
            //        repository.FindFeatureByName("FULL DESKTOP SHARING"),
            //        repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
            //        repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
            //        repository.FindFeatureByName("PRIVATE CHAT MODE"),
            //        repository.FindFeatureByName("SSL SECURITY"),
            //        //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
            //        //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
            //        //repository.FindFeatureByName("INACTIVITY TIME OUT"),
            //        repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
            //        repository.FindFeatureByName("FREE VOIP CALLING"),
            //        //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
            //    },
            //    ApplicationCostPerMonth = 39.00M,
            //    CallsPackageCostPerMonth = 0M,
            //    SetupFee = repository.FindSetupFeeByName("N/A"),
            //    MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
            //    PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
            //    PaymentOptions = new List<PaymentOption>()
            //    {
            //        repository.FindPaymentOptionByName("CREDIT CARD"),
            //        repository.FindPaymentOptionByName("PRE-PAY"),
            //    },
            //    FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
            //    Category = repository.FindCategoryByName("WEB CONFERENCING"),
            //    Vendor = repository.FindVendorByName("LotusLive"),
            //    Description = "LotusLive (www.lotuslive.com) is a portfolio of online services, hosted by IBM, that delivers scalable, security-rich email, Web conferencing and collaboration solutions. LotusLive is delivered through the SaaS model. LotusLive services provide users with new ways to work more effectively with people inside and outside their company, including customers, partners and suppliers, at a very predictable monthly rate.",
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

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            //repository.AddCloudApplication(ca);

            #endregion

            #region OMNIJOIN OMNIJOIN 30
            ca = new CloudApplication()
            {
                Brand = "OmniJoin",
                ServiceName = "OmniJoin 30",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("OmniJoin"),
                Description = "BOARDROOM QUALITY WEB AND VIDEO CONFERENCING... MADE EASY. HD Video. Crystal-clear audio. Superior Collaboration. OmniJoin™ web and video conferencing provides the meeting experience that businesses truly need — boardroom-quality, multi-party video, combined with smoothly synched audio. See your colleagues clearly, share and mark up files easily, and play video files virtually instantly, all with surprisingly simple desktop controls.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 4533375,
                TwitterName = "OmniJoin",
                FacebookName = "OmniJoinUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 30;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OMNIJOIN OMNIJOIN 50
            ca = new CloudApplication()
            {
                Brand = "OmniJoin",
                ServiceName = "OmniJoin 50",
                CompanyURL = "www.clickmeeting.com",
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 15,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("OmniJoin"),
                Description = "BOARDROOM QUALITY WEB AND VIDEO CONFERENCING... MADE EASY. HD Video. Crystal-clear audio. Superior Collaboration. OmniJoin™ web and video conferencing provides the meeting experience that businesses truly need — boardroom-quality, multi-party video, combined with smoothly synched audio. See your colleagues clearly, share and mark up files easily, and play video files virtually instantly, all with surprisingly simple desktop controls.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 4533375,
                TwitterName = "OmniJoin",
                FacebookName = "OmniJoinUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 30;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INFINITE WEB CONFERENCING
            ca = new CloudApplication()
            {
                Brand = "Infinite",
                ServiceName = "Web Conferencing",
                CompanyURL = "www.infinite conferencing.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 1000,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    //repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Infinite"),
                Description = "At Infinite Conferencing, we offer the industry’s most comprehensive suite of scalable, secure, feature-rich and customizable online meetings for all of your needs. Whether you want to hold a sales call, a product demo, an internal team meeting, a product development discussion or even an executive board meeting, Infinite combines the intimacy and impact of face-to-face meetings with the cost savings, flexibility and convenience of online collaboration. We give you an easy to use audio/video platform you can use to conduct business across the office or across the globe.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 52136,
                TwitterName = "Infinite",
                FacebookName = "infiniteconferencing",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INFINITE WEBINARS
            ca = new CloudApplication()
            {
                Brand = "Infinite",
                ServiceName = "Webinars",
                CompanyURL = "www.infinite conferencing.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 1000,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    //repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 100.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Infinite"),
                Description = "At Infinite Conferencing, we offer the industry’s most comprehensive suite of scalable, secure, feature-rich and customizable online meetings for all of your needs. Whether you want to hold a sales call, a product demo, an internal team meeting, a product development discussion or even an executive board meeting, Infinite combines the intimacy and impact of face-to-face meetings with the cost savings, flexibility and convenience of online collaboration. We give you an easy to use audio/video platform you can use to conduct business across the office or across the globe.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 52136,
                TwitterName = "Infinite",
                FacebookName = "infiniteconferencing",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING BASIC
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Basic",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    //repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    //repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    //repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING PROFESSIONAL 5
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional 5",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 12.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 5;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING PROFESSIONAL 10
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional 10",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 18.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 10;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING PROFESSIONAL 25
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional 25",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING PROFESSIONAL 50
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional 50",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING PROFESSIONAL 100
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional 100",
                CompanyURL = "www.zohomeeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 5,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = "Zoho Meeting empowers you to connect, share desktop, collaborate and share ideas with your remote audience in seconds, sitting at your location. Just you and your customer need a computer and internet connection to meet each other. Whatever it may be, a product demo, team meeting, training or presentations, anything can be done with your remote Participants in a simple and easy way. Now with the integrated audio conferencing, its not just sharing your desktop with someone, it is in-person meeting with your customers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@zohomeeting",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUZE BOX FUZE SHARE
            ca = new CloudApplication()
            {
                Brand = "Fuze Box",
                ServiceName = "Fuze Share",
                CompanyURL = "www.fuzebox.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(15),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("FUZE BOX"),
                Description = "Client presentations, internal and external pitches, medical demonstrations, classes, webinars, video and web conferencing, present yourself and your work in unparalleled HD quality and blow clients and colleagues away simultaneously. Fuze Meeting allows you to interact face-to-face with anyone on any device, from anywhere in the world",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 449328,
                TwitterName = "@fuzebox",
                FacebookName = "fuzeboxinc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUZE BOX FUZE PRO
            ca = new CloudApplication()
            {
                Brand = "Fuze Box",
                ServiceName = "Fuze Pro",
                CompanyURL = "www.fuzebox.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(25),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("FUZE BOX"),
                Description = "Client presentations, internal and external pitches, medical demonstrations, classes, webinars, video and web conferencing, present yourself and your work in unparalleled HD quality and blow clients and colleagues away simultaneously. Fuze Meeting allows you to interact face-to-face with anyone on any device, from anywhere in the world",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 449328,
                TwitterName = "@fuzebox",
                FacebookName = "fuzeboxinc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 25;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUZE BOX FUZE BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Fuze Box",
                ServiceName = "Fuze Business",
                CompanyURL = "www.fuzebox.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 69.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("FUZE BOX"),
                Description = "Client presentations, internal and external pitches, medical demonstrations, classes, webinars, video and web conferencing, present yourself and your work in unparalleled HD quality and blow clients and colleagues away simultaneously. Fuze Meeting allows you to interact face-to-face with anyone on any device, from anywhere in the world",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 449328,
                TwitterName = "@fuzebox",
                FacebookName = "fuzeboxinc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FUZE BOX FUZE ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Fuze Box",
                ServiceName = "Fuze Enterprise",
                CompanyURL = "www.fuzebox.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 25,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("FUZE BOX"),
                Description = "Client presentations, internal and external pitches, medical demonstrations, classes, webinars, video and web conferencing, present yourself and your work in unparalleled HD quality and blow clients and colleagues away simultaneously. Fuze Meeting allows you to interact face-to-face with anyone on any device, from anywhere in the world",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 449328,
                TwitterName = "@fuzebox",
                FacebookName = "fuzeboxinc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P2
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P2",
                CompanyURL = "www.yugma.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 24.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = "Yugma is the leader in affordable instant web conferencing solutions. Yugma provides Free, Professional, and Enterprise web conferencing software-as-a-service (SaaS) solutions to individuals, small businesses, and large enterprises across a diverse range of industries.                                                                     The core Yugma product technology is a secure, easy-to-use, feature-rich, web conferencing and collaboration software service that allows users to host or attend online meetings using Windows, Mac, or Linux computers at a fraction of the cost of comparable technologies. Yugma technology is scalable from 1 to 1 desktop sharing to conferences for 1000+ attendees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 66317,
                TwitterName = "Yugma",
                FacebookName = "Yugma",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 2;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P20
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P20",
                CompanyURL = "www.yugma.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 99.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = "Yugma is the leader in affordable instant web conferencing solutions. Yugma provides Free, Professional, and Enterprise web conferencing software-as-a-service (SaaS) solutions to individuals, small businesses, and large enterprises across a diverse range of industries.                                                                     The core Yugma product technology is a secure, easy-to-use, feature-rich, web conferencing and collaboration software service that allows users to host or attend online meetings using Windows, Mac, or Linux computers at a fraction of the cost of comparable technologies. Yugma technology is scalable from 1 to 1 desktop sharing to conferences for 1000+ attendees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 66317,
                TwitterName = "Yugma",
                FacebookName = "Yugma",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 20;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P50
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P50",
                CompanyURL = "www.yugma.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 34.95M,
                ApplicationCostPerAnnum = 349.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = "Yugma is the leader in affordable instant web conferencing solutions. Yugma provides Free, Professional, and Enterprise web conferencing software-as-a-service (SaaS) solutions to individuals, small businesses, and large enterprises across a diverse range of industries.                                                                     The core Yugma product technology is a secure, easy-to-use, feature-rich, web conferencing and collaboration software service that allows users to host or attend online meetings using Windows, Mac, or Linux computers at a fraction of the cost of comparable technologies. Yugma technology is scalable from 1 to 1 desktop sharing to conferences for 1000+ attendees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 66317,
                TwitterName = "Yugma",
                FacebookName = "Yugma",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 50;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P100
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P100",
                CompanyURL = "www.yugma.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 79.95M,
                ApplicationCostPerAnnum = 799.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = "Yugma is the leader in affordable instant web conferencing solutions. Yugma provides Free, Professional, and Enterprise web conferencing software-as-a-service (SaaS) solutions to individuals, small businesses, and large enterprises across a diverse range of industries.                                                                     The core Yugma product technology is a secure, easy-to-use, feature-rich, web conferencing and collaboration software service that allows users to host or attend online meetings using Windows, Mac, or Linux computers at a fraction of the cost of comparable technologies. Yugma technology is scalable from 1 to 1 desktop sharing to conferences for 1000+ attendees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 66317,
                TwitterName = "Yugma",
                FacebookName = "Yugma",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 100;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P500
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P500",
                CompanyURL = "www.yugma.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 159.95M,
                ApplicationCostPerAnnum = 1599.50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = "Yugma is the leader in affordable instant web conferencing solutions. Yugma provides Free, Professional, and Enterprise web conferencing software-as-a-service (SaaS) solutions to individuals, small businesses, and large enterprises across a diverse range of industries.                                                                     The core Yugma product technology is a secure, easy-to-use, feature-rich, web conferencing and collaboration software service that allows users to host or attend online meetings using Windows, Mac, or Linux computers at a fraction of the cost of comparable technologies. Yugma technology is scalable from 1 to 1 desktop sharing to conferences for 1000+ attendees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 66317,
                TwitterName = "Yugma",
                FacebookName = "Yugma",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 500;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region POWWOWNOW
            ca = new CloudApplication()
            {
                Brand = "POWWOWNOW",
                ServiceName = "PowWowNow",
                CompanyURL = "www.powwownow.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                PayAsYouGo = true,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("POWWOWNOW"),
                Description = "With Powwownow you only pay the cost of your own 0844 phone call – nothing more! At Powwownow, we don't want our customers doing things the hard way. That's why we offer you immediate conference calls, available 24/7, with as many people as you want speaking at an affordable price - we don't even need to know your name. Here are some of the ways we are different from the competition: Affordable. Only pay the cost of your own phone call - that's it! No contracts and no bills. Simple to use. Don't worry about explaining to people how to use it. The simple 3-stage process makes it all perfectly clear. It saves so much time. Why travel to a meeting when you can do it over the phone? Don't set a meeting for next week. Have a Powwow - now!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "POWWOWNOW",
                FacebookName = "POWWOWNOW",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region POWWOWNOW PLUS
            ca = new CloudApplication()
            {
                Brand = "POWWOWNOW",
                ServiceName = "PowWowNow Plus",
                CompanyURL = "www.powwownow.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                PayAsYouGo = true,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("POWWOWNOW"),
                Description = "With Powwownow you only pay the cost of your own 0844 phone call – nothing more! At Powwownow, we don't want our customers doing things the hard way. That's why we offer you immediate conference calls, available 24/7, with as many people as you want speaking at an affordable price - we don't even need to know your name. Here are some of the ways we are different from the competition: Affordable. Only pay the cost of your own phone call - that's it! No contracts and no bills. Simple to use. Don't worry about explaining to people how to use it. The simple 3-stage process makes it all perfectly clear. It saves so much time. Why travel to a meeting when you can do it over the phone? Don't set a meeting for next week. Have a Powwow - now!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "POWWOWNOW",
                FacebookName = "POWWOWNOW",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region POWWOWNOW PREMIUM
            ca = new CloudApplication()
            {
                Brand = "POWWOWNOW",
                ServiceName = "PowWowNow Premium",
                CompanyURL = "www.powwownow.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                PayAsYouGo = true,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("POWWOWNOW"),
                Description = "With Powwownow you only pay the cost of your own 0844 phone call – nothing more! At Powwownow, we don't want our customers doing things the hard way. That's why we offer you immediate conference calls, available 24/7, with as many people as you want speaking at an affordable price - we don't even need to know your name. Here are some of the ways we are different from the competition: Affordable. Only pay the cost of your own phone call - that's it! No contracts and no bills. Simple to use. Don't worry about explaining to people how to use it. The simple 3-stage process makes it all perfectly clear. It saves so much time. Why travel to a meeting when you can do it over the phone? Don't set a meeting for next week. Have a Powwow - now!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "POWWOWNOW",
                FacebookName = "POWWOWNOW",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 1000;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 1000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MEGAMEETING WEBINAR
            ca = new CloudApplication()
            {
                Brand = "MegaMeeting",
                ServiceName = "Webinar",
                CompanyURL = "www.megameeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonthFrom = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("MegaMeeting"),
                Description = "Experience the Power of Unlimited Web & Video Conferencing Conduct online trainings, seminars or product demonstrations for your clients, colleagues, prospects and employees without the hassle of having them download any software. MegaMeeting provides the flexibility and convenience of hosting first-class Webinars for everyone to see. By offering powerful communication tools with ubiquity across all platforms, MegaMeeting makes Internet-based collaboration easy and affordable. Meet with anyone, anytime, from anywhere! 100% Browser-based - Nothing to download in order to join a meeting. An Internet connection and a web browser is all that's required. Get MORE people into your meetings! Cross Platform and Browser Compatible - MegaMeeting works on all PC/MAC/LINUX machines. MegaMeeting is also compatible with all of the major internet browsers , including Internet Explorer, Firefox, Chrome, Safari and Opera. Video Conferencing with True VoIP Audio - MegaMeeting comes with integrated VoIP audio, allowing meeting participants to speak with one another simply by using a standard headset/microphone. Live High Quality Video Feeds - MegaMeeting provides the highest quality and most flexible video streams of any browser-based system. Multi Language Interface – MegaMeeting offers a Multi Language Interface, allowing guests to choose the language they are most comfortable with.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 145681,
                TwitterName = "MegaMeeting",
                FacebookName = "MegaMeeting-UK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERACTIVE TRAINING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERFACE COMPANY BRANDING")).IsOptional = true;

            //ca.IsScaledPrice = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MEGAMEETING PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "MegaMeeting",
                ServiceName = "Professional",
                CompanyURL = "www.megameeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonthFrom = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("MegaMeeting"),
                Description = "Experience the Power of Unlimited Web & Video Conferencing Conduct online trainings, seminars or product demonstrations for your clients, colleagues, prospects and employees without the hassle of having them download any software. MegaMeeting provides the flexibility and convenience of hosting first-class Webinars for everyone to see. By offering powerful communication tools with ubiquity across all platforms, MegaMeeting makes Internet-based collaboration easy and affordable. Meet with anyone, anytime, from anywhere! 100% Browser-based - Nothing to download in order to join a meeting. An Internet connection and a web browser is all that's required. Get MORE people into your meetings! Cross Platform and Browser Compatible - MegaMeeting works on all PC/MAC/LINUX machines. MegaMeeting is also compatible with all of the major internet browsers , including Internet Explorer, Firefox, Chrome, Safari and Opera. Video Conferencing with True VoIP Audio - MegaMeeting comes with integrated VoIP audio, allowing meeting participants to speak with one another simply by using a standard headset/microphone. Live High Quality Video Feeds - MegaMeeting provides the highest quality and most flexible video streams of any browser-based system. Multi Language Interface – MegaMeeting offers a Multi Language Interface, allowing guests to choose the language they are most comfortable with.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 145681,
                TwitterName = "MegaMeeting",
                FacebookName = "MegaMeeting-UK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERACTIVE TRAINING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERFACE COMPANY BRANDING")).IsOptional = true;

            //ca.IsScaledPrice = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MEGAMEETING ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "MegaMeeting",
                ServiceName = "Enterprise",
                CompanyURL = "www.megameeting.com",
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("MegaMeeting"),
                Description = "Experience the Power of Unlimited Web & Video Conferencing Conduct online trainings, seminars or product demonstrations for your clients, colleagues, prospects and employees without the hassle of having them download any software. MegaMeeting provides the flexibility and convenience of hosting first-class Webinars for everyone to see. By offering powerful communication tools with ubiquity across all platforms, MegaMeeting makes Internet-based collaboration easy and affordable. Meet with anyone, anytime, from anywhere! 100% Browser-based - Nothing to download in order to join a meeting. An Internet connection and a web browser is all that's required. Get MORE people into your meetings! Cross Platform and Browser Compatible - MegaMeeting works on all PC/MAC/LINUX machines. MegaMeeting is also compatible with all of the major internet browsers , including Internet Explorer, Firefox, Chrome, Safari and Opera. Video Conferencing with True VoIP Audio - MegaMeeting comes with integrated VoIP audio, allowing meeting participants to speak with one another simply by using a standard headset/microphone. Live High Quality Video Feeds - MegaMeeting provides the highest quality and most flexible video streams of any browser-based system. Multi Language Interface – MegaMeeting offers a Multi Language Interface, allowing guests to choose the language they are most comfortable with.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 145681,
                TwitterName = "MegaMeeting",
                FacebookName = "MegaMeeting-UK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERACTIVE TRAINING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INTERFACE COMPANY BRANDING")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MEETINGZONE
            ca = new CloudApplication()
            {
                Brand = "meetingzone",
                ServiceName = "Web Conference",
                CompanyURL = "www.meetingzone.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("ONLINE"),
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
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                PayAsYouGo = true,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("meetingzone"),
                Description = "MeetingZone is one of the world’s largest independent conferencing services provider and offers customers high performance, personalised audio and web conferencing services. Whether you require quick and simple screen sharing or the ability to make remote presentations, our web conferencing services are easy to use. MeetingZone’s competitive pricing plans are tailored to your needs. We ensure we provide the most cost effective solution based on your usage patterns and geographic reach. MeetingZone’s core business philosophy is centred around transparent charging so you can see all the details of every transaction. Customers choose us because they know that our clear, clean billing and reporting systems reflect precisely their actual usage. There are no hidden charges, no subscriptions and no fees.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 118575,
                TwitterName = "meetingzone",
                FacebookName = "MeetingZoneUK",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("RECORD & REPLAY SERVICE")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTERCALL PAY AS YOU GO
            ca = new CloudApplication()
            {
                Brand = "InterCall",
                ServiceName = "Pay As You Go",
                CompanyURL = "www.intercall.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                PayAsYouGo = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("InterCall"),
                Description = "Take your conference calls to the next level—share presentations, collaborate on documents and show people exactly what you mean with online meetings from InterCall.Show presentations, manage your audio calls and meet face-to-face with one comprehensive, intuitive solution. InterCall Unified Meeting® makes meetings more productive, so you can get more out of your day. Online Meetings allow you to get more done in your day. InterCall is the worldwide conferencing leader and has been leading conversations for over 20 years. We’ve sold, supported or used almost every online meeting software on the market. InterCall Unified Meeting incorporates all the best features you need for your daily meetings so you can get more done in less time.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5226,
                TwitterName = "InterCall",
                FacebookName = "InterCall",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 20;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTERCALL UNLIMITED 20
            ca = new CloudApplication()
            {
                Brand = "InterCall",
                ServiceName = "Unlimited 20",
                CompanyURL = "www.intercall.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 16384,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    //repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerAnnum = 499.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("InterCall"),
                Description = "Take your conference calls to the next level—share presentations, collaborate on documents and show people exactly what you mean with online meetings from InterCall.Show presentations, manage your audio calls and meet face-to-face with one comprehensive, intuitive solution. InterCall Unified Meeting® makes meetings more productive, so you can get more out of your day. Online Meetings allow you to get more done in your day. InterCall is the worldwide conferencing leader and has been leading conversations for over 20 years. We’ve sold, supported or used almost every online meeting software on the market. InterCall Unified Meeting incorporates all the best features you need for your daily meetings so you can get more done in less time.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 5226,
                TwitterName = "InterCall",
                FacebookName = "InterCall",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 125;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ONSYNC GO 15
            ca = new CloudApplication()
            {
                Brand = "OnSync",
                ServiceName = "On-Sync Go 15",
                CompanyURL = "www.digitalsamba.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 45.00M,
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("OnSync"),
                Description = "OnSync delivers a truly all-in-one web conferencing solution for all your organisation-wide online communication needs.                              Web conferencing usage can vary widely, depending on business necessities, daily fluctuations in application requirements, and even personal preferences. Using OnSync as your communication medium offers you easily accessible solutions to any communication challenge – whenever or wherever they arise.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "OnSync",
                FacebookName = "OnSync",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ONSYNC PRO 50
            ca = new CloudApplication()
            {
                Brand = "OnSync",
                ServiceName = "On-Sync Pro 50",
                CompanyURL = "www.digitalsamba.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 65.00M,
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("OnSync"),
                Description = "OnSync delivers a truly all-in-one web conferencing solution for all your organisation-wide online communication needs.                              Web conferencing usage can vary widely, depending on business necessities, daily fluctuations in application requirements, and even personal preferences. Using OnSync as your communication medium offers you easily accessible solutions to any communication challenge – whenever or wherever they arise.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "OnSync",
                FacebookName = "OnSync",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 50;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ONSYNC HD 100
            ca = new CloudApplication()
            {
                Brand = "OnSync",
                ServiceName = "On-Sync Pro 50",
                CompanyURL = "www.digitalsamba.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    //repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 99.00M,
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
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("OnSync"),
                Description = "OnSync delivers a truly all-in-one web conferencing solution for all your organisation-wide online communication needs.                              Web conferencing usage can vary widely, depending on business necessities, daily fluctuations in application requirements, and even personal preferences. Using OnSync as your communication medium offers you easily accessible solutions to any communication challenge – whenever or wherever they arise.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "OnSync",
                FacebookName = "OnSync",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished WEB CONFERENCING");
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


        #region PumpMikogoLogo
        public static bool PumpMikogoLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "MIKOGO",
                VendorLogoFileName = "Mikogo logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\carbonite logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//New Logos//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\New Logos\\Mikogo logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpMikogo
        public static bool PumpMikogo(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("WEB CONFERENCING").CategoryID;

            #region MIKOGO
            ca = new CloudApplication()
            {
                Brand = "Mikogo",
                ServiceName = "Mikogo",
                CompanyURL = "www.mikogo.com",
                Devices = new List<Device>()
                {
                    repository.FindDeviceByName("MOBILE"),
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
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry")
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
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
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
                    repository.FindFeatureByName("MAXIMUM MEETING ATTENDEES"),
                    repository.FindFeatureByName("MAXIMUM WEBINAR/EVENT ATTENDEES"),
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRPERSON"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTION"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("INTERACTIVE TRAINING"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("CALL ME/TOLL FREE"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                //ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerMonthFrom = 13.00M,
                ApplicationCostPerMonthTo = 78.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumFrom = 156.00M,
                ApplicationCostPerAnnumTo = 936.00M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                Vendor = repository.FindVendorByName("Mikogo"),
                Description = "Successful online collaboration doesn't need to be complicated nor difficult. Mikogo has built an easy-to-use and intuitive solution for online meetings which is lightweight on your computer resources. Fast and secure, Mikogo brings a great range of meeting features to the table. Use Mikogo for your next online meetings and invite anyone from around the world - anything you see on your screen, they see on their screens.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "Mikogo",
                FacebookName = "Mikogo",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
            };

            //InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM MEETING ATTENDEES")).Count = 100;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MAXIMUM WEBINAR/EVENT ATTENDEES")).Count = 3000;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            return retVal;

        }
        #endregion



    }
}
