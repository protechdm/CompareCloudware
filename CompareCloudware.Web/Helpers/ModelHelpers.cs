using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.Controllers;
using CompareCloudware.Web.Models;
using System.Configuration;
using CompareCloudware.Domain.Models;
using CompareCloudware.Domain.Contracts.Repositories;
using PagedList;
using Castle.Core.Logging;
using System.Net;
using System.Web.Mvc;
using LinqKit;
using System.IO;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Core;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Helpers
{
    public class ModelHelpers
    {
        static int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_FEATURED = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageFeatured"]);
        static int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_NEW = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageNew"]);
        static int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_TOP10 = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageTop10"]);
        static int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_FEATURED = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageFeatured"]);
        static int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_NEW = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageNew"]);
        static int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_TOP10 = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageTop10"]);

        const int CATEGORY_ID_PHONE = 1;
        const int CATEGORY_ID_CRM = 2;
        const int CATEGORY_ID_WEB_CONFERENCING = 3;
        const int CATEGORY_ID_EMAIL = 4;
        const int CATEGORY_ID_OFFICE = 5;
        const int CATEGORY_ID_STORAGE_AND_BACKUP = 6;
        const int CATEGORY_ID_PROJECT_MANAGEMENT = 7;
        const int CATEGORY_ID_FINANCIAL = 8;
        const int CATEGORY_ID_SECURITY = 9;
        const int CATEGORY_ID_COMMUNICATIONS = 19;
        
        const int CATEGORY_ID_MARKETING = 10;
        const int CATEGORY_ID_WEBSITE = 11;
        const int CATEGORY_ID_CREATIVE = 12;
        const int CATEGORY_ID_INTELLIGENCE_AND_REPORTING = 13;
        const int CATEGORY_ID_HOSTING = 14;
        const int CATEGORY_ID_HR = 15;
        const int CATEGORY_ID_PAYMENTS = 16;
        const int CATEGORY_ID_BUSINESS_AND_OPERATIONS = 17;
        const int CATEGORY_ID_SALES = 18;

        const string FILTER_CATEGORIES = "CATEGORY";
        const string FILTER_USERS = "USERS";
        const string FILTER_BROWSERS = "BROWSER";
        const string FILTER_FEATURES = "FEATURE";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEM";
        const string FILTER_DEVICES = "DEVICES";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPE";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGE";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORM";
        const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURE";
        const string FILTER_TIMEZONES = "TIMEZONE";

        static int SEARCH_RESULTS_PER_PAGE = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPage"]);
        static int GLOBAL_SEARCH_RESULTS_PER_PAGE = int.Parse(ConfigurationManager.AppSettings["GlobalSearchResultsPerPage"]);

        #region ConstructHomePageModel
        public static HomePageModel ConstructHomePageModel(HomePageModel model, ICustomSession customSession, ICompareCloudwareRepository repository, HttpRequestBase request, HttpResponseBase response)
        {

            //Logger.Debug("ConstructHomePageModel #1");
            model.SearchInputModel.Categories = GetCategories(customSession,repository);
            //Logger.Debug("ConstructHomePageModel #2");
            model.SearchInputModel.NumberOfUsers = GetNumberOfUsers(repository);
            //Logger.Debug("ConstructHomePageModel #3");
            model.SearchInputModel.NumberOfUsers = AddNumberOfUsersToList(model.SearchInputModel.NumberOfUsers, "User numbers");
            //model.SearchInputModel.ChosenNumberOfUsers = 1;
            //Logger.Debug("ConstructHomePageModel #4");

            if (!customSession.TestMode)
            {
                model.SearchInputModel.ChosenNumberOfUsers = "User numbers";
                model.SearchInputModel.ChosenCategoryID = 6;
                model.SearchInputModel.Forename = customSession.Forename ?? "First Name";
                model.SearchInputModel.Surname = customSession.Surname ?? "Surname";
                model.SearchInputModel.EMail = customSession.EMail ?? "Email";
            }
            model.SearchInputModel.DisplayStyle = SearchInputModelStyle.HomePage;


            model.SearchInputModelFirstTime = model.SearchInputModel;

            //Logger.Debug("ConstructHomePageModel #5");
            //OLD TABS
            if (model.TabbedSearchResultsModel == null)
            {
                model.TabbedSearchResultsModel = new TabbedSearchResultsModel(customSession);
                model.TabbedSearchResultsModel.FeaturedCloudwareSearchResultsVisible = true;
            }
            //Logger.Debug("ConstructHomePageModel #5.1");
            model.TabbedSearchResultsModel.FeaturedCloudware = ConvertSearchResultToSearchResultModel(repository.GetFeaturedCloudware(SEARCH_RESULTS_PER_PAGE_HOME_PAGE_FEATURED, LiveApplicationsOnly(customSession)),customSession);
            //Logger.Debug("ConstructHomePageModel #5.2");
            model.TabbedSearchResultsModel.TopTenCloudware = ConvertSearchResultToSearchResultModel(repository.GetTopTenCloudware(SEARCH_RESULTS_PER_PAGE_HOME_PAGE_TOP10, LiveApplicationsOnly(customSession)),customSession);
            //Logger.Debug("ConstructHomePageModel #5.3");
            model.TabbedSearchResultsModel.NewCloudware = ConvertSearchResultToSearchResultModel(repository.GetNewCloudware(SEARCH_RESULTS_PER_PAGE_HOME_PAGE_NEW, LiveApplicationsOnly(customSession)),customSession);
            //LogTabbedSearchResultsModelSiteAnalytic(model.TabbedSearchResultsModel,1);

            //NEW DISPLAY TEMPLATES
            //Logger.Debug("ConstructHomePageModel #6");
            model.TabbedSearchResultsModel.FeaturedCloudwareNew = new FeaturedCloudwareModel();
            model.TabbedSearchResultsModel.FeaturedCloudwareNew.FeaturedCloudware = model.TabbedSearchResultsModel.FeaturedCloudware;
            model.TabbedSearchResultsModel.NewCloudwareNew = new NewCloudwareModel();
            model.TabbedSearchResultsModel.NewCloudwareNew.NewCloudware = model.TabbedSearchResultsModel.NewCloudware;
            model.TabbedSearchResultsModel.TopTenCloudwareNew = new TopTenCloudwareModel();
            model.TabbedSearchResultsModel.TopTenCloudwareNew.TopTenCloudware = model.TabbedSearchResultsModel.TopTenCloudware;
            SetTabLayoutPosition(model.TabbedSearchResultsModel.FeaturedCloudwareNew.FeaturedCloudware);
            SetTabLayoutPosition(model.TabbedSearchResultsModel.NewCloudwareNew.NewCloudware);
            SetTabLayoutPosition(model.TabbedSearchResultsModel.TopTenCloudwareNew.TopTenCloudware);

            model.CustomSession = customSession;
            model.CustomSession.SelectedCategoryID = 0;
            //Logger.Debug("ConstructHomePageModel #7");
            model.Carousel = new CarouselModel(customSession, repository,CarouselType.Home);
            model.CarouselSocial = new CarouselModel(customSession, repository, CarouselType.Social);

            model.H1H2ContentText = new ContentTextsModel(customSession);
            model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HOMEPAGE_H1_TITLE", "HOMEPAGE_H1_BODY", "HOMEPAGE_H2_1_TITLE", "HOMEPAGE_H2_1_BODY", "HOMEPAGE_H2_2_TITLE", "HOMEPAGE_H2_2_BODY" }),ContentDataPage.Home).ToList();

            model.TabbedOnpageOptimisationModel = new TabbedOnpageOptimisationModel(customSession);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H1_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H1_BODY")).OrderBy(x => x.BodyOrder).ToList();
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_BODY")).OrderBy(x => x.BodyOrder).ToList(); ;
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_BODY")).OrderBy(x => x.BodyOrder).ToList(); ;

            model.TabbedOnpageOptimisationModel.Tab1Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H1_TITLE")).FirstOrDefault().ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab2Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_TITLE")).FirstOrDefault().ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab3Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_TITLE")).FirstOrDefault().ContentTextData;

            SetFirstAndLastInCollection(model.TabbedOnpageOptimisationModel);

            #region Video
            model.Video = new CloudApplicationVideoModel(customSession, request)
            {
                //CloudApplicationVideoFileFormat = "MP4",
                //CloudApplicationVideoFileName = "CCW Provider Demo 1.mp4",
                //CloudApplicationVideoID = x.CloudApplicationVideoID,
                //CloudApplicationVideoURL = "https://www.youtube.com/v/-YH7LDC15rE",
                //CloudApplicationVideoURL = "https://www.youtube.com/embed/-YH7LDC15rE",
                CloudApplicationVideoURL = "//player.vimeo.com/video/103524492?title=0&amp;byline=0&amp;portrait=0",
                //IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                //IsLocalDomain = true,
                IsYouTubeStream = true,
                ReadyToPlay = true,
                CloudApplicationVideoStatus = "LIVE",
                Width = 304,
                AspectRatio = AspectRatio.Ratio16x9,
            };
            #endregion

            model.IsFirstTimeVisit = IsFirstTimeVisit(request, response);
            return model;
        }
        #endregion

        #region GetCategories
        public static List<CategoryModel> GetCategories(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            List<CategoryModel> retVal = repository.GetCategories().Select(x => new CategoryModel(customSession)
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                SearchFilterID = x.CategoryID,
                Selected = false
            }).ToList();

            return retVal;
        }
        #endregion

        #region GetNumberOfUsers
        public static List<NumberOfUsersModel> GetNumberOfUsers(ICompareCloudwareRepository repository)
        {
            List<NumberOfUsersModel> retVal = repository.GetNumberOfUsers(false).Select(x => new NumberOfUsersModel()
            {
                UserValue = x.UserValue.ToString(),
            }).ToList();

            return retVal;
        }

        public static List<NumberOfUsersModel> GetNumberOfUsers(bool includeZero, ICompareCloudwareRepository repository)
        {
            List<NumberOfUsersModel> retVal = repository.GetNumberOfUsers(includeZero).Select(x => new NumberOfUsersModel()
            {
                UserValue = x.UserValue.ToString(),
            }).ToList();

            return retVal;
        }
        #endregion

        #region AddNumberOfUsersToList
        public static IList<NumberOfUsersModel> AddNumberOfUsersToList(IList<NumberOfUsersModel> list, string user)
        {
            List<NumberOfUsersModel> newList = new List<NumberOfUsersModel>();
            NumberOfUsersModel newUser = new NumberOfUsersModel()
            {
                UserValue = user,
            };

            newList.Add(newUser);

            newList = newList.Union(list).ToList();
            return newList;
        }

        #endregion

        #region ConvertSearchResultToSearchResultModel
        public static List<SearchResultModel> ConvertSearchResultToSearchResultModel(IList<SearchResult> sr, ICustomSession customSession)
        {
            //Logger.Debug("ConvertSearchResultToSearchResultModel #1");
            //Logger.Debug("Detected browser : " + CustomSession.DetectedBrowserID);

            List<SearchResultModel> srm = sr.Select(x => new SearchResultModel(customSession)
            {
                ApplicationCostOneOff = x.ApplicationCostOneOff,
                ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                ApplicationCostPerAnnumFree = x.ApplicationCostPerAnnumFree,
                ApplicationCostPerAnnumOffered = x.ApplicationCostPerAnnumOffered,
                ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
                ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,

                CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                CloudApplicationID = x.CloudApplicationID,
                CloudApplicationCategoryTag = x.CloudApplicationCategoryTag,
                CloudApplicationShopTag = x.CloudApplicationShopTag,
                Description = x.Description,
                FreeTrialPeriod = x.FreeTrialPeriod != null ? new FreeTrialPeriodModel()
                {
                    FreeTrialPeriodID = x.FreeTrialPeriod.FreeTrialPeriodID,
                    FreeTrialPeriodName = x.FreeTrialPeriod.FreeTrialPeriodName,
                } : null,
                ServiceName = x.ServiceName,
                SetupFee = x.SetupFee != null ? new SetupFeeModel()
                {
                    SetupFeeID = x.SetupFee.SetupFeeID,
                    SetupFeeName = x.SetupFee.SetupFeeName,
                } : null,
                VendorID = x.VendorID,
                VendorLogoURL = x.VendorLogoURL,
                VendorName = x.VendorName,
            }).ToList();

            //Logger.Debug("ConvertSearchResultToSearchResultModel #2");
            //return new List<SearchResultModel>();

            return srm;
        }
        #endregion

        #region LiveApplicationsOnly
        public static bool LiveApplicationsOnly(ICustomSession customSession)
        {
            bool liveApplicationsOnly = (customSession.DummyVXMode == false);
            return liveApplicationsOnly;
        }
        #endregion

        #region SetTabLayoutPosition
        public static void SetTabLayoutPosition(IList<SearchResultModel> tsrm)
        {
            int i = 1;
            foreach (SearchResultModel srm in tsrm)
            {
                srm.TabLayoutPosition = i;
                i++;
                i = (i == 2 ? i : 1);
            }
        }
        #endregion

        #region GetDocumentFileFormats
        public static string[,] GetDocumentFileFormats()
        {
            string[,] fileFormats = new string[,] { { "URL Link", "HTML" }, { "PDF Document", "application/pdf" }, { "Word Document", "application/msword" } };
            return fileFormats;
        }
        #endregion

        #region GetDocumentTypes
        public static string[,] GetDocumentTypes()
        {
            //string[,] documentTypes = new string[,] { { "White Paper", "WHITE" }, { "Case Study", "CASE" } };
            string[,] documentTypes = new string[,] { { "White Paper", "White Paper" }, { "Case Study", "Case Study" } };
            return documentTypes;
        }
        #endregion

        #region FormatDisplayValue
        public static GenericValueModel FormatDisplayValue(GenericValueModel gvm)
        {
            if (gvm.ModelValue == "UNLIMITED")
            {
                gvm.DisplayValue = "All";
            }
            else
            {
                if (gvm.OutputDisplayDescriptor == "BYTES")
                {
                    if (Convert.ToDecimal(gvm.ModelValue) >= 1000)
                    {
                        decimal newValue = Convert.ToDecimal(gvm.ModelValue);
                        newValue = newValue / 1000;
                        gvm.DisplayValue = newValue.ToString();
                        gvm.ValueSuffix = "TB";
                    }
                    if (Convert.ToDecimal(gvm.ModelValue) < 1)
                    {
                        decimal newValue = Convert.ToDecimal(gvm.ModelValue);
                        newValue = newValue * 1000;
                        gvm.DisplayValue = newValue.ToString();
                        gvm.ValueSuffix = "MB";
                    }
                }
                if (gvm.OutputDisplayType == "INT")
                {
                    gvm.DisplayValue = ((int)Convert.ToDecimal(gvm.DisplayValue)).ToString();
                }
                gvm.DisplayValue += gvm.ValueSuffix;
            }
            return gvm;
        }
        #endregion

        #region GetStorageBytes
        public static string[] GetStorageBytes()
        {
            string[] storageBytes = new string[] { "MB", "GB", "TB" };
            return storageBytes;
        }
        #endregion

        #region GetProviderTermsAndConditions
        public static TermsAndConditionsModel GetProviderTermsAndConditions(TermsAndConditionsModel model, ICompareCloudwareRepository repository)
        {
            model.TermsAndConditions = repository.GetTermsOfUseData("PROVIDER_TERMS_AND_CONDITIONS").Select(x => new TermConditionModel()
            {
                DisplayID = x.DisplayID,
                Indent = x.Indent,
                ColumnSpan = x.ColumnSpan,
                Order = x.Order,
                ParentDisplayID = x.ParentDisplayID,
                Section = x.Section,
                SectionNumber = x.SectionNumber,
                SectionText1 = x.SectionText1,
                SectionText2 = x.SectionText2,
                SectionText3 = x.SectionText3,
                SectionText4 = x.SectionText4,
                SectionText5 = x.SectionText5,
                SectionText1IsURL = x.SectionText1IsURL,
                SectionText2IsURL = x.SectionText2IsURL,
                SectionText3IsURL = x.SectionText3IsURL,
                SectionText4IsURL = x.SectionText4IsURL,
                SectionText5IsURL = x.SectionText5IsURL,
                SectionText1IsMailRef = x.SectionText1IsMailRef,
                SectionText2IsMailRef = x.SectionText2IsMailRef,
                SectionText3IsMailRef = x.SectionText3IsMailRef,
                SectionText4IsMailRef = x.SectionText4IsMailRef,
                SectionText5IsMailRef = x.SectionText5IsMailRef,
                SectionText1MailRef = x.SectionText1MailRef,
                SectionText2MailRef = x.SectionText2MailRef,
                SectionText3MailRef = x.SectionText3MailRef,
                SectionText4MailRef = x.SectionText4MailRef,
                SectionText5MailRef = x.SectionText5MailRef,
                SectionText1URL = x.SectionText1URL,
                SectionText2URL = x.SectionText2URL,
                SectionText3URL = x.SectionText3URL,
                SectionText4URL = x.SectionText4URL,
                SectionText5URL = x.SectionText5URL,
                TermConditionID = x.TermConditionID,
                IsBold = x.IsBold,
            }).ToList();

            return model;
        }
        #endregion

        #region GetUserTermsAndConditions
        public static TermsAndConditionsModel GetUserTermsAndConditions(TermsAndConditionsModel model, ICompareCloudwareRepository repository)
        {
            model.TermsAndConditions = repository.GetTermsOfUseData("USER_TERMS_AND_CONDITIONS").Select(x => new TermConditionModel()
            {
                DisplayID = x.DisplayID,
                Indent = x.Indent,
                ColumnSpan = x.ColumnSpan,
                Order = x.Order,
                ParentDisplayID = x.ParentDisplayID,
                Section = x.Section,
                SectionNumber = x.SectionNumber,
                SectionText1 = x.SectionText1,
                SectionText2 = x.SectionText2,
                SectionText3 = x.SectionText3,
                SectionText4 = x.SectionText4,
                SectionText5 = x.SectionText5,
                SectionText1IsURL = x.SectionText1IsURL,
                SectionText2IsURL = x.SectionText2IsURL,
                SectionText3IsURL = x.SectionText3IsURL,
                SectionText4IsURL = x.SectionText4IsURL,
                SectionText5IsURL = x.SectionText5IsURL,
                SectionText1IsMailRef = x.SectionText1IsMailRef,
                SectionText2IsMailRef = x.SectionText2IsMailRef,
                SectionText3IsMailRef = x.SectionText3IsMailRef,
                SectionText4IsMailRef = x.SectionText4IsMailRef,
                SectionText5IsMailRef = x.SectionText5IsMailRef,
                SectionText1MailRef = x.SectionText1MailRef,
                SectionText2MailRef = x.SectionText2MailRef,
                SectionText3MailRef = x.SectionText3MailRef,
                SectionText4MailRef = x.SectionText4MailRef,
                SectionText5MailRef = x.SectionText5MailRef,
                SectionText1URL = x.SectionText1URL,
                SectionText2URL = x.SectionText2URL,
                SectionText3URL = x.SectionText3URL,
                SectionText4URL = x.SectionText4URL,
                SectionText5URL = x.SectionText5URL,
                TermConditionID = x.TermConditionID,
                IsBold = x.IsBold,
            }).ToList();

            return model;
        }
        #endregion

        #region GetPrivacyPolicyData
        public static TermsAndConditionsModel GetPrivacyPolicyData(TermsAndConditionsModel model, ICompareCloudwareRepository repository)
        {
            model.TermsAndConditions = repository.GetTermsOfUseData("PRIVACY_POLICY").Select(x => new TermConditionModel()
            {
                DisplayID = x.DisplayID,
                Indent = x.Indent,
                ColumnSpan = x.ColumnSpan,
                Order = x.Order,
                ParentDisplayID = x.ParentDisplayID,
                Section = x.Section,
                SectionNumber = x.SectionNumber,
                SectionText1 = x.SectionText1,
                SectionText2 = x.SectionText2,
                SectionText3 = x.SectionText3,
                SectionText4 = x.SectionText4,
                SectionText5 = x.SectionText5,
                SectionText1IsURL = x.SectionText1IsURL,
                SectionText2IsURL = x.SectionText2IsURL,
                SectionText3IsURL = x.SectionText3IsURL,
                SectionText4IsURL = x.SectionText4IsURL,
                SectionText5IsURL = x.SectionText5IsURL,
                SectionText1IsMailRef = x.SectionText1IsMailRef,
                SectionText2IsMailRef = x.SectionText2IsMailRef,
                SectionText3IsMailRef = x.SectionText3IsMailRef,
                SectionText4IsMailRef = x.SectionText4IsMailRef,
                SectionText5IsMailRef = x.SectionText5IsMailRef,
                SectionText1MailRef = x.SectionText1MailRef,
                SectionText2MailRef = x.SectionText2MailRef,
                SectionText3MailRef = x.SectionText3MailRef,
                SectionText4MailRef = x.SectionText4MailRef,
                SectionText5MailRef = x.SectionText5MailRef,
                SectionText1URL = x.SectionText1URL,
                SectionText2URL = x.SectionText2URL,
                SectionText3URL = x.SectionText3URL,
                SectionText4URL = x.SectionText4URL,
                SectionText5URL = x.SectionText5URL,
                TermConditionID = x.TermConditionID,
                IsBold = x.IsBold,
            }).ToList();

            return model;
        }
        #endregion

        #region GetCloudwareExplainedData
        public static ContentTextsModel GetCloudwareExplainedData(ContentTextsModel model, ICompareCloudwareRepository repository)
        {
            model.ContentTexts = ConvertContentText(repository.GetContentData(new[] 
            { 
                "CLOUDWAREEXPLAINEDPAGE_TITLE", 
                "CLOUDWAREEXPLAINED_TAB_TITLE", 
                "10REASONSFORUSINGCLOUDWARE_TAB_TITLE", 
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_TITLE", 
                "CLOUDWAREEXPLAINED_TAB_HEADER", 
                "10REASONSFORUSINGCLOUDWARE_TAB_HEADER", 
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER", 
                "CLOUDWAREEXPLAINED_SECTION_TITLE", 
                "CLOUDWAREEXPLAINED_SECTION_BODY",
                "10REASONSFORUSINGCLOUDWARE_TITLE", 
                "10REASONSFORUSINGCLOUDWARE_SECTION_TITLE", 
                "10REASONSFORUSINGCLOUDWARE_SECTION_BODY",
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TITLE", 
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SUBTITLE", 
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE", 
                "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY",
            }), ContentDataPage.CloudwareExplained).ToList();

            return model;
        }
        #endregion

        #region GetPartnerProgrammeData
        public static ContentTextsModel GetPartnerProgrammeData(ContentTextsModel model, ICompareCloudwareRepository repository, ICustomSession customSession, HttpRequestBase request)
        {
            model.ContentTexts = new List<ContentTextModel>();
            ContentTextModel ctm = new ContentTextModel();
            ContentTextTypeModel cttm = new ContentTextTypeModel();
            string data;

            #region PROGRAMME OVERVIEW
            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMMEPAGE_TITLE";
            data = "THE TITLE!!!!";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_TAB_TITLE";
            data = "Overview";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_TAB_HEADER";
            data = "Programme Overview";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE";
            data = "Compare Cloudware operates a partner programme to accommodate all cloud providers on the platform.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "The programme is open to software-as-a-service, hosted software and cloud services providers who are looking to build their business with contemporary digital channels to market. There are two tiers to the programme, dependent on the level of lead visibility, on-site promotion, performance reporting and member marketing required.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-15px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "Both levels of partner benefit from a unique sales channel:";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<strong>Always-on</strong> – providing 24x7x365 opportunity, unlike traditional channels";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<strong>Automated</strong> – with efficient and streamlined workflows";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<strong>As-you-go</strong> – delivering performance-based demand generation";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<strong>Active buyers</strong> – appealing to ‘in-mode’ buyers who are in the market for purchase";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<strong>Accountable</strong> – providing a high level of lead transparency";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE";
            data = "How do partners use Compare Cloudware?";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                //ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "Partners typically use the platform in a couple of different ways:";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<b>A new digital channel partner.</b> Cloud providers can use Compare Cloudware as a contemporary addition to their routes to market, driving leads for the business to service themselves (direct model). This works well for brands which have a direct sales team but want to expand their reach and increase their sales funnel.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_BODY";
            data = "<b>A new way to drive leads for partners.</b> Cloud providers can use Compare Cloudware to generate leads to pass to their traditional channel partners. This can work well for organisations that are looking to motivate existing sales channels with additional SMB opportunities.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                IsBulleted = true,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE";
            data = "Discover more about becoming a Business Partner, Strategic Partner – or a Refer & Reward Partner";
            data = "";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-15px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);
            #endregion

            #region BUSINESS PARTNER
            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_TAB_TITLE";
            data = "Business Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                //ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_TAB_HEADER";
            data = "Business Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_TITLE";
            data = "There are already hundreds of Business Partners that benefit from representation on Compare Cloudware. What unifies them is their desire to target SMBs (the largest addressable market for cloud services) – and the efficiency of an automated platform to drive demand.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "Becoming a Compare Cloudware Business Partner requires very little resource overhead to get started. It avoids the cost associated with accreditation, training and sales enablement - let alone the ongoing maintenance and optimisations costs of underperforming partners.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
                ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "What’s more it’s free - and involves no risk whatsoever. So why wait any longer? Take a look at the Business Partner presentation to discover more in 3 easy steps:";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "1) The Compare Cloudware Difference";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "2) Benefits of partnering with Compare Cloudware";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "3) How to become a Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            //ctm = new ContentTextModel();
            //cttm = new ContentTextTypeModel();
            //cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            //data = "Register to view the Business Partner presentation now.";
            //ctm = new ContentTextModel()
            //{
            //    BodyOrder = 1,
            //    //CompositeID,
            //    NiceName = "",
            //    ContentTextType = cttm,
            //    ContentTextData = data,
            //    FontStyle = "font-normal-13px-black",
            //    ContentDataPage = ContentDataPage.PartnerProgramme,
            //    LineBreakAfter = true,
            //};
            //model.ContentTexts.Add(ctm);

            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY";
            data = "";
            var ctmww = new ContentTextModelWithWidget<RegisterNowModel>(new RegisterNowModel() 
            { 
                Forename = customSession.Forename,
                Surname = customSession.Surname,
                EMailAddress = customSession.EMail,
                HeaderStrap = "Register to view the Business Partner presentation now.",
                ShowHeaderStrapImage = true,
                PartnerProgrammeType = PartnerProgrammeTypeEnum.BusinessPartner,
                HasPresentationVideo = true,
                ShowVideo = false,
                Video = new CloudApplicationVideoModel(customSession, request)
                {
                    //CloudApplicationVideoFileFormat = "MP4",
                    //CloudApplicationVideoFileName = "CCW Provider Demo 1.mp4",
                    //CloudApplicationVideoID = x.CloudApplicationVideoID,
                    //CloudApplicationVideoURL = "https://www.youtube.com/v/-YH7LDC15rE",
                    //CloudApplicationVideoURL = "https://www.youtube.com/embed/-YH7LDC15rE",
                    //CloudApplicationVideoURL = "//player.vimeo.com/video/103524492?title=0&amp;byline=0&amp;portrait=0",
                    CloudApplicationVideoURL = "//player.vimeo.com/video/112796483?title=0&amp;byline=0&amp;portrait=0&amp;color=786caf&amp;autoplay=1",
                    //width="900" height="506" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen​",

                    //IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                    //IsLocalDomain = true,
                    IsYouTubeStream = true,
                    ReadyToPlay = true,
                    CloudApplicationVideoStatus = "LIVE",
                    Width = 304,
                    AspectRatio = AspectRatio.Ratio16x9,
                },
            }, customSession)
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                //FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                //LineBreakAfter = true,
                IsWidget = true,
                WidgetName = "RegisterNow",
            };
            model.ContentTexts.Add(ctmww);
            
            
            
            #endregion


            #region STRATEGIC PARTNER
            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_TAB_TITLE";
            data = "Strategic Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_TAB_HEADER";
            data = "Strategic Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_TITLE";
            data = "Compare Cloudware Strategic Partner status gives cloud providers a greater profile and representation across the platform.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY";
            data = "Strategic Partners can choose the marketing package that best suits their requirements around lead visibility and frequency of performance reporting. Additionally, this partner level provides enhanced exposure offered through member marketing and social communications.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY";
            data = "";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
                IsImage = true,
                ImageURL = "CCW_PP_CloudDiagram.jpg",
                
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY";
            data = "We’d be happy to do a personalised Strategic Partner presentation, once you’ve been approved as a Business Partner.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            //ctm = new ContentTextModel();
            //cttm = new ContentTextTypeModel();
            //cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY";
            //data = "Register for your personalised Strategic Partner presentation.";
            //ctm = new ContentTextModel()
            //{
            //    BodyOrder = 1,
            //    //CompositeID,
            //    NiceName = "",
            //    ContentTextType = cttm,
            //    ContentTextData = data,
            //    FontStyle = "font-normal-13px-black",
            //    ContentDataPage = ContentDataPage.PartnerProgramme,
            //    LineBreakAfter = true,
            //};
            //model.ContentTexts.Add(ctm);

            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY";
            data = "";
            ctmww = new ContentTextModelWithWidget<RegisterNowModel>(new RegisterNowModel()
            {
                Forename = customSession.Forename,
                Surname = customSession.Surname,
                EMailAddress = customSession.EMail,
                HeaderStrap = "Register for your personalised Strategic Partner presentation.",
                ShowHeaderStrapImage = false,
                PartnerProgrammeType = PartnerProgrammeTypeEnum.StrategicPartner,
                //Video = new CloudApplicationVideoModel(customSession, request)
                //{
                //    //CloudApplicationVideoFileFormat = "MP4",
                //    //CloudApplicationVideoFileName = "CCW Provider Demo 1.mp4",
                //    //CloudApplicationVideoID = x.CloudApplicationVideoID,
                //    //CloudApplicationVideoURL = "https://www.youtube.com/v/-YH7LDC15rE",
                //    //CloudApplicationVideoURL = "https://www.youtube.com/embed/-YH7LDC15rE",
                //    CloudApplicationVideoURL = "//player.vimeo.com/video/103524492?title=0&amp;byline=0&amp;portrait=0",
                //    //IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                //    //IsLocalDomain = true,
                //    IsYouTubeStream = true,
                //    ReadyToPlay = true,
                //    CloudApplicationVideoStatus = "LIVE",
                //    Width = 304,
                //    AspectRatio = AspectRatio.Ratio16x9,
                //},
            }, customSession)
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                //FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                //LineBreakAfter = true,
                IsWidget = true,
                WidgetName = "RegisterNow",
            };
            model.ContentTexts.Add(ctmww);
            
            
            
            
            
            #endregion

            #region REFER AND REWARD PARTNER
            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_TAB_TITLE";
            data = "Refer & Reward Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_TAB_HEADER";
            data = "Refer & Reward Partner";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-22px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_TITLE";
            data = "The Compare Cloudware Refer & Reward Programme is aimed at advisors who see value in increasing the sales opportunity for their cloud provider clients, contacts and partners.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "Compare Cloudware recognises the business performance advantages of cloud services - and the transformation opportunities created for the growing business. Our ambition is to drive faster and greater adoption within SMBs.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
                ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "We have a network of introduction partners who believe in our cause, the value it creates for the entrepreneurial community and the stimulus it generates for the broader environment. We work collaboratively with these partners to convert cloud providers who support us.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
                ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "This Refer & Reward programme is designed to be easy to understand and use. It’s easy to align with partner business needs and resource investments – from ad-hoc referrals to comprehensive sales closure.";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
                ParagraphBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "Who can join?";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-normal-17px-purple",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "Advisors and suppliers to cloud service providers";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                IsBulleted = true,
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "Cloud providers referring fellow ecosystem partner providers";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                IsBulleted = true,
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            ctm = new ContentTextModel();
            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "Professionals within cloud providers who are not part of the sales & marketing team";
            ctm = new ContentTextModel()
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                FontStyle = "font-bold-13px-black",
                IsBulleted = true,
                ContentDataPage = ContentDataPage.PartnerProgramme,
                LineBreakAfter = true,
            };
            model.ContentTexts.Add(ctm);

            //ctm = new ContentTextModel();
            //cttm = new ContentTextTypeModel();
            //cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            //data = "Register now for our Refer & Reward programme";
            //ctm = new ContentTextModel()
            //{
            //    BodyOrder = 1,
            //    //CompositeID,
            //    NiceName = "",
            //    ContentTextType = cttm,
            //    ContentTextData = data,
            //    FontStyle = "font-normal-13px-black",
            //    ContentDataPage = ContentDataPage.PartnerProgramme,
            //    LineBreakAfter = true,
            //};
            //model.ContentTexts.Add(ctm);

            cttm = new ContentTextTypeModel();
            cttm.ContentTextTypeName = "PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY";
            data = "";
            ctmww = new ContentTextModelWithWidget<RegisterNowModel>(new RegisterNowModel()
            {
                Forename = customSession.Forename,
                Surname = customSession.Surname,
                EMailAddress = customSession.EMail,
                HeaderStrap = "Register now for our Refer & Reward programme",
                ShowHeaderStrapImage = false,
                PartnerProgrammeType = PartnerProgrammeTypeEnum.ReferRewardPartner,
                //Video = new CloudApplicationVideoModel(customSession, request)
                //{
                //    //CloudApplicationVideoFileFormat = "MP4",
                //    //CloudApplicationVideoFileName = "CCW Provider Demo 1.mp4",
                //    //CloudApplicationVideoID = x.CloudApplicationVideoID,
                //    //CloudApplicationVideoURL = "https://www.youtube.com/v/-YH7LDC15rE",
                //    //CloudApplicationVideoURL = "https://www.youtube.com/embed/-YH7LDC15rE",
                //    CloudApplicationVideoURL = "//player.vimeo.com/video/103524492?title=0&amp;byline=0&amp;portrait=0",
                //    //IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                //    //IsLocalDomain = true,
                //    IsYouTubeStream = true,
                //    ReadyToPlay = true,
                //    CloudApplicationVideoStatus = "LIVE",
                //    Width = 304,
                //    AspectRatio = AspectRatio.Ratio16x9,
                //},
            }, customSession)
            {
                BodyOrder = 1,
                //CompositeID,
                NiceName = "",
                ContentTextType = cttm,
                ContentTextData = data,
                //FontStyle = "font-normal-13px-black",
                ContentDataPage = ContentDataPage.PartnerProgramme,
                //LineBreakAfter = true,
                IsWidget = true,
                WidgetName = "RegisterNow",
            };
            model.ContentTexts.Add(ctmww);


            #endregion


            return model;
        }
        #endregion


        //#region GetH1H2Data
        //public static ContentTextsModel GetH1H2Data(ContentTextsModel model, ICompareCloudwareRepository repository)
        //{
        //    model.ContentTexts = ConvertContentText(repository.GetContentData(new[] 
        //    { 
        //        "HOMEPAGE_H1_TITLE", 
        //        "HOMEPAGE_H1_BODY", 
        //        "HOMEPAGE_H2_1_TITLE", 
        //        "HOMEPAGE_H2_1_BODY", 
        //        "HOMEPAGE_H2_2_TITLE", 
        //        "HOMEPAGE_H2_2_BODY", 
        //    })).ToList();

        //    return model;
        //}
        //#endregion

        #region GetSiteMapData
        public static SiteMapModel GetSiteMapData(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            SiteMapModel smm = new SiteMapModel(customSession);
            //smm.Categories = repository.GetCategories().Select(x => new SiteMapModelItem()
            //{
            //    SiteMapModelItemID = x.CategoryID,
            //    SiteMapModelItemText = x.CategoryName,
            //    SiteMapModelItemURL = x.CategoryID.ToString(),
            //}).ToList();
            smm.Categories = repository.GetCategoryURLs().Select(x => new SiteMapModelItem()
            {
                SiteMapModelItemID = x.Category.CategoryID,
                SiteMapModelItemText = x.Category.CategoryName,
                SiteMapModelItemURL = x.TagName,
            }).ToList();

            smm.Company.Add(new SiteMapModelItem()
            {
                SiteMapModelItemText = "Cloudware Explained",
                SiteMapModelItemURL = "cloudware-explained",
            });
            smm.Company.Add(new SiteMapModelItem()
            {
                SiteMapModelItemText = "Contact Us",
                SiteMapModelItemURL = "contact",
            });
            smm.Company.Add(new SiteMapModelItem()
            {
                SiteMapModelItemText = "Privacy Policy",
                SiteMapModelItemURL = "privacy",
            });
            smm.Company.Add(new SiteMapModelItem()
            {
                SiteMapModelItemText = "Terms Of Use",
                SiteMapModelItemURL = "terms",
            });
            smm.Company.Add(new SiteMapModelItem()
            {
                SiteMapModelItemText = "Corporate Information",
                SiteMapModelItemURL = "corporate",
            });

            return smm;
        }
        #endregion

        #region ConvertContentText
        public static IList<ContentTextModel> ConvertContentText(IList<ContentText> ct, ContentDataPage contentDataPage)
        {
            var ctm = ct.Select(x => new ContentTextModel()
            {
                BodyOrder = x.BodyOrder,
                ContentTextData = x.ContentTextData,
                ContentTextID = x.ContentTextID,
                NiceName = x.NiceName,
                ContentTextType = x.ContentTextType != null ? new ContentTextTypeModel()
                {
                    ContentTextTypeID = x.ContentTextType.ContentTextTypeID,
                    ContentTextTypeName = x.ContentTextType.ContentTextTypeName,
                } : null,
                CompositeID = x.CompositeID,
                ContentTextGraphic = x.ContentTextGraphic,
                HyperLinkURL = x.HyperLinkURL,
                IsBold = x.IsBold,
                IsEmailLink = x.IsEmailLink,
                IsHyperLink = x.IsHyperLink,
                IsUnderline = x.IsUnderline,
                IsBulleted = x.IsBulleted,
                IsDate = x.IsDate,
                IsNumbered = x.IsNumbered,
                NumberOrder = x.NumberOrder,
                NumberSuffix = x.NumberSuffix,
                HeaderTagType = x.ContentTextType.ContentTextTypeName.EndsWith("H1_TITLE") ? HeaderTagType.H1 : HeaderTagType.H2,
                ContentDataPage = contentDataPage,
                LineBreakBefore = x.LineBreakBefore ?? false,
                LineBreakAfter = x.LineBreakAfter ?? false,
            });
            return ctm.ToList();
        }
        #endregion

        #region LogTabbedSearchResultsModelSiteAnalytic
        public static void LogTabbedSearchResultsModelSiteAnalytic(TabbedSearchResultsModel tsrm, int whichTab, ISiteAnalyticsLogger siteAnalyticsLogger, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            if (tsrm.CategoryID == null)
            {
                switch (whichTab)
                {
                    case 1: tsrm.FeaturedCloudwareNew.FeaturedCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsFeaturedOnHomePage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                    case 2: tsrm.NewCloudwareNew.NewCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsNewOnHomePage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                    case 3: tsrm.TopTenCloudwareNew.TopTenCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsTop10OnHomePage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                }
            }
            else
            {
                switch (whichTab)
                {
                    case 1: tsrm.FeaturedCloudwareNew.FeaturedCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsFeaturedOnCategoryPage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                    case 2: tsrm.NewCloudwareNew.NewCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsNewOnCategoryPage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                    case 3: tsrm.TopTenCloudwareNew.TopTenCloudware.ForEach(srm => siteAnalyticsLogger.Log(repository, ActionType.InViewResultsTop10OnCategoryPage, srm.CloudApplicationID, null, customSession.PersonID));
                        break;
                }
            }
        }

        public static void LogSearchResultModelSiteAnalytic(PagedList<SearchResultModelOneColumn> pl, int categoryID, ISiteAnalyticsLogger siteAnalyticsLogger, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            if (customSession.VisitedViaCategory)
            {
                pl.ForEach(srmoc => siteAnalyticsLogger.Log(repository, ActionType.InComparisonResultsFromClickCategoryPageCompare, srmoc.CloudApplicationID, categoryID, customSession.PersonID));
            }
            else
            {
                pl.ForEach(srmoc => siteAnalyticsLogger.Log(repository, ActionType.InComparisonResultsFromClickHomePageCompare, srmoc.CloudApplicationID, categoryID, customSession.PersonID));
            }
        }

        public static void LogSearchFilterModelSiteAnalytic(int? categoryID, string featureType, int featureID, ISiteAnalyticsLogger siteAnalyticsLogger, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            if (customSession.VisitedViaCategory)
            {
                //    pl.ForEach(srmoc => _siteAnalyticsLogger.Log(_repository, ActionType.InComparisonResultsFromClickCategoryPageCompare, srmoc.CloudApplicationID, categoryID, CustomSession.PersonID));
            }
            else
            {
                //    pl.ForEach(srmoc => _siteAnalyticsLogger.Log(_repository, ActionType.InComparisonResultsFromClickHomePageCompare, srmoc.CloudApplicationID, categoryID, CustomSession.PersonID));
            }
        }

        #endregion

        #region CategoryPage
        //[SessionExpireFilter]
        //public ActionResult CategoryPage(int? categoryID, CategoryPageModel model2)
        public static CategoryPageModel ConstructCategoryPage(string categoryName, ISiteAnalyticsLogger siteAnalyticsLogger, ICustomSession customSession, ICompareCloudwareRepository repository, HttpRequestBase request)
        {
            try
            {
                Category c = repository.FindCategoryByURL(categoryName);

                SetSessionVariables(request, customSession);

                var model = ModelHelpers.ConstructCategoryPageModel(new CategoryPageModel(customSession, ModelHelpers.ConvertContentPageToContentPageModel(repository.GetContentPage(c.CategoryName))), c.CategoryID, customSession, repository);
                model.TabbedSearchResultsModel.CategoryBasedResults = true;

                model.SearchInputModel.Forename = customSession.Forename ?? "First Name";
                model.SearchInputModel.Surname = customSession.Surname ?? "Surname";
                model.SearchInputModel.EMail = customSession.EMail ?? "EMail";


                customSession.VisitedViaCategory = true;
                customSession.HasSearchResults = false;

                siteAnalyticsLogger.Log(repository, ActionType.ClickCategory, null, c.CategoryID, customSession.PersonID);
                //LogTabbedSearchResultsModelSiteAnalytic(model.TabbedSearchResultsModel,1);

                AdvertisingImage ai1 = GetMPU(customSession,repository);
                AdvertisingImage ai2 = GetMPU(customSession,repository);

                if (ai1 != null)
                {
                    model.MPUAdvertisingImageID1 = ai1.AdvertisingImageID;
                    model.MPUCloudApplicationID1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationID : 0;
                    model.MPUAdvertisingImageCategoryTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                    model.MPUAdvertisingImageShopTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationShopTag.TagName : null;
                }

                if (ai2 != null)
                {
                    model.MPUAdvertisingImageID2 = ai2.AdvertisingImageID;
                    model.MPUCloudApplicationID2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationID : 0;
                    model.MPUAdvertisingImageCategoryTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                    model.MPUAdvertisingImageShopTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationShopTag.TagName : null;
                }

                //return View(model);
                model.Carousel = new CarouselModel(customSession, repository,CarouselType.Category);
                
                return model;
            }
            catch (SessionExpiredException e)
            {
                //Response.Redirect(homePageURL);
                return null;
            }
            //return View("Index");
        }
        #endregion

        #region ConstructCategoryPageModel
        public static CategoryPageModel ConstructCategoryPageModel(CategoryPageModel model, int categoryID, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            model.CustomSession = customSession;
            model.CustomSession.SelectedCategoryID = categoryID;

            model.SearchInputModel = new SearchInputModel(customSession);

            model.SearchInputModel.Categories = ModelHelpers.GetCategories(customSession, repository);
            model.SearchInputModel.NumberOfUsers = ModelHelpers.GetNumberOfUsers(repository);
            model.SearchInputModel.NumberOfUsers = ModelHelpers.AddNumberOfUsersToList(model.SearchInputModel.NumberOfUsers, "User numbers");
            //model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = categoryID;
            model.SearchInputModel.Forename = customSession.Forename ?? "First Name";
            model.SearchInputModel.Surname = customSession.Surname ?? "Surname";
            model.SearchInputModel.EMail = customSession.EMail ?? "EMail";
            model.SearchInputModel.DisplayStyle = SearchInputModelStyle.CategoryPage;

            if (model.TabbedSearchResultsModel == null)
            {
                model.TabbedSearchResultsModel = new TabbedSearchResultsModel(customSession);
                model.TabbedSearchResultsModel.FeaturedCloudwareSearchResultsVisible = true;
            }
            model.TabbedSearchResultsModel.FeaturedCloudware = ModelHelpers.ConvertSearchResultToSearchResultModel(repository.GetFeaturedCloudware(categoryID, SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_FEATURED, ModelHelpers.LiveApplicationsOnly(customSession)), customSession);
            model.TabbedSearchResultsModel.TopTenCloudware = ModelHelpers.ConvertSearchResultToSearchResultModel(repository.GetTopTenCloudware(categoryID, SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_TOP10, ModelHelpers.LiveApplicationsOnly(customSession)), customSession);
            model.TabbedSearchResultsModel.NewCloudware = ModelHelpers.ConvertSearchResultToSearchResultModel(repository.GetNewCloudware(categoryID, SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_NEW, ModelHelpers.LiveApplicationsOnly(customSession)), customSession);
            model.TabbedSearchResultsModel.CategoryID = categoryID;

            //NEW DISPLAY TEMPLATES
            model.TabbedSearchResultsModel.FeaturedCloudwareNew = new FeaturedCloudwareModel();
            model.TabbedSearchResultsModel.FeaturedCloudwareNew.FeaturedCloudware = model.TabbedSearchResultsModel.FeaturedCloudware;
            model.TabbedSearchResultsModel.NewCloudwareNew = new NewCloudwareModel();
            model.TabbedSearchResultsModel.NewCloudwareNew.NewCloudware = model.TabbedSearchResultsModel.NewCloudware;
            model.TabbedSearchResultsModel.TopTenCloudwareNew = new TopTenCloudwareModel();
            model.TabbedSearchResultsModel.TopTenCloudwareNew.TopTenCloudware = model.TabbedSearchResultsModel.TopTenCloudware;
            ModelHelpers.SetTabLayoutPosition(model.TabbedSearchResultsModel.FeaturedCloudwareNew.FeaturedCloudware);
            ModelHelpers.SetTabLayoutPosition(model.TabbedSearchResultsModel.NewCloudwareNew.NewCloudware);
            ModelHelpers.SetTabLayoutPosition(model.TabbedSearchResultsModel.TopTenCloudwareNew.TopTenCloudware);

            model.ContentTextsModel = new ContentTextsModel(customSession);
            model.H1H2ContentText = new ContentTextsModel(customSession);

            model.TabbedOnpageOptimisationModel = new TabbedOnpageOptimisationModel(customSession);


            //int[] IDs;
            switch (categoryID)
            {
                case CATEGORY_ID_PHONE:
                case CATEGORY_ID_COMMUNICATIONS:
                    //IDs = new[] { 7, 29, 30, 31 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PHONE_CATEGORY_TITLE", "PHONE_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PHONE_H1_TITLE", "PHONE_H1_BODY", "PHONE_H2_1_TITLE", "PHONE_H2_1_BODY", "PHONE_H2_2_TITLE", "PHONE_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_CRM:
                    //IDs = new[] { 8, 32, 33, 34 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CRM_CATEGORY_TITLE", "CRM_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CRM_H1_TITLE", "CRM_H1_BODY", "CRM_H2_1_TITLE", "CRM_H2_1_BODY", "CRM_H2_2_TITLE", "CRM_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_WEB_CONFERENCING:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CONFERENCING_CATEGORY_TITLE", "CONFERENCING_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CONFERENCING_H1_TITLE", "CONFERENCING_H1_BODY", "CONFERENCING_H2_1_TITLE", "CONFERENCING_H2_1_BODY", "CONFERENCING_H2_2_TITLE", "CONFERENCING_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_EMAIL:
                    //IDs = new[] { 4, 18, 19, 20, 21, 22 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "EMAIL_CATEGORY_TITLE", "EMAIL_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "EMAIL_H1_TITLE", "EMAIL_H1_BODY", "EMAIL_H2_1_TITLE", "EMAIL_H2_1_BODY", "EMAIL_H2_2_TITLE", "EMAIL_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_OFFICE:
                    //IDs = new[] { 6, 26, 27, 28 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "OFFICE_CATEGORY_TITLE", "OFFICE_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "OFFICE_H1_TITLE", "OFFICE_H1_BODY", "OFFICE_H2_1_TITLE", "OFFICE_H2_1_BODY", "OFFICE_H2_2_TITLE", "OFFICE_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_STORAGE_AND_BACKUP:
                    //IDs = new[] { 3, 15, 16, 17 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "STORAGEANDBACKUP_CATEGORY_TITLE", "STORAGEANDBACKUP_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "STORAGEANDBACKUP_H1_TITLE", "STORAGEANDBACKUP_H1_BODY", "STORAGEANDBACKUP_H2_1_TITLE", "STORAGEANDBACKUP_H2_1_BODY", "STORAGEANDBACKUP_H2_2_TITLE", "STORAGEANDBACKUP_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_PROJECT_MANAGEMENT:
                    //IDs = new[] { 2, 12, 13, 14 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PROJECTMANAGEMENT_CATEGORY_TITLE", "PROJECTMANAGEMENT_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PROJECTMANAGEMENT_H1_TITLE", "PROJECTMANAGEMENT_H1_BODY", "PROJECTMANAGEMENT_H2_1_TITLE", "PROJECTMANAGEMENT_H2_1_BODY", "PROJECTMANAGEMENT_H2_2_TITLE", "PROJECTMANAGEMENT_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_FINANCIAL:
                    //IDs = new[] { 5, 23, 24, 25 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "FINANCIAL_CATEGORY_TITLE", "FINANCIAL_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "FINANCIAL_H1_TITLE", "FINANCIAL_H1_BODY", "FINANCIAL_H2_1_TITLE", "FINANCIAL_H2_1_BODY", "FINANCIAL_H2_2_TITLE", "FINANCIAL_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_SECURITY:
                    //IDs = new[] { 8, 32, 33, 34 };
                    //model.ContentTextsModel.ContentTexts = ConvertContentText(_repository.GetContentData(IDs)).ToList();
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "SECURITY_CATEGORY_TITLE", "SECURITY_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "SECURITY_H1_TITLE", "SECURITY_H1_BODY", "SECURITY_H2_1_TITLE", "SECURITY_H2_1_BODY", "SECURITY_H2_2_TITLE", "SECURITY_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_MARKETING:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "MARKETING_CATEGORY_TITLE", "MARKETING_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "MARKETING_H1_TITLE", "MARKETING_H1_BODY", "MARKETING_H2_1_TITLE", "MARKETING_H2_1_BODY", "MARKETING_H2_2_TITLE", "MARKETING_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_WEBSITE:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "WEBSITE_CATEGORY_TITLE", "WEBSITE_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "WEBSITE_H1_TITLE", "WEBSITE_H1_BODY", "WEBSITE_H2_1_TITLE", "WEBSITE_H2_1_BODY", "WEBSITE_H2_2_TITLE", "WEBSITE_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_CREATIVE:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CREATIVE_CATEGORY_TITLE", "CREATIVE_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "CREATIVE_H1_TITLE", "CREATIVE_H1_BODY", "CREATIVE_H2_1_TITLE", "CREATIVE_H2_1_BODY", "CREATIVE_H2_2_TITLE", "CREATIVE_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_INTELLIGENCE_AND_REPORTING:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "INTELLIGENCEANDREPORTING_CATEGORY_TITLE", "INTELLIGENCEANDREPORTING_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "INTELLIGENCEANDREPORTING_H1_TITLE", "INTELLIGENCEANDREPORTING_H1_BODY", "INTELLIGENCEANDREPORTING_H2_1_TITLE", "INTELLIGENCEANDREPORTING_H2_1_BODY", "INTELLIGENCEANDREPORTING_H2_2_TITLE", "INTELLIGENCEANDREPORTING_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_HOSTING:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HOSTING_CATEGORY_TITLE", "HOSTING_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HOSTING_H1_TITLE", "HOSTING_H1_BODY", "HOSTING_H2_1_TITLE", "HOSTING_H2_1_BODY", "HOSTING_H2_2_TITLE", "HOSTING_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_HR:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HR_CATEGORY_TITLE", "HR_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HR_H1_TITLE", "HR_H1_BODY", "HR_H2_1_TITLE", "HR_H2_1_BODY", "HR_H2_2_TITLE", "HR_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_PAYMENTS:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PAYMENTS_CATEGORY_TITLE", "PAYMENTS_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "PAYMENTS_H1_TITLE", "PAYMENTS_H1_BODY", "PAYMENTS_H2_1_TITLE", "PAYMENTS_H2_1_BODY", "PAYMENTS_H2_2_TITLE", "PAYMENTS_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_BUSINESS_AND_OPERATIONS:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "BUSINESSANDOPERATIONS_CATEGORY_TITLE", "BUSINESSANDOPERATIONS_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "BUSINESSANDOPERATIONS_H1_TITLE", "BUSINESSANDOPERATIONS_H1_BODY", "BUSINESSANDOPERATIONS_H2_1_TITLE", "BUSINESSANDOPERATIONS_H2_1_BODY", "BUSINESSANDOPERATIONS_H2_2_TITLE", "BUSINESSANDOPERATIONS_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
                case CATEGORY_ID_SALES:
                    model.ContentTextsModel.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "SALES_CATEGORY_TITLE", "SALES_CATEGORY_BODY" }), ContentDataPage.Category).ToList();
                    model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "SALES_H1_TITLE", "SALES_H1_BODY", "SALES_H2_1_TITLE", "SALES_H2_1_BODY", "SALES_H2_2_TITLE", "SALES_H2_2_BODY" }), ContentDataPage.Category).ToList();
                    break;
            }

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H1_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H1_BODY")).ToList();
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_BODY")).ToList(); ;
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_BODY")).ToList(); ;

            model.TabbedOnpageOptimisationModel.Tab1Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H1_TITLE")).FirstOrDefault().ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab2Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_1_TITLE")).FirstOrDefault().ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab3Title = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("H2_2_TITLE")).FirstOrDefault().ContentTextData;

            SetFirstAndLastInCollection(model.TabbedOnpageOptimisationModel);

            
            return model;
        }
        #endregion



        #region ConvertCloudApplicationToGlobalSearchResultModelOneColumn
        public static GlobalSearchResultModelOneColumn ConvertCloudApplicationToGlobalSearchResultModelOneColumn(CloudApplication ca)
        {
            bool useExchangeRateForSorting = Convert.ToBoolean(ConfigurationManager.AppSettings["UseExchangeRatesForSorting"]);
            var gsrm = new GlobalSearchResultModelOneColumn()
            {
                ApplicationCostOneOff = ca.ApplicationCostOneOff,

                ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                ApplicationCostPerAnnumFrom = ca.ApplicationCostPerAnnumFrom,
                ApplicationCostPerAnnumTo = ca.ApplicationCostPerAnnumTo,
                ApplicationCostPerAnnumPOA = ca.ApplicationCostPerAnnumPOA,
                ApplicationCostPerAnnumFree = ca.ApplicationCostPerAnnumFree,
                ApplicationCostPerAnnumOffered = ca.ApplicationCostPerAnnumOffered,

                ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                ApplicationCostPerMonthFrom = ca.ApplicationCostPerMonthFrom,
                ApplicationCostPerMonthTo = ca.ApplicationCostPerMonthTo,
                ApplicationCostPerMonthPOA = ca.ApplicationCostPerMonthPOA,
                ApplicationCostPerMonthFree = ca.ApplicationCostPerMonthFree,
                ApplicationCostPerMonthOffered = ca.ApplicationCostPerMonthOffered,
                ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthSuffix,

                CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,


                CloudApplicationID = ca.CloudApplicationID,
                Description = ca.Description,
                FreeTrialPeriod = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodName : null,
                ServiceName = ca.ServiceName,
                SetupFee = ca.SetupFee != null ? ca.SetupFee.SetupFeeName : null,
                VendorID = ca.Vendor.VendorID,
                VendorLogoURL = ca.Vendor.VendorLogoFullURL,
                VendorName = ca.Vendor.VendorName,

                CloudApplicationCategoryTag = ca.CloudApplicationCategoryTag.TagName,
                CloudApplicationShopTag = ca.CloudApplicationShopTag.TagName,

                Currency = ca.CloudApplicationCurrency != null ? new CurrencyModel()
                {
                    CurrencyID = ca.CloudApplicationCurrency.CurrencyID,
                    CurrencyName = ca.CloudApplicationCurrency.CurrencyName,
                    CurrencyShortName = ca.CloudApplicationCurrency.CurrencyShortName,
                    CurrencySymbol = ca.CloudApplicationCurrency.CurrencySymbol,
                    ExchangeRateSterling = ca.CloudApplicationCurrency.ExchangeRateSterling,
                    UseExchangeRateForSorting = useExchangeRateForSorting,
                } : null
            };
            return gsrm;
        }
        #endregion

        #region ConvertContentPageToContentPageModel
        public static ContentPageModel ConvertContentPageToContentPageModel(ContentPage cp)
        {
            if (cp != null)
            {
                var cpm = new ContentPageModel()
                {
                    Author = cp.Author,
                    ContentPageID = cp.ContentPageID,
                    Frequency = (short)cp.Frequency,
                    GooglePlusId = cp.GooglePlusId,
                    Keywords = cp.Keywords,
                    Markdown = cp.Markdown,
                    MetaDescription = cp.MetaDescription,
                    MetaKeywords = cp.MetaKeywords,
                    MetaTitle = cp.MetaTitle,
                    Modified = cp.Modified,
                    NoSearch = cp.NoSearch,
                    Priority = cp.Priority,
                    Route = cp.Route,
                    Slug = cp.Slug,
                    SortOrder = cp.SortOrder,
                    Title = cp.Title,
                };
                return cpm;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region GetCloudApplicationModel
        [SessionExpireFilter]
        public static SearchPageModel GetCloudApplicationModel(int cloudApplicationID, string term, bool? showUserReviewConfirmation, ICustomSession customSession, ICompareCloudwareRepository repository, ILogger Logger, ISiteAnalyticsLogger siteAnalyticsLogger, Controller controller, HttpRequestBase request)
        {
            int categoryID;
            SetSessionVariables(request, customSession);
            SearchPageModel model = new SearchPageModel(customSession);
            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #1");
            ModelHelpers.GetModelFromViewData(model, controller);

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #2");
            CloudApplicationModel cam = null;
            CloudApplication ca = repository.GetCloudApplication(cloudApplicationID, true, true, RefreshMode.StoreWins);

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #2.5");
            categoryID = ca.Category.CategoryID;

            IList<CloudApplication> alternatives = repository.GetCloudApplicationsByVendor(ca.Vendor.VendorID, ca.Category.CategoryID, true);
            Logger.Debug("Getting cloud applications by vendor OUT");

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #3");
            cam = ModelHelpers.ConstructCloudApplicationModel(ca, alternatives, customSession, repository, Logger, request);


            model.ContainerModel.ChosenCloudApplicationModel = cam;
            ModelHelpers.SetSearchResultsColumnHeaders(categoryID, cam.CloudApplicationSearchResultModel, repository);

            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename = customSession.Forename;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname = customSession.Surname;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees = customSession.NumberOfUsers ?? 0;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress = customSession.EMail;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company = customSession.Company;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone = customSession.Telephone;
            model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CloudApplicationID = cloudApplicationID;

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #4");
            ModelHelpers.FixUpViewData(model, controller);

            if (customSession.PersonID != null)
            {
                if (customSession.VisitedViaCategory)
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ShopVisitViaCategoryIdentified, cloudApplicationID, categoryID, customSession.PersonID);
                }
                else
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ShopVisitNonCategoryIdentified, cloudApplicationID, null, customSession.PersonID);
                }
            }
            else
            {
                if (customSession.VisitedViaCategory)
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ShopVisitViaCategory, cloudApplicationID, categoryID);
                }
                else
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ShopVisitNonCategory, cloudApplicationID);
                }
            }

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #5");
            if (showUserReviewConfirmation ?? false)
            {
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "User review complete";
                model.ConfirmationDialogMessage1 = "Thank you, your review has been registered with us.";
            }

            Logger.Debug("Sending request for cloud application : " + cloudApplicationID.ToString());
            if (model.ContainerModel.ChosenCloudApplicationModel.CloudApplicationVideos != null)
            {
                if (model.ContainerModel.ChosenCloudApplicationModel.CloudApplicationVideos.Count == 1)
                {
                    //@Html.EditorFor(x => x.ContainerModel.ChosenCloudApplicationModel.CloudApplicationVideos)
                }
                else
                {
                    Logger.Fatal("Cloud application " + cloudApplicationID.ToString() + " contains " + model.ContainerModel.ChosenCloudApplicationModel.CloudApplicationVideos.Count.ToString() + "videos");
                }
            }
            else
            {
                Logger.Fatal("Cloud application " + cloudApplicationID.ToString() + " does not contain any video");
            }

            return model;
        }
        #endregion

        
        
        #region ConstructCloudApplicationModel
        public static CloudApplicationModel ConstructCloudApplicationModel(CloudApplication ca, IList<CloudApplication> alternatives, ICustomSession customSession, ICompareCloudwareRepository repository, ILogger Logger, HttpRequestBase request)
        {
            //string xx = "";
            //Logger.Debug("ConstructCloudApplication : step #1");
            bool useExchangeRateForSorting = Convert.ToBoolean(ConfigurationManager.AppSettings["UseExchangeRatesForSorting"]);

            if (
                ca.Browsers == null ||
                ca.Category == null ||
                ca.CloudApplicationFeatures == null ||
                ca.FreeTrialPeriod == null ||
                ca.Languages == null ||
                ca.LicenceTypeMaximum == null ||
                ca.LicenceTypeMinimum == null ||
                ca.MinimumContract == null ||
                ca.MobilePlatforms == null ||
                ca.OperatingSystems == null ||
                ca.PaymentFrequency == null ||
                ca.PaymentOptions == null

                )
            {
                //string x = "";
            }

            //Logger.Debug("ConstructCloudApplication : step #2");
            CloudApplicationModel cam = new CloudApplicationModel(customSession)
            {
                AddDate = ca.AddDate,
                ApplicationContentStatusID = ca.ApplicationContentStatusID,
                ApplicationCostOneOff = ca.ApplicationCostOneOff,
                ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,


                ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthSuffix,
                ApprovalAssignedPersonID = ca.ApprovalAssignedPersonID,
                ApprovalStatusID = ca.ApprovalStatusID,
                AverageEaseOfUse = ca.AverageEaseOfUse,
                AverageFunctionality = ca.AverageFunctionality,
                AverageOverallRating = ca.AverageOverallRating,
                AverageValueForMoney = ca.AverageValueForMoney,
                Brand = ca.Brand,
                CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,

                CloudApplicationID = ca.CloudApplicationID,
                CloudApplicationLogo = ca.CloudApplicationLogo,
                CompanyURL = ca.CompanyURL,
                Description = ca.Description,
                DemoOffered = ca.DemoOffered,
                FacebookFollowers = ca.FacebookFollowers,
                FacebookURL = ca.FacebookURL,
                //IsPromotional = ca.IsPromotional,
                LinkedInFollowers = ca.LinkedInFollowers,
                LinkedInURL = ca.LinkedInURL,
                MaximumMeetingAttendees = ca.MaximumMeetingAttendees,
                MaximumWebinarAttendees = ca.MaximumWebinarAttendees,

                BuyURL = ca.BuyURL,
                TryURL = ca.TryURL,
                ServiceName = ca.ServiceName,
                Title = ca.Title,
                TwitterFollowers = ca.TwitterFollowers,
                TwitterURL = ca.TwitterURL,
                VideoTrainingSupport = ca.VideoTrainingSupport,

                SocialShareModel = new SocialShareModel(customSession,ca.Category.CategoryID),
            };

            //Logger.Debug("ConstructCloudApplication : step #3");

            #region CloudApplicationSearchResultModel
            cam.CloudApplicationSearchResultModel = new CloudApplicationSearchResultShopModel(customSession)
            {
                ApplicationCostOneOff = ca.ApplicationCostOneOff,
                ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                ApplicationCostPerAnnumFrom = ca.ApplicationCostPerAnnumFrom,
                ApplicationCostPerAnnumTo = ca.ApplicationCostPerAnnumTo,
                ApplicationCostPerAnnumOffered = ca.ApplicationCostPerAnnumOffered,
                ApplicationCostPerAnnumFree = ca.ApplicationCostPerAnnumFree,
                ApplicationCostPerAnnumIsForUnlimitedUsers = ca.ApplicationCostPerAnnumIsForUnlimitedUsers ?? false,

                ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                ApplicationCostPerMonthFrom = ca.ApplicationCostPerMonthFrom,
                ApplicationCostPerMonthTo = ca.ApplicationCostPerMonthTo,
                ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthSuffix,
                ApplicationCostPerMonthOffered = ca.ApplicationCostPerMonthOffered,
                ApplicationCostPerMonthFree = ca.ApplicationCostPerMonthFree,
                ApplicationCostPerMonthIsForUnlimitedUsers = ca.ApplicationCostPerMonthIsForUnlimitedUsers ?? false,

                ApplicationCostPerAnnumPOA = ca.ApplicationCostPerAnnumPOA,
                ApplicationCostPerMonthPOA = ca.ApplicationCostPerMonthPOA,
                PayAsYouGo = ca.PayAsYouGo,

                CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,
                CloudApplicationID = ca.CloudApplicationID,
                CategoryID = ca.Category.CategoryID,
                Description = ca.Description,
                FreeTrialPeriod = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodName : null,
                DemoOffered = ca.DemoOffered,
                SearchResultID = 0,
                ServiceName = ca.ServiceName,
                SetupFee = ca.SetupFee != null ? ca.SetupFee.SetupFeeName : null,
                VendorLogoURL = ca.Vendor.VendorLogoFileName.AddImagePath(),
                VendorName = ca.Vendor.VendorName,
                VendorID = ca.Vendor.VendorID,
                ResultDisplayFormat = SearchResultDisplayFormat.Single,

            };

            //Logger.Debug("ConstructCloudApplication : step #4");

            #region OperatingSystems
            cam.CloudApplicationSearchResultModel.OperatingSystems = ca.OperatingSystems.Select(x => new OperatingSystemModelSearchResults()
            {
                OperatingSystemID = x.OperatingSystemID,
                OperatingSystemName = x.OperatingSystemName,
            }).ToList();

            #endregion

            //Logger.Debug("ConstructCloudApplication : step #5");

            #region SupportTypes
            cam.CloudApplicationSearchResultModel.SupportTypes = ca.SupportTypes.Select(x => new SupportTypeModel()
            {
                SupportTypeID = x.SupportTypeID,
                SupportTypeName = x.SupportTypeName,
            }).ToList();
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #6");

            #region SupportDays
            cam.CloudApplicationSearchResultModel.SupportDays = new SupportDaysModel()
            {
                SupportDaysID = ca.SupportDays != null ? ca.SupportDays.SupportDaysID : 0,
                SupportDaysName = ca.SupportDays != null ? ca.SupportDays.SupportDaysName : "",
            };
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #7");

            #region Languages
            cam.CloudApplicationSearchResultModel.Languages = ca.Languages.Select(x => new LanguageModel()
            {
                LanguageID = x.LanguageID,
                LanguageName = x.LanguageName,
            }).ToList();
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #8");

            #region Features
            cam.CloudApplicationSearchResultModel.CloudApplicationFeatures = ca.CloudApplicationFeatures.Select(x => new CloudApplicationFeatureModel()
            {
                CloudApplicationFeatureID = x.CloudApplicationFeatureID,
                Cost = x.Cost,
                Count = x.Count,
                CountSuffix = x.CountSuffix,
                Feature = new FeatureModel()
                {
                    FeatureColumnNumber = x.Feature.FeatureColumnNumber,
                    FeatureID = x.Feature.FeatureID,
                    FeatureName = x.Feature.FeatureName,
                    FeatureRowNumber = x.Feature.FeatureRowNumber,
                },
                //Include = x.Include,
                //IncludeCount = x.IncludeCount,
                //IncludeCountSuffix = x.IncludeCountSuffix,
                //IncludeExtraCost = x.IncludeExtraCost,

            }).ToList();
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #9");

            //Logger.Debug("ConstructCloudApplication : step #10 - " + ca.CloudApplicationApplications != null ? ca.CloudApplicationApplications.Count.ToString() : "NULL");

            #region Applications
            var test = ca.CloudApplicationApplications.ToList();
            foreach (CloudApplicationApplication caa in ca.CloudApplicationApplications)
            {
                if (caa.Feature == null)
                {
                    Logger.Debug("NO FEATURE : " + caa.CloudApplicationApplicationID);
                }
            }

            //Logger.Debug("ConstructCloudApplication : step #11");

            cam.CloudApplicationSearchResultModel.CloudApplicationApplications = ca.CloudApplicationApplications != null ? ca.CloudApplicationApplications.Where(x => x.Feature != null).Select(x => new CloudApplicationApplicationModel()
            {
                CloudApplicationFeatureID = x.CloudApplicationApplicationID,
                Cost = x.Cost,
                Count = x.Count,
                CountSuffix = x.CountSuffix,
                Feature = new FeatureModel()
                {
                    FeatureColumnNumber = x.Feature.FeatureColumnNumber,
                    FeatureID = x.Feature.FeatureID,
                    FeatureName = x.Feature.FeatureName,
                    FeatureRowNumber = x.Feature.FeatureRowNumber,
                },
                //Include = x.Include,
                //IncludeCount = x.IncludeCount,
                //IncludeCountSuffix = x.IncludeCountSuffix,
                //IncludeExtraCost = x.IncludeExtraCost,

            }).ToList() : null;
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #12");

            #region Currency
            cam.CloudApplicationSearchResultModel.Currency = ca.CloudApplicationCurrency != null ? new CurrencyModel(customSession)
            {
                CurrencyID = ca.CloudApplicationCurrency.CurrencyID,
                CurrencyName = ca.CloudApplicationCurrency.CurrencyName,
                CurrencyShortName = ca.CloudApplicationCurrency.CurrencyShortName,
                CurrencySymbol = ca.CloudApplicationCurrency.CurrencySymbol,
                ExchangeRateSterling = ca.CloudApplicationCurrency.ExchangeRateSterling,
                UseExchangeRateForSorting = useExchangeRateForSorting,
            } : null;
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #13");

            #endregion


            #region Browsers
            cam.Browsers = ca.Browsers.Select(x => new BrowserModel(customSession)
            {
                BrowserColumnNumber = x.BrowserColumnNumber,
                BrowserID = x.BrowserID,
                BrowserName = x.BrowserName,
                BrowserRowNumber = x.BrowserRowNumber,
            }).ToList();
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #14");

            #region Category
            cam.Category = new CategoryModel(customSession)
            {
                CategoryID = ca.Category.CategoryID,
                CategoryName = ca.Category.CategoryName,
            };
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #15");

            #region Features
            cam.CloudApplicationFeatures = ca.CloudApplicationFeatures.Select(y => new CloudApplicationFeatureModel()
            {
                CloudApplicationFeatureID = y.CloudApplicationFeatureID,
                Cost = y.Cost,
                Count = y.Count,
                CountSuffix = y.CountSuffix,
                Feature = new FeatureModel()
                {
                    FeatureColumnNumber = y.Feature.FeatureColumnNumber,
                    FeatureID = y.Feature.FeatureID,
                    FeatureName = y.Feature.FeatureName,
                    FeatureRowNumber = y.Feature.FeatureRowNumber,
                },
                //Include = y.Include,
                //IncludeCount = y.IncludeCount,
                //IncludeCountSuffix = y.IncludeCountSuffix,
                //IncludeExtraCost = y.IncludeExtraCost,
            }).ToList();
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #16");

            #region Applications
            cam.CloudApplicationApplications = ca.CloudApplicationApplications != null ? ca.CloudApplicationApplications.Where(x => x.Feature != null).Select(y => new CloudApplicationApplicationModel()
            {
                CloudApplicationFeatureID = y.CloudApplicationApplicationID,
                Cost = y.Cost,
                Count = y.Count,
                CountSuffix = y.CountSuffix,
                Feature = new FeatureModel()
                {
                    FeatureColumnNumber = y.Feature.FeatureColumnNumber,
                    FeatureID = y.Feature.FeatureID,
                    FeatureName = y.Feature.FeatureName,
                    FeatureRowNumber = y.Feature.FeatureRowNumber,
                },
                //Include = y.Include,
                //IncludeCount = y.IncludeCount,
                //IncludeCountSuffix = y.IncludeCountSuffix,
                //IncludeExtraCost = y.IncludeExtraCost,
            }).ToList() : null;
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #17");

            #region FreeTrialBuyNow
            cam.FreeTrialBuyNow = new FreeTrialBuyNowModel(customSession)
            {
                Forename = customSession != null ? customSession.Forename : "",
                Surname = customSession != null ? customSession.Surname : "",
                EMailAddress = customSession != null ? customSession.EMail : "",
                //RequestTypes = ModelHelpers.GetRequestTypes(ca, "free trial", customSession, repository),
                FreeTrial = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodName.ToUpper() != "NO" : false,
                CategoryID = ca.Category.CategoryID,
                CloudApplicationName = string.Format("{0} {1}",ca.Vendor.VendorName,ca.ServiceName),
                CloudApplicationNumberOfUsers = string.Format("{0}-{1} users",ca.LicenceTypeMinimum.LicenceTypeMinimumName,ca.LicenceTypeMaximum.LicenceTypeMaximumName),
                TermsAndConditions = (customSession.Forename != null && customSession.Surname != null && customSession.EMail != null && customSession.NumberOfUsers > 0),
            };
            //cam.FreeTrialBuyNow.RequestTypeID = cam.FreeTrialBuyNow.RequestTypes.Where(x => x.Selected).FirstOrDefault().RequestTypeID;
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #18");

            #region FreeTrialPeriod
            cam.FreeTrialPeriod = new FreeTrialPeriodModel()
            {
                FreeTrialPeriodID = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodID : 0,
                FreeTrialPeriodName = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodName : null,
            };
            #endregion

            //Logger.Debug("ConstructCloudApplication : step #19");

            #region Languages
            cam.Languages = ca.Languages.Select(x => new LanguageModel()
            {
                LanguageID = x.LanguageID,
                LanguageName = x.LanguageName,
            }).ToList();
            #endregion


            //Logger.Debug("ConstructCloudApplication : step #20");

            #region LicenceTypeMaximum
            cam.LicenceTypeMaximum = new LicenceTypeMaximumModel()
            {
                LicenceTypeMaximumID = ca.LicenceTypeMaximum != null ? ca.LicenceTypeMaximum.LicenceTypeMaximumID : 0,
                LicenceTypeMaximumName = ca.LicenceTypeMaximum != null ? ca.LicenceTypeMaximum.LicenceTypeMaximumName.ToString() : null,
            };
            #endregion

            #region LicenceTypeMinimum
            cam.LicenceTypeMinimum = new LicenceTypeMinimumModel()
            {
                LicenceTypeMinimumID = ca.LicenceTypeMinimum != null ? ca.LicenceTypeMinimum.LicenceTypeMinimumID : 0,
                LicenceTypeMinimumName = ca.LicenceTypeMinimum != null ? ca.LicenceTypeMinimum.LicenceTypeMinimumName.ToString() : null,
            };
            #endregion

            #region MinimumContract
            cam.MinimumContract = ca.MinimumContract != null ? new MinimumContractModel()
            {
                MinimumContractID = ca.MinimumContract.MinimumContractID,
                MinimumContractName = ca.MinimumContract.MinimumContractName,
            } : null;
            #endregion

            #region MobilePlatforms
            cam.MobilePlatforms = ca.MobilePlatforms != null ? ca.MobilePlatforms.Select(x => new MobilePlatformModel()
            {
                MobilePlatformID = x.MobilePlatformID,
                MobilePlatformName = x.MobilePlatformName,
            }).ToList() : null;
            #endregion

            #region OperatingSystems
            cam.OperatingSystems = ca.OperatingSystems.Select(x => new OperatingSystemModel()
            {
                OperatingSystemID = x.OperatingSystemID,
                OperatingSystemName = x.OperatingSystemName,
            }).ToList();
            #endregion

            #region PaymentFrequency
            cam.PaymentFrequency = new PaymentFrequencyModel()
            {
                PaymentFrequencyID = ca.PaymentFrequency != null ? ca.PaymentFrequency.PaymentFrequencyID : 0,
                PaymentFrequencyName = ca.PaymentFrequency != null ? ca.PaymentFrequency.PaymentFrequencyName : null,
            };
            #endregion

            #region PaymentOptions
            cam.PaymentOptions = ca.PaymentOptions.Select(x => new PaymentOptionModel()
            {
                PaymentOptionID = x.PaymentOptionID,
                PaymentOptionName = x.PaymentOptionName,
            }).ToList();
            #endregion

            #region UserReviews
            int userReviewsToFetch = int.Parse(ConfigurationManager.AppSettings["UserReviewsPerShop"]);
            cam.CloudApplicationUserReviews = ca.CloudApplicationUserReviews.Select(x => new CloudApplicationUserReviewModel(customSession)
            {
                CloudApplicationUserReviewEaseOfUse = x.CloudApplicationUserReviewEaseOfUse,
                CloudApplicationUserReviewFunctionality = x.CloudApplicationUserReviewFunctionality,
                CloudApplicationUserReviewOverallRating = x.CloudApplicationUserReviewOverallRating,
                CloudApplicationUserReviewID = x.CloudApplicationUserReviewID,
                CloudApplicationUserReviewCompany = x.CloudApplicationUserReviewCompany,
                CloudApplicationUserReviewForename = x.CloudApplicationUserReviewForename,
                CloudApplicationUserReviewSurname = x.CloudApplicationUserReviewSurname,
                CloudApplicationUserReviewTitle = x.CloudApplicationUserReviewTitle,
                CloudApplicationUserReviewText = x.CloudApplicationUserReviewText,
                CloudApplicationUserReviewValueForMoney = x.CloudApplicationUserReviewValueForMoney,
                CloudApplicationUserReviewEmployeeCount = x.CloudApplicationUserReviewEmployeeCount,
                ChosenIndustry = new IndustryModel()
                {
                    code = x.CloudApplicationUserReviewIndustry.Code,
                    description = x.CloudApplicationUserReviewIndustry.Description,
                    IndustryID = x.CloudApplicationUserReviewIndustry.IndustryID,
                }
            }).Take(Math.Max(userReviewsToFetch, ca.CloudApplicationUserReviews.Count)).ToList();
            #endregion

            #region ProductReviews
            int productReviewsToFetch = int.Parse(ConfigurationManager.AppSettings["ProductReviewsPerShop"]);
            cam.CloudApplicationProductReviews = ca.CloudApplicationProductReviews.Select(x => new CloudApplicationProductReviewModel(customSession)
            {
                CloudApplicationProductReviewDate = x.CloudApplicationProductReviewDate,
                CloudApplicationProductReviewHeadline = x.CloudApplicationProductReviewHeadline,
                CloudApplicationProductReviewID = x.CloudApplicationProductReviewID,
                CloudApplicationProductReviewPublisherName = x.CloudApplicationProductReviewPublisherName,
                CloudApplicationProductReviewText = x.CloudApplicationProductReviewText,
                CloudApplicationProductReviewURL = x.CloudApplicationProductReviewURL,
                CloudApplicationProductReviewURLDocumentFormat = x.CloudApplicationProductReviewURLDocumentFormat.CloudApplicationDocumentFormatShortName,
                CloudApplicationProductReviewURLDocumentFormats = ConstructDocumentFileFormats(),
            })
                //.Where(x => x.CloudApplicationReviewURLDocumentExtension == "HTML")
                .Take(Math.Max(productReviewsToFetch, ca.CloudApplicationProductReviews.Count))
            .ToList()
            ;
            #endregion

            #region SetupFee
            cam.SetupFee = new SetupFeeModel()
            {
                SetupFeeID = ca.SetupFee != null ? ca.SetupFee.SetupFeeID : 0,
                SetupFeeName = ca.SetupFee != null ? ca.SetupFee.SetupFeeName : "",
            };
            #endregion

            #region SupportDays
            cam.SupportDays = new SupportDaysModel()
            {
                SupportDaysID = ca.SupportDays != null ? ca.SupportDays.SupportDaysID : 0,
                SupportDaysName = ca.SupportDays != null ? ca.SupportDays.SupportDaysName : "",
            };
            #endregion

            #region SupportHours
            cam.SupportHours = new SupportHoursModel()
            {
                SupportHoursID = ca.SupportHours != null ? ca.SupportHours.SupportHoursID : 0,
                SupportHoursName = ca.SupportHours != null ? ca.SupportHours.SupportHoursName : "",
            };
            #endregion

            #region SupportTerritories
            cam.SupportTerritories = ca.SupportTerritories != null ? ca.SupportTerritories.Select(x => new SupportTerritoryModel()
            {
                SupportTerritoryID = x.SupportTerritoryID,
                SupportTerritoryName = x.SupportTerritoryName,
            }).ToList() : null;
            #endregion

            #region SupportTypes
            cam.SupportTypes = ca.SupportTypes != null ? ca.SupportTypes.Select(x => new SupportTypeModel()
            {
                SupportTypeID = x.SupportTypeID,
                SupportTypeName = x.SupportTypeName,
            }).ToList() : null;
            #endregion

            #region CloudApplicationDocuments
            cam.CloudApplicationDocuments = ca.CloudApplicationDocuments.Select(x => new CloudApplicationDocumentModel()
            {
                CloudApplicationDocumentFileName = x.CloudApplicationDocumentFileName,
                CloudApplicationDocumentID = x.CloudApplicationDocumentID,
                CloudApplicationDocumentPhysicalFilePath = x.CloudApplicationDocumentPhysicalFilePath,
                CloudApplicationDocumentTitle = x.CloudApplicationDocumentTitle,
                CloudApplicationDocumentType = new CloudApplicationDocumentTypeModel()
                {
                    CloudApplicationDocumentTypeID = x.CloudApplicationDocumentType.CloudApplicationDocumentTypeID,
                    CloudApplicationDocumentTypeName = x.CloudApplicationDocumentType.CloudApplicationDocumentTypeName,
                },
                CloudApplicationDocumentURL = x.CloudApplicationDocumentURL,
            }).ToList();
            #endregion

            #region Vendor
            cam.Vendor = new VendorModel()
            {
                VendorID = ca.Vendor.VendorID,
                //VendorLogo = ca.Vendor.VendorLogo,
                VendorLogo = ca.Vendor.VendorLogo != null ? ca.Vendor.VendorLogo.Logo : null,
                VendorLogoFileName = ca.Vendor.VendorLogoFileName,
                VendorName = ca.Vendor.VendorName,
                VendorLogoFullURL = ca.Vendor.VendorLogoFullURL != null ? ca.Vendor.VendorLogoFullURL.Replace("//", "/") : null,
            };
            #endregion

            #region CloudApplicationVideos
            cam.CloudApplicationVideos = ca.CloudApplicationVideos != null ? ca.CloudApplicationVideos.Select(x => new CloudApplicationVideoModel(customSession, request)
            {
                CloudApplicationVideoFileFormat = x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "",
                CloudApplicationVideoFileName = x.CloudApplicationVideoFileName,
                CloudApplicationVideoID = x.CloudApplicationVideoID,
                CloudApplicationVideoURL = x.CloudApplicationVideoURL,
                IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                IsLocalDomain = x.IsLocalDomain,
                IsYouTubeStream = x.IsYouTubeStream,
                ReadyToPlay = true,
                CloudApplicationVideoStatus = x.CloudApplicationVideoStatus.StatusName,
            })
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == "MP4"))
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == "OGV"))
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == "WEBM"))
                //.Where(x => x.IsYouTubeStream)
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == "SWF"))
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == "MOV"))
                //.Where(x => ((x.CloudApplicationVideoFileFormat != null ? x.CloudApplicationVideoFileFormat.ToUpperInvariant() : "") == ConfigurationManager.AppSettings["VideoContainerFormat"]))
            .ToList()
            : null;
            #endregion

            cam.CloudApplicationModelAlternatives = new List<CloudApplicationModelAlternative>();
            if (alternatives != null)
            {
                foreach (CloudApplication capp in alternatives)
                {
                    if (capp.CloudApplicationID != cam.CloudApplicationID)
                    {
                        cam.CloudApplicationModelAlternatives.Add(capp.ConstructCloudApplicationModelAlternatives(customSession));
                        //var d = alternatives.ForEach(x => x.ConstructCloudApplicationModelAlternatives());
                    }
                }
            }
            //cam.FreeTrialBuyNow.Surname = "w";
            //cam.FreeTrialBuyNow.Company = "w";
            //cam.FreeTrialBuyNow.Telephone = "w";

            Logger.Debug("ConstructCloudApplication : step #4");

            cam.CloudApplicationUserReviewModel = new CloudApplicationUserReviewModel(customSession);
            cam.CloudApplicationUserReviewModel.CloudApplicationID = cam.CloudApplicationID;
            cam.CloudApplicationUserReviewModel.Industries = GetIndustries(repository);
            cam.CloudApplicationUserReviewModel.EmployeeCount = ModelHelpers.GetNumberOfUsers(true, repository);

            Logger.Debug("ConstructCloudApplication : step #5");

            cam = CheckForBrokenLinks(cam, true, Logger);

            Logger.Debug("ConstructCloudApplication : step #6");

            return cam;

        }


        #endregion

        #region CheckForBrokenLinks
        public static CloudApplicationModel CheckForBrokenLinks(CloudApplicationModel cam, bool removeFromList, ILogger Logger)
        {
            Logger.Debug("CheckForBrokenLinks IN");
            if (Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["CheckForBrokenLinks"].ToString()) == true)
            {
                if (cam.CloudApplicationProductReviews != null)
                {
                    foreach (CloudApplicationProductReviewModel carm in cam.CloudApplicationProductReviews)
                    {
                        Logger.Debug("Checking Broken Link...");
                        if (carm.CloudApplicationProductReviewURL != null)
                        {
                            // Create a new 'HttpWebRequest' Object to the mentioned URL.
                            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.samplepdf.com/zzzzzzzz.pdf");
                            //HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.swiftview.com/tech/letterlegal5.doc");


                            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
                            HttpWebResponse myHttpWebResponse;
                            try
                            {
                                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(carm.CloudApplicationProductReviewURL);
                                myHttpWebRequest.Method = "HEAD";
                                myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                                HttpStatusCode statusCode = myHttpWebResponse.StatusCode;
                            }
                            catch (WebException we)
                            {
                                carm.IsBrokenLink = true;
                                Logger.Error("BROKEN REVIEW LINK ( WEB EXCEPTION ) FOR : " + carm.CloudApplicationProductReviewURL + " CLOUD APPLICATION ID : " + carm.CloudApplicationID.ToString(), we);
                                //cam.Reviews.Remove(carm);
                            }
                            catch (UriFormatException ue)
                            {
                                carm.IsBrokenLink = true;
                                //Logger.Error("BROKEN REVIEW LINK", ue);
                                Logger.Error("BROKEN REVIEW LINK ( URI FORMAT EXCEPTION ) FOR : " + carm.CloudApplicationProductReviewURL + " CLOUD APPLICATION ID : " + carm.CloudApplicationID.ToString(), ue);
                                //cam.Reviews.Remove(carm);
                            }
                        }
                    }

                    if (removeFromList)
                    {
                        cam.CloudApplicationProductReviews = cam.CloudApplicationProductReviews.Where(x => !x.IsBrokenLink).ToList();
                    }
                }
            }
            Logger.Debug("CheckForBrokenLinks OUT");
            return cam;
        }
        #endregion

        #region ConvertGlobalSearchResults
        public static IEnumerable<GlobalSearchResultModelOneColumn> ConvertGlobalSearchResults(IEnumerable<CloudApplication> ca)
        {
            var cam = ca.ToList().Select(x => ConvertCloudApplicationToGlobalSearchResultModelOneColumn(x));
            return cam;
        }
        #endregion

        #region GetRequestTypes
        public static List<RequestTypeModel> GetRequestTypes(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            List<RequestTypeModel> retVal = repository.GetRequestTypes().Select(x => new RequestTypeModel(customSession)
            {
                RequestTypeID = x.RequestTypeID,
                RequestTypeName = x.RequestTypeName,
                Selected = false
            }).ToList();

            return retVal;
        }

        public static List<RequestTypeModel> GetRequestTypes(CloudApplication ca, string selectedValue, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            List<RequestTypeModel> retVal = repository.GetRequestTypes().Select(x => new RequestTypeModel(customSession)
            {
                RequestTypeID = x.RequestTypeID,
                RequestTypeName = x.RequestTypeName,
                Selected = false
            }).ToList();

            RequestTypeModel rtm = (RequestTypeModel)retVal.Where(x => x.RequestTypeName.ToUpper() == "FREE TRIAL").FirstOrDefault();
            if (ca.FreeTrialPeriod == null && rtm != null)
            {
                retVal.Remove(rtm);
            }

            if (selectedValue != null)
            {
                rtm = (RequestTypeModel)retVal.Where(x => x.RequestTypeName.ToUpper() == selectedValue.ToUpper()).FirstOrDefault();
                if (rtm != null)
                {
                    rtm.Selected = true;
                }
            }
            return retVal;
        }
        #endregion

        #region ConstructDocumentFileFormats
        public static SelectListItemCollection ConstructDocumentFileFormats(params string[] ignoreArgs)
        {
            string[,] fileFormats;
            if (ignoreArgs == null)
            {
                fileFormats = ModelHelpers.GetDocumentFileFormats();
            }
            else
            {
                fileFormats = ModelHelpers.GetDocumentFileFormats();
            }

            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            for (int i = 0; i <= fileFormats.GetUpperBound(0); i++)
            {
                if (ignoreArgs == null ? true : !ignoreArgs.Contains(fileFormats[i, 0]))
                {
                    retVal.SelectListItems.Add(new SelectListItem()
                    {
                        Text = fileFormats[i, 0],
                        Value = fileFormats[i, 1]
                    });
                }
            }

            retVal.MultiSelect = false;
            retVal.OtherIsNumeric = true;
            retVal.OtherNumeric = 1;
            //docTypes.SelectListItems = new List<SelectListItem>();
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "URL Link", Value = "HTML" });
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "PDF Document", Value = "PDF" });
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "Word Document", Value = "DOC" });
            //return docTypes;
            return retVal;
        }
        #endregion

        #region GetIndustries
        public static List<IndustryModel> GetIndustries(ICompareCloudwareRepository repository)
        {
            List<IndustryModel> retVal = repository.GetIndustries().Select(x => new IndustryModel()
            {
                code = x.Code,
                description = x.Description,
                IndustryID = x.IndustryID,
            }).ToList();

            return retVal;
        }
        #endregion

        #region ConstructDocumentTypes
        public static SelectListItemCollection ConstructDocumentTypes()
        {
            var documentTypes = ModelHelpers.GetDocumentTypes();
            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            for (int i = 0; i <= documentTypes.GetUpperBound(0); i++)
            {
                retVal.SelectListItems.Add(new SelectListItem() { Text = documentTypes[i, 0], Value = documentTypes[i, 1] });
            }

            retVal.MultiSelect = false;
            retVal.OtherIsNumeric = true;
            retVal.OtherNumeric = 1;
            return retVal;
        }
        #endregion

        #region RequerySearchResults
        [SessionExpireFilter]
        public static SearchPageModel RequerySearchResults(SearchPageModel model, int? oldCategory, int? newCategory, ICustomSession customSession, ICompareCloudwareRepository repository, ILogger Logger, ISiteAnalyticsLogger siteAnalyticsLogger, Controller controller)
        {
            #region via the filter button
            //must have come in via the filter button
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(customSession, repository);
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(repository);
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = GetSupportDays(repository);

            int? selectedSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = GetSupportHours(selectedSupportHours, newCategory, customSession, repository);

            int? selectedTimeZone = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = GetTimeZones(selectedTimeZone, newCategory,repository);
            //model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportDays = 0;
            //model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours = 0;

            //SearchModel newModel = new SearchModel();
            //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            //newModel.SearchFiltersModel.Categories = this.GetCategories();
            //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
            //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

            //newModel = this.GetSearchModel(newModel);

            if (oldCategory != newCategory)
            {
                //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                model = GetSearchModelFiltersOneColumn(model, true, true,customSession,repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, "UNLIMITED",repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, (int)newCategory, "UNLIMITED",repository);
                SetSearchResultsColumnHeaders((int)newCategory, model,repository);
            }
            else
            {
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, null,repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, (int)newCategory, "UNLIMITED",repository);
            }

            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = GetSearchResults(model,customSession, repository,Logger,siteAnalyticsLogger).ToList();
            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
                {
                    ApplicationCostOneOff = x.ApplicationCostOneOff,

                    ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                    ApplicationCostPerAnnumFrom = x.ApplicationCostPerAnnumFrom,
                    ApplicationCostPerAnnumTo = x.ApplicationCostPerAnnumTo,
                    ApplicationCostPerAnnumPOA = x.ApplicationCostPerAnnumPOA,
                    ApplicationCostPerAnnumOffered = x.ApplicationCostPerAnnumOffered,
                    ApplicationCostPerAnnumFree = x.ApplicationCostPerAnnumFree,
                    ApplicationCostPerAnnumIsForUnlimitedUsers = x.ApplicationCostPerAnnumIsForUnlimitedUsers,

                    ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                    ApplicationCostPerMonthFrom = x.ApplicationCostPerMonthFrom,
                    ApplicationCostPerMonthTo = x.ApplicationCostPerMonthTo,
                    ApplicationCostPerMonthPOA = x.ApplicationCostPerMonthPOA,
                    ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,
                    ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
                    ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                    ApplicationCostPerMonthIsForUnlimitedUsers = x.ApplicationCostPerMonthIsForUnlimitedUsers,

                    PayAsYouGo = x.PayAsYouGo,

                    CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                    CloudApplicationID = x.CloudApplicationID,
                    Description = x.Description,
                    FreeTrialPeriod = x.FreeTrialPeriod,
                    //IsLastInCollection = x.IsLastInCollection,
                    ResultDisplayFormat = x.ResultDisplayFormat,
                    SearchResultID = x.SearchResultID,
                    ServiceName = x.ServiceName,
                    SetupFee = x.SetupFee,
                    VendorID = x.VendorID,
                    VendorLogo = x.VendorLogo,
                    VendorLogoURL = x.VendorLogoURL,
                    VendorName = x.VendorName,
                    CloudApplicationCategoryTag = x.CloudApplicationCategoryTag,
                    CloudApplicationShopTag = x.CloudApplicationShopTag,
                    Currency = new CurrencyModel()
                    {
                        CurrencyID = x.Currency.CurrencyID,
                        CurrencyName = x.Currency.CurrencyName,
                        CurrencyShortName = x.Currency.CurrencyShortName,
                        CurrencySymbol = x.Currency.CurrencySymbol,
                        ExchangeRateSterling = x.Currency.ExchangeRateSterling,
                        UseExchangeRateForSorting = x.Currency.UseExchangeRateForSorting,
                    }
                }).ToList();


            #region crap
            //var results = this.SearchProducts(model3.SearchFiltersModel, null).ToList();
            ////var temp = results.Where(x => x.SetupFee == null).ToList();

            ////var results = _repository.GetSearchResults()
            //var results2 = results
            //    .Select(y => new SearchResultModel()
            //    {
            //        CloudApplicationID = y.CloudApplicationID,
            //        Description = y.Description,
            //        SearchResultID = y.CloudApplicationID,
            //        ServiceName = y.ServiceName,
            //        VendorLogoURL = y.Vendor.VendorLogoURL.AddImagePath(),
            //        VendorName = y.Vendor.VendorName,
            //        ApplicationCostOneOff = y.ApplicationCostOneOff,
            //        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
            //        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
            //        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
            //        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
            //        FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
            //        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,

            //    }
            //);
            //model3.SearchResultsModel.SearchResults = results2.ToList();
            #endregion

            #endregion

            //return View(newModel);
            bool removed = controller.ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");

            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersBrowsers");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersFeatures");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersLanguages");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersOperatingSystems");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportDays");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportHours");
            //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportTypes");
            controller.ModelState.Clear();
            model.CustomSession = customSession;

            SetSearchResultsSortOrder(null, null, model);
            PaginateSearchResults(model, 1);
            FixUpViewData(model,controller);
            return model;
        }
        #endregion

        #region GetSupportDays
        public static List<SearchFilterModelOneColumn> GetSupportDays(ICompareCloudwareRepository repository)
        {
            List<SearchFilterModelOneColumn> retVal = repository.GetSupportDays().Select(x => new SearchFilterModelOneColumn()
            {
                SearchFilterID = x.SupportDaysID,
                Col1SearchFilterName = x.SupportDaysName,
            }).ToList();

            return retVal;
        }
        #endregion

        #region GetSupportHours
        public static List<SearchFilterModelOneColumn> GetSupportHours(int? selectedSupportHours, int? categoryID, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            List<SearchFilterModelOneColumn> retVal = null;
            if (categoryID == null)
            {
                retVal = repository.GetSupportHours().Select(x => new SearchFilterModelOneColumn(customSession, true)
                {
                    SearchFilterID = x.SupportHoursID,
                    Col1SearchFilterName = x.SupportHoursName,
                    Col1ValueFrom = x.SupportHoursFrom.ToString(),
                    Col1ValueTo = x.SupportHoursTo.ToString(),
                    Col1Selected = x.SupportHoursID == selectedSupportHours
                }).ToList();
            }
            else
            {
                retVal = repository.GetSupportHours((int)categoryID).Select(x => new SearchFilterModelOneColumn(customSession, true)
                {
                    SearchFilterID = x.SupportHoursID,
                    Col1SearchFilterName = x.SupportHoursName,
                    Col1ValueFrom = x.SupportHoursFrom.ToString(),
                    Col1ValueTo = x.SupportHoursTo.ToString(),
                    Col1Selected = x.SupportHoursID == selectedSupportHours
                }).ToList();
            }


            return retVal;
        }
        #endregion

        #region GetTimeZones
        public static List<SearchFilterModelOneColumn> GetTimeZones(int? selectedTimeZone, int? categoryID, ICompareCloudwareRepository repository)
        {
            List<SearchFilterModelOneColumn> retVal = null;
            if (categoryID == null)
            {
                retVal = repository.GetTimeZones().Select(x => new SearchFilterModelOneColumn()
                {
                    SearchFilterID = x.TimeZoneID,
                    Col1SearchFilterName = x.TimeZoneName,
                    Col1Selected = x.TimeZoneID == selectedTimeZone,

                }).ToList();
            }
            else
            {
                retVal = repository.GetTimeZones((int)categoryID).Select(x => new SearchFilterModelOneColumn()
                {
                    SearchFilterID = x.TimeZoneID,
                    Col1SearchFilterName = x.TimeZoneName,
                    Col1Selected = x.TimeZoneID == selectedTimeZone,

                }).ToList();
            }
            return retVal;
        }
        #endregion

        #region SetComboOptionsFromApplicationFeature
        public static IEnumerable<SearchFilterModelOneColumn> SetComboOptionsFromApplicationFeature(IEnumerable<SearchFilterModelOneColumn> options, int category, string selectedValue, ICompareCloudwareRepository repository)
        {
            if (options != null)
            {
                foreach (SearchFilterModelOneColumn sfmoc in options)
                {
                    if (sfmoc.IsValueBased)
                    {
                        List<GenericValueModel> values = GetComboOptionsFromApplicationFeature(sfmoc.Col1SearchFilterType, sfmoc.Col1SearchFilterName, category,repository);
                        sfmoc.Col1Values = values;
                        if (selectedValue != null)
                        {
                            sfmoc.Col1Value = selectedValue;
                        }
                    }
                }
            }
            return options;
        }
        #endregion

        #region GetComboOptionsFromApplicationFeature
        public static List<GenericValueModel> GetComboOptionsFromApplicationFeature(string searchFilterType, string featureName, int categoryID, ICompareCloudwareRepository repository)
        {
            List<GenericValueModel> retVal = null;
            if (searchFilterType == FILTER_FEATURES)
            {
                retVal = repository.GetValuesForFeature(typeof(CloudApplicationFeature), featureName, categoryID).Select(x => new GenericValueModel()
                {
                    ModelValue = x.ValueAsString,
                    DisplayValue = x.ValueAsString,
                    OutputDisplayType = x.OutputDisplayType,
                    ValueSuffix = x.ValueSuffix,
                    OutputDisplayDescriptor = x.OutputDisplayDescriptor,
                }).ToList();
            }
            if (searchFilterType == FILTER_APPLICATIONFEATURES)
            {
                retVal = repository.GetValuesForFeature(typeof(CloudApplicationApplication), featureName, categoryID).Select(x => new GenericValueModel()
                {
                    ModelValue = x.ValueAsString,
                    DisplayValue = x.ValueAsString,
                    OutputDisplayType = x.OutputDisplayType,
                    ValueSuffix = x.ValueSuffix,
                    OutputDisplayDescriptor = x.OutputDisplayDescriptor,
                }).ToList();
            }
            if (retVal != null)
            {
                retVal.ForEach(x => ModelHelpers.FormatDisplayValue(x));
            }
            return retVal;
        }
        #endregion

        #region GetSearchModelFiltersOneColumn
        public static SearchPageModel GetSearchModelFiltersOneColumn(SearchPageModel model, bool featuresOnly, bool clearExistingFilters, ICustomSession customSession, ICompareCloudwareRepository repository)
        {

            var allFiltersAsOneColumn = repository.GetFiltersOneColumn((int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, (int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers);
            //get all the search filters which need to be rendered as one column
            var justFeaturesFilters =
                //_repository.GetSearchOptions(3)
                allFiltersAsOneColumn
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn(customSession)
                {
                    //Category = x.CategoryCol1 != null ? x.CategoryCol1 : null,
                    Category = x.CategoryCol1 != null ? new CategoryModel()
                    {
                        CategoryID = x.CategoryCol1.CategoryID,
                        CategoryName = x.CategoryCol1.CategoryName,
                    }
                    : null,
                    SearchFilterID = x.SearchFilterID,
                    Col1SearchFilterName = x.SearchFilterNameCol1,
                    Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                    Col1Selected = false,
                    IsValueBased = x.IsDataDrivenCol1,

                    Col1Value = x.DataDrivenFieldCol1,
                    IsDataFloorDriven = x.IsDataFloorDrivenCol1,
                    IsDataCeilingDriven = x.IsDataCeilingDrivenCol1,

                    CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven,
                }
                );

            var justApplicationFeaturesFilters =
                //_repository.GetSearchOptions(3)
    allFiltersAsOneColumn
    .Where(x => x.SearchFilterTypeNameCol1 == FILTER_APPLICATIONFEATURES)
    .Select(x => new SearchFilterModelOneColumn(customSession)
    {
        //Category = x.CategoryCol1 != null ? x.CategoryCol1 : null,
        Category = x.CategoryCol1 != null ? new CategoryModel()
        {
            CategoryID = x.CategoryCol1.CategoryID,
            CategoryName = x.CategoryCol1.CategoryName,
        }
        : null,
        SearchFilterID = x.SearchFilterID,
        SearchFilterParentID = (x.SearchFilterParentID == 0 ? x.SearchFilterID : x.SearchFilterParentID),
        Col1SearchFilterName = x.SearchFilterNameCol1,
        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
        Col1Selected = false,
        IsValueBased = x.IsDataDrivenCol1,
        Col1Value = x.DataDrivenFieldCol1,
        IsDataFloorDriven = x.IsDataFloorDrivenCol1,
        IsDataCeilingDriven = x.IsDataCeilingDrivenCol1,
        SuppressFilterBehaviour = x.SuppressFilterBehaviour,
        CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven,
    }
    );

            var searchModel = new SearchPageModel(customSession);
            if (featuresOnly)
            {
                //simply replace the other filters with the original model filters, clear out the existing selected value if necessary
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ClearValues().OrderBy(x => x.Col1SearchFilterName) : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.OrderBy(x => x.Col1SearchFilterName);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ClearValues().OrderBy(x => x.Col1SearchFilterName) : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.OrderBy(x => x.Col1SearchFilterName);
                //searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ClearValues().OrderBy(x => x.Col1SearchFilterName) : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.OrderBy(x => x.Col1SearchFilterName);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ClearValues().OrderBy(x => x.Col1SearchFilterName) : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.OrderBy(x => x.Col1SearchFilterName);

                if (searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices != null)
                {
                    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices =
                        clearExistingFilters
                        ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ClearValues().OrderBy(x => x.Col1SearchFilterName)
                        : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.OrderBy(x => x.Col1SearchFilterName);
                }

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays =
                    clearExistingFilters
                    ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ClearValues().OrderBy(x => x.SearchFilterID).ToList()
                    : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.OrderBy(x => x.SearchFilterID).ToList();

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours =
                    clearExistingFilters
                    ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ClearValues().OrderBy(x => x.SearchFilterID).ToList()
                    : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.OrderBy(x => x.SearchFilterID).ToList();

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes =
                    clearExistingFilters
                    ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ClearValues().OrderBy(x => x.Col1SearchFilterName)
                    : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.OrderBy(x => x.Col1SearchFilterName);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones =
                    clearExistingFilters
                    ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones.ClearValues().OrderBy(x => x.Col1SearchFilterName).ToList()
                    : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones.OrderBy(x => x.Col1SearchFilterName).ToList();

            }
            else
            {
                //get all the search filters which need to be rendered as two column
                var filtersExcludingFeatures =
                    //_repository.GetSearchOptions(3)
                    allFiltersAsOneColumn
                    .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                    .Where(x => x.SearchFilterTypeNameCol1 != FILTER_APPLICATIONFEATURES)
                    .Select(x => new SearchFilterModelOneColumn(customSession)
                    {
                        //Category = x.Category != null ? x.Category : null,
                        SearchFilterID = x.SearchFilterID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                        //Col2SearchFilterName = x.SearchFilterNameCol2,
                        //Col2SearchFilterType = x.SearchFilterTypeNameCol2,
                        //Col2Selected = false
                    }
                    );
                //model3.SearchFiltersModel.SearchFilters = features;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS).ToList().OrderBy(x => x.Col1SearchFilterName);
                //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES).ToList().OrderBy(x => x.Col1SearchFilterName);
                //searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS).ToList().OrderBy(x => x.Col1SearchFilterName);
                //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList().OrderBy(x => x.Col1SearchFilterName);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_DEVICES).ToList().OrderBy(x => x.Col1SearchFilterName);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS).OrderBy(x => x.SearchFilterID).ToList();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS).OrderBy(x => x.SearchFilterID).ToList();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES).ToList().OrderBy(x => x.Col1SearchFilterName);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_TIMEZONES).OrderBy(x => x.Col1SearchFilterName).ToList();
            }

            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
            //searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = justFeaturesFilters.Where(x => x.Col1SearchFilterType == FILTER_FEATURES).ToList().OrderByDescending(x => x.IsValueBased).ThenBy(x => x.Col1SearchFilterName);
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures =
                justApplicationFeaturesFilters.Where(x => x.Col1SearchFilterType == FILTER_APPLICATIONFEATURES)
                .ToList()
                //.OrderByDescending(x => x.IsValueBased).ThenBy(x => x.Col1SearchFilterName)
                .OrderBy(x => x.SearchFilterID).ThenBy(x => x.SearchFilterParentID)
                ;

            searchModel.ContainerModel.SearchFiltersModel.DisplayAsSummary = model.ContainerModel.SearchFiltersModel.DisplayAsSummary;
            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;

            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersApplicationFeaturesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersApplicationFeaturesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = model.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed;

            return searchModel;

        }
        #endregion

        #region SetSearchResultsColumnHeaders
        public static void SetSearchResultsColumnHeaders(int categoryID, SearchPageModel model, ICompareCloudwareRepository repository)
        {
            CategoryParameters cp = repository.GetCategoryParameters(categoryID);
            model.AnnualPriceColumnHeader = cp.SearchResultsAnnualPriceColumnHeader;
            model.MonthlyPriceColumnHeader = cp.SearchResultsMonthlyPriceColumnHeader;
            model.CloudwareProviderColumnHeader = cp.SearchResultsCloudwareProviderColumnHeader;
            model.SetupFeeColumnHeader = cp.SearchResultsSetupFeeColumnHeader;
            model.FreeTrialColumnHeader = cp.SearchResultsFreeTrialColumnHeader;
        }

        public static void SetSearchResultsColumnHeaders(int categoryID, CloudApplicationSearchResultModel model, ICompareCloudwareRepository repository)
        {
            CategoryParameters cp = repository.GetCategoryParameters(categoryID);
            model.AnnualPriceColumnHeader = cp.SearchResultAnnualPriceColumnHeader;
            model.MonthlyPriceColumnHeader = cp.SearchResultMonthlyPriceColumnHeader;
            model.CloudwareProviderColumnHeader = cp.SearchResultCloudwareProviderColumnHeader;
            model.SetupFeeColumnHeader = cp.SearchResultSetupFeeColumnHeader;
            model.FreeTrialColumnHeader = cp.SearchResultFreeTrialColumnHeader;
        }
        #endregion

        #region GetSearchResults
        public static List<SearchResultModelOneColumn> GetSearchResults(SearchPageModel searchModel, ICustomSession customSession, ICompareCloudwareRepository repository, ILogger Logger, ISiteAnalyticsLogger siteAnalyticsLogger)
        //private IEnumerable<SearchResultModelOneColumn> GetSearchResults(SearchPageModel searchModel)
        {
            Logger.Debug("GetSearchResults#1 - " + DateTime.Now.TimeOfDay.ToString());
            bool liveApplicationsOnly = ModelHelpers.LiveApplicationsOnly(customSession);
            var searchResults = SearchProducts(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn, customSession, repository, siteAnalyticsLogger, null).ToList();
            Logger.Debug("GetSearchResults#2 - " + DateTime.Now.TimeOfDay.ToString());
            int i = 0;
            string imagePath = ConfigurationManager.AppSettings["LogosFolder"].ToString();

            bool useExchangeRateForSorting = Convert.ToBoolean(ConfigurationManager.AppSettings["UseExchangeRatesForSorting"]);












            var searchResultsForModel = searchResults
    .Select(y => new SearchResultModelOneColumn(customSession)
    {
        CloudApplicationID = y.CloudApplicationID,
        Description = y.Description,
        SearchResultID = i++,
        ServiceName = y.ServiceName,
        VendorLogoURL = imagePath + y.Vendor.VendorLogoFileName,
        VendorName = y.Vendor.VendorName,
        ApplicationCostOneOff = y.ApplicationCostOneOff,
        ApplicationCostPerAnnum = (y.ApplicationCostPerAnnum == 0 ? y.ApplicationCostPerAnnumFrom : y.ApplicationCostPerAnnum),
        ApplicationCostPerAnnumFrom = y.ApplicationCostPerAnnumFrom,
        ApplicationCostPerAnnumTo = y.ApplicationCostPerAnnumTo,
        ApplicationCostPerAnnumPOA = y.ApplicationCostPerAnnumPOA,
        ApplicationCostPerAnnumOffered = y.ApplicationCostPerAnnumOffered,
        ApplicationCostPerAnnumFree = y.ApplicationCostPerAnnumFree,
        ApplicationCostPerAnnumIsForUnlimitedUsers = y.ApplicationCostPerAnnumIsForUnlimitedUsers ?? false,
        ApplicationCostPerMonth = (y.ApplicationCostPerMonth == 0 ? y.ApplicationCostPerMonthFrom : y.ApplicationCostPerMonth),
        ApplicationCostPerMonthFrom = y.ApplicationCostPerMonthFrom,
        ApplicationCostPerMonthTo = y.ApplicationCostPerMonthTo,
        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthSuffix,
        ApplicationCostPerMonthPOA = y.ApplicationCostPerMonthPOA,
        ApplicationCostPerMonthOffered = y.ApplicationCostPerMonthOffered,
        ApplicationCostPerMonthFree = y.ApplicationCostPerMonthFree,
        ApplicationCostPerMonthIsForUnlimitedUsers = y.ApplicationCostPerMonthIsForUnlimitedUsers ?? false,
        PayAsYouGo = y.PayAsYouGo,
        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
        FreeTrialPeriod = y.FreeTrialPeriod != null ? y.FreeTrialPeriod.FreeTrialPeriodName : null,
        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,
        ResultDisplayFormat = SearchResultDisplayFormat.Multiple,
        VendorID = y.Vendor.VendorID,

        OperatingSystems = y.OperatingSystems.Select(x => new OperatingSystemModelSearchResults()
        {
            OperatingSystemID = x.OperatingSystemID,
            OperatingSystemName = x.OperatingSystemName,
        }).ToList(),
        Devices = y.Devices.Select(x => new DeviceModel()
        {
            DeviceID = x.DeviceID,
            DeviceName = x.DeviceName,
        }).ToList(),
        SupportTypes = y.SupportTypes.Select(x => new SupportTypeModel()
        {
            SupportTypeID = x.SupportTypeID,
            SupportTypeName = x.SupportTypeName,
        }).ToList(),
        SupportDays = y.SupportDays != null ? new SupportDaysModel()
        {
            SupportDaysID = y.SupportDays.SupportDaysID,
            SupportDaysName = y.SupportDays.SupportDaysName,
        } : null,
        SupportHours = y.SupportHours != null ? new SupportHoursModel()
        {
            SupportHoursID = y.SupportHours.SupportHoursID,
            SupportHoursName = y.SupportHours.SupportHoursName,
        } : null,
        Languages = y.Languages.Select(x => new LanguageModel()
        {
            LanguageID = x.LanguageID,
            LanguageName = x.LanguageName,
        }).ToList(),
        CloudApplicationFeatures = y.CloudApplicationFeatures.Select(x => new CloudApplicationFeatureModel()
        {
            CloudApplicationFeatureID = x.CloudApplicationFeatureID,
            Cost = x.Cost,
            Count = x.Count,
            CountSuffix = x.CountSuffix,
            Feature = new FeatureModel()
            {
                FeatureColumnNumber = x.Feature.FeatureColumnNumber,
                FeatureID = x.Feature.FeatureID,
                FeatureName = x.Feature.FeatureName,
                FeatureRowNumber = x.Feature.FeatureRowNumber,
            },
            //Include = x.Include,
            //IncludeCount = x.IncludeCount,
            //IncludeCountSuffix = x.IncludeCountSuffix,
            //IncludeExtraCost = x.IncludeExtraCost,

        }).ToList(),
        SearchResultWeighting = y.SearchResultWeighting,
        Currency = new CurrencyModel()
        {
            CurrencyID = y.CloudApplicationCurrency.CurrencyID,
            CurrencyName = y.CloudApplicationCurrency.CurrencyName,
            CurrencyShortName = y.CloudApplicationCurrency.CurrencyShortName,
            CurrencySymbol = y.CloudApplicationCurrency.CurrencySymbol,
            ExchangeRateSterling = y.CloudApplicationCurrency.ExchangeRateSterling,
            UseExchangeRateForSorting = useExchangeRateForSorting,
        },
        DemoOffered = y.DemoOffered,

        CloudApplicationCategoryTag = y.CloudApplicationCategoryTag.TagName,
        CloudApplicationShopTag = y.CloudApplicationShopTag.TagName,

    }
)
                //.ToList()
;
            Logger.Debug("GetSearchResults#3 - " + DateTime.Now.TimeOfDay.ToString());
            return searchResultsForModel.ToList();
        }
        #endregion

        #region SetSearchResultsSortOrder
        public static void SetSearchResultsSortOrder(string sortColumn, string currentSortOrder, SearchPageModel model)
        {
            if (currentSortOrder != null)
            {
                if (currentSortOrder.Length == 0)
                {
                    currentSortOrder = null;
                }
            }
            string newSortColumn = sortColumn ?? (currentSortOrder != null ? currentSortOrder.Substring(0, currentSortOrder.IndexOf(" ")).Trim() : null) ?? "";
            currentSortOrder = ((sortColumn == null && currentSortOrder != null) ? newSortColumn + " " + (currentSortOrder.Substring(currentSortOrder.IndexOf(" ")).Trim() == "ASC" ? "DESC" : "ASC") : currentSortOrder);
            switch (newSortColumn.Trim().ToUpper())
            {
                case "":
                    //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                    //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.VendorName).ToList();
                    //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                    //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.VendorName).ToList();
                    //model.ContainerModel.SearchResultsModel.CurrentSortOrder = "VENDOR ASC";
                    break;
                case "VENDOR":
                    if (currentSortOrder == "VENDOR ASC")
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderByDescending(x => x.VendorName).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderByDescending(x => x.VendorName).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "VENDOR DESC";
                    }
                    else
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.VendorName).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.VendorName).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "VENDOR ASC";
                    }
                    break;
                case "MONTHLYPRICE":
                    if (currentSortOrder == "MONTHLYPRICE ASC")
                    {
                        PriceComparer priceComparer = new PriceComparer();
                        priceComparer.ComparisonMethod = ComparisonType.MonthlyDescending;
                        PriceComparerSummary priceComparerSummary = new PriceComparerSummary();
                        priceComparerSummary.ComparisonMethod = ComparisonType.MonthlyDescending;
                        List<SearchResultModelOneColumn> a = new List<SearchResultModelOneColumn>();
                        List<SearchResultSummaryModel> b = new List<SearchResultSummaryModel>();
                        //a.Add(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults[3]);
                        //a.Add(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults[0]);
                        //a.Sort(comparer);

                        a = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList();
                        a.Sort(priceComparer);
                        b = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList();
                        b.Sort(priceComparerSummary);

                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = a;
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = b;
                        //b = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList();
                        //b.Sort(comparer);
                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = b;


                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList().Sort(comparer);

                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderByDescending(x => x.ApplicationCostPerMonth).ToList();
                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderByDescending(x => x.ApplicationCostPerMonth).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "MONTHLYPRICE DESC";
                    }
                    else
                    {
                        PriceComparer priceComparer = new PriceComparer();
                        priceComparer.ComparisonMethod = ComparisonType.MonthlyAscending;
                        PriceComparerSummary priceComparerSummary = new PriceComparerSummary();
                        priceComparerSummary.ComparisonMethod = ComparisonType.MonthlyAscending;

                        List<SearchResultModelOneColumn> a = new List<SearchResultModelOneColumn>();
                        List<SearchResultSummaryModel> b = new List<SearchResultSummaryModel>();
                        //a.Add(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults[3]);
                        //a.Add(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults[0]);
                        //a.Sort(comparer);

                        a = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList();
                        a.Sort(priceComparer);
                        b = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList();
                        b.Sort(priceComparerSummary);

                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = a;
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = b;

                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList().Sort(comparer);

                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.ApplicationCostPerMonth).ToList();
                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.ApplicationCostPerMonth).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "MONTHLYPRICE ASC";
                    }
                    break;
                case "ANNUALPRICE":
                    if (currentSortOrder == "ANNUALPRICE ASC")
                    {
                        PriceComparer priceComparer = new PriceComparer();
                        priceComparer.ComparisonMethod = ComparisonType.AnnualDescending;
                        PriceComparerSummary priceComparerSummary = new PriceComparerSummary();
                        priceComparerSummary.ComparisonMethod = ComparisonType.AnnualDescending;
                        List<SearchResultModelOneColumn> a = new List<SearchResultModelOneColumn>();
                        List<SearchResultSummaryModel> b = new List<SearchResultSummaryModel>();

                        a = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList();
                        a.Sort(priceComparer);
                        b = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList();
                        b.Sort(priceComparerSummary);

                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = a;
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = b;

                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderByDescending(x => x.ApplicationCostPerAnnum).ToList();
                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderByDescending(x => x.ApplicationCostPerAnnum).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "ANNUALPRICE DESC";
                    }
                    else
                    {
                        PriceComparer priceComparer = new PriceComparer();
                        priceComparer.ComparisonMethod = ComparisonType.AnnualAscending;
                        PriceComparerSummary priceComparerSummary = new PriceComparerSummary();
                        priceComparerSummary.ComparisonMethod = ComparisonType.AnnualAscending;
                        List<SearchResultModelOneColumn> a = new List<SearchResultModelOneColumn>();
                        List<SearchResultSummaryModel> b = new List<SearchResultSummaryModel>();

                        a = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList();
                        a.Sort(priceComparer);
                        b = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList();
                        b.Sort(priceComparerSummary);

                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = a;
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = b;

                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.ApplicationCostPerAnnum).ToList();
                        //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                        //    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.ApplicationCostPerAnnum).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "ANNUALPRICE ASC";
                    }
                    break;
                case "SETUPFEE":
                    if (currentSortOrder == "SETUPFEE ASC")
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderByDescending(x => x.SetupFee).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderByDescending(x => x.SetupFee).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "SETUPFEE DESC";
                    }
                    else
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.SetupFee).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.SetupFee).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "SETUPFEE ASC";
                    }
                    break;
                case "FREETRIAL":
                    if (currentSortOrder == "FREETRIAL ASC")
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderByDescending(x => x.FreeTrialPeriod).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderByDescending(x => x.FreeTrialPeriod).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "FREETRIAL DESC";
                    }
                    else
                    {
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.OrderBy(x => x.FreeTrialPeriod).ToList();
                        model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.OrderBy(x => x.FreeTrialPeriod).ToList();
                        model.ContainerModel.SearchResultsModel.CurrentSortOrder = "FREETRIAL ASC";
                    }
                    break;
            }

        }
        #endregion

        #region SearchProducts
        //IQueryable<CompareCloudware.Domain.Models.CloudApplication> SearchProducts(SearchFiltersModelOneColumn model, params string[] keywords)
        public static IList<CompareCloudware.Domain.Models.CloudApplication> SearchProducts(SearchFiltersModelOneColumn model, ICustomSession customSession, ICompareCloudwareRepository repository, ISiteAnalyticsLogger siteAnalyticsLogger, params string[] keywords)
        {
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> allPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> categoryPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> browsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> featuresPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> operatingSystemsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> devicesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportTypesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportDaysPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportHoursPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> languagesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> mobilePlatformsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> numberOfUsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> applicationFeaturesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> timezonesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> cloudApplicationsPredicate;
            bool anyFilterSelected = false;
            if (

                model.SearchFiltersBrowsers.All(x => x.Col1Selected == false) &
                //model.SearchFiltersFeatures.FeatureFilters.All(x => x.Selected == false) &
                model.SearchFiltersFeatures.All(x => x.Col1Selected == false) &
                !model.SearchFiltersFeatures.Any(x => (x.Col1Value != null && x.Col1Value != "UNLIMITED")) &
                model.SearchFiltersLanguages.All(x => x.Col1Selected == false) &
                //model.SearchFiltersMobilePlatforms.All(x => x.Col1Selected == false) &
                model.SearchFiltersOperatingSystems.All(x => x.Col1Selected == false) &
                (model.SearchFiltersDevices == null ? true : model.SearchFiltersDevices.All(x => x.Col1Selected == false)) &
                //model.SearchFiltersSupportDays.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportHours.Where(s => s.Col1SearchFilterName != "ALL").All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportTypes.All(x => x.Col1Selected == false) &
                (model.SearchFiltersApplicationFeatures == null ? true : model.SearchFiltersApplicationFeatures.All(x => x.Col1Selected == false)) &
                (model.SearchFiltersApplicationFeatures == null ? true : !model.SearchFiltersApplicationFeatures.Any(x => (x.Col1Value != null && x.Col1Value != "UNLIMITED"))) &
                model.SearchFiltersTimeZones.Where(s => s.Col1SearchFilterName != "ALL").All(x => x.Col1Selected == false)
                )
            {
                //not a single search filter has been selected
                allPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                browsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                devicesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                timezonesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            }
            else
            {
                anyFilterSelected = true;
                //one of the filters has been selected
                allPredicate = LinqKit.PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                if (model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("BROWSERS")))
                {
                    browsersPredicate = PredicateBuilder.False<CompareCloudware.Domain.Models.CloudApplication>();
                }
                else
                {
                    browsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }

                //if (model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).Any(x => x.SearchFilterType.StartsWith("FEATURES")))
                if (model.SearchFiltersFeatures.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
                //if (model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
                {
                    featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }
                else
                {
                    featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }

                if (model.SearchFiltersApplicationFeatures != null)
                {
                    if (model.SearchFiltersApplicationFeatures.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("APPLICATIONFEATURES")))
                    //if (model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
                    {
                        applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                    }
                    else
                    {
                        applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                    }
                }
                else
                {
                    applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }

                operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                devicesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                timezonesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            }

            cloudApplicationsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();

            //foreach (string keyword in keywords)
            //{
            //    string temp = keyword;
            //    predicate = predicate.Or(p => p.Description.Contains(temp));
            //}

            //foreach (SearchFilterModel checkedentry in model.SearchFilters)
            //{
            //    if (checkedentry.Selected)
            //    {
            //        predicate = predicate.Or(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName == checkedentry.SearchFilterName));
            //    }
            //}

            //Dictionary<string, Action<SearchFilterModel>> actions =
            //         new Dictionary<string, Action<SearchFilterModel>>();

            //actions.Add("FEATURES", DoThis);
            //actions.Add("OPERATINGSYSTEMS", DoThat);
            //actions.Add("BROWSERS", DoSomethingElse);

            //Action<SearchFilterModel,string> action = null;
            //model.SearchFilters.ToList().ForEach(x => action(x,x.SearchFilterName));
            //model.SearchFilters.ForEachMatch(s => s.SearchFilterType.StartsWith("a"), s => Console.WriteLine(s));

            if (model.ChosenCategoryID != null)
            {
                InsertCategoryFilterClause(model.ChosenCategoryID, ref categoryPredicate);
                InsertNumberOfUsersFilterClause(model.ChosenNumberOfUsers, (int)model.ChosenCategoryID, ref categoryPredicate);
            }

            model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("BROWSERS"), x => InsertBrowserFilterClause(x, ref browsersPredicate));

            //model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).ForEachMatch(x => x.SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));

            //model.SearchFiltersFeatures.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));

            //model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref applicationFeaturesPredicate));
            model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureFilterClause(x, ref applicationFeaturesPredicate));


            //model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));
            model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureFilterClause(x, ref featuresPredicate));
            //model.SearchFiltersFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureLimitClause(x, ref featuresPredicate));
            model.SearchFiltersFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureLimitClause(x, ref featuresPredicate));

            if (model.SearchFiltersApplicationFeatures != null)
            {
                //model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("APPLICATIONFEATURES"), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
                //model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("APPLICATIONFEATURES"), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
                //model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("APPLICATIONFEATURES"), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
                model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
                model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
                model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
            }

            //model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("OPERATINGSYSTEMS"), x => InsertOperatingSystemFilterClause(x, ref operatingSystemsPredicate));
            model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_OPERATINGSYSTEMS), x => InsertOperatingSystemFilterClause(x, ref operatingSystemsPredicate));
            if (model.SearchFiltersDevices != null)
            {
                //model.SearchFiltersDevices.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("DEVICES"), x => InsertDeviceFilterClause(x, ref devicesPredicate));
                model.SearchFiltersDevices.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_DEVICES), x => InsertDeviceFilterClause(x, ref devicesPredicate));
            }
            //model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTTYPES"), x => InsertSupportTypeFilterClause(x, ref supportHoursPredicate));
            model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_SUPPORTTYPES), x => InsertSupportTypeFilterClause(x, ref supportHoursPredicate));
            //model.SearchFiltersSupportDays.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTDAYS"), x => InsertSupportDaysFilterClause(x, ref supportDaysPredicate));

            bool includeSupportInSearchFilter = HaveAnyActiveSupportTypesBeenSelected(model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true),repository);

            if (IsChosenSupportDaysAPredicate(model.ChosenSupportDays,repository) && includeSupportInSearchFilter)
            {
                InsertSupportDaysFilterClause(model.ChosenSupportDays, ref supportDaysPredicate);
            }
            //model.SearchFiltersSupportHours.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTHOURS"), x => InsertSupportHoursFilterClause(x, ref supportHoursPredicate));
            if (IsChosenSupportHoursAPredicate(model.ChosenSupportHours,repository) && includeSupportInSearchFilter)
            {
                InsertSupportHoursFilterClause(model.ChosenSupportHours, ref supportHoursPredicate,repository);
            }
            //model.SearchFiltersLanguages.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("LANGUAGES"), x => InsertLanguageFilterClause(x, ref languagesPredicate));
            model.SearchFiltersLanguages.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_LANGUAGES), x => InsertLanguageFilterClause(x, ref languagesPredicate));
            //model.SearchFiltersMobilePlatforms.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("MOBILEPLATFORMS"), x => InsertMobilePlatformFilterClause(x, ref mobilePlatformsPredicate));
            if (IsChosenTimeZoneAPredicate(model.ChosenTimeZone,repository) && includeSupportInSearchFilter)
            {
                InsertTimeZoneFilterClause(model.ChosenTimeZone, ref timezonesPredicate);
            }

            bool liveApplicationsOnly = ModelHelpers.LiveApplicationsOnly(customSession);
            if (liveApplicationsOnly)
            {
                InsertStatusFilterClause(ref cloudApplicationsPredicate);
            }

            allPredicate = allPredicate.And(categoryPredicate.Expand());
            allPredicate = allPredicate.And(numberOfUsersPredicate.Expand());

            allPredicate = allPredicate.And(browsersPredicate.Expand());

            allPredicate = allPredicate.And(featuresPredicate.Expand());
            allPredicate = allPredicate.And(applicationFeaturesPredicate.Expand());
            allPredicate = allPredicate.And(operatingSystemsPredicate.Expand());
            allPredicate = allPredicate.And(devicesPredicate.Expand());
            allPredicate = allPredicate.And(supportTypesPredicate.Expand());
            allPredicate = allPredicate.And(supportDaysPredicate.Expand());
            allPredicate = allPredicate.And(supportHoursPredicate.Expand());
            allPredicate = allPredicate.And(languagesPredicate.Expand());
            //allPredicate = allPredicate.And(mobilePlatformsPredicate.Expand());
            allPredicate = allPredicate.And(timezonesPredicate.Expand());
            allPredicate = allPredicate.And(cloudApplicationsPredicate.Expand());

            var retVal = repository.GetSearchResults(allPredicate, liveApplicationsOnly);

            //var test = retVal.Where(x => x.Vendor.VendorName.ToUpper() == "RINGCENTRAL");
            //var retVal = _repository.GetSearchResults(allPredicate.And(browsersPredicate).And(featuresPredicate));
            //return retVal.AsQueryable();


            if (anyFilterSelected)
            {
                //SITE ANALYTIC CHOSEN CATEGORY
                //_siteAnalyticsLogger.Log(_repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, CustomSession.PersonID, _repository.FindFeatureTypeByName(FILTER_CATEGORIES).FeatureTypeID, (int)model.ChosenCategoryID);
                //SITE ANALYTIC CHOSEN NUMBER OF USERS
                //_siteAnalyticsLogger.Log(_repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, CustomSession.PersonID, _repository.FindFeatureTypeByName(FILTER_USERS).FeatureTypeID);
                //SITE ANALYTIC CHOSEN OPERATING SYSTEMS
                model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true)
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_OPERATINGSYSTEMS),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_OPERATINGSYSTEMS).FeatureTypeID, x.SearchFilterID));
                //SITE ANALYTIC CHOSEN BROWSERS
                model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true)
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_BROWSERS),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_BROWSERS).FeatureTypeID, x.SearchFilterID));

                //SITE ANALYTIC CHOSEN FEATURES
                //STANDARD CHECKBOX NO VALUE
                model.SearchFiltersFeatures.Where(x => x.Col1Selected == true)
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_FEATURES).FeatureTypeID, x.SearchFilterID));
                //CHECKBOX AND VALUE
                model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven))
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_FEATURES).FeatureTypeID, x.SearchFilterID));
                //VALUE NO CHECKBOX
                //model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureFilterClause(x, ref featuresPredicate));
                model.SearchFiltersFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true))
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_FEATURES).FeatureTypeID, x.SearchFilterID));


                //SITE ANALYTIC CHOSEN APPLICATION FEATURES
                if (model.SearchFiltersApplicationFeatures != null)
                {
                    //STANDARD CHECKBOX NO VALUE
                    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased))
                        .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES),
                        x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_APPLICATIONFEATURES).FeatureTypeID, x.SearchFilterID));
                    //CHECKBOX AND VALUE
                    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven))
                        .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES),
                        x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_APPLICATIONFEATURES).FeatureTypeID, x.SearchFilterID));
                    //VALUE NO CHECKBOX
                    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true))
                        .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES),
                        x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_APPLICATIONFEATURES).FeatureTypeID, x.SearchFilterID));
                }





                //SITE ANALYTIC CHOSEN SUPPORT TYPES
                model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true)
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_SUPPORTTYPES),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_SUPPORTTYPES).FeatureTypeID, x.SearchFilterID));
                //SITE ANALYTIC CHOSEN SUPPORT DAYS
                if (IsChosenSupportDaysAPredicate(model.ChosenSupportDays,repository) && includeSupportInSearchFilter)
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_SUPPORTDAYS).FeatureTypeID, (int)model.ChosenSupportDays);
                }
                //SITE ANALYTIC CHOSEN SUPPORT HOURS
                if (IsChosenSupportHoursAPredicate(model.ChosenSupportHours,repository) && includeSupportInSearchFilter)
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_SUPPORTHOURS).FeatureTypeID, (int)model.ChosenSupportHours);
                }
                //SITE ANALYTIC CHOSEN TIMEZONE
                if (IsChosenTimeZoneAPredicate(model.ChosenTimeZone,repository) && includeSupportInSearchFilter)
                {
                    siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_TIMEZONES).FeatureTypeID, (int)model.ChosenTimeZone);
                }
                //SITE ANALYTIC CHOSEN LANGUAGES
                model.SearchFiltersLanguages.Where(x => x.Col1Selected == true)
                    .ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_LANGUAGES),
                    x => siteAnalyticsLogger.Log(repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, customSession.PersonID, repository.FindFeatureTypeByName(FILTER_LANGUAGES).FeatureTypeID, x.SearchFilterID));

                //_siteAnalyticsLogger.Log(_repository, ActionType.ClickFilter, null, (int)model.ChosenCategoryID, CustomSession.PersonID, _repository.FindFeatureTypeByName(FILTER_OPERATINGSYSTEMS).FeatureTypeID);
                //_siteAnalyticsLogger.Log(_repository, ActionType.ClickFilter, null, categoryID, CustomSession.PersonID, _repository.FindFeatureTypeByName("SupportHours").FeatureTypeID);
                //model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("BROWSERS"), x => LogSearchFilterModelSiteAnalytic(model.ChosenCategoryID, x.Col1SearchFilterType, x.SearchFilterID));
            }




            return retVal;
            //return dataContext.Products.Where(predicate);
        }
        #endregion

        #region SearchProductsCount
        //IQueryable<CompareCloudware.Domain.Models.CloudApplication> SearchProducts(SearchFiltersModelOneColumn model, params string[] keywords)
        public static int SearchProductsCount(SearchFiltersModelOneColumn model, ICustomSession customSession, ICompareCloudwareRepository repository, ISiteAnalyticsLogger siteAnalyticsLogger, params string[] keywords)
        {
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> allPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> categoryPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> browsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> featuresPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> operatingSystemsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> devicesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportTypesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportDaysPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportHoursPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> languagesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> mobilePlatformsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> numberOfUsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> applicationFeaturesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> timezonesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> cloudApplicationsPredicate;
            bool anyFilterSelected = false;
            //if (

            //    model.SearchFiltersBrowsers.All(x => x.Col1Selected == false) &
            //    //model.SearchFiltersFeatures.FeatureFilters.All(x => x.Selected == false) &
            //    model.SearchFiltersFeatures.All(x => x.Col1Selected == false) &
            //    !model.SearchFiltersFeatures.Any(x => (x.Col1Value != null && x.Col1Value != "UNLIMITED")) &
            //    model.SearchFiltersLanguages.All(x => x.Col1Selected == false) &
            //    //model.SearchFiltersMobilePlatforms.All(x => x.Col1Selected == false) &
            //    model.SearchFiltersOperatingSystems.All(x => x.Col1Selected == false) &
            //    (model.SearchFiltersDevices == null ? true : model.SearchFiltersDevices.All(x => x.Col1Selected == false)) &
            //    //model.SearchFiltersSupportDays.All(x => x.Col1Selected == false) &
            //    model.SearchFiltersSupportHours.Where(s => s.Col1SearchFilterName != "ALL").All(x => x.Col1Selected == false) &
            //    model.SearchFiltersSupportTypes.All(x => x.Col1Selected == false) &
            //    (model.SearchFiltersApplicationFeatures == null ? true : model.SearchFiltersApplicationFeatures.All(x => x.Col1Selected == false)) &
            //    (model.SearchFiltersApplicationFeatures == null ? true : !model.SearchFiltersApplicationFeatures.Any(x => (x.Col1Value != null && x.Col1Value != "UNLIMITED"))) &
            //    model.SearchFiltersTimeZones.Where(s => s.Col1SearchFilterName != "ALL").All(x => x.Col1Selected == false)
            //    )
            //{
                //not a single search filter has been selected
                allPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                browsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                devicesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                timezonesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //}
            //else
            //{
            //    anyFilterSelected = true;
            //    //one of the filters has been selected
            //    allPredicate = LinqKit.PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    categoryPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    if (model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("BROWSERS")))
            //    {
            //        browsersPredicate = PredicateBuilder.False<CompareCloudware.Domain.Models.CloudApplication>();
            //    }
            //    else
            //    {
            //        browsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    }

            //    //if (model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).Any(x => x.SearchFilterType.StartsWith("FEATURES")))
            //    if (model.SearchFiltersFeatures.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
            //    //if (model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
            //    {
            //        featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    }
            //    else
            //    {
            //        featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    }

            //    if (model.SearchFiltersApplicationFeatures != null)
            //    {
            //        if (model.SearchFiltersApplicationFeatures.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("APPLICATIONFEATURES")))
            //        //if (model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).Any(x => x.Col1SearchFilterType.StartsWith("FEATURES")))
            //        {
            //            applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //        }
            //        else
            //        {
            //            applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //        }
            //    }
            //    else
            //    {
            //        applicationFeaturesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    }

            //    operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    devicesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //    timezonesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            //}

            cloudApplicationsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();


            InsertCategoryFilterClause(model.ChosenCategoryID, ref categoryPredicate);
            InsertNumberOfUsersFilterClause(model.ChosenNumberOfUsers, (int)model.ChosenCategoryID, ref categoryPredicate);

            //model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("BROWSERS"), x => InsertBrowserFilterClause(x, ref browsersPredicate));

            //model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureFilterClause(x, ref applicationFeaturesPredicate));
            //model.SearchFiltersFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureFilterClause(x, ref featuresPredicate));
            //model.SearchFiltersFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_FEATURES), x => InsertFeatureLimitClause(x, ref featuresPredicate));

            //if (model.SearchFiltersApplicationFeatures != null)
            //{
            //    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && x.CanBeBooleanAndDataDriven)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
            //    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Selected == true && !x.IsValueBased)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
            //    model.SearchFiltersApplicationFeatures.Where(x => (x.Col1Value != "UNLIMITED" && x.IsValueBased == true)).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_APPLICATIONFEATURES), x => InsertApplicationFeatureFilterClause(x, ref applicationFeaturesPredicate));
            //}

            //model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_OPERATINGSYSTEMS), x => InsertOperatingSystemFilterClause(x, ref operatingSystemsPredicate));
            //if (model.SearchFiltersDevices != null)
            //{
            //    model.SearchFiltersDevices.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_DEVICES), x => InsertDeviceFilterClause(x, ref devicesPredicate));
            //}
            //model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_SUPPORTTYPES), x => InsertSupportTypeFilterClause(x, ref supportHoursPredicate));

            //bool includeSupportInSearchFilter = HaveAnyActiveSupportTypesBeenSelected(model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true), repository);

            //if (IsChosenSupportDaysAPredicate(model.ChosenSupportDays, repository) && includeSupportInSearchFilter)
            //{
            //    InsertSupportDaysFilterClause(model.ChosenSupportDays, ref supportDaysPredicate);
            //}
            //if (IsChosenSupportHoursAPredicate(model.ChosenSupportHours, repository) && includeSupportInSearchFilter)
            //{
            //    InsertSupportHoursFilterClause(model.ChosenSupportHours, ref supportHoursPredicate, repository);
            //}
            //model.SearchFiltersLanguages.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith(FILTER_LANGUAGES), x => InsertLanguageFilterClause(x, ref languagesPredicate));
            //if (IsChosenTimeZoneAPredicate(model.ChosenTimeZone, repository) && includeSupportInSearchFilter)
            //{
            //    InsertTimeZoneFilterClause(model.ChosenTimeZone, ref timezonesPredicate);
            //}

            bool liveApplicationsOnly = ModelHelpers.LiveApplicationsOnly(customSession);
            if (liveApplicationsOnly)
            {
                InsertStatusFilterClause(ref cloudApplicationsPredicate);
            }

            allPredicate = allPredicate.And(categoryPredicate.Expand());
            allPredicate = allPredicate.And(numberOfUsersPredicate.Expand());

            allPredicate = allPredicate.And(browsersPredicate.Expand());

            allPredicate = allPredicate.And(featuresPredicate.Expand());
            allPredicate = allPredicate.And(applicationFeaturesPredicate.Expand());
            allPredicate = allPredicate.And(operatingSystemsPredicate.Expand());
            allPredicate = allPredicate.And(devicesPredicate.Expand());
            allPredicate = allPredicate.And(supportTypesPredicate.Expand());
            allPredicate = allPredicate.And(supportDaysPredicate.Expand());
            allPredicate = allPredicate.And(supportHoursPredicate.Expand());
            allPredicate = allPredicate.And(languagesPredicate.Expand());
            //allPredicate = allPredicate.And(mobilePlatformsPredicate.Expand());
            allPredicate = allPredicate.And(timezonesPredicate.Expand());
            allPredicate = allPredicate.And(cloudApplicationsPredicate.Expand());

            var retVal = repository.GetSearchResultsCount(allPredicate, liveApplicationsOnly);

            return retVal;
            //return dataContext.Products.Where(predicate);
        }
        #endregion

                #region Inserts
        //public static void CallActionForEachMatch<T>(this IEnumerable<T> values, Func<T, bool> pred, Action<T> act)
        //{
        //    foreach (var value in values.Where(pred))
        //    {
        //        act(value);
        //    }
        //}

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertCategoryFilterClause(int? categoryID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(categoryID ?? 0) != 0)
            {
                predicate = predicate.And(p => p.Category.CategoryID == categoryID);
            }
            else
            {
                predicate = predicate.Or(p => p.Category.CategoryID == categoryID);
            }
            return predicate;
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertNumberOfUsersFilterClause(int? numberOfUsers, int categoryID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(numberOfUsers ?? 0) != 0)
            {
                predicate = predicate.And(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                predicate = predicate.And(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            else
            {
                //predicate = predicate.Or(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                //predicate = predicate.Or(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            return predicate;
        }

        #region InsertBrowserFilterClause
        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertBrowserFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.Or(p => p.Browsers.Any(x => x.BrowserName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            return predicate;
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertBrowserFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.Or(p => p.Browsers.Any(x => x.BrowserName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            return predicate;
        }
        #endregion

        #region InsertFeatureFilterClause
        public static void InsertFeatureFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //return predicate;
        }
        #endregion

        #region InsertApplicationFeatureFilterClause
        public static void InsertApplicationFeatureFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.And(p => p.CloudApplicationApplications.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //return predicate;
        }
        #endregion

        #region InsertFeatureLimitClause
        public static void InsertFeatureLimitClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            decimal limitValue = Convert.ToDecimal(element.Col1Value);
            if (element.IsDataCeilingDriven)
            {
                predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim() && x.Count >= limitValue));
            }
            else if (element.IsDataFloorDriven)
            {
                predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim() && x.Count <= limitValue));
            }
            else
            {
                predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim() && x.Count <= limitValue));
            }

            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //return predicate;
        }
        #endregion

        #region InsertOperatingSystemFilterClause
        public static void InsertOperatingSystemFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.OperatingSystems.Any(x => x.OperatingSystemName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public static void InsertOperatingSystemFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.OperatingSystems.Any(x => x.OperatingSystemName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region InsertDeviceFilterClause
        public static void InsertDeviceFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Devices.Any(x => x.DeviceName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public static void InsertDeviceFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Devices.Any(x => x.DeviceName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region InsertSupportTypeFilterClause
        public static void InsertSupportTypeFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.SupportTypes.Any(x => x.SupportTypeName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public static void InsertSupportTypeFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.SupportTypes.Any(x => x.SupportTypeName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region InsertSupportHoursFilterClause
        public static void InsertSupportHoursFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static void InsertSupportHoursFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertSupportHoursFilterClause(int? chosenSupportHoursID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, ICompareCloudwareRepository repository)
        {
            if (Convert.ToInt32(chosenSupportHoursID ?? 0) != 0)
            {
                SupportHours sh = repository.GetSupportHour((int)chosenSupportHoursID);

                //predicate = predicate.And(p => p.SupportHours.SupportHoursID == chosenSupportHoursID);
                predicate = predicate.And(p => p.SupportHours.SupportHoursFrom <= sh.SupportHoursFrom && p.SupportHours.SupportHoursTo >= sh.SupportHoursTo);
            }
            else
            {
                predicate = predicate.Or(p => p.SupportHours.SupportHoursID == chosenSupportHoursID);
            }
            return predicate;
        }

        public static void InsertSupportHoursFromToFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static void InsertSupportHoursFromToFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertSupportHoursFromFilterClause(int? chosenSupportHoursID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, ICompareCloudwareRepository repository)
        {
            if (Convert.ToInt32(chosenSupportHoursID ?? 0) != 0)
            {
                int supportHoursFrom = repository.GetSupportHour((int)chosenSupportHoursID).SupportHoursFrom;
                int supportHoursTo = repository.GetSupportHour((int)chosenSupportHoursID).SupportHoursTo;
                predicate = predicate.And(p => (p.SupportHours.SupportHoursFrom >= supportHoursFrom))
                    .And(p => (p.SupportHours.SupportHoursTo <= supportHoursTo))
                    ;
            }
            else
            {
                predicate = predicate.Or(p => p.SupportHours.SupportHoursID == chosenSupportHoursID);
            }
            return predicate;
        }

        #endregion

        #region InsertTimeZoneFilterClause
        public static void InsertTimeZoneFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHoursTimeZone.TimeZoneName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static void InsertTimeZoneFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHoursTimeZone.TimeZoneName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertTimeZoneFilterClause(int? chosenTimeZoneID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(chosenTimeZoneID ?? 0) != 0)
            {
                predicate = predicate.And(p => p.SupportHoursTimeZone.TimeZoneID == chosenTimeZoneID);
            }
            else
            {
                predicate = predicate.Or(p => p.SupportHoursTimeZone.TimeZoneID == chosenTimeZoneID);
            }
            return predicate;
        }

        #endregion

        #region InsertSupportDaysFilterClause
        public static void InsertSupportDaysFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportDays.SupportDaysName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static void InsertSupportDaysFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportDays.SupportDaysName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public static System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertSupportDaysFilterClause(int? chosenSupportDaysID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(chosenSupportDaysID ?? 0) != 0)
            {
                predicate = predicate.And(p => p.SupportDays.SupportDaysID == chosenSupportDaysID);
            }
            else
            {
                predicate = predicate.Or(p => p.SupportDays.SupportDaysID == chosenSupportDaysID);
            }
            return predicate;
        }

        #endregion

        #region InsertLanguageFilterClause
        public static void InsertLanguageFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Languages.Any(x => x.LanguageName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public static void InsertLanguageFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Languages.Any(x => x.LanguageName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region InsertMobilePlatformFilterClause
        public static void InsertMobilePlatformFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.MobilePlatforms.Any(x => x.MobilePlatformName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public static void InsertMobilePlatformFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.MobilePlatforms.Any(x => x.MobilePlatformName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region InsertStatusFilterClause
        public static void InsertStatusFilterClause(ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.CloudApplicationStatus.StatusName == "LIVE");
        }
        #endregion

        
        #endregion

        #region HaveAnyActiveSupportTypesBeenSelected
        //public bool HaveAnyActiveSupportTypesBeenSelected(IEnumerable<SupportType> supportTypes)
        public static bool HaveAnyActiveSupportTypesBeenSelected(IEnumerable<SearchFilterModelOneColumn> supportTypes, ICompareCloudwareRepository repository)
        {
            bool retVal = false;
            List<SearchFilterModelOneColumn> selectedSupportTypes = supportTypes.Where(x => !repository.FindSupportTypeByName(x.Col1SearchFilterName, true).IsPassive).ToList();

            retVal = selectedSupportTypes.Count > 0;
            return retVal;
        }
        #endregion

        #region IsChosenSupportDaysAPredicate
        public static bool IsChosenSupportDaysAPredicate(int? supportDaysID, ICompareCloudwareRepository repository)
        {
            bool retVal = false;
            if (supportDaysID != null)
            {
                retVal = !repository.GetSupportDay((int)supportDaysID).IgnoreFilterPredicate;
            }
            return retVal;
        }
        #endregion

        #region IsChosenSupportHoursAPredicate
        public static bool IsChosenSupportHoursAPredicate(int? supportHoursID, ICompareCloudwareRepository repository)
        {
            bool retVal = false;
            if (supportHoursID != null)
            {
                retVal = !repository.GetSupportHour((int)supportHoursID).IgnoreFilterPredicate;
            }
            return retVal;
        }
        #endregion

        #region IsChosenTimeZoneAPredicate
        public static bool IsChosenTimeZoneAPredicate(int? timeZoneID, ICompareCloudwareRepository repository)
        {
            bool retVal = false;
            if (timeZoneID != null)
            {
                retVal = !repository.GetTimeZone((int)timeZoneID).IgnoreFilterPredicate;
            }
            return retVal;
        }
        #endregion

        #region PaginateSearchResults
        public static void PaginateSearchResults(SearchPageModel searchResultsForModel, int pageNumber)
        {
            int pageSize = SEARCH_RESULTS_PER_PAGE;
            searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage =
                (PagedList<SearchResultModelOneColumn>)searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToPagedList(pageNumber, pageSize);
            //searchResultsForModel = searchResultsForModel.ToList().ToPagedList(pageNumber, pageSize);
            //var searchResultsPages = (PagedList.IPagedList<SearchResultModelOneColumn>)searchResultsForModel;
            //searchResultsForModel.ContainerModel.SearchResultsModel.CurrentSortOrder = "VENDOR ASC";
            MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList());
            MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage.ToList());
            MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList());
        }

        public static void PaginateSearchResults(GlobalSearchPageModel searchResultsForModel, int pageNumber)
        {
            int pageSize = GLOBAL_SEARCH_RESULTS_PER_PAGE;
            searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage =
                (PagedList<GlobalSearchResultModelOneColumn>)searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToPagedList(pageNumber, pageSize);
            searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPerPage = pageSize;
            //searchResultsForModel = searchResultsForModel.ToList().ToPagedList(pageNumber, pageSize);
            //var searchResultsPages = (PagedList.IPagedList<SearchResultModelOneColumn>)searchResultsForModel;
            //searchResultsForModel.ContainerModel.SearchResultsModel.CurrentSortOrder = "VENDOR ASC";
            MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList());
            MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage.ToList());
            //MarkLastInCollection(searchResultsForModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary.ToList());
        }

        #endregion

        #region MarkLastInCollection
        public static void MarkLastInCollection(IList<SearchResultModelOneColumn> searchResultsForModel)
        {
            if (searchResultsForModel.Count > 0)
            {
                int checkedFilter = searchResultsForModel.ToList().FindIndex(x => x.IsLastInCollectionFull);
                if (checkedFilter >= 0)
                {
                    searchResultsForModel.ToList()[checkedFilter].IsLastInCollectionFull = false;
                }
                searchResultsForModel[searchResultsForModel.Count - 1].IsLastInCollectionFull = true;
            }

        }

        public static void MarkLastInCollection(IList<SearchResultSummaryModel> searchResultsForModel)
        {
            if (searchResultsForModel.Count > 0)
            {
                int checkedFilter = searchResultsForModel.ToList().FindIndex(x => x.IsLastInCollectionSummary);
                if (checkedFilter >= 0)
                {
                    searchResultsForModel.ToList()[checkedFilter].IsLastInCollectionSummary = false;
                }
                searchResultsForModel[searchResultsForModel.Count - 1].IsLastInCollectionSummary = true;
            }

        }

        public static void MarkLastInCollection(IList<GlobalSearchResultModelOneColumn> searchResultsForModel)
        {
            if (searchResultsForModel.Count > 0)
            {
                int checkedFilter = searchResultsForModel.ToList().FindIndex(x => x.IsLastInCollection);
                if (checkedFilter >= 0)
                {
                    searchResultsForModel.ToList()[checkedFilter].IsLastInCollection = false;
                }
                searchResultsForModel[searchResultsForModel.Count - 1].IsLastInCollection = true;
            }

        }

        #endregion

        #region FixUpViewData
        public static void FixUpViewData(SearchPageModel model, Controller controller)
        {
            if (model.CustomSession == null)
            {
                int x = 0;
            }
            controller.TempData["SearchFilters"] = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn;
            controller.TempData["SearchResults"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn;
            //TempData["SearchResultsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;
            controller.TempData["ChosenCloudApplicationModel"] = model.ContainerModel.ChosenCloudApplicationModel;
            controller.TempData["MonthlyPriceColumnHeader"] = model.MonthlyPriceColumnHeader;
            controller.TempData["AnnualPriceColumnHeader"] = model.AnnualPriceColumnHeader;
            controller.TempData["SearchFiltersBrowsersCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed;
            controller.TempData["SearchFiltersCategoriesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed;
            controller.TempData["SearchFiltersDevicesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed;
            controller.TempData["SearchFiltersFeaturesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed;
            controller.TempData["SearchFiltersLanguagesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed;
            controller.TempData["SearchFiltersMobilePlatformsCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed;
            controller.TempData["SearchFiltersOperatingSystemsCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed;
            controller.TempData["SearchFiltersSupportDaysCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed;
            controller.TempData["SearchFiltersSupportHoursCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed;
            controller.TempData["SearchFiltersSupportTypesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed;
            controller.TempData["SearchFiltersUsersCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed;
            controller.TempData["SearchFiltersTimeZonesCollapsed"] = model.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed;
            if (model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn != null)
            {
                controller.TempData["DisplayAsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
            }
        }

        public static void FixUpViewData(GlobalSearchPageModel model, Controller controller)
        {
            //TempData["SearchFilters"] = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn;
            controller.TempData["GlobalSearchResults"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn;
            //TempData["SearchResultsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;
            //TempData["ChosenCloudApplicationModel"] = model.ContainerModel.ChosenCloudApplicationModel;
        }
        #endregion

        #region GetModelFromViewData
        public static void GetModelFromViewData(SearchPageModel model, Controller controller)
        {
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn = (SearchFiltersModelOneColumn)controller.TempData["SearchFilters"];
            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn = (SearchResultsModelOneColumn)controller.TempData["SearchResults"];
            //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = (IEnumerable<SearchResultSummaryModel>)TempData["SearchResultsSummary"];
            if (model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn != null)
            {
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = Convert.ToBoolean(controller.TempData["DisplayAsSummary"]);
            }
            model.ContainerModel.ChosenCloudApplicationModel = (CloudApplicationModel)controller.TempData["ChosenCloudApplicationModel"];

            model.MonthlyPriceColumnHeader = controller.TempData["MonthlyPriceColumnHeader"] != null ? controller.TempData["MonthlyPriceColumnHeader"].ToString() : null;
            model.AnnualPriceColumnHeader = controller.TempData["AnnualPriceColumnHeader"] != null ? controller.TempData["AnnualPriceColumnHeader"].ToString() : null;

            model.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersBrowsersCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersCategoriesCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersDevicesCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersFeaturesCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersLanguagesCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersMobilePlatformsCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersOperatingSystemsCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersSupportDaysCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersSupportHoursCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersSupportTypesCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersUsersCollapsed"]);
            model.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = Convert.ToBoolean(controller.TempData["SearchFiltersTimeZonesCollapsed"]);
        }

        public static void GetModelFromViewData(GlobalSearchPageModel model, Controller controller)
        {
            //model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn = (SearchFiltersModelOneColumn)TempData["SearchFilters"];
            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn = (GlobalSearchResultsModelOneColumn)controller.TempData["GlobalSearchResults"];
            //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = (IEnumerable<SearchResultSummaryModel>)TempData["SearchResultsSummary"];
            //model.ContainerModel.ChosenCloudApplicationModel = (CloudApplicationModel)TempData["ChosenCloudApplicationModel"];
        }
        #endregion

        #region SetFilterHeadersCollapsedStatus
        private void SetFilterHeadersCollapsedStatus(SearchFiltersModel filtersModel)
        {
            filtersModel.SearchFiltersBrowsersCollapsed = true;
            filtersModel.SearchFiltersFeaturesCollapsed = true;
            filtersModel.SearchFiltersLanguagesCollapsed = true;
            filtersModel.SearchFiltersMobilePlatformsCollapsed = true;
            filtersModel.SearchFiltersOperatingSystemsCollapsed = true;
            filtersModel.SearchFiltersSupportDaysCollapsed = true;
            filtersModel.SearchFiltersSupportHoursCollapsed = true;
            filtersModel.SearchFiltersSupportTypesCollapsed = true;
            filtersModel.SearchFiltersTimeZonesCollapsed = true;
        }
        #endregion

        #region SetSessionVariables
        public static void SetSessionVariables(HttpRequestBase request, ICustomSession customSession, bool showSearchTextBox = true)
        {
            var bc = request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            customSession.DetectedBrowser = bc.Browser;
            customSession.DetectedBrowserID = bc.Id;
            customSession.ShowSearchTextBox = showSearchTextBox;
        }
        #endregion

        #region GetCorporateInformationData
        public static ContentTextsModel GetCorporateInformationData(ContentTextsModel model, ICompareCloudwareRepository repository)
        {
            model.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] 
            { 
                "ABOUTUS_TITLE", 
                "ABOUTUS_SECTION_TITLE", 
                "ABOUTUS_SECTION_BODY",
                "MANAGEMENTTEAM_TITLE", 
                "MANAGEMENTTEAM_SECTION_TITLE", 
                "MANAGEMENTTEAM_SECTION_BODY",
                "VISION_TITLE", 
                "VISION_SECTION_TITLE", 
                "VISION_SECTION_BODY",
                "FAQS_TITLE", 
                "FAQS_SECTION_TITLE", 
                "FAQS_SECTION_BODY",
                "CAREERS_TITLE", 
                "CAREERS_SECTION_TITLE", 
                "CAREERS_SECTION_BODY",
                "PRESS_TITLE", 
                "PRESS_SECTION_TITLE", 
                "PRESS_SECTION_TITLE_DATE", 
                "PRESS_SECTION_TITLE_PUBLISHER", 
                "PRESS_SECTION_BODY",
                "CONTACTUS_TITLE", 
                "CONTACTUS_SECTION_TITLE", 
                "CONTACTUS_SECTION_BODY",
            }), ContentDataPage.Corporate).OrderBy(x => x.BodyOrder).ThenBy(x => x.ContentTextType.ContentTextTypeID).ToList();

            return model;
        }
        #endregion

        #region AddPerson
        public static Person AddPerson(PersonTypeEnum personType, string forename, string surname, string eMail, int numberOfUsers, ICompareCloudwareRepository repository)
        {
            //Person person = _repository.GetPersonByEMail(eMail);
            Person person = repository.GetPerson(forename, surname, eMail, numberOfUsers);
            if (person == null)
            {
                person = new Person();
                person.Forename = forename;
                person.Surname = surname;
                person.EMail = eMail;
                person.NumberOfEmployees = numberOfUsers;
                person.PersonStatus = repository.FindStatusByName("LIVE");
                person.PersonType = repository.GetPersonTypeByPersonTypeName(Enum.GetName(typeof(PersonTypeEnum), personType));
                repository.AddPerson(person);
                //_repository.Insert<Person>(person);
                //person = _repository.GetPersonByEMail(eMail);
                person = repository.GetPerson(forename, surname, eMail, numberOfUsers);
            }
            return person;
        }

        public static Person AddPerson(PersonTypeEnum personType, string forename, string surname, string eMail, int numberOfUsers, string telephone, string company, string position, ICompareCloudwareRepository repository)
        {
            //Person person = _repository.GetPersonByEMail(eMail);
            Person person = repository.GetPerson(forename, surname, eMail, numberOfUsers, telephone, company, position);
            if (person == null)
            {
                person = new Person();
                person.Forename = forename;
                person.Surname = surname;
                person.EMail = eMail;
                person.NumberOfEmployees = numberOfUsers;
                person.Telephone = telephone;
                person.Position = position;
                person.Company = company;
                person.PersonStatus = repository.FindStatusByName("LIVE");
                person.PersonType = repository.GetPersonTypeByPersonTypeName(Enum.GetName(typeof(PersonTypeEnum), personType));
                repository.AddPerson(person);
                //_repository.Insert<Person>(person);
                //person = _repository.GetPersonByEMail(eMail);
                person = repository.GetPerson(forename, surname, eMail, numberOfUsers, telephone, company, position);
            }
            return person;
        }

        public static Person AddPerson(PersonTypeEnum personType, string forename, string surname, string position, string company, string eMail, string telephone, string country, bool joinUserGroup, ICompareCloudwareRepository repository)
        {
            //Person person = _repository.GetPersonByEMail(eMail);
            Person person = repository.GetPerson(forename, surname, eMail, country, telephone, company, position, joinUserGroup);
            if (person == null)
            {
                person = new Person();
                person.Forename = forename;
                person.Surname = surname;
                person.EMail = eMail;
                person.PersonCountry = country;
                person.Telephone = telephone;
                person.Position = position;
                person.Company = company;
                person.PersonStatus = repository.FindStatusByName("LIVE");
                person.IsInUserGroup = joinUserGroup;
                person.PersonType = repository.GetPersonTypeByPersonTypeName(Enum.GetName(typeof(PersonTypeEnum), personType));
                repository.AddPerson(person);
                //_repository.Insert<Person>(person);
                //person = _repository.GetPersonByEMail(eMail);
                person = repository.GetPerson(forename, surname, eMail, country, telephone, company, position, joinUserGroup);
            }
            return person;
        }

        public static Person AddPerson(PersonTypeEnum personType, string eMail, bool joinUserGroup, ICompareCloudwareRepository repository)
        {
            //Person person = _repository.GetPersonByEMail(eMail);
            Person person = repository.GetPerson(eMail, joinUserGroup);
            if (person == null)
            {
                person = new Person();
                person.EMail = eMail;
                person.PersonStatus = repository.FindStatusByName("LIVE");
                person.IsInUserGroup = joinUserGroup;
                person.PersonType = repository.GetPersonTypeByPersonTypeName(Enum.GetName(typeof(PersonTypeEnum), personType));
                repository.AddPerson(person);
                //_repository.Insert<Person>(person);
                //person = _repository.GetPersonByEMail(eMail);
                person = repository.GetPerson(eMail, joinUserGroup);
            }
            return person;
        }

        #endregion

        #region AddColleague
        public static bool AddColleagueLink(Person colleaguePerson, string eMailIntroducer, ICompareCloudwareRepository repository)
        {
            //Person person = _repository.GetPersonByEMail(eMail);
            Colleague colleague = new Colleague();
            colleague.Introducer = repository.GetPersonByEMail(eMailIntroducer);
            if (colleague.Introducer == null)
            {
                colleague.Introducer = AddPerson(PersonTypeEnum.User, eMailIntroducer, false, repository);
            }
            colleague.Introducer.PersonStatus = repository.FindStatusByName("LIVE");
            colleague.ColleagueOfIntroducer = colleaguePerson;
            colleague.ColleagueOfIntroducer.PersonStatus = repository.FindStatusByName("LIVE");

            //bool retVal = repository.Insert<Colleague>(colleague);
            bool retVal = repository.AddColleagueLink(colleague);

            return retVal;
        }
        #endregion

        #region FormatDataStorageValueForBytes
        public static decimal FormatDataStorageValueForBytes(SelectListItemFeature slif)
        {
            decimal retVal = slif.Count;
            if (slif.Count == 16384)
            {
                retVal = slif.Count;
            }
            else
            {
                if (slif.OutputDisplayDescriptor == "BYTES")
                {
                    if (slif.CountSuffix == "MB")
                    {
                        retVal = (decimal)slif.Count / 1000;
                    }
                    if (slif.CountSuffix == "GB")
                    {
                        retVal = slif.Count;
                    }
                    if (slif.CountSuffix == "TB")
                    {
                        retVal = slif.Count * 1000;
                    }
                }
            }
            return retVal;
        }
        #endregion

        #region FormatViewModelValueForBytes
        public static int FormatViewModelValueForBytes(CloudApplicationFeature caf)
        {
            int retVal = (int)caf.Count;
            if (caf.Count == 16384)
            {
                retVal = (int)caf.Count;
            }
            else
            {
                if (caf.Feature.OutputDisplayDescriptor == "BYTES")
                {
                    if (caf.CountSuffix == "MB")
                    {
                        retVal = (int)(caf.Count * 1000);
                    }
                    if (caf.CountSuffix == "GB")
                    {
                        retVal = (int)caf.Count;
                    }
                    if (caf.CountSuffix == "TB")
                    {
                        retVal = (int)(caf.Count / 1000);
                    }
                }
            }
            return retVal;
        }

        public static int FormatViewModelValueForBytes(CloudApplicationApplication caa)
        {
            int retVal = (int)caa.Count;
            if (caa.Count == 16384)
            {
                retVal = (int)caa.Count;
            }
            else
            {
                if (caa.Feature.OutputDisplayDescriptor == "BYTES")
                {
                    if (caa.CountSuffix == "MB")
                    {
                        retVal = (int)(caa.Count * 1000);
                    }
                    if (caa.CountSuffix == "GB")
                    {
                        retVal = (int)caa.Count;
                    }
                    if (caa.CountSuffix == "TB")
                    {
                        retVal = (int)(caa.Count / 1000);
                    }
                }
            }
            return retVal;
        }

        #endregion

        #region GetVideoExtensions
        public static SelectListItemCollection GetVideoExtensions(ILogger Logger)
        {
            Logger.Debug("GetVideoExtensions()");
            IList<string> list = new List<string>();
            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            try
            {
                list.Add("MP4");
                list.Add("SWF");
                list.Add("MOV");
                list.Add("WEBM");
                list.Add("OGV");
                list.Add("YouTube");
                list.Add("In a HTML page");
                list.Add("FLV");

                retVal.SelectListItems = list.Select(x => new SelectListItem() { Text = x, Value = x }).ToList();


            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetVideoDomains
        public static SelectListItemCollection GetVideoDomains(ILogger Logger)
        {
            Logger.Debug("GetVideoDomains()");
            IList<string> list = new List<string>();
            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            try
            {
                list.Add("CompareCloudware");
                list.Add("HTTP");
                retVal.SelectListItems = list.Select(x => new SelectListItem() { Text = x, Value = x }).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetStatuses
        public static List<StatusModel> GetStatuses(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            List<StatusModel> retVal = repository.GetStatuses().Select(x => new StatusModel(customSession)
            {
                StatusID = x.StatusID,
                StatusName = x.StatusName,
            }).ToList();

            return retVal;
        }
        #endregion




        #region GetDocumentFileFormatShort
        public static string GetDocumentFileFormatShort(string documentFileFormat)
        {
            switch (documentFileFormat)
            {
                case "HTML":
                    return "HTML";
                case "application/pdf":
                    return "PDF";
                case "application/msword":
                    return "DOC";
                default:
                    return "UNKNOWN";
            }
        }
        #endregion


        #region ConstructListOfIntegers
        public static SelectListItemCollection ConstructListOfIntegers(int minVal, int maxVal)
        {
            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            for (int i = minVal; i <= maxVal; i++)
            {
                retVal.SelectListItems.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }

            retVal.MultiSelect = false;

            return retVal;
        }
        #endregion

        #region ConstructListOfIntegers
        public static SelectListItemCollection ConstructListOfTimes(int minVal, int maxVal, int step)
        {
            return ConstructListOfTimes(minVal, maxVal, step, null);
        }
        public static SelectListItemCollection ConstructListOfTimes(int minVal, int maxVal, int stepMinutes, string outputFormat)
        {
            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();

            for (int i = minVal; i <= maxVal; i += stepMinutes < 60 ? ((stepMinutes / 6) * 10) : 100)
            {
                int hours = (i / 100) * 100;
                decimal minutes = (((decimal)i / 100) * 60) % 60;
                int val = hours + (int)minutes;
                if (outputFormat != null)
                {
                    retVal.SelectListItems.Add(new SelectListItem() { Text = val.ToString(outputFormat), Value = val.ToString() });
                }
                else
                {
                    retVal.SelectListItems.Add(new SelectListItem() { Text = val.ToString(), Value = val.ToString() });
                }
            }

            retVal.MultiSelect = false;

            return retVal;
        }
        #endregion

        #region ConstructContiguousDays
        public static SelectListItemCollection ConstructContiguousDays(int daysSpan, ICompareCloudwareRepository repository)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();


            int i = 0;
            int arrayLength = days.GetLength(0);
            if (daysSpan < arrayLength)
            {
                while (i < arrayLength)
                {
                    int c = ((i + daysSpan - 1) >= arrayLength) ? (i + daysSpan - 1 - 7) : (i + daysSpan - 1);
                    if (daysSpan > 1)
                    {
                        retVal.SelectListItems.Add(new SelectListItem() { Text = days[i] + "-" + days[c], Value = days[i] + "-" + days[c] });
                    }
                    else
                    {
                        retVal.SelectListItems.Add(new SelectListItem() { Text = days[i], Value = days[i] });
                    }
                    i++;
                }
            }
            else
            {
                string supportDaysName = repository.FindSupportDaysByName("7").SupportDaysName;
                retVal.SelectListItems.Add(new SelectListItem() { Text = supportDaysName, Value = supportDaysName });
            }
            retVal.MultiSelect = false;

            return retVal;
        }
        #endregion

        #region GetNumberOfContiguousDays
        public static int GetNumberOfContiguousDays(string daysFromTo)
        {
            int retVal = -1;
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (daysFromTo != "7")
            {
                try
                {
                    retVal = int.Parse(daysFromTo);
                }
                catch
                {
                    string[] fromToDays = daysFromTo.Split(Convert.ToChar("-"));
                    if (fromToDays.Length == 2)
                    {
                        string from = fromToDays.First();
                        string to = fromToDays.Last();
                        int start = days.ToList().IndexOf(from);
                        int finish = days.ToList().IndexOf(to);
                        retVal = finish - start + 1;
                    }
                    string x = "";
                }
            }
            else
            {
                retVal = 7;
            }
            return retVal;
        }
        #endregion

        #region GetSupportHours
        public static int GetSupportHours(string supportHours)
        {
            int retVal = 0;
            return retVal;
        }
        #endregion


        #region ConstructStorageBytes
        public static SelectListItemCollection ConstructStorageBytes(params string[] ignoreArgs)
        {
            string[] storageBytes;
            if (ignoreArgs == null)
            {
                storageBytes = ModelHelpers.GetStorageBytes();
            }
            else
            {
                storageBytes = ModelHelpers.GetStorageBytes();
            }

            SelectListItemCollection retVal = new SelectListItemCollection();
            retVal.SelectListItems = new List<SelectListItem>();
            for (int i = 0; i <= storageBytes.GetUpperBound(0); i++)
            {
                if (ignoreArgs == null ? true : !ignoreArgs.Contains(storageBytes[i]))
                {
                    retVal.SelectListItems.Add(new SelectListItem() { Text = storageBytes[i], Value = storageBytes[i] });
                }
            }

            retVal.MultiSelect = false;
            //docTypes.SelectListItems = new List<SelectListItem>();
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "URL Link", Value = "HTML" });
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "PDF Document", Value = "PDF" });
            //docTypes.SelectListItems.Add(new SelectListItem() { Text = "Word Document", Value = "DOC" });
            //return docTypes;
            return retVal;
        }
        #endregion


        #region ApplicationHasActiveSupport
        public static bool ApplicationHasActiveSupport(List<SelectListItemSupportType> supportTypes)
        {
            bool retVal = false;
            List<SelectListItemSupportType> selectedSupportTypes = supportTypes.Where(x => x.Selected).ToList();

            retVal = selectedSupportTypes.Any(x => !x.IsPassive);
            return retVal;
        }
        #endregion

        #region GetAdvertisingImages
        public static SearchPageModel GetAdvertisingImages(SearchPageModel searchModel, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            try
            {
                AdvertisingImage ai1 = ModelHelpers.GetMPU(customSession, repository);
                AdvertisingImage ai2 = ModelHelpers.GetMPU(customSession, repository);
                AdvertisingImage ai3 = ModelHelpers.GetSkyscraper(customSession, repository);
                AdvertisingImage ai4 = ModelHelpers.GetSkyscraper(customSession, repository);
                searchModel.ContainerModel.MPUAdvertisingImageID1 = ai1.AdvertisingImageID;
                searchModel.ContainerModel.MPUCloudApplicationID1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationID : 0;

                searchModel.ContainerModel.MPUAdvertisingImageID2 = ai2.AdvertisingImageID;
                searchModel.ContainerModel.MPUCloudApplicationID2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationID : 0;

                searchModel.ContainerModel.SkyscraperAdvertisingImageID1 = ai3.AdvertisingImageID;
                searchModel.ContainerModel.SkyscraperCloudApplicationID1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationID : 0;

                searchModel.ContainerModel.SkyscraperAdvertisingImageID2 = ai4.AdvertisingImageID;
                searchModel.ContainerModel.SkyscraperCloudApplicationID2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationID : 0;

                searchModel.ContainerModel.MPUAdvertisingImageCategoryTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                searchModel.ContainerModel.MPUAdvertisingImageShopTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationShopTag.TagName : null;
                searchModel.ContainerModel.MPUAdvertisingImageCategoryTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                searchModel.ContainerModel.MPUAdvertisingImageShopTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationShopTag.TagName : null;

                searchModel.ContainerModel.SkyScraperAdvertisingImageCategoryTag1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                searchModel.ContainerModel.SkyScraperAdvertisingImageShopTag1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationShopTag.TagName : null;
                searchModel.ContainerModel.SkyScraperAdvertisingImageCategoryTag2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationCategoryTag.TagName : null;
                searchModel.ContainerModel.SkyScraperAdvertisingImageShopTag2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationShopTag.TagName : null;
            }
            catch (Exception e)
            {

            }
            return searchModel;
        }

        public static GlobalSearchPageModel GetAdvertisingImages(GlobalSearchPageModel searchModel, ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            AdvertisingImage ai1 = ModelHelpers.GetMPU(customSession,repository);
            AdvertisingImage ai2 = ModelHelpers.GetMPU(customSession,repository);
            AdvertisingImage ai3 = ModelHelpers.GetSkyscraper(customSession, repository);
            AdvertisingImage ai4 = ModelHelpers.GetSkyscraper(customSession, repository);
            searchModel.MPUAdvertisingImageID1 = ai1.AdvertisingImageID;
            searchModel.MPUCloudApplicationID1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationID : 0;

            searchModel.MPUAdvertisingImageID2 = ai2.AdvertisingImageID;
            searchModel.MPUCloudApplicationID2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationID : 0;

            searchModel.SkyscraperAdvertisingImageID1 = ai3.AdvertisingImageID;
            searchModel.SkyscraperCloudApplicationID1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationID : 0;

            searchModel.SkyscraperAdvertisingImageID2 = ai4.AdvertisingImageID;
            searchModel.SkyscraperCloudApplicationID2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationID : 0;

            searchModel.MPUAdvertisingImageCategoryTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationCategoryTag.TagName : null;
            searchModel.MPUAdvertisingImageShopTag1 = ai1.CloudApplication != null ? ai1.CloudApplication.CloudApplicationShopTag.TagName : null;
            searchModel.MPUAdvertisingImageCategoryTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationCategoryTag.TagName : null;
            searchModel.MPUAdvertisingImageShopTag2 = ai2.CloudApplication != null ? ai2.CloudApplication.CloudApplicationShopTag.TagName : null;

            searchModel.SkyScraperAdvertisingImageCategoryTag1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationCategoryTag.TagName : null;
            searchModel.SkyScraperAdvertisingImageShopTag1 = ai3.CloudApplication != null ? ai3.CloudApplication.CloudApplicationShopTag.TagName : null;
            searchModel.SkyScraperAdvertisingImageCategoryTag2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationCategoryTag.TagName : null;
            searchModel.SkyScraperAdvertisingImageShopTag2 = ai4.CloudApplication != null ? ai4.CloudApplication.CloudApplicationShopTag.TagName : null;

            return searchModel;
        }
        #endregion

        #region GetMPU
        public static AdvertisingImage GetMPU(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            //advertisingImageID = new Random().Next(12, 15);
            AdvertisingImage ai = null;
            try
            {
                ai = repository.GetAdvertisingImage(0, "MPU", customSession.SelectedCategoryID, true);
            }
            catch (Exception e)
            {

            }
            return ai;
        }
        #endregion

        #region GetSkyscraper
        public static AdvertisingImage GetSkyscraper(ICustomSession customSession, ICompareCloudwareRepository repository)
        {
            //advertisingImageID = new Random().Next(12, 15);
            AdvertisingImage ai = null;
            try
            {
                ai = repository.GetAdvertisingImage(0, "SKYSCRAPER", customSession.SelectedCategoryID, true);
            }
            catch (Exception e)
            {

            }
            return ai;
        }
        #endregion

        #region GetShopURL
        public static string GetShopURL(int cloudApplicationID, ICompareCloudwareRepository repository)
        {
            string retVal = repository.GetShopURL(cloudApplicationID);
            return retVal;
        }
        #endregion

        #region GetSearchModelFiltersTwoColumn
        //public SearchPageModel xGetSearchModelFiltersTwoColumn(SearchPageModel model, bool featuresOnly)
        //{

        //    var twoCols = _repository.GetFiltersTwoColumn((int)model.ContainerModel.SearchFiltersModel.ChosenCategoryID, (int)model.ContainerModel.SearchFiltersModel.ChosenNumberOfUsers);
        //    //get all the search filters which need to be rendered as one column
        //    var filtersOneColumn =
        //        //_repository.GetSearchOptions(3)
        //        twoCols
        //        .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
        //        .Select(x => new SearchFilterModelOneColumn(CustomSession)
        //        {
        //            Category = x.CategoryCol1 != null ? new CategoryModel()
        //            {
        //                CategoryID = x.CategoryCol1.CategoryID,
        //                CategoryName = x.CategoryCol1.CategoryName,
        //            }
        //            : null,
        //            //x.CategoryCol1 : null,
        //            //SearchFilterID = x.Category.CategoryID,
        //            Col1SearchFilterName = x.SearchFilterNameCol1,
        //            Col1SearchFilterType = x.SearchFilterTypeNameCol1,
        //            Col1Selected = false,
        //        }
        //        );

        //    var searchModel = new SearchPageModel(CustomSession);
        //    if (!featuresOnly)
        //    {
        //        //get all the search filters which need to be rendered as two column
        //        var filtersTwoColumn =
        //            //_repository.GetSearchOptions(3)
        //            twoCols
        //            .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
        //            .Select(x => new SearchFilterModelTwoColumn(CustomSession)
        //            {
        //                //Category = x.Category != null ? x.Category : null,
        //                //SearchFilterID = x.Category.CategoryID,
        //                Col1SearchFilterName = x.SearchFilterNameCol1,
        //                Col1SearchFilterType = x.SearchFilterTypeNameCol1,
        //                Col1Selected = false,
        //                Col2SearchFilterName = x.SearchFilterNameCol2,
        //                Col2SearchFilterType = x.SearchFilterTypeNameCol2,
        //                Col2Selected = false
        //            }
        //            );
        //        //model3.SearchFiltersModel.SearchFilters = features;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
        //        //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
        //        //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);
        //    }
        //    else
        //    {
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersBrowsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersBrowsers;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersLanguages = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersLanguages;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersMobilePlatforms = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersMobilePlatforms;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersOperatingSystems = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersOperatingSystems;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportDays = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportDays;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportHours;
        //        searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportTypes = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportTypes;
        //    }

        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.PreviouslyChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID;
        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID;
        //    //searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.Categories = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.Categories;
        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenNumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenNumberOfUsers;
        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.NumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.NumberOfUsers;
        //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersFeatures = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_FEATURES);


        //    return searchModel;

        //}
        #endregion

        #region ConstructCloudwareExplainedPageModel
        public static CloudwareExplainedPageModel ConstructCloudwareExplainedPageModel(CloudwareExplainedPageModel model, ICustomSession customSession, ICompareCloudwareRepository repository, HttpRequestBase request)
        {


            model.CustomSession = customSession;
            model.CustomSession.SelectedCategoryID = 0;
            //Logger.Debug("ConstructHomePageModel #7");
            //model.Carousel = new CarouselModel(customSession, repository, CarouselType.Home);
            model.CarouselSocial = new CarouselModel(customSession, repository, CarouselType.Social);

            model.H1H2ContentText = new ContentTextsModel(customSession);
            //model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HOMEPAGE_H1_TITLE", "HOMEPAGE_H1_BODY", "HOMEPAGE_H2_1_TITLE", "HOMEPAGE_H2_1_BODY", "HOMEPAGE_H2_2_TITLE", "HOMEPAGE_H2_2_BODY" })).ToList();
            model.ContentTextsModel = new ContentTextsModel();
            model.H1H2ContentText = ModelHelpers.GetCloudwareExplainedData(model.ContentTextsModel, repository);

            model.TabbedOnpageOptimisationModel = new TabbedOnpageOptimisationModel(customSession);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_SECTION_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_SECTION_BODY") || x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_TAB_HEADER")).ToList();
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_SECTION_BODY") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_TAB_HEADER")).ToList(); ;
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SUBTITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER")).ToList(); ;

            var cloudwareExplainedTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINEDPAGE_TITLE")).FirstOrDefault();
            var cloudwareExplainedTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_TAB_TITLE")).FirstOrDefault();
            var tenReasonsTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_TAB_TITLE")).FirstOrDefault();
            var whatDoesMyBusinessTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_TITLE")).FirstOrDefault();

            model.CloudwareExplainedHeading = cloudwareExplainedTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab1Title = cloudwareExplainedTabTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab2Title = tenReasonsTabTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab3Title = whatDoesMyBusinessTabTitle.ContentTextData;


            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(cloudwareExplainedTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(cloudwareExplainedTabTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(tenReasonsTabTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(whatDoesMyBusinessTabTitle);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);

            SetFirstAndLastInCollection(model.TabbedOnpageOptimisationModel);

            #region Video
            model.Video = new CloudApplicationVideoModel(customSession, request)
            {
                //CloudApplicationVideoFileFormat = "MP4",
                //CloudApplicationVideoFileName = "CCW Provider Demo 1.mp4",
                //CloudApplicationVideoID = x.CloudApplicationVideoID,
                //CloudApplicationVideoURL = "https://www.youtube.com/v/-YH7LDC15rE",
                //CloudApplicationVideoURL = "https://www.youtube.com/embed/-YH7LDC15rE",
                CloudApplicationVideoURL = "//player.vimeo.com/video/103524492?title=0&amp;byline=0&amp;portrait=0",
                //IsLive = x.CloudApplicationVideoStatus.StatusName == "LIVE",
                //IsLocalDomain = true,
                IsYouTubeStream = true,
                ReadyToPlay = true,
                CloudApplicationVideoStatus = "LIVE",
                Width = 304,
                AspectRatio = AspectRatio.Ratio16x9,
            };
            #endregion

            return model;
        }
        #endregion

        #region ConstructPartnerProgrammeModel
        public static PartnerProgrammeModel ConstructPartnerProgrammeModel(PartnerProgrammeModel model, ICustomSession customSession, ICompareCloudwareRepository repository, HttpRequestBase request)
        {


            model.CustomSession = customSession;
            model.CustomSession.SelectedCategoryID = 0;
            //model.CarouselSocial = new CarouselModel(customSession, repository, CarouselType.Social);

            model.H1H2ContentText = new ContentTextsModel(customSession);
            //model.H1H2ContentText.ContentTexts = ModelHelpers.ConvertContentText(repository.GetContentData(new[] { "HOMEPAGE_H1_TITLE", "HOMEPAGE_H1_BODY", "HOMEPAGE_H2_1_TITLE", "HOMEPAGE_H2_1_BODY", "HOMEPAGE_H2_2_TITLE", "HOMEPAGE_H2_2_BODY" })).ToList();
            model.ContentTextsModel = new ContentTextsModel();
            //model.H1H2ContentText = ModelHelpers.GetCloudwareExplainedData(model.ContentTextsModel, repository);
            model.H1H2ContentText = ModelHelpers.GetPartnerProgrammeData(new ContentTextsModel(customSession), repository, customSession,request);

            model.TabbedOnpageOptimisationModel = new TabbedOnpageOptimisationModel(customSession);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3 = new OnpageOptimisationTabModel(customSession);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab4 = new OnpageOptimisationTabModel(customSession);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData = 
                model.H1H2ContentText.ContentTexts
                .Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TITLE")
                    //|| x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TAB_TITLE")
                    //|| x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SUBTITLE1")
                    //|| x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SUBTITLE2")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SECTION_BODY")
                    //|| x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TAB_HEADER")
                    ).ToList();


            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData = 
                model.H1H2ContentText.ContentTexts
                .Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TITLE") 
                || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE") 
                || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SECTION_BODY") 
                || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TAB_HEADER")
                ).ToList();
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData = 
                model.H1H2ContentText.ContentTexts
                .Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_BODY")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_TAB_HEADER")
                    ).ToList(); ;
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData = 
                model.H1H2ContentText.ContentTexts
                .Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_SUBTITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_BODY")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_TAB_HEADER")
                    ).ToList(); ;
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab4.OnpageOptimisationTabData =
                model.H1H2ContentText.ContentTexts
                .Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_SUBTITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_TITLE")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_BODY")
                    || x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_TAB_HEADER")
                    ).ToList(); ;

            
            //model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_SECTION_BODY") || x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_TAB_HEADER")).ToList(); ;
            //model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SUBTITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY") || x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER")).ToList(); ;

            var cloudwareExplainedTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMMEPAGE_TITLE")).FirstOrDefault();
            var cloudwareExplainedTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_TAB_TITLE")).FirstOrDefault();
            var tenReasonsTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_TAB_TITLE")).FirstOrDefault();
            var whatDoesMyBusinessTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_TAB_TITLE")).FirstOrDefault();
            var referRewardTabTitle = model.H1H2ContentText.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_TAB_TITLE")).FirstOrDefault();


            model.TabbedOnpageOptimisationModel.Tab1Title = cloudwareExplainedTabTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab2Title = tenReasonsTabTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab3Title = whatDoesMyBusinessTabTitle.ContentTextData;
            model.TabbedOnpageOptimisationModel.Tab4Title = referRewardTabTitle.ContentTextData;


            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(cloudwareExplainedTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(cloudwareExplainedTabTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(tenReasonsTabTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(whatDoesMyBusinessTabTitle);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.Remove(referRewardTabTitle);

            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab1.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab2.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab3.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);
            model.TabbedOnpageOptimisationModel.OnpageOptimisationTab4.OnpageOptimisationTabData.ForEach(x => x.IsCollapsible = true);

            SetFirstAndLastInCollectionPP(model.TabbedOnpageOptimisationModel);
            
            model.CarouselSocial = new CarouselModel(customSession, repository, CarouselType.Social);


            return model;
        }
        #endregion

        #region SetFirstAndLastInCollection
        private static void SetFirstAndLastInCollection(TabbedOnpageOptimisationModel model)
        {
            ContentTextModel ctt;
            ctt = model.OnpageOptimisationTab1.OnpageOptimisationTabData
                .FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("CLOUDWAREEXPLAINED_SECTION_TITLE"));
            if (ctt != null)
            {
                ctt.IsFirstInCollection = true;
            }
            model.OnpageOptimisationTab1.OnpageOptimisationTabData.Last().IsLastInCollection = true;

            if (model.OnpageOptimisationTab2.OnpageOptimisationTabData != null)
            {
                ctt = model.OnpageOptimisationTab2.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"));
                if (ctt != null)
                {
                    ctt.IsFirstInCollection = true;
                }
                model.OnpageOptimisationTab2.OnpageOptimisationTabData.Last().IsLastInCollection = true;
            }

            if (model.OnpageOptimisationTab3.OnpageOptimisationTabData != null)
            {
                ctt = model.OnpageOptimisationTab3.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"));
                if (ctt != null)
                {
                    ctt.IsFirstInCollection = true;
                }
                model.OnpageOptimisationTab3.OnpageOptimisationTabData.Last().IsLastInCollection = true;
            }

            if (model.OnpageOptimisationTab4 != null)
            {
                if (model.OnpageOptimisationTab4.OnpageOptimisationTabData != null)
                {
                    ctt = model.OnpageOptimisationTab4.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"));
                    if (ctt != null)
                    {
                        ctt.IsFirstInCollection = true;
                    }
                    model.OnpageOptimisationTab4.OnpageOptimisationTabData.Last().IsLastInCollection = true;
                }
            }
            
            

        }

        #endregion

        #region SetFirstAndLastInCollectionPP
        private static void SetFirstAndLastInCollectionPP(TabbedOnpageOptimisationModel model)
        {
            ContentTextModel ctt;
            ctt = model.OnpageOptimisationTab1.OnpageOptimisationTabData
                .FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_OVERVIEW_SECTION_TITLE"));
            if (ctt != null)
            {
                ctt.IsFirstInCollection = true;
            }
            model.OnpageOptimisationTab1.OnpageOptimisationTabData.Last().IsLastInCollection = true;

            if (model.OnpageOptimisationTab2.OnpageOptimisationTabData != null)
            {
                ctt = model.OnpageOptimisationTab2.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_BUSINESSPARTNER_SECTION_TITLE"));
                if (ctt != null)
                {
                    ctt.IsFirstInCollection = true;
                }
                model.OnpageOptimisationTab2.OnpageOptimisationTabData.Last().IsLastInCollection = true;
            }

            if (model.OnpageOptimisationTab3.OnpageOptimisationTabData != null)
            {
                ctt = model.OnpageOptimisationTab3.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_STRATEGICPARTNER_SECTION_TITLE"));
                if (ctt != null)
                {
                    ctt.IsFirstInCollection = true;
                }
                model.OnpageOptimisationTab3.OnpageOptimisationTabData.Last().IsLastInCollection = true;
            }

            if (model.OnpageOptimisationTab4 != null)
            {
                if (model.OnpageOptimisationTab4.OnpageOptimisationTabData != null)
                {
                    ctt = model.OnpageOptimisationTab4.OnpageOptimisationTabData.FirstOrDefault(x => x.ContentTextType.ContentTextTypeName.EndsWith("PARTNERPROGRAMME_REFERREWARDPARTNER_SECTION_TITLE"));
                    if (ctt != null)
                    {
                        ctt.IsFirstInCollection = true;
                    }
                    model.OnpageOptimisationTab4.OnpageOptimisationTabData.Last().IsLastInCollection = true;
                }
            }



        }

        #endregion

        #region IsFirstTimeVisit
        public static bool IsFirstTimeVisit(HttpRequestBase request, HttpResponseBase response)
        {
            // check if cookie exists and if yes update
            HttpCookie existingCookie = request.Cookies["CCW_FirstTimeVisit"];
            if (existingCookie != null)
            {
                return false;
            }
            else
            {
                // create a cookie
                HttpCookie newCookie = new HttpCookie("CCW_FirstTimeVisit", DateTime.Now.ToString());
                newCookie.Expires = DateTime.Today.AddMonths(12);
                response.Cookies.Add(newCookie);
                return true;
            }
        }
        #endregion

    }
}