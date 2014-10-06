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
using CompareCloudware.Web.Helpers;
using System.Data.Entity;
using LinqKit;

namespace CompareCloudware.Web.Controllers
{
    public class HomeController : Controller
    {
        const string FILTER_CATEGORIES = "CATEGORIES";
        const string FILTER_USERS = "USERS";
        const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_FEATURES = "FEATURES";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";

        readonly ICloudCompareRepository _repository;

        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        public ILogger Logger { get; set; }

        private ICustomSession CustomSession { get; set; }

        public HomeController(ICustomSession session, ICloudCompareRepository repository)
        {
            CustomSession = session;
            _repository = repository;
            //ViewBag.CustomSession = session;
        }

        #region xIndex
        public ActionResult xIndex()
        {
            Logger.Debug("Entered site");

            var bc = Request.Browser;
            int x = bc.EcmaScriptVersion.Major;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            return View();
            //return RedirectToAction("HomePage");
        }
        #endregion

        #region Index
        public ActionResult Index(string id, string javascriptenabled)
        {
            Logger.Debug("Entered site");
            CustomSession.JavaScriptEnabled = true;

            //var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            //CustomSession.DetectedBrowser = bc.Browser;
            //CustomSession.DetectedBrowserID = bc.Id;






            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            //return View();
            return RedirectToAction("HomePage");
            //return RedirectToAction("SearchPage");
        }
        #endregion

        #region IndexCustom
        public ActionResult IndexCustom(string id, string javascriptenabled)
        {
            Logger.Debug("Entered site");

            CustomSession.JavaScriptEnabled = javascriptenabled != null ? Convert.ToBoolean(javascriptenabled) : CustomSession.JavaScriptEnabled;
            var bc = Request.Browser;
            int x = bc.EcmaScriptVersion.Major;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            //return View();
            return RedirectToAction("Index");
        }
        #endregion

        #region About
        public ActionResult About()
        {
            return View();
        }
        #endregion

        #region HomePage
        public ActionResult HomePage()
        {
            var model = new HomePageModel(CustomSession);
            model.SearchInputModel = new SearchInputModel(CustomSession);

            model.SearchInputModel.Categories = this.GetCategories();
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();
            model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = 6;
            model.SearchInputModel.Firstname = "Glyn";
            model.SearchInputModel.EMailAddress = "somebody@anywhere.com";
            model.SearchInputModel.DisplayStyle = SearchInputModelStyle.HomePage;

            model.TabbedSearchResultsModel = new TabbedSearchResultsModel(CustomSession);
            model.TabbedSearchResultsModel.FeaturedCloudware = ConvertSearchResult(_repository.GetFeaturedCloudware());
            model.TabbedSearchResultsModel.TopTenCloudware = ConvertSearchResult(_repository.GetTopTenCloudware());
            model.TabbedSearchResultsModel.NewCloudware = ConvertSearchResult(_repository.GetNewCloudware());

            #region crap
            //var model2 = new SearchFiltersModel();
            //IEnumerable<CloudCompare.Web.Models.SearchFilterModel> filters = _repository.GetSearchOptions(3).Select( x => new SearchFilterModel() { 
            //    //CategoryID = x.Category.CategoryID,
            //    SearchFilterID = x.Category.CategoryID,
            //    SearchFilterName = x.SearchFeatureName,
            //    Selected = false}
            //    );

            ////model2.SearchFilters = features;
            //model2.SearchFiltersBrowsers = filters.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            //model2.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersLanguages = filters.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersMobilePlatforms = filters.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersOperatingSystems = filters.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS);
            //model2.SearchFiltersSupportDays = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersSupportHours = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersSupportTypes = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);
            #endregion

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;



            return View(model);

            //return View("Index");
        }
        #endregion

        #region ConvertSearchResult
        private IList<SearchResultModel> ConvertSearchResult(IList<SearchResult> sr)
        {
            var srm = sr.Select(x => new SearchResultModel()
                  {
                      ApplicationCostOneOff = x.ApplicationCostOneOff,
                      ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                      ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                      ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                      CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                      CloudApplicationID = x.CloudApplicationID,
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
                  });
            return srm.ToList();
        }
        #endregion

        #region HomePage POST
        [HttpPost]
        public ActionResult HomePage(HomePageModel model)
        {
            model.SearchInputModel.Categories = this.GetCategories();
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();


            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;
            SearchPageModel searchModel = new SearchPageModel(CustomSession);

            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.SearchInputModel.Categories;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = model.SearchInputModel.ChosenNumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

            searchModel = this.GetSearchModelFiltersOneColumn(searchModel, false, true);
            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(searchModel).ToList();
            searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
                {
                    ApplicationCostOneOff = x.ApplicationCostOneOff,
                    ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                    ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                    ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                    CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                    CloudApplicationID = x.CloudApplicationID,
                    Description = x.Description,
                    FreeTrialPeriod = x.FreeTrialPeriod,
                    IsLastInCollection = x.IsLastInCollection,
                    ResultDisplayFormat = x.ResultDisplayFormat,
                    SearchResultID = x.SearchResultID,
                    ServiceName = x.ServiceName,
                    SetupFee = x.SetupFee,
                    VendorID = x.VendorID,
                    VendorLogo = x.VendorLogo,
                    VendorLogoURL = x.VendorLogoURL,
                    VendorName = x.VendorName,

                    OperatingSystems = x.OperatingSystems,
                    SupportTypes = x.SupportTypes,
                    SupportDays = x.SupportDays,
                    Languages = x.Languages,
                    CloudApplicationFeatures = x.CloudApplicationFeatures,

                });

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

            FixUpViewData(searchModel);
            //ViewData["SearchResults"] = ViewBag.SearchResults;
            //ViewData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;

            //TempData["SearchFilters"] = ViewBag.SearchFilters;
            //TempData["SearchResults"] = ViewBag.SearchResults;
            //TempData["SearchResultsSummary"] = ViewBag.SearchResultsSummary;


            return View("SearchPage", searchModel);
        }
        #endregion

        #region xHomePage POST
        [HttpPost]
        public ActionResult xHomePage(SearchInputModel model)
        {
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            return View(model);
        }
        #endregion

        #region HomePage with selected tab
        [HttpPost]
        public ActionResult xHomePage(string tab)
        {
            var model = new HomePageModel(CustomSession);
            model.SearchInputModel.Categories = this.GetCategories();
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();
            model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = 6;
            model.SearchInputModel.Firstname = "Glyn";
            model.TabbedSearchResultsModel = new TabbedSearchResultsModel(CustomSession);
            model.TabbedSearchResultsModel.FeaturedCloudware = ConvertSearchResult(_repository.GetFeaturedCloudware());
            model.TabbedSearchResultsModel.TopTenCloudware = ConvertSearchResult(_repository.GetTopTenCloudware());
            model.TabbedSearchResultsModel.NewCloudware = ConvertSearchResult(_repository.GetNewCloudware());
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = int.Parse(tab);

            //TabbedSearchResults tsr = new TabbedSearchResults();
            //tsr.FeaturedCloudware = repository.GetFeaturedCloudware();
            //tsr.NewCloudware = repository.GetNewCloudware();
            //tsr.TopTenCloudware = repository.GetTopTenCloudware();
            ////return View(context.CloudApplications.ToList());
            //ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            //ViewBag.VisibleResultsTab = int.Parse(tab);
            //return View(tsr);

            //return View("Index");
            return View(model);
        }
        #endregion

