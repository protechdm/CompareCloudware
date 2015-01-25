using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class SecurityProductionData
    {

        public static bool PumpSecurityData(QueryRepository repository)
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

            #region SECURITY

            #region ESET
            ca = new CloudApplication()
            {
                Brand = "ESET",
                ServiceName = "Endpoint Security",
                CompanyURL = "http://www.eset.co.uk/Business/Endpoint-Security/Endpoint-Security",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("LINUX")
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
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 113.85M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("eset"),
                Description = "ESET Endpoint Security integrates ESET Endpoint Antivirus's robust virus and spyware scanning engine, with a bi-directional firewall to stop hacker attacks. The integrated spam filters also reduce the risk of social-engineering and phishing attacks via email, reducing your cybercrime attack surface. Enjoy streamlined management capabilities with ESET Remote Administrator that makes for fast and easy deployment and monitoring of ESET Endpoint Security across your network - all from a single console. Supplied with our remote administrator console for ease of rollout and ongoing management across all platforms",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1024458,
                TwitterName = "eset",
                FacebookName = "esetsoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ESET
            ca = new CloudApplication()
            {
                Brand = "ESET",
                ServiceName = "Endpoint Antivirus",
                CompanyURL = "http://www.eset.co.uk/Business/Endpoint-Security/Endpoint-Antivirus",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("LINUX")
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
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 91.65M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("eset"),
                Description = "Designed to support networks large and small, ESET Endpoint Antivirus with ESET Remote Administrator lets you focus on running your business, not your antivirus software. The solution delivers state-of-the-art proactive malware defence without the slowdowns, false positives, and other issues that impact end users and tie up your IT staff",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1024458,
                TwitterName = "eset",
                FacebookName = "esetsoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ESET
            ca = new CloudApplication()
            {
                Brand = "ESET",
                ServiceName = "Mobile & Tablet Security",
                CompanyURL = "http://www.eset.co.uk/Business/Endpoint-Security/Mobile-Security",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("SYMBIAN")
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
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("eset"),
                Description = "Protect your vital corporate data with ESET Mobile Security's advanced and proactive technology. Designed specifically for Windows Mobile and Symbian platforms, it combines a broad feature set with a light system footprint to cover all your mobile security needs. Supplied with our remote administrator console for ease of monitoring and ongoing management across all platforms.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1024458,
                TwitterName = "eset",
                FacebookName = "esetsoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SYMANTEC CLOUD
            ca = new CloudApplication()
            {
                Brand = "Symantec.Cloud",
                ServiceName = "Endpoint Protection Small Business Edition 2013",
                CompanyURL = "http://buy.symantec.com/estore/categoryDetailPage/skuType/Product/productCode/SHEP-EXP-LM_Vx.2_12MO_CC,SHEP-EXP-LM_Vx.2_24MO_CC,SHEP-EXP-LM_Vx.2_36MO_CC/buyNowTabSelectdCategroy/1/parentCartId/0/asoociationType/0/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("APPLE OS"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                //Browsers = new List<Browser>()
                //{
                //    repository.FindBrowserByName("IE6"),
                //    repository.FindBrowserByName("IE7"),
                //    repository.FindBrowserByName("IE8"),
                //    repository.FindBrowserByName("IE9"),
                //},
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
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
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 18.24M,
                ApplicationCostPerAnnumTo = 22.80M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("SYMANTEC.CLOUD"),
                Description = "Symantec Endpoint Protection Small Business Edition 2013 offers simple, fast and effective protection against viruses and malware. It is available as a cloud-managed service, or an on-premise management application depending upon your selection. If you select a cloud-managed service, it sets up in just minutes with no additional hardware needed, so securing your business is simple and quick. The cloud-managed service also updates automatically, so you always have the latest security available. Not quite ready for the Cloud? Start with our on-premise management option and transition to the Cloud during your subscription period, at no additional cost.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1231,
                TwitterName = "@symanteccloud",
                FacebookName = "Symantec",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SYMANTEC CLOUD
            ca = new CloudApplication()
            {
                Brand = "Symantec.Cloud",
                ServiceName = "Email Data Loss Prevention",
                CompanyURL = "http://buy.symantec.com/estore/categoryDetailPage/skuType/Product/productCode/006B7268-6102-1939-3A8B-A2078208B0B1,4992D240-F05A-0AE7-3C24-36187E137B8D,76FA6CAE-EAAE-13DE-76C3-196D9F8112CA/buyNowTabSelectdCategroy/1/parentCartId/0/asoociationType/0/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                //Browsers = new List<Browser>()
                //{
                //    repository.FindBrowserByName("IE6"),
                //    repository.FindBrowserByName("IE7"),
                //    repository.FindBrowserByName("IE8"),
                //    repository.FindBrowserByName("IE9"),
                //},
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
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
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    //repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    //repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    //repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 3.24M,
                ApplicationCostPerAnnumTo = 4.08M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("SYMANTEC.CLOUD"),
                Description = "Defend your data and protect email users by automatically detecting, controlling and blocking sensitive or inappropriate content and images found in email messages and attachments. Use our service to simplify your email policy management, aid in meeting regulatory compliance requirements and help prevent company data loss. Our service helps you protect employees from unwanted or offensive content and images, reduce data loss through email communications and aid in meeting regulatory compliance. It is also an effective solution for controlling the circulation of proprietary content and images.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1231,
                TwitterName = "@symanteccloud",
                FacebookName = "Symantec",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SYMANTEC CLOUD
            ca = new CloudApplication()
            {
                Brand = "Symantec.Cloud",
                ServiceName = "Email Security.Cloud",
                CompanyURL = "http://buy.symantec.com/estore/categoryDetailPage/skuType/Product/productCode/8BE5E938-91AC-FE39-7ED1-22BFB8430953,8F00E58E-7A37-6D2F-B9EE-D52D3D045E9E,01151BED-565F-63FD-A356-3ECD8E58A0DD/buyNowTabSelectdCategroy/1/parentCartId/0/asoociationType/0/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
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
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                //Languages = new List<Language>()
                //{
                //    repository.FindLanguageByName("ENGLISH")
                //},
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
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
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 29.40M,
                ApplicationCostPerAnnumTo = 36.72M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("SYMANTEC.CLOUD"),
                Description = "Symantec MessageLabs Email Security.cloud combines advanced email antivirus, antispam, and content filtering capabilities in an easy to manage solution that requires no on-site hardware or software. Part of an integrated approach to securing and managing email, Web, and instant messaging traffic, Email Security.cloud includes an industry-leading SLA that covers 100% protection against known and unknown viruses and a 99% spam capture rate (95% for email with double-byte characters).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1231,
                TwitterName = "@symanteccloud",
                FacebookName = "Symantec",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BIT DEFENDER
            ca = new CloudApplication()
            {
                Brand = "Bit Defender",
                ServiceName = "Cloud Security for Endpoints",
                CompanyURL = "http://www.bitdefender.co.uk/cloud",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
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
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 14.93M,
                ApplicationCostPerAnnumTo = 25.39M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("BIT DEFENDER"),
                Description = "Security for Endpoints is intended for workstations, laptops and servers running on Microsoft® Windows. Security for all systems can be managed by simply opening a browser and accessing Cloud Security Console",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 6825,
                TwitterName = "BIT DEFENDER",
                FacebookName = "bitdefender",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PANDA
            ca = new CloudApplication()
            {
                Brand = "Panda",
                ServiceName = "Cloud Office Protection",
                CompanyURL = "https://shop.pandasecurity.com/cgi-bin/pp/reg=GB?id=A1COPAESD&track=135486&coupon=HALLOWEEN30FF&actp=1&nav=pp_enterprise_businessSol_A1COPAESD",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
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
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 48.76M,
                ApplicationCostPerAnnumTo = 51.32M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("PANDA"),
                Description = "Panda Cloud Office Protection is cloud-based antivirus and endpoint protection for PCs and servers",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 165392,
                TwitterName = "PANDA",
                FacebookName = "PANDA",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region PANDA
            ca = new CloudApplication()
            {
                Brand = "Panda",
                ServiceName = "Global Protection 2013",
                CompanyURL = "https://shop.pandasecurity.com/cgi-bin/pp/reg=GB/ml=EN?id=A1GP13EST5&track=135486&coupon=HALLOWEEN30FF&actp=1&nav=pp_enterprise_businessSMB_A1GP13EST5",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
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
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(15),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
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
                    //repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 52.88M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("PANDA"),
                Description = "Harness the power of the cloud and help automatically improve the protection of every computer in the Panda community. Protect yourself from all kinds of online threats: viruses, hackers, online fraud, identity theft and all other known and unknown malware. Keep your inbox spam-free and surf the Web privately and securely with the Safe Browser (Sandboxing). The new password manager will allow you to store passwords, credit card numbers, bank account numbers and other sensitive online information securely. Panda Global Protection 2013 is easier, lighter, more secure and more complete than ever!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 165392,
                TwitterName = "PANDA",
                FacebookName = "PANDA",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBROOT
            ca = new CloudApplication()
            {
                Brand = "Webroot",
                ServiceName = "Secure Anywhere Business Endpoint Proetction",
                CompanyURL = "http://www.webroot.co.uk/En_GB/business/resources/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
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
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(999),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 17.59M,
                ApplicationCostPerAnnumTo = 137.55M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("WEBROOT"),
                Description = "Webroot® SecureAnywhere™ Business — Endpoint Protection offers a revolutionary approach to endpoint malware protection. With almost limitless power of cloud computing to stop known threats and prevent unknown zero-day attacks, Webroot’s innovative file pattern and predictive behavior recognition technology works more effectively than anyone else. Using the world’s lightest and fastest endpoint security client scans are unbelievably fast—normally less than two minutes — and they don’t slow down your end-users, ever. And because the technology is truly real-time, your security is always up-to-date, providing protection against all the latest threats and attacks without the hassle of managing signature file updates.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7434,
                TwitterName = "WEBROOT",
                FacebookName = "WEBROOT",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBROOT
            ca = new CloudApplication()
            {
                Brand = "Webroot",
                ServiceName = "Web Security Service",
                CompanyURL = "http://www.webroot.co.uk/En_GB/business/web-security/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
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
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                //LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                //LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(999),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    //repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("WEBROOT"),
                Description = "Webroot Web Security Service is a cloud-based security service that stops web usage threats before they reach your users' or your network. It intercepts all web page requests and ensures that remote and mobile employees, as well as those on network, are fully protected. It also ensures that web usage and Internet access policies are consistently enforced, no matter where users are accessing the web from. The Webroot Web Security Service is designed to make it simple for you to manage and enforce Internet usage policies, track web trends and minimize web malware. And as there's no on-premise management hardware and software to administer, as the management console is cloud-based too, it all adds-up to considerable savings in time and operational cost.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7434,
                TwitterName = "WEBROOT",
                FacebookName = "WEBROOT",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WEBROOT
            ca = new CloudApplication()
            {
                Brand = "Webroot",
                ServiceName = "Mobile protection",
                CompanyURL = "http://www.webroot.co.uk/En_GB/business/mobile-protection/",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("IPAD"),
                    //repository.FindMobilePlatformByName("WIN")
                },
                //Browsers = new List<Browser>()
                //{
                //    repository.FindBrowserByName("IE6"),
                //    repository.FindBrowserByName("IE7"),
                //    repository.FindBrowserByName("IE8"),
                //    repository.FindBrowserByName("IE9"),
                //    repository.FindBrowserByName("FIREFOX"),
                //    repository.FindBrowserByName("SAFARI"),
                //    repository.FindBrowserByName("OPERA"),
                //    repository.FindBrowserByName("CHROME"),
                //},
                //LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                //LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(999),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("WEBROOT"),
                Description = "Powerful, smart devices allow for a highly mobile and productive workforce. Enterprise mobile management and security has led to a complex set of challenges for IT. Webroot SecureAnywhere Business - Mobile delivers uncompromising defense against malware and web-based threats, ensuring end users and business data are protected. The SecureAnywhere platform is the only cloud-based security solution delivering endpoint protection from a single management console.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 7434,
                TwitterName = "WEBROOT",
                FacebookName = "WEBROOT",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MCAFEE
            ca = new CloudApplication()
            {
                Brand = "McAfee",
                ServiceName = "SaaS Endpoint & Email Protection",
                CompanyURL = "http://shop.mcafee.com/products/TotalProtectionForSmallBusinessAdvanced.aspx?site=uk&pid=TOPSBADV&CID=MFE-SHP104",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 36.67M,
                ApplicationCostPerAnnumTo = 43.77M,
                Options = "Vulnerability Assessment",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("MCAFEE"),
                Description = "Security doesn't have to be complicated, time consuming, or expensive. Companies know that there is a real need for security, but may be skittish about cost issues. McAfee understands that small businesses need security solutions that are easy to install and stress-free to maintain — while providing essential system, email, web, and mobile protection to stop new viruses and emerging online threats. With small business security from McAfee, you get exactly what your growing business needs in a solution that is scalable and priced right. Our solutions are cloud based, so they don’t require any software to install, and are simple to manage on our web interface. Learn more about McAfee cloud-based security for SMBs and how to keep your business safe in the face of growing threats to small businesses",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2336,
                TwitterName = "MCAFEE",
                FacebookName = "MCAFEE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MCAFEE
            ca = new CloudApplication()
            {
                Brand = "McAfee",
                ServiceName = "SaaS Endpoint Protection",
                CompanyURL = "http://shop.mcafee.com/ProductRecommender.aspx",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(251),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 18.75M,
                ApplicationCostPerAnnumTo = 22.39M,
                //Options = "Vulnerability Assessment",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("MCAFEE"),
                Description = "More and more new threats are evolving daily. Spam, phishing, viruses, web threats, and hackers can steal your valuable data and disrupt your network. Without constant updates, your security software becomes obsolete. Keeping your business continuously up to date requires total protection against known and unknown threats. McAfee® SaaS Endpoint Protection Suites safeguard your desktops, file servers, and email servers—with the convenience and ease of maintenance of a single, integrated Security-as-a-Service (SaaS) solution.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2336,
                TwitterName = "MCAFEE",
                FacebookName = "MCAFEE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MCAFEE
            ca = new CloudApplication()
            {
                Brand = "McAfee",
                ServiceName = "SaaS Email Inbound Filtering",
                CompanyURL = "http://shop.mcafee.com/Products/EmailInboundFiltering.aspx?cg=ctl00_BodyContent_prodRecommender1_hrefImgEIF",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 8.30M,
                ApplicationCostPerAnnumTo = 19.76M,
                //Options = "Vulnerability Assessment",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("MCAFEE"),
                Description = "SaaS Email Inbound Filtering from McAfee offers far more than traditional spam prevention. It provides businesses with complete inbound email security using a combination of proven spam filters, our leading anti-virus engine, fraud protection, content filtering, and email attack protection. Our simple-to-administer service identifies, quarantines, and blocks suspect email messages in the cloud, before they can enter your organization’s messaging infrastructure.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2336,
                TwitterName = "MCAFEE",
                FacebookName = "MCAFEE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region MCAFEE
            ca = new CloudApplication()
            {
                Brand = "McAfee",
                ServiceName = "SaaS Email Ptotection & Continuity",
                CompanyURL = "http://shop.mcafee.com/Products/EmailProtectionAndContinuity.aspx?cg=ctl00_BodyContent_prodRecommender1_hrefImgEPC",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 14.27M,
                ApplicationCostPerAnnumTo = 17.00M,
                Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("MCAFEE"),
                Description = "Tackle email security the easy way with McAfee® SaaS Email Protection and Continuity. Beyond blocking spam, phishing scams, malware, and inappropriate email content before it reaches your network, this cloud-based service enforces outgoing mail policies to protect you from data loss. Count on always-on email continuity so that your organization has around-the-clock access to email. With no hardware to buy, no software to install, and automatic updates to protect against the latest threats, you can focus on securing your business, not running applications.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2336,
                TwitterName = "MCAFEE",
                FacebookName = "MCAFEE",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TREND MICRO
            ca = new CloudApplication()
            {
                Brand = "Trend Micro",
                ServiceName = "Worry-Free Business Security Services",
                CompanyURL = "http://www.trendmicro.co.uk/products/worry-free-business-security-services/index.html",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH (EUROPEAN AND LATIN AMERICAN)"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("THAI"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 22.50M,
                ApplicationCostPerAnnumTo = 37.29M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("TREND MICRO"),
                Description = "Trend Micro™ Worry-Free™ Business Security Services provides Enterprise-class protection for Windows, Mac, and Android devices from a secure, centralized, web-based management console. It’s protection that can grow as your business increases without needing to grow your IT staff. You can manage all of your devices from anywhere and always feel confident that your data is safe. With Worry-Free Business Security Services, your machines are protected wherever they are connected from viruses, spyware, spam, malicious websites, and more.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 4312,
                TwitterName = "@TrendMicro",
                FacebookName = "Trendmicro",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TREND MICRO
            ca = new CloudApplication()
            {
                Brand = "Trend Micro",
                ServiceName = "Worry-Free Business Security Standard",
                CompanyURL = "http://www.trendmicro.co.uk/products/worry-free-business-security-standard/index.html",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH (EUROPEAN AND LATIN AMERICAN)"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("THAI"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 27.06M,
                ApplicationCostPerAnnumTo = 36.62M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("TREND MICRO"),
                Description = "Trend Micro Worry-Free Business Security Standard is cloud-based protection against viruses and cybercriminals. It lets you focus on your business instead of worrying about Internet security.  Worry-Free Business Security solutions provide businesses with fast, effective, and simple protection that allows for optimal use of their computers and servers. It provides effective protection that stops web threats before they reach your business machines while minimizing any slowdowns.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 4312,
                TwitterName = "@TrendMicro",
                FacebookName = "Trendmicro",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region TREND MICRO
            ca = new CloudApplication()
            {
                Brand = "Trend Micro",
                ServiceName = "Worry-Free Business Security Advanced",
                CompanyURL = "http://www.trendmicro.co.uk/products/worry-free-business-security-advanced/index.html",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(5),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("CHINESE (SIMPLIFIED)"),
                    repository.FindLanguageByName("CHINESE (TRADITIONAL)"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("ITALIAN"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH (EUROPEAN AND LATIN AMERICAN)"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("CZECH"),
                    repository.FindLanguageByName("DANISH"),
                    repository.FindLanguageByName("GREEK"),
                    repository.FindLanguageByName("HEBREW"),
                    repository.FindLanguageByName("KOREAN"),
                    repository.FindLanguageByName("NORWEGIAN"),
                    repository.FindLanguageByName("POLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SWEDISH"),
                    repository.FindLanguageByName("TURKISH"),
                    repository.FindLanguageByName("THAI"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 40.36M,
                ApplicationCostPerAnnumTo = 52.64M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("TREND MICRO"),
                Description = "Trend Micro Worry-Free Business Security Advanced is cloud-based protection against viruses, spam, cybercriminals, and data loss. It lets you focus on your business instead of worrying about Internet security. Worry-Free Business Security solutions provide businesses with fast, effective, and simple protection that allows for optimal use of their computers and servers. It provides effective protection that stops web threats before they reach your business machines while minimizing any slowdowns.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 4312,
                TwitterName = "@TrendMicro",
                FacebookName = "Trendmicro",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GFI
            ca = new CloudApplication()
            {
                Brand = "GFI Cloud",
                ServiceName = "Vipre Business Online - Antivirus & Antispyware",
                CompanyURL = "http://www.gficloud.com/vipre-business-online",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                //Languages = new List<Language>()
                //{
                //    repository.FindLanguageByName("ENGLISH"),
                //},
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 12.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("GFI"),
                Description = "GFI VIPRE Business Online is the antivirus solution that’s always on alert, giving you control of your network security anytime, anywhere, via the cloud. Because it has a very small footprint, VIPRE Business Online gives you real-time threat protection against viruses, spyware and other malware without impacting the performance of your computers. Whether you have 5 or 500 employees, its simple-to-use, web-based dashboard enables you to easily manage and configure the antivirus software on all your workstations and servers in 10 minutes or less. And because it scans on the endpoint, no potentially sensitive data leaves your network. With VIPRE Business Online, you have control and insight into the security of your network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 163985,
                TwitterName = "@GFICloud",
                FacebookName = "gfisoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZSCALER
            ca = new CloudApplication()
            {
                Brand = "Zscaler",
                ServiceName = "Web Security Premium Suite",
                CompanyURL = "http://www.zscaler.com/products_web_security.html",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                //LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                //LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName(""DEBIT CARD""),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("ZSCALER"),
                Description = "Small and Medium Businesses (SMB) can point all their Internet traffic to the Zscaler Web Security Cloud. The cloud protects against viruses, spyware, botnets and thousands of other advanced Internet-based threats. The cloud also provides a full suite of URL filtering capabilities. Unwanted URL categories can be blocked, while productivity draining categories can be controlled. Overall internet usage can be easily monitored with a simple cloud-based reporting portal. Web security made simple for the SMB",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 234625,
                TwitterName = "ZSCALER",
                FacebookName = "Zscaler",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZSCALER
            ca = new CloudApplication()
            {
                Brand = "Zscaler",
                ServiceName = "Email Security",
                CompanyURL = "",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                //LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                //LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName(""DEBIT CARD""),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("ZSCALER"),
                Description = "Small and Medium Businesses (SMB) can point all their email traffic to the Zscaler Email Security Cloud. The cloud protects against viruses, spyware, and spam. Mail flow and encryption policies can also be enforced. In addition, data loss over email – intentional or unintentional – can be detected and prevented. The savings in appliance maintenance overhead and ultimately cost are significant for already resource constrained SMBs. Email security made simple",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 234625,
                TwitterName = "ZSCALER",
                FacebookName = "Zscaler",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZSCALER
            ca = new CloudApplication()
            {
                Brand = "Zscaler",
                ServiceName = "Mobile Security",
                CompanyURL = "",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                //LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                //LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    //repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    repository.FindPaymentOptionByName(""DEBIT CARD""),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("ZSCALER"),
                Description = "Zscaler Mobile Security leverages the world’s largest global security cloud to protect mobile users and secure corporate data via the industry’s only 100% cloud–delivered mobile security solution. Thanks to a unique architecture that accepts traffic directly from smartphones and tablets, Zscaler Mobile Security protects users across mobile devices and laptops, regardless of network or location—All with a single policy. Zscaler Mobile Security scans in and outbound traffic, to enforce corporate security and use policy and to prevent corporate data from leaving the enterprise perimeter regardless of device or location. A gap–free mobile perimeter — Enforced in the cloud.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 234625,
                TwitterName = "ZSCALER",
                FacebookName = "Zscaler",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished SECURITY");
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
            if (ca.Devices != null)
            {
                ca.Devices.ForEach(x => x.DeviceStatus = repository.FindStatusByName("LIVE"));
            }
            ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            if (ca.Browsers != null)
            {
                ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            }
            if (ca.Languages != null)
            {
                ca.Languages.ForEach(x => x.LanguageStatus = repository.FindStatusByName("LIVE"));
            }
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

        #region PumpGFICloudAntiVirus
        public static bool PumpGFICloudAntiVirus(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region GFICLOUDANTIVIRUS
            ca = new CloudApplication()
            {
                Brand = "GFI",
                ServiceName = "Cloud Antivirus",
                CompanyURL = "http://www.gficloud.com/vipre-business-online",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 12.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("GFI"),
                Description = "GFI VIPRE Business Online is the antivirus solution that’s always on alert, giving you control of your network security anytime, anywhere, via the cloud. Because it has a very small footprint, VIPRE Business Online gives you real-time threat protection against viruses, spyware and other malware without impacting the performance of your computers. Whether you have 5 or 500 employees, its simple-to-use, web-based dashboard enables you to easily manage and configure the antivirus software on all your workstations and servers in 10 minutes or less. And because it scans on the endpoint, no potentially sensitive data leaves your network. With VIPRE Business Online, you have control and insight into the security of your network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 163985,
                TwitterName = "@GFICloud",
                FacebookName = "gfisoftware",
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

        #region PumpGFICloudWebProtection
        public static bool PumpGFICloudWebProtection(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region GFICLOUDWEBPROTECTION
            ca = new CloudApplication()
            {
                Brand = "GFI",
                ServiceName = "Cloud Web Protection",
                CompanyURL = "http://www.gficloud.com/vipre-business-online",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 12.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("GFI"),
                Description = "GFI VIPRE Business Online is the antivirus solution that’s always on alert, giving you control of your network security anytime, anywhere, via the cloud. Because it has a very small footprint, VIPRE Business Online gives you real-time threat protection against viruses, spyware and other malware without impacting the performance of your computers. Whether you have 5 or 500 employees, its simple-to-use, web-based dashboard enables you to easily manage and configure the antivirus software on all your workstations and servers in 10 minutes or less. And because it scans on the endpoint, no potentially sensitive data leaves your network. With VIPRE Business Online, you have control and insight into the security of your network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 163985,
                TwitterName = "@GFICloud",
                FacebookName = "gfisoftware",
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

        #region PumpGFICloudRemoteSupport
        public static bool PumpGFICloudRemoteSupport(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region GFICLOUDREMOTESUPPORT
            ca = new CloudApplication()
            {
                Brand = "GFI",
                ServiceName = "Cloud Remote Support",
                CompanyURL = "http://www.gficloud.com/vipre-business-online",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("IPAD"),
                    repository.FindOperatingSystemByName("APPLE"),
                    repository.FindOperatingSystemByName("SYMBIAN"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(500),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 12.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("GFI"),
                Description = "GFI VIPRE Business Online is the antivirus solution that’s always on alert, giving you control of your network security anytime, anywhere, via the cloud. Because it has a very small footprint, VIPRE Business Online gives you real-time threat protection against viruses, spyware and other malware without impacting the performance of your computers. Whether you have 5 or 500 employees, its simple-to-use, web-based dashboard enables you to easily manage and configure the antivirus software on all your workstations and servers in 10 minutes or less. And because it scans on the endpoint, no potentially sensitive data leaves your network. With VIPRE Business Online, you have control and insight into the security of your network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 163985,
                TwitterName = "@GFICloud",
                FacebookName = "gfisoftware",
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

        #region PumpAVGLogo
        public static bool PumpAVGLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "AVG",
                VendorLogoFileName = "AVG.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Security\\New Logos\\AVG.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpAVGAntiVirus2014
        public static bool PumpAVGAntiVirus2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGANTIVIRUS2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Anti Virus 2014",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 29.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGInternetSecurity2014
        public static bool PumpAVGInternetSecurity2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGINTERNETSECURITY2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Internet Security 2014",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 40.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGPremiumSecurity2014
        public static bool PumpAVGPremiumSecurity2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGPREMIUMSECURITY2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Premium Security 2014",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGAntiVirusForMac
        public static bool PumpAVGAntiVirusForMac(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGANTIVIRUSFORMAC
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Anti Virus For Mac",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    //repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = true,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGFileServer2014
        public static bool PumpAVGFileServer2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGFILESERVER2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "File Server 2014",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 31.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGBusinessAntiVirus
        public static bool PumpAVGBusinessAntiVirus(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGFILESERVER2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Business Anti Virus",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 70.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGBusinessInternetSecurity
        public static bool PumpAVGBusinessInternetSecurity(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGFILESERVER2014
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "Business Internet Security",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 73.95M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAVGCloudCare
        public static bool PumpAVGCloudCare(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVGCLOUDCARE
            ca = new CloudApplication()
            {
                Brand = "AVG",
                ServiceName = "CloudCare",
                CompanyURL = "http://www.avg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVG"),
                Description = "AVG provides robust online protection for both home and business use. AVG Internet Security 2014 protects users while they are surfing the web and communicating on Instant Messenger (IM) services, while simultaneously providing security to Local Area Networks (if they exist) against hazardous system attacks.AVG 2014 Internet Security is built with some completely new features since our 2011 product release. New in 2014 is AVG Accelerator, which helps speed up Internet experiences by accelerating downloads and Flash videos. Also new is AVG Advisor which provides assistance and recommendations in case of detected memory problems caused by browser sessions where tabs have been open for a long time.AVG 2014 uses the power of the company’s massive global user community to make the Internet safer for users everywhere. AVG’s ”People-Powered Protection” approach is foundational to AVG’s security software offering; by harnessing the power of the online community, AVG increases its ability to predict, identify and thwart attacks before they become widespread. Because of this, the software can isolate and address malicious activity more rapidly than ever before.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyLogo
        public static bool PumpKasperskyLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "Kaspersky",
                VendorLogoFileName = "kaspersky.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Security\\New Logos\\kaspersky.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpKasperskyPure3.0
        public static bool PumpKasperskyPure30(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYPURE3.0
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Pure 3.0",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "For the ultimate PC security solution, choose Kaspersky PURE 3.0 Total Security. It delivers everything you need to protect your PC – including your digital identity and your documents, photos, music and passwords – against the latest, sophisticated malware and Internet threats. With special features that add further layers of protection when you’re online shopping or banking, Kaspersky PURE 3.0 also secures your money and your accounts against cybercriminals.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyInternetSecurity2014
        public static bool PumpKasperskyInternetSecurity2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYINTERNETSECURITY2014
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Internet Security 2014",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    //repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 39.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Internet security software – to protect your PC, your data, and your identity. Along with the benefits of online shopping, banking and social networking, the growth in web-based activities has brought a corresponding growth in the viruses and complex Internet threats that can compromise the security of your PC and your valuable, personal information. Kaspersky Internet Security 2014 combines a vast array of easy-to-use, rigorous web security technologies that protect you against all types of malware and Internet-based threats – including cybercriminals that try to steal your money or your identity. Kaspersky Lab brings you hassle-free security that has minimal impact on your computer’s performance. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyAntiVirus2014
        public static bool PumpKasperskyAntiVirus2014(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYANTIVIRUS2014
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Anti Virus 2014",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
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
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    //repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    //repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 29.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Antivirus software – to keep your PC and your data secure against malware. With over 200,000 new malware items being launched every day, it’s vital that your PC – and the personal data you store on it – is protected against infections and cybercriminals. At the same time, you need a security solution that’s easy to use and doesn’t severely slow down your PC’s performance.Kaspersky Anti-Virus 2014 delivers essential antivirus technologies for your PC – with real-time, cloud-assisted protection against the latest malware threats. Working ‘behind the scenes’ – with intelligent virus scanning and small, frequent updates – it proactively defends your PC against both known and emerging threats, without any significant impact on your PC’s performance.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyInternetSecurityMultiDevice
        public static bool PumpKasperskyInternetSecurityMultiDevice(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYINTERNETSECURITYMULTIDEVICE
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Internet Security Multi Device",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(3),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    //repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    //repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 34.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "The one-licence, multi-platform solution for PCs, Macs & Android devices. Whichever device you use when you’re banking, shopping, surfing or social networking online, the Internet holds the same security risks – including malware infections, cybercrime and phishing. So it’s important to ensure all your connected devices, and the personal data you store on them, are protected against all the threats the Web can deliver. Kaspersky Internet Security – Multi-Device is the easy-to-use, one-licence, multi-platform security solution that protects virtually any combination of PCs, Macs, Android smartphones and Android tablets.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskySecurityForMac
        public static bool PumpKasperskySecurityForMac(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYSECURITYFORMAC
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Security For Mac",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    //repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    //repository.FindFeatureByName("SPYWARE PROTECTION"),
                    //repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    //repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    //repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 39.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Mac security – to protect your Mac, your data… and your children. With more and more people using Macs and other Apple devices, there’s been a rapid growth in the volume of Mac malware and the number of cybercriminals that are targeting Mac users – to steal their data, identities and money. Choosing a simple antivirus product isn’t enough to keep you, your children and your sensitive information safe. With its easy-to-use, Mac-style interface, Kaspersky Internet Security for Mac is optimised to deliver real-time protection against both Mac and PC malware – while also guarding your Mac against sophisticated Internet-based threats and cybercrime… all without any significant impact on your Mac’s performance.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyEndpointForBusinessAdvanced
        public static bool PumpKasperskyEndpointForBusinessAdvanced(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYENDPOINTFORBUSINESSADVANCED
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Endpoint For Business Advanced",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = " Kaspersky Endpoint Security for Business ADVANCED plays a valuable role in helping to eliminate the risk of criminals exploiting vulnerabilities within your systems.As business IT networks continue to become more complex, the task of managing all of the systems your business depends on has become much more difficult and time consuming. Kaspersky Endpoint Security for Business ADVANCED simplifies a vast range of systems management tasks – including configuration, deployment and troubleshooting. Kaspersky Endpoint Security for Business ADVANCED is preconfigured to help you manage and protect your systems – as soon as it’s installed.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyEndpointForBusinessSelect
        public static bool PumpKasperskyEndpointForBusinessSelect(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYENDPOINTFORBUSINESSSELECT
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Endpoint For Business Select",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Multi-level mobile security technologies help you to defend your business against the security risks that can result from enabling mobile access to your corporate systems. Kaspersky Endpoint Security for Business SELECT, can help you to benefit from the cost savings and productivity gains that a Bring Your Own Device (BYOD) initiative can deliver – while Kaspersky technologies protect you against viruses, spyware, Trojans, worms, bots and a wide range of other threats.With integrated mobile security and mobile device management (MDM), Kaspersky Endpoint Security for Business SELECT makes it easier to control how mobile devices access your business systems. As soon as a mobile device appears on your network, it’s visible to your administrators – so they can rapidly start managing the device’s security and how the device interacts with your systems.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyEndpointForBusinessCore
        public static bool PumpKasperskyEndpointForBusinessCore(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYENDPOINTFORBUSINESSCORE
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Endpoint For Business Core",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    //repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    //repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    //repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "With over 125,000 new malicious programs being detected every day, relying on just signature-based protection is no longer enough to provide adequate security for your business Kaspersky Endpoint Security for Business CORE combines several powerful anti-malware technologies – including signature-based protection, proactive protection and cloud-assisted security – to deliver multiple layers of defence for your business.Kaspersky Endpoint Security for Business CORE is preconfigured to start protecting your systems and data… as soon as it’s installed. It’s also supplied complete with Kaspersky Security Center – the centralised management console that makes it easier for you to control all aspects of your Kaspersky security solution.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyTotalSecurityForBusiness
        public static bool PumpKasperskyTotalSecurityForBusiness(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYTOTALSECURITYFORBUSINESS
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Total Security For Business",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "For businesses that demand world-class protection technologies across every major node on their network, Kaspersky TOTAL Security for Business delivers our most comprehensive business security solution. In addition to anti-malware for workstations, file servers and mobile devices – plus specialist encryption technologies, flexible endpoint controls and efficiency boosting systems management tools – Kaspersky TOTAL Security for Business provides reliable protection for mail servers, collaboration servers and traffic flowing through Internet gateways.Kaspersky TOTAL Security for Business offers easy-to-manage anti-malware and anti-spam protection for mail servers. In addition to delivering efficient, optimised virus scanning, Kaspersky provides intelligent spam filtering – to eliminate dangerous or distracting spam emails and reduce the amount of traffic on your corporate network.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskyTargetedSecuritySolutions
        public static bool PumpKasperskyTargetedSecuritySolutions(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYTARGETEDSECURITYSOLUTIONS
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Targeted Security Solutions",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 0.00M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Targeted Security solutions offer a cost-effective way to put Kaspersky technologies precisely where you need them – as standalone solutions or to extend your Kaspersky Endpoint Security for Business or Kaspersky Total Security for Business solution.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpKasperskySmallOfficeSecurity
        public static bool PumpKasperskySmallOfficeSecurity(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYSMALLOFFICESECURITY
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Small Office Security",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 159.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Protect your business. Because of increased reliance on computing and the Internet, all businesses are more vulnerable to malware and cybercrime attacks against their computers. Valuable business information, online financial transactions and sensitive data are all at risk.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
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

        #region PumpAvastLogo
        public static bool PumpAvastLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "Avast",
                VendorLogoFileName = "avast.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Security\\New Logos\\avast.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }
        #endregion

        #region PumpAvastEndpointProtection
        public static CloudApplication PumpAvastEndpointProtection(QueryRepository repository)
        {
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVASTENDPOINTPROTECTION
            ca = new CloudApplication()
            {
                Brand = "Avast",
                ServiceName = "Endpoint Protection",
                CompanyURL = "http://www.avast.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVAST"),
                Description = "Award-winning avast! endpoint protection, now customized for small-business needs. Basic and reliable security for great value for money!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpAvastEndpointProtectionPlus
        public static CloudApplication PumpAvastEndpointProtectionPlus(QueryRepository repository)
        {
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVASTENDPOINTPROTECTION
            ca = new CloudApplication()
            {
                Brand = "Avast",
                ServiceName = "Endpoint Protection Plus",
                CompanyURL = "http://www.avast.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVAST"),
                Description = "Award-winning avast! endpoint protection, now customized for small-business needs. Basic and reliable security for great value for money!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpAvastEndpointProtectionSuite
        public static CloudApplication PumpAvastEndpointProtectionSuite(QueryRepository repository)
        {
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVASTENDPOINTPROTECTIONSUITE
            ca = new CloudApplication()
            {
                Brand = "Avast",
                ServiceName = "Endpoint Protection Suite",
                CompanyURL = "http://www.avast.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVAST"),
                Description = "Award-winning avast! endpoint protection, now customized for small-business needs. Basic and reliable security for great value for money!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpAvastEndpointProtectionSuitePlus
        public static CloudApplication PumpAvastEndpointProtectionSuitePlus(QueryRepository repository)
        {
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region AVASTENDPOINTPROTECTION
            ca = new CloudApplication()
            {
                Brand = "Avast",
                ServiceName = "Endpoint Protection Suite Plus",
                CompanyURL = "http://www.avast.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    //repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    //repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    //repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    //repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    //repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    //repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    //repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //ApplicationCostPerAnnumPOA = true,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("AVAST"),
                Description = "Award-winning avast! endpoint protection, now customized for small-business needs. Basic and reliable security for great value for money!",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpKasperskyTotalSecurityMultiDevice
        public static CloudApplication PumpKasperskyTotalSecurityMultiDevice(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYTOTALSECURITYMULTIDEVICE
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Total Security Multi Device",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 49.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Protect your business. Because of increased reliance on computing and the Internet, all businesses are more vulnerable to malware and cybercrime attacks against their computers. Valuable business information, online financial transactions and sensitive data are all at risk.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpKasperskyInternetSecurity2015
        public static CloudApplication PumpKasperskyInternetSecurity2015(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYINTERNETSECURITY2015
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Internet Security 2015",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 39.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Protect your business. Because of increased reliance on computing and the Internet, all businesses are more vulnerable to malware and cybercrime attacks against their computers. Valuable business information, online financial transactions and sensitive data are all at risk.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion

        #region PumpKasperskyAntiVirus2015
        public static CloudApplication PumpKasperskyAntiVirus2015(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("SECURITY").CategoryID;

            #region KASPERSKYANTIVIRUS2015
            ca = new CloudApplication()
            {
                Brand = "Kaspersky",
                ServiceName = "Anti Virus 2015",
                CompanyURL = "http://www.kaspersky.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN XP"),
                    repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                    repository.FindBrowserByName("CHROME"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
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
                    repository.FindFeatureByName("CLOUD-CENTRIC SERVICE DELIVERY"),
                    repository.FindFeatureByName("CLOUD-BASED THREAT DETECTION/INTERCEPTION"),
                    repository.FindFeatureByName("CLOUD-BASED UPDATES"),
                    repository.FindFeatureByName("ANTIVIRUS PROTECTION"),
                    repository.FindFeatureByName("MALWARE PROTECTION"),
                    repository.FindFeatureByName("SPAM PROTECTION"),
                    repository.FindFeatureByName("ROOTKIT PROTECTION"),
                    repository.FindFeatureByName("SPYWARE PROTECTION"),
                    repository.FindFeatureByName("ADDITIONAL FIREWALL SECURITY"),
                    repository.FindFeatureByName("WEB BROWSING RESTRICTION"),
                    repository.FindFeatureByName("WEB BROWSING CONTROL"),
                    repository.FindFeatureByName("WEB BROWSING PROTECTION"),
                    //repository.FindFeatureByName("USB, PORT, CD/DVD CONTROL"),
                    //repository.FindFeatureByName("CREATE BOOTABLE RESCUE DRIVES"),
                    repository.FindFeatureByName("CENTRAL, REMOTE ADMINISTRATION"),
                    //repository.FindFeatureByName("ACCESS REGISTRATION TO PROTECT SENSITIVE CONTENT"),
                    repository.FindFeatureByName("OUTBOUND EMAIL & DOCUMENT CONTROL"),
                    repository.FindFeatureByName("OUTBOUND EMAIL ENCRYPTION"),
                    repository.FindFeatureByName("IMAGE/ATTACHMENT CONTROL"),
                    repository.FindFeatureByName("USER LEVEL WEB BROWSER REPORTING"),
                    //repository.FindFeatureByName("OFFLINE END-POINT PROTECTION"),
                    //repository.FindFeatureByName("THREAT SANDBOXING"),
                    repository.FindFeatureByName("INTRUSION PREVENTION SYSTEM"),
                    repository.FindFeatureByName("DEVICE LOCATION MAP"),
                    repository.FindFeatureByName("MOBILE BLUETOOTH HACKING"),
                    repository.FindFeatureByName("MOBILE REMOTE DATA WIPE"),
                    repository.FindFeatureByName("QUANTANTINE MOBILE INFILTRATIONS"),
                    repository.FindFeatureByName("SMS SPAM PROTECTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnumFrom = 29.99M,
                //Options = "Email Encryption",
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                ApplicationCostPerAnnumPOA = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("SECURITY"),
                Vendor = repository.FindVendorByName("KASPERSKY"),
                Description = "Protect your business. Because of increased reliance on computing and the Internet, all businesses are more vulnerable to malware and cybercrime attacks against their computers. Valuable business information, online financial transactions and sensitive data are all at risk.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.Smaller businesses face the same security risks as large organisations, but often don’t have the time or resources to configure and manage complex IT security solutions. Kaspersky Small Office Security delivers business-grade protection technologies that are designed to be simple to install, configure and run. The solution protects your Windows-based PCs & file servers and Android smartphones & tablets… to safeguard your online banking transactions, your business data and the information your customers entrust to you.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "",
                FacebookName = "",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            return ca;

        }
        #endregion



    }
}
