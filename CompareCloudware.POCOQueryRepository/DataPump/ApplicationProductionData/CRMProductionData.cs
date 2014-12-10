using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class CRMProductionData
    {

        public static bool PumpCRMData(QueryRepository repository)
        {

            CloudApplication ca;

            bool retVal = true;

            int categoryID = repository.FindCategoryByName("CRM").CategoryID;

            #region APPLICATIONS

            #region CRM

            #region SALESFORCE CONTACT MANAGER
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Sales Cloud Contact Manager",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 3.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The world's #1 CRM sales app. With Sales Cloud you get all the CRM capabilities you’d expect from salesforce.com, along with everything you need to grow revenue, boost productivity, and get visibility into your business. Customers large and small have experienced amazing growth with Sales Cloud. You can too. Salesforce.com offers everything you need to grow your company, whether you’re an up-and-comer or a FORTUNE 50 corporation. With no software or hardware to install, you're up and running—and seeing a positive impact on your business—quickly. The Sales Cloud puts everything you need at your fingertips—available anywhere. From Social accounts and contacts to Mobile, Chatter, and Analytics, collaboration across your global organization and getting deals done faster is not only possible, it's easy.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE GROUP
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Sales Cloud Group",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 17.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The world's #1 CRM sales app. With Sales Cloud you get all the CRM capabilities you’d expect from salesforce.com, along with everything you need to grow revenue, boost productivity, and get visibility into your business. Customers large and small have experienced amazing growth with Sales Cloud. You can too. Salesforce.com offers everything you need to grow your company, whether you’re an up-and-comer or a FORTUNE 50 corporation. With no software or hardware to install, you're up and running—and seeing a positive impact on your business—quickly. The Sales Cloud puts everything you need at your fingertips—available anywhere. From Social accounts and contacts to Mobile, Chatter, and Analytics, collaboration across your global organization and getting deals done faster is not only possible, it's easy.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Sales Cloud Professional",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The world's #1 CRM sales app. With Sales Cloud you get all the CRM capabilities you’d expect from salesforce.com, along with everything you need to grow revenue, boost productivity, and get visibility into your business. Customers large and small have experienced amazing growth with Sales Cloud. You can too. Salesforce.com offers everything you need to grow your company, whether you’re an up-and-comer or a FORTUNE 50 corporation. With no software or hardware to install, you're up and running—and seeing a positive impact on your business—quickly. The Sales Cloud puts everything you need at your fingertips—available anywhere. From Social accounts and contacts to Mobile, Chatter, and Analytics, collaboration across your global organization and getting deals done faster is not only possible, it's easy.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Sales Cloud Enterprise",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 85.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The world's #1 CRM sales app. With Sales Cloud you get all the CRM capabilities you’d expect from salesforce.com, along with everything you need to grow revenue, boost productivity, and get visibility into your business. Customers large and small have experienced amazing growth with Sales Cloud. You can too. Salesforce.com offers everything you need to grow your company, whether you’re an up-and-comer or a FORTUNE 50 corporation. With no software or hardware to install, you're up and running—and seeing a positive impact on your business—quickly. The Sales Cloud puts everything you need at your fingertips—available anywhere. From Social accounts and contacts to Mobile, Chatter, and Analytics, collaboration across your global organization and getting deals done faster is not only possible, it's easy.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE UNLIMITED
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Sales Cloud Unlimited",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 170.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The world's #1 CRM sales app. With Sales Cloud you get all the CRM capabilities you’d expect from salesforce.com, along with everything you need to grow revenue, boost productivity, and get visibility into your business. Customers large and small have experienced amazing growth with Sales Cloud. You can too. Salesforce.com offers everything you need to grow your company, whether you’re an up-and-comer or a FORTUNE 50 corporation. With no software or hardware to install, you're up and running—and seeing a positive impact on your business—quickly. The Sales Cloud puts everything you need at your fingertips—available anywhere. From Social accounts and contacts to Mobile, Chatter, and Analytics, collaboration across your global organization and getting deals done faster is not only possible, it's easy.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Service Cloud Professional",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The leader in customer service. Transform your customer experience and build great customer connections with Service Cloud. From the contact center to self-service communities, social media and beyond, Service Cloud is changing the game in customer service.Work smarter. All of your cases in one unified agent experience. Create and track. Route and escalate. Fully integrated with your company’s call-center telephony and back-office apps. Your agents will know more, work faster, and work smarter. Across all channels. All the time. Increase loyalty, decrease costs. Empower your customers. Let them get case updates and search the knowledge base for themselves. Online, 24/7. With your customers posting, commenting, and validating, crowd-sourcing the best solutions will be faster. And the cost of a happy customer goes down.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Service Cloud Enterprise",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 90.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The leader in customer service. Transform your customer experience and build great customer connections with Service Cloud. From the contact center to self-service communities, social media and beyond, Service Cloud is changing the game in customer service.Work smarter. All of your cases in one unified agent experience. Create and track. Route and escalate. Fully integrated with your company’s call-center telephony and back-office apps. Your agents will know more, work faster, and work smarter. Across all channels. All the time. Increase loyalty, decrease costs. Empower your customers. Let them get case updates and search the knowledge base for themselves. Online, 24/7. With your customers posting, commenting, and validating, crowd-sourcing the best solutions will be faster. And the cost of a happy customer goes down.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESFORCE UNLIMITED
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Service Cloud Unlimited",
                CompanyURL = "www.salesforce.com/uk",
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
                Browsers = new List<Browser>()
                {
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 178.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = "The leader in customer service. Transform your customer experience and build great customer connections with Service Cloud. From the contact center to self-service communities, social media and beyond, Service Cloud is changing the game in customer service.Work smarter. All of your cases in one unified agent experience. Create and track. Route and escalate. Fully integrated with your company’s call-center telephony and back-office apps. Your agents will know more, work faster, and work smarter. Across all channels. All the time. Increase loyalty, decrease costs. Empower your customers. Let them get case updates and search the knowledge base for themselves. Online, 24/7. With your customers posting, commenting, and validating, crowd-sourcing the best solutions will be faster. And the cost of a happy customer goes down.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 3185,
                TwitterName = "Salesforce",
                FacebookName = "Salesforce",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUGARCRM PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "SUGARCRM",
                ServiceName = "Professional",
                CompanyURL = "www.sugaruk.co.uk",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 30.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SUGARCRM"),
                Description = "Sugar is an affordable and easy to use customer relationship management (CRM) platform, designed to help your business communicate with prospects, share sales information, close deals and keep customers happy. Thousands of successful companies use Sugar every day to manage sales, marketing and support.                                     As an open source, web-based CRM solution, Sugar is easy to customize and adapt to your changing needs. Ideal for small and medium-sized companies, large enterprises and government organizations, Sugar can run in the cloud or on-site.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 17345,
                TwitterName = "SUGARCRM",
                FacebookName = "SUGARCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUGARCRM CORPORATE
            ca = new CloudApplication()
            {
                Brand = "SUGARCRM",
                ServiceName = "Corporate",
                CompanyURL = "www.sugaruk.co.uk",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SUGARCRM"),
                Description = "Sugar is an affordable and easy to use customer relationship management (CRM) platform, designed to help your business communicate with prospects, share sales information, close deals and keep customers happy. Thousands of successful companies use Sugar every day to manage sales, marketing and support.                                     As an open source, web-based CRM solution, Sugar is easy to customize and adapt to your changing needs. Ideal for small and medium-sized companies, large enterprises and government organizations, Sugar can run in the cloud or on-site.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 17345,
                TwitterName = "SUGARCRM",
                FacebookName = "SUGARCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUGARCRM ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "SUGARCRM",
                ServiceName = "Enterprise",
                CompanyURL = "www.sugaruk.co.uk",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 60.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SUGARCRM"),
                Description = "Sugar is an affordable and easy to use customer relationship management (CRM) platform, designed to help your business communicate with prospects, share sales information, close deals and keep customers happy. Thousands of successful companies use Sugar every day to manage sales, marketing and support.                                     As an open source, web-based CRM solution, Sugar is easy to customize and adapt to your changing needs. Ideal for small and medium-sized companies, large enterprises and government organizations, Sugar can run in the cloud or on-site.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 17345,
                TwitterName = "SUGARCRM",
                FacebookName = "SUGARCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUGARCRM ULTIMATE
            ca = new CloudApplication()
            {
                Brand = "SUGARCRM",
                ServiceName = "Ultimate",
                CompanyURL = "www.sugaruk.co.uk",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SUGARCRM"),
                Description = "Sugar is an affordable and easy to use customer relationship management (CRM) platform, designed to help your business communicate with prospects, share sales information, close deals and keep customers happy. Thousands of successful companies use Sugar every day to manage sales, marketing and support.                                     As an open source, web-based CRM solution, Sugar is easy to customize and adapt to your changing needs. Ideal for small and medium-sized companies, large enterprises and government organizations, Sugar can run in the cloud or on-site.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 17345,
                TwitterName = "SUGARCRM",
                FacebookName = "SUGARCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region ZOHOCRM FREE
            ca = new CloudApplication()
            {
                Brand = "ZOHOCRM",
                ServiceName = "Free",
                CompanyURL = "www.zoho.com/crm",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("ZOHOCRM"),
                Description = "Zoho CRM frees you to do what you do best: selling. Automate tasks, improve workflow and focus on creating and capturing opportunities.Zoho CRM’s Opportunity Tracking tool gives you a current, comprehensive view of all your sales activities. Know where every customer is in the sales cycle, deal size, contact history, even competitor information to help craft more effective messaging. Dynamic Reports & Dashboards provide an easy, accurate read of everything going on.What’s the latest with your prospects and customers? Let them tell you. Link their LinkedIn, Facebook and Twitter profiles into your Zoho CRM system. Associate profiles to contacts or leads, send invitations to connect, view updates and share your comments.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 38373,
                TwitterName = "ZOHOCRM",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE INCLUDED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL INTEGRATION")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("OPEN API/3RD PARTY INTEGRATION")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region ZOHOCRM PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "ZOHOCRM",
                ServiceName = "Professional",
                CompanyURL = "www.zoho.com/crm",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 12.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("ZOHOCRM"),
                Description = "Zoho CRM frees you to do what you do best: selling. Automate tasks, improve workflow and focus on creating and capturing opportunities.Zoho CRM’s Opportunity Tracking tool gives you a current, comprehensive view of all your sales activities. Know where every customer is in the sales cycle, deal size, contact history, even competitor information to help craft more effective messaging. Dynamic Reports & Dashboards provide an easy, accurate read of everything going on.What’s the latest with your prospects and customers? Let them tell you. Link their LinkedIn, Facebook and Twitter profiles into your Zoho CRM system. Associate profiles to contacts or leads, send invitations to connect, view updates and share your comments.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 38373,
                TwitterName = "ZOHOCRM",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL INTEGRATION")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("OPEN API/3RD PARTY INTEGRATION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region ZOHOCRM ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "ZOHOCRM",
                ServiceName = "Enterprise",
                CompanyURL = "www.zoho.com/crm",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                    repository.FindSupportTypeByName("FAQ"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 25.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("ZOHOCRM"),
                Description = "Zoho CRM frees you to do what you do best: selling. Automate tasks, improve workflow and focus on creating and capturing opportunities.Zoho CRM’s Opportunity Tracking tool gives you a current, comprehensive view of all your sales activities. Know where every customer is in the sales cycle, deal size, contact history, even competitor information to help craft more effective messaging. Dynamic Reports & Dashboards provide an easy, accurate read of everything going on.What’s the latest with your prospects and customers? Let them tell you. Link their LinkedIn, Facebook and Twitter profiles into your Zoho CRM system. Associate profiles to contacts or leads, send invitations to connect, view updates and share your comments.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 38373,
                TwitterName = "ZOHOCRM",
                FacebookName = "zoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED STORAGE")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL INTEGRATION")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("MOBILE INTEGRATION")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("OPEN API/3RD PARTY INTEGRATION")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKBOOKS.COM FREE
            ca = new CloudApplication()
            {
                Brand = "Workbooks.com",
                ServiceName = "FREE",
                CompanyURL = "www.workbooks.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    //repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    //repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Workbooks.com"),
                Description = "Workbooks is designed for small and mid-size organisations with simple delivery through the Cloud.At Workbooks.com we understand the needs of small and mid-size businesses.  We recognise you are constantly looking to find ways to improve your business, offer your customers better service, increase revenues and improve your profitability. We also know that your IT systems need to be simple to use, must deliver the functionality you need and mustn't cost a fortune.Workbooks can help your organisation to increase revenue, streamline businesses processes and reduce costs. Workbooks extends beyond traditional CRM to include sales order processing, contract management and invoicing, so you can manage all your customer information in one place.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 225937,
                TwitterName = "@workbooks",
                FacebookName = "WorkbooksCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKBOOKS.COM CRM
            ca = new CloudApplication()
            {
                Brand = "Workbooks.com",
                ServiceName = "CRM",
                CompanyURL = "www.workbooks.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Workbooks.com"),
                Description = "Workbooks is designed for small and mid-size organisations with simple delivery through the Cloud.At Workbooks.com we understand the needs of small and mid-size businesses.  We recognise you are constantly looking to find ways to improve your business, offer your customers better service, increase revenues and improve your profitability. We also know that your IT systems need to be simple to use, must deliver the functionality you need and mustn't cost a fortune.Workbooks can help your organisation to increase revenue, streamline businesses processes and reduce costs. Workbooks extends beyond traditional CRM to include sales order processing, contract management and invoicing, so you can manage all your customer information in one place.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 225937,
                TwitterName = "@workbooks",
                FacebookName = "WorkbooksCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKBOOKS.COM BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Workbooks.com",
                ServiceName = "Business",
                CompanyURL = "www.workbooks.com",
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
                //    repository.FindMobilePlatformByName("IPAD"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Workbooks.com"),
                Description = "Workbooks is designed for small and mid-size organisations with simple delivery through the Cloud.At Workbooks.com we understand the needs of small and mid-size businesses.  We recognise you are constantly looking to find ways to improve your business, offer your customers better service, increase revenues and improve your profitability. We also know that your IT systems need to be simple to use, must deliver the functionality you need and mustn't cost a fortune.Workbooks can help your organisation to increase revenue, streamline businesses processes and reduce costs. Workbooks extends beyond traditional CRM to include sales order processing, contract management and invoicing, so you can manage all your customer information in one place.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 225937,
                TwitterName = "@workbooks",
                FacebookName = "WorkbooksCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MICROSOFT DYNAMICS
            ca = new CloudApplication()
            {
                Brand = "Microsoft Dynamics",
                ServiceName = "CRM Online",
                CompanyURL = "http://crm.dynamics.com",
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
                MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 28.70M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("INVOICE"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Microsoft Dynamics"),
                Description = "With Microsoft Dynamics CRM Online, you get powerful CRM software delivered as a cloud service from Microsoft, providing instant-on anywhere access, predictable pay-as-you-go pricing and a financially backed service level agreement (SLA).Get Immediate Results with Microsoft Dynamics CRM Online",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 1035,
                TwitterName = "@MSFTDynamics",
                FacebookName = "msftdynamics",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MAXIMIZER ENTREPENEUR
            ca = new CloudApplication()
            {
                Brand = "Maximizer",
                ServiceName = "Entrepeneur Edition",
                CompanyURL = "http://www.max.co.uk",
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
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    //repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    //repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerAnnum = 0.00M,
                ApplicationCostOneOff = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("NO"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Maximizer"),
                Description = "Since 1987 Maximizer has been creating Customer Relationship Management (CRM) software meeting the needs, budgets and access requirements of entrepreneurs, small and medium business and larger corporations. Maximizer CRM can be easily configured to meet the specific needs of your business and enables managers and executives to gain insight into the performance of the business through dashboards and reports. Custom CRM reporting is available for you to get key insights into your business performance.                                                                                     Simple, easy-to-use and affordable, Maximizer CRM enables organizations in all industries and markets to increase sales, enhance marketing, and improve customer service while boosting productivity and revenues",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 119039,
                TwitterName = "Maximizer",
                FacebookName = "MaximizerSoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MAXIMIZER GROUP
            ca = new CloudApplication()
            {
                Brand = "Maximizer",
                ServiceName = "Group Edition",
                CompanyURL = "http://www.max.co.uk",
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
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostOneOff = 0.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("NO"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Maximizer"),
                Description = "Since 1987 Maximizer has been creating Customer Relationship Management (CRM) software meeting the needs, budgets and access requirements of entrepreneurs, small and medium business and larger corporations. Maximizer CRM can be easily configured to meet the specific needs of your business and enables managers and executives to gain insight into the performance of the business through dashboards and reports. Custom CRM reporting is available for you to get key insights into your business performance.                                                                                     Simple, easy-to-use and affordable, Maximizer CRM enables organizations in all industries and markets to increase sales, enhance marketing, and improve customer service while boosting productivity and revenues",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 119039,
                TwitterName = "Maximizer",
                FacebookName = "MaximizerSoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MAXIMIZER ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Maximizer",
                ServiceName = "Enterprise Edition",
                CompanyURL = "http://www.max.co.uk",
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
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostOneOff = 0.00M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("NO"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Maximizer"),
                Description = "Since 1987 Maximizer has been creating Customer Relationship Management (CRM) software meeting the needs, budgets and access requirements of entrepreneurs, small and medium business and larger corporations. Maximizer CRM can be easily configured to meet the specific needs of your business and enables managers and executives to gain insight into the performance of the business through dashboards and reports. Custom CRM reporting is available for you to get key insights into your business performance.                                                                                     Simple, easy-to-use and affordable, Maximizer CRM enables organizations in all industries and markets to increase sales, enhance marketing, and improve customer service while boosting productivity and revenues",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 119039,
                TwitterName = "Maximizer",
                FacebookName = "MaximizerSoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region MAXIMIZER CLOUD
            ca = new CloudApplication()
            {
                Brand = "Maximizer",
                ServiceName = "Cloud Edition",
                CompanyURL = "http://www.max.co.uk",
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
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BLACKBERRY"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonthFrom = 49.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("24"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Maximizer"),
                Description = "Since 1987 Maximizer has been creating Customer Relationship Management (CRM) software meeting the needs, budgets and access requirements of entrepreneurs, small and medium business and larger corporations. Maximizer CRM can be easily configured to meet the specific needs of your business and enables managers and executives to gain insight into the performance of the business through dashboards and reports. Custom CRM reporting is available for you to get key insights into your business performance.                                                                                     Simple, easy-to-use and affordable, Maximizer CRM enables organizations in all industries and markets to increase sales, enhance marketing, and improve customer service while boosting productivity and revenues",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 119039,
                TwitterName = "Maximizer",
                FacebookName = "MaximizerSoftware",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region OPENCRM ENTRY
            ca = new CloudApplication()
            {
                Brand = "opencrm",
                ServiceName = "Entry",
                CompanyURL = "www.opencrm.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
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
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 75.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("opencrm"),
                Description = "OpenCRM delivers premium CRM functionality without the price tag! Whether you are in Sales and need to manage your Pipeline, Customer Service following Incidents through to resolution, or an Administrator helping to keep the company on track. Unlike some of our competitors, when you subscribe to OpenCRM you get all of the features, all of the time, regardless of the subscription level. Our goal is to give you a tool that will help your business grow and that's why, regardless of your business size, you can take advantage of everything we do. From our point of view, why wouldn't we?",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 498359,
                TwitterName = "opencrm",
                FacebookName = "opencrm",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region OPENCRM BUSINESS
            ca = new CloudApplication()
            {
                Brand = "opencrm",
                ServiceName = "Business",
                CompanyURL = "www.opencrm.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 125.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("opencrm"),
                Description = "OpenCRM delivers premium CRM functionality without the price tag! Whether you are in Sales and need to manage your Pipeline, Customer Service following Incidents through to resolution, or an Administrator helping to keep the company on track. Unlike some of our competitors, when you subscribe to OpenCRM you get all of the features, all of the time, regardless of the subscription level. Our goal is to give you a tool that will help your business grow and that's why, regardless of your business size, you can take advantage of everything we do. From our point of view, why wouldn't we?",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 498359,
                TwitterName = "opencrm",
                FacebookName = "opencrm",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region OPENCRM PRO
            ca = new CloudApplication()
            {
                Brand = "opencrm",
                ServiceName = "Pro",
                CompanyURL = "www.opencrm.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(16),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 260.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("opencrm"),
                Description = "OpenCRM delivers premium CRM functionality without the price tag! Whether you are in Sales and need to manage your Pipeline, Customer Service following Incidents through to resolution, or an Administrator helping to keep the company on track. Unlike some of our competitors, when you subscribe to OpenCRM you get all of the features, all of the time, regardless of the subscription level. Our goal is to give you a tool that will help your business grow and that's why, regardless of your business size, you can take advantage of everything we do. From our point of view, why wouldn't we?",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 498359,
                TwitterName = "opencrm",
                FacebookName = "opencrm",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region OPENCRM ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "opencrm",
                ServiceName = "Enterprise",
                CompanyURL = "www.opencrm.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
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
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(50),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 580.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                DemoOffered = true,
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("opencrm"),
                Description = "OpenCRM delivers premium CRM functionality without the price tag! Whether you are in Sales and need to manage your Pipeline, Customer Service following Incidents through to resolution, or an Administrator helping to keep the company on track. Unlike some of our competitors, when you subscribe to OpenCRM you get all of the features, all of the time, regardless of the subscription level. Our goal is to give you a tool that will help your business grow and that's why, regardless of your business size, you can take advantage of everything we do. From our point of view, why wouldn't we?",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 498359,
                TwitterName = "opencrm",
                FacebookName = "opencrm",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region TACTILECRM SOLO
            ca = new CloudApplication()
            {
                Brand = "TactileCRM",
                ServiceName = "Solo",
                CompanyURL = "www.tactilecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("TactileCRM"),
                Description = "The UK's most popular small business, web based CRM Tactile CRM lets you easily record every email, telephone call, note, activity and meeting, so that you and your colleagues can quickly see every interaction. Tactile CRM is an easy to use CRM sales tool that means even occasional users can get up and running without training on this simple web CRM.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 127879,
                TwitterName = "TactileCRM",
                FacebookName = "Tactile-CRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region TACTILECRM PREMIUM
            ca = new CloudApplication()
            {
                Brand = "TactileCRM",
                ServiceName = "Premium",
                CompanyURL = "www.tactilecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 6.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("TactileCRM"),
                Description = "The UK's most popular small business, web based CRM Tactile CRM lets you easily record every email, telephone call, note, activity and meeting, so that you and your colleagues can quickly see every interaction. Tactile CRM is an easy to use CRM sales tool that means even occasional users can get up and running without training on this simple web CRM.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 127879,
                TwitterName = "TactileCRM",
                FacebookName = "Tactile-CRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region TACTILECRM ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "TactileCRM",
                ServiceName = "Enterprise",
                CompanyURL = "www.tactilecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    //repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 6.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("TactileCRM"),
                Description = "The UK's most popular small business, web based CRM Tactile CRM lets you easily record every email, telephone call, note, activity and meeting, so that you and your colleagues can quickly see every interaction. Tactile CRM is an easy to use CRM sales tool that means even occasional users can get up and running without training on this simple web CRM.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 127879,
                TwitterName = "TactileCRM",
                FacebookName = "Tactile-CRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CAPSULE FREE
            ca = new CloudApplication()
            {
                Brand = "capsule",
                ServiceName = "Free",
                CompanyURL = "www.capsulecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("capsule"),
                Description = "The easy online CRM for doing business. Use Capsule to keep track of the people and companies you do business with, communications with them, opportunities in the pipeline, and what needs to be done when.Use Capsule to keep track of the people and companies you do business with, communications with them, opportunities in the pipeline, and what needs to be done when.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 2545778,
                TwitterName = "capsule",
                FacebookName = "capsule",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED CONTACTS")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED STORAGE")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region CAPSULE PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "capsule",
                ServiceName = "Professional",
                CompanyURL = "www.capsulecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 8.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("capsule"),
                Description = "The easy online CRM for doing business. Use Capsule to keep track of the people and companies you do business with, communications with them, opportunities in the pipeline, and what needs to be done when.Use Capsule to keep track of the people and companies you do business with, communications with them, opportunities in the pipeline, and what needs to be done when.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 2545778,
                TwitterName = "capsule",
                FacebookName = "capsule",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED CONTACTS")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE INCLUDED")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BUDDY
            ca = new CloudApplication()
            {
                Brand = "Buddy",
                ServiceName = "BuddyCRM",
                CompanyURL = "www.buddycrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 17.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Buddy"),
                Description = "BuddyCRM is the sales management tool built from the salesperson's perspective to spread good practice, reduce administration and maximise profits. It is simple to use and gives users and their managers the ability to efficiently manage leads, sales opportunities, generate forecasts, communicate with customers and produce quotations. Also, because Buddy CRM is built to link with existing sales processing and accounting system, it also means that real data can be imported to give up to date sales figures, identify downtraders and track performance against target. It streamlines your work to let you spend more time selling. BuddyCRM is delivered on a hosted platform with full data security and reliability commitments. Users access the system via a web browser and the use of brand new Adobe Flex technology delivers the application at the speed of a local machine with the convenience of being able to access from anywhere in the world.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 2276547,
                TwitterName = "Buddy",
                FacebookName = "Buddy",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SAGE CRM ESSENTIALS
            ca = new CloudApplication()
            {
                Brand = "sage",
                ServiceName = "SageCRM Essentials",
                CompanyURL = "www.uksagecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    //repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("INVOICE"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("sage"),
                Description = "A cloud-based solution, Sage CRM Essentials helps manage your sales pipeline and co-ordinate calendars, while giving you instant and transparent access to the information you need. Get up and running immediately, accelerate your sales performance, and analyse, manage and collaborate on all your opportunities with Sage CRM Essentials. Sage CRM Essentials gives you a single source of sales information in a simple to deploy and administer cloud-based solution. Automated workflow and pipeline management capabilities help you to progress sales opportunities, while ensuring that data is can be accessed by anyone that needs it. By helping to drive sales productivity it can help you to protect margins, reduce your cost of sale and customer attrition while also eliminating process bottlenecks.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 2802,
                TwitterName = "sage",
                FacebookName = "Sage-CRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MARKETING")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING AND MANAGEMENT")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL INTEGRATION")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CUSTOMER HELPDESK")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CASE QUEUEING & TRACKING")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED CASES")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SAGE CRM PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "sage",
                ServiceName = "SageCRM Professional",
                CompanyURL = "www.uksagecrm.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("IPHONE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 50.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("INVOICE"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("sage"),
                Description = "A cloud-based solution, Sage CRM Essentials helps manage your sales pipeline and co-ordinate calendars, while giving you instant and transparent access to the information you need. Get up and running immediately, accelerate your sales performance, and analyse, manage and collaborate on all your opportunities with Sage CRM Essentials. Sage CRM Essentials gives you a single source of sales information in a simple to deploy and administer cloud-based solution. Automated workflow and pipeline management capabilities help you to progress sales opportunities, while ensuring that data is can be accessed by anyone that needs it. By helping to drive sales productivity it can help you to protect margins, reduce your cost of sale and customer attrition while also eliminating process bottlenecks.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 2802,
                TwitterName = "sage",
                FacebookName = "Sage-CRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL MARKETING")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING AND MANAGEMENT")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("EMAIL INTEGRATION")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CUSTOMER HELPDESK")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CASE QUEUEING & TRACKING")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("UNLIMITED CASES")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WEBCRM
            ca = new CloudApplication()
            {
                Brand = "webCRM",
                ServiceName = "",
                CompanyURL = "www.webcrm.com/uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 18.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("1"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("webCRM"),
                Description = "web CRM customers range from small to large businesses. Our CRM customers cover manufacturing, professional services, media, telemarketing, training, property retail and management, IT, consulting and much more. webCRM allows users to easily retrieve information themselves without having to learn complex reporting tools. Web based CRM, Hosted CRM, On-line CRM, Cloud Computing, Software as a Service and Software on Demand are all words which describe the same concept: Secure access to your webCRM system at any computer, anywhere, anytime.All you need to start using webCRM is a standard PC/Mac with Internet access. There is no software to install, and no issues with reliability, synchronising data, sharing information, maintenance, upgrading or back-ups. Simply log on to webCRM and start working.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 946927,
                TwitterName = "webCRM",
                FacebookName = "WebCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PLANET SOHO
            ca = new CloudApplication()
            {
                Brand = "Planet Soho",
                ServiceName = "Start",
                CompanyURL = "www.sohoos.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Planet Soho"),
                Description = "SohoOS puts everything that you need to succeed directly at your fingertips so your business can grow and thrive almost effortlessly. From a unified contact system through inventory management to billing and accounts payable, SohoOS handles it all. Free of charge. Both on the web and on your mobile.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 1129208,
                TwitterName = "@planetsoho",
                FacebookName = "PlanetSoho",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BRIGHTPEARL
            ca = new CloudApplication()
            {
                Brand = "Brightpearl",
                ServiceName = "Brightpearl",
                CompanyURL = "www.brightpearl.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 69.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Brightpearl"),
                Description = "SohoOS puts everything that you need to succeed directly at your fingertips so your business can grow and thrive almost effortlessly. From a unified contact system through inventory management to billing and accounts payable, SohoOS handles it all. Free of charge. Both on the web and on your mobile.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 1215544,
                TwitterName = "Brightpearl",
                FacebookName = "BrightpearlHQ",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BATCHBOOK SMALL
            ca = new CloudApplication()
            {
                Brand = "Batchbook",
                ServiceName = "Small",
                CompanyURL = "www.batchblue.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Batchbook"),
                Description = "Batchbook is a social CRM which helps you build meaningful relationships with your best customers. Cloud based so every team member can use it, from anywhere, on any device. No matter where your contacts currently live, you'll find that Batchbook has open arms. Import your contacts via a spreadsheet from almost anywhere or collect them via a contact form on your website. Make your contact list useful with the ability to sort, resort, and view interesting segments of people. Get a better idea of who your customers are, how they relate to each other, and what next steps you need to take with them.Collecting information about your contacts is only half the battle. Building relationships is where the fun is! Encourage more customer interaction across your team and keep a running history of what has been said, promised, and accomplished.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 237609,
                TwitterName = "Batchbook",
                FacebookName = "BatchbookCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BATCHBOOK MEDIUM
            ca = new CloudApplication()
            {
                Brand = "Batchbook",
                ServiceName = "Medium",
                CompanyURL = "www.batchblue.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 50.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Batchbook"),
                Description = "Batchbook is a social CRM which helps you build meaningful relationships with your best customers. Cloud based so every team member can use it, from anywhere, on any device. No matter where your contacts currently live, you'll find that Batchbook has open arms. Import your contacts via a spreadsheet from almost anywhere or collect them via a contact form on your website. Make your contact list useful with the ability to sort, resort, and view interesting segments of people. Get a better idea of who your customers are, how they relate to each other, and what next steps you need to take with them.Collecting information about your contacts is only half the battle. Building relationships is where the fun is! Encourage more customer interaction across your team and keep a running history of what has been said, promised, and accomplished.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 237609,
                TwitterName = "Batchbook",
                FacebookName = "BatchbookCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BATCHBOOK LARGE
            ca = new CloudApplication()
            {
                Brand = "Batchbook",
                ServiceName = "Large",
                CompanyURL = "www.batchblue.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(50),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 100.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("Batchbook"),
                Description = "Batchbook is a social CRM which helps you build meaningful relationships with your best customers. Cloud based so every team member can use it, from anywhere, on any device. No matter where your contacts currently live, you'll find that Batchbook has open arms. Import your contacts via a spreadsheet from almost anywhere or collect them via a contact form on your website. Make your contact list useful with the ability to sort, resort, and view interesting segments of people. Get a better idea of who your customers are, how they relate to each other, and what next steps you need to take with them.Collecting information about your contacts is only half the battle. Building relationships is where the fun is! Encourage more customer interaction across your team and keep a running history of what has been said, promised, and accomplished.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 237609,
                TwitterName = "Batchbook",
                FacebookName = "BatchbookCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKetc STARTER
            ca = new CloudApplication()
            {
                Brand = "WORKetc",
                ServiceName = "Starter",
                CompanyURL = "www.worketc.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(2),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("WORKetc"),
                Description = "WORKetc is a total small business management software solution. WORKetc helps organize many of your daily activities such as tracking billable time, managing customer support, marketing and invoicing - making them easily accessible through the single interface.                                                              What this means is that we provide you with a number of integrated, internet-based software tools, that all work together to help you better manage your business.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 983909,
                TwitterName = "WORKetc",
                FacebookName = "WorKetc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKetc 10 PLUS
            ca = new CloudApplication()
            {
                Brand = "WORKetc",
                ServiceName = "10 Plus",
                CompanyURL = "www.worketc.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("WORKetc"),
                Description = "WORKetc is a total small business management software solution. WORKetc helps organize many of your daily activities such as tracking billable time, managing customer support, marketing and invoicing - making them easily accessible through the single interface.                                                              What this means is that we provide you with a number of integrated, internet-based software tools, that all work together to help you better manage your business.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 983909,
                TwitterName = "WORKetc",
                FacebookName = "WorKetc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WORKetc 20 PLUS
            ca = new CloudApplication()
            {
                Brand = "WORKetc",
                ServiceName = "20 Plus",
                CompanyURL = "www.worketc.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(21),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("WORKetc"),
                Description = "WORKetc is a total small business management software solution. WORKetc helps organize many of your daily activities such as tracking billable time, managing customer support, marketing and invoicing - making them easily accessible through the single interface.                                                              What this means is that we provide you with a number of integrated, internet-based software tools, that all work together to help you better manage your business.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 983909,
                TwitterName = "WORKetc",
                FacebookName = "WorKetc",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region APPSHORE SOLO
            ca = new CloudApplication()
            {
                Brand = "AppShore",
                ServiceName = "Solo",
                CompanyURL = "www.appshore.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("AppShore"),
                Description = "AppShore was founded with a crystal clear vision: To provide small business owners with the single most functional, cost-effective, and easy-to-use Customer Relationship Management solution possible. But, what really differentiates us from the competition is our passion and our people. Our CRM experts take personal responsibility and great pride in your success. Our policy is to answer every email and every support ticket as soon as humanly possible.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 837959,
                TwitterName = "AppShore",
                FacebookName = "AppShore",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region APPSHORE TEAM 3
            ca = new CloudApplication()
            {
                Brand = "AppShore",
                ServiceName = "Team 3",
                CompanyURL = "www.appshore.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("AppShore"),
                Description = "AppShore was founded with a crystal clear vision: To provide small business owners with the single most functional, cost-effective, and easy-to-use Customer Relationship Management solution possible. But, what really differentiates us from the competition is our passion and our people. Our CRM experts take personal responsibility and great pride in your success. Our policy is to answer every email and every support ticket as soon as humanly possible.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 837959,
                TwitterName = "AppShore",
                FacebookName = "AppShore",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region APPSHORE TEAM 7
            ca = new CloudApplication()
            {
                Brand = "AppShore",
                ServiceName = "Team 7",
                CompanyURL = "www.appshore.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(7),
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("AppShore"),
                Description = "AppShore was founded with a crystal clear vision: To provide small business owners with the single most functional, cost-effective, and easy-to-use Customer Relationship Management solution possible. But, what really differentiates us from the competition is our passion and our people. Our CRM experts take personal responsibility and great pride in your success. Our policy is to answer every email and every support ticket as soon as humanly possible.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 837959,
                TwitterName = "AppShore",
                FacebookName = "AppShore",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region APPSHORE TEAM 15
            ca = new CloudApplication()
            {
                Brand = "AppShore",
                ServiceName = "Team 15",
                CompanyURL = "www.appshore.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(8),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(15),
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 84.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("AppShore"),
                Description = "AppShore was founded with a crystal clear vision: To provide small business owners with the single most functional, cost-effective, and easy-to-use Customer Relationship Management solution possible. But, what really differentiates us from the competition is our passion and our people. Our CRM experts take personal responsibility and great pride in your success. Our policy is to answer every email and every support ticket as soon as humanly possible.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 837959,
                TwitterName = "AppShore",
                FacebookName = "AppShore",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region APPSHORE TEAM 30
            ca = new CloudApplication()
            {
                Brand = "AppShore",
                ServiceName = "Team 30",
                CompanyURL = "www.appshore.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(16),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(30),
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
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 129.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("AppShore"),
                Description = "AppShore was founded with a crystal clear vision: To provide small business owners with the single most functional, cost-effective, and easy-to-use Customer Relationship Management solution possible. But, what really differentiates us from the competition is our passion and our people. Our CRM experts take personal responsibility and great pride in your success. Our policy is to answer every email and every support ticket as soon as humanly possible.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 837959,
                TwitterName = "AppShore",
                FacebookName = "AppShore",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PIPELINE DEALS
            ca = new CloudApplication()
            {
                Brand = "Pipeline Deals",
                ServiceName = "Pipeline Deals",
                CompanyURL = "www.pipelinedeals.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("PipelineDeals"),
                Description = "PipelineDeals is the easiest way for your sales team to organize your sales pipeline and grow your business. Close more deals with less effort. PipelineDeals is so fast and easy, you’ll actually want to use it. We offer powerful hosted CRM features, and nothing to slow you down. Why buy a tank when you could get a sportscar? PipelineDeals is better for most B2B sales teams than Salesforce. We’re easier to use and more affordable with plenty of features and amazing support. We keep our pricing ridiculously simple. No hidden fees. No storage limits. No extra charges for support or for mobile access from any device. And no long-term contracts.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 1073626,
                TwitterName = "PipelineDeals",
                FacebookName = "PipelineDeals",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUPEROFFICE STANDARD
            ca = new CloudApplication()
            {
                Brand = "SuperOffice",
                ServiceName = "Standard",
                CompanyURL = "www.superoffice.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    //repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 33.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SuperOffice"),
                Description = "Great CRM Online - no matter what your size. SuperOffice CRM Online is ideal for those of you who are looking for an in the cloud CRM solution. There's no installation, no investment, no hassle. The powerful features in CRM Online can help you manage your contacts better and improve your sales and marketing processes. Hundreds of users choose SuperOffice CRM Online each month to improve their business.  We've got two editions.  Which one is right for you?Due to its interactive and intuitive interface SuperOffice CRM Online is easy to learn and simple to use. e-Learning is even installed in the Help section to support you along the way.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 811499,
                TwitterName = "SuperOffice",
                FacebookName = "SuperOfficeCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SUPEROFFICE PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "SuperOffice",
                ServiceName = "Professional",
                CompanyURL = "www.superoffice.co.uk",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 44.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("SuperOffice"),
                Description = "Great CRM Online - no matter what your size. SuperOffice CRM Online is ideal for those of you who are looking for an in the cloud CRM solution. There's no installation, no investment, no hassle. The powerful features in CRM Online can help you manage your contacts better and improve your sales and marketing processes. Hundreds of users choose SuperOffice CRM Online each month to improve their business.  We've got two editions.  Which one is right for you?Due to its interactive and intuitive interface SuperOffice CRM Online is easy to learn and simple to use. e-Learning is even installed in the Help section to support you along the way.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 811499,
                TwitterName = "SuperOffice",
                FacebookName = "SuperOfficeCRM",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESBOOM TEAM
            ca = new CloudApplication()
            {
                Brand = "salesboom",
                ServiceName = "Team",
                CompanyURL = "www.salesboom.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 14.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("salesboom"),
                Description = "Cloud CRM Products from Salesboom.com help small, medium and large enterprises manage and grow their business with our online Lead Management, Contact Management, Sales Force Automation, Customer Service; Support tools and much more. Cloud CRM is unlike traditional CRM Software, CRM the Cloud has low total cost, low risk, no large upfront cost, advanced customer service functionality as well as enhanced business collaboration tools. Try our Cloud CRM Software Free Online Trial to see why so many businesses have leveraged our Cloud CRM Software.Thousands of companies around the world depend on Salesboom to effectively manage their business and streamline operations across all departments in real time, everyday. Salesboom on demand customer facing and back office solutions are the most user friendly, feature rich and honestly priced, today.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 147454,
                TwitterName = "salesboom",
                FacebookName = "salesboom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESBOOM PROFESSIONAL
            ca = new CloudApplication()
            {
                Brand = "salesboom",
                ServiceName = "Professional",
                CompanyURL = "www.salesboom.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 45.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("salesboom"),
                Description = "Cloud CRM Products from Salesboom.com help small, medium and large enterprises manage and grow their business with our online Lead Management, Contact Management, Sales Force Automation, Customer Service; Support tools and much more. Cloud CRM is unlike traditional CRM Software, CRM the Cloud has low total cost, low risk, no large upfront cost, advanced customer service functionality as well as enhanced business collaboration tools. Try our Cloud CRM Software Free Online Trial to see why so many businesses have leveraged our Cloud CRM Software.Thousands of companies around the world depend on Salesboom to effectively manage their business and streamline operations across all departments in real time, everyday. Salesboom on demand customer facing and back office solutions are the most user friendly, feature rich and honestly priced, today.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 147454,
                TwitterName = "salesboom",
                FacebookName = "salesboom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region SALESBOOM ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "salesboom",
                ServiceName = "Enterprise",
                CompanyURL = "www.salesboom.com",
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
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("APPLE"),
                //    //repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
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
                    repository.FindSupportTypeByName("FAQ")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 95.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("salesboom"),
                Description = "Cloud CRM Products from Salesboom.com help small, medium and large enterprises manage and grow their business with our online Lead Management, Contact Management, Sales Force Automation, Customer Service; Support tools and much more. Cloud CRM is unlike traditional CRM Software, CRM the Cloud has low total cost, low risk, no large upfront cost, advanced customer service functionality as well as enhanced business collaboration tools. Try our Cloud CRM Software Free Online Trial to see why so many businesses have leveraged our Cloud CRM Software.Thousands of companies around the world depend on Salesboom to effectively manage their business and streamline operations across all departments in real time, everyday. Salesboom on demand customer facing and back office solutions are the most user friendly, feature rich and honestly priced, today.",
                AddDate = DateTime.Now,
                //IsLive = true,
                LinkedInCompanyID = 147454,
                TwitterName = "salesboom",
                FacebookName = "salesboom",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("CAMPAIGN TRACKING")).IsOptional = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IsOptional = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region WECANDOBIZ
            ca = new CloudApplication()
            {
                Brand = "wecandobiz",
                ServiceName = "Entry",
                CompanyURL = "wecando.biz",
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("wecandobiz"),
                Description = "WeCanDo.Biz is an online new business network for sales leads and referrals. Using social networking methods to broker valuable new business relationships, it provides simple tools to members which help generate sales leads, leverage customer referrals and win new business.",
                AddDate = DateTime.Now,
                //IsLive = false,
                LinkedInCompanyID = 0,
                TwitterName = "wecandobiz",
                FacebookName = "wecandobiz",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IncludeExtraCost = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished CRM");
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

        #region PumpCommenceLogo
        public static bool PumpCommenceLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "COMMENCE",
                VendorLogoFileName = "Commence Logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\carbonite logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//New Logos//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\CRM\\New Logos\\Commence Logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpCommence
        public static bool PumpCommence(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("CRM").CategoryID;

            #region COMMENCE
            ca = new CloudApplication()
            {
                Brand = "Commence",
                ServiceName = "Commence",
                CompanyURL = "www.commence.com",
                Devices = new List<Device>()
                {
                    //repository.FindDeviceByName("MOBILE"),
                    repository.FindDeviceByName("TABLET"),
                    repository.FindDeviceByName("DESKTOP"),
                    //repository.FindDeviceByName("LAPTOP"),
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
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("Blackberry"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
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
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("STORAGE INCLUDED"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION",categoryID),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION",categoryID),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CRM"),
                Vendor = repository.FindVendorByName("COMMENCE"),
                Description = "",
                AddDate = DateTime.Now,
                //IsLive = false,
                LinkedInCompanyID = 0,
                TwitterName = "CommenceCorp",
                FacebookName = "CommenceCRM",
                BuyURL = "www.comparecloudware.com",
                TryURL = "www.comparecloudware.com",
            };

            //InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVOICE CREATION & MANAGEMENT")).IncludeExtraCost = true;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INVENTORY & ORDER MANAGEMENT")).IncludeExtraCost = true;
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            return retVal;

        }
        #endregion

    }
}
