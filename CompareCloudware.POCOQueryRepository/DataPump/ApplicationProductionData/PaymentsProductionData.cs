using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class PaymentsProductionData
    {

        public static bool PumpPaymentsData(QueryRepository repository)
        {

            CloudApplication ca;

            bool retVal = true;

            int categoryID = repository.FindCategoryByName("PAYMENTS").CategoryID;

            #region APPLICATIONS

            #region Payments

            #region Sage Pay Flex

            ca = new CloudApplication()
            {
                Brand = "SagePay",
                ServiceName = "Sage Pay Flex",
                CompanyURL = "http://www.sagepay.co.uk/",
                
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    //repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 19.9M,
                ApplicationCostPerMonthFrom = 19.9M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                 
                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("SagePay"),
                Description = "Sage Pay has a range of online payment solutions designed to offer everything you need to successfully grow your business without requiring any extras.  Sage Pay Flex is one of the most comprehensive solutions at the lowest overall price. To get things started the package includes 350 transactions per month (additional transactions at 12p each), free advanced fraud screening tools and eInvoice payments included as standard.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper().ToUpper())).Count = 350;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper().ToUpper())).Count = 12;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper().ToUpper())).CountSuffix = "p";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Sage Pay Plus

            ca = new CloudApplication()
            {
                Brand = "SagePay",
                ServiceName = "Sage Pay Plus",
                CompanyURL = "http://www.sagepay.co.uk/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 45M,
                ApplicationCostPerMonthFrom = 45M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("SagePay"),
                Description = "Sage Pay Plus is a premium solution for online payments where larger volumes of transactions, service and advanced security needs are at the core of your business. In addition to Fast Pass 24/7 telephone, email & Twitter support, local European payments can easily be set-up and arranged alongside setting-up AMEX SafeKey. Sage Pay also offers a comprehensive package that includes both a payment gateway and a merchant account, making it easier for businesses to start trading. Switching to Sage Pay is easy to enjoy a seamless integrated solution that is fast, secure and reliable.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Sage Pay Business

            ca = new CloudApplication()
            {
                Brand = "SagePay",
                ServiceName = "Sage Pay Business",
                CompanyURL = "http://www.sagepay.co.uk/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    repository.FindFeatureByName("Mail & Phone Payments"),
                    repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    //repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    //repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 18M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("SagePay"),
                Description = "Sage Pay Business is a mail & telephone order payments solution designed to offer everything you need to successfully grow your business without requiring any extras. It offers the most comprehensive solution at the lowest overall price with 100 transactions per month (additional transactions at 14p each), free advanced fraud screening tools, 24/7 telephone, email and Twitter support. You can even apply for merchant accounts directly through Sage Pay to get up and running in no time at all.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 14;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region PayPal Here

            ca = new CloudApplication()
            {
                Brand = "PayPal",
                ServiceName = "PayPal Here",
                CompanyURL = "https://www.paypal.com/uk/webapps/mpp/accept-payments-online",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 20M,
                ApplicationCostPerMonthFrom = 20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("PayPal"),
                Description = "PayPal helps process payments for millions of customers worldwide. You pay a one-off fee to get access to the services, then you simply pay a transaction fee. It really is pay as you go! PayPal charges UK sellers a fee of between 1.4% and 3.4% of the total sale plus 20p per transaction within the UK. The fee depends on how much you sell, so the more you sell, the less you pay.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Skrill Digital Wallet

            ca = new CloudApplication()
            {
                Brand = "Skrill",
                ServiceName = "Skrill Digital Wallet",
                CompanyURL = "www.skrill.com",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    //repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Skrill"),
                Description = "The Skrill Digital Wallet lets your business accept secure ‘password only’ payments in 39 currencies from over 36 million people worldwide. For your customers, the Skrill Digital Wallet is the easy to use instant payment option. Paying online with the Skrill Digital Wallet is as fast and easy as paying with cards, with the additional benefit that no sensitive financial data is involved. All that's needed to pay with local payment options and 39 currencies is an email address and password. You can offer all this to your customers with just a single integration and contract.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Skrill Card Processing

            ca = new CloudApplication()
            {
                Brand = "Skrill",
                ServiceName = "Skrill Card Processing",
                CompanyURL = "www.skrill.com",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 19.95M,
                ApplicationCostPerMonthFrom = 19.95M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Skrill"),
                Description = "Skrill Card Processing accept payments from all major credit and debit cards without the complexity of setting up merchant accounts with different banks or credit card company. Your business can quickly offer debit card payments in different currencies and checkout languages, all with flexible integration options and a simple contractual setup. Card processing with Skrill allows you to customise your checkout to take control of your customers’ experience, while our fully responsive design ensures a seamless payment experience across desktop, tablet and mobile.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Real Ex Business Starter

            ca = new CloudApplication()
            {
                Brand = "Real Ex",
                ServiceName = "Real Ex Business Starter",
                CompanyURL = "http://www.realexpayments.co.uk/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 19M,
                ApplicationCostPerMonthFrom = 19M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Real Ex"),
                Description = "Real Ex Business Starter is a low cost, secure and feature-rich service, especially designed for small businesses trading online. Included are a number of fraud management tools which allows you to accept payments securely and greatly reduce the exposure to fraud faced in a 'card not present' environment. Fraud prevention combines fraud scoring, payer authentication and CVV/CVN checking. 3DSecure is also included as standard in all solutions. The unique online reporting tool, called RealControl, provides you with your own visibility over your transactions, in real-time. RealControl is simple and easy to access with separate levels of access depending on the user’s needs.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 350;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 9;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Real Ex Pay Pal

            ca = new CloudApplication()
            {
                Brand = "Real Ex",
                ServiceName = "Real Ex Pay Pal",
                CompanyURL = "http://www.realexpayments.co.uk/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    //repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    //repository.FindFeatureByName("PayPal Acceptance"),
                    repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    //repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 5M,
                ApplicationCostPerMonthFrom = 5M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Real Ex"),
                Description = "Real Ex Pay Pal provides a state-of-the-art online payments solution, allowing the automation of sales and online payments processing through to fulfilment of Pay Pal transactions. The Real Ex PayPal package is a low cost, secure and feature rich service especially designed for the start-up online trader.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 9;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region eWay Fast Dizzy Hamster

            ca = new CloudApplication()
            {
                Brand = "eWay",
                ServiceName = "eWay Fast Dizzy Hamster",
                CompanyURL = "http://www.eway.co.uk/pricing/pricing-plans",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("eWay"),
                Description = "eWay’s Fast Dizzy Hamster Plan is perfectly tailored for small and micro sized online businesses. eWAY believe in simplicity and made it happen. Don’t wait days for payments when eWAY processes payments in seconds. With overnight settlement, your cash flow has never been healthier. eWAY enables a fast, secure connection between your website and your bank. Customers don't have to leave your site, they don't have to enter their card number for repeat purchases, and the funds go directly to your bank.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("45.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region eWay Big Fat Elephant

            ca = new CloudApplication()
            {
                Brand = "eWay",
                ServiceName = "eWay Big Fat Elephant",
                CompanyURL = "http://www.eway.co.uk/pricing/pricing-plans",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 0M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("eWay"),
                Description = "eWay’s Big Fat Elephant Plan is perfect for the growing business. eWAY's most popular pricing plan, the Big Fat Elephant Plan is cost-effective for businesses of many different sizes. Merchants can take advantage of one of lowest transaction rates in the industry at only 3p each and additional features such as multiple users and custom report, all with no annual or monthly rate. To avoid growing pains, you can mind your own business like never before! With MYeWAY you can sort all your eCommerce sales by value, display only successful transactions, view just the refunds, and display many other useful transaction statistics.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("195.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 3;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Authorize.Net Online

            ca = new CloudApplication()
            {
                Brand = "Authorize.Net",
                ServiceName = "Authorize.Net Online",
                CompanyURL = "https://www.authorize.net/en-GB/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ/Knowledge Base"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 19M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Authorize.Net"),
                Description = "Authorize.Net is a natural choice for European merchants looking for a payment gateway and merchant account to accept payments online, including small business start-ups, retailers looking to expand online or those simply wishing to upgrade their current payments solution. Authorize.Net enables businesses to authorise, settle and manage credit card transactions via their web sites and mail order/telephone order. Identify, manage and prevent suspicious and potentially costly fraudulent transactions with our exclusive customisable, rules-based Advanced Fraud Detection Suite™ (AFDS).",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                //SetupFee = repository.FindSetupFeeByName("195.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region BT Safe Pay


            ca = new CloudApplication()
            {
                Brand = "BT-SafePay",
                ServiceName = "BT Safe Pay",
                CompanyURL = "http://www.eway.co.uk/pricing/pricing-plans",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("BT-SafePay"),
                Description = "BT SafePay has the capability to accept all major credit and debit cards, using the latest security technology: 3-D Secure; Verisign certification; encryption and firewall technology. BT SafePay processes more than 35 million transactions every year, worth over £2.5 billion (and we've done that for 18 years). And as a Tier 1 merchant ourselves, we really understand about taking secure payments. We have solutions to help you meet your obligations no matter how big or small your business. From a simple virtual terminal, or customisable payment pages, right through to fully integrated hosted solutions we can put your compliance worries to bed. BT SafePay's token system is a safe and secure way of storing card information in BT's Secure PCIDSS compliant Data Centres.No set-up fees, annual charges, or hidden costs, just simple and straightforward transaction-based pricing. Plus free tokenisation and UK-based support.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                //SetupFee = repository.FindSetupFeeByName("195.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 8;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Cashflows UK Domestic


            ca = new CloudApplication()
            {
                Brand = "Cashflows",
                ServiceName = "UK Domestic",
                CompanyURL = "http://www.cashflows.com/pricing-plans.php",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    //repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 34.99M,
                ApplicationCostPerMonthFrom = 34.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Cashflows"),
                Description = "CashFlows have designed a range of innovative business payment services, designed to help you manage your cash flow. They are principal members of Visa and MasterCard, allowing us to provide merchant accounts to accept credit and debit card payments painlessly. Based upon your monthly card turnover, trading history, business background and risk sector, Cashflow provides a tailored pricing plan to your suit your business.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("99.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Cashflows Eurozone

            ca = new CloudApplication()
            {
                Brand = "Cashflows",
                ServiceName = "Eurozone",
                CompanyURL = "http://www.cashflows.com/pricing-plans.php",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 34.99M,
                ApplicationCostPerMonthFrom = 79.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Cashflows"),
                Description = "Ready to trade with Europe? Cashflow Eurozone provides a service to enable cross-border transactions within the European Currency Union. CashFlows Eurozone also provides a range of online fraud management services, to help secure online payments and reduce your expose to fraud including: 3D Secure (SecureCode MasterCard, Verified by Visa), Address Verification Service (AVS) checks, CVV (CVN/CVC) checks, shoppers country blacklisting and VoicePay a voice biometric authorisation process.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("99.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Cashflows International

            ca = new CloudApplication()
            {
                Brand = "Cashflows",
                ServiceName = "International",
                CompanyURL = "http://www.cashflows.com/pricing-plans.php",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 34.99M,
                ApplicationCostPerMonthFrom = 139.99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Cashflows"),
                Description = "Cashflow International has all the benefits of UK Domestic and Eurozone products whilst enhancing service levels and fraud prevention capabilities. Cashflow have an in-house Fraud Screening Service that uses a range of data services including TC40 and SAFE reports to flag certain transactions as 'High Risk of potential fraud. All transaction information passed between merchant sites and our systems is encrypted using 128-bit SSL certificates. No cardholder information is ever passed unencrypted and any messages sent to your servers from us are secure and tamper-proof via SSL.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("99.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 25;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Digital River World Payments Processing

            ca = new CloudApplication()
            {
                Brand = "Digital River",
                ServiceName = "World Payments Processing",
                CompanyURL = "http://digitalriverpayments.co.uk/payment-processing/",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    //repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Digital River"),
                Description = "Digital River® World Payments™ is your partner for online payment processing across the globe. Wherever your next business move will take you, we are there to support your business growth – today and tomorrow. Digital River® World Payments™ can reduce your speed to market in new countries with products and services that simplify the complexity of global payment processing in more than 190 countries and over 170 transaction and display currencies. Flexible global payment processing programs ranging from standard gateway services to merchant account services and a fully outsourced payment solution. Payment options available include local and global cards, eWallets, emerging payment methods, retail bank products and third-party solutions.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("99.00"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                //FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 15;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Kounta Lite

            ca = new CloudApplication()
            {
                Brand = "Kounta",
                ServiceName = "Kounta Lite",
                CompanyURL = "",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    //repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                //ApplicationCostPerMonth = 20M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("£"),
                
                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Kounta"),
                Description = "Kouta keeps pricing simple and fair. They don’t limit you to the amount of transactions you do, the number of products you sell, the people you have working in your business, the number of logins and the size of your business. You pay for each register and any chargeable add-ons. Kounta Lite (the free plan) includes all of Kounta’s features and add-ons with limited transactions. You can upgrade at any time.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("All Credit Cards / Debit Cards".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PayPal Acceptance".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Mobile Payments".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Free Refunds".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion

            #region Kounta Business

            ca = new CloudApplication()
            {
                Brand = "Kounta",
                ServiceName = "Kounta Business",
                CompanyURL = "",

                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    //repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("BENGALI"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("FAQ/Knowledge Base")
                },
                //SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),

                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Inclusive Transactions (Per Month)", categoryID),
                    //repository.FindFeatureByName("Transaction Cost"),
                    repository.FindFeatureByName("All Credit Cards / Debit Cards"),
                    repository.FindFeatureByName("PayPal Acceptance"),
                    //repository.FindFeatureByName("Mail & Phone Payments"),
                    //repository.FindFeatureByName("Local / Alternative Payments"),
                    repository.FindFeatureByName("Mobile Payments"),
                    repository.FindFeatureByName("Free Refunds"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Instant Mass Payouts"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("1-Click Payments"),
                    repository.FindFeatureByName("Multi-Currency Payments"),
                    repository.FindFeatureByName("Fraud Screening"),
                    repository.FindFeatureByName("Integrated Checkout"),
                },
                ApplicationCostPerMonth = 50M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),

                Category = repository.FindCategoryByName("PAYMENTS"),
                Vendor = repository.FindVendorByName("Kounta"),
                Description = "Kounta Business is perfect for Point of Sale retail and restaurants, it is quick to set up, customisable and easy-to-use. Kounta works on Mac, PC, iPad, Android and even POS equipment you already have. All you need is Chrome or Safari (internet browsers). Kounta works with a range of existing and new printers, cash-drawers and barcode scanners and effortlessly brings your existing data to the cloud. You can access it anywhere, anytime, even on mobile. Upgrade to Kounta quickly and easily and without any business downtime. Kounta works with the same speed and efficiency even if you have lost your internet connection. Your products, inventory, orders, staff and customers are automatically updated and backed up in the cloud.",
                AddDate = DateTime.Now,
                //IsLive = true,
                //LinkedInCompanyID = 3185,
                //TwitterName = "Salesforce",
                //FacebookName = "Salesforce",
                //BuyURL = "www.amazon.co.uk",
                //TryURL = "www.bbc.co.uk",
                //Devices = new List<Device>()
                //{
                //    repository.FindDeviceByName("MOBILE"),
                //    repository.FindDeviceByName("TABLET"),
                //    repository.FindDeviceByName("DESKTOP"),
                //    repository.FindDeviceByName("LAPTOP"),
                //},
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                //MinimumContract = repository.FindMinimumContractByName("12"),
                //PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PRE-PAY"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                //SupportTerritories = new List<SupportTerritory>()
                //{
                //    repository.FindSupportTerritoryByName("GLOBAL"),
                //},
            };

            //InsertDocumentLinks(repository, ca);
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Inclusive Transactions (Per Month)".ToUpper())).Count = 0;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).Count = 15;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Transaction Cost".ToUpper())).CountSuffix = "p";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("All Credit Cards / Debit Cards".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("PayPal Acceptance".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Mobile Payments".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Free Refunds".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);
            #endregion
            #endregion

            #endregion

            Console.WriteLine("Finished Payments");
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
            //ca.Devices.ForEach(x => x.DeviceStatus = repository.FindStatusByName("LIVE"));
            ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            ca.Languages.ForEach(x => x.LanguageStatus = repository.FindStatusByName("LIVE"));
            ca.SupportTypes.ForEach(x => x.SupportTypeStatus = repository.FindStatusByName("LIVE"));
            if (ca.SupportTerritories != null)
            {
                ca.SupportTerritories.ForEach(x => x.SupportTerritoryStatus = repository.FindStatusByName("LIVE"));
            }
            ca.CloudApplicationFeatures.ForEach(x => x.CloudApplicationFeatureStatus = repository.FindStatusByName("LIVE"));
            //ca.PaymentOptions.ForEach(x => x.PaymentOptionStatus = repository.FindStatusByName("LIVE"));
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
                VendorLogoFullURL = "//Images//Logos/Customer Management//New Logos//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Customer Management\\New Logos\\Commence Logo.jpg"),
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
            int categoryID = repository.FindCategoryByName("CUSTOMER MANAGEMENT").CategoryID;

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
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
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
