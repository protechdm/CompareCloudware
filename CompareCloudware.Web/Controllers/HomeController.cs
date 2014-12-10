using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Logging;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.POCOQueryRepository.Helpers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.Domain.Models;
using CompareCloudware.Web.Models;
using CompareCloudware.Web.Models.EMailTemplateModels;
using CompareCloudware.Web.Helpers;
using System.Data.Entity;
using LinqKit;
using System.IO;
using System.Web.Script.Serialization;
using PagedList;
using System.Configuration;
using System.Collections;
using System.Net;
//using System.Data.Objects;
using System.Text;
//using System.Web.WebPages;
//using Omu.AwesomeMvc;
//using System.Web.Routing;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;
using System.Threading.Tasks;

namespace CompareCloudware.Web.Controllers
{
    public class HomeController : BaseController
    {
        const string SAMPLE_EMAIL = "protechdm@yahoo.com";
        const string SAMPLE_FIRSTNAME = "Glyn";

        //const string FILTER_CATEGORIES = "CATEGORIES";
        const string FILTER_CATEGORIES = "CATEGORY";
        const string FILTER_USERS = "USERS";
        //const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_BROWSERS = "BROWSER";
        //const string FILTER_FEATURES = "FEATURES";
        const string FILTER_FEATURES = "FEATURE";
        //const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEM";
        const string FILTER_DEVICES = "DEVICES";
        //const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPE";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        //const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_LANGUAGES = "LANGUAGE";
        //const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORM";
        //const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURES";
        const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURE";
        //const string FILTER_TIMEZONES = "TIMEZONES";
        const string FILTER_TIMEZONES = "TIMEZONE";



        //bool DUMMY_VX_MODE = Convert.ToBoolean(ConfigurationManager.AppSettings["DummyVXMode"]);

        const string TAB_FEATURED = "TAB_FEATURED";
        const string TAB_NEW = "TAB_NEW";
        const string TAB_TOPTEN = "TAB_TOPTEN";




        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        //public ILogger Logger { get; set; }


        private bool testMode;
        private string homePageURL = null;
        

        //public HomeController() :base(null) { }

        public HomeController(ICustomSession session, ICompareCloudwareRepository repository, ISiteAnalyticsLogger _SiteAnalyticsLogger)
            :base(session, repository,_SiteAnalyticsLogger)
        {
            CustomSession = session;

            //_repository = repository;
            //ViewBag.CustomSession = session;
            testMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            homePageURL = testMode ? ConfigurationManager.AppSettings["HomePageURLDev"] : ConfigurationManager.AppSettings["HomePageURLLive"];

        }
        
        #region Index
        //[SessionExpireFilter]
        public ActionResult Index(string id, bool? showDiagnostics)
        {
            //return View("Index", new HomePageModel(CustomSession));
            //return View("index2",new HomePageModel(CustomSession));
            Logger.Debug("Entered site through IndexCustom");

            CustomSession.DummyVXMode = false;
            CustomSession.HasSearchResults = false;
            CustomSession.ShowSearchTextBox = false;

            bool testMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            if (testMode)
            {
                CustomSession.Forename = "test";
                CustomSession.Surname = "test";
                CustomSession.EMail = "w@w.co";
                CustomSession.NumberOfUsers = 99;
            }
            //return RedirectToAction("PartnerProgrammePage");
            //var httpRequest = new HttpRequest("EMailTemplates/BusinessPartner", "http://localhost:81/businesspartner", null);
            //string x = RenderRazorView.RenderViewToString(this, "EMailTemplates/BusinessPartner", new BusinessPartnerModel() { Forename = "f", Surname = "s", Vendorname = "v" });

            if (showDiagnostics == null)
            {
                CustomSession.ShowDiagnostics = false;
            }
            else
            {
                CustomSession.ShowDiagnostics = showDiagnostics ?? false;
            }

            ModelHelpers.SetSessionVariables(Request, this.CustomSession, false);

            //ModelHelpers.SetSessionVariables(Request,this.CustomSession);
            SiteActivities.Log(_repository, Request);

            CustomSession.VisitedViaCategory = false;
            var model = ModelHelpers.ConstructHomePageModel(new HomePageModel(CustomSession, ModelHelpers.ConvertContentPageToContentPageModel(_repository.GetContentPage("Home")))
            {
                SearchInputModel = new SearchInputModel(CustomSession)
            }, this.CustomSession, _repository,Request, this.HttpContext.Response);
            ViewBag.VisibleResultsTab = 1;
            return MetaDataView("HomePage",model);

            //return View();
            //return RedirectToAction("HomePage");
            //return RedirectToAction("SearchTags");
            //return RedirectToAction("SearchPage");
        }
        #endregion

        #region Category
        public ActionResult Category(string category)
        {
            try
            {
                string categoryName = RouteData.Values["theCategory"].ToString();
                //return RedirectToAction("Index");
                Category c = _repository.FindCategoryByURL(categoryName);
                if (c.CategoryStatus.StatusName.ToUpper() != "SUSPENDED")
                {
                    CategoryPageModel cpm = ModelHelpers.ConstructCategoryPage(categoryName, _siteAnalyticsLogger, this.CustomSession, _repository, Request);
                    return MetaDataView("CategoryPage", cpm);
                }
                else
                {
                    CustomSession.SelectedCategoryName = c.CategoryName;
                    CustomSession.SelectedCategoryID = c.CategoryID;
                    ModelHelpers.SetSessionVariables(Request, CustomSession);
                    //return RedirectToAction("ThanksForComing", new { categoryname = c.CategoryName });
                    //return RedirectToRoute("ThanksForComing", new { categoryname = c.CategoryName });
                    BaseModel b = new BaseModel() { CustomSession = CustomSession };
                    //return RedirectToAction("ThanksForComing", b);
                    return View("ThanksForComing",b);
                }
                //return RedirectToAction("CategoryPage", new { categoryID = c.CategoryID });
            }
            catch (Exception e)
            {
                //throw new Exception("OOPS");
                throw new CategoryNotFoundException();
            }
        }
        #endregion

        #region Shop
        public ActionResult Shop(string category, string shop, int? cloudApplicationID)
        {
            try
            {
                if (cloudApplicationID == null)
                {
                    string categoryName = RouteData.Values["theCategory"].ToString();
                    Category c = _repository.FindCategoryByURL(categoryName);
                    string shopName = RouteData.Values["theShop"].ToString();
                    cloudApplicationID = _repository.FindShopByURL(shopName);
                }

                bool DUMMY_VX_MODE = CustomSession.DummyVXMode;
                if (DUMMY_VX_MODE)
                {
                    //int id = cloudApplicationID;
                    //return RedirectToAction("IndexCustom", "Vendor", new { cloudApplicationID = cloudApplicationID });
                    return RedirectToRoute("Vendor", new { controller = "Vendor", action = "IndexCustom", cloudApplicationID = cloudApplicationID });
                }

                var term = "";//TODO
                var showUserReviewConfirmation = false;//TODO
                var model = ModelHelpers.GetCloudApplicationModel((int)cloudApplicationID, term, showUserReviewConfirmation, this.CustomSession, _repository, Logger, _siteAnalyticsLogger, this, Request);

                Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #6");
                bool testPDF = Convert.ToBoolean(ConfigurationManager.AppSettings["TestPDFMode"]);
                if (!testPDF)
                {
                    return MetaDataView("CloudApplicationModel", model);
                }
                else
                {
                    model.ContainerModel.ChosenCloudApplicationModel.CustomSession.Forename = "Glyn";
                    model.ContainerModel.ChosenCloudApplicationModel.CustomSession.Surname = "Threadgold";
                    //return View("PrintResult3", model.ContainerModel.ChosenCloudApplicationModel);
                    //return RedirectToAction("PrintResult3", "Admin", new { cloudApplicationID = cloudApplicationID });
                    //return null;
                    return View("PrintResult3", model);
                    //return View("ShopPDFPage2", model);
                }
            }
            catch (Exception e)
            {
                throw new ShopNotFoundException();
            }
        }
        #endregion

        #region About
        public ActionResult About()
        {
            try
            {
                //string message = ViewRenderer.RenderView("~/Views/WS.cshtml", null, ControllerContext);
                //string path = Server.MapPath("~/Views/WS.cshtml");
                //string message = ViewRenderer.RenderView("j:\\comparecloudwarevideo\\comparecloudware.web\\Views\\WS.cshtml", null, ControllerContext);
                //var html = this.RenderView("WS");
                return View();
            }
            catch (Exception e)
            {
                return null;
            }
            return View();
        }
        #endregion

        #region HomePage
        //[SessionExpireFilter]
        public ActionResult HomePage()
        {
            //Logger.Fatal("In HomePage");
            try
            {
                CustomSession.VisitedViaCategory = false;
                CustomSession.ShowSearchTextBox = false;
                var model = ModelHelpers.ConstructHomePageModel(new HomePageModel(CustomSession,ModelHelpers.ConvertContentPageToContentPageModel(_repository.GetContentPage("Home"))) 
                { 
                    SearchInputModel = new SearchInputModel(CustomSession),
                    SearchInputModelFirstTime = new SearchInputModel(CustomSession),
                }, this.CustomSession, _repository, Request, this.HttpContext.Response);
                ViewBag.VisibleResultsTab = 1;
                return View(model);
            }
            catch (Exception ex)
            {
                Logger.Fatal("HomePage exception. The exception was :" + ex.Message + ". Stacktrace : " + ex.StackTrace);
                //throw new Exception();
                return null;
            }
            //return View("Index");
        }
        #endregion

        #region HomePage POST
        [HttpPost]
        public ActionResult HomePage(HomePageModel model)
        {
            return HomePagePost(model);
        }
        #endregion

        #region HomePageFirstTime
        [HttpPost]
        public ActionResult HomePageFirstTime(HomePageModel model)
        {
            model.SearchInputModel = model.SearchInputModelFirstTime;
            return HomePagePost(model);
        }
        #endregion

        #region HomePagePost
        private ActionResult HomePagePost(HomePageModel model)
        {
            if (!model.SearchInputModel.TermsAndConditions)
            {
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "Terms & Conditions";
                model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
                return View(ModelHelpers.ConstructHomePageModel(model, this.CustomSession, _repository, Request, this.HttpContext.Response));
            }

            if (model.SearchInputModel.ChosenNumberOfUsers == "User numbers")
            {
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "User numbers";
                model.ConfirmationDialogMessage1 = "Please select the User number to proceed";
                return View(ModelHelpers.ConstructHomePageModel(model, this.CustomSession, _repository, Request, this.HttpContext.Response));
            }

            if (ModelState.IsValid)
            {
                Person person = ModelHelpers.AddPerson(PersonTypeEnum.User, model.SearchInputModel.Forename, model.SearchInputModel.Surname, model.SearchInputModel.EMail, int.Parse(model.SearchInputModel.ChosenNumberOfUsers),_repository);
                CustomSession.EMail = person.EMail;
                CustomSession.Forename = person.Forename;
                CustomSession.Surname = person.Surname;
                CustomSession.NumberOfUsers = person.NumberOfEmployees;
                CustomSession.PersonID = person.PersonID;

                _siteAnalyticsLogger.Log(_repository, ActionType.ClickHomePageCompare, null, model.SearchInputModel.ChosenCategoryID, person.PersonID);

                return RedirectToAction("Comparing", new { categoryID = model.SearchInputModel.ChosenCategoryID, numberOfUsers = model.SearchInputModel.ChosenNumberOfUsers, useCachedData = false });
            }
            else
            {
                if (ModelState["SearchInputModel.Forename"].Errors.Count > 0 || model.SearchInputModel.Forename == ViewModelHelpers.FORENAME_ERROR_MESSAGE)
                {
                    ModelState["SearchInputModel.Forename"].Value = new ValueProviderResult(ViewModelHelpers.FORENAME_ERROR_MESSAGE, model.SearchInputModel.Forename, System.Globalization.CultureInfo.CurrentCulture);
                    ModelState.AddModelError("SearchInputModel.Forename", "www");
                    model.SearchInputModel.Forename = model.SearchInputModel.Forename == null ? "Please enter your name" : model.SearchInputModel.Forename;
                }


                if (ModelState["SearchInputModel.EMail"].Errors.Count > 0)
                {
                    if (model.SearchInputModel.EMail == ViewModelHelpers.EMAIL_ERROR_MESSAGE || model.SearchInputModel.EMail == null)
                    {
                        ModelState["SearchInputModel.EMail"].Value = new ValueProviderResult(ViewModelHelpers.EMAIL_ERROR_MESSAGE, model.SearchInputModel.EMail, System.Globalization.CultureInfo.CurrentCulture);
                        model.SearchInputModel.EMail = model.SearchInputModel.EMail == null ? "Please enter your email address" : model.SearchInputModel.EMail;
                    }
                    ModelState.AddModelError("SearchInputModel.EMail", "www");
                }
                return View(ModelHelpers.ConstructHomePageModel(model, this.CustomSession, _repository, Request, this.HttpContext.Response));
            }
        }
        #endregion

        #region CategoryPagePost
        private ActionResult CategoryPagePost(CategoryPageModel model)
        {
            if (!model.SearchInputModel.TermsAndConditions)
            {
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "Terms & Conditions";
                model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
                return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));
            }

