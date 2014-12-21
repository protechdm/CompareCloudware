using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class BIRProductionData
    {

        public static bool PumpBIRData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("INTELLIGENCE AND REPORTING").CategoryID;

            #region APPLICATIONS

            #region INTELLIGENCE AND REPORTING


            #region Bime Base Plan

            ca = new CloudApplication()
            {
                Brand = "Bime",
                ServiceName = "Base Plan",
                CompanyURL = "http://www.bimeanalytics.com/pricing.html",                
                Description = "We believe that business intelligence software is just too hard: too hard to use, too hard to manage, too hard to buy, and too hard to get right. So, we created BIME. an easy yet powerful service to connect to and analyse data in any organisation. We are focused on delivering a simple-to-use business intelligence product based on the latest data visualisation and ground-breaking cloud computing innovations. BIME allows you to connect to both the online and the on-premise world in the same place. Create connections to all your data sources, create and execute queries and view your dashboards easily - all within BIME's beautifully intuitive interface.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    repository.FindFeatureByName("OLAP"),
                },
                //ApplicationCostPerMonth = 65.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 490.00M,
                ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("BIME"),
                AddDate = DateTime.Now,
                TryURL = "http://www.bimeanalytics.com/pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho Reports Standard

            ca = new CloudApplication()
            {
                Brand = "Zoho",
                ServiceName = "Standard",
                CompanyURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
                Description = "Zoho Reports Standard is an online reporting and business intelligence software that helps you easily analyse your business data, and create insightful reports & dashboards for informed decision-making. It's a BI software that allows you to easily create and share powerful reports in minutes with no IT help.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    //repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                ApplicationCostPerMonth = 50.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ZOHO REPORTS"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho Reports Professional

            ca = new CloudApplication()
            {
                Brand = "Zoho",
                ServiceName = "Professional",
                CompanyURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
                Description = "Zoho Reports Professional is a step up from Zoho's Standard BI software, providing increased records, emails and users. Zoho Reports is an online reporting and business intelligence service that helps you easily analyse your business data, and create insightful reports & dashboards for informed decision-making. It's a Business Intelligence software that allows you to easily create and share powerful reports in minutes with no IT help. Professional users get greater integration with other Zoho services.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    //repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                ApplicationCostPerMonth = 90.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ZOHO REPORTS"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho Reports Professional Plus

            ca = new CloudApplication()
            {
                Brand = "Zoho",
                ServiceName = "Professional Plus",
                CompanyURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
                Description = "Zoho Reports Pofessional Plus provides an entensive range features for mutliple users requiring access to business intelligence. Zoho Reports is an online reporting and business intelligence service that helps you easily analyse your business data, and create insightful reports & dashboards for informed decision-making. It allows you to easily create and share powerful reports in minutes with no IT help. The Professonal Plus BI service provides even higher limits on emails, records and users. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    //repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                ApplicationCostPerMonth = 140.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ZOHO REPORTS"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho Reports Professional Enterprise

            ca = new CloudApplication()
            {
                Brand = "Zoho",
                ServiceName = "Enterprise",
                CompanyURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
                Description = "The Zoho Reports Enterprise service is an online reporting and business intelligence service that helps you easily analyse your business data, and create insightful reports & dashboards for informed decision-making. It provides the highest limits on users, records, emails - in additon to the most extensive integration of Zoho services.  It allows you to easily create and share powerful reports in minutes with no IT help ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(21),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    //repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ZOHO REPORTS"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/reports/zohoreports-pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Qlik QlikSense Dsktop


            ca = new CloudApplication()
            {
                Brand = "Qlik",
                ServiceName = "QlikSense Dsktop",
                CompanyURL = "http://www.qlik.com/uk/explore/products/free-download",
                Description = "Imagine an analytics tool so intuitive, anyone in your company could easily create personalised reports and dynamic dashboards to explore vast amounts of data and find meaningful insights. That’s Qlik Sense — a revolutionary self-service data visualisation and BI discovery application designed for individuals, groups and organisations. Qlik Sense lets you rapidly create visualisations, explore data deeply, reveal connections instantly, and see opportunities from every angle.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    //repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("QLIK"),
                AddDate = DateTime.Now,
                TryURL = "http://www.qlik.com/uk/explore/products/free-download",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Birst Birst


            ca = new CloudApplication()
            {
                Brand = "Birst",
                ServiceName = "Birst",
                CompanyURL = "http://www.birst.com/learn/try-birst",
                Description = "Birst delivers accurate, actionable content in an intuitive, self-service business intelligence software environment. It allows users to combine data from different source systems in a single BI platform to get answers to their most pressing business concerns in real time. And, when the questions change, it adapts quickly to the new request",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("BIRST"),
                AddDate = DateTime.Now,
                TryURL = "http://www.birst.com/learn/try-birst",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SiSense Sisense


            ca = new CloudApplication()
            {
                Brand = "Sisense",
                ServiceName = "Sisense",
                CompanyURL = "http://www.sisense.com",
                Description = "Sisense is an award-winning, full-stack Business Intelligence and Analytics software that’s leading the way into a new era of BI. Our software is creating quite a buzz for its powerful technology as Sisense is the only fully-functional Business Intelligence tool that lets non-techies join multiple large data sets, build smart dashboards with great data visualisations, and share with thousands of users. Our secret sauce is the incredible technology behind Sisense that’s designed to be used by business users, without dependence on coding, IT or data scientists. Sisense provides a centralised database on standard hardware, and serves more queries, more users, and more data than any other BI tool on the market.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    //repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("SISENSE"),
                AddDate = DateTime.Now,
                TryURL = "http://www.sisense.com/demo/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Tableau Online


            ca = new CloudApplication()
            {
                Brand = "Tableau",
                ServiceName = "Online",
                CompanyURL = "http://www.tableausoftware.com/products/online",
                Description = "Tableau Online is a hosted version of Tableau Server. It makes business intelligence faster and easier than ever before. Publish dashboards with Tableau Desktop and share them with colleagues, partners or customers. Find answers in minutes — whenever, wherever you are. Turn everyone into your best analyst with interactive dashboards in a web browser or mobile device. Comment on dashboards to share your findings. BI software subscribers get regular updates - all from a secure web platform. Start with a few users and add as many as you need, when you need them.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("TABLEAU"),
                AddDate = DateTime.Now,
                TryURL = "http://www.tableausoftware.com/products/online",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Looker Cloud BI platform



            ca = new CloudApplication()
            {
                Brand = "Looker",
                ServiceName = "Cloud BI platform",
                CompanyURL = "http://try.looker.com/free-trial",
                Description = "Looker works with your data as it is, wherever it lives, connecting directly to your entire data source rather than importing only part of it. With our business intelligence software platform you'll always be working with the complete picture, and can drill into anything of interest, all the way down to the source.The entire Looker BI platform can be distributed on our infrastructure or yours, whether that's managed on-premise or in the cloud, and is packaged in an easy to distribute fashion for fast implementation.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
                    //repository.FindOperatingSystemByName("WINDOWS 8 RT"),
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("LOOKER"),
                AddDate = DateTime.Now,
                TryURL = "http://try.looker.com/free-trial",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Roambi analytics




            ca = new CloudApplication()
            {
                Brand = "Roambi",
                ServiceName = "Analytics",
                CompanyURL = "http://roambi.com/plans-and-pricing",
                Description = "Roambi Analytics takes data from anywhere and transforms it into a simple, engaging, and intuitive experience that helps you understand your numbers - providing a great basis for business insights and intelligence. We believe phones and tablets are more than just another browser. That's why Roambi was designed and built from the ground up to put data into the hands of everyone who needs it, in the moments they need it most.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("IE10"),
                    //repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    //repository.FindFeatureByName("Ad hoc reporting"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ROAMBI"),
                AddDate = DateTime.Now,
                TryURL = "http://roambi.com/get-your-free-roambi-business-30-day-trial",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Microstrategy Cloud




            ca = new CloudApplication()
            {
                Brand = "Microstrategy",
                ServiceName = "Cloud",
                CompanyURL = "http://www.microstrategy.com/uk/platforms/cloud",
                Description = "With MicroStrategy Cloud, tapping into the benefits of world class analytics and business intelligence has never been easier. Deploy applications to thousands of users in weeks instead of years. Dramatically reduce project risks. Cut operating costs and eliminate capital expenditures. And do it without sacrificing anything in application power, performance, and customisation.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
                    repository.FindOperatingSystemByName("WIN 8"),
                    //repository.FindOperatingSystemByName("LINUX"),
                    repository.FindOperatingSystemByName("APPLE IOS"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("MICROSTRATEGY"),
                AddDate = DateTime.Now,
                TryURL = "http://www.microstrategy.com/uk/free/overview",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adaptive Insights Planning
            



            ca = new CloudApplication()
            {
                Brand = "Adaptive Insights",
                ServiceName = "Planning",
                CompanyURL = "http://www.adaptiveinsights.co.uk/products/adaptive-suite",
                Description = "Adaptive Planning offers the leading cloud-based revenue planning, budgeting and forecasting software for cash flow projection, sales planning & balance sheet forecasting. Our cash flow forecasting and sales forecasting software combines a powerful financial modeling engine with an easy-to-use, drag-and-drop interface.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Custom dashboard"),
                    //repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    repository.FindFeatureByName("Forecasting"),
                    //repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    //repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ADAPTIVE INSIGHTS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.adaptiveinsights.co.uk/services/free-trial/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adaptive Insights Consolidation




            ca = new CloudApplication()
            {
                Brand = "Adaptive Insights",
                ServiceName = "Consolidation",
                CompanyURL = "http://www.adaptiveinsights.co.uk/products/adaptive-suite",
                Description = "Adaptive Consolidation, the premier cloud-based financial consolidation software, has been built on our proven financial modeling engine, with the easy-to-use Adaptive interface. Based on simple and intuitive rule definition, allocations are performed, intercompany eliminations generated, and consolidations finalised live – no batch jobs need to be run or processes submitted. Financial consolidation and BI software enables users to drill down to explore details of consolidated figures.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Ad hoc analysis"),
                    repository.FindFeatureByName("Ad hoc query"),
                    repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Custom dashboard"),
                    //repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    //repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    //repository.FindFeatureByName("Trend indicators"),
                    //repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ADAPTIVE INSIGHTS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.adaptiveinsights.co.uk/services/free-trial/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adaptive Insights Discover




            ca = new CloudApplication()
            {
                Brand = "Adaptive Insights",
                ServiceName = "Discover",
                CompanyURL = "http://www.adaptiveinsights.co.uk/products/adaptive-suite",
                Description = "Adaptive Discovery is the only cloud dashboard software and visual analytics that’s designed for use by executives, line-of-business managers, data analysts, finance and operations. With the power to incorporate financial and operational data, actuals, budgets and forecasts, Adaptive Discovery makes it simple to create and deliver dashboards, drill down into data, and even perform what-if analysis on the fly.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    //repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    //repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ADAPTIVE INSIGHTS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.adaptiveinsights.co.uk/services/free-trial/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adaptive Insights Reporting




            ca = new CloudApplication()
            {
                Brand = "Adaptive Insights",
                ServiceName = "Reporting",
                CompanyURL = "http://www.adaptiveinsights.co.uk/products/adaptive-suite",
                Description = "With Adaptive Reporting you can manage all of your reporting needs both online and across Microsoft Office. Our drag-and-drop report builders, on the Web and in Excel, put powerful yet easy-to-use business reporting software in the hands of finance, budget managers, and executives. Fast, fun, easy to create financial reports, management reports and board reports always reflect the latest data from Adaptive Planning and Consolidation. With our robust enterprise reporting software users across the company can share and access information to make faster, more informed decisions.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(16384),
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("OSX"),
                    //repository.FindOperatingSystemByName("WIN XP"),
                    //repository.FindOperatingSystemByName("WIN VISTA"),
                    //repository.FindOperatingSystemByName("WIN 7"),
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

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY,INDONESIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Ad hoc analysis"),
                    //repository.FindFeatureByName("Ad hoc query"),
                    //repository.FindFeatureByName("Ad hoc reporting"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Custom dashboard"),
                    repository.FindFeatureByName("Custom reporting"),
                    repository.FindFeatureByName("Drag and drop visualisations"),
                    repository.FindFeatureByName("Export data to Excel"),
                    //repository.FindFeatureByName("Forecasting"),
                    repository.FindFeatureByName("Interactive dashboard/reporting"),
                    repository.FindFeatureByName("Key performance indicators"),
                    repository.FindFeatureByName("Multi source data integration"),
                    repository.FindFeatureByName("Trend indicators"),
                    repository.FindFeatureByName("Visual data presentation"),
                    //repository.FindFeatureByName("OLAP"),
                                    },
                //ApplicationCostPerMonth = 495.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,
                //ApplicationCostPerMonthFrom = 490.00M,
                //ApplicationCostPerMonthTo = 690.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("INTELLIGENCE AND REPORTING"),
                Vendor = repository.FindVendorByName("ADAPTIVE INSIGHTS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.adaptiveinsights.co.uk/services/free-trial/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished INTELLIGENCE AND REPORTING");
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
