using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class BusinessAndOperationsProductionData
    {

        public static bool PumpBusinessAndOperationsData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("BUSINESS AND OPERATIONS").CategoryID;

            #region APPLICATIONS

            #region BUSINESS AND OPERATIONS

            #region Deputy Starter

            ca = new CloudApplication()
            {
                Brand = "Deputy",
                ServiceName = "Starter",
                CompanyURL = "http://www.deputy.com/pricing/",
                Description = "Easy employee scheduling & workforce management software in the cloud. Deputy is so much more than just a rostering tool. We've solved the everyday problems involved in running a business. Keep track of when and where your people work - timesheets are created automatically when employees start and end their shifts. Also, Deputy integrates with the payroll provider you already use - and keeps employees in the loop with fast and easy announcements.",
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
                    repository.FindOperatingSystemByName("ANDROID"),
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
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = 24.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("Deputy"),
                AddDate = DateTime.Now,
                TryURL = "http://www.deputy.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Deputy Premium

            ca = new CloudApplication()
            {
                Brand = "Deputy",
                ServiceName = "Premium",
                CompanyURL = "http://www.deputy.com/pricing/",
                Description = "Deputy Premium is our best value service, with no restrictions on employees and locations. Easy employee scheduling & workforce management software in the Cloud. Deputy is so much more than just a rostering tool. We've solved the everyday problems involved in running a business",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 4.00M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("Deputy"),
                AddDate = DateTime.Now,
                TryURL = "http://www.deputy.com/pricing/",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Deputy Flexi

            ca = new CloudApplication()
            {
                Brand = "Deputy",
                ServiceName = "Flexi",
                CompanyURL = "http://www.deputy.com/pricing/",
                Description = "Deputy Flexi is ideal for seasonal, catering and event companies and has no restrictions on employees and locations. You can even keep occassional staff on the platform. Deputy enables easy employee scheduling & workforce management software in the cloud. Deputy is so much more than just a rostering tool. We've solved the everyday problems involved in running a business. ",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 8.00M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("Deputy"),
                AddDate = DateTime.Now,
                TryURL = "http://www.deputy.com/pricing/",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Liveplan Standard

            ca = new CloudApplication()
            {
                Brand = "Liveplan",
                ServiceName = "Standard",
                CompanyURL = "http://www.liveplan.com/pricing",
                Description = "LivePlan simplifies business planning, budgeting, forecasting, and performance tracking for small businesses and startups. Set business goals, compare performance to industry benchmarks, and see all your key numbers in an easy-to-use dashboard so you know exactly what's going on in your business. ",
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
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = true,
                SupportHours = repository.FindSupportHoursByName("8am-5pm"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("PST"),
                SupportDays = repository.FindSupportDaysByName("Mon-Fri"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 19.95M,
                ApplicationCostPerAnnum = 139.92M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("Liveplan"),
                AddDate = DateTime.Now,
                TryURL = "http://www.liveplan.com/pricing",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Megaventory Starter

            ca = new CloudApplication()
            {
                Brand = "Megaventory",
                ServiceName = "Starter",
                CompanyURL = "https://www.megaventory.com/?pricing-plans=1",
                Description = "Megaventory Starter will revolutionse the way you do business! Sign-up to our single-user cloud platform and solve your sales, purchasing and inventory management headaches. Not all businesses have the tools to create reports that instantly help the decision makers. Megaventory can generate amazing inventory reports that are simple and make sense to everyone! If your business is operating in multiple locations, things won't get messy with us. Megaventory seamlessly supports multiple locations and users under the same cloud platform. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 9.90M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("MEGAVENTORY"),
                AddDate = DateTime.Now,
                TryURL = "https://www.megaventory.com/?pricing-plans=1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Megaventory Business

            ca = new CloudApplication()
            {
                Brand = "Megaventory",
                ServiceName = "Business",
                CompanyURL = "https://www.megaventory.com/?pricing-plans=1",
                Description = "Megaventory Business caters for more users and locations - together with increased  product codes. It will revolutionise the way you do business! Sign-up to our multiuser cloud platform and solve your sales, purchasing and inventory management headaches. Not all businesses have the tools to create reports that instantly help the decision makers. Megaventory can generate amazing inventory reports that are simple and make sense to everyone! If your business is operating in multiple locations, things won't get messy with us. Megaventory seamlessly supports multiple locations and users under the same cloud platform. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 49.90M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("MEGAVENTORY"),
                AddDate = DateTime.Now,
                TryURL = "https://www.megaventory.com/?pricing-plans=1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Megaventory Corporate

            ca = new CloudApplication()
            {
                Brand = "Megaventory",
                ServiceName = "Corporate",
                CompanyURL = "https://www.megaventory.com/?pricing-plans=1",
                Description = "Megaventory Corporate is great for multi-locations and teams - together with the most extensive range of product codes. It will transform the way you do business! Sign-up to our multiuser cloud platform and solve your sales, purchasing and inventory management headaches. Not all businesses have the tools to create reports that instantly help the decision makers. Megaventory can generate amazing inventory reports that are simple and make sense to everyone! ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 99.90M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("MEGAVENTORY"),
                AddDate = DateTime.Now,
                TryURL = "https://www.megaventory.com/?pricing-plans=1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Timely Solo

            ca = new CloudApplication()
            {
                Brand = "Timely",
                ServiceName = "Solo",
                CompanyURL = "http://www.gettimely.com/pricing",
                Description = "Use Timely Solo to start to take control of your business. Once you're set up you can immediately start managing your bookings. Timely is packed with great features to save you time and help grow your client base. You are in full control, with a range of easy-to-follow settings that allow you to configure Timely to fit your business.  ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 15.00M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TIMELY"),
                AddDate = DateTime.Now,
                TryURL = "http://www.gettimely.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Timely Team

            ca = new CloudApplication()
            {
                Brand = "Timely",
                ServiceName = "Team",
                CompanyURL = "http://www.gettimely.com/pricing",
                Description = "Timely Team is great for businesses with mutliple users. Use Team to take control of your business. Once you're set up you can immediately start managing your bookings. Timely is packed with great features to save you time and help grow your client base. You are in full control, with a range of easy-to-follow settings that allow you to configure Timely to fit your business. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = 15.00M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                ApplicationCostPerMonthFrom = 20.00M,
                ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TIMELY"),
                AddDate = DateTime.Now,
                TryURL = "http://www.gettimely.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Timely Unlimited

            ca = new CloudApplication()
            {
                Brand = "Timely",
                ServiceName = "Unlimited",
                CompanyURL = "http://www.gettimely.com/pricing",
                Description = "Timely Unlinited is ideal for organisations that have many staff that rely on appointments and bookings. Use Timely Unlimited to take control of your business. Once you're set up you can immediately start managing your bookings. Timely is packed with great features to save you time and help grow your client base. You are in full control, with a range of easy-to-follow settings that allow you to configure Timely to fit your business. ",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 60.00M,
                //ApplicationCostPerAnnum = 59.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TIMELY"),
                AddDate = DateTime.Now,
                TryURL = "http://www.gettimely.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Tradegecko Hobbyist

            ca = new CloudApplication()
            {
                Brand = "Tradegecko",
                ServiceName = "Hobbyist",
                CompanyURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
                Description = "At TradeGecko we’re building the #1 inventory and order management platform for the wholesale and retail industry. Our mission is to connect the world’s supply chain.TradeGecko Hobbyist is a great starter service and is ideal for businesses requiring just a few users.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
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
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 468.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TRADEGECKO"),
                AddDate = DateTime.Now,
                TryURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Tradegecko Small Business

            ca = new CloudApplication()
            {
                Brand = "Tradegecko",
                ServiceName = "Small Business",
                CompanyURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
                Description = "TradeGecko Small Business is ideal for organisations requiring a handful of users and support for multi-currency and warehouse facilities. At TradeGecko we make boring business software history and help our customers become way more awesome. Our customers are delighted with our beautiful business software, and we are always there to help them succeed through our expertise and the facilitation of knowledge exchange between themselves.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerAnnum = 948.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TRADEGECKO"),
                AddDate = DateTime.Now,
                TryURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Tradegecko Business

            ca = new CloudApplication()
            {
                Brand = "Tradegecko",
                ServiceName = "Business",
                CompanyURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
                Description = "TradeGecko Business is our most popular level of service - providing a rich set of features and functionality for a low monthly price. TradeGecko are building the #1 inventory and order management platform for the wholesale and retail industry. Our mission is to connect the world’s supply chain. We are not just another cloud-based software vendor, instead we are a real partner for customers who are serious about business.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 199.00M,
                ApplicationCostPerAnnum = 2028.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TRADEGECKO"),
                AddDate = DateTime.Now,
                TryURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Tradegecko Business Premium

            ca = new CloudApplication()
            {
                Brand = "Tradegecko",
                ServiceName = "Business Premium",
                CompanyURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
                Description = "TradeGecko Business Premium addresses the needs of the most demanding user -across mutliple currencies and warehouses.  TradeGeck are building the #1 inventory and order management platform for the wholesale and retail industry. Our mission is to connect the world’s supply chain. We make boring business software history and help our customers become way more awesome. Our customers are delighted with our beautiful business software, and we are always there to help them succeed through our expertise and the facilitation of knowledge exchange between themselves. We are not just another cloud-based software vendor, instead we are a real partner for our customers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 399.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("TRADEGECKO"),
                AddDate = DateTime.Now,
                TryURL = "http://tradegecko.com/pricing/?_ga=1.126407949.1457280302.1413843153",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workflowmax 1user

            ca = new CloudApplication()
            {
                Brand = "Workflomax",
                ServiceName = "1user",
                CompanyURL = "http://www.workflowmax.com/pricing",
                Description = "WorkFlowMax provide end-to-end project management software for businesses of all sizes. WorkflowMax’s software contains everything you need to manage your business workflow — in one integrated platform.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(2),
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
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKFLOWMAX"),
                AddDate = DateTime.Now,
                TryURL = "http://www.workflowmax.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workflowmax 3 users

            ca = new CloudApplication()
            {
                Brand = "Workflomax",
                ServiceName = "3 users",
                CompanyURL = "http://www.workflowmax.com/pricing",
                Description = "If you have a service business or you bill based on time, then WorkflowMax is right for you. It's as simple as that. Creative agencies, architects, engineering firms, builders, construction firms, fabricators, consultants and IT companies are some of our common customers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(3),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
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
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKFLOWMAX"),
                AddDate = DateTime.Now,
                TryURL = "http://www.workflowmax.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workflowmax 10 user

            ca = new CloudApplication()
            {
                Brand = "Workflomax",
                ServiceName = "10 user",
                CompanyURL = "http://www.workflowmax.com/pricing",
                Description = "WorkFlowMax is great for growing project-bsed consulting businesses such as creative agencies, architects, engineering firms, builders, construction firms, fabricators, consultants and IT companies If you have a service business or if you bill based on time, then WorkflowMax is right for you. It's as simple as that. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(19),
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
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKFLOWMAX"),
                AddDate = DateTime.Now,
                TryURL = "http://www.workflowmax.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workflowmax 20 user

            ca = new CloudApplication()
            {
                Brand = "Workflomax",
                ServiceName = "20 user",
                CompanyURL = "http://www.workflowmax.com/pricing",
                Description = "WorkFlowMax can cope with larger project teams with distributed wokers. It is great for growing project-based consulting businesses such as creative agencies, architects, engineering firms, builders, construction firms, fabricators, consultants and IT companies. If you have a service business or you bill based on time, then WorkflowMax is right for you. It's as simple as that. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(20),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 69.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKFLOWMAX"),
                AddDate = DateTime.Now,
                TryURL = "http://www.workflowmax.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workflowmax Unlilimted

            ca = new CloudApplication()
            {
                Brand = "Workflomax",
                ServiceName = "Unlimited",
                CompanyURL = "http://www.workflowmax.com/pricing",
                Description = "WorkFlowMax can cope with the largest project teams with distributed wokers.  If you have a service business or you bill based on time, then WorkflowMax is right for you. It's as simple as that. Also, it's easy to upgrade to WorkflowMax Premium, which includes additional KPI and Productivity dashboards, and the ability to import invoices directly from Xero.",
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
                    //repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 99.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKFLOWMAX"),
                AddDate = DateTime.Now,
                TryURL = "http://www.workflowmax.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BrightPearl Starter

            ca = new CloudApplication()
            {
                Brand = "BrightPearl",
                ServiceName = "Starter",
                CompanyURL = "https://www.brightpearl.com/pricing",
                Description = "Brightpearl helps retailers accelerate  growth and profits - integrating all your orders, inventory, accounting, customer data and reporting. Minimise admin time and reduce errors - with real-time automatic syncing-across orders, inventory, customer data and accounting. Get real-time visibility into your business with clear, easy to use reports that show where you're making money by SKU, channel and customer.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 199.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("BRIGHTPEARL"),
                AddDate = DateTime.Now,
                TryURL = "https://www.brightpearl.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BrightPearl Business

            ca = new CloudApplication()
            {
                Brand = "BrightPearl",
                ServiceName = "Business",
                CompanyURL = "https://www.brightpearl.com/pricing",
                Description = "Brightpearl Business is ideal for businesses with more users, SKUs and monthly orders. It helps retailers accelerate  growth and profits - getting all your orders, inventory, accounting, customer data and reporting together in one place. Minimise admin time and reduce errors - with real-time automatic syncing-across orders, inventory, customer data and accounting. Get real-time visibility into your business with clear, easy to use reports that show where you're making money by SKU, channel and customer.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 299.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("BRIGHTPEARL"),
                AddDate = DateTime.Now,
                TryURL = "https://www.brightpearl.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region BrightPearl Professional

            ca = new CloudApplication()
            {
                Brand = "BrightPearl",
                ServiceName = "Professional",
                CompanyURL = "https://www.brightpearl.com/pricing",
                Description = "Brightpearl Professional is the perfect solution for retailers with larger portfolios, staff numbers and monthly transactions. It helps retailers accelerate  growth and profits - getting all your orders, inventory, accounting, customer data and reporting together in one place. Minimise admin time and reduce errors - with real-time automatic syncing-across orders, inventory, customer data and accounting. Get real-time visibility into your business with clear, easy to use reports that show where you're making money by SKU, channel and customer.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 499.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("BRIGHTPEARL"),
                AddDate = DateTime.Now,
                TryURL = "https://www.brightpearl.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region DocuSign Individual

            ca = new CloudApplication()
            {
                Brand = "DocuSign",
                ServiceName = "Individual",
                CompanyURL = "https://www.docusign.co.uk/products-and-pricing",
                Description = "DocuSign is an eSignature solution that lets you automate entire workflows so that transactions move at the speed of digital. Everyone has full visibility into the status of the document and all completed documents remain securely stored and readily retrievable. DocuSign will help you accelerate sales, reduce your costs, and delight your customers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 7.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("DOCUSIGN"),
                AddDate = DateTime.Now,
                TryURL = "https://www.docusign.co.uk/products-and-pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region DocuSign Professional

            ca = new CloudApplication()
            {
                Brand = "DocuSign",
                ServiceName = "Professional",
                CompanyURL = "https://www.docusign.co.uk/products-and-pricing",
                Description = "DocuSign Professional is great for users who want to send unlimited documents with company branded. It's an electronic signature application that  lets you automate entire workflows so that transactions move at the speed of digital. Everyone has full visibility into the status of the document and all completed documents remain securely stored and readily retrievable. DocuSign will help you accelerate sales, reduce your costs, and delight your customers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 14.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("DOCUSIGN"),
                AddDate = DateTime.Now,
                TryURL = "https://www.docusign.co.uk/products-and-pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region DocuSign Business

            ca = new CloudApplication()
            {
                Brand = "DocuSign",
                ServiceName = "Business",
                CompanyURL = "https://www.docusign.co.uk/products-and-pricing",
                Description = "DocuSign Business is great for organisations with more demanding eSignature and eContract requirements - including signer authentication and data validation, It lets you automate entire workflows so that transactions move at the speed of digital. Everyone has full visibility into the status of the document and all completed documents remain securely stored and readily retrievable. DocuSign will help you accelerate sales, reduce your costs, and delight your customers.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 4188.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("DOCUSIGN"),
                AddDate = DateTime.Now,
                TryURL = "https://www.docusign.co.uk/products-and-pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OpenBravo Professional

            ca = new CloudApplication()
            {
                Brand = "OpenBravo",
                ServiceName = "Professional",
                CompanyURL = "http://www.openbravo.com/retailers/editions-and-pricing/",
                Description = "The Professional Edition is a great way for clients to start benefitting from the Openbravo Commerce Platform - with a limited number of users and terminals.The Professional Edition comes with standard support and maintenance included and gives access to commercial functionality including Retail Analytics.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(5),
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
                    repository.FindBrowserByName("IE7"),
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
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 4500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                SetupFee = repository.FindSetupFeeByName("NO"),

                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("OPENBRAVO"),
                AddDate = DateTime.Now,
                TryURL = "http://www.openbravo.com/retailers/editions-and-pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OpenBravo Enterprise

            ca = new CloudApplication()
            {
                Brand = "OpenBravo",
                ServiceName = "Enterprise",
                CompanyURL = "http://www.openbravo.com/retailers/editions-and-pricing/",
                Description = "The Enterprise Edition is preferred by most of our mid-sized and larger clients that require a substantial number of users and terminals.The Enterprise Edition is best for client competitiveness today and tomorrow, thanks to the inclusion of our most advanced features, such as Casual or Portal users, Retail Analytics, more services and the highest level of support.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                    repository.FindBrowserByName("IE7"),
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
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 19500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("EUR"),
                SetupFee = repository.FindSetupFeeByName("NO"),

                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("OPENBRAVO"),
                AddDate = DateTime.Now,
                TryURL = "http://www.openbravo.com/retailers/editions-and-pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SignNow Solo

            ca = new CloudApplication()
            {
                Brand = "SignNow",
                ServiceName = "Solo",
                CompanyURL = "https://www.signnow.com/pricing",
                Description = "Ditch the printer, scanner, and fax. SignNow eSignature software cuts document turnaround time by as much as 90%. Get legally binding signatures from your customer, partners, and employees in seconds using any device. You will save countless hours, get deals done faster, and help the environment. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 18.00M,
                ApplicationCostPerAnnum = 19500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("SIGNNOW"),
                AddDate = DateTime.Now,
                TryURL = "https://www.signnow.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SignNow 10 user

            ca = new CloudApplication()
            {
                Brand = "SignNow",
                ServiceName = "10 user",
                CompanyURL = "https://www.signnow.com/pricing",
                Description = "With SignNow, you never need to search for a paper agreement again. Your documents are stored in a secure cloud. SignNow gives you control over your document workflows and lets you easily integrate signed documents with other electronic systems",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 99.96M,
                ApplicationCostPerAnnum = 19500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("SIGNNOW"),
                AddDate = DateTime.Now,
                TryURL = "https://www.signnow.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SignNow 30 user

            ca = new CloudApplication()
            {
                Brand = "SignNow",
                ServiceName = "30 user",
                CompanyURL = "https://www.signnow.com/pricing",
                Description = "SignNow gives you control over your document workflows and lets you easily integrate signed documents with other electronic systems. SignNow cuts document turnaround time by as much as 90%. Get legally binding signatures from your customer, partners, and employees in seconds using any device. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(30),
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
                    //repository.FindBrowserByName("IE8"),
                    //repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 83.28M,
                ApplicationCostPerAnnum = 19500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),              
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("SIGNNOW"),
                AddDate = DateTime.Now,
                TryURL = "https://www.signnow.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Workday Financials

            ca = new CloudApplication()
            {
                Brand = "Workday",
                ServiceName = "Financials",
                CompanyURL = "https://forms.workday.com/uk/landing_page/product_preview_uk_financial_management_overview_lp.php?camp=70180000000p6X7",
                Description = "Empower your organisation with a full range of financial capabilities, relevant analytics and metrics - and fully auditable process management. Get detailed drill-down analysis through multiple dimensions for quicker and more informative insights. Discover how unified process controls and security can help ensure proper regulatory compliance, such as separation of duties and data privacy. Achieve instant global consolidation across multiple entities and currencies without a multi-step consolidation process. ",
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
                    repository.FindOperatingSystemByName("ANDROID"),
                    //repository.FindOperatingSystemByName("BBOS"),
                },
                Browsers = new List<Browser>()
                {
                    //repository.FindBrowserByName("IE6"),
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = true,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    repository.FindFeatureByName("Inventory management"),
                    repository.FindFeatureByName("Invoice management"),
                    repository.FindFeatureByName("Order management"),
                    repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerAnnum = 19500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("POA"),

                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("WORKDAY"),
                AddDate = DateTime.Now,
                TryURL = "https://forms.workday.com/uk/landing_page/product_preview_uk_financial_management_overview_lp.php?camp=70180000000p6X7",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZenDesk Starter

            ca = new CloudApplication()
            {
                Brand = "ZenDesk",
                ServiceName = "Starter",
                CompanyURL = "https://www.zendesk.com/product/pricing",
                Description = "Zendesk streamlines your online helpdesk support with time-saving tools like ticket views, triggers, and automations. This helps you get straight to what matters most — better customer service and more meaningful conversations.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 2.00M,
                ApplicationCostPerAnnum = 12.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ZENDESK"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zendesk.com/product/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZenDesk Regular

            ca = new CloudApplication()
            {
                Brand = "ZenDesk",
                ServiceName = "Regular",
                CompanyURL = "https://www.zendesk.com/product/pricing",
                Description = "Zendesk Regular takes helpdesk support to the next level with satisfaction surveys and custom domains. Zendesk streamlines your support with time-saving tools like ticket views, triggers, and automations. This helps you get straight to what matters most — better customer service and more meaningful conversations.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 300.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ZENDESK"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zendesk.com/product/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZenDesk Plus

            ca = new CloudApplication()
            {
                Brand = "ZenDesk",
                ServiceName = "Plus",
                CompanyURL = "https://www.zendesk.com/product/pricing",
                Description = "Zendesk streamlines your online support with time-saving tools like ticket views, triggers, and automations. With Zendesk Plus, users benefit from custom reports, time trackingand an internal knowledge.  This helps you get straight to what matters most — better customer service and more meaningful conversations.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(20),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 59.00M,
                ApplicationCostPerAnnum = 588.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ZENDESK"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zendesk.com/product/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region ZenDesk Enterprise

            ca = new CloudApplication()
            {
                Brand = "ZenDesk",
                ServiceName = "Enterprise",
                CompanyURL = "https://www.zendesk.com/product/pricing",
                Description = "Zendesk Enterprise is for environments that require more sophisticated functionality and technical support. Zendesk streamlines your customer service support with time-saving tools like ticket views, triggers, and automations. This helps you get straight to what matters most — better customer service and more meaningful conversations.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(50),
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 139.00M,
                ApplicationCostPerAnnum = 1500.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ZENDESK"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zendesk.com/product/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Freshdesk Blossom

            ca = new CloudApplication()
            {
                Brand = "Freshdesk",
                ServiceName = "Blossom",
                CompanyURL = "http://freshdesk.com/signup",
                Description = "Freshdesk is a cloud-based customer support platform that was founded to enable companies of all sizes to provide great customer service.  Freshdesk makes it simple and easy for brands to talk to their customers and make it easy for users to get in touch with businesses",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 192.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("FRESHDESK"),
                AddDate = DateTime.Now,
                TryURL = "http://freshdesk.com/signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Freshdesk Garden

            ca = new CloudApplication()
            {
                Brand = "Freshdesk",
                ServiceName = "Garden",
                CompanyURL = "http://freshdesk.com/signup",
                Description = "Freshdesk Garden provides support for multiple locations and  products - complete with live chat. It's a cloud-based customer support platform that was founded to enable companies of all sizes to provide great customer service.  Freshdesk makes it simple and easy for brands to talk to their customers and make it easy for users to get in touch with businesses. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 300.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("FRESHDESK"),
                AddDate = DateTime.Now,
                TryURL = "http://freshdesk.com/signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Freshdesk Estate

            ca = new CloudApplication()
            {
                Brand = "Freshdesk",
                ServiceName = "Estate",
                CompanyURL = "http://freshdesk.com/signup",
                Description = "Freshdesk Estate provides enterprise grade reporting, portal customisation and agent reports. Freshdesk is a cloud-based customer support platform that was founded to enable companies of all sizes to provide great customer service.  Freshdesk makes it simple and easy for brands to talk to their customers and make it easy for users to get in touch with businesses. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 480.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("FRESHDESK"),
                AddDate = DateTime.Now,
                TryURL = "http://freshdesk.com/signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Freshdesk Forest

            ca = new CloudApplication()
            {
                Brand = "Freshdesk",
                ServiceName = "Forest",
                CompanyURL = "http://freshdesk.com/signup",
                Description = "Freshdesk Forest is ideal for organisations looking for enhanced functionality such as IP whitelisting and custom email servers. Freshdesk is a cloud-based customer support platform that was founded to enable companies of all sizes to provide great customer service.  Freshdesk makes it simple and easy for brands to talk to their customers and make it easy for users to get in touch with businesses. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(4),
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
                    repository.FindBrowserByName("IE7"),
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
                    repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonth = 79.00M,
                ApplicationCostPerAnnum = 840.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("FRESHDESK"),
                AddDate = DateTime.Now,
                TryURL = "http://freshdesk.com/signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Frontrange Heat Cloud

            ca = new CloudApplication()
            {
                Brand = "Frontrange",
                ServiceName = "Heat Cloud",
                CompanyURL = "http://pages.frontrange.com/Cloud-Service-Management-Trial.html",
                Description = "HEAT Cloud Help Desk integrates core service and support components into one complete help desk solution to reduce costs and increase operational efficiency. The solution is designed for organisations of all sizes, and one which can support all types of help desk needs. The end-to-end support that HEAT Cloud Help Desk delivers to an organization helps manage service issues from the initial call, too completed work orders and service restoration. Leverage this configurable help desk solution to improve service productivity and extend your business beyond basic IT support. ",
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
                    repository.FindBrowserByName("IE7"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    repository.FindFeatureByName("Field service management"),
                    repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerAnnum = 840.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("FRONTRANGE"),
                AddDate = DateTime.Now,
                TryURL = "http://pages.frontrange.com/Cloud-Service-Management-Trial.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Stratpad Startup

            ca = new CloudApplication()
            {
                Brand = "Stratpad",
                ServiceName = "Startup",
                CompanyURL = "https://cloud.stratpad.com/index.html#signup",
                Description = "StratPad Starter is the perfect option for startups and students. It's a cloud-based business planning software that can run on the browser of virtually any laptop or desktop. StratPad asks you the important questions about your business and creates all the necessary financial statements using a few simple numbers. ",
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
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = false,
                ApplicationCostPerAnnum = 36.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("STRATPAD"),
                AddDate = DateTime.Now,
                TryURL = "https://cloud.stratpad.com/index.html#signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Stratpad Business

            ca = new CloudApplication()
            {
                Brand = "Stratpad",
                ServiceName = "Business",
                CompanyURL = "https://cloud.stratpad.com/index.html#signup",
                Description = "StratPad Business is the preferred option for individuals and organisations looking to produce multiple plans. It cuts through the complexity, providing a step-by-step approach that’s simple and practical for small businesses and startups. By the time you’re done you’ll have a full business plan, ready to take to a banker or an investor or just to help you stay on track.",
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
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Business performance reporting"),
                    repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    //repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = false,
                ApplicationCostPerAnnum = 99.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("STRATPAD"),
                AddDate = DateTime.Now,
                TryURL = "https://cloud.stratpad.com/index.html#signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Stratpad Unlimited

            ca = new CloudApplication()
            {
                Brand = "Stratpad",
                ServiceName = "Unlimited",
                CompanyURL = "https://cloud.stratpad.com/index.html#signup",
                Description = "StratPad Unlimited is for consulting professionals and organisations that have power-user requirements for business planning tools.  It's a cloud-based business planning software that can run on the browser of virtually any laptop or desktop.StratPad Unlimited asks you the important questions about your business and creates all the necessary financial statements using a few simple numbers.",
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
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = false,
                ApplicationCostPerAnnum = 179.00M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("STRATPAD"),
                AddDate = DateTime.Now,
                TryURL = "https://cloud.stratpad.com/index.html#signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe EchoSign Pro

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "EchoSign Pro",
                CompanyURL = "https://www.echosign.adobe.com/en/pricing.html?cs=mktg_topnav",
                Description = "Adobe EchoSign allows you to add e-signatures to your existing business processes. Make paper documents a thing of the past. And condense the time it takes to close business from weeks to minutes with EchoSign — the secure e-signature solution from Adobe.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    repository.FindBrowserByName("IE7"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = false,
                ApplicationCostPerAnnum = 179.40M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ADOBE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.echosign.adobe.com/en/pricing.html?cs=mktg_topnav",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe EchoSign Team

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "EchoSign Team",
                CompanyURL = "https://www.echosign.adobe.com/en/pricing.html?cs=mktg_topnav",
                Description = "Adobe EchoSign Team allows you to add e-signatures to your existing business processes - all with the benefit of your own company branding, preferences and settings. Make paper documents a thing of the past. And condense the time it takes to close business from weeks to minutes with EchoSign — the secure e-signature solution from Adobe.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(2),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(9),
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
                    repository.FindBrowserByName("IE7"),
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
                    //repository.FindLanguageByName("MALAY"),repository.FindLanguageByName("INDONESIAN"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Business performance reporting"),
                    //repository.FindFeatureByName("Business planning"),
                    //repository.FindFeatureByName("Contact management/CRM"),
                    repository.FindFeatureByName("Electronic signature"),
                    //repository.FindFeatureByName("Field service management"),
                    //repository.FindFeatureByName("Helpdesk"),
                    //repository.FindFeatureByName("Inventory management"),
                    //repository.FindFeatureByName("Invoice management"),
                    //repository.FindFeatureByName("Order management"),
                    //repository.FindFeatureByName("Purchasing management"),
                    //repository.FindFeatureByName("Quote management"),
                    //repository.FindFeatureByName("Resource scheduling"),
                    //repository.FindFeatureByName("Service dispatch"),
                    //repository.FindFeatureByName("Supply chain management"),
                    //repository.FindFeatureByName("Time & attendance"),
                },
                //ApplicationCostPerMonth = false,
                ApplicationCostPerAnnum = 239.40M,
                //ApplicationCostPerMonthFree = true,
                //ApplicationCostPerMonthFrom = 20.00M,
                //ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("BUSINESS AND OPERATIONS"),
                Vendor = repository.FindVendorByName("ADOBE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.echosign.adobe.com/en/pricing.html?cs=mktg_topnav",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            #endregion

            #endregion

            Console.WriteLine("Finished BUSINESS AND OPERATIONS");
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