            if (model.SearchInputModel.ChosenNumberOfUsers == "User numbers")
            {
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "User numbers";
                model.ConfirmationDialogMessage1 = "Please select the User number to proceed";
                return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));
            }

            if (ModelState.IsValid)
            {
                Person person = ModelHelpers.AddPerson(PersonTypeEnum.User, model.SearchInputModel.Forename, model.SearchInputModel.Surname, model.SearchInputModel.EMail, int.Parse(model.SearchInputModel.ChosenNumberOfUsers), _repository);
                CustomSession.EMail = person.EMail;
                CustomSession.Forename = person.Forename;
                CustomSession.Surname = person.Surname;
                CustomSession.NumberOfUsers = person.NumberOfEmployees;
                CustomSession.PersonID = person.PersonID;

                _siteAnalyticsLogger.Log(_repository, ActionType.ClickHomePageCompare, null, model.SearchInputModel.ChosenCategoryID, person.PersonID);

                return RedirectToAction("Comparing", new { categoryID = model.SearchInputModel.ChosenCategoryID, numberOfUsers = model.SearchInputModel.ChosenNumberOfUsers, useCachedData = false });
            }
            else
            {
                if (ModelState["SearchInputModel.Forename"].Errors.Count > 0 || model.SearchInputModel.Forename == ViewModelHelpers.FORENAME_ERROR_MESSAGE)
                {
                    ModelState["SearchInputModel.Forename"].Value = new ValueProviderResult(ViewModelHelpers.FORENAME_ERROR_MESSAGE, model.SearchInputModel.Forename, System.Globalization.CultureInfo.CurrentCulture);
                    ModelState.AddModelError("SearchInputModel.Forename", "www");
                    model.SearchInputModel.Forename = model.SearchInputModel.Forename == null ? "Please enter your name" : model.SearchInputModel.Forename;
                }


                if (ModelState["SearchInputModel.EMail"].Errors.Count > 0)
                {
                    if (model.SearchInputModel.EMail == ViewModelHelpers.EMAIL_ERROR_MESSAGE || model.SearchInputModel.EMail == null)
                    {
                        ModelState["SearchInputModel.EMail"].Value = new ValueProviderResult(ViewModelHelpers.EMAIL_ERROR_MESSAGE, model.SearchInputModel.EMail, System.Globalization.CultureInfo.CurrentCulture);
                        model.SearchInputModel.EMail = model.SearchInputModel.EMail == null ? "Please enter your email address" : model.SearchInputModel.EMail;
                    }
                    ModelState.AddModelError("SearchInputModel.EMail", "www");
                }
                return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));
            }
        }
        #endregion



        #region Comparing
        public ActionResult Comparing(int categoryID, int numberOfUsers, bool useCachedData)
        {
            SearchPageModel searchPageModel = new SearchPageModel(CustomSession);
            searchPageModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = categoryID;
            searchPageModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = numberOfUsers;
            return View("Comparing", searchPageModel);
        }
        #endregion

        #region SearchResultsCount
        [HttpGet]
        public JsonResult SearchResultsCount(int categoryID, int numberOfUsers)
        {
            SearchPageModel searchPageModel = new SearchPageModel(CustomSession);
            searchPageModel.ContainerModel.SearchFiltersModel = new SearchFiltersModel()
                {
                    SearchFiltersModelOneColumn = new SearchFiltersModelOneColumn()
                    {
                        ChosenCategoryID = categoryID,
                        ChosenNumberOfUsers = numberOfUsers,
                    }
                };

            //int searchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger)
            var searchResults = ModelHelpers.SearchProductsCount(searchPageModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn, CustomSession, _repository, _siteAnalyticsLogger, null);
            return Json(searchResults,JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region SearchPage
        [SessionExpireFilter]
        public ActionResult SearchPage(int categoryID, int numberOfUsers, bool useCachedData)
        {
            CustomSession.SelectedCategoryID = categoryID;
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            SearchPageModel searchModel = new SearchPageModel(CustomSession);

            if (useCachedData)
            {
                ModelHelpers.GetModelFromViewData(searchModel,this);

                if (searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn == null)
                {
                    return RedirectToAction("HomePage");
                }

                categoryID = (int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, searchModel, _repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, categoryID, "UNLIMITED",_repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, categoryID, "UNLIMITED",_repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = true;
            }
            else
            {
                Logger.Debug("SearchPage#1 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = categoryID;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = numberOfUsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

                int? selectedSupportHours = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,categoryID,this.CustomSession,_repository);

                int? selectedTimeZone = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone,categoryID,_repository);

                Logger.Debug("SearchPage#2 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel = ModelHelpers.GetSearchModelFiltersOneColumn(searchModel, false, true, this.CustomSession, _repository);

                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.ChosenCategoryID = categoryID;
                
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, categoryID, "UNLIMITED",_repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, categoryID, "UNLIMITED",_repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersApplicationFeaturesCollapsed = false;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = true;

                Logger.Debug("SearchPage#3 - " + DateTime.Now.TimeOfDay.ToString());
                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(searchModel).ToList().OrderBy(x => x.VendorName);
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["UseWeighting"]))
                {
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger)
                        //.OrderBy(x => x.SearchResultWeighting).ToList()
                        ;
                }
                else
                {
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger).OrderBy(x => x.VendorName).ToList();
                }

                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, searchModel, _repository);

                Logger.Debug("SearchPage#4 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
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

                        OperatingSystems = x.OperatingSystems,
                        Devices = x.Devices,
                        SupportTypes = x.SupportTypes,
                        SupportDays = x.SupportDays,
                        Languages = x.Languages,
                        CloudApplicationFeatures = x.CloudApplicationFeatures,
                        SupportHours = x.SupportHours,
                        Currency = new CurrencyModel()
                        {
                            CurrencyID = x.Currency.CurrencyID,
                            CurrencyName = x.Currency.CurrencyName,
                            CurrencyShortName = x.Currency.CurrencyShortName,
                            CurrencySymbol = x.Currency.CurrencySymbol,
                            ExchangeRateSterling = x.Currency.ExchangeRateSterling,
                            UseExchangeRateForSorting = x.Currency.UseExchangeRateForSorting,
                        }

                    })
                    .ToList()
                    ;

                searchModel.ContainerModel.SearchResultsModel.TestValue = "TEST";
                searchModel.ContainerModel.CustomSession = CustomSession;
                searchModel.ContainerModel.SearchResultsModel.CustomSession = CustomSession;

                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchFiltersOperatingSystems =
                //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems;
                //searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchResults =
                //    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;

                //ViewBag.SearchFilters = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn;
                //ViewBag.SearchResults = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
                //ViewBag.SearchResultsSummary = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;

                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage =
                //    (PagedList.IPagedList<SearchResultModelOneColumn>)searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
            }
            Logger.Debug("SearchPage#5 - " + DateTime.Now.TimeOfDay.ToString());
            ModelHelpers.SetSearchResultsSortOrder(null, null, searchModel);
            ModelHelpers.PaginateSearchResults(searchModel, 1);

            //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage
            ModelHelpers.FixUpViewData(searchModel,this);
            //ViewData["SearchResults"] = ViewBag.SearchResults;
            //ViewData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;

            //TempData["SearchFilters"] = ViewBag.SearchFilters;
            //TempData["SearchResults"] = ViewBag.SearchResults;
            //TempData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;

            ViewBag.NameSortParm = "Vendor desc";
            ViewBag.VisibleResultsTab = 1;

            searchModel.CustomSession.HasSearchResults = true;

            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

            ModelHelpers.LogSearchResultModelSiteAnalytic(searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage,categoryID,_siteAnalyticsLogger,this.CustomSession,_repository);
            return View("SearchPage", searchModel);
        }
        #endregion

        #region SearchPagePartial
        [SessionExpireFilter]
        public ActionResult SearchPagePartial(int categoryID, int numberOfUsers, bool useCachedData)
        {
            CustomSession.SelectedCategoryID = categoryID;
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            SearchPageModel searchModel = new SearchPageModel(CustomSession);

            if (useCachedData)
            {
                ModelHelpers.GetModelFromViewData(searchModel, this);

                if (searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn == null)
                {
                    return RedirectToAction("HomePage");
                }

                categoryID = (int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, searchModel, _repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, categoryID, "UNLIMITED", _repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, categoryID, "UNLIMITED", _repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = true;
            }
            else
            {
                Logger.Debug("SearchPage#1 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = categoryID;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession, _repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = numberOfUsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

                int? selectedSupportHours = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours, categoryID, this.CustomSession, _repository);

                int? selectedTimeZone = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone, categoryID, _repository);

                Logger.Debug("SearchPage#2 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel = ModelHelpers.GetSearchModelFiltersOneColumn(searchModel, false, true, this.CustomSession, _repository);

                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.ChosenCategoryID = categoryID;

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, categoryID, "UNLIMITED", _repository);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, categoryID, "UNLIMITED", _repository);

                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersApplicationFeaturesCollapsed = false;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = true;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = true;

                Logger.Debug("SearchPage#3 - " + DateTime.Now.TimeOfDay.ToString());
                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(searchModel).ToList().OrderBy(x => x.VendorName);
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["UseWeighting"]))
                {
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger)
                        //.OrderBy(x => x.SearchResultWeighting).ToList()
                        ;
                }
                else
                {
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger).OrderBy(x => x.VendorName).ToList();
                }

                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, searchModel, _repository);

                Logger.Debug("SearchPage#4 - " + DateTime.Now.TimeOfDay.ToString());
                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
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

                        OperatingSystems = x.OperatingSystems,
                        Devices = x.Devices,
                        SupportTypes = x.SupportTypes,
                        SupportDays = x.SupportDays,
                        Languages = x.Languages,
                        CloudApplicationFeatures = x.CloudApplicationFeatures,
                        SupportHours = x.SupportHours,
                        Currency = new CurrencyModel()
                        {
                            CurrencyID = x.Currency.CurrencyID,
                            CurrencyName = x.Currency.CurrencyName,
                            CurrencyShortName = x.Currency.CurrencyShortName,
                            CurrencySymbol = x.Currency.CurrencySymbol,
                            ExchangeRateSterling = x.Currency.ExchangeRateSterling,
                            UseExchangeRateForSorting = x.Currency.UseExchangeRateForSorting,
                        }

                    })
                    .ToList()
                    ;

                searchModel.ContainerModel.SearchResultsModel.TestValue = "TEST";
                searchModel.ContainerModel.CustomSession = CustomSession;
                searchModel.ContainerModel.SearchResultsModel.CustomSession = CustomSession;

                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchFiltersOperatingSystems =
                //    searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems;
                //searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchResults =
                //    searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;

                //ViewBag.SearchFilters = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn;
                //ViewBag.SearchResults = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
                //ViewBag.SearchResultsSummary = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;

                //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage =
                //    (PagedList.IPagedList<SearchResultModelOneColumn>)searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
            }
            Logger.Debug("SearchPage#5 - " + DateTime.Now.TimeOfDay.ToString());
            ModelHelpers.SetSearchResultsSortOrder(null, null, searchModel);
            ModelHelpers.PaginateSearchResults(searchModel, 1);

            //searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage
            ModelHelpers.FixUpViewData(searchModel, this);
            //ViewData["SearchResults"] = ViewBag.SearchResults;
            //ViewData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;

            //TempData["SearchFilters"] = ViewBag.SearchFilters;
            //TempData["SearchResults"] = ViewBag.SearchResults;
            //TempData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;

            ViewBag.NameSortParm = "Vendor desc";
            ViewBag.VisibleResultsTab = 1;

            searchModel.CustomSession.HasSearchResults = true;

            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

            ModelHelpers.LogSearchResultModelSiteAnalytic(searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, categoryID, _siteAnalyticsLogger, this.CustomSession, _repository);
            //return View("SearchPage", searchModel);
            return PartialView("SearchPagePartial", searchModel);
        }
        #endregion

        #region SearchPage POST
        [HttpPost]
        public ActionResult SearchPage(SearchPageModel model, FormCollection formCollection, string sortOrder, int? categoryID, int? numberOfUsers, bool? useCachedData)
        {
            CustomSession.SelectedCategoryID = categoryID;

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Vendor desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "Date desc" : "Date";

            //PROCEED_BUTTON_APPLICATION_ID_

            var oldCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
            var newCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;

            model.CustomSession = CustomSession;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);

            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

            int? selectedSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,newCategory, this.CustomSession, _repository);

            int? selectedTimeZone = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone, newCategory,_repository);


            #region WHICH BUTTON WAS PRESSED
            var proceedButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("PROCEED_BUTTON_APPLICATION_ID_"))
                //.SingleOrDefault()
                ;

            var moreInfoButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("MOREINFO_BUTTON_APPLICATION_ID_"))
                //.SingleOrDefault()
                ;

            var filterButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("FILTER_TYPE_"))
                //.SingleOrDefault()
                ;

            var filterHeaderButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("FILTER_HEADER_"))
                //.SingleOrDefault()
                ;

            var toggleSearchResultsButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("TOGGLERESULTS_BUTTON"))
                //.SingleOrDefault()
                ;

            var noScriptFilterRefreshButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("noScriptFilterRefresh"))
                //.SingleOrDefault()
                ;
            #endregion

            if (toggleSearchResultsButtonPressed.Count() > 0)
            {
                #region TOGGLE SEARCH RESULTS
                ModelHelpers.GetModelFromViewData(model,this);
                ModelState.Clear();
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = !model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
                ModelHelpers.FixUpViewData(model,this);
                #endregion
                return View(model);
            }

            if (filterHeaderButtonPressed.Count() > 0)
            {
                #region FILTER HEADER BUTTON PRESSED
                ModelHelpers.GetModelFromViewData(model, this);
                ModelState.Clear();
                var pressedButton = filterHeaderButtonPressed.ElementAt(0);
                string[] filterAttributes = pressedButton.ToString().Split(';');
                string filterHeader = filterAttributes[0].Replace("FILTER_HEADER_", "").Replace(".x", "").Replace(".y", "");

                switch (filterHeader)
                {
                    case FILTER_CATEGORIES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed;
                        break;
                    case FILTER_USERS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed;
                        break;
                    case FILTER_BROWSERS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed;
                        break;
                    case FILTER_FEATURES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed;
                        break;
                    case FILTER_LANGUAGES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed;
                        break;
                    case FILTER_MOBILEPLATFORMS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed;
                        break;
                    case FILTER_OPERATINGSYSTEMS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed;
                        break;
                    case FILTER_SUPPORTDAYS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed;
                        break;
                    case FILTER_SUPPORTHOURS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed;
                        break;
                    case FILTER_SUPPORTTYPES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed;
                        break;
                    case FILTER_TIMEZONES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed;
                        break;

                }
                #endregion
                ModelHelpers.FixUpViewData(model,this);
                return View(model);
            }

            else if (filterButtonPressed.Count() > 0)
            {
                ModelHelpers.GetModelFromViewData(model, this);

                #region FILTER BUTTON PRESSED
                var pressedButton = filterButtonPressed.ElementAt(0);
                string[] filterAttributes = pressedButton.ToString().Split(';');
                int filterID = int.Parse(filterAttributes[1].Replace("FILTER_ID_", "").Replace(".x", "").Replace(".y", ""));
                string filterType = filterAttributes[0].Replace("FILTER_TYPE_", "").Replace(".x", "").Replace(".y", "");
                int checkedFilter;

                switch (filterType)
                {
                    case FILTER_BROWSERS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_FEATURES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_LANGUAGES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_MOBILEPLATFORMS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_OPERATINGSYSTEMS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_DEVICES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTDAYS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTHOURS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTTYPES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected);
                        break;

                }
                #endregion

                #region via the filter button
                model = ModelHelpers.RequerySearchResults(model,oldCategory,newCategory,this.CustomSession,_repository,Logger,_siteAnalyticsLogger,this);
                ModelState.Remove("");

                ViewBag.NameSortParm = "Vendor desc";
                ViewBag.VisibleResultsTab = 1;

                return View(model);
                #endregion
            }

            else if (proceedButtonPressed.Count() > 0)
            {
                ModelHelpers.GetModelFromViewData(model, this);

                //CloudApplicationModel cam = null;
                #region PROCEED BUTTON PRESSED
                if (proceedButtonPressed.Count() > 3)
                {
                    throw new Exception("Internal server error");
                }
                else
                {
                    var pressedButton = proceedButtonPressed.ElementAt(0);
                    int cloudApplicationID = int.Parse(pressedButton.Replace("PROCEED_BUTTON_APPLICATION_ID_", "").Replace(".x", "").Replace(".y", ""));

                    string shopURL = _repository.GetShopURL(cloudApplicationID);
                    //var shopURLParams = shopURL.Split(new Char[] {'/'},2);
                    string categoryPart = shopURL.Substring(0, shopURL.IndexOf("/"));
                    string shopPart = shopURL.Substring(shopURL.IndexOf("/")+1);


            //@{href = Model.CloudApplicationCategoryTag + "/" + Model.CloudApplicationShopTag ;}
                    //return RedirectToAction("Shop", new { theCategory = categoryPart, theShop = shopPart });

                    EMailCloudApplicationModel ecam = new EMailCloudApplicationModel(CustomSession)
                    {
                        CloudApplicationID = cloudApplicationID,
                        CloudApplicationURL = shopURL,
                        EMailAddress = CustomSession.EMail,
                    };

                    return RedirectToRoute("TakingToSelectionWithPrompt", ecam);
                    return RedirectToRoute("Shop", new { category = categoryPart, shop = shopPart, cloudApplicationID = cloudApplicationID });
                    return RedirectToAction("Shop", new { category = categoryPart, shop = shopPart, cloudApplicationID = cloudApplicationID });

                    //CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID);
                    //IList<CloudApplication> alternatives = _repository.GetCloudApplicationsByVendor(ca.Vendor.VendorID);
                    //cam = ConstructCloudApplicationModel(ca,alternatives);
                }
                #endregion

                //model.ContainerModel.ChosenCloudApplicationModel = cam;
                //FixUpViewData(model);

                ////return ForceDisplayTemplateViewFor(cam);

                //return View("CloudApplicationModel", model.ContainerModel.ChosenCloudApplicationModel);

            }

            else if (moreInfoButtonPressed.Count() > 0)
            {
                #region MORE INFO BUTTON PRESS
                ModelState.Clear();
                var pressedButton = moreInfoButtonPressed.ElementAt(0);
                string buttonApplicationID = pressedButton.ToString().Replace("MOREINFO_BUTTON_APPLICATION_ID_", "").Replace(".x", "").Replace(".y", "");

                ModelHelpers.GetModelFromViewData(model, this);
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = (IEnumerable<SearchResultModelOneColumn>)TempData["SearchResults"];
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = (IEnumerable<SearchResultSummaryModel>)TempData["SearchResultsSummary"];

                int searchResultIndex = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList().FindIndex(x => x.CloudApplicationID.ToString() == buttonApplicationID);
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList()[searchResultIndex].MoreInfoVisible
                    = !(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList()[searchResultIndex].MoreInfoVisible);

                ModelHelpers.FixUpViewData(model,this);
                //TempData["SearchResults"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
                //TempData["SearchResultsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;
                #endregion
                return View(model);
            }

            else if (noScriptFilterRefreshButtonPressed.Count() > 0)
            {
                model = ModelHelpers.RequerySearchResults(model, oldCategory, newCategory, this.CustomSession, _repository, Logger, _siteAnalyticsLogger,this);
                ViewBag.NameSortParm = "Vendor desc";
                ViewBag.VisibleResultsTab = 1;
                return View("SearchPage", model);
            }

            else
            {
                ModelHelpers.GetModelFromViewData(model, this);
                ModelHelpers.FixUpViewData(model, this);
                return View("SearchPage", model);
            }

        }
        #endregion


        #region TakeToSelection
        public ActionResult TakeToSelection(int cloudApplicationID)
        {
            string shopURL = _repository.GetShopURL(cloudApplicationID);
            string categoryPart = shopURL.Substring(0, shopURL.IndexOf("/"));
            string shopPart = shopURL.Substring(shopURL.IndexOf("/") + 1);

            EMailCloudApplicationModel ecam = new EMailCloudApplicationModel(CustomSession)
            {
                CloudApplicationID = cloudApplicationID,
                CloudApplicationURL = shopURL,
                EMailAddress = CustomSession.EMail,
            };
            return View("TakingToSelectionWithPrompt", ecam);
        }
        #endregion



        #region TakingToSelectionWithPrompt
        public ActionResult TakingToSelectionWithPrompt(EMailCloudApplicationModel eMailCloudApplicationModel)
        {
            return View("TakingToSelectionWithPrompt", eMailCloudApplicationModel);
        }
        #endregion

        #region GetNextSearchResultsPage
        public ActionResult GetNextSearchResultsPage(SearchPageModel searchModel, FormCollection formCollection, int page)
        {

            bool displayAsSummary = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
            ModelHelpers.GetModelFromViewData(searchModel, this);
            //var test = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Where(x => x.VendorName.ToUpper() == "RINGCENTRAL");
            int categoryID = (int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = displayAsSummary;
            ModelHelpers.SetSearchResultsColumnHeaders(categoryID, searchModel, _repository);
            ModelHelpers.PaginateSearchResults(searchModel, page);
            ModelHelpers.FixUpViewData(searchModel, this);
            //return View("SearchPage", searchModel);

            //var test2 = searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Where(x => x.VendorName.ToUpper() == "RINGCENTRAL");

            ModelHelpers.LogSearchResultModelSiteAnalytic(searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, categoryID, _siteAnalyticsLogger, this.CustomSession, _repository);
            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

            return PartialView("SearchResultsModel", searchModel);

        }

        public ActionResult GetNextGlobalSearchResultsPage(GlobalSearchPageModel searchModel, FormCollection formCollection, int page)
        {
            ModelHelpers.GetModelFromViewData(searchModel, this);
            ModelHelpers.PaginateSearchResults(searchModel, page);
            ModelHelpers.FixUpViewData(searchModel,this);
            //return View("SearchPage", searchModel);
            return PartialView("GlobalSearchResultsModel", searchModel);

        }
        #endregion



        #region TestJSON
        [HttpPost]
        public ActionResult TestJSON(SearchPageModel model)
        {
            TempData["x"] = 0;
            //var viewModel = new JavaScriptSerializer().Deserialize<SearchPageModel>(model);
            return View();
        }
        #endregion

        #region SearchResultsPartial POST
        [HttpPost]
        public ActionResult SearchResultsPartial(SearchPageModel model, FormCollection formCollection, string sortColumn, string currentSortOrder)
        //public ActionResult SearchResultsPartial(SearchPageModel model, FormCollection formCollection)
        {
            //string sortColumn = null;
            //string currentSortOrder = null;

            //PROCEED_BUTTON_APPLICATION_ID_

            //var oldCategory = model.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
            //var newCategory = model.SearchFiltersModelOneColumn.ChosenCategoryID;

            if (sortColumn == null)
            {
                var textButton = formCollection
                    .Keys
                    .OfType<string>()
                    .Where(x => x.StartsWith("PROCEED_BUTTON_APPLICATION_ID_"))
                    //.SingleOrDefault()
                    ;

                if (textButton.Count() == 0)
                {
                    #region via the filter button
                    //must have come in via the filter button
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);

                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

                    int? selectedSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours, model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, this.CustomSession, _repository);

                    int? selectedTimeZone = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone,model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID,_repository);
                    
                    model.CustomSession = CustomSession;
                    //model.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

                    //SearchModel newModel = new SearchModel();
                    //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
                    //newModel.SearchFiltersModel.Categories = this.GetCategories();
                    //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
                    //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

                    //newModel = this.GetSearchModel(newModel);
                    //if (oldCategory != newCategory)
                    //{
                    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                    //    model = this.GetSearchModelFiltersOneColumn(model, true);
                    //}

                    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(model,this.CustomSession, _repository, Logger, _siteAnalyticsLogger).ToList();
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
                        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                        ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,
                        ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
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

                    ModelHelpers.SetSearchResultsSortOrder(sortColumn, currentSortOrder, model);
                    ModelHelpers.SetSearchResultsColumnHeaders((int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, model, _repository);
                    ModelHelpers.PaginateSearchResults(model, 1);

                    ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, _siteAnalyticsLogger, this.CustomSession, _repository);
                    ModelHelpers.FixUpViewData(model,this);
                    #endregion
                }
                else
                {
                    #region via the proceed button

                    if (textButton.Count() > 2)
                    {
                        throw new Exception("Internal server error");
                    }
                    else
                    {
                        var pressedButton = textButton.ElementAt(0);
                        int cloudApplicationID = int.Parse(pressedButton.Replace("PROCEED_BUTTON_APPLICATION_ID_", "").Replace(".x", "").Replace(".y", ""));

                        CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID,true);
                        IList<CloudApplication> alternatives = _repository.GetCloudApplicationsByVendor(ca.Vendor.VendorID,ca.Category.CategoryID,true);
                        CloudApplicationModel cam = ModelHelpers.ConstructCloudApplicationModel(ca,alternatives,this.CustomSession,_repository,Logger,Request);
                        
                        return ForceDisplayTemplateViewFor(cam);
                    }
                    #endregion
                }
            }
            else
            {
                #region via the sort columns
                bool displayAsSummary = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
                ModelHelpers.GetModelFromViewData(model, this);
                //bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                ModelState.Clear();
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = displayAsSummary;

                model.ContainerModel.SearchFiltersModel.DisplayAsSummary = displayAsSummary;

                //var test =
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults
                //.Where(x => x.ServiceName.ToUpper().StartsWith("BUSINESS PREMIER")
                //|| x.ServiceName.ToUpper().StartsWith("MOZY ENTERPRISE")
                ////|| x.ServiceName.ToUpper().StartsWith("HOME PLUS")
                //|| x.ServiceName.ToUpper().StartsWith("HOME")
                //)
                //.ToList();

                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = test;

                ModelHelpers.SetSearchResultsSortOrder(sortColumn, currentSortOrder, model);
                ModelHelpers.PaginateSearchResults(model, 1);
                ModelHelpers.FixUpViewData(model,this);

                ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, _siteAnalyticsLogger, this.CustomSession, _repository);

                #endregion
            }

            //return View(newModel);
            //bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
            //ModelState.Clear();

            //var test = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Where(x => x.VendorName.ToUpper() == "RINGCENTRAL");

            return PartialView("SearchResultsModel", model);

        }
    
        #endregion



        #region SearchFiltersPartial POST
        [HttpPost]
        public ActionResult SearchFiltersPartial(SearchPageModel model, FormCollection formCollection, bool refreshResults, string sortColumn, string currentSortOrder)
        {
            //PROCEED_BUTTON_APPLICATION_ID_

            var oldCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
            var newCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;

            var textButton = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("PROCEED_BUTTON_APPLICATION_ID_"))
                //.SingleOrDefault()
                ;

            if (textButton.Count() == 0)
            {
                #region via the filter button
                //must have come in via the filter button
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

                int? selectedSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,newCategory,this.CustomSession,_repository);
                
                int? selectedTimezone = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimezone,newCategory,_repository);

                //SearchModel newModel = new SearchModel();
                //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
                //newModel.SearchFiltersModel.Categories = this.GetCategories();
                //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
                //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

                //newModel = this.GetSearchModel(newModel);
                if (oldCategory != newCategory)
                {
                    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                    //IMPORTANT!!
                    //model = this.GetSearchModelFiltersOneColumn(model, true, true);
                    model = ModelHelpers.GetSearchModelFiltersOneColumn(model, false, true,this.CustomSession,_repository);
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, "UNLIMITED",_repository);
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, (int)newCategory, "UNLIMITED",_repository);
                    ModelHelpers.SetSearchResultsColumnHeaders((int)newCategory, model,_repository);
                }
                else
                {
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, null,_repository);
                    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, (int)newCategory, null,_repository);
                }


                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(model,this.CustomSession, _repository, Logger, _siteAnalyticsLogger).ToList();
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
        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
        ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,
        ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
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


                ModelHelpers.SetSearchResultsSortOrder(sortColumn, currentSortOrder, model);
                ModelHelpers.PaginateSearchResults(model, 1);
                ModelHelpers.GetAdvertisingImages(model, this.CustomSession, _repository);

                ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)newCategory, _siteAnalyticsLogger, this.CustomSession, _repository);

                ModelHelpers.FixUpViewData(model,this);
                //return View(newModel);
                bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                ModelState.Clear();

                if (Convert.ToBoolean(refreshResults))
                {
                    return PartialView("SearchPageContainerModel", model);
                }
                else
                {
                    return PartialView("SearchFiltersModel", model);
                }
                #endregion
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region SearchPageNoScript POST
        //[HttpPost]
        public ActionResult SearchPageNoScript(SearchPageModel model, FormCollection formCollection, string dummyValue, string sortColumn, string currentSortOrder, int? page, int? categoryID)
        //public ActionResult SearchPageNoScript(int dummyValue)
        {
            CustomSession.SelectedCategoryID = categoryID;

            //PROCEED_BUTTON_APPLICATION_ID_


            //var proceedButtonPressed = formCollection
            //    .Keys
            //    .OfType<string>()
            //    .Where(x => x.StartsWith("PROCEED_BUTTON_APPLICATION_ID_"))
            //    //.SingleOrDefault()
            //    ;

            //var moreInfoButtonPressed = formCollection
            //    .Keys
            //    .OfType<string>()
            //    .Where(x => x.StartsWith("MOREINFO_BUTTON_APPLICATION_ID_"))
            //    //.SingleOrDefault()
            //    ;

            //var filterButtonPressed = formCollection
            //    .Keys
            //    .OfType<string>()
            //    .Where(x => x.StartsWith("FILTER_TYPE_"))
            //    //.SingleOrDefault()
            //    ;

            //var filterHeaderButtonPressed = formCollection
            //    .Keys
            //    .OfType<string>()
            //    .Where(x => x.StartsWith("FILTER_HEADER_"))
            //    //.SingleOrDefault()
            //    ;

            if (model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID == null)
            {
                return RedirectToAction("HomePage");
            }

            if (page != null)
            {
                bool displayAsSummary = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;

                ModelHelpers.GetModelFromViewData(model, this);
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = displayAsSummary;
                ModelHelpers.PaginateSearchResults(model, (int)page);
                ModelHelpers.SetSearchResultsColumnHeaders((int)categoryID, model,_repository);
                ModelHelpers.FixUpViewData(model,this);

                ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)categoryID, _siteAnalyticsLogger, this.CustomSession, _repository);
                return View("SearchPage", model);
            }

            if (sortColumn != null)
            {

                #region via the sort columns
                //bool displayAsSummary = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
                ModelHelpers.GetModelFromViewData(model, this);
                //bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                ModelState.Clear();
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = displayAsSummary;
                ModelHelpers.SetSearchResultsSortOrder(sortColumn, currentSortOrder, model);
                ModelHelpers.PaginateSearchResults(model, 1);
                ModelHelpers.SetSearchResultsColumnHeaders((int)categoryID, model, _repository);
                ModelHelpers.FixUpViewData(model,this);

                ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)categoryID, _siteAnalyticsLogger, this.CustomSession, _repository);
                
                return View("SearchPage", model);

                #endregion


            }

            if (dummyValue != null)
            {
                ModelHelpers.GetModelFromViewData(model, this);

                var oldCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
                var newCategory = categoryID;

                #region FILTER BUTTON PRESSED
                string[] filterAttributes = dummyValue.ToString().Split(';');
                int filterID = int.Parse(filterAttributes[1].Replace("FILTER_ID_", "").Replace(".x", "").Replace(".y", ""));
                string filterType = filterAttributes[0].Replace("FILTER_TYPE_", "").Replace(".x", "").Replace(".y", "");
                int checkedFilter;

                switch (filterType)
                {
                    case FILTER_BROWSERS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_FEATURES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ElementAt(checkedFilter).Col1Selected
                            = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures.ElementAt(checkedFilter).Col1Selected);
                        //= true;
                        break;
                    case FILTER_LANGUAGES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_MOBILEPLATFORMS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_OPERATINGSYSTEMS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_DEVICES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersDevices.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTDAYS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTHOURS:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected);
                        break;
                    case FILTER_SUPPORTTYPES:
                        checkedFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ToList().FindIndex(x => x.SearchFilterID == filterID);
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ToList()[checkedFilter].Col1Selected = !(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ToList()[checkedFilter].Col1Selected);
                        break;

                }
                #endregion

                //if (oldCategory != newCategory)
                //{
                //    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                //    model = this.GetSearchModelFiltersOneColumn(model, true, true);
                //    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, "UNLIMITED");
                //    SetSearchResultsColumnHeaders((int)newCategory, model);
                //}
                //else
                //{
                //    model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = SetComboOptionsFromApplicationFeature(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)newCategory, null);
                //}

                #region via the filter button
                //must have come in via the filter button
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);
                //model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

                int? selectedSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,newCategory,this.CustomSession,_repository);

                int? selectedTimeZone = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetSupportHours(selectedTimeZone, newCategory, this.CustomSession,_repository);

                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(model,this.CustomSession, _repository, Logger, _siteAnalyticsLogger).ToList();
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
                        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                        ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,
                        ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
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
                            UseExchangeRateForSorting = x.Currency.UseExchangeRateForSorting
                        }
                    }).ToList();

                model.CustomSession = CustomSession;
                ModelHelpers.PaginateSearchResults(model, 1);
                ModelHelpers.FixUpViewData(model,this);

                ModelHelpers.LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)oldCategory, _siteAnalyticsLogger, this.CustomSession, _repository);

                return View("SearchPage", model);
                #endregion
            }

            return View("SearchPage", model);

        }
        #endregion

        #region GlobalSearchPageNoScript POST
        //[HttpPost]
        public ActionResult GlobalSearchPageNoScript(GlobalSearchPageModel model, FormCollection formCollection, string dummyValue, string sortColumn, string currentSortOrder, int? page, int? categoryID, string term)
        //public ActionResult SearchPageNoScript(int dummyValue)
        {

            if (page != null)
            {

                ModelHelpers.GetModelFromViewData(model, this);

                if (model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn == null)
                {
                    ModelHelpers.SetSessionVariables(Request,this.CustomSession);
                    bool liveApplicationsOnly = true;
                    GlobalSearchPageModel searchModel = new GlobalSearchPageModel(CustomSession);
                    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn = new GlobalSearchResultsModelOneColumn(CustomSession);

                    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                        ModelHelpers.ConvertGlobalSearchResults(_repository.GetSearchResultsFromTags(term, liveApplicationsOnly));

                    searchModel.ContainerModel.SearchResultsModel.TestValue = "TEST";
                    searchModel.ContainerModel.CustomSession = CustomSession;
                    searchModel.ContainerModel.SearchResultsModel.CustomSession = CustomSession;
                    searchModel.ContainerModel.SearchResultsModel.Term = term;
                }

                ModelHelpers.PaginateSearchResults(model, (int)page);
                ModelHelpers.FixUpViewData(model,this);
                model.ContainerModel.SearchResultsModel.Term = term;

                //LogSearchResultModelSiteAnalytic(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, (int)categoryID);
                return View("GlobalSearchPage", model);
            }

            return View("GlobalSearchPage", model);

        }
        #endregion

        #region CloudApplication
        [SessionExpireFilter]
        public ActionResult CloudApplication(int cloudApplicationID, string term, bool? showUserReviewConfirmation)
        {
            bool DUMMY_VX_MODE = CustomSession.DummyVXMode;
            if (DUMMY_VX_MODE)
            {
                //int id = cloudApplicationID;
                return RedirectToAction("IndexCustom", "Vendor", new { cloudApplicationID = cloudApplicationID });
            }

            var model = ModelHelpers.GetCloudApplicationModel(cloudApplicationID,term,showUserReviewConfirmation,this.CustomSession,_repository,Logger,_siteAnalyticsLogger,this,Request);

            Logger.Debug("Getting cloud application : " + cloudApplicationID.ToString() + " step #6");
            bool testPDF = Convert.ToBoolean(ConfigurationManager.AppSettings["TestPDFMode"]);
            if (!testPDF)
            {
                return View("CloudApplicationModel", model);
            }
            else
            {
                model.ContainerModel.ChosenCloudApplicationModel.CustomSession.Forename = "Glyn";
                model.ContainerModel.ChosenCloudApplicationModel.CustomSession.Surname = "Threadgold";
                //return View("PrintResult3", model.ContainerModel.ChosenCloudApplicationModel);
                //return RedirectToAction("PrintResult3", "Admin", new { cloudApplicationID = cloudApplicationID });
                //return null;
                return View("PrintResult3", model);
                //return View("ShopPDFPage2", model);
            }

        }
        #endregion

        #region BackToSearchResults
        //[HttpPost]
        public ActionResult BackToSearchResults(SearchPageModel model, FormCollection formCollection)
        {

            return RedirectToAction("SearchPage", new { categoryID = 1, numberOfUsers = 1, useCachedData = true });
        }
        #endregion

        #region CloudApplication POST
        [HttpPost]
        public ActionResult CloudApplication(SearchPageModel model, FormCollection formCollection, int cloudApplicationID)
        {
            CustomSession.Forename = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename;
            CustomSession.Surname = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname;
            CustomSession.EMail = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress;
            CustomSession.Company = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company;
            CustomSession.Telephone = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone;
            CustomSession.NumberOfUsers = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees;

            model.CustomSession = CustomSession;

            int categoryID = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CategoryID;
            
            var emailButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("EMAIL_BUTTON"))
                //.SingleOrDefault()
                ;

            var backResultsButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("BACKRESULTS_BUTTON"))
                //.SingleOrDefault()
                ;

            var applicationRequestButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("APPLICATIONREQUEST_BUTTON"))
                //.SingleOrDefault()
                ;

            var createrReviewButtonPressed = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("CREATEREVIEW_BUTTON"))
                //.Where(x => x.StartsWith("APPLICATIONRATING_BUTTON"))
                //.SingleOrDefault()
                ;

            if (backResultsButtonPressed.Count() > 0)
            {
                return RedirectToAction("SearchPage", new { categoryID = categoryID, numberOfUsers = 1, useCachedData = true });
            }

            if (emailButtonPressed.Count() > 0)
            {
                if (!model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.TermsAndConditions)
                {
                    //ModelState.Clear();
                    //ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID"] = null;
                    ModelState.Remove("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID");
                    ModelHelpers.GetModelFromViewData(model, this);
                    model.ShowConfirmationDialog = true;
                    model.ConfirmationDialogTitle = "Terms & Conditions";
                    model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID = 3;
                    ModelHelpers.FixUpViewData(model,this);
                    return View("CloudApplicationModel", model);
                }

                if (ModelState.IsValid)
                {
                    EmailApplicationRequest(model);
                    ModelHelpers.GetModelFromViewData(model, this);
                    model.ShowConfirmationDialog = true;
                    model.ConfirmationDialogTitle = "Email application complete";
                    model.ConfirmationDialogMessage1 = "Thank you, an EMail has just been sent to your address.";
                    model.ConfirmationDialogMessage2 = "When you're ready to register for your FREE trial or place an order, simply complete the details in the blue registration panel on the right.";
                    ModelHelpers.FixUpViewData(model,this);
                    return View("CloudApplicationModel", model);
                }
                else
                {
                    if (ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename"].Errors.Count > 0 || model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename == ViewModelHelpers.FORENAME_ERROR_MESSAGE)
                    {
                        ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename"].Value = new ValueProviderResult(ViewModelHelpers.FORENAME_ERROR_MESSAGE, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename, System.Globalization.CultureInfo.CurrentCulture);
                        ModelState.AddModelError("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename", "www");
                    }
                    if (ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress"].Errors.Count > 0)
                    {
                        if (model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress == ViewModelHelpers.EMAIL_ERROR_MESSAGE || model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress == null)
                        {
                            ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress"].Value = new ValueProviderResult(ViewModelHelpers.EMAIL_ERROR_MESSAGE, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress, System.Globalization.CultureInfo.CurrentCulture);
                        }
                        ModelState.AddModelError("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress", "www");
                    }

                    //ModelState.Clear();
                    ModelState.Remove("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID");
                    ModelHelpers.GetModelFromViewData(model, this);
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID = 3;
                    ModelHelpers.FixUpViewData(model,this);
                    model.CustomSession = CustomSession;
                    return View("CloudApplicationModel", model);
                }

                
                
                
                
                //GetModelFromViewData(model);
                //model.ShowConfirmationDialog = true;
                //model.ConfirmationDialogTitle = "Email application complete";
                //model.ConfirmationDialogMessage1 = "Thank you, an EMail has just been sent to your address.";
                //model.ConfirmationDialogMessage2 = "When you're ready to register for your FREE trial or place an order, simply complete the details in the blue registration panel on the right.";
                //EmailApplicationRequest(model);
                //FixUpViewData(model);
            }

            if (applicationRequestButtonPressed.Count() > 0)
            {
                //FreeTrialBuyNowModel ftbn = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow;
                if (!model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.TermsAndConditions)
                {
                    ModelHelpers.GetModelFromViewData(model, this);
                    model.ShowConfirmationDialog = true;
                    model.ConfirmationDialogTitle = "Terms & Conditions";
                    model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
                    ModelHelpers.FixUpViewData(model,this);
                    return View("CloudApplicationModel", model);
                }

                if (ModelState.IsValid)
                {
                    //var applicationRequestInserted = InsertApplicationRequest(model);

                    FreeTrialBuyNowModel tempFreeTryBuyNowModel = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow;
                    ModelHelpers.GetModelFromViewData(model, this);
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow = tempFreeTryBuyNowModel;
                    //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypes = ModelHelpers.GetRequestTypes(this.CustomSession, _repository);
                    model.ShowConfirmationDialog = true;
                    if (model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID == 1)
                    {
                        model.ConfirmationDialogTitle = "FREE trial request complete";
                    }
                    else if (model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID == 2)
                    {
                        model.ConfirmationDialogTitle = "Buy now request complete";
                    }
                    else if (model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID == 3)
                    {
                        model.ConfirmationDialogTitle = "Email page request complete";
                    }

                    model.ConfirmationDialogMessage1 = "Thank you for your request. Somebody will be in touch with you shortly.";
                    ModelHelpers.FixUpViewData(model,this);
                    return View("CloudApplicationModel", model);
                }
                else
                {
                    if (ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename"].Errors.Count > 0 || model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename == ViewModelHelpers.FORENAME_ERROR_MESSAGE)
                    {
                        ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename"].Value = new ValueProviderResult(ViewModelHelpers.FORENAME_ERROR_MESSAGE, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename, System.Globalization.CultureInfo.CurrentCulture);
                        ModelState.AddModelError("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename", "www");
                    }
                    if (ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress"].Errors.Count > 0)
                    {
                        if (model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress == ViewModelHelpers.EMAIL_ERROR_MESSAGE || model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress == null)
                        {
                            ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress"].Value = new ValueProviderResult(ViewModelHelpers.EMAIL_ERROR_MESSAGE, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress, System.Globalization.CultureInfo.CurrentCulture);
                        }
                        ModelState.AddModelError("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress", "www");
                    }

                    ModelHelpers.GetModelFromViewData(model, this);
                    ModelHelpers.FixUpViewData(model, this);
                    return View("CloudApplicationModel", model);
                }
            }

            if (createrReviewButtonPressed.Count() > 0)
            {
                ModelHelpers.GetModelFromViewData(model, this);
                ModelHelpers.FixUpViewData(model, this);
                //return View("RatingReview", new CloudApplicationRatingModel(CustomSession));
                return RedirectToAction("UserReview");
            }
            

            return View("SearchPage", model);
        }
        #endregion

        #region UserReview
        [SessionExpireFilter]
        public ActionResult UserReview()
        {
            SearchPageModel model = new SearchPageModel(CustomSession);
            ModelHelpers.GetModelFromViewData(model, this);
            
            ModelHelpers.FixUpViewData(model,this);
            var cloudApplicationID = model.ContainerModel.ChosenCloudApplicationModel.CloudApplicationID;
            return View("UserReview", new CloudApplicationUserReviewModel(CustomSession) 
            { 
                CloudApplicationID = cloudApplicationID,
                Industries = ModelHelpers.GetIndustries(_repository),
                EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository),
            });
        }
        #endregion

        #region UserReview POST
        [HttpPost]
        public ActionResult UserReview(CloudApplicationUserReviewModel model)
        {
            //GetModelFromViewData(model);
            //FixUpViewData(model);

            if (!model.TermsAndConditions)
            {
                SearchPageModel searchModel = new SearchPageModel(CustomSession);
                ModelHelpers.GetModelFromViewData(searchModel, this);
                ModelHelpers.GetModelFromViewData(searchModel, this);
                model.ShowConfirmationDialog = true;
                model.ConfirmationDialogTitle = "Terms & Conditions";
                model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
                ModelHelpers.FixUpViewData(searchModel,this);

                model.Industries = ModelHelpers.GetIndustries(_repository);
                model.EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository);
                
                return View(model);
            }

            if (ModelState.IsValid)
            {
                CloudApplicationUserReview car = new CloudApplicationUserReview()
                {
                    CloudApplication = _repository.GetCloudApplication(model.CloudApplicationID,true),
                    CloudApplicationUserReviewEaseOfUse = model.CloudApplicationUserReviewEaseOfUse * 20,
                    CloudApplicationUserReviewFunctionality = model.CloudApplicationUserReviewFunctionality * 20,
                    CloudApplicationUserReviewOverallRating = model.CloudApplicationUserReviewOverallRating * 20,
                    CloudApplicationUserReviewCompany = model.CloudApplicationUserReviewCompany,
                    CloudApplicationUserReviewForename = model.CloudApplicationUserReviewForename,
                    CloudApplicationUserReviewSurname = model.CloudApplicationUserReviewSurname,
                    CloudApplicationUserReviewTitle = model.CloudApplicationUserReviewTitle,
                    CloudApplicationUserReviewText = model.CloudApplicationUserReviewText,
                    CloudApplicationUserReviewValueForMoney = model.CloudApplicationUserReviewValueForMoney * 20,
                    CloudApplicationUserReviewIndustry = _repository.GetIndustry(model.ChosenIndustryID),
                    CloudApplicationUserReviewEmployeeCount = model.ChosenEmployeeCount,
                    CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE"),
                    CloudApplicationUserReviewDate = DateTime.Now,
                    UniqueRowID = System.Guid.NewGuid(),

                };
                _repository.InsertUserReview(car);

                SearchPageModel searchModel = new SearchPageModel(CustomSession);
                ModelHelpers.GetModelFromViewData(searchModel, this);
                searchModel.ShowConfirmationDialog = true;
                searchModel.ConfirmationDialogTitle = "Rating review complete";
                searchModel.ConfirmationDialogMessage1 = "Thank you, your review has been registered with us.";
                ModelHelpers.FixUpViewData(searchModel,this);
                //return View("CloudApplicationModel", searchModel);
                
                //return RedirectToAction("CloudApplication", new { cloudApplicationID = model.CloudApplicationID, term = "", showUserReviewConfirmation = true });
                //return View("RatingReview", model);
                //return View(model);
                return null;
            }
            else
            {
                model.Industries = ModelHelpers.GetIndustries(_repository);
                model.EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository);

                SearchPageModel searchModel = new SearchPageModel(CustomSession);
                ModelHelpers.GetModelFromViewData(searchModel, this);
                ModelHelpers.FixUpViewData(searchModel, this);
                
                return View(model);
            }
        }
        #endregion

        [HttpPost]
        public ActionResult InsertApplicationRequestFreeTrial(FreeTrialBuyNowModel model)
        {
            return null;
        }

        #region InsertApplicationRequest POST
        [HttpPost]
        public ActionResult InsertApplicationRequest(SearchPageModel model, bool sendToColleague = false)
        //public ActionResult InsertApplicationRequest(FreeTrialBuyNowModel postModel, bool sendToColleague = false)
        {
            //SearchPageModel model = new SearchPageModel(CustomSession);
            //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow = postModel;

            //if (ModelState.IsValid)
            //{
                CloudApplicationRequest ar = new CloudApplicationRequest();

                Person p = null;

                var BuyNow = 2;
                var EMail = 7;
                var FreeTrial = 1;

                if (!sendToColleague)
                {
                    p = ModelHelpers.AddPerson(
                        PersonTypeEnum.User,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.JobTitle,
                        _repository
                        );

                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID =
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.FreeTrial ? FreeTrial : BuyNow;
                
                }
                else
                {
                    p = ModelHelpers.AddPerson(
                        PersonTypeEnum.Colleague,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname,
                        model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddressColleague,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company,
                        //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.JobTitle,
                        false,
                        _repository
                        );

                    ModelHelpers.AddColleagueLink(p, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress, _repository);

                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID = EMail;

                    ar.RequestData = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.MessageToColleague;



                }

                ar.PersonID = p.PersonID;
                ar.CloudApplicationID = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CloudApplicationID;
                
                
                //ar.EMail = true;
                //ar.FreeTrial = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.FreeTrial;
                //ar.BuyNow = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.BuyNow;

                ar.RequestTypeID = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID;

                bool retVal = _repository.Insert<CloudApplicationRequest>(ar);

                CustomSession.Forename = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename;
                CustomSession.Surname = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname;
                CustomSession.EMail = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress;
                CustomSession.Company = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company;
                CustomSession.Telephone = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone;
                CustomSession.NumberOfUsers = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees;
                CustomSession.PersonID = p.PersonID;

                switch (ar.RequestTypeID)
                {
                    case 1:
                        if (CustomSession.VisitedViaCategory)
                        {
                            //_siteAnalyticsLogger.Log(_repository, ActionType.TryFormSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.Category.CategoryID, CustomSession.PersonID);
                            _siteAnalyticsLogger.Log(_repository, ActionType.TryFormSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CategoryID, CustomSession.PersonID);
                        }
                        else
                        {
                            _siteAnalyticsLogger.Log(_repository, ActionType.TryFormSubmission, ar.CloudApplicationID, null, CustomSession.PersonID);
                        }
                        break;
                    case 2:
                        if (CustomSession.VisitedViaCategory)
                        {
                            //_siteAnalyticsLogger.Log(_repository, ActionType.BuyFormSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.Category.CategoryID, CustomSession.PersonID);
                            _siteAnalyticsLogger.Log(_repository, ActionType.BuyFormSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CategoryID, CustomSession.PersonID);
                        }
                        else
                        {
                            _siteAnalyticsLogger.Log(_repository, ActionType.BuyFormSubmission, ar.CloudApplicationID, null, CustomSession.PersonID);
                        }
                        break;
                    case 7:
                        if (CustomSession.VisitedViaCategory)
                        {
                            //_siteAnalyticsLogger.Log(_repository, ActionType.EMailSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.Category.CategoryID, CustomSession.PersonID);
                            _siteAnalyticsLogger.Log(_repository, ActionType.EMailSubmission, ar.CloudApplicationID, model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CategoryID, CustomSession.PersonID);
                        }
                        else
                        {
                            _siteAnalyticsLogger.Log(_repository, ActionType.EMailSubmission, ar.CloudApplicationID, null, CustomSession.PersonID);
                        }
                        break;

                }
                //return View("SearchPage", model);
            //}
            //else
            //{
            //    var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();

            //}
            return null;
            //return retVal;
        }
        #endregion

        #region EmailApplicationRequest
        [HttpPost]
        public ActionResult EmailApplicationRequest(SearchPageModel model)
        {
            //GetModelFromViewData(model);
            //SearchPageModel source = model;

            //ServiceReference1.CompareCloudwareServiceClient sc = new ServiceReference1.CompareCloudwareServiceClient();
            //ServiceReference1.CloudApplicationModel destination = new ServiceReference1.CloudApplicationModel();
            //CompareCloudware.Web.Plumbing.AutoMapObjects.MapSearchResultPDF(model.ContainerModel.ChosenCloudApplicationModel);
            //destination = AutoMapper.Mapper.Map<CloudApplicationModel, ServiceReference1.CloudApplicationModel>(model.ContainerModel.ChosenCloudApplicationModel);
            //ServiceReference1.AdditionalOutput ao = new ServiceReference1.AdditionalOutput();
            //ao.OutputFileName = "test.htm";
            //ao.PDFEngineType = ServiceReference1.PDFEngineType.ASPPDF;

            CloudApplicationRequest car = new CloudApplicationRequest();

            Person p = ModelHelpers.AddPerson(
                    PersonTypeEnum.Colleague,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company,
                    model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.JobTitle,
                    _repository
                );

            car.PersonID = p.PersonID;
            car.CloudApplicationID = model.ContainerModel.ChosenCloudApplicationModel.CloudApplicationSearchResultModel.CloudApplicationID;
            car.EMail = true;
            //car.FreeTrial = false;
            //car.BuyNow = false;
            //car.RequestTypeID = model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID;
            car.RequestTypeID = 3;
            bool retVal = _repository.Insert<CloudApplicationRequest>(car);

            //CloudApplicationModel localDestination;
            //localDestination = ConstructCloudApplicationModel(_repository.GetCloudApplication(car.CloudApplicationID),null);
            //AdditionalOutput localao = new AdditionalOutput();
            //localao.OutputFileName = "test.htm";
            //localao.PDFEngineType = PDFEngineType.ASPPDF;

            ////string x = sc.SendSearchResultToRAZORAndCreatePDF(destination, 1, "~/documents/", "test.pdf", true, ao);
            //string fileName = localDestination.ServiceName.Trim() + ".pdf";
            ////string x = SendSearchResultToRAZORAndCreatePDF(localDestination, 1, "~/documents/", fileName, true, localao);

            //MemoryStream y = SendSearchResultToRAZORAndReturnPDFStream(localDestination, 1, "~/documents/", fileName, true, localao);
            //byte[] b = y.ToArray();
            //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");
            ////System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
            //SendEmail sm = new SendEmail();
            //y.Position = 0;
            //sm.Execute(p, car, y, fileName);

            CustomSession.PersonID = p.PersonID;

            ModelHelpers.GetModelFromViewData(model, this);
            ModelHelpers.FixUpViewData(model, this);
            return null;
        }
        #endregion


        #region ForceDisplayTemplateViewFor
        protected ViewResult ForceDisplayTemplateViewFor(object model)
        {
            return View("ForceDisplayTemplate", model);
        }
        #endregion


        #region ShowImage
        public ActionResult ShowImage(int documentID)
        {
            CloudApplicationDocument td = _repository.GetCloudApplicationDocument(documentID);
            return File(td.CloudApplicationDocumentImage.CloudApplicationDocumentBytes, "image/jpg");
        }
        #endregion

        #region ShowAdvertisingImage
        public ActionResult ShowAdvertisingImage(int advertisingImageID)
        {
            advertisingImageID = new Random().Next(1, 11);
            //AdvertisingImage ai = _repository.GetAdvertisingImage(advertisingImageID,"MPU",true);
            AdvertisingImage ai = _repository.GetAdvertisingImage(advertisingImageID, "MPU", CustomSession.SelectedCategoryID, true);
            return File(ai.AdvertisingImageBytes, "image/jpg");
        }


        public ActionResult ShowMPU(int advertisingImageID)
        {
            //advertisingImageID = new Random().Next(12, 15);
            AdvertisingImage ai = null;
            //ai = _repository.GetAdvertisingImage(0, "MPU", CustomSession.SelectedCategoryID, true);
            ai = _repository.GetAdvertisingImage(advertisingImageID,null);
            return File(ai.AdvertisingImageBytes, "image/jpg");
        }

        public ActionResult ShowSkyScraper(int advertisingImageID)
        {
            //advertisingImageID = new Random().Next(12, 15);
            AdvertisingImage ai = null;
            //ai = _repository.GetAdvertisingImage(advertisingImageID, "SKYSCRAPER");
            //ai = _repository.GetAdvertisingImage(0, "SKYSCRAPER", CustomSession.SelectedCategoryID, true);
            ai = _repository.GetAdvertisingImage(advertisingImageID, null);
            return File(ai.AdvertisingImageBytes, "image/jpg");
        }
        #endregion

        #region ShowLogo
        public ActionResult ShowLogo(int vendorID)
        {
            Vendor v = _repository.FindVendorByID(vendorID);
            //return v.VendorLogo != null ? File(v.VendorLogo, "image/jpg") : null;
            //return v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null;
            return v.VendorLogo != null ? v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null : null;
        }
        #endregion

        #region ShowPortrait
        public ActionResult ShowPortrait(int contentTextID)
        {
            ContentText ct = _repository.FindContentTextByID(contentTextID);
            return ct.ContentTextGraphic != null ? File(ct.ContentTextGraphic, "image/jpg") : null;
        }
        #endregion

        #region RedirectShowDocument
        public ActionResult RedirectShowDocument(int documentID)
        {
            //Document td = _repository.GetCloudApplicationDocument(thumbnailDocumentID);
            CloudApplicationDocumentImage tdd = _repository.GetCloudApplicationDocumentImage(documentID);

            CloudApplicationDocument cad = _repository.GetCloudApplicationDocument(documentID);
            CloudApplicationDocumentType cadt = cad.CloudApplicationDocumentType;

            string contentType = cad.CloudApplicationDocumentFormat.CloudApplicationDocumentFormatURLHeaderName;
            //contentType = _repository.GetCloudApplicationDocument(documentID).CloudApplicationDocumentFormat.CloudApplicationDocumentFormatURLHeaderName;
            //td.DocumentURL = "http://www.bbc.co.uk";

            //string documentPath = null;
            //if (td.DocumentType.DocumentTypeName.ToUpper() == "CASE STUDY")
            //{
            //    documentPath = ConfigurationManager.AppSettings["CaseStudiesFolder"];
            //}
            //if (td.DocumentType.DocumentTypeName.ToUpper() == "WHITE PAPER")
            //{
            //    documentPath = ConfigurationManager.AppSettings["WhitePapersFolder"];
            //}
            //td.DocumentPhysicalFilePath = documentPath;

            PdfResult pr = new PdfResult(tdd,contentType);

            switch (cadt.CloudApplicationDocumentTypeName.Trim().ToUpper())
            {
                case "CASE STUDY":
                    if (CustomSession.VisitedViaCategory)
                    {
                        _siteAnalyticsLogger.Log(_repository, ActionType.ClickCaseStudy, cad.CloudApplication.CloudApplicationID, cad.CloudApplication.Category.CategoryID, CustomSession.PersonID);
                    }
                    else
                    {
                        _siteAnalyticsLogger.Log(_repository, ActionType.ClickCaseStudy, cad.CloudApplication.CloudApplicationID, null, CustomSession.PersonID);
                    }
                    break;
                case "WHITE PAPER":
                    if (CustomSession.VisitedViaCategory)
                    {
                        _siteAnalyticsLogger.Log(_repository, ActionType.ClickWhitePaper, cad.CloudApplication.CloudApplicationID, cad.CloudApplication.Category.CategoryID, CustomSession.PersonID);
                    }
                    else
                    {
                        _siteAnalyticsLogger.Log(_repository, ActionType.ClickWhitePaper, cad.CloudApplication.CloudApplicationID, null, CustomSession.PersonID);
                    }
                    break;

            }
            return pr;
            //td.DocumentURL;
        }
        #endregion

        #region RedirectToDocumentOwnerWebsiteToShowDocument
        public ActionResult RedirectToDocumentOwnerWebsiteToShowDocument(int documentID)
        {
            CloudApplicationDocument td = _repository.GetCloudApplicationDocument(documentID);
            td.CloudApplicationDocumentURL = "http://www.bbc.co.uk";
            //return View();
            //td.DocumentURL;
            RedirectResult rr = new RedirectResult(td.CloudApplicationDocumentURL);
            return rr;
        }
        #endregion

        #region DownloadFile
        public FileResult DownloadFile(int documentID)
        {
            CloudApplicationDocument td = _repository.GetCloudApplicationDocument(documentID);
            //int fid = Convert.ToInt32(id);
            //var files = objData.GetFiles();
            //string filename = (from f in files
            //                   where f.FileId == fid
            //                   select f.FilePath).First();
            string fileName = td.CloudApplicationDocumentPhysicalFilePath + td.CloudApplicationDocumentFileName;
            string contentType = "application/pdf";
            //Parameters to file are
            //1. The File Path on the File Server
            //2. The content type MIME type
            //3. The parameter for the file save by the browser
            //return File(fileName, contentType, "Report.pdf");
            return File(fileName, contentType, td.CloudApplicationDocumentFileName);
        }
        #endregion


        #region Header
        //public override ActionResult HeaderModel(HeaderModel hm)
        //{
        //    return base.HeaderModel(hm);
        //}

        public override ActionResult HeaderModel(HeaderModel hm, CustomSession session)
        {
            return base.HeaderModel(hm,session);
        }

        [HttpPost]
        public override ActionResult HeaderModel(HeaderModel hm, FormCollection fc)
        {
            return base.HeaderModel(hm, fc);
        }

        #endregion

        #region Footer
        public override ActionResult FooterModel(HeaderModel hm)
        {
            return base.FooterModel(hm);
        }

        [HttpPost]
        public override ActionResult FooterModel(HeaderModel hm, FormCollection fc)
        {
            return base.FooterModel(hm, fc);
        }

        #endregion



        #region CategoryPage POST
        [HttpPost]
        public ActionResult CategoryPage(CategoryPageModel model)
        {
            return CategoryPagePost(model);
            #region DEPRECATED
        //    if (!model.SearchInputModel.TermsAndConditions)
        //    {
        //        //ModelState.Clear();
        //        //ModelState["ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID"] = null;
        //        //ModelState.Remove("ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.RequestTypeID");
        //        model.ShowConfirmationDialog = true;
        //        model.ConfirmationDialogTitle = "Terms & Conditions";
        //        model.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
        //        return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));

        //    }

        //    if (model.SearchInputModel.ChosenNumberOfUsers == "User numbers")
        //    {
        //        model.ShowConfirmationDialog = true;
        //        model.ConfirmationDialogTitle = "User numbers";
        //        model.ConfirmationDialogMessage1 = "Please select the User number to proceed";
        //        return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        #region ISVALID

        //        CustomSession.HasSearchResults = true;

        //        if (model.SearchInputModel != null)
        //        {
        //            Person person = ModelHelpers.AddPerson(model.SearchInputModel.Forename, model.SearchInputModel.Surname, model.SearchInputModel.EMail, int.Parse(model.SearchInputModel.ChosenNumberOfUsers), _repository);
        //            CustomSession.EMail = person.EMail;
        //            CustomSession.Forename = person.Forename;
        //            CustomSession.Surname = person.Surname;
        //            CustomSession.NumberOfUsers = person.NumberOfEmployees;
        //            CustomSession.PersonID = person.PersonID;

        //            model.SearchInputModel.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
        //            model.SearchInputModel.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);
        //            model.SearchInputModel.NumberOfUsers = ModelHelpers.AddNumberOfUsersToList(model.SearchInputModel.NumberOfUsers, "User numbers");

        //            ViewBag.VisibleResultsTab = 1;
        //            SearchPageModel searchModel = new SearchPageModel(CustomSession);
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.SearchInputModel.Categories;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = int.Parse(model.SearchInputModel.ChosenNumberOfUsers);
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

        //            int? selectedSupportHours = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,model.SearchInputModel.ChosenCategoryID,this.CustomSession,_repository);

        //            int? selectedTimeZone = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone, model.SearchInputModel.ChosenCategoryID,_repository);

        //            searchModel = ModelHelpers.GetSearchModelFiltersOneColumn(searchModel, false, false, this.CustomSession, _repository);

        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures, (int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, "UNLIMITED",_repository);
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures = ModelHelpers.SetComboOptionsFromApplicationFeature(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersApplicationFeatures, (int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, "UNLIMITED",_repository);

        //            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel,this.CustomSession, _repository, Logger, _siteAnalyticsLogger).ToList();

        //            ModelHelpers.SetSearchResultsColumnHeaders((int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, searchModel, _repository);

        //            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
        //                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
        //                {
        //                    ApplicationCostOneOff = x.ApplicationCostOneOff,

        //                    ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
        //                    ApplicationCostPerAnnumFrom = x.ApplicationCostPerAnnumFrom,
        //                    ApplicationCostPerAnnumTo = x.ApplicationCostPerAnnumTo,
        //                    ApplicationCostPerAnnumPOA = x.ApplicationCostPerAnnumPOA,
        //                    ApplicationCostPerAnnumOffered = x.ApplicationCostPerAnnumOffered,
        //                    ApplicationCostPerAnnumFree = x.ApplicationCostPerAnnumFree,
        //                    ApplicationCostPerAnnumIsForUnlimitedUsers = x.ApplicationCostPerAnnumIsForUnlimitedUsers,

        //                    ApplicationCostPerMonth = x.ApplicationCostPerMonth,
        //                    ApplicationCostPerMonthFrom = x.ApplicationCostPerMonthFrom,
        //                    ApplicationCostPerMonthTo = x.ApplicationCostPerMonthTo,
        //                    ApplicationCostPerMonthPOA = x.ApplicationCostPerMonthPOA,
        //                    ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
        //                    ApplicationCostPerMonthOffered = x.ApplicationCostPerMonthOffered,
        //                    ApplicationCostPerMonthFree = x.ApplicationCostPerMonthFree,
        //                    ApplicationCostPerMonthIsForUnlimitedUsers = x.ApplicationCostPerMonthIsForUnlimitedUsers,

        //                    PayAsYouGo = x.PayAsYouGo,

        //                    CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
        //                    CloudApplicationID = x.CloudApplicationID,
        //                    Description = x.Description,
        //                    FreeTrialPeriod = x.FreeTrialPeriod,
        //                    //IsLastInCollection = x.IsLastInCollection,
        //                    ResultDisplayFormat = x.ResultDisplayFormat,
        //                    SearchResultID = x.SearchResultID,
        //                    ServiceName = x.ServiceName,
        //                    SetupFee = x.SetupFee,
        //                    VendorID = x.VendorID,
        //                    VendorLogo = x.VendorLogo,
        //                    VendorLogoURL = x.VendorLogoURL,
        //                    VendorName = x.VendorName,
        //                    CloudApplicationCategoryTag = x.CloudApplicationCategoryTag,
        //                    CloudApplicationShopTag = x.CloudApplicationShopTag,

        //                    OperatingSystems = x.OperatingSystems,
        //                    SupportTypes = x.SupportTypes,
        //                    SupportDays = x.SupportDays,
        //                    Languages = x.Languages,
        //                    CloudApplicationFeatures = x.CloudApplicationFeatures,
        //                    Currency = new CurrencyModel()
        //                    {
        //                        CurrencyID = x.Currency.CurrencyID,
        //                        CurrencyName = x.Currency.CurrencyName,
        //                        CurrencyShortName = x.Currency.CurrencyShortName,
        //                        CurrencySymbol = x.Currency.CurrencySymbol,
        //                        ExchangeRateSterling = x.Currency.ExchangeRateSterling,
        //                        UseExchangeRateForSorting = x.Currency.UseExchangeRateForSorting,
        //                    }

        //                }).ToList();

        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersCategoriesCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersUsersCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersOperatingSystemsCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersDevicesCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersBrowsersCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersMobilePlatformsCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersFeaturesCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportTypesCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportDaysCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersSupportHoursCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersLanguagesCollapsed = true;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersTimeZonesCollapsed = true;

        //            ModelHelpers.SetSearchResultsSortOrder(null, null, searchModel);
        //            ModelHelpers.PaginateSearchResults(searchModel, 1);
        //            ModelHelpers.FixUpViewData(searchModel,this);

        //            _siteAnalyticsLogger.Log(_repository, ActionType.ClickCategoryPageCompare, null, model.SearchInputModel.ChosenCategoryID, person.PersonID);
        //            ModelHelpers.LogSearchResultModelSiteAnalytic(searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsPage, model.SearchInputModel.ChosenCategoryID, _siteAnalyticsLogger, this.CustomSession, _repository);

        //            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

        //            return View("SearchPage", searchModel);

        //        }
        //        else
        //        {
        //            model.SearchInputModel.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
        //            model.SearchInputModel.NumberOfUsers = ModelHelpers.GetNumberOfUsers(_repository);
        //            model.SearchInputModel.NumberOfUsers = ModelHelpers.AddNumberOfUsersToList(model.SearchInputModel.NumberOfUsers, "User numbers");

        //            model.SearchInputModel.Forename = CustomSession.Forename;
        //            model.SearchInputModel.Surname = CustomSession.Surname;
        //            model.SearchInputModel.EMail = CustomSession.EMail;

        //            ViewBag.VisibleResultsTab = 1;
        //            SearchPageModel searchModel = new SearchPageModel(CustomSession);
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.SearchInputModel.Categories;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = int.Parse(model.SearchInputModel.ChosenNumberOfUsers);
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = ModelHelpers.GetSupportDays(_repository);

        //            int? selectedSupportHours = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenSupportHours;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = ModelHelpers.GetSupportHours(selectedSupportHours,model.SearchInputModel.ChosenCategoryID,this.CustomSession,_repository);

        //            int? selectedTimeZone = searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenTimeZone;
        //            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersTimeZones = ModelHelpers.GetTimeZones(selectedTimeZone, model.SearchInputModel.ChosenCategoryID, _repository);

        //            searchModel = ModelHelpers.GetSearchModelFiltersOneColumn(searchModel, false, false, this.CustomSession, _repository);
        //            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = ModelHelpers.GetSearchResults(searchModel, this.CustomSession, _repository, Logger, _siteAnalyticsLogger).ToList();

        //            ModelHelpers.SetSearchResultsColumnHeaders((int)searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, searchModel, _repository);

        //            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

        //            return View("CategoryPage", searchModel);
        //        }
        //        #endregion
        //    }
        //    else
        //    {
        //        if (ModelState["SearchInputModel.Forename"].Errors.Count > 0 || model.SearchInputModel.Forename == ViewModelHelpers.FORENAME_ERROR_MESSAGE)
        //        {
        //            ModelState["SearchInputModel.Forename"].Value = new ValueProviderResult(ViewModelHelpers.FORENAME_ERROR_MESSAGE, model.SearchInputModel.Forename, System.Globalization.CultureInfo.CurrentCulture);
        //            ModelState.AddModelError("SearchInputModel.Firstname", "www");
        //        }
        //        if (ModelState["SearchInputModel.EMail"].Errors.Count > 0)
        //        {
        //            if (model.SearchInputModel.EMail == ViewModelHelpers.EMAIL_ERROR_MESSAGE || model.SearchInputModel.EMail == null)
        //            {
        //                ModelState["SearchInputModel.EMail"].Value = new ValueProviderResult(ViewModelHelpers.EMAIL_ERROR_MESSAGE, model.SearchInputModel.EMail, System.Globalization.CultureInfo.CurrentCulture);
        //            }
        //            ModelState.AddModelError("SearchInputModel.EMail", "www");
        //        }
        //        return View(ModelHelpers.ConstructCategoryPageModel(model, model.SearchInputModel.ChosenCategoryID, this.CustomSession, _repository));
        //    }
            #endregion
        }
        #endregion











        #region GetMPU


        #endregion


        #region SearchTags
        public ActionResult SearchTags()
        {
            var model = new ReservationViewModel(CustomSession);
            return View(model);
        }

        [HttpPost]
        public ActionResult SearchTags(ReservationViewModel model)
        {
            model = new ReservationViewModel(CustomSession);
            return View(model);
        }
        #endregion



        #region AutoCompleteResultRedirect
        public ActionResult AutoCompleteResultRedirect(int? id, string term)
        {
            return View();

        }
        #endregion

        #region GlobalSearchResults
        //[HttpPost]
        public ActionResult GlobalSearchResults(string term, bool liveApplicationsOnly)
        {
            ViewBag.VisibleResultsTab = 1;
            CustomSession.HasSearchResults = false;

            GlobalSearchPageModel searchModel = new GlobalSearchPageModel(CustomSession);

            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults =
                ModelHelpers.ConvertGlobalSearchResults(_repository.GetSearchResultsFromTags(term,liveApplicationsOnly));

            searchModel.ContainerModel.SearchResultsModel.TestValue = "TEST";
            searchModel.ContainerModel.CustomSession = CustomSession;
            searchModel.ContainerModel.SearchResultsModel.CustomSession = CustomSession;

            searchModel.ContainerModel.SearchResultsModel.Term = term;

            //SetSearchResultsSortOrder(null, null, searchModel);
            ModelHelpers.PaginateSearchResults(searchModel, 1);

            ModelHelpers.GetAdvertisingImages(searchModel, this.CustomSession, _repository);

            ModelHelpers.FixUpViewData(searchModel,this);
            return View("GlobalSearchPage", searchModel);
        }
        #endregion

        #region TabbedSearchResultsNoScript
        //[HttpPost]
        public ActionResult TabbedSearchResultsNoScript(FormCollection fc, string resultsPage, bool categoryBasedResults, int? categoryID)
        {
            int whichTab;
            switch (resultsPage)
            {
                case TAB_FEATURED: whichTab = 1;
                    break;
                case TAB_NEW: whichTab = 2;
                    break;
                case TAB_TOPTEN: whichTab = 3;
                    break;
                default: whichTab = 1;
                    break;
            }

            if (categoryBasedResults)
            {
                if (categoryID != null)
                {
                    var model = ModelHelpers.ConstructCategoryPageModel(new CategoryPageModel(CustomSession) { SearchInputModel = new SearchInputModel(CustomSession) }, (int)categoryID, this.CustomSession, _repository);
                    model.TabbedSearchResultsModel.FeaturedCloudwareSearchResultsVisible = (resultsPage == TAB_FEATURED);
                    model.TabbedSearchResultsModel.NewCloudwareSearchResultsVisible = (resultsPage == TAB_NEW);
                    model.TabbedSearchResultsModel.TopTenCloudwareSearchResultsVisible = (resultsPage == TAB_TOPTEN);
                    model.TabbedSearchResultsModel.CategoryBasedResults = categoryBasedResults;
                    ModelHelpers.LogTabbedSearchResultsModelSiteAnalytic(model.TabbedSearchResultsModel, whichTab, _siteAnalyticsLogger, this.CustomSession, _repository);
                    return View("CategoryPage", model);
                }
                else
                {
                    throw new Exception("TabbedSearchResultsNoScript received a null category ID");
                }
            }
            else
            {
                var model = ModelHelpers.ConstructHomePageModel(new HomePageModel(CustomSession) { SearchInputModel = new SearchInputModel(CustomSession) }, this.CustomSession, _repository, Request, this.HttpContext.Response);
                model.TabbedSearchResultsModel.FeaturedCloudwareSearchResultsVisible = (resultsPage == TAB_FEATURED);
                model.TabbedSearchResultsModel.NewCloudwareSearchResultsVisible = (resultsPage == TAB_NEW);
                model.TabbedSearchResultsModel.TopTenCloudwareSearchResultsVisible = (resultsPage == TAB_TOPTEN);
                model.TabbedSearchResultsModel.CategoryBasedResults = categoryBasedResults;
                ModelHelpers.LogTabbedSearchResultsModelSiteAnalytic(model.TabbedSearchResultsModel, whichTab, _siteAnalyticsLogger, this.CustomSession, _repository);
                return View("HomePage", model);
            }
        }
        #endregion

        #region Log
        [HttpPost]
        public ActionResult LogBrokenLink(string link)
        {
            Logger.Error("BROKEN_LINK:" + link);
            return null;
        }
        #endregion

        #region SetDummyVXMode POST
        [HttpPost]
        public ActionResult SetDummyVXMode(bool dummyVXMode)
        {
            CustomSession.DummyVXMode = dummyVXMode;
            return null;

        }

        #endregion

        #region SearchFiltersPartial POST
        [HttpPost]
        public ActionResult SearchResultsTabChanged(string whichTab,HomePageModel model)
        {
            try
            {
                ModelHelpers.LogTabbedSearchResultsModelSiteAnalytic(model.TabbedSearchResultsModel, int.Parse(whichTab) + 1, _siteAnalyticsLogger, this.CustomSession, _repository);
            }
            catch (Exception e)
            {
                Logger.Error("Couldn't log search results tab. The error was : " + e.Message + ". Stack trace : " + e.StackTrace);
            }
            return null;
        }
        #endregion

        #region HasActiveSupport
        [HttpPost]
        //public ActionResult RefreshActiveSupport(IEnumerable<SearchFilterModelOneColumn> supportTypes)
        public ActionResult HasActiveSupport(SearchPageModel model)
        {
            //bool includeSupportInSearchFilter = base.HaveAnyActiveSupportTypesBeenSelected(model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true));

            bool includeSupportInSearchFilter = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes != null ? ModelHelpers.HaveAnyActiveSupportTypesBeenSelected(model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true),_repository) : false;
            //return Content(includeSupportInSearchFilter.ToString());
            return Json(includeSupportInSearchFilter.ToString());
        }
        #endregion


        #region RegisterCloudware
        [HttpPost]
        public override ActionResult RegisterCloudware(CloudApplicationRegistrationAndUpdateModel carm, FormCollection fc)
        {
            return base.RegisterCloudware(carm, fc);
        }
        #endregion

        #region RedisplayBetaSplashShownNoScript
        //[HttpPost]
        public override ActionResult RedisplayBetaSplashShownNoScript()
        {
            //return null;
            return base.RedisplayBetaSplashShownNoScript();
        }
        #endregion

        #region BetaSplashShownNoScript
        //[HttpPost]
        //[HttpGet]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public override ActionResult BetaSplashShownNoScript()
        {
            //return null;
            return base.BetaSplashShownNoScript();
        }
        #endregion

        #region RegisterExternal
        public ActionResult RegisterExternal()
        {
            //Logger.Fatal("In HomePage");
            try
            {
                Logger.Debug("RegisterExternal #1");
                ModelHelpers.SetSessionVariables(Request,this.CustomSession);
                CustomSession.AutoShowRegisterOrUpdate = true;
                CustomSession.BetaSplashShown = true;
                Logger.Debug("RegisterExternal #2");
                //return RedirectToRoute("HomePage");

                CustomSession.VisitedViaCategory = false;
                var model = ModelHelpers.ConstructHomePageModel(new HomePageModel(CustomSession) { SearchInputModel = new SearchInputModel(CustomSession) }, this.CustomSession, _repository, Request, this.HttpContext.Response);
                ViewBag.VisibleResultsTab = 1;
                return View("HomePage",model);

            }
            catch (Exception e)
            {
                Logger.Fatal("Could not register from external site request. The error was: " + e.Message + ". Stack trace:" + e.StackTrace, e);
                throw new Exception("Could not register from external site request", e);
            }
        }
        #endregion


        #region SendSearchResultToRAZORAndCreatePDF
        private string SendSearchResultToRAZORAndCreatePDF(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            string retVal = "";
            string HTML;
            string htmlFileName = additionalOutput.OutputFileName;
            string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath(filePath);
            string createdFileName = null;
            //LogoPositioning logoPositioning = null;
            try
            {
                ImageBag searchResultImages = new ImageBag();
                PDFImageInsert ii;
                ii = new PDFImageInsert();
                //ii.ImageBitmap = CompareCloudware.Web.App_LocalResources.Images.CCW_Logo_Top;
                ii.LogoPositioning.X_Position = 10;
                ii.LogoPositioning.Y_Position = 10;
                //searchResultImages.PDFImageInserts.Add(ii);

                DirectoryInfo di = new DirectoryInfo(serverFilePath);
                if (!di.Exists)
                {
                    CompareCloudwareService.CreateFolder(serverFilePath);
                }

                HTML = this.CreateSearchResultPDFHTML(searchResult, "PrintResult2");

                if (htmlFileName == null)
                {
                    //File.WriteAllText("c:\\gt\\wcfrazor\\wcfrazor\\output.htm", pdfHtml);
                }
                else
                {
                    System.IO.File.WriteAllText(serverFilePath + htmlFileName, HTML);
                }

                if (pageNumber == 1)
                {
                    //logoPositioning = invoice.LogoPositionPage1;
                }
                if (pageNumber == 2)
                {
                    //logoPositioning = invoice.LogoPositionPage2;
                }

                if (additionalOutput.PDFEngineType == PDFEngineType.ASPPDF)
                {
                    createdFileName = PDFGenerator.CreatePdfFileUsingASPPDF(serverFilePath, fileName, overwriteIfExists, HTML, searchResultImages);
                }
                //else if (additionalOutput.PDFEngineType == PDFEngineType.PDFTRON)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingPDFTRON(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}
                //else if (additionalOutput.PDFEngineType == PDFEngineType.EVOPDF)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingEVOPDF(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}

                //return pdfHtml;
                return createdFileName;

            }
            catch (Exception e)
            {
                retVal = e.Message;
            }
            return retVal;
        }
        #endregion

        #region SendSearchResultToRAZORAndReturnPDFStream
        private MemoryStream SendSearchResultToRAZORAndReturnPDFStream(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            string retVal = "";
            string HTML;
            string htmlFileName = additionalOutput.OutputFileName;
            string serverFilePath = filePath != null ? System.Web.Hosting.HostingEnvironment.MapPath(filePath) : null;
            //string createdFileName = null;
            MemoryStream createdStream = null;
            //LogoPositioning logoPositioning = null;
            try
            {
                ImageBag searchResultImages = new ImageBag();
                PDFImageInsert ii;
                ii = new PDFImageInsert();
                //ii.ImageBitmap = CompareCloudware.Web.App_LocalResources.Images.CCW_Logo_Top;
                ii.LogoPositioning.X_Position = 10;
                ii.LogoPositioning.Y_Position = 10;
                //searchResultImages.PDFImageInserts.Add(ii);

                if (filePath != null)
                {
                    DirectoryInfo di = new DirectoryInfo(serverFilePath);
                    if (!di.Exists)
                    {
                        CompareCloudwareService.CreateFolder(serverFilePath);
                    }
                }

                HTML = this.CreateSearchResultPDFHTML(searchResult, "PrintResult3");

                if (htmlFileName == null)
                {
                    //File.WriteAllText("c:\\gt\\wcfrazor\\wcfrazor\\output.htm", pdfHtml);
                }
                else
                {
                    System.IO.File.WriteAllText(serverFilePath + htmlFileName, HTML);
                }

                if (pageNumber == 1)
                {
                    //logoPositioning = invoice.LogoPositionPage1;
                }
                if (pageNumber == 2)
                {
                    //logoPositioning = invoice.LogoPositionPage2;
                }

                if (additionalOutput.PDFEngineType == PDFEngineType.ASPPDF)
                {
                    createdStream = PDFGenerator.CreatePdfStreamUsingASPPDF(serverFilePath, fileName, overwriteIfExists, HTML, searchResultImages);
                }
                //else if (additionalOutput.PDFEngineType == PDFEngineType.PDFTRON)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingPDFTRON(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}
                //else if (additionalOutput.PDFEngineType == PDFEngineType.EVOPDF)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingEVOPDF(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}

                //return pdfHtml;
                return createdStream;

            }
            catch (Exception e)
            {
                retVal = e.Message;
            }
            return createdStream;
        }
        #endregion

        #region CreateSearchResultPDFHTML
        private string CreateSearchResultPDFHTML(CloudApplicationModel model, string template)
        //public string CreateGenericInvoicePdfHtml<T>(GenericInvoice<T> invoice, string template)
        {
            string pdfHtml = string.Empty;
            {

                // Create a dummy ControllerContext using a seperate response stream so we can use the standard Razor View Engine to Render the Invoices using Razor View Templates.               
                using (var htmlStream = new System.IO.MemoryStream())
                {
                    using (var htmlWriter = new System.IO.StreamWriter(htmlStream))
                    {
                        string filename;
                        filename = template;
                        string url;
                        url = ConfigurationManager.AppSettings["PDFViewPath"];

                        System.Web.UI.Page p = new System.Web.UI.Page();
                        var httpContext = new HttpContext(new HttpRequest(filename, url, null), new HttpResponse(htmlWriter));
                        httpContext.Request.Browser = new HttpBrowserCapabilities();

                        System.Web.Routing.RouteCollection routes = new System.Web.Routing.RouteCollection();
                        System.Web.Routing.Route r = new System.Web.Routing.Route("{controller}.mvc/{action}/{id}", new MvcRouteHandler())
                        {
                            Defaults = new System.Web.Routing.RouteValueDictionary(new { controller = "Home", action = "Index", id = "" }),

                        };
                        routes.Add(r);

                        System.Web.Routing.RouteData rd = new System.Web.Routing.RouteData(routes[0], new MvcRouteHandler());
                        rd.Values.Add("Controller", "Home");
                        rd.Values.Add("Action", "Index");


                        //var cc = new ControllerContext(new HttpContextWrapper(httpContext), rd, this);
                        //cc.Controller.ViewData.Model = model;

                        this.ViewData.Model = model;
                        //IView iv = new System.Web.Mvc.RazorView(cc, "~/Views/Home/" + filename + ".cshtml", "~/Views/Home", false, null);
                        var view = this.View(filename);
                        StringWriter sw = new StringWriter();
                        try
                        {
                            //var viewName = "~/Views/Shared/PrintResult3.cshtml";
                            //viewName = "PrintResult3";
                            //var viewResult = ViewEngines.Engines.FindPartialView(cc, viewName);
                            //var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                            //viewResult.View.Render(viewContext, sw);
                            //viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                            ////return sw.GetStringBuilder().ToString();

                            //ViewEngineResult vr = ViewEngines.Engines.FindView(cc, "PrintResult3", null);
                            //ViewContext vc = new ViewContext(cc.Controller.ControllerContext, vr.View, cc.Controller.ViewData, cc.Controller.TempData, sw);
                            //vr.View.Render(vc, sw);
                            //view.ExecuteResult(cc);

                            var cc = new ControllerContext(new HttpContextWrapper(httpContext), rd, this);
                            this.ViewData.Model = model;
                            this.View(filename).ExecuteResult(cc);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                        htmlWriter.Flush();
                        htmlStream.Position = 0;
                        using (var htmlReader = new System.IO.StreamReader(htmlStream))
                        {
                            pdfHtml = htmlReader.ReadToEnd();
                        }
                    }

                    htmlStream.Close();
                }
            }

            return pdfHtml;
        }
        #endregion

        #region RenderRazorViewToString
        //public string RenderRazorViewToString(string viewName, CloudApplicationModel model)
        //{
        //    ViewData.Model = model;
        //    //var html = this.RenderView("about");
        //    //return html;
        //    using (var sw = new StringWriter())
        //    {
        //        var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
        //        var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
        //        viewResult.View.Render(viewContext, sw);
        //        viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
        //        return sw.GetStringBuilder().ToString();
        //    }
        //}
        #endregion

        #region SendHTMLStringAndReturnPDFStream
        //public MemoryStream SendHTMLStringAndReturnPDFStream(string HTML, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        //{
        //    string retVal = "";
        //    string htmlFileName = additionalOutput.OutputFileName;
        //    string serverFilePath = filePath != null ? System.Web.Hosting.HostingEnvironment.MapPath(filePath) : null;
        //    //string createdFileName = null;
        //    MemoryStream createdStream = null;
        //    //LogoPositioning logoPositioning = null;
        //    try
        //    {
        //        ImageBag searchResultImages = new ImageBag();
        //        PDFImageInsert ii;
        //        ii = new PDFImageInsert();
        //        //ii.ImageBitmap = CompareCloudware.Web.App_LocalResources.Images.CCW_Logo_Top;
        //        ii.LogoPositioning.X_Position = 10;
        //        ii.LogoPositioning.Y_Position = 10;
        //        //searchResultImages.PDFImageInserts.Add(ii);

        //        if (filePath != null)
        //        {
        //            DirectoryInfo di = new DirectoryInfo(serverFilePath);
        //            if (!di.Exists)
        //            {
        //                CompareCloudwareService.CreateFolder(serverFilePath);
        //            }
        //        }

        //        if (htmlFileName == null)
        //        {
        //            //File.WriteAllText("c:\\gt\\wcfrazor\\wcfrazor\\output.htm", pdfHtml);
        //        }
        //        else
        //        {
        //            System.IO.File.WriteAllText(serverFilePath + htmlFileName, HTML);
        //        }

        //        if (pageNumber == 1)
        //        {
        //            //logoPositioning = invoice.LogoPositionPage1;
        //        }
        //        if (pageNumber == 2)
        //        {
        //            //logoPositioning = invoice.LogoPositionPage2;
        //        }

        //        if (additionalOutput.PDFEngineType == PDFEngineType.ASPPDF)
        //        {
        //            createdStream = PDFGenerator.CreatePdfStreamUsingASPPDF(serverFilePath, fileName, overwriteIfExists, HTML, searchResultImages);
        //        }
        //        //else if (additionalOutput.PDFEngineType == PDFEngineType.PDFTRON)
        //        //{
        //        //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingPDFTRON(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
        //        //}
        //        //else if (additionalOutput.PDFEngineType == PDFEngineType.EVOPDF)
        //        //{
        //        //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingEVOPDF(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
        //        //}

        //        //return pdfHtml;
        //        return createdStream;

        //    }
        //    catch (Exception e)
        //    {
        //        retVal = e.Message;
        //    }
        //    return createdStream;
        //}
        #endregion

        #region WindowToOpenOnTryBuy
        public ActionResult WindowToOpenOnTryBuy()
        {
            string url = RouteData.Values["WindowToOpenOnTryBuy"].ToString();
            return Redirect("http://www.bbc.co.uk");
        }
        #endregion


        #region PartnerProgrammePage
        [HttpPost]
        //public async Task<ActionResult> PartnerProgrammePage(TabbedOnpageOptimisationModel model)
        //public async Task<ActionResult> PartnerProgrammePage(PartnerProgrammeModel model)
        public async Task<ActionResult> PartnerProgrammePage(RegisterNowModel model)
        {
            RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();

            if (String.IsNullOrEmpty(recaptchaHelper.Response))
            {
                ModelState.AddModelError("recaptcha", "Captcha answer cannot be empty.");
                //return Json(new { capthcaInvalid = true }); 
                return View("RegisterNow", model);
                //return null;
            }

            RecaptchaVerificationResult recaptchaResult = await recaptchaHelper.VerifyRecaptchaResponseTaskAsync();

            if (recaptchaResult != RecaptchaVerificationResult.Success)
            {
                ModelState.AddModelError("recaptcha", "Incorrect captcha answer.");
            }
            else
            {
                Person p = ModelHelpers.AddPerson(
                        PersonTypeEnum.ProspectVendor,
                        model.Forename,
                        model.Surname,
                        model.EMailAddress,
                        0,
                        model.Telephone,
                        model.Company,
                        model.JobTitle,
                        _repository
                    );

                CloudApplicationRequest ar = new CloudApplicationRequest();
                ar.PersonID = p.PersonID;
                ar.RequestTypeID = _repository.GetRequestTypeByRequestTypeName(Enum.GetName(typeof(PartnerProgrammeTypeEnum), model.PartnerProgrammeType)).RequestTypeID;

                bool retVal = _repository.Insert<CloudApplicationRequest>(ar);

                ModelState.Remove("IsRegistered");
                model.IsRegistered = true;

                if (model.HasPresentationVideo)
                {
                    ModelState.Remove("ShowVideo");

                    model.ShowVideo = true;
                    model.Video = new CloudApplicationVideoModel(CustomSession, Request)
                    {
                        CloudApplicationVideoURL = "//player.vimeo.com/video/112796483?title=0&amp;byline=0&amp;portrait=0&amp;color=786caf&amp;autoplay=1",
                        IsYouTubeStream = true,
                        ReadyToPlay = true,
                        CloudApplicationVideoStatus = "LIVE",
                        Width = 240,
                        AspectRatio = AspectRatio.Ratio16x9,
                    };
                }

            }
            return View("RegisterNow",model);
        }
        #endregion

    
    }

    #region FormCollectionExtensions
    public static class FormCollectionExtensions
    {
        public static string GetSubmitButtonName(this FormCollection formCollection)
        {
            return GetSubmitButtonName(formCollection, false);
        }

        public static string GetSubmitButtonName(this FormCollection formCollection, bool throwOnError)
        {
            var imageButton = formCollection.Keys.OfType<string>().Where(x => x.EndsWith(".x")).SingleOrDefault();
            var textButton = formCollection.Keys.OfType<string>().Where(x => x.StartsWith("Submit_")).SingleOrDefault();

            if (textButton != null)
            {
                return textButton.Substring("Submit_".Length);
            }

            // we got something like AddToCart.x
            if (imageButton != null)
            {
                return imageButton.Substring(0, imageButton.Length - 2);
            }

            if (throwOnError)
            {
                throw new ApplicationException("No button found");
            }
            else
            {
                return null;
            }
        }
    }
    #endregion

    #region IEnumerableForEachExtensions
    static class IEnumerableForEachExtensions
    {
        public static void ForEachMatch<T>(this IEnumerable<T> items,
            Predicate<T> predicate,
            Action<T> action
        )
        {
            items.Where(x => predicate(x)).ForEach(action);
        }

        //public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        //{
        //    foreach (T item in items)
        //    {
        //        action(item);
        //    }
        //}
    }
    #endregion

    #region PdfResult
    public class PdfResult : ActionResult
    {
        //private members
        private byte[] pdfBytes;
        private string contentType;
        public PdfResult(CloudApplicationDocument td) 
        {
            //System.IO.FileStream fs = new System.IO.FileStream(td.DocumentPhysicalFilePath + td.DocumentFileName,System.IO.FileMode.Open);
            //using (System.IO.FileStream fs = System.IO.File.OpenRead(td.DocumentPhysicalFilePath + td.DocumentFileName))
            {
                //System.IO.MemoryStream ms = new System.IO.MemoryStream((int)fs.Length);
                //int read = fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                pdfBytes = System.IO.File.ReadAllBytes(td.CloudApplicationDocumentPhysicalFilePath + td.CloudApplicationDocumentFileName);
            }
            
        }

        public PdfResult(CloudApplicationDocumentImage tdd, string applicationType)
        {
            //System.IO.FileStream fs = new System.IO.FileStream(td.DocumentPhysicalFilePath + td.DocumentFileName,System.IO.FileMode.Open);
            //using (System.IO.FileStream fs = System.IO.File.OpenRead(td.DocumentPhysicalFilePath + td.DocumentFileName))
            {
                //System.IO.MemoryStream ms = new System.IO.MemoryStream((int)fs.Length);
                //int read = fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                //pdfBytes = System.IO.File.ReadAllBytes(td.DocumentPhysicalFilePath + td.DocumentFileName);
                pdfBytes = tdd.CloudApplicationDocumentBytes;
                contentType = applicationType;
            }

        }

        public override void ExecuteResult(ControllerContext context) 
        {
            //create the pdf in a byte array then drop it into the response
            context.HttpContext.Response.Clear();
            //context.HttpContext.Response.ContentType = "application/pdf";
            context.HttpContext.Response.ContentType = contentType;
            //context.HttpContext.Response.AddHeader("content-disposition", "attachment;filename=xxx.pdf");
            context.HttpContext.Response.AddHeader("content-disposition", "inline;");
            context.HttpContext.Response.OutputStream.Write(pdfBytes.ToArray(), 0, pdfBytes.ToArray().Length);
            context.HttpContext.Response.End();
        }
    }
    #endregion

    #region TestResult
    public class TestResult : ViewResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (string.IsNullOrEmpty(this.ViewName))
            {
                this.ViewName = context.RouteData.GetRequiredString("action");
            }
            ViewEngineResult result = null;
            if (this.View == null)
            {
                result = this.FindView(context);
                this.View = result.View;
            }
            TextWriter output = context.HttpContext.Response.Output;
            ViewContext viewContext = new ViewContext(context, this.View, this.ViewData, this.TempData, output);
            this.View.Render(viewContext, output);
            if (result != null)
            {
                result.ViewEngine.ReleaseView(context, this.View);
            }
        }
    }
    #endregion

    #region VIEWRENDERER - NOT USED
    ///// <summary>
    ///// Class that renders MVC views to a string using the
    ///// standard MVC View Engine to render the view. 
    ///// </summary>
    //public class ViewRenderer
    //{
    //    /// <summary>
    //    /// Required Controller Context
    //    /// </summary>
    //    protected ControllerContext Context { get; set; }

    //    /// <summary>
    //    /// Initializes the ViewRenderer with a Context.
    //    /// </summary>
    //    /// <param name="controllerContext">
    //    /// If you are running within the context of an ASP.NET MVC request pass in
    //    /// the controller's context. 
    //    /// Only leave out the context if no context is otherwise available.
    //    /// </param>
    //    public ViewRenderer(ControllerContext controllerContext = null)
    //    {
    //        // Create a known controller from HttpContext if no context is passed
    //        if (controllerContext == null)
    //        {
    //            if (HttpContext.Current != null)
    //                //controllerContext = CreateController<ErrorController>().ControllerContext;
    //                controllerContext = CreateController<HomeController>().ControllerContext;
    //            else
    //                throw new InvalidOperationException(
    //                    "ViewRenderer must run in the context of an ASP.NET " +
    //                    "Application and requires HttpContext.Current to be present.");
    //        }
    //        Context = controllerContext;
    //    }

    //    /// <summary>
    //    /// Renders a full MVC view to a string. Will render with the full MVC
    //    /// View engine including running _ViewStart and merging into _Layout        
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to render the view with</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public string RenderView(string viewPath, object model)
    //    {
    //        return RenderViewToStringInternal(viewPath, model, false);
    //    }


    //    /// <summary>
    //    /// Renders a partial MVC view to string. Use this method to render
    //    /// a partial view that doesn't merge with _Layout and doesn't fire
    //    /// _ViewStart.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to pass to the viewRenderer</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public string RenderPartialView(string viewPath, object model)
    //    {
    //        return RenderViewToStringInternal(viewPath, model, true);
    //    }

    //    /// <summary>
    //    /// Renders a partial MVC view to string. Use this method to render
    //    /// a partial view that doesn't merge with _Layout and doesn't fire
    //    /// _ViewStart.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to pass to the viewRenderer</param>
    //    /// <param name="controllerContext">Active Controller context</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public static string RenderView(string viewPath, object model,
    //                                    ControllerContext controllerContext)
    //    {
    //        ViewRenderer renderer = new ViewRenderer(controllerContext);
    //        return renderer.RenderView(viewPath, model);
    //    }

    //    /// <summary>
    //    /// Renders a partial MVC view to string. Use this method to render
    //    /// a partial view that doesn't merge with _Layout and doesn't fire
    //    /// _ViewStart.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to pass to the viewRenderer</param>
    //    /// <param name="controllerContext">Active Controller context</param>
    //    /// <param name="errorMessage">optional out parameter that captures an error message instead of throwing</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public static string RenderView(string viewPath, object model,
    //                                    ControllerContext controllerContext,
    //                                    out string errorMessage)
    //    {
    //        errorMessage = null;
    //        try
    //        {
    //            ViewRenderer renderer = new ViewRenderer(controllerContext);
    //            return renderer.RenderView(viewPath, model);
    //        }
    //        catch (Exception ex)
    //        {
    //            errorMessage = ex.GetBaseException().Message;
    //        }
    //        return null;
    //    }

    //    /// <summary>
    //    /// Renders a partial MVC view to string. Use this method to render
    //    /// a partial view that doesn't merge with _Layout and doesn't fire
    //    /// _ViewStart.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to pass to the viewRenderer</param>
    //    /// <param name="controllerContext">Active controller context</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public static string RenderPartialView(string viewPath, object model,
    //                                            ControllerContext controllerContext)
    //    {
    //        ViewRenderer renderer = new ViewRenderer(controllerContext);
    //        return renderer.RenderPartialView(viewPath, model);
    //    }

    //    /// <summary>
    //    /// Renders a partial MVC view to string. Use this method to render
    //    /// a partial view that doesn't merge with _Layout and doesn't fire
    //    /// _ViewStart.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">The model to pass to the viewRenderer</param>
    //    /// <param name="controllerContext">Active controller context</param>
    //    /// <param name="errorMessage">optional output parameter to receive an error message on failure</param>
    //    /// <returns>String of the rendered view or null on error</returns>
    //    public static string RenderPartialView(string viewPath, object model,
    //                                            ControllerContext controllerContext,
    //                                            out string errorMessage)
    //    {
    //        errorMessage = null;
    //        try
    //        {
    //            ViewRenderer renderer = new ViewRenderer(controllerContext);
    //            return renderer.RenderPartialView(viewPath, model);
    //        }
    //        catch (Exception ex)
    //        {
    //            errorMessage = ex.GetBaseException().Message;
    //        }
    //        return null;
    //    }

    //    /// <summary>
    //    /// Internal method that handles rendering of either partial or 
    //    /// or full views.
    //    /// </summary>
    //    /// <param name="viewPath">
    //    /// The path to the view to render. Either in same controller, shared by 
    //    /// name or as fully qualified ~/ path including extension
    //    /// </param>
    //    /// <param name="model">Model to render the view with</param>
    //    /// <param name="partial">Determines whether to render a full or partial view</param>
    //    /// <returns>String of the rendered view</returns>
    //    protected string RenderViewToStringInternal(string viewPath, object model,
    //                                                bool partial = false)
    //    {
    //        // first find the ViewEngine for this view
    //        ViewEngineResult viewEngineResult = null;
    //        if (partial)
    //            viewEngineResult = ViewEngines.Engines.FindPartialView(Context, viewPath);
    //        else
    //            viewEngineResult = ViewEngines.Engines.FindView(Context, viewPath, null);

    //        if (viewEngineResult == null)
    //            throw new FileNotFoundException("Resources.ViewCouldNotBeFound");

    //        // get the view and attach the model to view data
    //        var view = viewEngineResult.View;
    //        Context.Controller.ViewData.Model = model;

    //        string result = null;

    //        using (var sw = new StringWriter())
    //        {
    //            var ctx = new ViewContext(Context, view,
    //                                        Context.Controller.ViewData,
    //                                        Context.Controller.TempData,
    //                                        sw);
    //            view.Render(ctx, sw);
    //            result = sw.ToString();
    //        }

    //        return result;
    //    }


    //    /// <summary>
    //    /// Creates an instance of an MVC controller from scratch 
    //    /// when no existing ControllerContext is present       
    //    /// </summary>
    //    /// <typeparam name="T">Type of the controller to create</typeparam>
    //    /// <returns></returns>
    //    public static T CreateController<T>(RouteData routeData = null)
    //                where T : Controller, new()
    //    {
    //        T controller = new T();

    //        // Create an MVC Controller Context
    //        HttpContextBase wrapper = null;
    //        if (HttpContext.Current != null)
    //            wrapper = new HttpContextWrapper(System.Web.HttpContext.Current);
    //        //else
    //        //    wrapper = CreateHttpContextBase(writer);


    //        if (routeData == null)
    //            routeData = new RouteData();

    //        if (!routeData.Values.ContainsKey("controller") && !routeData.Values.ContainsKey("Controller"))
    //            routeData.Values.Add("controller", controller.GetType().Name
    //                                                        .ToLower()
    //                                                        .Replace("controller", ""));

    //        controller.ControllerContext = new ControllerContext(wrapper, routeData, controller);
    //        return controller;
    //    }
    //}
    #endregion

    #region CUSTOMVIEWENGINE - NOT USED
    //public class CustomViewEngine : WebFormViewEngine
    //{
    //    public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
    //    {
    //        //string skinName = this.GetSkinName(controllerContext);

    //        string controllerName = controllerContext.RouteData.GetRequiredString("controller");

    //        //string viewPath = this.GetPathFromGeneralName(this.ViewLocationFormats, viewName, controllerName, skinName);

    //        //string masterPath = this.GetPathFromGeneralName(this.MasterLocationFormats, viewName, controllerName, skinName);

    //        //if (string.IsNullOrEmpty(viewPath))
    //        //{
    //        //    IEnumerable<string> searchedLocations =
    //        //        this.ViewLocationFormats.Union(this.MasterLocationFormats);
    //        //    return new ViewEngineResult(searchedLocations);
    //        //}
    //        var myView = this.CreateView(controllerContext, "~/Views/Shared/", "");
    //        var myViewEngine = new ViewEngineResult(myView, this);

    //        //try default implementation
    //        System.Web.WebPages.DisplayModeProvider.Instance.Modes.Insert(0, new System.Web.WebPages.DefaultDisplayMode("iPhone")
    //        {
    //            ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
    //              ("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
    //        });

    //        var result = base.FindView(controllerContext, viewName, masterName,useCache);
    //        if (result.View == null)
    //        {
    //            //add the location searched
    //            //return new ViewEngineResult(pathsToSearch);
    //            return new ViewEngineResult(null);
    //        }            
    //        return myViewEngine;
    //    }
    //}
    #endregion

    #region RENDERRAZORVIEW - NOT USED
    public static class RenderRazorView
    {
        /// <summary>Renders a view to string.</summary>
        public static string RenderViewToString(this Controller controller,
                                                string viewName, object viewData)
        {
            //Create memory writer
            var sb = new StringBuilder();
            var memWriter = new StringWriter(sb);

            string filename = "PrintResult3";
            filename = "BusinessPartner";
            string url = ConfigurationManager.AppSettings["PDFViewPath"];
            url = "http://localhost:81/businesspartner";
            var httpRequest = new HttpRequest(filename, url, viewData.ToString());

            //Create fake http context to render the view
            var fakeResponse = new HttpResponse(memWriter);
            //var fakeContext = new HttpContext(HttpContext.Current.Request, fakeResponse);
            var fakeContext = new HttpContext(httpRequest, fakeResponse);
            var fakeControllerContext = new ControllerContext(
                new HttpContextWrapper(fakeContext),
                controller.ControllerContext.RouteData,
                controller.ControllerContext.Controller);

            var oldContext = HttpContext.Current;
            HttpContext.Current = fakeContext;


            //Use HtmlHelper to render partial view to fake context
            var html = new HtmlHelper(new ViewContext(fakeControllerContext, new FakeView(), new ViewDataDictionary(), new TempDataDictionary(), memWriter),
                new ViewPage());
            //html.RenderPartial(viewName, viewData);
            System.Web.Mvc.Html.RenderPartialExtensions.RenderPartial(html, viewName, viewData);
            //Restore context
            HttpContext.Current = oldContext;

            //Flush memory and return output
            memWriter.Flush();
            return sb.ToString();
        }
    }

    /// <summary>Fake IView implementation used to instantiate an HtmlHelper.</summary>
    public class FakeView : IView
    {
        #region IView Members

        public void Render(ViewContext viewContext, System.IO.TextWriter writer)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
}