        #region SearchPage
        public ActionResult SearchPage()
        {

            var twoCols = _repository.GetFiltersTwoColumn(3, 5);

            //var query = from x in Enumerable.Range(0, twoCols.GetUpperBound(0))
            //from y in Enumerable.Range(0, twoCols.GetUpperBound(1))
            //where twoCols[x, y] = true
            //select new { x, y };

            //twoCols.AsQueryable();
            //var filtersTwoCols =
            //    from twoColsResults
            //    in twoCols.AsEnumerable();
            //.Where(x => x.SearchFeatureTypeName != FILTER_FEATURES)
            //.Select(x => new SearchFilterModelOneColumn()
            //{
            //    Category = x.Category != null ? x.Category : null,
            //    //SearchFilterID = x.Category.CategoryID,
            //    SearchFilterName = x.SearchFeatureName,
            //    SearchFilterType = x.SearchFeatureTypeName,
            //    Selected = false
            //}
            //);
            //var model = new HomePageModel();
            //model.Categories = _repository.GetCategories();
            //model.OperatingSystems = _repository.GetOperatingSystems();
            //model.ChosenOperatingSystemID = 2;
            //model.ChosenCategoryID = 6;
            //model.Name = "aaa";

            //model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            //model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            //model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            //model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();

            var filtersOneColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn(CustomSession)
                    {
                        //Category = x.CategoryCol1 != null ? x.CategoryCol1 : null,
                        Category = x.CategoryCol1 != null ? new CategoryModel()
                        {
                            CategoryID = x.CategoryCol1.CategoryID,
                            CategoryName = x.CategoryCol1.CategoryName,
                        }
                        : null,
                        //SearchFilterID = x.Category.CategoryID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                    }
                );

            var filtersTwoColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                .Select(x => new SearchFilterModelTwoColumn(CustomSession)
                    {
                        //Category = x.Category != null ? x.Category : null,
                        //SearchFilterID = x.Category.CategoryID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                        Col2SearchFilterName = x.SearchFilterNameCol2,
                        Col2SearchFilterType = x.SearchFilterTypeNameCol2,
                        Col2Selected = false
                    }
                );
            //List<SearchFilterModelOneColumn> list = filtersOneColumn.ToList();
            //int nStep = 2;
            //var test = list.Where((x, i) => i % nStep == 0);

            //var model2 = new SearchFiltersModel();
            ////model2.SearchFilters = features;
            //model2.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            //model2.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);
            ////model2.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersOperatingSystems.FeatureFilters = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
            //model2.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);


            var model3 = new SearchPageModel(CustomSession);
            //model3.SearchFiltersModel.SearchFilters = features;
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_FEATURES);
            //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
            model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);


            var results = this.SearchProducts(model3.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn, null).ToList();
            //var temp = results.Where(x => x.SetupFee == null).ToList();

            //var results = _repository.GetSearchResults()
            var results2 = results
                .Select(y => new SearchResultModelOneColumn(CustomSession)
            {
                CloudApplicationID = y.CloudApplicationID,
                Description = y.Description,
                SearchResultID = y.CloudApplicationID,
                ServiceName = y.ServiceName,
                VendorLogoURL = y.Vendor.VendorLogoFileName.AddImagePath(),
                VendorName = y.Vendor.VendorName,
                ApplicationCostOneOff = y.ApplicationCostOneOff,
                ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
                ApplicationCostPerMonth = y.ApplicationCostPerMonth,
                ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
                CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
                FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
                SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,
                OperatingSystems = y.OperatingSystems.Select(x => new OperatingSystemModel()
                {
                    OperatingSystemID = x.OperatingSystemID,
                    OperatingSystemName = x.OperatingSystemName,
                }).ToList(),
                SupportTypes = y.SupportTypes.Select(x => new SupportTypeModel()
                {
                    SupportTypeID = x.SupportTypeID,
                    SupportTypeName = x.SupportTypeName,
                }).ToList(),
                SupportDays = new SupportDaysModel()
                {
                    SupportDaysID = y.SupportDays.SupportDaysID,
                    SupportDaysName = y.SupportDays.SupportDaysName,
                },
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
                    Include = x.Include,
                    IncludeCount = x.IncludeCount,
                    IncludeCountSuffix = x.IncludeCountSuffix,
                    IncludeExtraCost = x.IncludeExtraCost,

                }).ToList(),

            }
            );
            model3.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = results2.ToList();

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;
            model3.CustomSession = CustomSession;
            model3.ContainerModel.CustomSession = CustomSession;


            return View(model3);

            //return View("Index");
        }
        #endregion

        #region SearchPageMoreInfo POST
        [HttpPost]
        public ActionResult SearchPageMoreInfo(string buttonID)
        {
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            return View();
        }
        #endregion

        #region SearchPage POST
        [HttpPost]
        public ActionResult SearchPage(SearchPageModel model, FormCollection formCollection)
        {
            //PROCEED_BUTTON_APPLICATION_ID_

            model.CustomSession = CustomSession;
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = this.GetCategories();
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = this.GetNumberOfUsers();

            var oldCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
            var newCategory = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;

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

            if (toggleSearchResultsButtonPressed.Count() > 0)
            {
                GetModelFromViewData(model);
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary = !model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.DisplayAsSummary;
                FixUpViewData(model);
                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                return View(model);

            }

            if (filterHeaderButtonPressed.Count() > 0)
            {
                #region FILTER HEADER BUTTON PRESSED
                GetModelFromViewData(model);
                var pressedButton = filterHeaderButtonPressed.ElementAt(0);
                string[] filterAttributes = pressedButton.ToString().Split(';');
                string filterHeader = filterAttributes[0].Replace("FILTER_HEADER_", "").Replace(".x", "").Replace(".y", "");

                switch (filterHeader)
                {
                    case FILTER_CATEGORIES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersCategoriesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersCategoriesCollapsed;
                        break;
                    case FILTER_USERS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersUsersCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersUsersCollapsed;
                        break;
                    case FILTER_BROWSERS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsersCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsersCollapsed;
                        break;
                    case FILTER_FEATURES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeaturesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeaturesCollapsed;
                        break;
                    case FILTER_LANGUAGES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguagesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguagesCollapsed;
                        break;
                    case FILTER_MOBILEPLATFORMS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatformsCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatformsCollapsed;
                        break;
                    case FILTER_OPERATINGSYSTEMS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystemsCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystemsCollapsed;
                        break;
                    case FILTER_SUPPORTDAYS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDaysCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDaysCollapsed;
                        break;
                    case FILTER_SUPPORTHOURS:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHoursCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHoursCollapsed;
                        break;
                    case FILTER_SUPPORTTYPES:
                        model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypesCollapsed = !model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypesCollapsed;
                        break;

                }
                #endregion
                FixUpViewData(model);
                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                return View(model);
            }

            else if (filterButtonPressed.Count() > 0)
            {
                GetModelFromViewData(model);

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
                //must have come in via the filter button
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = this.GetCategories();
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = this.GetNumberOfUsers();
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

                //SearchModel newModel = new SearchModel();
                //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
                //newModel.SearchFiltersModel.Categories = this.GetCategories();
                //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
                //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

                //newModel = this.GetSearchModel(newModel);
                if (oldCategory != newCategory)
                {
                    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                    model = this.GetSearchModelFiltersOneColumn(model, true, true);
                }

                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(model).ToList();
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
                    {
                        ApplicationCostOneOff = x.ApplicationCostOneOff,
                        ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                        ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                        CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                        CloudApplicationID = x.CloudApplicationID,
                        Description = x.Description,
                        FreeTrialPeriod = x.FreeTrialPeriod,
                        IsLastInCollection = x.IsLastInCollection,
                        ResultDisplayFormat = x.ResultDisplayFormat,
                        SearchResultID = x.SearchResultID,
                        ServiceName = x.ServiceName,
                        SetupFee = x.SetupFee,
                        VendorID = x.VendorID,
                        VendorLogo = x.VendorLogo,
                        VendorLogoURL = x.VendorLogoURL,
                        VendorName = x.VendorName,
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

                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                //return View(newModel);
                bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");

                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersBrowsers");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersFeatures");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersLanguages");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersOperatingSystems");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportDays");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportHours");
                //removed = ModelState.Remove("SearchFiltersModelOneColumn.SearchFiltersSupportTypes");
                ModelState.Clear();
                model.CustomSession = CustomSession;
                return View(model);
            }

            else if (proceedButtonPressed.Count() > 0)
            {
                GetModelFromViewData(model);

                CloudApplicationModel cam = null;
                #region PROCEED BUTTON PRESSED
                if (proceedButtonPressed.Count() > 3)
                {
                    throw new Exception("Internal server error");
                }
                else
                {
                    var pressedButton = proceedButtonPressed.ElementAt(0);
                    int cloudApplicationID = int.Parse(pressedButton.Replace("PROCEED_BUTTON_APPLICATION_ID_", "").Replace(".x", "").Replace(".y", ""));

                    CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID);
                    cam = ConstructCloudApplicationModel(ca);
                }
                #endregion

                model.ContainerModel.ChosenCloudApplicationModel = cam;
                FixUpViewData(model);

                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                //return ForceDisplayTemplateViewFor(cam);

                return View("CloudApplicationModel", model);

            }

            else if (moreInfoButtonPressed.Count() > 0)
            {
                var pressedButton = moreInfoButtonPressed.ElementAt(0);
                string buttonApplicationID = pressedButton.ToString().Replace("MOREINFO_BUTTON_APPLICATION_ID_", "").Replace(".x", "").Replace(".y", "");

                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;

                GetModelFromViewData(model);
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = (IEnumerable<SearchResultModelOneColumn>)TempData["SearchResults"];
                //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = (IEnumerable<SearchResultSummaryModel>)TempData["SearchResultsSummary"];

                int searchResultIndex = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList().FindIndex(x => x.CloudApplicationID.ToString() == buttonApplicationID);
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList()[searchResultIndex].MoreInfoVisible
                    = !(model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.ToList()[searchResultIndex].MoreInfoVisible);

                FixUpViewData(model);
                //TempData["SearchResults"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults;
                //TempData["SearchResultsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;
                return View(model);
            }

            else
            {
                GetModelFromViewData(model);
                return View(model);
            }
        }
        #endregion

        #region GetModelFromViewData
        private void GetModelFromViewData(SearchPageModel model)
        {
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn = (SearchFiltersModelOneColumn)TempData["SearchFilters"];
            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn = (SearchResultsModelOneColumn)TempData["SearchResults"];
            //model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary = (IEnumerable<SearchResultSummaryModel>)TempData["SearchResultsSummary"];
            model.ContainerModel.ChosenCloudApplicationModel = (CloudApplicationModel)TempData["ChosenCloudApplicationModel"];
        }
        #endregion

        #region FixUpViewData
        private void FixUpViewData(SearchPageModel model)
        {
            TempData["SearchFilters"] = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn;
            TempData["SearchResults"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn;
            //TempData["SearchResultsSummary"] = model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary;
            TempData["ChosenCloudApplicationModel"] = model.ContainerModel.ChosenCloudApplicationModel;
        }
        #endregion

        #region ConstructCloudApplicationModel
        private CloudApplicationModel ConstructCloudApplicationModel(CloudApplication ca)
        {
            CloudApplicationModel cam = new CloudApplicationModel(CustomSession)
            {
                AddDate = ca.AddDate,
                ApplicationContentStatusID = ca.ApplicationContentStatusID,
                ApplicationCostOneOff = ca.ApplicationCostOneOff,
                ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthExtra,
                ApprovalAssignedPersonID = ca.ApprovalAssignedPersonID,
                ApprovalStatusID = ca.ApprovalStatusID,
                AverageEaseOfUse = ca.AverageEaseOfUse,
                AverageFunctionality = ca.AverageFunctionality,
                AverageOverallRating = ca.AverageOverallRating,
                AverageValueForMoney = ca.AverageValueForMoney,
                Brand = ca.Brand,
                Browsers = ca.Browsers.Select(x => new BrowserModel(CustomSession)
                {
                    BrowserColumnNumber = x.BrowserColumnNumber,
                    BrowserID = x.BrowserID,
                    BrowserName = x.BrowserName,
                    BrowserRowNumber = x.BrowserRowNumber,
                }).ToList(),
                CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,
                Category = new CategoryModel(CustomSession)
                {
                    CategoryID = ca.Category.CategoryID,
                    CategoryName = ca.Category.CategoryName,
                },
                CloudApplicationFeatures = ca.CloudApplicationFeatures.Select(y => new CloudApplicationFeatureModel()
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
                    Include = y.Include,
                    IncludeCount = y.IncludeCount,
                    IncludeCountSuffix = y.IncludeCountSuffix,
                    IncludeExtraCost = y.IncludeExtraCost,
                }).ToList(),
                CloudApplicationID = ca.CloudApplicationID,
                CloudApplicationLogo = ca.CloudApplicationLogo,
                CompanyURL = ca.CompanyURL,
                Description = ca.Description,
                FacebookFollowers = ca.FacebookFollowers,
                FacebookURL = ca.FacebookURL,
                FreeTrialBuyNow = new FreeTrialBuyNowModel(CustomSession)
                {
                    FirstName = "Glyn",
                    EMailAddress = "glyn.threadgold@yahoo.co.uk",
                },
                FreeTrialPeriod = new FreeTrialPeriodModel()
                {
                    FreeTrialPeriodID = ca.FreeTrialPeriod.FreeTrialPeriodID,
                    FreeTrialPeriodName = ca.FreeTrialPeriod.FreeTrialPeriodName,
                },
                IsPromotional = ca.IsPromotional,
                Languages = ca.Languages.Select(x => new LanguageModel()
                {
                    LanguageID = x.LanguageID,
                    LanguageName = x.LanguageName,
                }).ToList(),
                LicenceTypeMaximum = new LicenceTypeMaximumModel()
                {
                    LicenceTypeMaximumID = ca.LicenceTypeMaximum.LicenceTypeMaximumID,
                    LicenceTypeMaximumName = ca.LicenceTypeMaximum.LicenceTypeMaximumName.ToString(),
                },
                LicenceTypeMinimum = new LicenceTypeMinimumModel()
                {
                    LicenceTypeMinimumID = ca.LicenceTypeMinimum.LicenceTypeMinimumID,
                    LicenceTypeMinimumName = ca.LicenceTypeMinimum.LicenceTypeMinimumName.ToString(),
                },
                LinkedInFollowers = ca.LinkedInFollowers,
                LinkedInURL = ca.LinkedInURL,
                MaximumMeetingAttendees = ca.MaximumMeetingAttendees,
                MaximumWebinarAttendees = ca.MaximumWebinarAttendees,
                MinimumContract = new MinimumContractModel()
                {
                    MinimumContractID = ca.MinimumContract.MinimumContractID,
                    MinimumContractName = ca.MinimumContract.MinimumContractName,
                },
                MobilePlatforms = ca.MobilePlatforms.Select(x => new MobilePlatformModel()
                {
                    MobilePlatformID = x.MobilePlatformID,
                    MobilePlatformName = x.MobilePlatformName,
                }).ToList(),
                OperatingSystems = ca.OperatingSystems.Select(x => new OperatingSystemModel()
                {
                    OperatingSystemID = x.OperatingSystemID,
                    OperatingSystemName = x.OperatingSystemName,
                }).ToList(),
                PaymentFrequency = new PaymentFrequencyModel()
                {
                    PaymentFrequencyID = ca.PaymentFrequency.PaymentFrequencyID,
                    PaymentFrequencyName = ca.PaymentFrequency.PaymentFrequencyName,
                },
                PaymentOptions = ca.PaymentOptions.Select(x => new PaymentOptionModel()
                {
                    PaymentOptionID = x.PaymentOptionID,
                    PaymentOptionName = x.PaymentOptionName,
                }).ToList(),
                Ratings = ca.Ratings.Select(x => new CloudApplicationRatingModel(CustomSession)
                {
                    CloudApplicationEaseOfUse = x.CloudApplicationEaseOfUse,
                    CloudApplicationFunctionality = x.CloudApplicationFunctionality,
                    CloudApplicationOverallRating = x.CloudApplicationOverallRating,
                    CloudApplicationRatingID = x.CloudApplicationRatingID,
                    CloudApplicationRatingReviewerCompany = x.CloudApplicationRatingReviewerCompany,
                    CloudApplicationRatingReviewerName = x.CloudApplicationRatingReviewerName,
                    CloudApplicationRatingReviewerTitle = x.CloudApplicationRatingReviewerTitle,
                    CloudApplicationRatingText = x.CloudApplicationRatingText,
                    CloudApplicationValueForMoney = x.CloudApplicationValueForMoney,
                }).Take(2).ToList(),
                Reviews = ca.Reviews.Select(x => new CloudApplicationReviewModel(CustomSession)
                {
                    CloudApplicationReviewDate = x.CloudApplicationReviewDate,
                    CloudApplicationReviewHeadline = x.CloudApplicationReviewHeadline,
                    CloudApplicationReviewID = x.CloudApplicationReviewID,
                    CloudApplicationReviewPublisherName = x.CloudApplicationReviewPublisherName,
                    CloudApplicationReviewText = x.CloudApplicationReviewText,
                    CloudApplicationReviewURL = x.CloudApplicationReviewURL,
                }).Take(2).ToList()
                ,
                SearchResultModel = new SearchResultModelOneColumn(CustomSession)
                {
                    ApplicationCostOneOff = ca.ApplicationCostOneOff,
                    ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                    ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                    ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthExtra,
                    CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,
                    CloudApplicationID = ca.CloudApplicationID,
                    Description = ca.Description,
                    FreeTrialPeriod = ca.FreeTrialPeriod.FreeTrialPeriodName,
                    SearchResultID = 0,
                    ServiceName = ca.ServiceName,
                    SetupFee = ca.SetupFee.SetupFeeName,
                    VendorLogoURL = ca.Vendor.VendorLogoFileName.AddImagePath(),
                    VendorName = ca.Vendor.VendorName,
                    VendorID = ca.Vendor.VendorID,
                    ResultDisplayFormat = SearchResultDisplayFormat.Single,

                    OperatingSystems = ca.OperatingSystems.Select(x => new OperatingSystemModel()
                    {
                        OperatingSystemID = x.OperatingSystemID,
                        OperatingSystemName = x.OperatingSystemName,
                    }).ToList(),
                    SupportTypes = ca.SupportTypes.Select(x => new SupportTypeModel()
                    {
                        SupportTypeID = x.SupportTypeID,
                        SupportTypeName = x.SupportTypeName,
                    }).ToList(),
                    SupportDays = new SupportDaysModel()
                    {
                        SupportDaysID = ca.SupportDays.SupportDaysID,
                        SupportDaysName = ca.SupportDays.SupportDaysName,
                    },
                    Languages = ca.Languages.Select(x => new LanguageModel()
                    {
                        LanguageID = x.LanguageID,
                        LanguageName = x.LanguageName,
                    }).ToList(),
                    CloudApplicationFeatures = ca.CloudApplicationFeatures.Select(x => new CloudApplicationFeatureModel()
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
                        Include = x.Include,
                        IncludeCount = x.IncludeCount,
                        IncludeCountSuffix = x.IncludeCountSuffix,
                        IncludeExtraCost = x.IncludeExtraCost,

                    }).ToList(),

                },
                ServiceName = ca.ServiceName,
                SetupFee = new SetupFeeModel()
                {
                    SetupFeeID = ca.SetupFee.SetupFeeID,
                    SetupFeeName = ca.SetupFee.SetupFeeName,
                },
                SupportDays = new SupportDaysModel()
                {
                    SupportDaysID = ca.SupportDays.SupportDaysID,
                    SupportDaysName = ca.SupportDays.SupportDaysName,
                },
                SupportHours = new SupportHoursModel()
                {
                    SupportHoursID = ca.SupportHours.SupportHoursID,
                    SupportHoursName = ca.SupportHours.SupportHoursName,
                },
                SupportTerritories = ca.SupportTerritories.Select(x => new SupportTerritoryModel()
                {
                    SupportTerritoryID = x.SupportTerritoryID,
                    SupportTerritoryName = x.SupportTerritoryName,
                }).ToList(),
                SupportTypes = ca.SupportTypes.Select(x => new SupportTypeModel()
                {
                    SupportTypeID = x.SupportTypeID,
                    SupportTypeName = x.SupportTypeName,
                }).ToList(),
                ThumbnailDocuments = ca.ThumbnailDocuments.Select(x => new ThumbnailDocumentModel()
                {
                    ThumbnailDocumentFileName = x.ThumbnailDocumentFileName,
                    ThumbnailDocumentID = x.ThumbnailDocumentID,
                    ThumbnailDocumentPhysicalFilePath = x.ThumbnailDocumentPhysicalFilePath,
                    ThumbnailDocumentTitle = x.ThumbnailDocumentTitle,
                    ThumbnailDocumentType = new ThumbnailDocumentTypeModel()
                    {
                        ThumbnailDocumentTypeID = x.ThumbnailDocumentType.ThumbnailDocumentTypeID,
                        ThumbnailDocumentTypeName = x.ThumbnailDocumentType.ThumbnailDocumentTypeName,
                    },
                    ThumbnailDocumentURL = x.ThumbnailDocumentURL,
                }).ToList(),
                Title = ca.Title,
                TwitterFollowers = ca.TwitterFollowers,
                TwitterURL = ca.TwitterURL,
                Vendor = new VendorModel()
                {
                    VendorID = ca.Vendor.VendorID,
                    VendorLogo = ca.Vendor.VendorLogo,
                    VendorLogoFileName = ca.Vendor.VendorLogoFileName.Replace("/","").Replace("//",""),
                    VendorName = ca.Vendor.VendorName,
                },
                VideoTrainingSupport = ca.VideoTrainingSupport,
            };

            return cam;

        }
        #endregion

        #region SearchResultsPartial POST
        [HttpPost]
        public ActionResult SearchResultsPartial(SearchPageModel model, FormCollection formCollection)
        {
            //PROCEED_BUTTON_APPLICATION_ID_

            //var oldCategory = model.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID;
            //var newCategory = model.SearchFiltersModelOneColumn.ChosenCategoryID;

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
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = this.GetCategories();
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = this.GetNumberOfUsers();
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

                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(model).ToList();
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
    {
        ApplicationCostOneOff = x.ApplicationCostOneOff,
        ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
        ApplicationCostPerMonth = x.ApplicationCostPerMonth,
        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
        CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
        CloudApplicationID = x.CloudApplicationID,
        Description = x.Description,
        FreeTrialPeriod = x.FreeTrialPeriod,
        IsLastInCollection = x.IsLastInCollection,
        ResultDisplayFormat = x.ResultDisplayFormat,
        SearchResultID = x.SearchResultID,
        ServiceName = x.ServiceName,
        SetupFee = x.SetupFee,
        VendorID = x.VendorID,
        VendorLogo = x.VendorLogo,
        VendorLogoURL = x.VendorLogoURL,
        VendorName = x.VendorName,
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


                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                //return View(newModel);
                //bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                //ModelState.Clear();
                return PartialView("SearchResultsModel", model);

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

                    CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID);
                    CloudApplicationModel cam = ConstructCloudApplicationModel(ca);
                    return ForceDisplayTemplateViewFor(cam);
                }
                #endregion
            }
        }
        #endregion

        #region SearchFiltersPartial POST
        [HttpPost]
        public ActionResult SearchFiltersPartial(SearchPageModel model, FormCollection formCollection, bool refreshResults)
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
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = this.GetCategories();
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = this.GetNumberOfUsers();
                model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

                //SearchModel newModel = new SearchModel();
                //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
                //newModel.SearchFiltersModel.Categories = this.GetCategories();
                //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
                //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

                //newModel = this.GetSearchModel(newModel);
                if (oldCategory != newCategory)
                {
                    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                    model = this.GetSearchModelFiltersOneColumn(model, true, true);
                }

                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(model).ToList();
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
    model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
    {
        ApplicationCostOneOff = x.ApplicationCostOneOff,
        ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
        ApplicationCostPerMonth = x.ApplicationCostPerMonth,
        ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
        CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
        CloudApplicationID = x.CloudApplicationID,
        Description = x.Description,
        FreeTrialPeriod = x.FreeTrialPeriod,
        IsLastInCollection = x.IsLastInCollection,
        ResultDisplayFormat = x.ResultDisplayFormat,
        SearchResultID = x.SearchResultID,
        ServiceName = x.ServiceName,
        SetupFee = x.SetupFee,
        VendorID = x.VendorID,
        VendorLogo = x.VendorLogo,
        VendorLogoURL = x.VendorLogoURL,
        VendorName = x.VendorName,
    }).ToList();




                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                FixUpViewData(model);
                //return View(newModel);
                bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                ModelState.Clear();

                if (refreshResults)
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
        public ActionResult SearchPageNoScript(SearchPageModel model, FormCollection formCollection, string dummyValue)
        //public ActionResult SearchPageNoScript(int dummyValue)
        {
            //PROCEED_BUTTON_APPLICATION_ID_

            GetModelFromViewData(model);

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
            //must have come in via the filter button
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = this.GetCategories();
            model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = this.GetNumberOfUsers();
            //model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = newCategory;

            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(model).ToList();
            model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResultsSummary =
                model.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults.Select(x => new SearchResultSummaryModel()
                {
                    ApplicationCostOneOff = x.ApplicationCostOneOff,
                    ApplicationCostPerAnnum = x.ApplicationCostPerAnnum,
                    ApplicationCostPerMonth = x.ApplicationCostPerMonth,
                    ApplicationCostPerMonthExtra = x.ApplicationCostPerMonthExtra,
                    CallsPackageCostPerMonth = x.CallsPackageCostPerMonth,
                    CloudApplicationID = x.CloudApplicationID,
                    Description = x.Description,
                    FreeTrialPeriod = x.FreeTrialPeriod,
                    IsLastInCollection = x.IsLastInCollection,
                    ResultDisplayFormat = x.ResultDisplayFormat,
                    SearchResultID = x.SearchResultID,
                    ServiceName = x.ServiceName,
                    SetupFee = x.SetupFee,
                    VendorID = x.VendorID,
                    VendorLogo = x.VendorLogo,
                    VendorLogoURL = x.VendorLogoURL,
                    VendorName = x.VendorName,
                }).ToList();

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            model.CustomSession = CustomSession;
            FixUpViewData(model);
            return View("SearchPage", model);
            #endregion

        }
        #endregion

        #region xSearchPage3 POST
        [HttpPost]
        public ActionResult xSearchPage3(SearchFiltersForFeatureTypeModel model2)
        {
            //var results = this.SearchProducts(model2.SearchFiltersModel, null);

            //var model = new HomePageModel();
            //model.Categories = _repository.GetCategories();
            //model.OperatingSystems = _repository.GetOperatingSystems();
            //model.ChosenOperatingSystemID = 2;
            //model.ChosenCategoryID = 6;
            //model.Name = "aaa";

            //model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            //model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            //model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            //model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();

            ////var model2 = new SearchFiltersModel();
            //var filtersOneColumn =
            //    _repository.GetSearchOptions(3)
            //    .Where(x => x.SearchFeatureTypeName == FILTER_FEATURES)
            //    .Select(x => new SearchFilterModelOneColumn()
            //    {
            //        Category = x.Category != null ? x.Category : null,
            //        //SearchFilterID = x.Category.CategoryID,
            //        SearchFilterName = x.SearchFeatureName,
            //        SearchFilterType = x.SearchFeatureTypeName,
            //        Selected = false
            //    }
            //    );
            //var filtersTwoColumn =
            //    _repository.GetSearchOptions(3)
            //    .Where(x => x.SearchFeatureTypeName != FILTER_FEATURES)
            //    .Select(x => new SearchFilterModelTwoColumn()
            //    {
            //        Category = x.Category != null ? x.Category : null,
            //        //SearchFilterID = x.Category.CategoryID,
            //        SearchFilterName = x.SearchFeatureName,
            //        SearchFilterType = x.SearchFeatureTypeName,
            //        Selected = false
            //    }
            //    );


            ////model2.SearchFiltersModel.SearchFilters = features.ToList();
            //model2.SearchFiltersModel.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            ////model2.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersModel.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersModel.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersModel.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersModel.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS);
            //model2.SearchFiltersModel.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersModel.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersModel.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);

            ////var results = this.SearchProducts(model3.SearchFiltersModel, null).ToList();
            //var temp = results.Where(x => x.SetupFee == null).ToList();

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
            //model2.SearchResultsModel.SearchResults = results2.ToList();

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            //ViewBag.VisibleResultsTab = 1;



            //return View(model2);

            //return View("Index");
            return View();
        }
        #endregion

        #region CloudApplication POST
        [HttpPost]
        public ActionResult CloudApplication(SearchPageModel model, FormCollection formCollection)
        {
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
            if (emailButtonPressed.Count() > 0)
            {
                GetModelFromViewData(model);
                //SearchPageModel source = model;

                ServiceReference1.CompareCloudwareServiceClient sc = new ServiceReference1.CompareCloudwareServiceClient();
                ServiceReference1.CloudApplicationModel destination = new ServiceReference1.CloudApplicationModel();

                //AutoMapper.Mapper.CreateMap<SearchPageModel, ServiceReference1.SearchPageModel>();
                //AutoMapper.Mapper.CreateMap<SearchPageModel, ServiceReference1.SearchPageModel>()
                //.ForMember(s => s.ContainerModel, d => d.MapFrom(s => s.ContainerModel))
                ;
                //destination.ContainerModel.
                //Mapper.AssertConfigurationIsValid();
                CompareCloudware.Web.Plumbing.AutoMapObjects.MapSearchResultPDF(model.ContainerModel.ChosenCloudApplicationModel);


                destination = AutoMapper.Mapper.Map<CloudApplicationModel, ServiceReference1.CloudApplicationModel>(model.ContainerModel.ChosenCloudApplicationModel);

                ServiceReference1.AdditionalOutput ao = new ServiceReference1.AdditionalOutput();
                ao.OutputFileName = "test.htm";
                ao.PDFEngineType = ServiceReference1.PDFEngineType.ASPPDF;

                //destination.OperatingSystems = null;

                string x = sc.SendSearchResultToRAZORAndCreatePDF(destination, 1, "~/documents/", "test.pdf", true, ao);
            }

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            return View("SearchPage", model);
        }
        #endregion

        #region SearchProducts
        IQueryable<CompareCloudware.Domain.Models.CloudApplication> SearchProducts(SearchFiltersModelOneColumn model, params string[] keywords)
        {
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> allPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> categoryPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> browsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> featuresPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> operatingSystemsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportTypesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportDaysPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportHoursPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> languagesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> mobilePlatformsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> numberOfUsersPredicate;

            if (
                model.SearchFiltersBrowsers.All(x => x.Col1Selected == false) &
                //model.SearchFiltersFeatures.FeatureFilters.All(x => x.Selected == false) &
                model.SearchFiltersFeatures.All(x => x.Col1Selected == false) &
                model.SearchFiltersLanguages.All(x => x.Col1Selected == false) &
                model.SearchFiltersMobilePlatforms.All(x => x.Col1Selected == false) &
                model.SearchFiltersOperatingSystems.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportDays.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportHours.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportTypes.All(x => x.Col1Selected == false)
                )
            {
                allPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                browsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            }
            else
            {
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
                {
                    featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }
                else
                {
                    featuresPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                }
                operatingSystemsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CompareCloudware.Domain.Models.CloudApplication>();
            }
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

            InsertCategoryFilterClause(model.ChosenCategoryID, ref categoryPredicate);
            InsertNumberOfUsersFilterClause(model.ChosenNumberOfUsers, ref categoryPredicate);
            model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("BROWSERS"), x => InsertBrowserFilterClause(x, ref browsersPredicate));
            //model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).ForEachMatch(x => x.SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));
            model.SearchFiltersFeatures.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));

            model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("OPERATINGSYSTEMS"), x => InsertOperatingSystemFilterClause(x, ref operatingSystemsPredicate));
            model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTTYPES"), x => InsertSupportTypeFilterClause(x, ref supportHoursPredicate));
            model.SearchFiltersSupportDays.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTDAYS"), x => InsertSupportDaysFilterClause(x, ref supportDaysPredicate));
            model.SearchFiltersSupportHours.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTHOURS"), x => InsertSupportHoursFilterClause(x, ref supportHoursPredicate));
            model.SearchFiltersLanguages.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("LANGUAGES"), x => InsertLanguageFilterClause(x, ref languagesPredicate));
            model.SearchFiltersMobilePlatforms.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("MOBILEPLATFORMS"), x => InsertMobilePlatformFilterClause(x, ref mobilePlatformsPredicate));

            allPredicate = allPredicate.And(categoryPredicate.Expand());
            allPredicate = allPredicate.And(numberOfUsersPredicate.Expand());

            allPredicate = allPredicate.And(browsersPredicate.Expand());

            allPredicate = allPredicate.And(featuresPredicate.Expand());
            allPredicate = allPredicate.And(operatingSystemsPredicate.Expand());
            allPredicate = allPredicate.And(supportTypesPredicate.Expand());
            allPredicate = allPredicate.And(supportDaysPredicate.Expand());
            allPredicate = allPredicate.And(supportHoursPredicate.Expand());
            allPredicate = allPredicate.And(languagesPredicate.Expand());
            allPredicate = allPredicate.And(mobilePlatformsPredicate.Expand());

            var retVal = _repository.GetSearchResults(allPredicate);

            //var retVal = _repository.GetSearchResults(allPredicate.And(browsersPredicate).And(featuresPredicate));
            return retVal.AsQueryable();
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

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertCategoryFilterClause(int? categoryID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
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

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertNumberOfUsersFilterClause(int? numberOfUsers, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(numberOfUsers ?? 0) != 0)
            {
                predicate = predicate.And(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                predicate = predicate.And(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            else
            {
                predicate = predicate.Or(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                predicate = predicate.Or(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            return predicate;
        }

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertBrowserFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.Or(p => p.Browsers.Any(x => x.BrowserName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            return predicate;
        }

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertBrowserFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.Or(p => p.Browsers.Any(x => x.BrowserName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            return predicate;
        }

        public void InsertFeatureFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //return predicate;
        }

        public void InsertOperatingSystemFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.OperatingSystems.Any(x => x.OperatingSystemName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertOperatingSystemFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.OperatingSystems.Any(x => x.OperatingSystemName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertSupportTypeFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.SupportTypes.Any(x => x.SupportTypeName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertSupportTypeFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.SupportTypes.Any(x => x.SupportTypeName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertSupportHoursFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertSupportHoursFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertSupportDaysFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportDays.SupportDaysName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertSupportDaysFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportDays.SupportDaysName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertLanguageFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Languages.Any(x => x.LanguageName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertLanguageFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Languages.Any(x => x.LanguageName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertMobilePlatformFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.MobilePlatforms.Any(x => x.MobilePlatformName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertMobilePlatformFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.MobilePlatforms.Any(x => x.MobilePlatformName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region ForceDisplayTemplateViewFor
        protected ViewResult ForceDisplayTemplateViewFor(object model)
        {
            return View("ForceDisplayTemplate", model);
        }
        #endregion

        #region ShowImage
        public ActionResult ShowImage(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            return File(td.ThumbnailImage, "image/jpg");
        }
        #endregion

        #region ShowAdvertisingImage
        public ActionResult ShowAdvertisingImage(int advertisingImageID)
        {
            advertisingImageID = new Random().Next(1, 11);
            AdvertisingImage ai = _repository.GetAdvertisingImage(advertisingImageID);
            return File(ai.AdvertisingImageBytes, "image/jpg");
        }

        public ActionResult ShowSkyScraper(int advertisingImageID)
        {
            advertisingImageID = new Random().Next(12, 15);
            AdvertisingImage ai = null;
            ai = _repository.GetAdvertisingImage(advertisingImageID, (int)AdvertSize.SkyScraper);
            return File(ai.AdvertisingImageBytes, "image/jpg");
        }
        #endregion

        #region ShowLogo
        public ActionResult ShowLogo(int vendorID)
        {
            Vendor v = _repository.FindVendorByID(vendorID);
            return v.VendorLogo != null ? File(v.VendorLogo, "image/jpg") : null;
        }
        #endregion

        #region RedirectInCloudCompareWebsiteToShowDocument
        public ActionResult RedirectInCloudCompareWebsiteToShowDocument(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            //td.ThumbnailDocumentURL = "http://www.bbc.co.uk";
            PdfResult pr = new PdfResult(td);
            return pr;
            //td.ThumbnailDocumentURL;
        }
        #endregion

        #region RedirectToDocumentOwnerWebsiteToShowDocument
        public ActionResult RedirectToDocumentOwnerWebsiteToShowDocument(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            td.ThumbnailDocumentURL = "http://www.bbc.co.uk";
            //return View();
            //td.ThumbnailDocumentURL;
            RedirectResult rr = new RedirectResult(td.ThumbnailDocumentURL);
            return rr;
        }
        #endregion

        #region DownloadFile
        public FileResult DownloadFile(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            //int fid = Convert.ToInt32(id);
            //var files = objData.GetFiles();
            //string filename = (from f in files
            //                   where f.FileId == fid
            //                   select f.FilePath).First();
            string fileName = td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName;
            string contentType = "application/pdf";
            //Parameters to file are
            //1. The File Path on the File Server
            //2. The content type MIME type
            //3. The parameter for the file save by the browser
            //return File(fileName, contentType, "Report.pdf");
            return File(fileName, contentType, td.ThumbnailDocumentFileName);
        }
        #endregion

        #region Header
        public ActionResult xHeaderModel()
        {
            //string button = fc.GetSubmitButtonName();
            HeaderModel hm = new HeaderModel(null);

            hm.Categories = this.GetCategories();
            hm.CustomSession = this.CustomSession;
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            return PartialView("HeaderModel", hm);
        }

        public ActionResult HeaderModel(HeaderModel hm)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();

            hm.Categories = this.GetCategories();
            hm.CustomSession = this.CustomSession;
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            return PartialView("HeaderModel", hm);
        }

        [HttpPost]
        public ActionResult HeaderModel(HeaderModel hm, FormCollection fc)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();
            var categoryButton = fc
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("CATEGORY_BUTTON_"))
                //.SingleOrDefault()
            ;

            if (categoryButton.Count() == 0)
            {
                //must have clicked an icon
                var icon = fc.Keys.OfType<string>().Where(x => x.StartsWith("ICON_"));
                if (icon.Count() > 0)
                {
                    switch (icon.ElementAt(0).Replace("ICON_", "").Replace(".x", "").Replace(".y", ""))
                    {
                        case "TWITTER": return RedirectToAction("TwitterModel");
                        case "FACEBOOK": return RedirectToAction("FacebookModel");
                        case "LINKEDIN": return RedirectToAction("LinkedInModel");
                        case "GOOGLE": return RedirectToAction("GoogleModel");
                        case "BROADCAST": return RedirectToAction("BroadcastModel");
                    }
                }
                //return RedirectToAction("CategoryPage", new { categoryID = 1 });
                hm.Categories = this.GetCategories();
                hm.CustomSession = CustomSession;
                return PartialView("HeaderModel", hm);
            }
            else
            {
                var pressedButton = categoryButton.ElementAt(0);
                int chosenCategoryID = int.Parse(pressedButton.Replace("CATEGORY_BUTTON_", "").Replace(".x", "").Replace(".y", ""));

                //hm.Categories = this.GetCategories();
                //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

                return RedirectToAction("CategoryPage", new { categoryID = chosenCategoryID });
                //return View("CategoryPage", model);
            }
        }

        #endregion

        #region Footer
        public ActionResult FooterModel(HeaderModel hm)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();

            hm.Categories = this.GetCategories();
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            return PartialView("FooterModel", hm);
        }

        [HttpPost]
        public ActionResult FooterModel(HeaderModel hm, FormCollection fc)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();
            var categoryButton = fc
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("CATEGORY_BUTTON_"))
                //.SingleOrDefault()
            ;

            if (categoryButton.Count() == 0)
            {
                //must have clicked an icon
                var icon = fc.Keys.OfType<string>().Where(x => x.StartsWith("ICON_"));
                if (icon.Count() > 0)
                {
                    switch (icon.ElementAt(0).Replace("ICON_", "").Replace(".x", "").Replace(".y", ""))
                    {
                        case "TWITTER": return RedirectToAction("TwitterModel");
                        case "FACEBOOK": return RedirectToAction("FacebookModel");
                        case "LINKEDIN": return RedirectToAction("LinkedInModel");
                        case "GOOGLE": return RedirectToAction("GoogleModel");
                        case "BROADCAST": return RedirectToAction("BroadcastModel");
                    }
                }
                //return RedirectToAction("CategoryPage", new { categoryID = 1 });
                hm.Categories = this.GetCategories();
                return PartialView("FooterModel", hm);
            }
            else
            {
                var pressedButton = categoryButton.ElementAt(0);
                int chosenCategoryID = int.Parse(pressedButton.Replace("CATEGORY_BUTTON_", "").Replace(".x", "").Replace(".y", ""));

                //hm.Categories = this.GetCategories();
                //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

                return RedirectToAction("CategoryPage", new { categoryID = chosenCategoryID });
                //return View("CategoryPage", model);
            }
        }

        #endregion

        #region CategoryPage
        public ActionResult CategoryPage(int categoryID, CategoryPageModel model2)
        {
            var model = new CategoryPageModel(CustomSession);
            model.SearchInputModel = new SearchInputModel(CustomSession);

            model.SearchInputModel.Categories = this.GetCategories();
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();
            //model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = categoryID;
            //model.SearchInputModel.Firstname = "Glyn";
            //model.SearchInputModel.EMailAddress = "somebody@anywhere.com";
            model.SearchInputModel.DisplayStyle = SearchInputModelStyle.CategoryPage;

            model.TabbedSearchResultsModel = new TabbedSearchResultsModel(CustomSession);
            model.TabbedSearchResultsModel.FeaturedCloudware = ConvertSearchResult(_repository.GetFeaturedCloudware(categoryID));
            model.TabbedSearchResultsModel.TopTenCloudware = ConvertSearchResult(_repository.GetTopTenCloudware(categoryID));
            model.TabbedSearchResultsModel.NewCloudware = ConvertSearchResult(_repository.GetNewCloudware(categoryID));

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;



            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;



            return View(model);

            //return View("Index");
        }
        #endregion


        #region CategoryPage POST
        [HttpPost]
        public ActionResult CategoryPage(CategoryPageModel model)
        {
            if (model.SearchInputModel != null)
            {
                model.SearchInputModel.Categories = this.GetCategories();
                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();


                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                ViewBag.VisibleResultsTab = 1;
                SearchPageModel searchModel = new SearchPageModel(CustomSession);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.SearchInputModel.Categories;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = model.SearchInputModel.ChosenNumberOfUsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

                searchModel = this.GetSearchModelFiltersOneColumn(searchModel, false, false);
                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(searchModel).ToList();

                return View("SearchPage", searchModel);

            }
            else
            {
                model.SearchInputModel.Categories = this.GetCategories();
                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();


                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                ViewBag.VisibleResultsTab = 1;
                SearchPageModel searchModel = new SearchPageModel(CustomSession);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.SearchInputModel.Categories;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = model.SearchInputModel.ChosenNumberOfUsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

                searchModel = this.GetSearchModelFiltersOneColumn(searchModel, false, false);
                searchModel.ContainerModel.SearchResultsModel.SearchResultsModelOneColumn.SearchResults = this.GetSearchResults(searchModel).ToList();

                return View("CategoryPage", searchModel);
            }
        }
        #endregion

        #region GetCategories
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> retVal = _repository.GetCategories().Select(x => new CategoryModel(CustomSession)
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
        public List<NumberOfUsersModel> GetNumberOfUsers()
        {
            List<NumberOfUsersModel> retVal = _repository.GetNumberOfUsers().Select(x => new NumberOfUsersModel()
            {
                UserValue = x.UserValue,
            }).ToList();

            return retVal;
        }
        #endregion

        #region GetSearchModelFiltersOneColumn
        public SearchPageModel GetSearchModelFiltersOneColumn(SearchPageModel model, bool featuresOnly, bool clearExistingFilters)
        {

            var allFiltersAsOneColumn = _repository.GetFiltersOneColumn((int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID, (int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers);
            //get all the search filters which need to be rendered as one column
            var justFeaturesFilters =
                //_repository.GetSearchOptions(3)
                allFiltersAsOneColumn
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn(CustomSession)
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
                }
                );

            var searchModel = new SearchPageModel(CustomSession);
            if (featuresOnly)
            {
                //simply replace the other filters with the original model filters, clear out the existing selected value if necessary
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes = clearExistingFilters ? model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes.ClearValues() : model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes;

            }
            else
            {
                //get all the search filters which need to be rendered as two column
                var filtersExcludingFeatures =
                    //_repository.GetSearchOptions(3)
                    allFiltersAsOneColumn
                    .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                    .Select(x => new SearchFilterModelOneColumn(CustomSession)
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
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersBrowsers = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
                //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersLanguages = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersMobilePlatforms = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
                //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersOperatingSystems = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportDays = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportHours = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersSupportTypes = filtersExcludingFeatures.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);
            }

            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.PreviouslyChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenCategoryID;
            //searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.Categories;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.ChosenNumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.NumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn.SearchFiltersFeatures = justFeaturesFilters.Where(x => x.Col1SearchFilterType == FILTER_FEATURES);


            return searchModel;

        }
        #endregion

        #region SetFilterHeadersCollapsedStatus
        private void SetFilterHeadersCollapsedStatus(SearchFiltersModelOneColumn filtersModel)
        {
            filtersModel.SearchFiltersBrowsersCollapsed = true;
            filtersModel.SearchFiltersFeaturesCollapsed = true;
            filtersModel.SearchFiltersLanguagesCollapsed = true;
            filtersModel.SearchFiltersMobilePlatformsCollapsed = true;
            filtersModel.SearchFiltersOperatingSystemsCollapsed = true;
            filtersModel.SearchFiltersSupportDaysCollapsed = true;
            filtersModel.SearchFiltersSupportHoursCollapsed = true;
            filtersModel.SearchFiltersSupportTypesCollapsed = true;
        }
        #endregion

        #region GetSearchModelFiltersTwoColumn
        public SearchPageModel xGetSearchModelFiltersTwoColumn(SearchPageModel model, bool featuresOnly)
        {

            var twoCols = _repository.GetFiltersTwoColumn((int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID, (int)model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenNumberOfUsers);
            //get all the search filters which need to be rendered as one column
            var filtersOneColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn(CustomSession)
                {
                    Category = x.CategoryCol1 != null ? new CategoryModel()
                    {
                        CategoryID = x.CategoryCol1.CategoryID,
                        CategoryName = x.CategoryCol1.CategoryName,
                    }
                    : null,
                    //x.CategoryCol1 : null,
                    //SearchFilterID = x.Category.CategoryID,
                    Col1SearchFilterName = x.SearchFilterNameCol1,
                    Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                    Col1Selected = false,
                }
                );

            var searchModel = new SearchPageModel(CustomSession);
            if (!featuresOnly)
            {
                //get all the search filters which need to be rendered as two column
                var filtersTwoColumn =
                    //_repository.GetSearchOptions(3)
                    twoCols
                    .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                    .Select(x => new SearchFilterModelTwoColumn(CustomSession)
                    {
                        //Category = x.Category != null ? x.Category : null,
                        //SearchFilterID = x.Category.CategoryID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                        Col2SearchFilterName = x.SearchFilterNameCol2,
                        Col2SearchFilterType = x.SearchFilterTypeNameCol2,
                        Col2Selected = false
                    }
                    );
                //model3.SearchFiltersModel.SearchFilters = features;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
                //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
                //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);
            }
            else
            {
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersBrowsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersBrowsers;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersLanguages = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersLanguages;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersMobilePlatforms = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersMobilePlatforms;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersOperatingSystems = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersOperatingSystems;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportDays = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportDays;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportHours = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportHours;
                searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportTypes = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersSupportTypes;
            }

            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.PreviouslyChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenCategoryID;
            //searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.Categories = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.Categories;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenNumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.ChosenNumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.NumberOfUsers = model.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.NumberOfUsers;
            searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelTwoColumn.SearchFiltersFeatures = filtersOneColumn.Where(x => x.Col1SearchFilterType == FILTER_FEATURES);


            return searchModel;

        }
        #endregion

        #region GetSearchResults
        private IEnumerable<SearchResultModelOneColumn> GetSearchResults(SearchPageModel searchModel)
        {
            var searchResults = this.SearchProducts(searchModel.ContainerModel.SearchFiltersModel.SearchFiltersModelOneColumn, null).ToList();
            int i = 0;
            var searchResultsForModel = searchResults
    .Select(y => new SearchResultModelOneColumn(CustomSession)
    {
        CloudApplicationID = y.CloudApplicationID,
        Description = y.Description,
        SearchResultID = i++,
        ServiceName = y.ServiceName,
        VendorLogoURL = y.Vendor.VendorLogoFileName.AddImagePath(),
        VendorName = y.Vendor.VendorName,
        ApplicationCostOneOff = y.ApplicationCostOneOff,
        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
        FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,
        ResultDisplayFormat = SearchResultDisplayFormat.Multiple,
        VendorID = y.Vendor.VendorID,

        OperatingSystems = y.OperatingSystems.Select(x => new OperatingSystemModel()
        {
            OperatingSystemID = x.OperatingSystemID,
            OperatingSystemName = x.OperatingSystemName,
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
            Include = x.Include,
            IncludeCount = x.IncludeCount,
            IncludeCountSuffix = x.IncludeCountSuffix,
            IncludeExtraCost = x.IncludeExtraCost,

        }).ToList(),

    }
).ToList();
            if (searchResultsForModel.Count > 0)
            {
                searchResultsForModel[searchResultsForModel.Count - 1].IsLastInCollection = true;
            }
            return searchResultsForModel;
        }
        #endregion

        #region GetMPU


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

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
            }
        }
    }
    #endregion

    #region PdfResult
    public class PdfResult : ActionResult
    {
        //private members
        private byte[] pdfBytes;
        public PdfResult(ThumbnailDocument td) 
        {
            //System.IO.FileStream fs = new System.IO.FileStream(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName,System.IO.FileMode.Open);
            //using (System.IO.FileStream fs = System.IO.File.OpenRead(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName))
            {
                //System.IO.MemoryStream ms = new System.IO.MemoryStream((int)fs.Length);
                //int read = fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                pdfBytes = System.IO.File.ReadAllBytes(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName);
            }
            
        }
        public override void ExecuteResult(ControllerContext context) 
        {
            //create the pdf in a byte array then drop it into the response
            context.HttpContext.Response.Clear();
            context.HttpContext.Response.ContentType = "application/pdf";
            //context.HttpContext.Response.AddHeader("content-disposition", "attachment;filename=xxx.pdf");
            context.HttpContext.Response.AddHeader("content-disposition", "inline;");
            context.HttpContext.Response.OutputStream.Write(pdfBytes.ToArray(), 0, pdfBytes.ToArray().Length);
            context.HttpContext.Response.End();
        }
    }
    #endregion
}
