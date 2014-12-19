using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;
using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
using CompareCloudware.Domain.Contracts.Repositories;
using System.Text.RegularExpressions;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class ReferenceData
    {
        public static bool TestLaptop(QueryRepository repository)
        {
            bool retVal = true;
            Category c;
            FeatureType ft;

            #region CATEGORIES
            c = new Category()
            {
                //CategoryName = "Voice"
                CategoryName = "Communications",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "CRM",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                //CategoryName = "Web Conference"
                CategoryName = "Web Conferencing",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Email",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Office",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Storage And Backup",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Project Management",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Financial",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Security",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            #endregion
            
            return retVal;
        }

        #region PumpStatuses
        public static bool PumpStatuses(QueryRepository repository)
        {
            Status s;
            bool retVal = true;

            #region STATUSES
            s = new Status()
            {
                StatusName = "Live",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Suspended",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Mediation",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Promotion",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Deleted",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Incomplete",
            };
            repository.AddStatus(s);
            s = new Status()
            {
                StatusName = "Approval",
            };
            repository.AddStatus(s);
            #endregion

            return retVal;
        }
        #endregion

        #region PumpSiteAnalyticTypes
        public static bool PumpSiteAnalyticTypes(ICompareCloudwareContext context)
        {
            //this.FakeContext = context;
            ICompareCloudwareRepository repository = new QueryRepository(context);
            SiteAnalyticType s;
            bool retVal = true;

            #region SITE ANALYTIC TYPES
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ShopVisitNonCategory",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ShopVisitViaCategory",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ShopVisitNonCategoryIdentified",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ShopVisitViaCategoryIdentified",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "TryFormSubmission",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "BuyFormSubmission",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "EMailSubmission",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickCaseStudy",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickWhitePaper",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickVideo",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickProductReview",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickHomePageCompare",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickCategoryPageCompare",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InComparisonResultsFromClickHomePageCompare",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InComparisonResultsFromClickCategoryPageCompare",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsTop10OnHomePage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsNewOnHomePage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsFeaturedOnHomePage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsTop10OnCategoryPage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsNewOnCategoryPage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "InViewResultsFeaturedOnCategoryPage",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickFilter",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickCategory",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            s = new SiteAnalyticType()
            {
                SiteAnalyticTypeName = "ClickSearchAutoComplete",
                AddDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };
            repository.AddSiteAnalyticType(s);
            #endregion


            return retVal;
        }
        #endregion

        #region PumpLevel1ReferenceData
        public static bool PumpLevel1ReferenceData(QueryRepository repository)
        {
            bool retVal = true;
            Category c;
            CategoryParameters cp;
            FeatureType ft;
            Industry i;
            Currency cur;

            #region CATEGORIES
            c = new Category()
            {
                //CategoryName = "Voice"
                CategoryName = "Communications",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee-per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",

                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "CRM",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                //CategoryName = "Web Conference"
                CategoryName = "Web Conferencing",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Email",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Office",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Storage And Backup",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Project Management",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Financial",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Security",
                CategoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                //SearchResultsMonthlyPriceColumnHeader = "Per-user-per-month",
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);
            #endregion

            #region FEATURETYPES
            ft = new FeatureType()
            {
                FeatureTypeName = "Category",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "LicenceTypeMinimum",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "LicenceTypeMaximum",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "OperatingSystem",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "Browser",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "Feature",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportType",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportDays",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportHours",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "Language",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "ApplicationFeature",
                FeatureTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFeatureType(ft);
            
            #endregion

            #region CURRENCIES
            cur = new Currency()
            {
                CurrencyName = "Sterling",
                CurrencyShortName = "GBP",
                CurrencySymbol = "£",
                ExchangeRateSterling = 1,
                CurrencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCurrency(cur);


            cur = new Currency()
            {
                CurrencyName = "US Dollars",
                CurrencyShortName = "USD",
                CurrencySymbol = "$",
                ExchangeRateSterling = 1.5M,
                CurrencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCurrency(cur);

            cur = new Currency()
            {
                CurrencyName = "Australian Dollars",
                CurrencyShortName = "AUD",
                CurrencySymbol = "$",
                ExchangeRateSterling = 2M,
                CurrencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCurrency(cur);

            cur = new Currency()
            {
                CurrencyName = "Euros",
                CurrencyShortName = "EUR",
                CurrencySymbol = "?",
                ExchangeRateSterling = 0.6M,
                CurrencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCurrency(cur);

            #endregion

            string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Scripts/");
            StreamReader sr = new StreamReader(serverFilePath + "linkedin_industries.js");
            string val = sr.ReadToEnd();
            AllIndustries result1 = JsonConvert.DeserializeObject<AllIndustries>(val);
            result1.Industries.ToList().ForEach(x => repository.AddIndustry(x));
            result1.Industries.ToList().ForEach(x => x.IndustryStatus = repository.FindStatusByName("LIVE"));
            return retVal;
        }
        #endregion

        #region PumpLevel2ReferenceData
        public static bool PumpLevel2ReferenceData(QueryRepository repository)
        {
            bool retVal = true;
            Feature f;
            Feature parentFeature;
            CompareCloudware.Domain.Models.OperatingSystem o;
            MobilePlatform mp;
            Browser b;
            LicenceTypeMinimum ltMin;
            LicenceTypeMaximum ltMax;
            Language l;
            SupportType st;
            SupportDays sd;
            SupportHours sh;
            SupportTerritory sterritory;
            MinimumContract mc;
            PaymentFrequency pf;
            SetupFee sf;
            PaymentOption po;
            FreeTrialPeriod ftp;
            Vendor v;
            CloudApplicationDocumentType dt;
            CloudApplicationDocumentFormat df;
            AdvertisingImageType ait;
            TagType tt;
            ContentTextType ctt;
            Device d;
            RequestType rt;
            CompareCloudware.Domain.Models.TimeZone tz;
            //CloudApplicationApplication caa;

            #region FEATURES

            #region PHONE FEATURES
            f = new Feature()
            {
                FeatureName = "Use Existing Handset",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Keep Existing Number",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Emergency Calls",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "PC Required (for Calls)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive UK Landline Calls",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive Mobile Calls",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive International Calls (Landline Only)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Virtual Landline Number",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Local Dialling Code",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Freephone/Local Rate Number",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Dial-by-name Directory",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Group Video Calling",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Auto-Reception/Call Handling",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Answering Rules",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Call Centre/Interactive Voice Response",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Music-on-hold",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Voicemail",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SMS Sending",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Call Forwarding",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Integration",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Hardware Supplied",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("COMMUNICATIONS"));
            repository.AddFeature(f);
            #endregion

            #region CRM FEATURES
            f = new Feature()
            {
                FeatureName = "Unlimited Contacts",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Storage Included (for Documents, PPTs, PDFs)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Sales Opportunity Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Sales Forecasting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web to Lead Form",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Marketing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Campaign Tracking and Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customer Helpdesk",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Case Queueing & Tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Cases",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Custom Reports",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Full SSL Security",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invoice Creation & Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inventory & Order Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Open API/3rd Party Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "User Customization",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CRM"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CRM"));
            repository.AddFeature(f);
            #endregion

            #region WEB CONFERENCING FEATURES
            f = new Feature()
            {
                FeatureName = "Maximum Meeting Attendees",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Maximum Webinar/Event Attendees",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "High Definition Video",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Presenter Preparation Mode",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multiple Meeting Hosts/Chairperson",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual Usage Reports",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "'On The Fly' Invitations For Additional Participants",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant Meeting Function",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Active Speaker Video Switching",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Full Desktop Sharing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Single Application Share",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Upload Multiple Presentations",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Private Chat Mode",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interactive Training",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Record & Replay Service",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interface Company Branding",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inactivity Time Out",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fixed Line & Mobile Dial-In",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Call Me/Toll Free",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Outlook Integration (to book meetings)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("WEB CONFERENCING"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEB CONFERENCING"));
            repository.AddFeature(f);
            #endregion

            #region EMAIL FEATURES
            f = new Feature()
            {
                FeatureName = "Number of Mailboxes/Email Addresses",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Storage Limit",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual File Size Limit (Attachments)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "No Daily Mail Limits (Inbox/Outbox)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Migrate Company Domain",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Anti-Virus",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Spam Guard / Anti-Phishing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Block Addresses / Blacklist",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Aliases",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Ad-free",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Archiving",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Quick Filter Toolbar",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Smart Folders",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Account Groups",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant Messaging (IM)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Track Conversations",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Outlook Compatible",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Migration Service",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("EMAIL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("EMAIL"));
            repository.AddFeature(f);
            #endregion

            #region OFFICE FEATURES
            f = new Feature()
            {
                FeatureName = "Storage size limit for documents",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                CanBeBooleanAndDataDriven = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Auto back-up drive for device content",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Data archiving & retrieval",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Company-wide data discovery & export",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Team document shared workspace",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                CanBeBooleanAndDataDriven = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Active Directory synchronisation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "MS Office Compatible",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Offline Mode (for Desktop Editing)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Document Revision History",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Document Password Protection",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "3rd Party APIs",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "SSL Security/Encryption",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("OFFICE"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            #endregion

            #region STORAGE AND BACKUP
            f = new Feature()
            {
                FeatureName = "Storage Limit",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual File Limit",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Adjust Transfer Speed / Bandwidth Used",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Data Transfer",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Storage",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Version History",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Undelete Files (up to 30 days)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "No Bandwidth Throttling",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "One-Click Sharing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Drag & Drop Multiple Files",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-User Access",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Password Protected Folder Sharing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Role Based Access",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Search Within Documents",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Local Back-Up",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Server Back-Up",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Back-Up",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Store Video e.g. Movies",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Guaranteed Restore",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Back-Up",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("STORAGE AND BACKUP"));
            repository.AddFeature(f);
            #endregion

            #region PROJECT MANAGEMENT
            f = new Feature()
            {
                FeatureName = "Number Of Projects",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "File Storage",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-Users Per Account",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Sharing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Shared Workspace",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Edited Document Tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Lockfiles",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Update & Deadline Alerts",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interactive GANTT Charts",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Time Budget Tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Client Invoicing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Wiki",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customised Reports",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Project Compatible",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Document Security",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Guaranteed Restore",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Offline Mode",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party APIs",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Bug Tracker",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PROJECT MANAGEMENT"));
            repository.AddFeature(f);
            #endregion

            #region FINANCIAL
            f = new Feature()
            {
                FeatureName = "Unlimited Transactions",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Customer Records",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Supplier Records",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Product & Service Descriptions",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Create Invoices",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invoice-to-Payment Matching",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-Currency Invoicing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Record Bank Payments",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customised Reports",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Accounting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "External Access (for Accountants)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-User Access",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Excel Compatible",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fixed Asset Depreciation Tool",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customer Statements",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Purchase Order System",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Payroll",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "VAT Filing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party API",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("FINANCIAL"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("FINANCIAL"));
            repository.AddFeature(f);
            #endregion

            #region SECURITY
            f = new Feature()
            {
                FeatureName = "Cloud-centric service delivery",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Cloud-based threat detection/interception",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Cloud-based updates",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Antivirus protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Malware protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SPAM protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Rootkit protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Spyware protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Additional Firewall security",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web browsing restriction",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web browsing control",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web browsing protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "USB, port, CD/DVD control",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Create bootable rescue drives",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Central, remote administration",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Access registration to protect sensitive content",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Outbound email & document control",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Outbound email encryption",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Image/attachment control",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "User level web browser reporting",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Offline end-point protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Threat sandboxing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Intrusion Prevention System",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Device location map",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Bluetooth hacking",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Remote data wipe",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Quantantine mobile infiltrations",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SMS spam protection",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SECURITY"));
            repository.AddFeature(f);
            #endregion

            #endregion

            #region APPLICATIONFEATURES
            
            //WORD PARENT
            f = new Feature()
            {
                FeatureName = "Word Processor",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;

            //WORD CHILDREN
            f = new Feature()
            {
                FeatureName = "Advanced Proofing & Editing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Advanced Referencing & Editing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mailing Features",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;
            
            
            //SPREADSHEET PARENT            
            f = new Feature()
            {
                FeatureName = "Spreadsheet",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            
            //SPREADSHEET CHILDREN
            f = new Feature()
            {
                FeatureName = "Formula Management",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Data Management",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Advanced Charting & Tables",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            
            //PRESENTATION PARENT
            f = new Feature()
            {
                FeatureName = "Presentation",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;
            
            //PRESENTATION CHILDREN
            f = new Feature()
            {
                FeatureName = "Advanced Design & Animation",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Real-Time Collaboration",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Version Management",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Large Video Files >50MB",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Own Branding",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            
            //CONFERENCING PARENT
            f = new Feature()
            {
                FeatureName = "Conferencing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;            
            
            //CONFERENCING CHILDREN
            f = new Feature()
            {
                FeatureName = "Desktop sharing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant messaging",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Desktop video conferencing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Desktop VoIP",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Presence tools",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            
            //NOTES PARENT
            f = new Feature()
            {
                FeatureName = "Notes",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;

            //NOTES CHILDREN
            f = new Feature()
            {
                FeatureName = "Read & Edit",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Save Web Content",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Image Capture",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Sync (for use on other devices)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            //WEB PUBLISHING PARENT
            f = new Feature()
            {
                FeatureName = "Web publishing",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            parentFeature = f;

            //WEB PUBLISHING CHILDREN
            f = new Feature()
            {
                FeatureName = "Web Publishing e.g. Blog",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Internal Website (Intranet)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "External Customer Website (Extranet)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                SuppressFilterBehaviour = true,
                ParentFeature = parentFeature,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Email (comprehensive client)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email security & anti-spam",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email storage limit per user",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                IsDataDriven = true,
                //DataDrivenField = "THIS",
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = "BYTES",
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                CanBeBooleanAndDataDriven = true,
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email content translation",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Contact Management",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Shared Calendar",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Management / Task Manager",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Collaboration (real-time)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Collaborative diagramming/mapping",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document consumption analytics",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            repository.AddFeature(f);

            #endregion

            #region OPERATING SYSTEMS
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Mac",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Linux",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "iPad",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Apple",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Android",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Symbian",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "OSX",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win XP",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win Vista",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win 7",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win 8",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Apple iOS",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Windows 8 RT",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "BBOS",
                OperatingSystemStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddOperatingSystem(o);
            #endregion

            #region MOBILE PLATFORMS
            //mp = new MobilePlatform()
            //{
            //    MobilePlatformName = "All"
            //};
            //repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Android",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "iPhone",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Win",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            //mp = new MobilePlatform()
            //{
            //    MobilePlatformName = "BB"
            //};
            //repository.AddMobilePlatform(mp);
            //mp = new MobilePlatform()
            //{
            //    MobilePlatformName = "No"
            //};
            //repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "iPad",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Apple",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Blackberry",
                MobilePlatformStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMobilePlatform(mp);
            #endregion

            #region BROWSERS
            b = new Browser()
            {
                BrowserName = "IE6",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "IE7",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "IE8",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "IE9",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Firefox",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Safari",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Opera",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Chrome",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            #endregion

            #region LICENCE TYPE MINIMUM
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 1,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 2,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 5,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 6,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 3,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 4,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 8,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 10,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 11,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 12,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 16,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 21,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 25,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 26,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 50,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = 100,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);
            #endregion

            #region LICENCE TYPE MAXIMUM
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 1,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 2,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 3,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 5,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 6,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 7,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 8,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 9,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 10,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 15,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 20,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 24,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 25,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 30,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 50,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 60,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 99,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 100,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 250,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 251,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 500,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 999,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 16384,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);
            #endregion

            #region LANGUAGES
            l = new Language()
            {
                LanguageName = "N/A",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Arabic",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Br Portugese",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Brazilian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Bulgarian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Catalan",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Chinese (Simplified)",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Chinese (Traditional)",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Croatian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Czech",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Danish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Dutch",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "English",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Estonian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Finnish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "French",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "German",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Greek",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Hebrew",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Hungarian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Indonesian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Italian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Japanese",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Korean",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Latvian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Lithuanian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Malay",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Norwegian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Polish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Portugese",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Romanian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Russian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Serbian-Latin",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Slovak",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Slovenian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Spanish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Spanish (Latin America)",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Spanish (Spain)",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Spanish (European and Latin American)",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Swedish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Turkish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Thai",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Turkish",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Ukranian",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            l = new Language()
            {
                LanguageName = "Vietnamese",
                LanguageStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLanguage(l);
            #endregion

            #region SUPPORT TYPES
            st = new SupportType()
            {
                SupportTypeName = "Online",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Technical",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Telephone",
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Email",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            //st = new SupportType()
            //{
            //    SupportTypeName = "FAQ",
            //    IsPassive = true,
            //};
            //repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Troubleshoot",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "FAQ/Knowledge Base",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Community/Forum",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            //st = new SupportType()
            //{
            //    SupportTypeName = "Free Telephone",
            //};
            //repository.AddSupportType(st);
            //st = new SupportType()
            //{
            //    SupportTypeName = "Local Rate Telephone",
            //};
            //repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Troubleticket",
                IsPassive = true,
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            //st = new SupportType()
            //{
            //    SupportTypeName = "Toll Free Phone"
            //};
            //repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Chat",
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "CallBack",
                SupportTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportType(st);
            #endregion

            #region SUPPORT DAYS
            sd = new SupportDays()
            {
                SupportDaysName = "ALL",
                IgnoreFilterPredicate = true,
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "7",
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "5",
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "N/A",
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "Mon-Fri",
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "6",
                SupportDaysStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportDays(sd);
            #endregion

            #region SUPPORT HOURS
            sh = new SupportHours()
            {
                SupportHoursName = "ALL",
                SupportHoursFrom = 0,
                SupportHoursTo = 2400,
                IgnoreFilterPredicate = true,
                SupportHoursStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "24 hours",
                SupportHoursFrom = 0,
                SupportHoursTo = 2400,
                SupportHoursStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "12 hours (business)",
                SupportHoursFrom = 900,
                SupportHoursTo = 2100,
                SupportHoursStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "12 hours",
                SupportHoursFrom = 900,
                SupportHoursTo = 2100,
                SupportHoursStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportHours(sh);


            for (int hoursFrom = 1; hoursFrom < 24; hoursFrom++)
            {
                for (int hoursTo = hoursFrom + 1; hoursTo < 24; hoursTo++)
                {
                    string supportHoursName = "";
                    
                    supportHoursName += hoursFrom < 13 ? hoursFrom.ToString() : (hoursFrom-12).ToString();
                    supportHoursName += hoursFrom < 12 ? "am" : "pm";
                    supportHoursName += "-";
                    supportHoursName += hoursTo > 12 ? (hoursTo-12).ToString() : hoursTo.ToString();
                    supportHoursName += hoursTo > 12 ? "pm" : "am";

                    sh = new SupportHours()
                    {
                        SupportHoursName = supportHoursName,
                        SupportHoursFrom = hoursFrom * 100,
                        SupportHoursTo = hoursTo * 100,
                        SupportHoursStatus = repository.FindStatusByName("LIVE"),
                    };
                    repository.AddSupportHours(sh);
                }
            }
            
            
            
            
            
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "9am-6pm",
            //    SupportHoursFrom = 9,
            //    SupportHoursTo = 18,
            //};
            //repository.AddSupportHours(sh);
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "N/A"
            //};
            //repository.AddSupportHours(sh);
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "9am-5pm",
            //    SupportHoursFrom = 9,
            //    SupportHoursTo = 17,
            //};
            //repository.AddSupportHours(sh);
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "8am-8pm",
            //    SupportHoursFrom = 8,
            //    SupportHoursTo = 20,
            //};
            //repository.AddSupportHours(sh);
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "8am-5pm",
            //    SupportHoursFrom = 8,
            //    SupportHoursTo = 17,
            //};
            //repository.AddSupportHours(sh);
            //sh = new SupportHours()
            //{
            //    SupportHoursName = "8am-7pm",
            //    SupportHoursFrom = 8,
            //    SupportHoursTo = 19,
            //};
            //repository.AddSupportHours(sh);
            #endregion

            #region TIMEZONES
            tz = new Domain.Models.TimeZone()
            {
                GMTDifference = 0,
                TimeZoneName = "ALL",
                IgnoreFilterPredicate = true,
                TimeZoneStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTimeZone(tz);
            //tz = new Domain.Models.TimeZone()
            //{
            //    GMTDifference = 0,
            //    TimeZoneName = "GMT",
            //};
            //repository.AddTimeZone(tz);
            //tz = new Domain.Models.TimeZone()
            //{
            //    GMTDifference = -7,
            //    TimeZoneName = "EST",
            //};
            //repository.AddTimeZone(tz);
            //tz = new Domain.Models.TimeZone()
            //{
            //    GMTDifference = -7,
            //    TimeZoneName = "PST",
            //};
            //repository.AddTimeZone(tz);

            string timezone = "GMT";
            for (int difference = -12; difference < 13; difference++)
            {
                
                if (difference == -5)
                {
                    timezone = "EST";
                }
                else if (difference == -8)
                {
                    timezone = "PST";
                }
                else
                {
                    timezone = difference.ToString();
                }
                tz = new Domain.Models.TimeZone()
                {
                    GMTDifference = difference,
                    TimeZoneName = difference == 0 ? "GMT" : timezone,
                    TimeZoneStatus = repository.FindStatusByName("LIVE"),
                };
                repository.AddTimeZone(tz);
            }
            #endregion

            #region SUPPORT TERRITORIES
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "UK",
                SupportTerritoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "Global",
                SupportTerritoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "US",
                SupportTerritoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "Australia",
                SupportTerritoryStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSupportTerritory(sterritory);
            #endregion

            #region MINIMUM CONTRACTS
            mc = new MinimumContract()
            {
                MinimumContractName = "No",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "6",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "12",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "24",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "1",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "36",
                MinimumContractStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddMinimumContract(mc);
            //mc = new MinimumContract()
            //{
            //    MinimumContractName = "1 Year"
            //};
            //repository.AddMinimumContract(mc);
            //mc = new MinimumContract()
            //{
            //    MinimumContractName = "N/A"
            //};
            //repository.AddMinimumContract(mc);
            #endregion

            #region PAYMENT FREQUENCIES
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "Monthly",
                PaymentFrequencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "No",
                PaymentFrequencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "On-demand",
                PaymentFrequencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "Annual",
                PaymentFrequencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "One-Off",
                PaymentFrequencyStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentFrequency(pf);
            #endregion

            #region SETUP FEES
            sf = new SetupFee()
            {
                SetupFeeName = "No",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "POA",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "27.97",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "14.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "4.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "130.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "29.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "20.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "24.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "25.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "49.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "9.21",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "19.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "99.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "75.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "25.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "35.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "19.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            #endregion

            #region PAYMENT OPTIONS
            po = new PaymentOption()
            {
                PaymentOptionName = "Credit Card",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Pre-Pay",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Direct Debit",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Debit Card",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "PayPal",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Invoice",
                PaymentOptionStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddPaymentOption(po);
            #endregion

            #region FREE TRIAL PERIODS
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "No",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "Yes",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "30",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "7",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "14",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "15",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "60",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "45",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);
            //ftp = new FreeTrialPeriod()
            //{
            //    FreeTrialPeriodName = "Demo"
            //};
            //repository.AddFreeTrialPeriod(ftp);
            //ftp = new FreeTrialPeriod()
            //{
            //    FreeTrialPeriodName = "Test Drive"
            //};
            //repository.AddFreeTrialPeriod(ftp);
            #endregion

            #region VENDORS
            v = new Vendor()
            {
                VendorName = "Skype",
                VendorLogoFileName = "skype logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Vonage",
                VendorLogoFileName = "vonage logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\vonage logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\vonage logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Vodafone",
                VendorLogoFileName = "vodafone logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\vodafone logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\vodafone logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "VoIPtalk",
                VendorLogoFileName = "voiptalk logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\voiptalk logo.png"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\voiptalk logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Gradwell",
                VendorLogoFileName = "gradwell logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\gradwell logo.png"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\gradwell logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "RingCentral",
                VendorLogoFileName = "ring central logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\ring central logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\ring central logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "BT",
                VendorLogoFileName = "bt logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\bt logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\bt logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Tpad",
                VendorLogoFileName = "tpad logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\tpad logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\tpad logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "yourCHOICE",
                VendorLogoFileName = "yourchoicevoip logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\yourchoicevoip logo.png"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\yourchoicevoip logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "freespeech.co.uk",
                VendorLogoFileName = "freespeech.co.uk logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\freespeech.co.uk logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\freespeech.co.uk logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "magicJack",
                VendorLogoFileName = "magicjack logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\magicjack logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\magicjack logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Press1.co.uk",
                VendorLogoFileName = "press1.co.uk logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\press1.co.uk logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\press1.co.uk logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "usomo",
                VendorLogoFileName = "usomo logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\usomo logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\usomo logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "colt",
                VendorLogoFileName = "colt logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\colt logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\colt logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sureVoIP",
                VendorLogoFileName = "sure voip logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\sure voip logo.png"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\sure voip logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "NTA:LTD",
                VendorLogoFileName = "ntaltd logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\ntaltd logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\ntaltd logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sipgate",
                VendorLogoFileName = "sipgate logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\sipgate logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\sipgate logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);


            v = new Vendor()
            {
                VendorName = "Connexin",
                //VendorLogoFileName = "zscaler.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    //Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Voipfone",
                //VendorLogoFileName = "zscaler.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    //Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Timico",
                //VendorLogoFileName = "zscaler.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/Phone//",
                VendorLogo = new VendorLogo()
                {
                    //Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Salesforce",
                VendorLogoFileName = "salesforce_logo.jpeg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\salesforce_logo.jpeg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\salesforce_logo.jpeg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SUGARCRM",
                VendorLogoFileName = "sugar crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\sugar crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\sugar crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHOCRM",
                VendorLogoFileName = "zoho logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\zoho logo.gif"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\zoho logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Workbooks.com",
                VendorLogoFileName = "workbooks logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\workbooks logo.png"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\workbooks logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Dynamics",
                VendorLogoFileName = "microsoft dynamics logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\microsoft dynamics logo.png"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\microsoft dynamics logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Maximizer",
                VendorLogoFileName = "maximizer logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\maximizer logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\maximizer logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "opencrm",
                VendorLogoFileName = "open crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\open crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\open crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "TactileCRM",
                VendorLogoFileName = "tactile_crm.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\tactile_crm.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\tactile_crm.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "wecandobiz",
                VendorLogoFileName = "we can do biz logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\we can do biz logo.png"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\we can do biz logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Buddy",
                VendorLogoFileName = "buddy crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\buddy crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\buddy crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sage",
                VendorLogoFileName = "sage crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\sage crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\sage crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "webCRM",
                VendorLogoFileName = "web crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\web crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\web crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "capsule",
                VendorLogoFileName = "capsule crm logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\capsule crm logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\capsule crm logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SohoOS",
                VendorLogoFileName = "soho os logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\soho os logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\soho os logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Planet Soho",
                VendorLogoFileName = "planet-soho.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\planet-soho.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Brightpearl",
                VendorLogoFileName = "brightpearl.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\brightpearl.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Batchbook",
                VendorLogoFileName = "batchbook.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\batchbook.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "WORKetc",
                VendorLogoFileName = "worketc.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\worketc.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "AppShore",
                VendorLogoFileName = "appshore.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\appshore.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PipelineDeals",
                VendorLogoFileName = "pipelinedeals.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\pipelinedeals.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SuperOffice",
                VendorLogoFileName = "superoffice.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\superoffice.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "salesboom",
                VendorLogoFileName = "salesboom.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/CRM//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\CRM\\salesboom.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Cisco webex",
                VendorLogoFileName = "cisco-webex-logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\cisco-webex-logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\cisco-webex-logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "GoToMeeting",
                VendorLogoFileName = "gotomeeting logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\gotomeeting logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\gotomeeting logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Lync Online",
                VendorLogoFileName = "microsoft lync logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\microsoft lync logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\microsoft lync logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "LotusLive",
                VendorLogoFileName = "lotus live logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\lotus live logo.png"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\lotus live logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Infinite",
                VendorLogoFileName = "infinite conferencing logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\infinite conferencing logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\infinite conferencing logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Meeting",
                VendorLogoFileName = "zoho meeting logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\zoho meeting logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\zoho meeting logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FUZE Meeting",
                VendorLogoFileName = "fuze meeting logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\fuze meeting logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\fuze meeting logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Yugma",
                VendorLogoFileName = "yugma logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\yugma logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\yugma logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "POWWOWNOW",
                VendorLogoFileName = "powwownow logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\powwownow logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\powwownow logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "MegaMeeting",
                VendorLogoFileName = "megameeting logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\megameeting logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\megameeting logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "meetingzone",
                VendorLogoFileName = "meeting zone logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\meeting zone logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\meeting zone logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "InterCall",
                VendorLogoFileName = "intercall logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\intercall logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\intercall logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "OnSync",
                VendorLogoFileName = "onsync logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\onsync logo.png"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\onsync logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ClickMeeting",
                VendorLogoFileName = "clickmeeting.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\onsync logo.png"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\clickmeeting.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "OmniJoin",
                VendorLogoFileName = "omnijoin.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\onsync logo.png"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\omnijoin.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FUZE BOX",
                VendorLogoFileName = "fuzebox.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\onsync logo.png"),
                VendorLogoFullURL = "//Images//Logos/Web Conferencing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Web Conferencing\\fuzebox.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "YAHOO Small Business",
                VendorLogoFileName = "yahoo logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\yahoo logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\yahoo logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Exchange Online",
                VendorLogoFileName = "ms exchange online logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\ms exchange online logo.png"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\ms exchange online logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Mail",
                VendorLogoFileName = "zoho logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\zoho logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\zoho logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SMS",
                VendorLogoFileName = "sms logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\sms logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\sms logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "BlueTie",
                VendorLogoFileName = "blue tie logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\blue tie logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\blue tie logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "GMail",
                VendorLogoFileName = "gmail logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\gmail logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\gmail logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Star",
                VendorLogoFileName = "star logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\star logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\star logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
                VendorLogoFileName = "hyperoffice logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\hyperoffice logo.png"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\hyperoffice logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FastMail",
                VendorLogoFileName = "fast mail logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fast mail logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fast mail logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "webfusion",
                VendorLogoFileName = "webfusion logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\webfusion logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\webfusion logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "rackspace",
                VendorLogoFileName = "rackspace logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\rackspace logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\rackspace logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "eclipse",
                VendorLogoFileName = "eclipse logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\eclipse logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\eclipse logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FuseMail",
                VendorLogoFileName = "fusemail logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fusemail logo.png"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fusemail logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "fasthosts",
                VendorLogoFileName = "fasthosts logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fasthosts logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\fasthosts logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "INTERMEDIA",
                VendorLogoFileName = "intermedia logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\intermedia logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\intermedia logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "1&1",
                VendorLogoFileName = "1&1 logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\1&1 logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Email//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Email\\1&1 logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Office 365",
                VendorLogoFileName = "microsoft office logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\microsoft office logo.png"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\microsoft office logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Google Apps for Business",
                VendorLogoFileName = "google apps logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\google apps logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\google apps logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO docs",
                VendorLogoFileName = "zoho logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\zoho logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\zoho logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Think Free",
                VendorLogoFileName = "thinkfree logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\thinkfree logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\thinkfree logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "feng OFFICE",
                VendorLogoFileName = "feng office logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\feng office logo.png"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\feng office logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Z CUBES",
                VendorLogoFileName = "zcubes logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\zcubes logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\zcubes logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
                VendorLogoFileName = "hyperoffice logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\hyperoffice logo.png"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\hyperoffice logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "myoffice",
                VendorLogoFileName = "my office logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\my office logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\my office logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Quickoffice",
                VendorLogoFileName = "quick office logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\quick office logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\quick office logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Live Documents",
                VendorLogoFileName = "live documents logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\live documents logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\live documents logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "EVERNOTE",
                VendorLogoFileName = "evernote logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\evernote logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\evernote logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sliderocket",
                VendorLogoFileName = "slide rocket logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\slide rocket logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\slide rocket logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PREZI",
                VendorLogoFileName = "prezi logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);




            v = new Vendor()
            {
                VendorName = "IBM",
                VendorLogoFileName = "IBM.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\IBM.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "slideshare",
                VendorLogoFileName = "slideshare.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\slideshare.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "slideboom",
                VendorLogoFileName = "slideboom.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\slideboom.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "creately",
                VendorLogoFileName = "creately.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\creately.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "lucidchart",
                VendorLogoFileName = "lucidachart.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\lucidachart.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "gliffy",
                VendorLogoFileName = "gliffy.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\gliffy.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mindjet",
                VendorLogoFileName = "mindjet.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\mindjet.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mindmeister",
                VendorLogoFileName = "mindmeister.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\prezi logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Office//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Office\\mindmeister.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);



            v = new Vendor()
            {
                VendorName = "CARBONITE",
                VendorLogoFileName = "carbonite logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\carbonite logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\carbonite logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "box",
                VendorLogoFileName = "box logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\box logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\box logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "OpenDrive",
                VendorLogoFileName = "open drive logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\open drive logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\open drive logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ADrive",
                VendorLogoFileName = "adrive logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\adrive logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\adrive logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "storegate",
                VendorLogoFileName = "storegate logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\storegate logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\storegate logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SugarSync",
                VendorLogoFileName = "sugar sync logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\sugar sync logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\sugar sync logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FLIPDRIVE",
                VendorLogoFileName = "flipdrive logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\flipdrive logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\flipdrive logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mozy",
                VendorLogoFileName = "mozy logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\mozy logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\mozy logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Dropbox",
                VendorLogoFileName = "dropbox logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\dropbox logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\dropbox logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CRASHPLAN",
                VendorLogoFileName = "crashplan logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\crashplan logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\crashplan logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "elephantdrive",
                VendorLogoFileName = "elephant drive logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\elephant drive logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\elephant drive logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iDrive",
                VendorLogoFileName = "idrive logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\idrive logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\idrive logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "livedrive",
                VendorLogoFileName = "live drive logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\live drive logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\live drive logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iBackup",
                VendorLogoFileName = "ibackup logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\ibackup logo.png"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\ibackup logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "backupify",
                VendorLogoFileName = "backupify logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\backupify logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Storage And Backup//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Storage And Backup\\backupify logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Projects",
                VendorLogoFileName = "zoho projects logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\zoho projects logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\zoho projects logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "@task",
                VendorLogoFileName = "attask logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\attask logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\attask logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mavenlink",
                VendorLogoFileName = "mavenlink logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\mavenlink logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\mavenlink logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "clarizen",
                VendorLogoFileName = "clarizen logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\clarizen logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\clarizen logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ProWorkflow",
                VendorLogoFileName = "proworkflow logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\proworkflow logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\proworkflow logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
                VendorLogoFileName = "hyperoffice logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\hyperoffice logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\hyperoffice logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "WORKetc",
                VendorLogoFileName = "worketc. logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\worketc. logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\worketc. logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "LiquidPlanner",
                VendorLogoFileName = "liquidplanner logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\liquidplanner logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CELOXIS",
                VendorLogoFileName = "celoxis logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\celoxis logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\celoxis logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "blue camroo",
                VendorLogoFileName = "blue camroo logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\blue camroo logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\blue camroo logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PROJECTMANAGER.com",
                VendorLogoFileName = "project manager logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\project manager logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\project manager logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CollaborateCloud",
                VendorLogoFileName = "collaboratecloud logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\collaboratecloud logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\collaboratecloud logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "copper",
                VendorLogoFileName = "copper project logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\copper project logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\copper project logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "projectplace",
                VendorLogoFileName = "project place logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\project place logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\project place logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Basecamp",
                VendorLogoFileName = "basecamp logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\basecamp logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\basecamp logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "trafficLIVE",
                VendorLogoFileName = "traffic live logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\traffic live logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\traffic live logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iManageProject",
                VendorLogoFileName = "manage project logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\manage project logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\manage project logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "intervals",
                VendorLogoFileName = "intervals logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\intervals logo.png"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\intervals logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Geniusproject",
                VendorLogoFileName = "genius project logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\genius project logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\genius project logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "glasscubes",
                VendorLogoFileName = "glasscubes logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\glasscubes logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\glasscubes logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HARVEST",
                VendorLogoFileName = "harvest.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\glasscubes logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Project Management//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Project Management\\harvest.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "xero",
                VendorLogoFileName = "xero logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\xero logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\xero logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SageOne",
                VendorLogoFileName = "sage one logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\sage one logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\sage one logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "e-conomic",
                VendorLogoFileName = "e-conomic logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\e-conomic logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\e-conomic logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ARITHMO",
                VendorLogoFileName = "arithmo logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\arithmo logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\arithmo logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "liquid",
                VendorLogoFileName = "liquid accounts logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\liquid accounts logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\liquid accounts logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "kashoo",
                VendorLogoFileName = "kashoo logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\kashoo logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\kashoo logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FRESHBOOKS",
                VendorLogoFileName = "freshbooks logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\freshbooks logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\freshbooks logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ClearBooks",
                VendorLogoFileName = "clearbooks logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\clearbooks logo.png"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\clearbooks logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ledgerble",
                VendorLogoFileName = "ledgerble logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\ledgerble logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\ledgerble logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "KashFlow",
                VendorLogoFileName = "kashflow logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\kashflow logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\kashflow logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FreeAgent",
                VendorLogoFileName = "freeagent central logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\freeagent central logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\freeagent central logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "outright",
                VendorLogoFileName = "outright logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\outright logo.png"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\outright logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Books",
                VendorLogoFileName = "zoho books logo.png",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\zoho books logo.png"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\zoho books logo.png"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iCashbook",
                VendorLogoFileName = "icashbook logo.gif",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\icashbook logo.gif"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\icashbook logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Yendo",
                VendorLogoFileName = "yendo logo.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\yendo logo.jpg"),
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\yendo logo.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "intuit",
                VendorLogoFileName = "intuit.jpg",
                VendorLogoFullURL = "//Images//Logos/Finance//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Finance\\intuit.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ESET",
                VendorLogoFileName = "eset.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\eset.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\eset.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Symantec.cloud",
                VendorLogoFileName = "symantec-cloud.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\symantec-cloud.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\symantec-cloud.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Bit Defender",
                VendorLogoFileName = "bitdefender.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\bitdefender.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\bitdefender.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Panda",
                VendorLogoFileName = "panda.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\panda.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\panda.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Webroot",
                VendorLogoFileName = "webroot.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\webroot.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\webroot.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "McAfee",
                VendorLogoFileName = "mcafee.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\mcafee.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\mcafee.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Trend Micro",
                VendorLogoFileName = "trend.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\trend.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\trend.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "GFI Cloud",
                VendorLogoFileName = "gfi-cloud.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\gfi-cloud.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\gfi-cloud.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Zscaler",
                VendorLogoFileName = "zscaler.jpg",
                //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                VendorLogoFullURL = "//Images//Logos/Security//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Security\\zscaler.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);


            #endregion

            #region DOCUMENT TYPES
            dt = new CloudApplicationDocumentType()
            {
                CloudApplicationDocumentTypeName = "Case Study",
                CloudApplicationDocumentTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentType(dt);
            dt = new CloudApplicationDocumentType()
            {
                CloudApplicationDocumentTypeName = "White Paper",
                CloudApplicationDocumentTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentType(dt);
            #endregion

            #region DOCUMENT FORMATS
            df = new CloudApplicationDocumentFormat()
            {
                CloudApplicationDocumentFormatShortName = "PDF",
                CloudApplicationDocumentFormatLongName = "PDF Document",
                CloudApplicationDocumentFormatURLHeaderName = "application/pdf",
                CloudApplicationDocumentFormatStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentFormat(df);
            df = new CloudApplicationDocumentFormat()
            {
                CloudApplicationDocumentFormatShortName = "DOC",
                CloudApplicationDocumentFormatLongName = "Word Document",
                CloudApplicationDocumentFormatURLHeaderName = "application/msword",
                CloudApplicationDocumentFormatStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentFormat(df);
            df = new CloudApplicationDocumentFormat()
            {
                CloudApplicationDocumentFormatShortName = "PPT",
                CloudApplicationDocumentFormatLongName = "Powerpoint Document",
                CloudApplicationDocumentFormatURLHeaderName = "application/powerpoint",
                CloudApplicationDocumentFormatStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentFormat(df);
            df = new CloudApplicationDocumentFormat()
            {
                CloudApplicationDocumentFormatShortName = "HTML",
                CloudApplicationDocumentFormatLongName = "HTML Document",
                CloudApplicationDocumentFormatURLHeaderName = "application/text",
                CloudApplicationDocumentFormatStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentFormat(df);
            df = new CloudApplicationDocumentFormat()
            {
                CloudApplicationDocumentFormatShortName = "VIDEO",
                CloudApplicationDocumentFormatLongName = "Video Link",
                CloudApplicationDocumentFormatURLHeaderName = null,
                CloudApplicationDocumentFormatStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddCloudApplicationDocumentFormat(df);
            #endregion


            #region ADVERTISING IMAGE TYPES
            ait = new AdvertisingImageType()
            {
                AdvertisingImageTypeName = "MPU",
                AdvertisingImageTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddAdvertisingImageType(ait);
            ait = new AdvertisingImageType()
            {
                AdvertisingImageTypeName = "CAROUSEL",
                AdvertisingImageTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddAdvertisingImageType(ait);
            ait = new AdvertisingImageType()
            {
                AdvertisingImageTypeName = "SKYSCRAPER",
                AdvertisingImageTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddAdvertisingImageType(ait);
            #endregion

            #region TAG TYPES
            tt = new TagType()
            {
                TagTypeName = "PRIMARY",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "SECONDARY",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "TERTIARY",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "PHRASE",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "VERNACULAR",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            #endregion

            #region CONTENTTEXTTYPES
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_CATEGORY_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_CATEGORY_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINED_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINED_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINED_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);


            ctt = new ContentTextType()
            {
                ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);


            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SUBTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);





            ctt = new ContentTextType()
            {
                ContentTextTypeName = "ABOUTUS_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "ABOUTUS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "ABOUTUS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MANAGEMENTTEAM_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MANAGEMENTTEAM_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MANAGEMENTTEAM_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);








            ctt = new ContentTextType()
            {
                ContentTextTypeName = "VISION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "VISION_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "VISION_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);









            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FAQS_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FAQS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FAQS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);










            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CAREERS_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CAREERS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CAREERS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);











            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PRESS_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PRESS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PRESS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);










            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONTACTUS_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONTACTUS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONTACTUS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_TOU_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_TOU_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_GENERAL_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_GENERAL_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_SERVICES_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_SERVICES_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_CONTENT_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_CONTENT_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_THIRD_PARTY_SITES_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_THIRD_PARTY_SITES_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_USER_OBLIGATIONS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_USER_OBLIGATIONS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_IPR_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_IPR_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_LIABILITY_DISCLAIMERS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_LIABILITY_DISCLAIMERS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_NO_WARRANTY_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_NO_WARRANTY_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_INDEMNITY_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_INDEMNITY_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_SITE_AVAILABILITY_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_SITE_AVAILABILITY_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_MISC_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "TOU_MISC_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);




            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_PP_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_PP_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_BACKGROUND_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_BACKGROUND_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DEFINITIONS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DEFINITIONS_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_COLLECTED_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_COLLECTED_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_USE_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_USE_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_THIRD_PARTY_SERVICES_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_THIRD_PARTY_SERVICES_SECTION_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COB_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COB_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COB_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COB_FOOTER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_ACCESS_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_ACCESS_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_DATA_ACCESS_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_WITHHOLD_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_WITHHOLD_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_WITHHOLD_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_OWNDATA_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_OWNDATA_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_OWNDATA_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_SECURITY_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_SECURITY_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_SECURITY_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COOKIES_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COOKIES_ITEMS_SECTION_BODY_NUMBER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_COOKIES_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_CHANGES_SECTION_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PP_CHANGES_ITEMS_SECTION_BODY_ITEM",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            #endregion

            #region DEVICES
            d = new Device()
            {
                DeviceName = "Mobile",
                DeviceStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddDevice(d);
            d = new Device()
            {
                DeviceName = "Tablet",
                DeviceStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddDevice(d);
            d = new Device()
            {
                DeviceName = "Desktop",
                DeviceStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddDevice(d);
            d = new Device()
            {
                DeviceName = "Laptop",
                DeviceStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddDevice(d);
            #endregion

            #region REQUEST TYPES
            rt = new RequestType()
            {
                RequestTypeName = "FREE Trial",
                RequestTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddRequestType(rt);
            rt = new RequestType()
            {
                RequestTypeName = "Buy now",
                RequestTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddRequestType(rt);
            rt = new RequestType()
            {
                RequestTypeName = "Email page",
                RequestTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddRequestType(rt);
            #endregion


            return retVal;
        }
        #endregion


        #region PumpLevel2Phase2ReferenceData
        public static bool PumpLevel2Phase2ReferenceData(QueryRepository repository)
        {
            bool retVal = true;
            Feature f;
            Feature parentFeature;
            CompareCloudware.Domain.Models.OperatingSystem o;
            MobilePlatform mp;
            Browser b;
            LicenceTypeMinimum ltMin;
            LicenceTypeMaximum ltMax;
            Language l;
            SupportType st;
            SupportDays sd;
            SupportHours sh;
            SupportTerritory sterritory;
            MinimumContract mc;
            PaymentFrequency pf;
            SetupFee sf;
            PaymentOption po;
            FreeTrialPeriod ftp;
            Vendor v;
            CloudApplicationDocumentType dt;
            CloudApplicationDocumentFormat df;
            AdvertisingImageType ait;
            TagType tt;
            ContentTextType ctt;
            Device d;
            RequestType rt;
            CompareCloudware.Domain.Models.TimeZone tz;
            //CloudApplicationApplication caa;

            #region Browsers
            b = new Browser()
            {
                BrowserName = "IE10",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "IE11",
                BrowserStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddBrowser(b);
            #endregion

            #region SetUp Fees

            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "Demo",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);

            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "21",
                FreeTrialPeriodStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddFreeTrialPeriod(ftp);

            sf = new SetupFee()
            {
                SetupFeeName = "282.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "500",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "499.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "54.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "629.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "61.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "46.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "799.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "89.99",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "399 to 2499",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "1000",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "1500",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "3000",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "45.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "195.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            sf = new SetupFee()
            {
                SetupFeeName = "99.00",
                SetupFeeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddSetupFee(sf);

            #endregion

            tz = new Domain.Models.TimeZone
            {
                TimeZoneName = "MST",
                GMTDifference = -7,
                TimeZoneStatus = repository.FindStatusByName("LIVE")

            };

            repository.AddTimeZone(tz);

            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 200,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);

            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 19,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);

            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = 101,
                LicenceTypeMaximumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMaximum(ltMax);

            ltMin = new LicenceTypeMinimum
            {
                LicenceTypeMinimumName = 51,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);

            ltMin = new LicenceTypeMinimum
            {
                LicenceTypeMinimumName = 101,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);

            ltMin = new LicenceTypeMinimum
            {
                LicenceTypeMinimumName = 20,
                LicenceTypeMinimumStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddLicenceTypeMinimum(ltMin);

            l = new Language
            {
                LanguageName = "Mandarin",
                LanguageStatus = repository.FindStatusByName("LIVE")
            };
            repository.AddLanguage(l);

            l = new Language
            {
                LanguageName = "Hindi",
                LanguageStatus = repository.FindStatusByName("LIVE")
            };
            repository.AddLanguage(l);

            l = new Language
            {
                LanguageName = "Bengali",
                LanguageStatus = repository.FindStatusByName("LIVE")
            };
            repository.AddLanguage(l);

            #region FEATURES

            #region PAYMENTS FEATURES
            f = new Feature()
            {
                FeatureName = "Inclusive Transactions (Per Month)",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE")
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Transaction Cost",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "All Credit Cards / Debit Cards",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "PayPal Acceptance",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mail & Phone Payments",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Local / Alternative Payments",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Payments",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Free Refunds",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Reporting",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant Mass Payouts",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party Integration (APIs)",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "1-Click Payments",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-Currency Payments",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fraud Screening",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Integrated Checkout",
                Categories = new List<Category>(),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("PAYMENTS"));
            repository.AddFeature(f);

            #endregion

            #region HOSTING FEATURES
            f = new Feature()
            {
                FeatureName = "Number of Websites",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SQL Databases",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Bandwidth",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Storage",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Website Sub Domains",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Accounts",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Virtual Data Centre Services",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Wesbite Security (SSL Certificate)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Site Analytics & Reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Tool Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party Integration (APIs)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Apps Library (Widgets)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "eCommerce",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Programming Tools",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Website",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Uptime Guarantee",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HOSTING"));
            repository.AddFeature(f);

            #endregion

            #region WEBSITE FEATURES
            f = new Feature()
            {
                FeatureName = "Bandwidth",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Storage",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = true,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Free Template Themes",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Responsive",
                Categories = new List<Category>(),
                IsDataDriven = true,
                OutputDisplayType = "INT",
                OutputDisplayDescriptor = null,
                IsDataCeilingDriven = true,
                HasCount = true,
                HasCountSuffix = false,
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Blog Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Site Analytics/Reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Certificate",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Store/Shop Creation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SEO Service",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Google Ads Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Live Chat Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Design Tools",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Photo & Video Editing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Uptime Guarantee",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("WEBSITE"));
            repository.AddFeature(f);

            #endregion

            #region HR FEATURES
            f = new Feature()
            {
                FeatureName = "Holiday/Sickness Tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Appraisal Performance",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Expenses",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Self-Service Portal",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Library",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Recruitment",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Workforce Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Training & Development",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Compliance, Health & Safety",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party Integration (APIs)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Timesheets",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Payroll",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Case Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email / Memos",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Uptime Guarantee",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("HR"));
            repository.AddFeature(f);

            #endregion

            #region SALES FEATURES
            f = new Feature()
            {
                FeatureName = "Deal Management / Tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Contact Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Access",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Set Goals / Targets",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Sales Activity Reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Import Data / Contacts",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Lead Scoring / Routing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customised Interface",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Marketing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Marketing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party Integration (APIs)",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Storage",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Visitor Analytics",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Telephone Integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Lead Age Management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Uptime Guarantee",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("SALES"));
            repository.AddFeature(f);

            #endregion

            #region BUSINESS & OPERATIONS FEATURES
            f = new Feature()
            {
                FeatureName = "API integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Business performance reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Business planning",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Contact management/CRM",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Electronic signature",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Field service management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Helpdesk",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inventory management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invoice management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Order management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Purchasing management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Quote management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Resource scheduling",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Service dispatch",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Supply chain management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Time & attendance",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("BUSINESS & OPERATIONS"));
            repository.AddFeature(f);

            #endregion

            #region MARKETING FEATURES
            f = new Feature()
            {
                FeatureName = "A/B testing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "API integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automated email",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Ad tracking",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email campaign management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Event management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Integrated contact management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invite/registration management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Landing page management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Campaign reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Search management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social media management",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social sharing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Surveys",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Telemarketing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);

            f = new Feature()
            {
                FeatureName = "Webinar platform",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("MARKETING"));
            repository.AddFeature(f);

            #endregion

            #region Business Intelligence Reporting FEATURES
            f = new Feature()
            {
                FeatureName = "Ad hoc analysis",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Ad hoc query",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Ad hoc reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "API integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Custom dashboard",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Custom reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Drag and drop visualisations",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Export data to Excel",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Forecasting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interactive dashboard/reporting",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Key performance indicators",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi source data integration",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Trend indicators",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Visual data presentation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "OLAP",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("Business Intelligence Reporting"));
            repository.AddFeature(f);

            #endregion

            #region CREATIVE FEATURES
            f = new Feature()
            {
                FeatureName = "Animated images",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "App design",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Audio editing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3D/CAD",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Content library",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Diagram design",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "eBook publishing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Graphics tools",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Photo editing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interactive animation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Presentation creation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Publishing tools",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Video creation",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Video editing",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Website design",
                Categories = new List<Category>(),
                //Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                FeatureType = repository.FindFeatureTypeByName("FEATURE"),
                FeatureStatus = repository.FindStatusByName("LIVE"),
            };
            f.Categories.Add(repository.FindCategoryByName("CREATIVE"));
            repository.AddFeature(f);

            #endregion

            #endregion

            //#region APPLICATIONFEATURES

            ////WORD PARENT
            //f = new Feature()
            //{
            //    FeatureName = "Word Processor",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;

            ////WORD CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Advanced Proofing & Editing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Advanced Referencing & Editing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Mailing Features",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;


            ////SPREADSHEET PARENT            
            //f = new Feature()
            //{
            //    FeatureName = "Spreadsheet",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);

            ////SPREADSHEET CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Formula Management",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Data Management",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Advanced Charting & Tables",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);


            ////PRESENTATION PARENT
            //f = new Feature()
            //{
            //    FeatureName = "Presentation",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;

            ////PRESENTATION CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Advanced Design & Animation",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Real-Time Collaboration",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Automatic Version Management",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Large Video Files >50MB",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Own Branding",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);


            ////CONFERENCING PARENT
            //f = new Feature()
            //{
            //    FeatureName = "Conferencing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;

            ////CONFERENCING CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Desktop sharing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Instant messaging",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Desktop video conferencing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Desktop VoIP",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Presence tools",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);


            ////NOTES PARENT
            //f = new Feature()
            //{
            //    FeatureName = "Notes",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;

            ////NOTES CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Read & Edit",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Save Web Content",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Image Capture",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Automatic Sync (for use on other devices)",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);

            ////WEB PUBLISHING PARENT
            //f = new Feature()
            //{
            //    FeatureName = "Web publishing",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //parentFeature = f;

            ////WEB PUBLISHING CHILDREN
            //f = new Feature()
            //{
            //    FeatureName = "Web Publishing e.g. Blog",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Social Media Integration",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Internal Website (Intranet)",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "External Customer Website (Extranet)",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    SuppressFilterBehaviour = true,
            //    ParentFeature = parentFeature,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);

            //f = new Feature()
            //{
            //    FeatureName = "Email (comprehensive client)",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Email security & anti-spam",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Email storage limit per user",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    IsDataDriven = true,
            //    //DataDrivenField = "THIS",
            //    OutputDisplayType = "INT",
            //    OutputDisplayDescriptor = "BYTES",
            //    IsDataCeilingDriven = true,
            //    HasCount = true,
            //    HasCountSuffix = true,
            //    CanBeBooleanAndDataDriven = true,
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Email content translation",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Contact Management",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Shared Calendar",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Project Management / Task Manager",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Document Collaboration (real-time)",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Collaborative diagramming/mapping",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);
            //f = new Feature()
            //{
            //    FeatureName = "Document consumption analytics",
            //    Categories = new List<Category>(),
            //    FeatureType = repository.FindFeatureTypeByName("APPLICATIONFEATURE"),
            //    FeatureStatus = repository.FindStatusByName("LIVE"),
            //};
            //f.Categories.Add(repository.FindCategoryByName("OFFICE"));
            //repository.AddFeature(f);

            //#endregion


            #region VENDORS

            #region PAYMENTS VENDORS
            v = new Vendor()
            {
                VendorName = "SagePay",
                VendorLogoFileName = "Sage_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Sage_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PayPal",
                VendorLogoFileName = "PayPal_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\PayPal_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Skrill",
                VendorLogoFileName = "Skrill_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Skrill_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Real Ex",
                VendorLogoFileName = "Realex_Payments_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Realex_Payments_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "eWay",
                VendorLogoFileName = "eWay_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\eWay_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Authorize.Net",
                VendorLogoFileName = "Authorize_net_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Authorize_net_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "BT-SafePay",
                VendorLogoFileName = "BT_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\BT_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Cashflows",
                VendorLogoFileName = "CashFlows_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\CashFlows_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Digital River",
                VendorLogoFileName = "DigitalRiver_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\DigitalRiver_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Kounta",
                VendorLogoFileName = "Kounta_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Kounta_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region HOSTING VENDORS

            v = new Vendor()
            {
                VendorName = "BT#2",
                VendorLogoFileName = "BT_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\BT_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "1&1#2",
                VendorLogoFileName = "1and1_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\1and1_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Gradwell Cloud",
                VendorLogoFileName = "Gradwell_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\Gradwell_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "GoDaddy",
                VendorLogoFileName = "GoDaddy_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\GoDaddy_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "123-Reg",
                VendorLogoFileName = "123Reg_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\123Reg_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Optimal Hosting",
                VendorLogoFileName = "Optimal_Hosting_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\Optimal_Hosting_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Heart Internet",
                VendorLogoFileName = "HeartInternet_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\HeartInternet_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "UK2",
                VendorLogoFileName = "EasySpace_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hosting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\EasySpace_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "EasySpace",
                VendorLogoFileName = "Authorize_net_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Payments//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Payments\\Authorize_net_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "DreamHost",
                VendorLogoFileName = "DreamHost_logo.gif",
                VendorLogoFullURL = "//Images//Logos//P//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hosting\\DreamHost_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region WEBSITE VENDORS

            v = new Vendor()
            {
                VendorName = "1&1#3",
                VendorLogoFileName = "1and1_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\1and1_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "GoDaddy#2",
                VendorLogoFileName = "GoDaddy_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\GoDaddy_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zoho Sites",
                VendorLogoFileName = "Zoho_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Zoho_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "123-Reg#2",
                VendorLogoFileName = "123Reg_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\123Reg_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "HighWire",
                VendorLogoFileName = "HighWire_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\HighWire_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Shopio",
                VendorLogoFileName = "Shopio_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Shopio_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Weebly",
                VendorLogoFileName = "Weebly_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Weebly_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Serif",
                VendorLogoFileName = "Serif_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Serif_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Wix",
                VendorLogoFileName = "Wix_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Wix_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Shopify",
                VendorLogoFileName = "Shopify_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Shopify_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Volusion",
                VendorLogoFileName = "Volusion_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Website//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Website\\Volusion_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region HR VENDORS
            v = new Vendor()
            {
                VendorName = "Breathe HR",
                VendorLogoFileName = "BreatheHR_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\BreatheHR_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "People HR",
                VendorLogoFileName = "PeopleHR_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\PeopleHR_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "SMB Partners",
                VendorLogoFileName = "SMB_Partners_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\SMB_Partners_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "You Manage",
                VendorLogoFileName = "YouManage_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\YouManage_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Staff Squared",
                VendorLogoFileName = "Staff_Squared_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\Staff_Squared_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "My HR Toolkit",
                VendorLogoFileName = "My_HR_Toolkit_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\My_HR_Toolkit_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Bamboo HR",
                VendorLogoFileName = "BambooHR_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\BambooHR_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Cezanne HR",
                VendorLogoFileName = "Cezanne_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\Cezanne_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Access Group",
                VendorLogoFileName = "Access_HR_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\Access_HR_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Moore Pay",
                VendorLogoFileName = "Moorepay_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\Moorepay_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zoho People",
                VendorLogoFileName = "Zoho_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Hr//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Hr\\Zoho_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);



            #endregion

            #region SALES VENDORS

            v = new Vendor()
            {
                VendorName = "Pipeline Deals#2",
                VendorLogoFileName = "PipelineDeals_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\PipelineDeals_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Pipedrive",
                VendorLogoFileName = "PipeDrive_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\PipeDrive_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zoho CRM#2",
                VendorLogoFileName = "Zoho_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Zoho_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Ambassador",
                VendorLogoFileName = "Ambassador_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Ambassador_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Pipeliner",
                VendorLogoFileName = "Pipeliner_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Pipeliner_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Salesforce Pardot",
                VendorLogoFileName = "Pardot_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Pardot_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Call Pro",
                VendorLogoFileName = "CallPro_CRM_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\CallPro_CRM_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Base",
                VendorLogoFileName = "BaseSales_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\BaseSales_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Hatchbuck",
                VendorLogoFileName = "Hatchbuck_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Hatchbuck_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Insightly",
                VendorLogoFileName = "Insightly_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Insightly_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Capsule CRM",
                VendorLogoFileName = "Capsule_CRM_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Sales//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Sales\\Capsule_CRM_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region BUSINESS & OPERATIONS VENDORS

            v = new Vendor()
            {
                VendorName = "Deputy",
                VendorLogoFileName = "Deputy_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Deputy_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "LivePlan",
                VendorLogoFileName = "LivePlan_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\LivePlan_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Megaventory",
                VendorLogoFileName = "Megaventory_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Megaventory_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Timely",
                VendorLogoFileName = "Timely_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Timely_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Tradegecko",
                VendorLogoFileName = "TradeGecko_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\TradeGecko_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Workflowmax",
                VendorLogoFileName = "Workflow_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Workflow_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "BrightPearl#2",
                VendorLogoFileName = "brightpearl_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\brightpearl_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "DocuSign",
                VendorLogoFileName = "DocuSign_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\DocuSign_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "OpenBravo",
                VendorLogoFileName = "Openbravo_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Openbravo_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "SignNow",
                VendorLogoFileName = "SignNow_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\SignNow_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Workday",
                VendorLogoFileName = "Workday_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Workday_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zendesk",
                VendorLogoFileName = "Zendesk_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Zendesk_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Freshdesk",
                VendorLogoFileName = "FreshDesk_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\FreshDesk_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Frontrange",
                VendorLogoFileName = "FrontRange-logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\FrontRange-logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Stratpad",
                VendorLogoFileName = "StratPad_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\StratPad_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Adobe",
                VendorLogoFileName = "Adobe_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business and Opps//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Adobe_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            //v = new Vendor()
            //{
            //    VendorName = "Unleashed",
            //    VendorLogoFileName = "Unleashed_logo.gif",
            //    VendorLogoFullURL = "//Images//Logos//Business and Opps//",
            //    VendorLogo = new VendorLogo()
            //    {
            //        //NS - need logo!!
            //        Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Unleashed_logo.gif"),
            //        VendorLogoStatus = repository.FindStatusByName("LIVE"),
            //    },
            //    VendorStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddVendor(v);

            //v = new Vendor()
            //{
            //    VendorName = "Jobber",
            //    //NS - need logo!!
            //    VendorLogoFileName = "Jobber_logo.gif",
            //    VendorLogoFullURL = "//Images//Logos//Business and Opps//",
            //    VendorLogo = new VendorLogo()
            //    {
            //        Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business and Opps\\Jobber_logo.gif"),
            //        VendorLogoStatus = repository.FindStatusByName("LIVE"),
            //    },
            //    VendorStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddVendor(v);

            #endregion

            #region MARKETING VENDORS

            v = new Vendor()
            {
                VendorName = "Constant Contact",
                VendorLogoFileName = "ConstantContact_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\ConstantContact_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "ClickWebinar",
                VendorLogoFileName = "ClickWebinar_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\ClickWebinar_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Dotmailer",
                VendorLogoFileName = "DotMailer_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\DotMailer_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Hootsuite",
                VendorLogoFileName = "HootSuite_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\HootSuite_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zoho Marketing",
                VendorLogoFileName = "Zoho_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Zoho_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Campaign Monitor",
                VendorLogoFileName = "CampaignMonitor_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\CampaignMonitor_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Instapage",
                VendorLogoFileName = "InstaPage_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\InstaPage_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Marketo",
                VendorLogoFileName = "Marketo_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Marketo_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Hubspot",
                VendorLogoFileName = "HunSpot_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\HunSpot_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Pardot",
                VendorLogoFileName = "Pardot_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Pardot_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Act-On",
                VendorLogoFileName = "Act-On_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Act-On_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Marin",
                VendorLogoFileName = "MarinsSoftware_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\MarinsSoftware_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Cvent",
                VendorLogoFileName = "Cvent_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Cvent_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "FluidSurveys",
                VendorLogoFileName = "FluidSurveys_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\FluidSurveys_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Vocus",
                VendorLogoFileName = "Vocus_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Vocus_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "OutMarket",
                VendorLogoFileName = "OutMarket_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\OutMarket_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Moz",
                VendorLogoFileName = "Moz_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Moz_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Adobe#2",
                VendorLogoFileName = "Adobe_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Adobe_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Citrix",
                VendorLogoFileName = "Citrix_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Citrix_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Vocalcom",
                VendorLogoFileName = "Vocalcom_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\Vocalcom_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "VanillaSoft",
                VendorLogoFileName = "VanillaSoft_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\VanillaSoft_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "New Voice Media",
                VendorLogoFileName = "NewVoiceMedia_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Marketing//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Marketing\\NewVoiceMedia_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region BUSINESS INTELLIGENCE REPORTING VENDORS

            v = new Vendor()
            {
                VendorName = "Bime",
                VendorLogoFileName = "Bime_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Bime_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Zoho Reports",
                VendorLogoFileName = "Zoho_Logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Zoho_Logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Qlik",
                VendorLogoFileName = "Qlik_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Qlik_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Birst",
                VendorLogoFileName = "Birst_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Birst_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "SiSense",
                VendorLogoFileName = "SiSense_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\SiSense_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Tableau",
                VendorLogoFileName = "Tableay_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Tableay_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Looker",
                VendorLogoFileName = "Looker_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Looker_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Roambi",
                VendorLogoFileName = "Roambi_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Roambi_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "MicroStrategy",
                VendorLogoFileName = "MicroStrategy_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\MicroStrategy_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Adaptive Insights",
                VendorLogoFileName = "Adaptive_Insights_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Business intelligence Reporting//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Business intelligence Reporting\\Adaptive_Insights_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #region CREATIVE VENDORS

            v = new Vendor()
            {
                VendorName = "Adobe#3",
                VendorLogoFileName = "Adobe_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Adobe_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Corel",
                VendorLogoFileName = "Coral_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Coral_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Quark",
                VendorLogoFileName = "Quark_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Quark_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Gliffy#2",
                VendorLogoFileName = "Gliffy_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Gliffy_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Creately#2",
                VendorLogoFileName = "Creately_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Creately_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "GoAnimate",
                VendorLogoFileName = "GoAnimate_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\GoAnimate_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Serif#2",
                VendorLogoFileName = "Serif_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Serif_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Moovly",
                VendorLogoFileName = "Moovly_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Moovly_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Magisto",
                VendorLogoFileName = "Magisto_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Magisto_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "WeVideo",
                VendorLogoFileName = "WeVideo_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\WeVideo_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Animoto",
                VendorLogoFileName = "Animoto_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Animoto_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Como",
                VendorLogoFileName = "Como_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Como_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Knack",
                VendorLogoFileName = "Knack_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Knack_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Mobile Roadie",
                VendorLogoFileName = "Mobile_Roadie_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Mobile_Roadie_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            v = new Vendor()
            {
                VendorName = "Mobincube",
                VendorLogoFileName = "Monincube_logo.gif",
                VendorLogoFullURL = "//Images//Logos//Creative//",
                VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Logos\\Creative\\Monincube_logo.gif"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                },
                VendorStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddVendor(v);

            #endregion

            #endregion

            //#region CONTENTTEXTTYPES
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CONFERENCING_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PROJECTMANAGEMENT_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "STORAGEANDBACKUP_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "EMAIL_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "FINANCIAL_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "OFFICE_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PHONE_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CUSTOMERMANAGEMENT_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "SECURITY_CATEGORY_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);

            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CONFERENCING_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PROJECTMANAGEMENT_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "STORAGEANDBACKUP_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "EMAIL_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "FINANCIAL_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "OFFICE_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PHONE_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CUSTOMERMANAGEMENT_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "SECURITY_CATEGORY_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CLOUDWAREEXPLAINED_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CLOUDWAREEXPLAINED_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CLOUDWAREEXPLAINED_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);


            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);


            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SUBTITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);





            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "ABOUTUS_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "ABOUTUS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "ABOUTUS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);






            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "MANAGEMENTTEAM_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "MANAGEMENTTEAM_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "MANAGEMENTTEAM_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);








            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "VISION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "VISION_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "VISION_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);









            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "FAQS_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "FAQS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "FAQS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);










            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CAREERS_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CAREERS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CAREERS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);











            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PRESS_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PRESS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PRESS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);










            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CONTACTUS_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CONTACTUS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "CONTACTUS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);






            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_TOU_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_TOU_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_GENERAL_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_GENERAL_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_SERVICES_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_SERVICES_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_CONTENT_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_CONTENT_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_THIRD_PARTY_SITES_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_THIRD_PARTY_SITES_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_USER_OBLIGATIONS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_USER_OBLIGATIONS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_IPR_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_IPR_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_LIABILITY_DISCLAIMERS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_LIABILITY_DISCLAIMERS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_NO_WARRANTY_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_NO_WARRANTY_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_INDEMNITY_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_INDEMNITY_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_SITE_AVAILABILITY_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_SITE_AVAILABILITY_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_MISC_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "TOU_MISC_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);




            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_PP_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_PP_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_BACKGROUND_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_BACKGROUND_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DEFINITIONS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DEFINITIONS_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_COLLECTED_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_COLLECTED_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_USE_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_USE_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_THIRD_PARTY_SERVICES_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_THIRD_PARTY_SERVICES_SECTION_BODY",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COB_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COB_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COB_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COB_FOOTER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_ACCESS_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_ACCESS_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_DATA_ACCESS_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_WITHHOLD_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_WITHHOLD_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_WITHHOLD_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_OWNDATA_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_OWNDATA_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_OWNDATA_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_SECURITY_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_SECURITY_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_SECURITY_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COOKIES_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COOKIES_ITEMS_SECTION_BODY_NUMBER",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_COOKIES_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_CHANGES_SECTION_TITLE",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);
            //ctt = new ContentTextType()
            //{
            //    ContentTextTypeName = "PP_CHANGES_ITEMS_SECTION_BODY_ITEM",
            //    ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentTextType(ctt);

            //#endregion

            return retVal;
        }
        #endregion

        #region PUMPMISSINGLOGOS
        public static bool PumpMissingLogos(QueryRepository repository)
        {
            List<Vendor> vendors = repository.FindVendorsByName("CONNEXIN").ToList();
            foreach (Vendor v in vendors)
            {
                v.VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\Connexin.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                };
                //repository.Update<Vendor>("-1", v);
            }

            vendors = repository.FindVendorsByName("VOIPFONE").ToList();
            foreach (Vendor v in vendors)
            {
                v.VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\voipphone.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                };
                //repository.Update<Vendor>("-1", v);
            }

            vendors = repository.FindVendorsByName("TIMICO").ToList();
            foreach (Vendor v in vendors)
            {
                v.VendorLogo = new VendorLogo()
                {
                    Logo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\timico.jpg"),
                    VendorLogoStatus = repository.FindStatusByName("LIVE"),
                };
                //repository.Update<Vendor>("-1", v);
            }
            return true;
        }
        #endregion

        #region PumpLogs
        public static bool PumpLogs(QueryRepository repository)
        {
            Status s;
            bool retVal = true;

            string pattern = null;
            pattern = "^[0-9]{4}-(((0[13578]|(10|12))-(0[1-9]|[1-2][0-9]|3[0-1]))|(02-(0[1-9]|[1-2][0-9]))|((0[469]|11)-(0[1-9]|[1-2][0-9]|30)))$";
            pattern = @"(\d{2}|\d{4})(?:\-)?([0]{1}\d{1}|[1]{1}[0-2]{1})(?:\-)?([0-2]{1}\d{1}|[3]{1}[0-1]{1})(?:\s)?([0-1]{1}\d{1}|[2]{1}[0-3]{1})(?::)?([0-5]{1}\d{1})(?::)?([0-5]{1}\d{1})";
            pattern = "(?:20[0-9]{2}|2[0-9]{3})/(?:0[1-9]|1[0-2])/(?<!\\d)(?=(?:0[1-9]|[1-2][0-9]|[3][01]))";
            pattern = @"^\d{4}-((0[1-9])|(1[012]))-((0[1-9]|[12]\d)|3[01])$";
            pattern = @"^\d{4}-((0[1-9])|(1[012]))$";
            pattern = @"\n";
            //string[] digits = Regex.Split(sentence, @"\D+");
            string sentence = null;
            using (StreamReader reader = File.OpenText(@"J:\CompareCloudwareVideo\CompareCloudware.Web\Logs\fatal.log.2"))
            {
                sentence = reader.ReadToEnd();
                //Console.WriteLine(text.Length);
            }
            string[] digits = Regex.Split(sentence, pattern,RegexOptions.Multiline);
            pattern = @"^\d{4}-((0[1-9])|(1[012]))-((0[1-9]|[12]\d)|3[01])";
            string testString = digits[0];
            var matches = Regex.IsMatch(testString, pattern, RegexOptions.Multiline);
            var list = digits.Where(x => Regex.IsMatch(x, pattern)).ToList();

            testString = list[0];
            string[] lineMatches = Regex.Split(testString, "(FATAL.*?|SESSION:.*?|URI:.*?|USER HOST ADDRESS:.*?|USER AGENT:.*?)",RegexOptions.Multiline);
            return retVal;
        }

        #endregion

        #region PumpContextTextTypesForH1H2
        public static bool PumpContextTextTypesForH1H2(QueryRepository repository)
        {
            bool retVal = true;
            ContentTextType ctt;
            #region CONTENTTEXTTYPES
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);





            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);









            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);















            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);









            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOSTING_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WEBSITE_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PAYMENTS_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HR_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SALES_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "INTELLIGENCEANDREPORTING_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "MARKETING_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "BUSINESSOPERATIONS_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);






            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H2_1_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H2_1_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H2_2_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CREATIVE_H2_2_BODY",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            
            
            
            
            

            #endregion

            return retVal;
        }
        #endregion

        #region PumpContentTextTypesForTabTitles
        public static bool PumpContentTextTypesForTabTitles(QueryRepository repository)
        {
            bool retVal = true;
            ContentTextType ctt;
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "HOMEPAGE_H2_2_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);
            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CONFERENCING_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PROJECTMANAGEMENT_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "STORAGEANDBACKUP_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "EMAIL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "FINANCIAL_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "OFFICE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "PHONE_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CRM_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "SECURITY_H1_TABTITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            return retVal;
        }
        #endregion

        #region PumpSecondCategories
        public static bool PumpSecondCategories(QueryRepository repository)
        {
            Category c;
            CategoryParameters cp;
            #region CATEGORIES
            c = new Category()
            {
                CategoryName = "Marketing",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee-per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",

                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Website",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Creative",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Intelligence & Reporting",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Hosting",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "HR",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Payments",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Business & Operations",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            c = new Category()
            {
                CategoryName = "Sales",
                CategoryStatus = repository.FindStatusByName("SUSPENDED"),
            };
            repository.AddCategory(c);
            cp = new CategoryParameters()
            {
                SearchResultsMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultsAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultsCloudwareProviderColumnHeader = "Cloudware provider A-Z",
                SearchResultsSetupFeeColumnHeader = "Set-up fee",
                SearchResultsFreeTrialColumnHeader = "Free trial",
                SearchResultMonthlyPriceColumnHeader = "Monthly fee per-user",
                SearchResultAnnualPriceColumnHeader = "Annual fee per-user",
                SearchResultCloudwareProviderColumnHeader = "Cloudware provider",
                SearchResultSetupFeeColumnHeader = "Set-up fee",
                SearchResultFreeTrialColumnHeader = "Free trial",
                Category = c,
            };
            repository.AddCategoryParameters(cp);

            #endregion

            return true;
        }
        #endregion
    }
}
