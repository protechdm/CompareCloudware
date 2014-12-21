using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class MarketingProductionData
    {

        public static bool PumpMarketingData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("MARKETING").CategoryID;

            #region APPLICATIONS

            #region MARKETING

            #region Constant Contact Email Marketing

            ca = new CloudApplication()
            {
                Brand = "Constant Contact",
                ServiceName = "Email Marketing",
                CompanyURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",
                Description = "Constant Contact is one of the easiest email marketing services available. Without any knowledge of coding, you can easily create a professional email newsletter and campaign. There is a great set of templates make it fast and painless - and analytics tools to test and valiate campaign success.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 24.00M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                //need to check
                ApplicationCostPerMonthFrom = 10.00M,
                ApplicationCostPerMonthTo = 55.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("Constant Contact"),
                AddDate = DateTime.Now,
                TryURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Constant Contact Survey

            ca = new CloudApplication()
            {
                Brand = "Constant Contact",
                ServiceName = "Survey",
                CompanyURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",
                Description = "Constant Contact Online Survey lets you get instant feedback so you can understand what's working, and what's not. Use your results to improve your business and tailor your message to your audience. Create an online survey or poll with our pre-written questions and templates in just a few minutes. Easily add your logo and branding.  Link to your survey or poll in your email or on a webpage, blog, or social media network. Monitor your responses in real-time, and analyse your data with easy-to-read reports. Download results and get a link so they're easy to share",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 15.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = false,
                //ApplicationCostPerMonthTo = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("Constant Contact"),
                AddDate = DateTime.Now,
                TryURL = "http://www.constantcontact.com/online-surveys2/overview",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Constant Contact EventSpot

            ca = new CloudApplication()
            {
                Brand = "Constant Contact",
                ServiceName = "EventSpot",
                CompanyURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",
                Description = "Constant Contact EventSpot easily handles all the tasks that go into your next fundraiser, online meeting, webinar, conference, tradeshow, or class. Create event invitations and landing pages that make you stand out; easily share your event to all your social media networks. Process payments and accept registrations online 24/7, day and night. Issue tickets to your attendees, too.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 15.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 10.00M,
                ApplicationCostPerMonthTo = 150.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("Constant Contact"),
                AddDate = DateTime.Now,
                TryURL = "http://www.constantcontact.com/eventspot2/overview",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Constant Contact Social Campaigns

            ca = new CloudApplication()
            {
                Brand = "Constant Contact",
                ServiceName = "Social Campaigns",
                CompanyURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",
                Description = "You know your customers are on Facebook, but how do you engage them in a way that's good for your business? With Constant Contact Social Campaigns, you can turn fans into customers with promotions they'll love. Easily create a professional-looking Facebook landing page with a great offer for your fans. Publish your campaign on Facebook, then promote it with email and social media, right from your Constant Contact account. Track your Facebook promotion with our easy-to-read reporting and stats.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 20.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = false,
                //ApplicationCostPerMonthTo = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("60"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("Constant Contact"),
                AddDate = DateTime.Now,
                TryURL = "http://www.constantcontact.com/social-campaigns2/overview",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Constant Contact ClickWebinar

            ca = new CloudApplication()
            {
                Brand = "Constant Contact",
                ServiceName = "Click Webinar",
                CompanyURL = "http://www.constantcontact.com/uk/email-marketing2/overview?s_tnt=61724:14:0",                
                Description = "Go global without leaving your desk! With ClickWebinar, you can present your brand, demo your products, and train customers and staff anywhere in the world − with a webinar on any browser or platform. From live webcasts to sales presentations, desktop sharing to web-based training, ClickWebinar makes it easy to impress. You take the bows. We’re just the stage hands.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    //repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 20.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 24.00M,
                ApplicationCostPerMonthTo = 230.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("Constant Contact"),
                AddDate = DateTime.Now,
                TryURL = "http://www.clickwebinar.com/pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion#region Constant Contact Social Campaigns

            #region Dotmailer

            ca = new CloudApplication()
            {
                Brand = "Dotmailer",
                ServiceName = "Dotmailer",
                CompanyURL = "http://www.dotmailer.com/platform/create/",                
                Description = "As marketers ourselves, we understand what you need. A flexible platform that helps you create, automate, test and send emails in minutes. With dotmailer email marketing that's exactly what you get.It’s what’s helped us become the UK’s No.1 email marketing automation platform. dotmailer is a simple, but powerful, tool. At your disposal are nine essential building blocks of functionality designed to help you target the right customer at the right time with the right message. Even better, there’s new features and benefits added every two weeks so we grow as you do. ",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 20.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = false,
                //ApplicationCostPerMonthTo = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("DOTMAILER"),
                AddDate = DateTime.Now,
                TryURL = "https://www.dotmailer.com/trial/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion#region Constant Contact Social Campaigns
                
            #region Hootsuite Pro

            ca = new CloudApplication()
            {
                Brand = "Hootsuite",
                ServiceName = "Pro",
                CompanyURL = "https://hootsuite.com/plans",                
                Description = "The Hootsuite Pro dashboard is a quick way to see all relevant conversations in one place. Check out trending topics and respond to messages across all your social channels. Now you can digest big data easily. Create sharp-looking reports in minutes with simple drag-and-drop tools and widgets. Whether you’re a dynamic duo or collaborating with multiple clients, you can delegate tasks and set permissions within your team. Hootsuite Pro to integrates with the apps you already work with. Whether its your CRM or a new selling tool, our app directory gives you access to tons of ways to enhance your dashboard.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
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
                    //repository.FindBrowserByName("IE7"),
                    //repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = false,
                //ApplicationCostPerMonthTo = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("HOOTSUITE"),
                AddDate = DateTime.Now,
                TryURL = "https://hootsuite.com/create-account?planId=2",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion#region Constant Contact Social Campaigns

            #region Zoho Marketing Campaigns

            ca = new CloudApplication()
            {
                Brand = "Zoho Marketing",
                ServiceName = "Campaigns",
                CompanyURL = "https://www.zoho.com/campaigns/",                
                Description = "Zoho Campaigns allows you to focus on building a relationship with your customers. Automate your email marketing with email workflows and autoresponders. Choose from a list of default newsletter templates or design your own templates to suit your email marketing needs. Know the performance of your email & social campaigns. Understand your audience better and improve future campaigns - all with Zoho Campaigns. ",
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
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 5.00M,
                ApplicationCostPerMonthTo = 350.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("ZOHO MARKETING"),
                AddDate = DateTime.Now,
                TryURL = "https://campaigns.zoho.com/signup.do?plan=sub",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion#region Constant Contact Social Campaigns

            #region CAMPAIGN MONITOR Basic

            ca = new CloudApplication()
            {
                Brand = "CAMPAIGN MONITOR",
                ServiceName = "Basic",
                CompanyURL = "https://www.campaignmonitor.com/pricing/",                
                Description = "With Campaign Monitor, anyone can create amazing emails - all without any coding knowledge!  All our custom templates have been lovingly designed to cater for both desktop clients and mobile devices. So when using Campaign Monitor's email broadcast platform, you can easily switch between the desktop and mobile view to see how your designs will appear on both sizes. Make it personal by inserting your subscribers name or a product they purchased using our own template language.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    //repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 9.00M,
                ApplicationCostPerMonthTo = 299.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CAMPAIGN MONITOR"),
                AddDate = DateTime.Now,
                TryURL = "https://www.campaignmonitor.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion#region Constant Contact Social Campaigns

            #region CAMPAIGN MONITOR Unlimited

            ca = new CloudApplication()
            {
                Brand = "CAMPAIGN MONITOR",
                ServiceName = "Unlimited",
                CompanyURL = "https://www.campaignmonitor.com/pricing/",                
                Description = "With Campiagn Monitor Unlimited, users can send unlimited emails every momth plus free design/spam tests. Anyone can create amazing emails - all without any coding knowledge!  All our custom templates have been lovingly designed to cater for both desktop clients and mobile devices. The Unlimited Plan is for big senders, pure and simple. Whether you send 100, or 100 million emails each month, you’ll pay the same low price. This covers all your regular campaigns, RSS to Email, autoresponders, or triggering your own emails via our powerful API.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(100),
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
                    //repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 29.00M,
                ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CAMPAIGN MONITOR"),
                AddDate = DateTime.Now,
                TryURL = "https://www.campaignmonitor.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
              
            #region Instapage Basic

            ca = new CloudApplication()
            {
                Brand = "Instapage",
                ServiceName = "Basic",
                CompanyURL = "https://www.instapage.com/pricing/",                
                Description = "With Instapage setting up your first landing page campaign becomes as easy as stealing candy from a baby. With the help of our drag and drop editor and other set of features, creating and optimizing landing pages not only helps you better engage visitors but actually helps turn them into customers. Instapage helps you properly segment your audience with the help of message matching. ",
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 29.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("INSTAPAGE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.instapage.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            
            #region Instapage Professional

            ca = new CloudApplication()
            {
                Brand = "Instapage",
                ServiceName = "Professional",
                CompanyURL = "https://www.instapage.com/pricing/",                
                Description = "With Instapage Professional landing page software, users get additional domains, client accounts and visitor limits. Setting up your first landing page campaign becomes as easy as stealing candy from a baby.With the help of our drag and drop editor and other set of features, creating and optimizing landing pages not only helps you better engage visitors but actually helps turn them into customers. Instapage Professional also provides integration options with Salesforce & Infusionsoft",
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 79.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("INSTAPAGE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.instapage.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Instapage Unlimited

            ca = new CloudApplication()
            {
                Brand = "Instapage",
                ServiceName = "Unlimited",
                CompanyURL = "https://www.instapage.com/pricing/",                
                Description = "With Instapage Unlimited, setting up your first landing page campaign becomes as easy as stealing candy from a baby. Instapage Unlimited landing page software provides unlimited visitors, custom domains and cleints accounts - ideal for the ower user.With the help of our drag and drop editor and other set of features, creating and optimizing landing pages not only helps you better engage visitors but actually helps turn them into customers.Instapage helps you properly segment your audience with the help of message matching.",
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
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 179.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("INSTAPAGE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.instapage.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Marketo Spark

            ca = new CloudApplication()
            {
                Brand = "Marketo",
                ServiceName = "Spark",
                CompanyURL = "https://uk.marketo.com/software/marketing-automation/pricing/",                
                Description = "With Marketo marketing automation software gives you the power and flexibility to quickly launch highly targeted campaigns across your marketing channels in order to generate more revenue with less manual effort. Only Marketo provides ease and speed combined with enterprise-level power and flexibility so you never outgrow the system or run into roadblocks.",
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 640.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MARKETO"),
                AddDate = DateTime.Now,
                TryURL = "https://uk.marketo.com/software/marketing-automation/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Marketo Standard

            ca = new CloudApplication()
            {
                Brand = "Marketo",
                ServiceName = "Standard",
                CompanyURL = "https://uk.marketo.com/software/marketing-automation/pricing/",                
                Description = "With Marketo Standard, you can easily create, automate and measure engaging campaigns across all your marketing channels. With extended CRM integration and advanced dynamic content, our marketing automation software gives you the power and flexibility to quickly launch highly targeted campaigns across your marketing channels in order to generate more revenue with less manual effort. Only Marketo provides ease and speed combined with enterprise-level power and flexibility so you never outgrow the system or run into roadblocks. Users benefit from advanced lead scoring and revenue modelling.",
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 1436.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MARKETO"),
                AddDate = DateTime.Now,
                TryURL = "https://uk.marketo.com/software/marketing-automation/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Marketo Select

            ca = new CloudApplication()
            {
                Brand = "Marketo",
                ServiceName = "Selecto",
                CompanyURL = "https://uk.marketo.com/software/marketing-automation/pricing/",                
                Description = "The Marketo Select marketing automation platform comes with advanced analytics for email, revenue and reporting. Our marketing automation software gives you the power and flexibility to quickly launch highly targeted campaigns across your marketing channels in order to generate more revenue with less manual effort. Only Marketo Select provides the advanced funtionality and features required for marketing automation power users.",
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
                    //repository.FindBrowserByName("IE8"),
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
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 2556.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MARKETO"),
                AddDate = DateTime.Now,
                TryURL = "https://uk.marketo.com/software/marketing-automation/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Hubspot Basic

            ca = new CloudApplication()
            {
                Brand = "Hubspot",
                ServiceName = "Basic",
                CompanyURL = "http://www.hubspot.com/pricing#?currency=GBP",                
                Description = "HubSpot's all-in-one marketing software helps you optimise your website to get found by more prospects and convert more of them into leads and paying customers. Get more traffic with SEO, social media, and blogging tools. Get more leads with landing pages, calls-to-action, and form building tools. Get more customers with email, marketing automation, and lead intelligence tools",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 140.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("HUBSPOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.hubspot.com/pricing#?currency=GBP",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Hubspot Pro

            ca = new CloudApplication()
            {
                Brand = "Hubspot",
                ServiceName = "Pro",
                CompanyURL = "http://www.hubspot.com/pricing#?currency=GBP",                
                Description = "With HubSpot Pro - our powerful, easy-to-use inbound marketing software - businesses can attract, engage, and delight customers by delivering inbound experiences that are relevant, helpful, and personalised. And because everything is integrated, each component goes further. Marketing automation goes beyond email. SEO tools give you more than keywords. Integration means everything is more powerful.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 560.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("HUBSPOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.hubspot.com/pricing#?currency=GBP",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Hubspot Enterprise

            ca = new CloudApplication()
            {
                Brand = "Hubspot",
                ServiceName = "Enterprise",
                CompanyURL = "http://www.hubspot.com/pricing#?currency=GBP",                
                Description = "HubSpot Enterprise brings your entire marketing funnel together -  from attracting visitors to closing customers. The results is less hassle, more control, and an inbound marketing strategy that actually works. HubSpot's inbound marketing software helps you optimise your website to get found by more prospects and convert more of them into leads and paying customers. With HubSpot Enterprise users benefit from advanced CRM integration and smart content, making the platform ideal for the progressive and growing businesses. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 1680.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("HUBSPOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.hubspot.com/pricing#?currency=GBP",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Pardot Standard

            ca = new CloudApplication()
            {
                Brand = "Pardot",
                ServiceName = "Standard",
                CompanyURL = "http://www.pardot.com/pricing/",                
                Description = "Pardot Standard offers a software-as-a-service marketing automation application that allows marketing and sales departments to create, deploy, and manage online marketing campaigns that increase revenue and maximise efficiency. Pardot empowers marketers with lead nurturing, lead scoring, and ROI reporting to generate and qualify sales leads, shorten sales cycles, and demonstrate marketing accountability.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 680.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("PARDOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.pardot.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Pardot Pro

            ca = new CloudApplication()
            {
                Brand = "Pardot",
                ServiceName = "Pro",
                CompanyURL = "http://www.pardot.com/pricing/",                
                Description = "With advanced email analytics and dynamic content, Pardot Pro empowers marketers with lead nurturing, lead scoring, and ROI reporting to generate and qualify sales leads, shorten sales cycles, and demonstrate marketing accountability. Pardot Pro cloud marketing automation software allows marketing and sales departments to create, deploy, and manage online marketing campaigns that increase revenue and maximise efficiency. ",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 1360.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("PARDOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.pardot.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Pardot Ultimate

            ca = new CloudApplication()
            {
                Brand = "Pardot",
                ServiceName = "Ultimate",
                CompanyURL = "http://www.pardot.com/pricing/",                
                Description = "With custom-user roles and API access, Pardot marketing automation software empowers marketers with lead nurturing, lead scoring, and ROI reporting to generate and qualify sales leads, shorten sales cycles, and demonstrate marketing accountability. Pardot Ultimate is the top level of service. It offers a software-as-a-service marketing automation application that allows marketing and sales departments to create, deploy, and manage online marketing campaigns that increase revenue and maximize efficiency. ",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 29.00M,
                //ApplicationCostPerMonthTo = 699.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("PARDOT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.pardot.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Act-On Marketing Automation

            ca = new CloudApplication()
            {
                Brand = "Act-On",
                ServiceName = "Marketing Automation",
                CompanyURL = "https://www.act-on.com/pricing/",                
                Description = "Act-On marketing automation software lets you make the most of powerful campaign management techniques – without the steep learning curve that hobbles marketers using many other systems. Lead nurturing, lead scoring, list management, dynamic content, automated programs, inbound marketing, CRM integration; these aren’t fancy marketing terms; they’re capabilities integrated into the Act-On platform so you can develop and accelerate your campaign management practices.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                ApplicationCostPerMonthFrom = 600.00M,
                ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),

                SetupFee = repository.FindSetupFeeByName("399 to 2499"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("ACT-ON"),
                AddDate = DateTime.Now,
                TryURL = "https://www.act-on.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Marin Professional

            ca = new CloudApplication()
            {
                Brand = "Marin",
                ServiceName = "Professional",
                CompanyURL = "http://www.marinsoftware.co.uk/platform/editions",                
                Description = "Whether you are an agency with multiple clients, you are a direct advertiser with a dedicated team focused on search marketing or you are a one-person marketing department, the Marin online advertising software platform has the tools to help you save time and improve the financial performance of your campaigns. With an easy-to-use interface, the Marin Professional online ad software can be put to work as soon as you first link in any publisher account (Google, Yahoo! Bing, Facebook, etc.). Even better, you can start to see results immediately as well",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),

                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MARIN"),
                AddDate = DateTime.Now,
                TryURL = "http://www.marinsoftware.co.uk/platform/editions",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Marin Enterprise

            ca = new CloudApplication()
            {
                Brand = "Marin",
                ServiceName = "Enterprise",
                CompanyURL = "http://www.marinsoftware.co.uk/platform/editions",                
                Description = "Marin Enterprise online ad software has the tools to help you save time and improve the financial performance of your campaigns. With an easy-to-use interface, the Marin Platform can be put to work as soon as you first link in any publisher account (Google, Yahoo! Bing, Facebook, etc.). Even better, you can start to see results immediately as well. With advanced integration options, dedicated account management and client services, in addition to custom reporting, Marin Enterprise is the preferred internet advertising software tool for many leading global brands.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),

                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("21"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MARIN"),
                AddDate = DateTime.Now,
                TryURL = "http://www.marinsoftware.co.uk/platform/editions",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Cvent Event Management

            ca = new CloudApplication()
            {
                Brand = "Cvent",
                ServiceName = "Event Management",
                CompanyURL = "http://www.cvent.com/uk/event-management-software/",                
                Description = "Maximising efficiencies and adding to attendance figures whilst cutting back on costs is the goal of every event planner. Cvent's online registration platform offers the ability to do just that. This highly intuitive event management software interface allows meeting and event planners to use time typically spent on laborious, manual tasks to focus on larger concerns.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CVENT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.cvent.com/uk/event-management-software/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Cvent Survey Management

            ca = new CloudApplication()
            {
                Brand = "Cvent",
                ServiceName = "Survey Management",
                CompanyURL = "http://www.cvent.com/uk/event-management-software/",                
                Description = "With Cvent's professional web survey software, organisations can streamline the way they collect feedback and timely business intelligence from their events. Professionals can use Cvent's web survey software to test markets, qualify leads, measure program effectiveness, enhance company culture and gauge stakeholder opinions. Using web survey software is the new norm for conducting and managing surveys, and is more effective and efficient than traditional surveying techniques.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 2050.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CVENT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.cvent.com/uk/online-survey-software/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FluidSurveys Pro

            ca = new CloudApplication()
            {
                Brand = "FluidSurveys",
                ServiceName = "Pro",
                CompanyURL = "https://fluidsurveys.com/pricing/",                
                Description = "The FuildSurvey Pro survey software allows you to build your own surveys using an easy drag & drop editor, or work off expert designed templates. Access tons of features: over 40 question types, logic, branding, and more! Collect responses in real-time with ease online, offline or on mobile devices. All surveys are responsive and work on any device. Distribute your surveys using web links, emails, social media, QR codes, and more. Gain actionable insights with powerful analytics. Create & share reports and display your results graphically, export data into Excel, Word, PDF, SPSS and PPT, drill down with filters, benchmark, and more!",
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
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("GERMAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //reository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 17.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("FLUIDSURVEYS"),
                AddDate = DateTime.Now,
                TryURL = "https://fluidsurveys.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FluidSurveys Ultra

            ca = new CloudApplication()
            {
                Brand = "FluidSurveys",
                ServiceName = "Ultra",
                CompanyURL = "https://fluidsurveys.com/pricing/",                
                Description = "With advanced survey logic and premium question types, FluidSurveys Ultra is our most popular survey software. Build your own surveys using an easy drag & drop editor, or work off expert designed templates. Access tons of features: over 40 question types, logic, branding, and more! Collect responses in real-time with ease online, offline or on mobile devices. All surveys are responsive and work on any device. Distribute your surveys using web links, emails, social media, QR codes, and more. Gain actionable insights with powerful analytics.",
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
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("ARABIC"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 49.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("FLUIDSURVEYS"),
                AddDate = DateTime.Now,
                TryURL = "https://fluidsurveys.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region FluidSurveys Enterprise

            ca = new CloudApplication()
            {
                Brand = "FluidSurveys",
                ServiceName = "Enterprise",
                CompanyURL = "https://fluidsurveys.com/pricing/",                
                Description = "FuildSurveys Enterprise is our top level online survey software for organisations looking for an enterprise grade data collection and analysis tool. Build your own surveys using an easy drag & drop editor, or work off expert designed templates. Access tons of features: over 40 question types, logic, branding, and more! Collect responses in real-time with ease online, offline or on mobile devices. All surveys are responsive and work on any device. Distribute your surveys using web links, emails, social media, QR codes, and more. With enhanced security, white label options and multi-user accounts, Enterprise addresses the needs of the most demanding user.",
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
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("INDONESIAN"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("ARABIC"),
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
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 49.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("FLUIDSURVEYS"),
                AddDate = DateTime.Now,
                TryURL = "https://fluidsurveys.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Vocus Basic

            ca = new CloudApplication()
            {
                Brand = "Vocus",
                ServiceName = "Basic",
                CompanyURL = "http://www.vocus.co.uk/pricing/",                
                Description = "Use Vocus PR software to get your company news out there and build awareness. What’s more, our social monitoring and online news will allow you to keep on top of your mentions when they happen. Ideal for growing companies that do not have dedicated PR or media relations staff. Vocus provides the best value for your budget without sacrificing service or quality. We deliver second-to-none software along with professional services in our customisable pricing packages that will surpass all your requirements.",
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
                    //.FindBrowserByName("OPERA"),
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
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 49.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VOCUS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vocus.co.uk/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Vocus Professional

            ca = new CloudApplication()
            {
                Brand = "Vocus",
                ServiceName = "Professional",
                CompanyURL = "http://www.vocus.co.uk/pricing/",                
                Description = "Gather and report on news about your company and competitors, build your network of journalists, and stay current on trends in your industry. Ideal for PR professionals and their teams. Vocus PR management software provides the best value for your budget without sacrificing service or quality. We deliver second-to-none software along with professional services in our customisable pricing packages that will surpass all your requirements.",
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
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 49.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VOCUS"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vocus.co.uk/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OutMarket Basic

            ca = new CloudApplication()
            {
                Brand = "OutMarket",
                ServiceName = "Basic",
                CompanyURL = "https://www.outmarket.com/pricing/",                
                Description = "With OutMarket marketing automation software, getting the most for your marketing dollars means never compromising on quality or service. We deliver best-in-class marketing software and expert services with scalable pricing packages that are proven to meet and exceed your objectives and expectations. Our marketing automation platform integrates communications and outreach across all channels.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(3),
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
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 300.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("500"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("OUTMARKET"),
                AddDate = DateTime.Now,
                TryURL = "https://www.outmarket.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OutMarket Plus

            ca = new CloudApplication()
            {
                Brand = "OutMarket",
                ServiceName = "Plus",
                CompanyURL = "https://www.outmarket.com/pricing/",                
                Description = "OutMarket provides marketing automation software and services for marketing teams to drive quantifiable results. The OutMarket platform integrates email marketing, landing pages, social media management, press outreach, and robust analytics in a simple but comprehensive cloud-based solution that helps customers outmarket the competition and grow their business.",
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
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 600.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("1000"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("OUTMARKET"),
                AddDate = DateTime.Now,
                TryURL = "https://www.outmarket.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region OutMarket Pro

            ca = new CloudApplication()
            {
                Brand = "OutMarket",
                ServiceName = "Pro",
                CompanyURL = "https://www.outmarket.com/pricing/",                
                Description = "OutMarket Pro is an advanced, feature-rich marketing automation service providing enhanced analytics, lead scoring and automation processes - enabling marketing teams to drive quantifiable results. The OutMarket platform integrates email marketing, landing pages, social media management, press outreach, and robust analytics in a simple but comprehensive cloud-based solution that helps customers outmarket the competition and grow their business.",
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
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 1000.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("1500"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("OUTMARKET"),
                AddDate = DateTime.Now,
                TryURL = "https://www.outmarket.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            
            #region OutMarket Enterprise

            ca = new CloudApplication()
            {
                Brand = "OutMarket",
                ServiceName = "Enterprise",
                CompanyURL = "https://www.outmarket.com/pricing/",                
                Description = "OutMarket Enterprise is our most comprehensive and professional service. The OutMarket automation platform integrates email marketing, landing pages, social media management, press outreach, and robust analytics in a simple but comprehensive cloud-based solution that helps customers outmarket the competition and grow their business. Sophisticated tools for buying signals and advanced lead scoring make the platform an essential marketing tool for many leading brands.",
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
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 2500.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("3000"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("OUTMARKET"),
                AddDate = DateTime.Now,
                TryURL = "https://www.outmarket.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion
            
            #region Moz Standard

            ca = new CloudApplication()
            {
                Brand = "Moz",
                ServiceName = "Standard",
                CompanyURL = "http://moz.com/products/pricing",                
                Description = "Measure and improve your search, social, brand, and content marketing with Moz Standard. Our inbound marketing platform performs in-depth research on your site - in addition to your competitors - with comprehensive research tools. Moz subscribers benefit from educational resources, answers to tough technical questions from our community of professional marketers, and more.",
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
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 99.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MOZ",true),
                AddDate = DateTime.Now,
                TryURL = "http://moz.com/products/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moz Medium

            ca = new CloudApplication()
            {
                Brand = "Moz",
                ServiceName = "Medium",
                CompanyURL = "http://moz.com/products/pricing",                
                Description = "The Moz Medium plan measures and improves your search, social, brand, and content marketing. With additional analytics campaigns, keywords, crawled pages and social accounts, the service is good for the growing business. Perform in-depth research on your site - and your competitors - with our research tools. Moz inbound marketing software subscribers benefit from educational resources, answers to tough technical questions from our community of professional marketers, and more.",
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
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 149.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MOZ",true),
                AddDate = DateTime.Now,
                TryURL = "http://moz.com/products/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moz Large

            ca = new CloudApplication()
            {
                Brand = "Moz",
                ServiceName = "Large",
                CompanyURL = "http://moz.com/products/pricing",                
                Description = "Moz Large inbound marketing software is great for socially intensive envornments. This level of service comes with higher thresholds on accounts, keywords, analytics and branded reports. Measure and improve your search, social, brand, and content marketing.Perform in-depth research on your site - and your competitors - with our research tools. Moz subscribers benefit from educational resources, answers to tough technical questions from our community of professional marketers, and more.",
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
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 249.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("MOZ",true),
                AddDate = DateTime.Now,
                TryURL = "http://moz.com/products/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Connect For Business

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Connect For Business",
                CompanyURL = "http://www.adobe.com/uk/products/adobeconnect/webinars.html",                
                Description = "Adobe Connect is a web conferencing software solution for secure web meetings, eLearning and webinars. Adobe Connect helps you deliver compelling, immersive events, maximise attendance, and measure results for optimised outcomes. Adobe Connect for eLearning provides a complete solution for rapid training and mobile learning, enabling rapid deployment of training.",
                
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    //repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 249.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("ADOBE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.adobe.com/cfusion/adobeconnect/index.cfm?event=trial",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Connect For Individuals

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Connect For Individuals",
                CompanyURL = "http://www.adobe.com/uk/products/adobeconnect/webinars.html",                
                Description = "Adobe Connect for Web Meetings enables you to significantly improve collaboration, both inside and outside your organisation’s firewalls. You can use Adobe Connect for a full range of online meeting needs, from simple screen-sharing all the way to mission-critical, real-time collaboration and webinars. Adobe Connect allows your teams to work more efficiently and effectively, increasing productivity and helping you to reduce costs.",
                
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 249.00M,
                //ApplicationCostPerAnnum = 0.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("ADOBE"),
                AddDate = DateTime.Now,
                TryURL = "https://www.adobe.com/cfusion/adobeconnect/index.cfm?event=trial",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Citrix 100 Attendees

            ca = new CloudApplication()
            {
                Brand = "Citrix",
                ServiceName = "100 Attendees",
                CompanyURL = "https://secure.citrixonline.com/buy?execution=e1s1",                
                Description = "Citrix GoToWebinar makes communication with prospects, employees, partners and customers easier and more efficient than any webinar product available today.With GoToWebinar, you can give presentations, perform product demonstrationsand deliver company-wide messages to up to 100 attendees, any time, anywhere — all for one flat fee.",
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    //repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 59.00M,
                //ApplicationCostPerAnnum = 566.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CITRIX"),
                AddDate = DateTime.Now,
                TryURL = "https://secure.citrixonline.com/buy?execution=e1s1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Citrix 500 Attendees

            ca = new CloudApplication()
            {
                Brand = "Citrix",
                ServiceName = "500 Attendees",
                CompanyURL = "https://secure.citrixonline.com/buy?execution=e1s1",                
                Description = "GoToWebinar All You Can Reach flat-fee pricing allows you to conduct as many webinars as you want, so you can make the most of your investment. Integrated VoIP and toll-based phone options eliminate audio costs, while the recording feature allows you to draw value from your event long after it’s over. Plus,GoToWebinar comes with a free GoToMeeting subscription.",
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    //repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 236.00M,
                //ApplicationCostPerAnnum = 2265.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CITRIX"),
                AddDate = DateTime.Now,
                TryURL = "https://secure.citrixonline.com/buy?execution=e1s1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Citrix 1000 Attendees

            ca = new CloudApplication()
            {
                Brand = "Citrix",
                ServiceName = "1000 Attendees",
                CompanyURL = "https://secure.citrixonline.com/buy?execution=e1s1",                
                Description = "Present to up to 1000 delegates simultaneously. Citrix GoToWebinar makes communication with prospects, employees, partners and customers easier and more efficient than any webinar product available today. With GoToWebinar, you can give presentations, perform product demonstrations and deliver companywide messages, any time, anywhere — all for one flat fee.",
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    //repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    //repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    //repository.FindFeatureByName("Telemarketing"),
                    repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 299.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = true,
                ApplicationCostPerAnnumAvailable = true,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("CITRIX"),
                AddDate = DateTime.Now,
                TryURL = "https://secure.citrixonline.com/buy?execution=e1s1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Vocalcom Cloud Contact Centre

            ca = new CloudApplication()
            {
                Brand = "Vocalcom",
                ServiceName = "Cloud Contact Centre",
                CompanyURL = "http://www.vocalcom.com/en/hosted-call-center-software-cloud-based-contact-center#features",                
                Description = "Engage better, respond faster, and empower your telemarketing agents. With Vocalcom's contact center and telemarketing solution, users get cloud simplicity with best-in-class functionality.  Increase customer satisfaction by 34% with Vocalcom. Deliver fast, effortless, and effective customer service on every channel from anywhere. Increase first call resolution, agent productivity, and more. ",
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    repository.FindFeatureByName("Social media management"),
                    repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 299.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VOCALCOM"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vocalcom.com/en/request-a-demo",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region VanillaSoft Lite

            ca = new CloudApplication()
            {
                Brand = "VanillaSoft",
                ServiceName = "Lite",
                CompanyURL = "http://www.vanillasoft.com/products",                
                Description = "VanillasSoft is the industry's leading software for telemarketing and telesales. Our intuitive and easy-to-use inside sales software takes the best of CRM, lead management and telemarketing applications to create the most productive phone sales environment available today. ",
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
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 25.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VANILLASOFT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vanillasoft.com/products",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region VanillaSoft Lite Plus

            ca = new CloudApplication()
            {
                Brand = "VanillaSoft",
                ServiceName = "Lite Plus",
                CompanyURL = "http://www.vanillasoft.com/products",                
                Description = "VanillasSoft is the industry's leading software for telemarketing and telesales. With options around autodialling, Lite Plus is the ideal option for environments looking towards greater productivity. Our intuitive and easy-to-use inside sales software takes the best of CRM, lead management and telemarketing applications to create the most productive phone sales environment available today.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(6),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(10),
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
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 40.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VANILLASOFT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vanillasoft.com/products",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region VanillaSoft Pro

            ca = new CloudApplication()
            {
                Brand = "VanillaSoft",
                ServiceName = "Pro",
                CompanyURL = "http://www.vanillasoft.com/products",                
                Description = "With unlimited contacts and custom fields, it easy to see why VanillasSoft Pro is the industry's leading software for telemarketing and telesales. Our intuitive and easy-to-use inside sales software takes the best of CRM, Lead Management and Telemarketing applications to create the most productive phone sales environment available today. ",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(11),
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
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("IE11"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
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
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    //repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                ApplicationCostPerMonth = 65.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = false,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("VANILLASOFT"),
                AddDate = DateTime.Now,
                TryURL = "http://www.vanillasoft.com/products",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region New Voice Media ContactWorld 

            ca = new CloudApplication()
            {
                Brand = "New Voice Media",
                ServiceName = "ContactWorld",
                CompanyURL = "http://pages.newvoicemedia.com/request-demonstration.html",                
                Description = "ContactWorld is the preferred choice for many leading telemarketing, telesales and customer services environments. As ContactWorld sits in ‘the cloud’, all resources associated with contact handling – licences, bandwidth, routing applications and gateways – are shared so you only use them when you need them. The robust infrastructure on which ContactWorld is built supports a 99.999% availability SLA and unique public Trust site that demonstrates platform performance and availability across 7 real-life actions in real-time.",
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
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    //repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("A/B testing"),
                    repository.FindFeatureByName("API integration", categoryID),
                    //repository.FindFeatureByName("Automated email"),
                    //repository.FindFeatureByName("Ad tracking"),
                    //repository.FindFeatureByName("Email campaign management"),
                    //repository.FindFeatureByName("Event management"),
                    repository.FindFeatureByName("Integrated contact management"),
                    //repository.FindFeatureByName("Invite/registration management"),
                    //repository.FindFeatureByName("Landing page management"),
                    repository.FindFeatureByName("Campaign reporting"),
                    //repository.FindFeatureByName("Search management"),
                    //repository.FindFeatureByName("Social media management"),
                    //repository.FindFeatureByName("Social sharing"),
                    //repository.FindFeatureByName("Surveys"),
                    repository.FindFeatureByName("Telemarketing"),
                    //repository.FindFeatureByName("Webinar platform"),
                },
                //ApplicationCostPerMonth = 65.00M,
                //ApplicationCostPerAnnum = 2870.0M,
                ApplicationCostPerMonthPOA = true,
                ApplicationCostPerMonthFree = false,              
                //ApplicationCostPerMonthFrom = 600.00M,
                //ApplicationCostPerMonthTo = 5100.00M,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),               
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("MARKETING"),
                Vendor = repository.FindVendorByName("NEW VOICE MEDIA"),
                AddDate = DateTime.Now,
                TryURL = "http://pages.newvoicemedia.com/request-demonstration.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion
            Console.WriteLine("Finished MARKETING");
            return retVal;
        }
        #region InsertDocumentLinks
        private static void xInsertDocumentLinks(QueryRepository repository, CloudApplication ca)
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
