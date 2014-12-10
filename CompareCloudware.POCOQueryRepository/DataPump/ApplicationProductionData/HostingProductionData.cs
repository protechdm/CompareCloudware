using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class HostingProductionData
    {

        public static bool PumpHostingData(QueryRepository repository)
        {
            #region setup
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

            #endregion

            int categoryID = repository.FindCategoryByName("HOSTING").CategoryID;

            #region APPLICATIONS

            #region HOSTING

            #region BT Starter

            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Starter",
                CompanyURL = "http://business.bt.com/domains-and-hosting/web-hosting/",
                Description = "The BT Starter Package is ideas for start-ups who are taking their first tentative steps into web hosting. It is BT’s most popular Web Hosting package and includes some fantastic features including WordPress so you can write you own Blog and LiveChat to speak to visitors who may want a bit more of guiding hand. For the more ambitious among you, the BT Starter Package includes more advanced features including scripting across a range of languages.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
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
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    //repository.FindFeatureByName("Web Tool Integration"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    //repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 6.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("BT"),
                AddDate = DateTime.Now,
                
            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 48;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 20;


            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BT Online & Protect

            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Online & Protect",
                CompanyURL = "http://business.bt.com/domains-and-hosting/web-hosting/",
                Description = "BT Online and Protect combines the BT Starter Package with security on up to 3 PCs. In one service you can have a fully hosted website with the reassurance of knowing that your business PCs are protected. This complete security package gives you all the protection your business needs online and is provided in association with Mcafee®. McAfee® is continually providing updates to protect against new online threats, guaranteeing that you have the latest protection available. McAfee® is continually providing updates to protect against new online threats, guaranteeing that you have the latest protection available.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
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

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    //repository.FindFeatureByName("Web Tool Integration"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    //repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 10.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("BT"),
                AddDate = DateTime.Now,

            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 48;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 20;


            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BT Professional

            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Professional",
                CompanyURL = "http://business.bt.com/domains-and-hosting/web-hosting/",
                Description = "The BT Professional Package is for small organisations where online is becoming a key part of their business in terms of promotion and revenue. A range of applications are available including Windows Services plus an unrivalled suite of reporting and analytics software so you know how well your site is performing. On top of this, BT Professional has a line-up of security features to ensure your site is fully protected from hackers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
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

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    //repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 18M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("BT"),
                AddDate = DateTime.Now,

            };

            InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 10;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 20;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Wesbite Security (SSL Certificate)".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 Starter

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Starter",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "Online publishing and online marketing have become two main occupations in the 21st Century. The Internet has developed into a liberal environment whereby anyone can write and speak freely – regardless of age, geographical position or social standing. By hosting a website on the Internet, every person or business can reach a potentially global audience. The 1&1 Starter package (for Linux only) is great for hobbyists, clubs, small charities or very small businesses that don’t need anything too fancy.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    //repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 2.49M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 10;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Wesbite Security (SSL Certificate)")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 Basic

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Basic",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "The 1&1Basic Service is an all-inclusive solution to create a professional online experience. Like all 1&1 services, the Basic service has bullet-proof security with daily backups and global redundancy to ensure availability. On top of this 1&1 basic includes unlimited monthly traffic for your website to secure a consistent flow of data to and from your website. With over 100GB of webspace and access to 144 applications with 1&1 Click & Build with plug-ins and extensions will help create the perfect website experience in no time, the Basic service is far from Basic.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 3.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 20;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 100;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Wesbite Security (SSL Certificate)")).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 Unlimited

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Unlimited",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "1&1 Unlimited has absolutely no limits on webspace, number of websites, databases or email accounts (2GB each). With Unlimited you can move into mobile. The technological innovations in mobile communications now allow smartphone users to access the Internet on the go, so you can easily create websites that are optimised for mobile devices with the included 1&1 Mobile Website Builder. This allows you to promote your website and keep it up to date by allowing customers to access your content quickly and easily on the go.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 6.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 Unlimited Plus

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Unlimited Plus",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "1&1 offers the highest levels of security and reliability with a highly sophisticated, geo-redundant infrastructure which means 1&1’s hosting services run in parallel at two separate data centres. In the event of problems at one data centre, the system switches to the second, ensuring your data remains available. With 1&1 Unlimited Plus, you can actively check your website for code vulnerabilities, and find them before hackers can cause harm. 1&1 SiteLock performs monthly scans of website applications, SQL injection scans and cross-site scripting (XSS) scans for up to 25 defined sub-pages of your website. In addition, 1&1 Unlimited Plus includes an SSL Certificate and takes performance to another level with 2GB Ram guaranteed which means your site is performing at the optimum level.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 9.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 1&1 Wordpress

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "1&1 Wordpress",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "1&1 WordPress hosting allows you to get your customised website online quickly and easily. Thinking about a blog? WordPress provides the perfect template, ready to go. What about your own website? With WordPress, you can be your own web designer, without knowledge of CSS and HTML or extensive online experience. With just a few clicks, WordPress is set up and ready to go. The 1&1 WordPress Hosting has an easy to use setup wizard that walks you through the installation step-by-step and makes it easy for you to get started. In no time at all, you will have a professionally designed website, without a large investment of time and effort. After 1&1 WordPress Hosting is installed, you can use 1&1 WP Wizard to select recommended themes and plugins, and install them for free. So go forward and Blog!",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 3.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1 1&1 Performance

            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "1&1 Performance",
                CompanyURL = "http://www.1&1.co.uk/hosting/",
                Description = "The range of 1&1 Performance Hosting is for sites with high visitor numbers including ecommerce platforms, online businesses or media. 1& 1 provides market leading performance with your own dedicated server which is located in 1&1 Data Centres and fully managed which means no administration for you or your existing IT support.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 39.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("1&1#2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Economy

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Economy",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Hosting is what makes it possible for others to view your website over the Internet. Without it, you’re the only one who will ever get a look. GoDaddy serves up one-click set-up, scalable storage and bandwidth and 24/7 secure monitoring. Go Daddy Economy comes with a free domain (with annual plan), free email addresses and one-click install of 200+ free applications to optimise your sites look, functionality and performance. All this plus 24/7 security monitoring and technical support, 99.9% uptime and money-back guarantee makes Go Daddy Economy a fantastic option if you’re just getting started. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 4.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 10;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 100;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Deluxe

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Deluxe",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Need to go unlimited? With Go Daddy Deluxe you are one click away from limitless storage and bandwidth. Ideal for building and managing multiple sites, the Deluxe package is ideal for the growing business where performance is becoming increasingly important. Did you know a 1 second delay in your website page load time can cause a 7% reduction in conversion? This can have a huge impact on your bottom line which is why Go Daddy work hard to maintain industry leading page load times.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 5.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 25;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 500;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Ultimate

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Ultimate",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Go Daddy Ultimate provides the best level of performance, features, service and security. With 2x the processing power and memory of Economy and Deluxe, you are moving into class-leading territory without the huge up-front costs of buying kit yourself. From a security standpoint, Go Daddy’s award-winning keeps your website safe with a dedicated  Go Daddy security team on the job 24/7, monitoring your site for suspicious activity and protecting it against brute force and DDoS attacks. On top of that, the Ultimate package includes an SSL certificate for the first year, keeping valuable customer data and payments safe with military grade encryption.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 9.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Wordpress Business

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Wordpress Business",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Ideal for small businesses, freelance designers and active bloggers. From the moment you log in, Go Daddy Wordpress Business is different. You’re instantly connected to WordPress, where you can spin up a new site in less than 30 seconds. Build your site on the free domain included with Business annual plan or start with a temporary domain and decide on the perfect URL later. And once your site is up, our automatic updates make sure you’re always running the latest version of WordPress, so your site is secure, up to date and running like a dream.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 12.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 5;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 500;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Wordpress Pro

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Wordpress Pro",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Recommended for web developers and creative agencies. Go Daddy Wordpress Pro is built from the ground up for maximum performance with dedicated, load-balanced servers, advanced tools and personal tweaks from our WordPress experts that you won’t find anywhere else. It all adds up to blistering speed and guaranteed 99.9% uptime, so when your latest blog post goes viral, your site stays up and running at top speed. And with Google® using site speed as a criteria for search ranking, it can help drive even more traffic to your site. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 18.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 25;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoDaddy Virtual Private Servers

            ca = new CloudApplication()
            {
                Brand = "GoDaddy",
                ServiceName = "Virtual Private Servers",
                CompanyURL = "http://www.godaddy.co.uk/",
                Description = "Launch your own VPS with just a few clicks. With Go Daddy's VPS simple setup process will have you up and running in minutes - no lengthy spin up times or waiting on resources. And with patching, monitoring, security, backups and support all included, you can stay focused on running your business. Best of all, when you choose Go Daddy's Managed VPS, your RAM, storage and bandwidth aren't just under your control, they're guaranteed.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GODADDY"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 40;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 123-Reg Business

            ca = new CloudApplication()
            {
                Brand = "123-Reg",
                ServiceName = "Business",
                CompanyURL = "http://www.123-reg.co.uk/",
                Description = "The concept of cloud hosting is to enable convenient, on demand network access to a shared pool of configurable resources (such as networks, servers, storage, applications and other services) that can be called upon and utilised rapidly with minimal effort compared to traditional hosting. Business cloud hosting is a cost effective solution for all businesses where you are not required to pay upfront for hardware or software. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 4.16M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("123-REG"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 50;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 5;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 2;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 123-Reg Start-Up

            ca = new CloudApplication()
            {
                Brand = "123-Reg",
                ServiceName = "Start-Up",
                CompanyURL = "http://www.123-reg.co.uk/",
                Description = "If the server where you are hosting your website were to crash this would affect your business and your credibility. Imagine how relieved you would be if this wouldn't be an issue. There is a solution for you and your business that allows you to keep your website online no matter what. It's called Start-Up cloud hosting and it gives you a flexible, cost effective and easy-to-use hosting product to organise and manage your company's website.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 2.49M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("123-REG"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 10;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 123-Reg Professional

            ca = new CloudApplication()
            {
                Brand = "123-Reg",
                ServiceName = "Professional",
                CompanyURL = "http://www.123-reg.co.uk/",
                Description = "With all 123 Reg cloud hosting packages you can have peace of mind because they take care of monitoring two leading edge data centres, 24 hours a day, 7 days a week. This enables Go Daddy to be proactive to add drives if more storage is required, computing power to handle increased load and bandwidth to deliver network capacity. The net result is that your site remains online and connected at all times. Go Daddy Professional takes it a step further with included website and restore",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 7.49M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("123-REG"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 100;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 3;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region 123-Reg Wordpress

            ca = new CloudApplication()
            {
                Brand = "123-Reg",
                ServiceName = "Wordpress",
                CompanyURL = "http://www.123-reg.co.uk/",
                Description = "If you want to create a WordPress site and host it online using your own unique web address you are in luck. With 123 Wordpress you can get online using your own domain in minutes. There is no app to upload, no complicated details to configure and no technical installation process. This means that you can easily get your site up and running even if you have little to no technical skills. You just login and make a site with a few clicks, it is that easy. You don't need to know the ins and outs of WordPress hosting; you can just get on with using this popular platform without the hassle.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 4.16M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("123-REG"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            //.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Optimal Hosting

            ca = new CloudApplication()
            {
                Brand = "Optimal Hosting",
                ServiceName = "Lite",
                CompanyURL = "http://www.optimalhosting.co.uk/",
                Description = "From small websites to large e-commerce websites, you can rely on Optimal Lite cloud hosting to keep your website working – even during the most demanding times. Optimal Lite is perfect for small websites who want rock-solid security and 24/7 support. Responsive and to-the-point, that’s what you can expect to receive whether it be via email, live chat, telephone or even through our Facebook or Twitter. Optimal Lite comes with 10GB disk space, 100GB bandwidth, 1 cloud website, 10 email addresses and free domain name. More than enough to get you started. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 5M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Optimal Hosting"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 10;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Optimal Hosting Professional

            ca = new CloudApplication()
            {
                Brand = "Optimal Hosting",
                ServiceName = "Professional",
                CompanyURL = "http://www.optimalhosting.co.uk/",
                Description = "Perfect for large websites that need to raise the game and ensure the website doesn’t fall over. With Optimal Professional 100% uptime is guaranteed on their cloud hosting platform. Optimal will keep you up and running 24x7x365 and if they do miss a beat, you’re covered with a generous service level agreement. Never lose a sale, follower or visitor again. Want to move an existing website to the Optimal hosting cloud? They will be appy to help you with a hands-off migration (and normally without any downtime!) at a time that suits you.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 10M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Optimal Hosting"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 20;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 200;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 20;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Optimal Hosting Business

            ca = new CloudApplication()
            {
                Brand = "Optimal Hosting",
                ServiceName = "Business",
                CompanyURL = "http://www.optimalhosting.co.uk/",
                Description = "Optimal Business is the top cloud hosting package. It’s lightning quick, high-availability and backed by Optimal’s 24 hour support team. With 100 GB disk space, 1,000GB (1TB) bandwidth, unlimited cloud websites, unlimited email accounts and a free domain and SSL certificate, you are guaranteed a business class service. Optimal Business ensures business continuity by data protection and daily back ups. Unlike other providers Optimal guarantee their backups and you can restore your entire website or an individual file from multiple restore points – even from months ago.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonth = 20M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Optimal Hosting"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 5;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Optimal Wordpress

            ca = new CloudApplication()
            {
                Brand = "Optimal Hosting",
                ServiceName = "Wordpress",
                CompanyURL = "http://www.optimalhosting.co.uk/",
                Description = "Optimised for WordPress, secured from attacks, lightning fast and backed by on-demand 24x7 WordPress experts. Combine the flexibility and extendability of the best open-source blogging platform with the reliability and performance of Optimal Hosting for an unrivalled hosting experience. Spin up WordPress in the cloud in minutes! Explore thousands of plugins, themes and customisations from a growing community of developers and users. When you sign up for a WordPress hosting package from Optimal Hosting, the hard work is done for you – WordPress is instantly available and you’ll be sent your login details right away to get started.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 5M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Optimal Hosting"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 100;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Optimal Servers

            ca = new CloudApplication()
            {
                Brand = "Optimal Hosting",
                ServiceName = "Servers",
                CompanyURL = "http://www.optimalhosting.co.uk/",
                Description = "More performance and flexibility requirements? Optimal’s Cloud Servers range of services are ideal for larger businesses and eCommerce sites. No more “cloud” buzzwords – unlike most mainstream cloud server providers, Optimal Cloud Servers is true to its name – with real failover technology, high performance SAN and unrivalled load balancing through a single pane of glass. From the core network to the physical servers in their private rackspace, everything is top-grade hardware from Dell, Cisco, Juniper and Intel. Optimal servers have cPanel loaded onto them, making it quick and easy to manage your website – from uploading files, to creating databases and checking email. Fan of SSH and the command line? They have got that for you too. You can also tap into Optimal’s team of experienced 24×7 system administrators. They can help with anything – from software installation to debugging your network settings and kernel. Server management is included on the top-end VS4/5/6 plans.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    //repository.FindFeatureByName("Web Tool Integration"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 17.5M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Optimal Hosting"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Heart Internet Starter Pro

            ca = new CloudApplication()
            {
                Brand = "Heart Internet",
                ServiceName = "Starter Pro",
                CompanyURL = "http://www.heartinternet.uk/",
                Description = "Web hosting for small websites or beginners. Perfect if you're starting out or creating a simple website. With a generous 5 GB web space, 30 GB bandwidth your site has room to grow. Add in free 100% UK customer support and the service hosted in secure state-of-the-art UK data centres all you need is a Money Back Guarantee. Heart offer that too with a 30 day money back guarantee as standard on all their web hosting accounts.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    //repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    //repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 2.49M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Heart Internet"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 30;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 1000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Heart Internet Home Pro

            ca = new CloudApplication()
            {
                Brand = "Heart Internet",
                ServiceName = "Home Pro",
                CompanyURL = "http://www.heartinternet.uk/",
                Description = "Feature-rich web hosting with plenty of room for your website to grow. Ideal for running a typical website with easy to install plug-ins for enhancements. Install over 70 popular titles – including Joomla!, Drupal, OpenCart, Simple Invoices, and Vanilla – in seconds with our convenient one-click installer. Available with both Home Pro and Business Pro web hosting plans, it’s completely free to use and there are no limits on the number of installs you can have. Build your business website, gallery, forum, e-shop, agency, portfolio, or family site in seconds. With a money-back guarantee you can follow your head as well as your heart! Designed by our in-house development team, the eXtend control panel has been crafted to meet all your domain and hosting management needs. Built by some of the industry's best developers and carefully refined using customer feedback, the eXtend control panel contains everything you need to manage your Heart Internet services.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 7.5M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Heart Internet"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 10000;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Heart Internet Business Pro

            ca = new CloudApplication()
            {
                Brand = "Heart Internet",
                ServiceName = "Business Pro",
                CompanyURL = "http://www.heartinternet.uk/",
                Description = "Not just for business, Heart’s top hosting package is a must for anyone serious about their websites. Host up to three websites with the Business Pro web hosting plan. With unlimited space, bandwidth & databases, all your sites have room to grow. Designed by Heart’s in-house development team, the eXtend control panel has been crafted to meet all your domain and hosting management needs. Built by some of the industry's best developers and carefully refined using customer feedback, the eXtend control panel contains everything you need to manage your Heart Business Pro Service. The friendly in-house UK team is there for you 24x7 with all servers hosted in secure state-of-the-art UK data centres. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 10.83M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Heart Internet"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Heart Internet Heart Virtual Private Server

            ca = new CloudApplication()
            {
                Brand = "Heart Internet",
                ServiceName = "Heart Virtual Private Server",
                CompanyURL = "http://www.heartinternet.uk/",
                Description = "Enjoy advanced VPS hosting services at an affordable price with Heart’s powerful virtual private servers. Combining the latest generation of Dell PowerEdge servers, Intel Xeon processors, and RAID-10 arrays of high-performance SAS disks with our bespoke systems, they have created one of the UK's most advanced virtual server platforms. Change your virtual server specs any time, make on the fly modifications ensure you can meet any sudden changes in demand or popularity as and when they occur. Virtual server hosting with Heart Internet includes a 99.99% uptime guarantee for your peace of mind. Take advantage of affordable, high-quality VPS hosting built on industry-leading hardware, a bespoke platform and in-house UK hardware and network support.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 11.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("Heart Internet"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region UK2 Business Cloud

            ca = new CloudApplication()
            {
                Brand = "UK2",
                ServiceName = "Business Cloud",
                CompanyURL = "http://www.uk2.net/",
                Description = "Based in the heart of start-up territory in Shoreditch, London, UK2.net is Britain’s local web hosting company. With the UK2 Business Cloud package and you’ll get your domains free for life. As well as cutting your budget a little slack, this’ll make life easier in general, because you’ll pay for your hosting in one simple monthly bill. The app installer gives you the potential to install popular software, including blogging platforms, forums and shopping carts. Some of the big names you’ll have access to are WordPress. Joomla, Drupal and opencart. This’ll save you time, pennies, and a whole lot of hassle. The unique UK2 Stats 2.0 web analytics helps you to learn about your website visitors, where they come from and how they interact with your website. Watch visitors browse your site in real time.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 6.63M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("UK2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region UK2 Virtual Private Server

            ca = new CloudApplication()
            {
                Brand = "UK2",
                ServiceName = "Virtual Private Server",
                CompanyURL = "http://www.uk2.net/",
                Description = "UK2 offers a very flexible Virtual Private Server (VPS) offer for those of you who want full control but not the hardware headache. UK2 uses leading edge hardware and is full of status symbol names like Cisco, HP and Supermicro. Going for premium specs make the services stable and reliable plus UK2 use unmetered gigabit connections making their cloud servers are fighter-pilot fast. If there’s a hardware problem on a certain cloud server, everything you have online will automatically switch to an active cloud without interruption. With instant set-up and complete control, you can have your UK2 VPS up and running with Windows or Linux in a matter of minutes.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    repository.FindFeatureByName("Virtual Data Centre Services"),
                    repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 5.96M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("UK2"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 1;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 50;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 1;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region EasySpace Web Hosting

            ca = new CloudApplication()
            {
                Brand = "EasySpace",
                ServiceName = "Web Hosting",
                CompanyURL = "http://www.easyspace.com/",
                Description = "Host powerful websites and applications at a fraction on the investment required for dedicated hardware. EasySpace utilise VMWare technology to ensure leading edge performance and security. There are three levels of service (Bronze, Silver and Gold) offering a competitive range of options in terms of speed and memory. With no long term commitment or sharing of resource, the VMware cloud is suitable for all types of business – from hosting to development, SOHO to SME. With a range of off the shelf operating systems EasySpace can tailor a build for your need – easily and quickly.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 3.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("EasySpace"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 5;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 10;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 100;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Dreamhost Shared Hosting

            ca = new CloudApplication()
            {
                Brand = "Dreamhost",
                ServiceName = "Shared Hosting",
                CompanyURL = "http://www.dreamhost.com/",
                Description = "DreamHost Shared Hosting is perfect for businesses that are creative as they are entrepreneurial. Everything is unlimited, bandwidth, storage, email accounts and domains. Dreamhost have a unique 1-click installer that will automatically install WordPress on your hosting account for you. All Dreamhost hosting plans are backed an in-house customer support team available 24/7/365 via live chat, email, and Twitter. The Shared Hosting service offers rock-solid 100% Uptime Guarantee and 97 Day Money Back Guarantee. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    //repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 8.95M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("DREAMHOST"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 3;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Dreamhost Virtual Private Servers

            ca = new CloudApplication()
            {
                Brand = "Dreamhost",
                ServiceName = "Virtual Private Servers",
                CompanyURL = "http://www.dreamhost.com/",
                Description = "Virtual Private Servers from DreamHost give you the power, stability, and control you need to successfully run your website or application. If you’re a business experiencing heavy traffic to your site or a software developer running a complex web application, downtime is not an option. VPS hosting provides an uncompromising level of performance that you'll need for total peace of mind. Dreamhost have built virtual private servers that can stand up to the unique demands of a MySQL database. Database-intensive apps would do very well with one of these on the backend! Perfect for businesses, e-commerce and developers and scalable up to 4GB of RAM with unlimited storage and unlimited bandwidth, you only pay for what you use.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    //repository.FindFeatureByName("Email Accounts"),
                    repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    //repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 15M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("DREAMHOST"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 16384;
            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 16384;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Gradwell Cloud

            ca = new CloudApplication()
            {
                Brand = "Gradwell Cloud",
                ServiceName = "Gradwell Hosting",
                CompanyURL = "http://www.gradwell.co.uk/",
                Description = "Gradwell Cloud Hosting offers three level of services depending on requirements and is perfect for companies wishing to build their website from scratch. Alongside generous webspace, bandwidth and email accounts, every hosting package comes with Gradwell’s unique website builder that can manage favicons, site logo, advertisements, embedded video, image gallery, site search, social integration, blog and even multi-lingual development. More than just hosting Gradwell Cloud combines all your website needs in one convenient package.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(200),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
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
                    //repository.FindBrowserByName("OPERA"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Number of Websites"),
                    repository.FindFeatureByName("SQL Databases"),
                    repository.FindFeatureByName("Bandwidth", categoryID),
                    repository.FindFeatureByName("Storage", categoryID),
                    repository.FindFeatureByName("Website Sub Domains"),
                    repository.FindFeatureByName("Email Accounts"),
                    //repository.FindFeatureByName("Virtual Data Centre Services"),
                    //repository.FindFeatureByName("Wesbite Security (SSL Certificate)"),
                    //repository.FindFeatureByName("Site Analytics & Reporting"),
                    repository.FindFeatureByName("Web Tool Integration"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Web Apps Library (Widgets)"),
                    repository.FindFeatureByName("eCommerce"),
                    repository.FindFeatureByName("Programming Tools"),
                    repository.FindFeatureByName("Mobile Website"),
                    repository.FindFeatureByName("Uptime Guarantee", categoryID),
                },
                ApplicationCostPerMonthFrom = 6.8M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HOSTING"),
                Vendor = repository.FindVendorByName("GRADWELL CLOUD"),
                AddDate = DateTime.Now,

            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Number of Websites".ToUpper())).Count = 2;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("SQL Databases".ToUpper())).Count = 5;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Bandwidth".ToUpper())).CountSuffix = "TB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).Count = 5;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Storage".ToUpper())).CountSuffix = "GB";

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Website Sub Domains".ToUpper())).Count = 16384;

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Email Accounts".ToUpper())).Count = 100;

            //ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("eCommerce".ToUpper())).IsOptional = true;

            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished Hosting");
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

        #region PumpEgnyteLogo
        public static bool PumpEgnyteLogo(QueryRepository repository)
        {
            bool retVal = true;
            Vendor v = new Vendor()
            {
                VendorName = "EGNYTE",
                VendorLogoFileName = "Egnyte.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\carbonite logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//New Logos//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\New Logos\\Egnyte.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            return retVal;
        }

        #endregion

        #region PumpEgnyte
        public static bool PumpEgnyte(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("STORAGE AND BACKUP").CategoryID;

            #region EGNYTE
            ca = new CloudApplication()
            {
                Brand = "Egnyte",
                ServiceName = "Egnyte",
                CompanyURL = "www.egnyte.com",
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
                    repository.FindOperatingSystemByName("ANDROID"),
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
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
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                PayAsYouGo = true,
                //ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerMonthFrom = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,


                //ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerAnnumFrom = 8.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                Vendor = repository.FindVendorByName("Egnyte"),
                Description = "Egnyte provides File Sharing for Enterprise. Access and Share files from anywhere, using any smartphone, tablet, or computer. Control where files are stored, with the speed of local storage and the simplicity of the cloud. Attain complete security and visibility with centralized administration, audit reporting and user permissioning. Sync with any existing storage system, allowing mobile access beyond the firewall, without the need for VPN or FTP servers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1015589,
                TwitterName = "Egnyte",
                FacebookName = "Egnyte",
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

        #region PumpEgnyteBusiness
        public static bool PumpEgnyteBusiness(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("STORAGE AND BACKUP").CategoryID;

            #region EGNYTE BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Egnyte",
                ServiceName = "Egnyte Business",
                CompanyURL = "www.egnyte.com",
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
                    repository.FindOperatingSystemByName("ANDROID"),
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
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
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                PayAsYouGo = true,
                //ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerMonthFrom = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,


                //ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerAnnumFrom = 8.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                Vendor = repository.FindVendorByName("Egnyte"),
                Description = "Egnyte provides File Sharing for Enterprise. Access and Share files from anywhere, using any smartphone, tablet, or computer. Control where files are stored, with the speed of local storage and the simplicity of the cloud. Attain complete security and visibility with centralized administration, audit reporting and user permissioning. Sync with any existing storage system, allowing mobile access beyond the firewall, without the need for VPN or FTP servers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1015589,
                TwitterName = "Egnyte",
                FacebookName = "Egnyte",
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

        #region PumpEgnyteEnterprise
        public static bool PumpEgnyteEnterprise(QueryRepository repository)
        {
            bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("STORAGE AND BACKUP").CategoryID;

            #region EGNYTE ENTERPRISE
            ca = new CloudApplication()
            {
                Brand = "Egnyte",
                ServiceName = "Egnyte Enterprise",
                CompanyURL = "www.egnyte.com",
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
                    repository.FindOperatingSystemByName("ANDROID"),
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
                    repository.FindBrowserByName("OPERA"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(99),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
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
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                PayAsYouGo = true,
                //ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerMonthFrom = 9.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,


                //ApplicationCostPerAnnum = 0.00M,
                ApplicationCostPerAnnumFrom = 8.00M,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                //CallsPackageCostPerMonth = 0M,
                CloudApplicationCurrency = repository.GetCurrencyBySymbol("$"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("NO"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                Vendor = repository.FindVendorByName("Egnyte"),
                Description = "Egnyte provides File Sharing for Enterprise. Access and Share files from anywhere, using any smartphone, tablet, or computer. Control where files are stored, with the speed of local storage and the simplicity of the cloud. Attain complete security and visibility with centralized administration, audit reporting and user permissioning. Sync with any existing storage system, allowing mobile access beyond the firewall, without the need for VPN or FTP servers.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 1015589,
                TwitterName = "Egnyte",
                FacebookName = "Egnyte",
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


                #region PumpCarboniteBusinessPlus
        public static CloudApplication PumpCarboniteBusinessPlus(QueryRepository repository)
        {
            //bool retVal = true;
            CloudApplication ca;
            int categoryID = repository.FindCategoryByName("STORAGE AND BACKUP").CategoryID;

        #region CARBONITE BUSINESS PLUS
            ca = new CloudApplication()
            {
                Brand = "CARBONITE",
                ServiceName = "Business Plus",
                CompanyURL = "www.carbonite.co.uk",
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
                //    //repository.FindMobilePlatformByName("ANDROID"),
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT",categoryID),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS",categoryID),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE",categoryID),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 229.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NO"),
                MinimumContract = repository.FindMinimumContractByName("12"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                Vendor = repository.FindVendorByName("CARBONITE"),
                Description = "At Carbonite, we understand how much of your life is on your computer. That's why we want to make it as easy as possible to back it up. We also understand that the only reason you back things up is so you can get them back when you need them. That's why we've focused on making our restore process as simple and hassle-free as possible.",
                AddDate = DateTime.Now,
                LinkedInCompanyID = 80260,
                TwitterName = "CARBONITE",
                FacebookName = "CarboniteOnlineBackup",
                BuyURL = "www.amazon.co.uk",
                TryURL = "www.bbc.co.uk",
            };

            //InsertDocumentLinks(repository, ca);
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).Count = 250M;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("STORAGE LIMIT")).CountSuffix = "GB";
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE LIMIT")).Count = 4;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("INDIVIDUAL FILE LIMIT")).CountSuffix = "GB";
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);


            #endregion

            return ca;

        }
                #endregion

    }
}
