using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using GhostscriptSharp;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class CreativeProductionData
    {

        public static bool PumpCreativeData(QueryRepository repository)
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

            int categoryID = repository.FindCategoryByName("CREATIVE").CategoryID;

            #region APPLICATIONS

            #region CREATIVE

            #region Adobe Illustrator

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Illustrator",
                CompanyURL = "https://www.adobe.com/products/illustrator.html",
                Description = "Adobe Illustrator is the industry standard tool for vector drawing and illustration, used by a wide variety of creative professionals including editorial illustrators, identity designers, textile and pattern designers, UI designers, motion artists and many others. The software provides a comprehensive vector graphics environment that invites you to explore more efficient ways to design.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },
                
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered=false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/illustrator",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Painter

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Painter",
                CompanyURL = "http://www.painterartist.com/gb/product/paint-program/?hptrack=mmptr",
                Description = "Change what's possible in art with Corel Painter. Explore new creative possibilities with Natural-Media brushes, paper textures and media that look and feel just like traditional art materials. Find unreal inspiration with revolutionary new Particle Brushes and mobile enhancements. Experience the speed and power of the ultimate paint program with native 64-bit Mac and PC support. Plus, work with Photoshop files for even more creative compatibility.",
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
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("282.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.painterartist.com/gb/product/paint-program/?hptrack=mmptr",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Draw Suite

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Draw Suite",
                CompanyURL = "http://www.coreldraw.com/gb/product/graphic-design-software/?hptrack=mmcdgs",
                Description = "With a fresh look, new must-have tools and major feature enhancements, CorelDRAW Graphics Suite X7 opens up a world of new creative possibilities. There are several new workspaces that reflect your natural workflow, so that everything is right where you need it, when you need it. Whether you're creating graphics and layouts, editing photos or designing websites, this complete suite of graphic design software helps you design your way.",
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
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("499.00"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.coreldraw.com/gb/product/graphic-design-software/?hptrack=mmcdgs",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Indesign

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Indesign",
                CompanyURL = "http://www.adobe.com/uk/products/indesign.html",
                Description = "Adobe InDesign is the industry-standard publishing application for print publications, interactive PDF documents, digital magazines, and EPUBs. InDesign is a professional publishing tool and a fully-featured working environment for page layout. You'll be able to create all sorts of documents, from simple flyers to complete ebooks, as well as labels, brochures, presentations, certificates, newsletters and more. It'll also let you add interactivity to your creations by inserting video and sound, then exporting the result as Flash (SWF) or an interactive PDF. The latest version of Adobe InDesign includes important new features that will enhance your workflow and boost your productivity. The simplified object selection, for example, makes it easier to control objects in your document. Also, the perfect integration of Adobe InDesign with the Adobe CS Review helps you share your work and receive feedback from colleagues and customers in a very easy way.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    repository.FindFeatureByName("eBook publishing"),
                    repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 17.58M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/indesign",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Premiere

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Premiere",
                CompanyURL = "https://www.adobe.com/uk/products/premiere.html",
                Description = "Adobe Premiere is the industry-standard video software used by videographers to edit, manipulate, and export their video projects. You can create quick movies from favourite parts of your clips or tell big life stories in full-on productions. Add motion inside movie titles, punch up the drama with cool focus effects, and get guidance as you go. Adobe Premiere is suitable for both amateur enthusiasts and professionals.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 17.58M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/premiere"
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe After Effects

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "After Effects",
                CompanyURL = "http://www.adobe.com/uk/products/aftereffects.html",
                Description = "Adobe After Effects is a digital motion graphics, visual effects and compositing applicaton used in the post-production process of filmmaking and television production. After Effects can also be used as a basic non-linear editor and a media transcoder.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 17.58M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/aftereffects",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Quark Xpress

            ca = new CloudApplication()
            {
                Brand = "Quark",
                ServiceName = "Xpress",
                CompanyURL = "http://www.quark.co.uk/en/Products/QuarkXPress/#1",
                Description = "Creative expression requires the right tools and when it comes to professional results, details matter. QuarkXPress 10 has been redesigned from the inside out to deliver stunning graphics, virtuoso productivity features and a design canvas to accentuate your creativity. So whether you love print or live digital, XPress Yourself with QuarkXPress 10.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("799.00"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Quark"),
                AddDate = DateTime.Now,
                TryURL = "http://www.quark.co.uk/en/Products/QuarkXPress/Test_Drive.aspx",

            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Gliffy Standard

            ca = new CloudApplication()
            {
                Brand = "Gliffy",
                ServiceName = "Standard",
                CompanyURL = "http://www.gliffy.com/products/online/pricing/",
                Description = "The Gliffy Online Standard version simplifes the production of complex diagrams and workflows. It  runs on an HTML5 editor that’s more than twice as fast as Flash. Users can create and edit very large diagrams without wasting time - in additon to dragging-and-dropping shapes from an extensive library.",
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
                    repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 3.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Gliffy"),
                AddDate = DateTime.Now,
                TryURL = "http://www.gliffy.com/products/online/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Gliffy Pro

            ca = new CloudApplication()
            {
                Brand = "Gliffy",
                ServiceName = "Pro",
                CompanyURL = "http://www.gliffy.com/products/online/pricing/",
                Description = "The Pro version of Gliffy Online provides users with the ability to produce unlimited diagrams and provides unlimited storage space - all with the same editor that’s twice as fast as Flash. Users can create and edit very large diagrams without wasting time - in additon to dragging-and-dropping shapes from an extensive library.",
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
                    repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 7.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Gliffy"),
                AddDate = DateTime.Now,
                TryURL = "http://www.gliffy.com/products/online/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Creately Personal

            ca = new CloudApplication()
            {
                Brand = "Creately",
                ServiceName = "Personal",
                CompanyURL = "http://creately.com/plans1?utm_expid=10997800-4.jRKOQ4XQRdK8G5E4AYeRUQ.1&utm_referrer=http%3A%2F%2Fcreately.com%2F",
                Description = "Creately is an intuitive and user-friendly diagramming, design and cloud-based drawing application. With a powerful, web-based interface, the service provides a visual communication platform for virtual teams and collaborative co-workers. It's a great visual collaboration tool that's a breeze to use - together with an extraordinary customer service experience that you'll love.",
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
                    repository.FindBrowserByName("IE9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 5M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Creately"),
                AddDate = DateTime.Now,
                TryURL = "http://creately.com/plans1?utm_expid=10997800-4.jRKOQ4XQRdK8G5E4AYeRUQ.1&utm_referrer=http%3A%2F%2Fcreately.com%2F",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Photoshop

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Photoshop",
                CompanyURL = "http://www.adobe.com/uk/products/photoshop.html",
                Description = "Adobe Photoshop is the industry standard image editing software. The software allows users to manipulate, crop, resize, and correct color on digital photos. The software is particularly popular amongst professional photographers and graphic designers because of its sophisticated image manipulation and retouching features.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("MALAY"),
                    repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 8.78M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/photoshop",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Paintshop Pro

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Paintshop Pro",
                CompanyURL = "https://store.paintshoppro.com/1184/purl-ATG_PID_HPbanner_PSPproX7ULT?hptrack=gb2mf1",
                Description = "There are reason why Corel Paintshop Pro is such a hit with users globally. Corel PaintShop Pro X7 Ultimate combines the pro-quality photo-editing tools of PaintShop Pro X7 with powerful image correction technology such as Perfectly Clear, portrait beautifying tools Reallusion FaceFilter3 Standard - together with a rich collection of creative extras. It;s a dream tool for designers and retouchers worldwide.",
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
                    repository.FindBrowserByName("IE8"),
                    repository.FindBrowserByName("IE9"),
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("54.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "https://store.paintshoppro.com/1184/purl-ATG_PID_HPbanner_PSPproX7ULT?hptrack=gb2mf1",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Aftershot Pro 2

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Aftershot Pro 2",
                CompanyURL = "http://www.aftershotpro.com/en/products/aftershot-pro/default.html",
                Description = "Say hello to the world’s fastest RAW photo-editing software. Corel AfterShot Pro 2 is changing the way the world works with RAW, with 64-bit performance that’s 30% faster than AfterShot Pro 1 and up to 4x faster than the competition. AfterShot Pro 2 is the best way to unlock the freedom and flexibility of shooting RAW.",
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
                    //repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("49.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.aftershotpro.com/en/free-trials/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Lightroom

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Lightroom",
                CompanyURL = "http://www.adobe.com/uk/products/photoshop-lightroom.html",
                Description = "Adobe Photoshop Lightroom is a photo editing and management programme. Via a single user interface, it allows the viewing, management, and editing of a large numbers of digital images. Nothing makes working with digital photos smoother than Lightroom.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("MALAY"),
                    //repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 8.78M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/lightroom",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel CorelCAD

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "CorelCAD",
                CompanyURL = "http://www.coreldraw.com/us/product/cad-software/",
                Description = "Get powerful and affordable CAD software with industry-standard features and 2D drafting and 3D design tools. Use CorelCAD to improve your design productivity and performance with the new drawing constraints functionality, In-Place text editing, and interactive layout and editing tools. Work in a familiar environment with the enhanced and customizable ribbon UI and other popular CAD features.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("629.00"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.coreldraw.com/us/product/cad-software/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Edge Animate

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Edge Animate",
                CompanyURL = "https://creative.adobe.com/products/animate",
                Description = "Adobe Edge Animate lets web designers create interactive HTML animations for web, digital publishing, rich media advertising and more, reaching both desktop and mobile browsers with ease. Edge Animate allows creatives to push the creative envelope on what can be delivered and presented online.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 8.78M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/animate?version=5.0",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoAnimate GoPublish

            ca = new CloudApplication()
            {
                Brand = "GoAnimate",
                ServiceName = "GoPublish",
                CompanyURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
                Description = "GoAnimate is a cloud-based platform for creating and distributing animated videos. It allows users to develop both narrative videos, in which characters speak with lip-sync and move around, and video presentations, in which a voice-over narrator speaks over images and props, which may also move around.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 39M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("GoAnimate"),
                AddDate = DateTime.Now,
                TryURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoAnimate GoPremium

            ca = new CloudApplication()
            {
                Brand = "GoAnimate",
                ServiceName = "GoPremium",
                CompanyURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
                Description = "GoAnimate GoPremium is a step up from the entry-level GoPublish service. It's still a cloud-based platform for creating and distributing animated videos - but with increased commercial opportunity, no watermarking and full HD content. It allows users to develop both narrative videos, in which characters speak with lip-sync and move around, and video presentations, where a voice-over narrator speaks over images and props.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 79M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("GoAnimate"),
                AddDate = DateTime.Now,
                TryURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region GoAnimate GoTeam

            ca = new CloudApplication()
            {
                Brand = "GoAnimate",
                ServiceName = "GoTeam",
                CompanyURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
                Description = "GoTeam is the top-level service from GoAnimate. It's a cloud-based software platform for creating and distributing animated videos - with extra functionality for Group and Project Management. It allows users to develop both narrative videos, in which characters speak with lip-sync and move around, and video presentations where a voice-over narrator speaks over images and props.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 250M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("GoAnimate"),
                AddDate = DateTime.Now,
                TryURL = "http://goanimate.com/business/videoplans/?hook=header_button.site",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Muse

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Muse",
                CompanyURL = "http://www.adobe.com/uk/products/muse.html",
                Description = "Adobe Muse is a web development application. The software is focused on allowing designers to create and publish dynamic websites for desktop and mobile devices that meet the latest web standards — without writing code",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 13.67M,
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
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/muse",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Serif Page Plus Starter Edition

            ca = new CloudApplication()
            {
                Brand = "Serif",
                ServiceName = "Page Plus Starter Edition",
                CompanyURL = "http://www.serif.com/desktop-publishing-software/",
                Description = "PagePlus Starter Edition is a powerful publishing program that allows you to design fantastic print documents. It contains a word processing feature for professional results, it allows total layout control when creating documents and support for common image files like JPG and PNG.",
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName(1),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName(1),
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("89.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Serif"),
                AddDate = DateTime.Now,
                TryURL = "http://www.serif.com/desktop-publishing-software/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moovly Plus

            ca = new CloudApplication()
            {
                Brand = "Moovly",
                ServiceName = "Plus",
                CompanyURL = "http://www.moovly.com/pricing",
                Description = "Moovly is a cloud-based digital media and content creation software platform. Using Moovly, users can create multimedia presentations, interactive infographics, animated banner ads, company and product promotion videos and other similar multimedia digital content. Using a combination of uploaded images, videos and sounds, as well as a pre-defined library of objects, users will be able to assemble new content modules and publish them on a variety of platforms.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 9.95M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Moovly"),
                AddDate = DateTime.Now,
                TryURL = "http://www.moovly.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Moovly Pro

            ca = new CloudApplication()
            {
                Brand = "Moovly",
                ServiceName = "Pro",
                CompanyURL = "http://www.moovly.com/pricing",
                Description = "Moovly Pro is a software-as-a-service content creation software platform - providing HD videos for users. Like Moovly Plus, users can create multimedia presentations, interactive infographs, animated banner ads, company and product promotion videos and other similar multimedia digital content. With Moovly Pro, users get increased storage capacity for using a combination of uploaded images, videos and sounds, as well as a pre-defined library of objects. And like Moovly Plus, users can assemble new content modules and publish them on a variety of platforms.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 24.95M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Moovly"),
                AddDate = DateTime.Now,
                TryURL = "http://www.moovly.com/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Magisto Standard

            ca = new CloudApplication()
            {
                Brand = "Magisto",
                ServiceName = "Standard",
                CompanyURL = "http://www.magisto.com/",
                Description = "Magisto automatically turns your everyday videos and photos into beautifully edited movies, perfect for sharing. It's quick, and easy as pie!  Magisto selects the best parts of your videos and photos, adds your chosen music, themes, and effects, and splices them into beautiful little movies. All with our  revolutionary video production automation software.",
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
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 24.95M,
                ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Magisto"),
                AddDate = DateTime.Now,
                TryURL = "http://www.magisto.com/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WeVideo Premium

            ca = new CloudApplication()
            {
                Brand = "WeVideo",
                ServiceName = "Premium",
                CompanyURL = "https://www.wevideo.com/sign-up",
                Description = "WeVideo Premium lets you create great videos in a flash. Drag and drop your videos, trim and choose from our pre-made themes to set a unique style. Go advanced when you are ready.",
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
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 4M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("WeVideo"),
                AddDate = DateTime.Now,
                TryURL = "https://www.wevideo.com/sign-up",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region WeVideo Pro

            ca = new CloudApplication()
            {
                Brand = "WeVideo",
                ServiceName = "Pro",
                CompanyURL = "https://www.wevideo.com/sign-up",
                Description = "WeVideo Pro lets you create great videos in a flash - with full HD quality and premium editing features. Drag and drop your videos, trim and choose from our pre-made themes to set a unique style and a comprehensive library of licensed tracks/songs. When you're ready, export your masterpiece to a comprehensive selection of platforms,",
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

                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 13M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("WeVideo"),
                AddDate = DateTime.Now,
                TryURL = "https://www.wevideo.com/sign-up",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Animoto Basic

            ca = new CloudApplication()
            {
                Brand = "Animoto",
                ServiceName = "Basic",
                CompanyURL = "https://animoto.com/personal/pricing",
                Description = "Animoto Basic is a cloud-based video creation service that produces video from photos, video clips, and music into video slideshows. Animoto makes it easy to create professional-quality videos on your computer and mobile device. We believe that video is the most powerful way to communicate what you care most deeply about, whether that’s your family, business, or a cause. Animoto ensures that making videos isn't limited to those with technical know-how and expensive production equipment.",
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
                    repository.FindBrowserByName("IE9"),

                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 7M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Animoto"),
                AddDate = DateTime.Now,
                TryURL = "https://animoto.com/personal/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Animoto Memory Keeper

            ca = new CloudApplication()
            {
                Brand = "Animoto",
                ServiceName = "Memory Keeper",
                CompanyURL = "https://animoto.com/personal/pricing",
                Description = "Memory Keeper is the top level of service from Animoto - providing unlimited, HD-quality videos. With an extended range of soundtrack options and export alternatives, it's a cloud-based video creation service that produces video from photos, video clips, and music into video slideshows. Animoto ensures that making videos isn't limited to those with technical know-how and expensive production equipment.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
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
                    //repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 14M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Animoto"),
                AddDate = DateTime.Now,
                TryURL = "https://animoto.com/personal/pricing",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe PhoneGap

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "PhoneGap",
                CompanyURL = "https://creative.adobe.com/products/phonegap-build",
                Description = "Adobe PhoneGap allows you to create mobile apps using the web tools you love - HTML, CSS, and JavaScript - and then easily compile them for multiple platforms in the cloud.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://build.phonegap.com/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Como Gold

            ca = new CloudApplication()
            {
                Brand = "Como",
                ServiceName = "Gold",
                CompanyURL = "http://www.como.com/pricing/",
                Description = "Como's unique auto-discovery technology grabs your existing online content and builds your app in seconds. Choose from a wide range of features, styles, backgrounds, and colour themes to match the look and feel of your brand. Create, publish, promote, and manage your app from one control panel. View analytics and keep track of your performance.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 33M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Como"),
                AddDate = DateTime.Now,
                TryURL = "http://www.como.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Como Platinum

            ca = new CloudApplication()
            {
                Brand = "Como",
                ServiceName = "Platinum",
                CompanyURL = "http://www.como.com/pricing/",
                Description = "Como Platinum is the power-user version of the software - providing greater commercial freedom and increased allowances on push notificatons. It's unique auto-discovery technology grabs your existing online content and builds your app in seconds. Create, publish, promote, and manage your app from one control panel. View analytics and keep track of your performance - and even white label for your customer needs.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    repository.FindLanguageByName("SPANISH"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 83M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Como"),
                AddDate = DateTime.Now,
                TryURL = "http://www.como.com/pricing/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Knack Starter

            ca = new CloudApplication()
            {
                Brand = "Knack",
                ServiceName = "Starter",
                CompanyURL = "https://www.knackhq.com/pricing/",
                Description = "Knack is the easiest way to build your own online database and web apps. With Knack anyone can build apps to access your data from anywhere, run reports and analytics, and share it with your users, employees, or customers. You can publish your apps to any website or blog.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 25M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Knack"),
                AddDate = DateTime.Now,
                TryURL = "https://www.knackhq.com/signup/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Knack Pro

            ca = new CloudApplication()
            {
                Brand = "Knack",
                ServiceName = "Pro",
                CompanyURL = "https://www.knackhq.com/pricing/",
                Description = "Knack is the easiest way to build your own online database and web apps. Knack Pro provides increased limits on storage, apps and records - in addition to enhanced customer support. With Knack anyone can build apps to access your data from anywhere, run reports and analytics, and share it with your users, employees, or customers. You can publish your apps to any website or blog.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 49M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Knack"),
                AddDate = DateTime.Now,
                TryURL = "https://www.knackhq.com/signup/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Knack Corporate

            ca = new CloudApplication()
            {
                Brand = "Knack",
                ServiceName = "Corporate",
                CompanyURL = "https://www.knackhq.com/pricing/",
                Description = "Knack Corporate is the highest level of service - providing premier customer support and our maximum level of apps, storage and records. Knack is the easiest way to build your own online database. With Knack anyone can build apps to access your data from anywhere, run reports and analytics, and share it with your users, employees, or customers. For power users we have expansion options if you need a bigger plan.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 149M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("14"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Knack"),
                AddDate = DateTime.Now,
                TryURL = "https://www.knackhq.com/signup/",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Adobe Flash

            ca = new CloudApplication()
            {
                Brand = "Adobe",
                ServiceName = "Flash",
                CompanyURL = "https://www.adobe.com/products/flash.html",
                Description = "Adobe Flash software is a development environment for building games and applications. With the new HTML5 Canvas support in Flash Professional CC, you can create modern web content in a familiar authoring environment.",
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
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    repository.FindLanguageByName("RUSSIAN"),
                    repository.FindLanguageByName("ARABIC"),
                    repository.FindLanguageByName("PORTUGESE"),
                    repository.FindLanguageByName("FRENCH"),
                    repository.FindLanguageByName("GERMAN"),
                    repository.FindLanguageByName("JAPANESE"),
                    repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("INDONESIAN"),
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("USD"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("30"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Adobe"),
                AddDate = DateTime.Now,
                TryURL = "https://creative.adobe.com/products/download/flash",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Mobile Roadie Core

            ca = new CloudApplication()
            {
                Brand = "Mobile Roadie",
                ServiceName = "Core",
                CompanyURL = "http://mobileroadie.com/signup",
                Description = "Mobile Roadie is an app creator that allows anyone to create and manage their own app or mobile website at a reasonable price. Mobile Roadie is the most powerful mobile app creator for iPhone, Android, iPad and Mobile Web. Build, host, and create apps in minutes.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 100M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Mobile Roadie"),
                AddDate = DateTime.Now,
                TryURL = "http://mobileroadie.com/signup",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Mobincube Standard

            ca = new CloudApplication()
            {
                Brand = "Mobincube",
                ServiceName = "Standard",
                CompanyURL = "http://www.mobincube.com/pricing.html",
                Description = "Mobincube is made for humans, not for geeks. Build your own app in a really easy way... even a lawyer can do it! Building your Apps FOR FREE with Mobincube, we will include some ads inside them and you'll earn 70% of the revenue from advertisement. It's such simple: the more Apps you publish, the more money you'll make.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 9.99M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Mobincube"),
                AddDate = DateTime.Now,
                TryURL = "http://www.mobincube.com/pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Mobincube Freelancer

            ca = new CloudApplication()
            {
                Brand = "Mobincube",
                ServiceName = "Freelancer",
                CompanyURL = "http://www.mobincube.com/pricing.html",
                Description = "The Mobincube Freelancer service allows you to create unlimited apps and provides an extended limit on pushes.  You'll find a template that fits your needs. Each one has a step-by-step wizard that helps you build your app in minutes. Mobincube Freelancer provides more storage and ad-free apps. Whatsmore, it easy to upgrade as you get more successful.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 49.99M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Mobincube"),
                AddDate = DateTime.Now,
                TryURL = "http://www.mobincube.com/pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Mobincube Agency

            ca = new CloudApplication()
            {
                Brand = "Mobincube",
                ServiceName = "Agency",
                CompanyURL = "http://www.mobincube.com/pricing.html",
                Description = "The Mobincube Agency service provides our highest limits on apps, storage and push notifications. The service is for our most serious user/buyer. Unlike our other levels of service, developers can use web widgets to download apps under their own brand.",
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
                    repository.FindBrowserByName("IE9"),
                    
                    repository.FindBrowserByName("IE11"),
                    repository.FindBrowserByName("IE10"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                    //repository.FindBrowserByName("OPERA"),
                },

                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH"),
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("SPANISH"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL"),
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
                    //repository.FindFeatureByName("Animated images"),
                    repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    //repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    //repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    //repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                ApplicationCostPerMonth = 99.99M,
                //ApplicationCostPerMonthPOA = true,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = true,
                ApplicationCostPerMonthAvailable = true,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),
                SetupFee = repository.FindSetupFeeByName("NO"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("Mobincube"),
                AddDate = DateTime.Now,
                TryURL = "http://www.mobincube.com/pricing.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Photo video suite

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Photo video suite",
                CompanyURL = "http://www.paintshoppro.com/en/products/photo-video-suite/default.html",
                Description = "Get everything you need to create your best photos and videos ever, together in one affordable package. Corel Photo Video Suite X7 combines the creative power of PaintShop Pro X7 and Video Studio X7 in one total package. Manage, adjust and edit your photos with the intuitive editing features and fun creative tools in PaintShop Pro X7.",
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
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    //repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("61.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.paintshoppro.com/en/products/photo-video-suite/default.html",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #region Corel Video studio ultimate

            ca = new CloudApplication()
            {
                Brand = "Corel",
                ServiceName = "Video studio ultimate",
                CompanyURL = "http://www.videostudiopro.com/en/products/videostudio/ultimate/default.html?x-source=atg_pid&utm_source=ATG&utm_medium=nav&utm_campaign=VideoStudio_Ultimate_X7",
                Description = "With a bold new 64-bit architecture, including a comprehensive 64-bit premium special effects pack, featuring 7 powerful FX applications, Corel VideoStudio Ultimate X7 is the easiest and most powerful VideoStudio ever. With faster rendering and more pro-quality video-editing tools, all within a simplified interface, VideoStudio Ultimate makes it faster to make the videos you love to create. Explore the benefits of FastFlick, an easy 3-step way to quickly make and share great-looking movies in less time.",
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
                    //repository.FindLanguageByName("MANDARIN"),
                    //repository.FindLanguageByName("HINDI"),
                    //repository.FindLanguageByName("RUSSIAN"),
                    //repository.FindLanguageByName("ARABIC"),
                    //repository.FindLanguageByName("PORTUGESE"),
                    //repository.FindLanguageByName("FRENCH"),
                    //repository.FindLanguageByName("GERMAN"),
                    //repository.FindLanguageByName("JAPANESE")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("COMMUNITY/FORUM"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ/KNOWLEDGE BASE"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportOffered = false,
                //SupportHours = repository.FindSupportHoursByName("24 Hours"),
                //SupportHoursTimeZone = repository.FindTimeZoneByName("GMT"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("Animated images"),
                    //repository.FindFeatureByName("App design"),
                    //repository.FindFeatureByName("Audio editing"),
                    repository.FindFeatureByName("3D/CAD"),
                    //repository.FindFeatureByName("Content library"),
                    //repository.FindFeatureByName("Diagram design"),
                    //repository.FindFeatureByName("eBook publishing"),
                    //repository.FindFeatureByName("Graphics tools"),
                    repository.FindFeatureByName("Photo editing"),
                    //repository.FindFeatureByName("Interactive animation"),
                    //repository.FindFeatureByName("Presentation creation"),
                    //repository.FindFeatureByName("Publishing tools"),
                    repository.FindFeatureByName("Video creation"),
                    repository.FindFeatureByName("Video editing"),
                    //repository.FindFeatureByName("Website design"),
                },
                //ApplicationCostPerMonth = 19.99M,
                //ApplicationCostPerAnnum = 59.00M,
                ApplicationCostPerMonthFree = false,
                ApplicationCostPerMonthOffered = false,
                ApplicationCostPerMonthAvailable = false,
                ApplicationCostPerAnnumFree = false,
                ApplicationCostPerAnnumOffered = false,
                ApplicationCostPerAnnumAvailable = false,
                CloudApplicationCurrency = repository.GetCurrencyByShortName("GBP"),

                SetupFee = repository.FindSetupFeeByName("46.99"),
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CREATIVE"),
                Vendor = repository.FindVendorByName("COREL"),
                AddDate = DateTime.Now,
                TryURL = "http://www.videostudiopro.com/en/products/videostudio/ultimate/default.html?x-source=atg_pid&utm_source=ATG&utm_medium=nav&utm_campaign=VideoStudio_Ultimate_X7",
            };

            //InsertDocumentLinks(repository, ca);
            SetLiveStatuses(ca, repository);
            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion

            Console.WriteLine("Finished Creative");
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
