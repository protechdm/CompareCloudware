using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class HRProductionData
    {

        public static bool PumpHrData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("HR").CategoryID;

            #region APPLICATIONS

            #region HR

            #region Breathe HR Micro

            ca = new CloudApplication()
            {
                Brand = "Breathe HR",
                ServiceName = "Micro",
                CompanyURL = "http://www.breathehr.com/",
                Description = "breatheHR is a ideal in helping very small and growing businesses reduce their HR headaches. breatheHR Micro keeps all your employee information in one central place and automates all those time consuming HR admin tasks. The cloud based breatheHR software gives you the best process for holiday tracking and sickness reporting which saves you valuable time.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("OPERA"),
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
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    //repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonth = 9.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Breathe HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.breathehr.com/hr-software-prices/",
                BuyURL = "http://www.breathehr.com/hr-software-prices/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Breathe HR Starter

            ca = new CloudApplication()
            {
                Brand = "Breathe HR",
                ServiceName = "Starter",
                CompanyURL = "http://www.breathehr.com/",
                Description = "breatheHR Starter is an HR system specifically designed to help small and growing businesses reduce their HR admin. breatheHR keeps all your employee information in one central place and automates all those time consuming HR admin tasks. The web based HR software gives you the best process for holiday approval and sickness reporting – saving you valuable time.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(20),
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
                    repository.FindBrowserByName("OPERA"),
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
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    //repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonth = 19.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Breathe HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.breathehr.com/hr-software-prices/",
                BuyURL = "http://www.breathehr.com/hr-software-prices/",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Breathe HR Regular

            ca = new CloudApplication()
            {
                Brand = "Breathe HR",
                ServiceName = "Regular ",
                CompanyURL = "http://www.breathehr.com/",
                Description = "breatheHR is designed to be simple and quick to get started so that’s why there’s no set up or implementation cost. With beatheHR Regular, your monthly price includes all the support you need to import your employee data. However if you simply don’t have time, our Concierge Service is the answer. As with all things breatheHR all processes are simple and cost effective. The three stage process will get the basics set and your data imported.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(21),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(50),
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
                    repository.FindBrowserByName("OPERA"),
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
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonth = 49.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Breathe HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.breathehr.com/hr-software-prices/",
                BuyURL = "http://www.breathehr.com/hr-software-prices/",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Breathe HR Pro

            ca = new CloudApplication()
            {
                Brand = "Breathe HR",
                ServiceName = "Pro",
                CompanyURL = "http://www.breathehr.com/",
                Description = "Small businesses need a low cost HR software system to reduce HR admin.  breatheHR has a simple & fast online setup to get you up and running really easily. breatheHR Pro enables small businesses to break through the employee ‘glass ceiling’ with effective management of tasks which may have been dealt with on multiple forms in multiple places. Stored safely in the Cloud you can have peace of mind because your data is stored securely and is always available, when and wherever you need it.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(51),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("OPERA"),
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
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonth = 99.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Breathe HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.breathehr.com/hr-software-prices/",
                BuyURL = "http://www.breathehr.com/hr-software-prices/",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region People HR Starter

            ca = new CloudApplication()
            {
                Brand = "People HR",
                ServiceName = "Starter",
                CompanyURL = "http://www.peoplehr.com/",
                Description = "People™ HR Starter covers all your HR admin essentials. With just a tap or a click, you can find and edit employee records, review and authorise holiday requests, track and tackle absences, and even discover useful insights about your workforce. Easily import or create employee records, and then customise them to perfection by adding your own unique information screens. Finding and editing staff files is easy, and you can even keep leavers on the system for future reference. Plus, you get unlimited document storage at no extra charge, meaning you can completely eliminate paper records. With 256-bit file encryption technology provides the same level of security you might expect to find in most fortune 500 companies, meaning you are in complete control over who can see and do what.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("OPERA"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonthFrom = 1.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("PEOPLE HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.peoplehr.com/price.html",
                BuyURL = "http://www.peoplehr.com/price.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region People HR Professional

            ca = new CloudApplication()
            {
                Brand = "People HR",
                ServiceName = "Professional",
                CompanyURL = "http://www.peoplehr.com/",
                Description = "With People HR Professional you can start to grow your business simply and professionally. Easily create new vacancies within People™, then advertise them on your own company website. You can add important job role information, and even ask unique questions to prompt meaningful applications from relevant candidates. People™ adds new applicants to your recruitment pipeline automatically. From here, you accept or reject candidates, add them to your talent pool, or sort them into fully-customisable categories you've created yourself. You can even send out letters and emails. And for every applicant you accept, you can go straight to the New Starter wizard to add them to People™. People™ also lets you assign different permissions to different people within your company. You can assign employees, managers and administrators using our preset permissions, or you can create your own groups to give people like Payroll Managers their own fine-tuned access rights.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("OPERA"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    //repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonthFrom = 1.40M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("PEOPLE HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.peoplehr.com/price.html",
                BuyURL = "http://www.peoplehr.com/price.html",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region People HR Enterprise

            ca = new CloudApplication()
            {
                Brand = "People HR",
                ServiceName = "Enterprise",
                CompanyURL = "http://www.peoplehr.com/",
                Description = "People HR Enterprise has all the benefits of Professional but raises the bar when it comes to performance reviews and reporting. With People HR Enterprise you can engage your entire company and launch your annual Performance Review using People™. Each employee can login and work directly with their own line manager, plus there’s the option to request peer reviews for 360° feedback. You can track progress in real-time, and even compare year-on-year progress using charts and league tables. On the reporting front People™ includes a set of compelling reports specially designed to capture attention and reveal hidden insights. You can use these impressive reports to highlight areas of focus for business growth, or even for demonstrating the year-on-year improvements you’re making for your company.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(101),
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
                    repository.FindBrowserByName("OPERA"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                ApplicationCostPerMonthFrom = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("PEOPLE HR"),
                AddDate = DateTime.Now,
                TryURL = "http://www.peoplehr.com/price.html",
                BuyURL = "http://www.peoplehr.com/price.html",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region SMB Partners

            ca = new CloudApplication()
            {
                Brand = "SMB Partners",
                ServiceName = "SMB HR",
                CompanyURL = "http://www.smb.co.uk/",
                Description = "SMB is the HR management software for small to medium-sized businesses. Think of SMB as your very own HR assistant, sending you daily notifications on important activity and prompting you when there’s a task to complete, a report to file or an updated policy document to share around the company. The software is intelligent and proactive so that you don’t need to worry about missing a deadline or overlooking an important aspect of employee management. Let SMB do the work so you can dedicate more of your valuable time to whatever it is your business does! SMB offer a simple pricing structure for all plans, regardless of the number of employees, for as low as just £1 per month per employee. That’s it. No hidden fees. No unexpected set-up costs. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 20M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("SMB PARTNERS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.smb.co.uk/pricing/",
                BuyURL = "http://www.smb.co.uk/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region You Manage

            ca = new CloudApplication()
            {
                Brand = "You Manage",
                ServiceName = "You Manage",
                CompanyURL = "http://www.youmanage.co.uk",
                Description = "You Manage is perfect for growing business in areas of high compliance. Included in all packages are updated HR documentation, guidance, policy, procedural, and educational material delivered to users at the appropriate point. With Youmanage's simple self-service interface, employees can be an active part of the HR management process. By simplifying employee self-service, You Manage has excellent cost and productivity benefits; employees can instigate and be involved in core HR functions such as absence and holiday management with ease. Highly secure, scalable and robust UK-based hosting platform, ensuring integrity and security of your data with 128-bit SSL session data encryption. Full support throughout the implementation process and during any trial period, ensuring that your system is configured to meet your organisation's specific requirements.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 9M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("YOU MANAGE"),
                AddDate = DateTime.Now,
                TryURL = "http://www.youmanage.co.uk/pricing/",
                BuyURL = "http://www.youmanage.co.uk/pricing/",
            };

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Appraisal Performance".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Expenses".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Self-Service Portal".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Recruitment".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Workforce Management".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Training & Development".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("3rd Party Integration (APIs)".ToUpper())).IsOptional = true;
            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Case Management".ToUpper())).IsOptional = true;

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region STAFF SQUARED

            ca = new CloudApplication()
            {
                Brand = "STAFF SQUARED",
                ServiceName = "STAFF SQUARED",
                CompanyURL = "http://www.staffsquared.com/pricing/",
                Description = "Staff Squared makes it easy to manage on-boarding, your employee data and files, and time off in a web based platform that is probably the most simple to use HR system ever built. You and your team will love using it, and you'll spend less time buried in paper working on HR tasks and the unique goal system will ensure you're better connected with your team than ever before. Still managing time off using spreadsheets or email? With Staff Squared managers are notified when a new time off request is submitted and can approve or reject holiday requests straight from their e-mail inbox. Best of all, Staff Squared is entirely cloud based so you can get started right away.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
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
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    //repository.FindFeatureByName("Self-Service Portal"),
                    //repository.FindFeatureByName("Document Library"),
                    //repository.FindFeatureByName("Recruitment"),
                    //repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    //repository.FindFeatureByName("Compliance, Health & Safety"),
                    //repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    //repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    //repository.FindFeatureByName("Case Management"),
                    //repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 4.5M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("STAFF SQUARED"),
                AddDate = DateTime.Now,
                TryURL = "http://www.staffsquared.com/?a=compa",
                BuyURL = "http://www.staffsquared.com/?a=compa",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region My HR Toolkit

            ca = new CloudApplication()
            {
                Brand = "My HR Toolkit",
                ServiceName = "My HR Toolkit",
                CompanyURL = "http://www.myhrtoolkit.com/pricing/",
                Description = "Specifically designed for small and medium sized businesses, myhrtoolkit online HR software streamlines your HR function with easy-to-use human resources tools. The ideal SaaS HR management system and HR software for SME’s myhrtoolkit offers business owners and HR Managers an online solution for staff management including absence and holiday management and training and appraisals. Using an online HR Software system that is tailored for the size of your business means you can save time and increase staff morale and engagement. You pay a simple monthly licence fee with no joining fee, simple monthly payment, monthly rolling contract, no tie-ins and free support to get you started.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 15M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("MY HR TOOLKIT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.myhrtoolkit.com/pricing/",
                BuyURL = "http://www.myhrtoolkit.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Bamboo HR

            ca = new CloudApplication()
            {
                Brand = "Bamboo HR",
                ServiceName = "Bamboo HR",
                CompanyURL = "http://www.bamboohr.com/",
                Description = "Bamboo HR are a small company that knows first-hand how challenging it can be to find solutions and pricing that fit. So they have created a flexible core HR system and pricing model that adapt to your changing needs and packaged it in the most user-friendly way. That’s why BambooHR is so refreshingly simple to use, yet so incredibly powerful. Typical features can be found including tracking time off, training and benefits yet more advanced features like applicant tracking and payroll can also be found. Bamboo HR has exceptional service with real, live customer support team will go out of their way to help you—by phone or by email. In addition a library of free video tutorials, forums, training webinars, whitepapers, and a great knowledgebase can be accessed 24/7.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(10),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = true,
                SupportHours = repository.FindSupportHoursByName("12 hours"),
                
                SupportHoursTimeZone = repository.FindTimeZoneByName("MST"),
                SupportDays = repository.FindSupportDaysByName("5"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 69M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("7"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("BAMBOO HR"),
                AddDate = DateTime.Now,
                TryURL = "https://www.bamboohr.com/pricing.php",
                BuyURL = "https://www.bamboohr.com/pricing.php",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Cezanne HR

            ca = new CloudApplication()
            {
                Brand = "Cezanne HR",
                ServiceName = "Cezanne HR",
                CompanyURL = "http://cezannehr.com/",
                Description = "Cezanne HR gives you the best of both worlds. Powerful, configurable software for human resources management that is easy to manage and remarkably cost-effective, whatever the size of your company.  It’s easy to use but flexible, so you can set it up to work the way you want. Modular, to allow you to choose the features you need. Global, so that anyone can use it from anywhere. In the Cloud, which means you can be up and running fast; and packed full of clever, time-saving features that everyone in your business will appreciate. With Cezanne On Demand, you pay a simple monthly subscription fee based on the number of employees managed in the system and the modules you’ve selected (subject to a minimum fee of £100 per month). You can have as many HR administrators or self-service users as you want, and they can be in as many countries as you want. With intuitive navigation, easy-to-use screens, robust security, built-in alerts, flexible reporting, integrated employee and manager self-service and more, Cezanne OnDemand provides everything you need to manage your people better.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(20),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("PORTUGESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = true,
                SupportHours = repository.FindSupportHoursByName("24 hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 100M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("CEZANNE HR"),
                AddDate = DateTime.Now,
                TryURL = "http://cezannehr.com/hr-system-pricing/",
                BuyURL = "http://cezannehr.com/hr-system-pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Access Group

            ca = new CloudApplication()
            {
                Brand = "Access Group",
                ServiceName = "aCloud HR",
                CompanyURL = "http://www.accessacloud.com/hr/",
                Description = "aCloud are firm believers that using HR software should be a straightforward process, which is why aCloudHR offers a simple pricing structure for all their customers. Small businesses need to work smart and the aCloud solution will help you to manage employees more effectively, reduce costs and improve overall performance, creating significant benefits for employers and employees alike. Typically businesses with less than 20 employees are happy for the updating of data and personal records to be handled centrally. For just £1 per employee per month you can have all of the above without the self-service element. aCloud HR fits around your business and find that for companies of this size, this can be a cost effective solution.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(20),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = true,
                SupportHours = repository.FindSupportHoursByName("24 hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 28M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("ACCESS GROUP"),
                AddDate = DateTime.Now,
                TryURL = "http://www.accessacloud.com/hr/pricing/",
                BuyURL = "http://www.accessacloud.com/hr/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moore Pay HR Essential

            ca = new CloudApplication()
            {
                Brand = "Moore Pay",
                ServiceName = "HR Essential",
                CompanyURL = "http://www.moorepay.co.uk/hr_software",
                Description = "Moorepay HR Essential is a cloud-based integrated HR and Payroll solution specially designed for small and medium sized business. Reduce your administrative burden by allowing employees to request holidays, recording absences, amend personal details and much more.  All requests can be instantly authorised by management. Simplify your recruitment process and reduce the hours spent sifting through applications or CVs. The competency assessment functionality will quickly identify the most appropriate candidates.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("12 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    //repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 1.1M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Moore Pay"),
                AddDate = DateTime.Now,
                TryURL = "http://www.moorepay.co.uk/moorepayhr_packages",
                BuyURL = "http://www.moorepay.co.uk/moorepayhr_packages",
            };

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Payroll".ToUpper())).IsOptional = true;

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moore Pay HR Expert

            ca = new CloudApplication()
            {
                Brand = "Moore Pay",
                ServiceName = "HR Expert",
                CompanyURL = "http://www.moorepay.co.uk/hr_software",
                Description = "HR Expert simplifies and automates the performance review process through effective employee and manager evaluations, helping you meet the performance objectives of the individual and business. HR Professionals can effectively manage employee’s performance and progression, identifying competency gaps and record career aspirations, develop skills and knowledge, and help meet KPIs. Effectively manage and monitor your employee's time and attendance whilst improving productivity and reducing the administrative burden on your HR department. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("12 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    //repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    //repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 1.8M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Moore Pay"),
                AddDate = DateTime.Now,
                TryURL = "http://www.moorepay.co.uk/moorepayhr_packages",
                BuyURL = "http://www.moorepay.co.uk/moorepayhr_packages",

            };

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Payroll".ToUpper())).IsOptional = true;

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moore Pay HR Advanced

            ca = new CloudApplication()
            {
                Brand = "Moore Pay",
                ServiceName = "HR Advanced",
                CompanyURL = "http://www.moorepay.co.uk/hr_software",
                Description = "Moorepayhr Advanced offers everything you need to automate your people processes. Including your payroll, self-service, reporting and lots more. Analyse and effectively manage your business’s employment costs, saving you time when conducting salary reviews and allowing you to allocate organisation wide salary increases within budget. Automate and streamline existing processes by improving the flow of information to help you make crucial business decisions.  Make information available to the right people, at the right time to enable appropriate action to be taken whilst minimising errors.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("12 Hours"),
                SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                SupportDays = repository.FindSupportDaysByName("5"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 2.7M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("Moore Pay"),
                AddDate = DateTime.Now,
                TryURL = "http://www.moorepay.co.uk/moorepayhr_packages",
                BuyURL = "http://www.moorepay.co.uk/moorepayhr_packages",

            };

            ca.CloudApplicationFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith("Payroll".ToUpper())).IsOptional = true;

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho People Standard

            ca = new CloudApplication()
            {
                Brand = "Zoho People",
                ServiceName = "Standard",
                CompanyURL = "https://www.zoho.com/people/",
                Description = "Zoho People lets you manage all your HR and benefits programs from a central location—making it easier than ever to attract, retain and reward top talent. All while reducing costs, saving time, and integrating and aligning your HR efforts with the rest of your organization. Attendance module is the most user-friendly attendance management system available! You can simply track your employees' time, attendance, absenteeism, holidays and much more! All of this can be done accurately in real-time, even when you're away from your office! Connect and collaborate with your colleagues on-the-go from your iPhone/iPad and Android smart phone, in just a few taps. The fully functional employee directory application allows you to access your colleagues' contact information – anytime and from anywhere!",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 39M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("ZOHO PEOPLE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/people/zohopeople-pricing.html",
                BuyURL = "https://www.zoho.com/people/zohopeople-pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho People Premium

            ca = new CloudApplication()
            {
                Brand = "Zoho People",
                ServiceName = "Premium",
                CompanyURL = "https://www.zoho.com/people/",
                Description = "Zoho People Premium is a cloud based on-demand application where an HR manager can record and track important details in only one place. The pre-build forms facilitate administrative tasks, payroll processing, report generation and much more. Zoho People is a self-service application where employees and managers themselves are involved in the handling of data. This increases accuracy and decreases administrative hassles. Zoho People Premium enables you to build custom modules. Intuitive drag and drop tools make it a snap to create custom forms. Add fields as you see fit, and quickly modify, delete and re-order them based on your changing needs. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 75M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("ZOHO PEOPLE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/people/zohopeople-pricing.html",
                BuyURL = "https://www.zoho.com/people/zohopeople-pricing.html",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Zoho People Enterprise

            ca = new CloudApplication()
            {
                Brand = "Zoho People",
                ServiceName = "Enterprise",
                CompanyURL = "https://www.zoho.com/people/",
                Description = "To better serve its enterprise customers, Zoho People Enterprise with role-based security. Zoho People Enterprise supports data sharing permissions for complex organizational hierarchies and fine-grained user access control. With Zoho People’s self-service feature, employees can access, update and modify their own records based on established rules. This frees your HR staff from having to respond to requests and manually enter changes. Time and talent are more effectively and efficiently utilized.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(101),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(250),
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
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("PORTUGESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("ONLINE")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Holiday/Sickness Tracking"),
                    repository.FindFeatureByName("Appraisal Performance"),
                    repository.FindFeatureByName("Expenses"),
                    repository.FindFeatureByName("Self-Service Portal"),
                    repository.FindFeatureByName("Document Library"),
                    repository.FindFeatureByName("Recruitment"),
                    repository.FindFeatureByName("Workforce Management"),
                    repository.FindFeatureByName("Training & Development"),
                    repository.FindFeatureByName("Reporting", categoryID),
                    repository.FindFeatureByName("Compliance, Health & Safety"),
                    repository.FindFeatureByName("3rd Party Integration (APIs)", categoryID),
                    repository.FindFeatureByName("Timesheets"),
                    //repository.FindFeatureByName("Payroll", categoryID),
                    repository.FindFeatureByName("Case Management"),
                    repository.FindFeatureByName("Email / Memos"),
                    //repository.FindFeatureByName("Uptime Guarantee"),
                },
                //ApplicationCostPerMonth = 1.80M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFrom = 99M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("15"),
                Category = repository.FindCategoryByName("HR"),
                Vendor = repository.FindVendorByName("ZOHO PEOPLE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.zoho.com/people/zohopeople-pricing.html",
                BuyURL = "https://www.zoho.com/people/zohopeople-pricing.html",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished HR");
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
