using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class FinancialProductionData
    {

        public static bool PumpFinancialData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("FINANCIAL").CategoryID;

            #region APPLICATIONS

            #region FINANCIAL

            #region XERO MEDIUM
            ca = new CloudApplication()
            {
                Brand = "xero",
                ServiceName = "Medium",
                CompanyURL = "www.xero.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("xero"),
                Description = "Xero is the world's most beautiful and easiest accounting software. See your cashflow in real time, automatically import and code your bank transactions. Easy invoice creation and a large range of add-ons to integrate with other Cloudware. Try a free trial today",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 50780,
                TwitterName = "xero",
                FacebookName = "Xero.Accounting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region XERO SMALL
            ca = new CloudApplication()
            {
                Brand = "xero",
                ServiceName = "Small",
                CompanyURL = "www.xero.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 12.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("xero"),
                Description = "Xero is the world's most beautiful and easiest accounting software. See your cashflow in real time, automatically import and code your bank transactions. Easy invoice creation and a large range of add-ons to integrate with other Cloudware. Try a free trial today",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 50780,
                TwitterName = "xero",
                FacebookName = "Xero.Accounting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region XERO LARGE
            ca = new CloudApplication()
            {
                Brand = "xero",
                ServiceName = "Large",
                CompanyURL = "www.xero.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 24.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("xero"),
                Description = "Xero is the world's most beautiful and easiest accounting software. See your cashflow in real time, automatically import and code your bank transactions. Easy invoice creation and a large range of add-ons to integrate with other Cloudware. Try a free trial today",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 50780,
                TwitterName = "xero",
                FacebookName = "Xero.Accounting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SAGEONE ACCOUNTS
            ca = new CloudApplication()
            {
                Brand = "SageOne",
                ServiceName = "Accounts",
                CompanyURL = "www.sageone.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 10.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("SageOne"),
                Description = "Sage is the world's Number 1 accounting software brand. SageOne Accounts is a specially tailored accounting service for small business who don't have time to learn accounting. From keeping on top of customers with recurring statements to online VAT returns, Sage One Accounts makes light work of controlling finances",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2136989,
                TwitterName = "SageOne",
                FacebookName = "sageuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SAGEONE CASHBOOK
            ca = new CloudApplication()
            {
                Brand = "SageOne",
                ServiceName = "Cashbook",
                CompanyURL = "www.sageone.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    //repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 5.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("SageOne"),
                Description = "Sage is the world's Number 1 accounting software brand. SageOne Cashbook is an online cash-based accounting system for sole traders to keep organised for HMRC and the bank. Quickly see your income and expenses for the month, so that tracking money in and out of your business becomes a breeze.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2136989,
                TwitterName = "SageOne",
                FacebookName = "sageuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SAGEONE PAYROLL
            ca = new CloudApplication()
            {
                Brand = "SageOne",
                ServiceName = "Payroll",
                CompanyURL = "www.sageone.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(15),
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
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    //repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    //repository.FindFeatureByName("CREATE INVOICES"),
                    //repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    //repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonthFrom = 5.00M,
                ApplicationCostPerMonthTo = 15.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("SageOne"),
                Description = "Sage is the world's Number 1 accounting software brand. SageOne Payroll is an online payroll solution for small businesses based in the UK that would like more control over their payroll processes, but don't necessarily have payroll knowledge or time for training. Simple to use and no prior payroll experienc is needed.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2136989,
                TwitterName = "SageOne",
                FacebookName = "sageuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //ca.IsScaledPrice = true;

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region E-CONOMIC SMALL
            ca = new CloudApplication()
            {
                Brand = "e-conomic",
                ServiceName = "Small",
                CompanyURL = "www.e-conomic.com",
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
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    //repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 12.99M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("e-conomic"),
                Description = "E-conomic is a cloud-based accounting system that conrtains General Ledger, Accounts Payable and Accounts Recievable and Sales Modules. There are also add on features such as Project Accounting. Two options are available with identical functionality, the only difference between them is a limit to the number of transactions in Small (max. 4000 transactions). E-conomic is the perfect solution for those that have limited hours and unlimited online accessibility.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 125528,
                TwitterName = "@ecoheretohelp",
                FacebookName = "economicuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region E-CONOMIC STANDARD
            ca = new CloudApplication()
            {
                Brand = "e-conomic",
                ServiceName = "Standard",
                CompanyURL = "www.e-conomic.com",
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
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 24.99M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("e-conomic"),
                Description = "E-conomic is a cloud-based accounting system that conrtains General Ledger, Accounts Payable and Accounts Recievable and Sales Modules. There are also add on features such as Project Accounting. Two options are available with identical functionality, the standard version has unlimited transactions for those that have more than 10 employees. E-conomic is the perfect solution for those that have limited hours and unlimited online accessibility.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 125528,
                TwitterName = "@ecoheretohelp",
                FacebookName = "economicuk",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ARITHMO STANDARD
            ca = new CloudApplication()
            {
                Brand = "ARITHMO",
                ServiceName = "Standard",
                CompanyURL = "www.arithmo.co.uk",
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("CALLBACK"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-6PM"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    //repository.FindFeatureByName("CREATE INVOICES"),
                    //repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 5.00M,
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
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ARITHMO"),
                Description = "Arithmo is unique as it has been designed to be a simple bookkeeping system to keep things on the money. Whether you are a working from home or in a small business, accounting can cause endless headaches. Arithmo is accounting software that takes away these hassles. Its easy to use interface means even a complete beginner can be up and running in minutes, making Arithmo one of the easiest pieces of accounting software on the market.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 685873,
                TwitterName = "ARITHMO",
                FacebookName = "ARITHMO",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ARITHMO PREMIUM
            ca = new CloudApplication()
            {
                Brand = "ARITHMO",
                ServiceName = "Premium",
                CompanyURL = "www.arithmo.co.uk",
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("CALLBACK"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-6PM"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 10.00M,
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
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ARITHMO"),
                Description = "Arithmo is unique as it has been designed to be a simple bookkeeping system to keep things on the money. Whether you are a working from home or in a small business, accounting can cause endless headaches. Arithmo is accounting software that takes away these hassles. Its easy to use interface means even a complete beginner can be up and running in minutes, making Arithmo one of the easiest pieces of accounting software on the market.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 685873,
                TwitterName = "ARITHMO",
                FacebookName = "ARITHMO",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LIQUID
            ca = new CloudApplication()
            {
                Brand = "liquid",
                ServiceName = "Business Accounting",
                CompanyURL = "www.liquidaccounts.net",
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 15.99M,
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
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("liquid"),
                Description = "Liquid is an award-winning, UK-based market leader of online accounting software. Our jargon-free, user-friendly business accounting system is designed to save you time and money and make running your business easier. Our software is accredited by both the ICAEW (Institute of Chartered Accountants of England and Wales) and the ICB (Institute of Certified Bookkeepers), and complies with the BASDA Cloud Vendor Charter (Business Application Software Developers Association).",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 255216,
                TwitterName = "liquid",
                FacebookName = "liquid",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region KASHOO SMALL BUSINESS
            ca = new CloudApplication()
            {
                Brand = "kashoo",
                ServiceName = "Small Business",
                CompanyURL = "www.kashoo.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("kashoo"),
                Description = "Kashoo is real accounting. There are plenty of apps out there that let you send invoices or track expenses or create reports. We think many of them are excellent. Kashoo does all of this and more in one accounting software application. Don’t worry. You don’t need to know a thing about accounting; Kashoo takes care of it for you as you create invoices and make entries, like expenses. When it comes time for your accountant to take care of your tax preparation, everything is in perfect order. This makes your accountant happy and saves you money.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 827645,
                TwitterName = "kashoo",
                FacebookName = "kashoo.online.accounting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region KASHOO START-UP
            ca = new CloudApplication()
            {
                Brand = "kashoo",
                ServiceName = "Start-Up",
                CompanyURL = "www.kashoo.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    //repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 16.00M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("kashoo"),
                Description = "Kashoo is real accounting. There are plenty of apps out there that let you send invoices or track expenses or create reports. We think many of them are excellent. Kashoo does all of this and more in one accounting software application. Don’t worry. You don’t need to know a thing about accounting; Kashoo takes care of it for you as you create invoices and make entries, like expenses. When it comes time for your accountant to take care of your tax preparation, everything is in perfect order. This makes your accountant happy and saves you money.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 827645,
                TwitterName = "kashoo",
                FacebookName = "kashoo.online.accounting",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FRESHBOOKS EVERGREEN
            ca = new CloudApplication()
            {
                Brand = "FRESHBOOKS",
                ServiceName = "Evergreen",
                CompanyURL = "www.freshbooks.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 29.95M,
                ApplicationCostPerAnnum = 0.00M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FRESHBOOKS"),
                Description = "Say Hello to Cloud Accounting. With Freshbooks you don't need desktop software, excel, a shoebox or magic elves. Freshbooks is built for small business owners that want to get oragnized and get paid. You can get paid faster with integrated online payments by credit card or PayPal as well as send late payment reminders to keep the cashlow moving.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 116468,
                TwitterName = "FRESHBOOKS",
                FacebookName = "FRESHBOOKS",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FRESHBOOKS SEEDLING
            ca = new CloudApplication()
            {
                Brand = "FRESHBOOKS",
                ServiceName = "Seedling",
                CompanyURL = "www.freshbooks.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    //repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    //repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    //repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 19.95M,
                ApplicationCostPerAnnum = 0.00M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FRESHBOOKS"),
                Description = "Say Hello to Cloud Accounting. With Freshbooks you don't need desktop software, excel, a shoebox or magic elves. Freshbooks is built for small business owners that want to get oragnized and get paid. You can get paid faster with integrated online payments by credit card or PayPal as well as send late payment reminders to keep the cashlow moving.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 116468,
                TwitterName = "FRESHBOOKS",
                FacebookName = "FRESHBOOKS",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FRESHBOOKS MIGHTY OAK
            ca = new CloudApplication()
            {
                Brand = "FRESHBOOKS",
                ServiceName = "Mighty Oak",
                CompanyURL = "www.freshbooks.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 39.95M,
                ApplicationCostPerAnnum = 0.00M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FRESHBOOKS"),
                Description = "Say Hello to Cloud Accounting. With Freshbooks you don't need desktop software, excel, a shoebox or magic elves. Freshbooks is built for small business owners that want to get oragnized and get paid. You can get paid faster with integrated online payments by credit card or PayPal as well as send late payment reminders to keep the cashlow moving.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 116468,
                TwitterName = "FRESHBOOKS",
                FacebookName = "FRESHBOOKS",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLEARBOOKS EVERYONE
            ca = new CloudApplication()
            {
                Brand = "ClearBooks",
                ServiceName = "Everyone",
                CompanyURL = "www.clearbooks.co.uk",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 39.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ClearBooks"),
                Description = "Clear Books Accounting Software is an online accounting system for small businesses. Our aim at Clear Books is to make accounting software for small business owners that is easy to use and saves time. Clear Books has been developed with the user in mind using a simple design to clearly guide users through day to day accounting and bookkeeping tasks. Clear Books supports multiple users logging into the accounts system at the same time. Clear Books small business accounting software is an online accounting system developed with small businesses in mind. Our accounts software is easy to use and will save you time. Clear Books is committed to excellent customer service, value for money and an open approach to business. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 399046,
                TwitterName = "ClearBooks",
                FacebookName = "ClearBooks",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLEARBOOKS EXPANSION
            ca = new CloudApplication()
            {
                Brand = "ClearBooks",
                ServiceName = "Expansion",
                CompanyURL = "www.clearbooks.co.uk",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ClearBooks"),
                Description = "Clear Books Accounting Software is an online accounting system for small businesses. Our aim at Clear Books is to make accounting software for small business owners that is easy to use and saves time. Clear Books has been developed with the user in mind using a simple design to clearly guide users through day to day accounting and bookkeeping tasks. Clear Books supports multiple users logging into the accounts system at the same time. Clear Books small business accounting software is an online accounting system developed with small businesses in mind. Our accounts software is easy to use and will save you time. Clear Books is committed to excellent customer service, value for money and an open approach to business. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 399046,
                TwitterName = "ClearBooks",
                FacebookName = "ClearBooks",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region CLEARBOOKS MICRO
            ca = new CloudApplication()
            {
                Brand = "ClearBooks",
                ServiceName = "Micro",
                CompanyURL = "www.clearbooks.co.uk",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 9.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ClearBooks"),
                Description = "Clear Books Accounting Software is an online accounting system for small businesses. Our aim at Clear Books is to make accounting software for small business owners that is easy to use and saves time. Clear Books has been developed with the user in mind using a simple design to clearly guide users through day to day accounting and bookkeeping tasks. Clear Books supports multiple users logging into the accounts system at the same time. Clear Books small business accounting software is an online accounting system developed with small businesses in mind. Our accounts software is easy to use and will save you time. Clear Books is committed to excellent customer service, value for money and an open approach to business. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 399046,
                TwitterName = "ClearBooks",
                FacebookName = "ClearBooks",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region LEDGERBLE
            ca = new CloudApplication()
            {
                Brand = "ledgerble",
                ServiceName = "Premium",
                CompanyURL = "www.ledgerble.com",
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
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 14.00M,
                ApplicationCostPerAnnum = 0.00M,
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
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ledgerble"),
                Description = "Moved back into Beta?",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "ledgerble",
                FacebookName = "ledgerble",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region KASHFLOW
            ca = new CloudApplication()
            {
                Brand = "KashFlow",
                ServiceName = "Accounting",
                CompanyURL = "www.kashflow.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 18.00M,
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
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("KashFlow"),
                Description = "Would you rather be working on your business or doing repetitive tasks? KashFlow automates raising invoices, chasing payments and much more. So you have more time for the important stuff. We don't think it's very nice to charge people more if they need help, so we don't. Our support team are always on hand any time of day, every day of the week. You work evenings and weekends, right? So do we.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 784324,
                TwitterName = "KashFlow",
                FacebookName = "KashFlowSoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FREEAGENT SOLE TRADER
            ca = new CloudApplication()
            {
                Brand = "FreeAgent",
                ServiceName = "Sole Trader",
                CompanyURL = "www.freeagentcentral.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 15.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FreeAgent"),
                Description = "FreeAgent is a web-based accounting application specifically for freelancers and small businesses. You can manage your invoicing, track expenses and time, and analyse electronic bank statements to build real-time accounts and tax predictions. FreeAgent allows you to import your Google Contacts and also export important invoice payment and tax dates to your Google Calendar, as well as integrating with other CRM systems like CapsuleCRM. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167335,
                TwitterName = "FreeAgent",
                FacebookName = "freeagentapp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FREEAGENT PARTNERSHIP
            ca = new CloudApplication()
            {
                Brand = "FreeAgent",
                ServiceName = "Partnership",
                CompanyURL = "www.freeagentcentral.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 20.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FreeAgent"),
                Description = "FreeAgent is a web-based accounting application specifically for freelancers and small businesses. You can manage your invoicing, track expenses and time, and analyse electronic bank statements to build real-time accounts and tax predictions. FreeAgent allows you to import your Google Contacts and also export important invoice payment and tax dates to your Google Calendar, as well as integrating with other CRM systems like CapsuleCRM. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167335,
                TwitterName = "FreeAgent",
                FacebookName = "freeagentapp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FREEAGENT LIMITED COMPANY
            ca = new CloudApplication()
            {
                Brand = "FreeAgent",
                ServiceName = "Limited Company",
                CompanyURL = "www.freeagentcentral.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                //    repository.FindSupportTerritoryByName("UK"),
                //},
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 25.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FreeAgent"),
                Description = "FreeAgent is a web-based accounting application specifically for freelancers and small businesses. You can manage your invoicing, track expenses and time, and analyse electronic bank statements to build real-time accounts and tax predictions. FreeAgent allows you to import your Google Contacts and also export important invoice payment and tax dates to your Google Calendar, as well as integrating with other CRM systems like CapsuleCRM. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 167335,
                TwitterName = "FreeAgent",
                FacebookName = "freeagentapp",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OUTRIGHT STANDARD
            ca = new CloudApplication()
            {
                Brand = "outright",
                ServiceName = "Standard",
                CompanyURL = "www.outright.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthPOA = true,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("outright"),
                Description = "Outright is much less work to learn and use than full-blown accounting solutions. Our 100,000 customers use us to make quarter-end, year-end, and sales tax events simple. With Outright, there's no accounting software to install. And, you don’t need to track down every receipt since the beginning of time. Outright is online and uses a secure Internet connection to download data from the accounts you link. Let Outright organize your online accounts, with support for over 4,000 banks and credit cards, plus eBay, PayPal, Freshbooks, Harvest and Shoeboxed.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 274957,
                TwitterName = "outright",
                FacebookName = "outright",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OUTRIGHT PLUS
            ca = new CloudApplication()
            {
                Brand = "outright",
                ServiceName = "Plus",
                CompanyURL = "www.outright.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("outright"),
                Description = "Outright is much less work to learn and use than full-blown accounting solutions. Our 100,000 customers use us to make quarter-end, year-end, and sales tax events simple. With Outright, there's no accounting software to install. And, you don’t need to track down every receipt since the beginning of time. Outright is online and uses a secure Internet connection to download data from the accounts you link. Let Outright organize your online accounts, with support for over 4,000 banks and credit cards, plus eBay, PayPal, Freshbooks, Harvest and Shoeboxed.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 274957,
                TwitterName = "outright",
                FacebookName = "outright",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO BOOKS
            ca = new CloudApplication()
            {
                Brand = "ZOHO Books",
                ServiceName = "Books",
                CompanyURL = "www.zoho.com/books",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerAnnum = 240.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ZOHO Books"),
                Description = "With Zoho Books business accounting software, get to know how much money your business is generating. Manage your invoices online and automate recurring invoices easily. Get paid fast with online payment gateways. Manage and control your expenses and cash outflow. Record invoices and commitments for purchases, services and even for reimbursable expenses like client travel. Keep track of your vendor's outstanding balances and pay on time.​ Glance through the dashboard to know what’s going well with your business and what’s not. Make smart and quick business decisions with the help of our insightful, available-anywhere reports.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 38373,
                TwitterName = "@ZohoBooks",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ICASHBOOK
            ca = new CloudApplication()
            {
                Brand = "iCashbook",
                ServiceName = "Standard",
                CompanyURL = "www.icashbook.com",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD"),
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    //repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BLACKBERRY"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 19.50M,
                ApplicationCostPerAnnum = 0.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("iCashbook"),
                Description = "Gone to the wall! Unable to view webpage?",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 0,
                TwitterName = "iCashbook",
                FacebookName = "iCashbook",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YENDO SOLO
            ca = new CloudApplication()
            {
                Brand = "Yendo",
                ServiceName = "Solo",
                CompanyURL = "www.yendo.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("ONLINE")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 9.00M,
                ApplicationCostPerAnnum = 0.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("Yendo"),
                Description = " Yendo is the only cloud delivered package that combines full accounting and CRM functionality. On the finance side it has everything you need to manage, invoicing, purchases, expenses and payments. With CRM also included you get sales pipeline and customer management complete with social media integration. With Yendo you have the complete financial and CRM start-up package in one.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 688217,
                TwitterName = "Yendo",
                FacebookName = "YendoBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YENDO STANDARD
            ca = new CloudApplication()
            {
                Brand = "Yendo",
                ServiceName = "Standard",
                CompanyURL = "www.yendo.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("ONLINE")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 26.00M,
                ApplicationCostPerAnnum = 0.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("Yendo"),
                Description = " Yendo is the only cloud delivered package that combines full accounting and CRM functionality. On the finance side it has everything you need to manage, invoicing, purchases, expenses and payments. With CRM also included you get sales pipeline and customer management complete with social media integration. With Yendo you have the complete financial and CRM start-up package in one.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 688217,
                TwitterName = "Yendo",
                FacebookName = "YendoBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region YENDO PREMIUM
            ca = new CloudApplication()
            {
                Brand = "Yendo",
                ServiceName = "Premium",
                CompanyURL = "www.yendo.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(15),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("ONLINE")
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 52.00M,
                ApplicationCostPerAnnum = 0.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("Yendo"),
                Description = " Yendo is the only cloud delivered package that combines full accounting and CRM functionality. On the finance side it has everything you need to manage, invoicing, purchases, expenses and payments. With CRM also included you get sales pipeline and customer management complete with social media integration. With Yendo you have the complete financial and CRM start-up package in one.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 688217,
                TwitterName = "Yendo",
                FacebookName = "YendoBusiness",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT PRO + PAYROLL
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Pro + Payroll",
                CompanyURL = "www.intuit.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 43.00M,
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
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = "Intuit Quickbooks Pro combines a powerful small business accounting package with payroll with automatically updated UK tax tables. Quick, easy in-house payroll Run payroll as often as you like - in minutes. There are just three simple steps: Choose which employees to pay and enter when they worked Check and approve the QuickBooks summary of pay Print your payslips - or just send them to your staff by email.  ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1666,
                TwitterName = "intuit",
                FacebookName = "intuit",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT PREMIER + PAYROLL
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Premier + Payroll",
                CompanyURL = "www.intuit.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 63.00M,
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
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = "Intuit Quickbooks Premier combines a powerful small business accounting package with payroll with automatically updated UK tax tables. Quick, easy in-house payroll. Quickbooks Premier has the added features of financial forecasting, stock control managment and the ability to apply discounts to your products and services. Run payroll as often as you like - in minutes. ",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1666,
                TwitterName = "intuit",
                FacebookName = "intuit",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT ONLINE SIMPLE START
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Online Simple Start",
                CompanyURL = "www.intuit.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 9.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = "Intuit QuickBooks business accounting software is a fast, easy way to spend less time on your business accounts. It makes light work of day-to-day accounting tasks and you don't need any accounting experience to get started. Rattle off branded invoices in seconds, automate lengthy manual tasks or find anything in a jiffy ... QuickBooks will save you time, all the time. Comfortably in the black or heading for the red (let's hope not)? QuickBooks shows cash flow figures that are up-to-the-minute.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1666,
                TwitterName = "intuit",
                FacebookName = "intuit",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT ONLINE ESSENTIALS
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Online Essentials",
                CompanyURL = "www.intuit.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = "Intuit QuickBooks business accounting software is a fast, easy way to spend less time on your business accounts. It makes light work of day-to-day accounting tasks and you don't need any accounting experience to get started. Rattle off branded invoices in seconds, automate lengthy manual tasks or find anything in a jiffy ... QuickBooks will save you time, all the time. Comfortably in the black or heading for the red (let's hope not)? QuickBooks shows cash flow figures that are up-to-the-minute.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1666,
                TwitterName = "intuit",
                FacebookName = "intuit",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT ONLINE PLUS
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Online Plus",
                CompanyURL = "www.intuit.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("Blackberry"),
                    repository.FindMobilePlatformByName("WIN")
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("8am-8pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 29.00M,
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
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = "Intuit QuickBooks business accounting software is a fast, easy way to spend less time on your business accounts. It makes light work of day-to-day accounting tasks and you don't need any accounting experience to get started. Rattle off branded invoices in seconds, automate lengthy manual tasks or find anything in a jiffy ... QuickBooks will save you time, all the time. Comfortably in the black or heading for the red (let's hope not)? QuickBooks shows cash flow figures that are up-to-the-minute.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1666,
                TwitterName = "intuit",
                FacebookName = "intuit",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished FINANCIAL");
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
            if (ca.OperatingSystems != null)
            {
                ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            }
            if (ca.Browsers != null)
            {
                ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            }
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

        #region PumpSageOneAccountsExtra
        public static bool PumpSageOneAccountsExtra(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("FINANCIAL").CategoryID;

            #region SAGEONE ACCOUNTS EXTRA
            ca = new CloudApplication()
            {
                Brand = "SageOne",
                ServiceName = "Accounts Extra",
                CompanyURL = "www.sageone.com",
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
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
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
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
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
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS",categoryID),
                    repository.FindFeatureByName("SSL SECURITY",categoryID),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API",categoryID),
                },
                ApplicationCostPerMonth = 10.00M,
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
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("SageOne"),
                Description = "Sage is the world's Number 1 accounting software brand. SageOne Accounts is a specially tailored accounting service for small business who don't have time to learn accounting. From keeping on top of customers with recurring statements to online VAT returns, Sage One Accounts makes light work of controlling finances",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 2136989,
                TwitterName = "SageOne",
                FacebookName = "sageuk",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
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
