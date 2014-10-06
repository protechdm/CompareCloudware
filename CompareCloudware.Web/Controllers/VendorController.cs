using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.Web;
using CompareCloudware.Web.Models;
using System;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using CompareCloudware.Web.Helpers;
using System.Drawing;
using System.IO;
using System.Net;
using System.Drawing.Drawing2D;
using CompareCloudware.Domain.Models;
using CompareCloudware.SocialNetworking;
using System.Configuration;
using System.Data.Objects;

using System.Web;

namespace CompareCloudware.Web.Controllers
{
    [Authorize]
    public class VendorController : BaseController
    {
        const string FILTER_CATEGORIES = "CATEGORIES";
        const string FILTER_USERS = "USERS";
        const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_FEATURES = "FEATURES";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_DEVICES = "DEVICES";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";
        const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURES";
        const string FILTER_TIMEZONES = "TIMEZONES";

        int minimumContiguousSupportDays;
        int maximumContiguousSupportDays;
        int defaultContiguousSupportDays;
        int supportHoursStepInterval;
        int testCategoryID;

        public VendorController(ICustomSession session, ICompareCloudwareRepository repository, ISiteAnalyticsLogger _SiteAnalyticsLogger)
            : base(session, repository,_SiteAnalyticsLogger)
        {
            this.CustomSession = session;
            minimumContiguousSupportDays = int.Parse(ConfigurationManager.AppSettings["MinimumContiguousSupportDays"]);
            maximumContiguousSupportDays = int.Parse(ConfigurationManager.AppSettings["MaximumContiguousSupportDays"]);
            defaultContiguousSupportDays = int.Parse(ConfigurationManager.AppSettings["DefaultContiguousSupportDays"]);
            supportHoursStepInterval = int.Parse(ConfigurationManager.AppSettings["SupportHoursStepInterval"]);
            testCategoryID = 5;
        }

        #region AddNewVendor
        [HttpGet]
        public ActionResult AddNewVendor()
        {
            return base.View(new VendorModel(this.CustomSession));
        }

        [HttpPost]
        public ActionResult AddNewVendor(VendorModel model)
        {
            if (!base.ModelState.IsValid)
            {
                return base.View(model);
            }
            return base.RedirectToAction("AddNewVendor");
        }
        #endregion

        #region Create
        public ActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return base.RedirectToAction("Index");
            }
            catch
            {
                return base.View();
            }
        }
        #endregion

        #region Delete
        public ActionResult Delete(int id)
        {
            return base.View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return base.RedirectToAction("Index");
            }
            catch
            {
                return base.View();
            }
        }
        #endregion

        #region Details
        public ActionResult Details(int id)
        {
            return base.View();
        }
        #endregion

        #region Edit
        public ActionResult Edit(int id)
        {
            return base.View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return base.RedirectToAction("Index");
            }
            catch
            {
                return base.View();
            }
        }
        #endregion

        public ActionResult Index()
        {
            Logger.Debug("Entered site");
            var bc = Request.Browser;
            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;
            SiteActivities.Log(_repository, Request);

            return RedirectToAction("RegisterApplication");
            //return RedirectToAction("UploadImage");
            //return RedirectToAction("UploadImageModal");
            //return base.View();
        }

        public ActionResult IndexCustom(int cloudApplicationID)
        {
            Logger.Debug("Entered site");
            var bc = Request.Browser;
            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;
            SiteActivities.Log(_repository, Request);

            return RedirectToAction("EditApplication", new { cloudApplicationID = cloudApplicationID });
            //return RedirectToAction("UploadImage");
            //return RedirectToAction("UploadImageModal");
            //return base.View();
        }

        //private ICustomSession CustomSession { get; set; }

        #region Header
        public override ActionResult xHeaderModel()
        {
            return base.xHeaderModel();
        }

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

        #region EditApplication
        //[HttpPost]
        public ActionResult EditApplication(int cloudApplicationID)
        {
            CustomSession.EditMode = true;

            HttpRequestBase request = this.Request;
            this.CustomSession.DetectedAgent = request.UserAgent;
            this.CustomSession.DetectedBrowserIsAPhone = request.UserAgent.ToUpperInvariant().Contains("PHONE");
            this.CustomSession.DetectedBrowserIsAnIPAD = request.UserAgent.ToUpperInvariant().Contains("IPAD");

            if (TempData["CloudApplicationInputModel"] != null)
            {
                CloudApplicationInputModel tempcaim = (CloudApplicationInputModel)TempData["CloudApplicationInputModel"];
                if (tempcaim.CloudApplicationID != cloudApplicationID)
                {
                    TempData["CloudApplicationInputModel"] = null;
                }
            }
            //editMode = true;
            CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID,false,true);
            testCategoryID = ca.Category.CategoryID;
            CloudApplicationInputModel caim = ConstructCloudApplicationInputModel(ca);

            SetContainersCollapsed(caim);

            caim.CustomSession = CustomSession;
            return View("RegisterApplication",caim);
        }
        #endregion

        #region RegisterApplication
        [SessionExpireFilter]
        public ActionResult RegisterApplication()
        {
            //var model = new HomePageModel(CustomSession);
            //model.SearchInputModel = new SearchInputModel(CustomSession);
            //var model = ConstructHomePageModel(new HomePageModel(CustomSession) { SearchInputModel = new SearchInputModel(CustomSession) });
            CustomSession.SessionVXModel = null;

            CloudApplication ca = GetModelFromViewData();
            CloudApplicationInputModel caim = GetInputModelFromViewData(false);
            ca.ServiceName = "Test Service";
            ca.Description = "Test Description";
            caim.HasVideo = HasVideo();
            ca = AddChildrenToContextForDialogs(caim);
            caim = ConstructCloudApplicationInputModel(ca);

            
            //FixUpViewData(model);
            //_repository.AddCloudApplication(


            caim.Categories.ChosenValue = caim.Categories.ChosenValue == null ? testCategoryID.ToString() : caim.Categories.ChosenValue;
            caim.Categories.SelectListItems.Find(x => x.Value == caim.Categories.ChosenValue).Selected = true;

            ViewBag.VisibleResultsTab = 1;
            return View(caim);

            //return View("Index");
        }

        [HttpPost]
        public ActionResult RegisterApplication(CloudApplicationInputModel model)
        {
            //video was changed via AJAX method so lost view state (HiddenFor fields)!
            //if (model.CloudApplicationVideos == null)
            //{
            //    model.CloudApplicationVideos = GetInputModelFromViewData(true).CloudApplicationVideos;
            //}

            //model.CloudApplicationDocuments = GetInputModelFromViewData(true).CloudApplicationDocuments;
            //model.CloudApplicationUserReviews = GetInputModelFromViewData(true).CloudApplicationUserReviews;
            //model.CloudApplicationProductReviews = GetInputModelFromViewData(true).CloudApplicationProductReviews;

            //model = ConstructCloudApplicationInputModelLists(model);
            int costPerAnnumFrom = (model.ApplicationCostPerAnnumFromWhole*100) + model.ApplicationCostPerAnnumFromFraction;
            int costPerAnnumTo = (model.ApplicationCostPerAnnumToWhole*100) + model.ApplicationCostPerAnnumToFraction;
            int costPerAnnumSingle = (model.ApplicationCostPerAnnumWhole*100) + model.ApplicationCostPerAnnumFraction;

            int costPerMonthFrom = (model.ApplicationCostPerMonthFromWhole*100) + model.ApplicationCostPerMonthFromFraction;
            int costPerMonthTo = (model.ApplicationCostPerMonthToWhole*100) + model.ApplicationCostPerMonthToFraction;
            int costPerMonthSingle = (model.ApplicationCostPerMonthWhole * 100) + model.ApplicationCostPerMonthFraction;

            if ((costPerAnnumFrom > 0 && costPerAnnumTo == 0) || (costPerAnnumFrom == 0 && costPerAnnumTo > 0))
            {
                //ModelState.AddModelError("CostPerAnnumFromTo", "Cost per annum needs both a 'from' and a 'to' cost");
            }
            if ((costPerAnnumFrom > 0 || costPerAnnumTo > 0) && costPerAnnumSingle > 0)
            {
                ModelState.AddModelError("CostPerAnnum", "Cost per annum cannot have both a 'from' and a 'to' cost and a single cost");
            }
            if ((costPerAnnumFrom >= costPerAnnumTo) && costPerAnnumFrom > 0)
            {
                //ModelState.AddModelError("CostPerAnnum", "Cost per annum 'to' must be greater than cost per annum 'from'");
            }
            
            if ((costPerMonthFrom > 0 && costPerMonthTo == 0) || (costPerMonthFrom == 0 && costPerMonthTo > 0))
            {
                //ModelState.AddModelError("CostPerMonthFromTo", "Cost per month needs both a 'from' and a 'to' cost");
            }
            if ((costPerMonthFrom > 0 || costPerMonthTo > 0) && costPerMonthSingle > 0)
            {
                ModelState.AddModelError("CostPerMonth", "Cost per month cannot have both a 'from' and a 'to' cost and a single cost");
            }
            if ((costPerMonthFrom >= costPerMonthTo) && costPerMonthFrom > 0)
            {
                //ModelState.AddModelError("CostPerMonth", "Cost per month 'to' must be greater than cost per month 'from'");
            }

            model.ApplicationHasActiveSupport = ModelHelpers.ApplicationHasActiveSupport(model.SupportTypes.SelectListItems);

            if (model.ApplicationHasActiveSupport)
            {
                if (_repository.FindSupportHoursByName(int.Parse(model.SupportHoursFrom.ChosenValue), int.Parse(model.SupportHoursTo.ChosenValue)) == null)
                {
                    ModelState.AddModelError("Support Hours", "Error with chosen support hours");
                }
            }
            

            //FixUpViewData(model);
            if (ModelState.IsValid)
            {
                CloudApplication ca = ConstructCloudApplicationFromCloudApplicationInputModel(model);

                try
                {
                    ca.CloudApplicationApplications.ForEach(x => _repository.Update<CloudApplicationApplication>("-1", x, RefreshMode.ClientWins));
                    _repository.Update<CloudApplication>("-1", ca, RefreshMode.ClientWins);
                    if (_repository.GetCloudApplicationContextModified() != null)
                    {
                        throw new Exception("Cloud Application still in context");
                    }
                    
                    //ca = _repository.GetCloudApplicationContextModified();
                    TempData.Clear();
                    CustomSession.SessionVXModel = null;

                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
                {
                    _repository.Update<CloudApplication>("-1", ca);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

                try
                {
                    if (model.CloudApplicationUserReviewsContainerModel.ApplyUserReviewsAtVendorLevel)
                    {
                        CopyUserReviewsToOtherBrands(ca);
                    }
                    if (model.CloudApplicationProductReviewsContainerModel.ApplyProductReviewsAtVendorLevel)
                    {
                        CopyProductReviewsToOtherBrands(ca);
                    }
                    if (model.CloudApplicationDocumentsContainerModel.ApplyDocumentsAtVendorLevel)
                    {
                        CopyDocumentsToOtherBrands(ca);
                    }
                    if (model.ApplyLanguagesAtVendorLevel)
                    {
                        CopyLanguagesToOtherBrands(ca);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

                model = ConstructCloudApplicationInputModel(ca);
                
                //model.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(model, ca);
                model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(model, ca);
                AddNewCloudApplicationUserReview(model);
                
                foreach (CloudApplicationVideoModel cavm in model.CloudApplicationVideosContainerModel.CloudApplicationVideos)
                {
                    cavm.CustomSession = CustomSession;
                }

                ModelState.Clear();

            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();
                var result = ViewData.ModelState.SelectMany(x => x.Value.Errors
                   .Where(error => error.Exception != null)
                   .Select(error => new KeyValuePair<string, Exception>(x.Key, error.Exception)));
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);

                CloudApplication ca = ConstructCloudApplicationFromCloudApplicationInputModel(model);
                ReconstructSelectLists(model,ca);
                //model.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(model, ca);
                model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(model, ca);
                AddNewCloudApplicationUserReview(model);
                foreach (CloudApplicationVideoModel cavm in model.CloudApplicationVideosContainerModel.CloudApplicationVideos)
                {
                    cavm.CustomSession = CustomSession;
                }

            }
            this.ConstructSelectLists(model);
            model.CustomSession = CustomSession;
            return View(model);
        }

        [HttpPost]
        public ActionResult RegisterApplicationNoPersist(CloudApplicationInputModel model)
        {
            //video was changed via AJAX method so lost view state (HiddenFor fields)!
            if (model.CloudApplicationVideosContainerModel == null)
            {
                model.CloudApplicationVideosContainerModel = GetInputModelFromViewData(true).CloudApplicationVideosContainerModel;
            }

            model = ConstructCloudApplicationInputModelLists(model);

            //ConstructCloudApplicationFromCloudApplicationInputModel(model);

            CloudApplication ca = ConstructCloudApplicationFromCloudApplicationInputModel(model);
            //_repository.Update<CloudApplication>("-1", ca);

            model.CustomSession = CustomSession;
            //return View(model);
            return null;
        }

        #endregion

        #region ConstructCloudApplicationInputModelLists
        private CloudApplicationInputModel ConstructCloudApplicationInputModelLists(CloudApplicationInputModel model)
        {
            #region Categories
            //inputModel.Categories.ChosenValue = inputModel.Categories.ChosenValue == null ? "6" : inputModel.Categories.ChosenValue;
            //inputModel.Categories.SelectListItems.Find(x => x.Value == inputModel.Categories.ChosenValue).Selected = true;
            //int chosenCategory = int.Parse(inputModel.Categories.ChosenValue);


            //model.Categories.ColumnCount = 2;
            //model.Categories.CollectionTitle = "Category";
            model.Categories.SelectListItems = ModelHelpers.GetCategories(this.CustomSession,_repository).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.CategoryName,
                Value = x.CategoryID.ToString(),
            }).ToList();
            //model.Categories.MultiSelect = false;


            #endregion

            #region Features
            int chosenCategory = int.Parse(model.Categories.ChosenValue);

            if (model.Features == null)
            {
                model.Features = new SelectListItemCollectionFeatures();
                model.Features.ColumnCount = 1;
                model.Features.CollectionTitle = "Features";
                model.Features.SelectListItems = this.GetFeaturesForChosenCategory(chosenCategory).Select(x => new SelectListItemFeature()
                {
                    Selected = false,
                    Text = x.Feature.FeatureName,
                    Value = x.Feature.FeatureID.ToString(),

                    CostWhole = (int)System.Math.Truncate(x.Cost),
                    CostFraction = (int)(x.Cost - System.Math.Truncate(x.Cost)),
                    Count = (int)x.Count,
                    CountSuffix = x.CountSuffix,
                    //Include = x.Include,
                    IncludeExtraCost = false,
                    HasCount = x.HasCount,
                    OutputDisplayDescriptor = x.OutputDisplayDescriptor,

                }).ToList();
                model.Features.MultiSelect = true;
            }
            #endregion

            #region Devices
            //model.Devices.ColumnCount = 2;
            //model.Devices.CollectionTitle = "Devices";
            //model.Devices.SelectListItems = _repository.GetDevices().Select(x => new SelectListItem()
            //{
            //    Selected = false,
            //    Text = x.DeviceName,
            //    Value = x.DeviceID.ToString(),
            //}).ToList();
            //model.Devices.MultiSelect = true;
            #endregion

            #region MobilePlatforms
            if (model.MobilePlatforms == null)
            {
                model.MobilePlatforms.ColumnCount = 2;
                model.MobilePlatforms.CollectionTitle = "Mobile Platforms";
                model.MobilePlatforms.SelectListItems = _repository.GetMobilePlatforms().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.MobilePlatformName,
                    Value = x.MobilePlatformID.ToString(),
                }).ToList();
                model.MobilePlatforms.MultiSelect = true;
            }
            #endregion

            #region OperatingSystems
            if (model.OperatingSystems == null)
            {
                model.OperatingSystems.ColumnCount = 2;
                model.OperatingSystems.CollectionTitle = "Mobile Platforms";
                model.OperatingSystems.SelectListItems = _repository.GetOperatingSystems().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.OperatingSystemName,
                    Value = x.OperatingSystemID.ToString(),
                }).ToList();
                model.OperatingSystems.MultiSelect = true;
            }
            #endregion

            #region Browsers
            if (model.Browsers == null)
            {
                model.Browsers.ColumnCount = 2;
                model.Browsers.CollectionTitle = "Browsers supported";
                model.Browsers.SelectListItems = _repository.GetBrowsers().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.BrowserName,
                    Value = x.BrowserID.ToString(),
                }).ToList();
                model.Browsers.MultiSelect = true;
            }
            #endregion

            #region Languages
            if (model.Languages == null)
            {
                model.Languages.ColumnCount = 3;
                model.Languages.CollectionTitle = "Languages";
                model.Languages.SelectListItems = _repository.GetLanguages().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.LanguageName,
                    Value = x.LanguageID.ToString(),
                }).ToList();
                model.Languages.MultiSelect = true;
            }
            #endregion

            #region SupportTypes
            if (model.SupportTypes == null)
            {
                model.SupportTypes.ColumnCount = 4;
                model.SupportTypes.CollectionTitle = "Support Types";
                model.SupportTypes.SelectListItems = _repository.GetSupportTypes().Select(x => new SelectListItemSupportType()
                {
                    Selected = false,
                    Text = x.SupportTypeName,
                    Value = x.SupportTypeID.ToString(),
                    IsPassive = x.IsPassive,
                }).ToList();
                model.SupportTypes.MultiSelect = true;
            }
            #endregion

            #region SupportHours
            if (model.SupportHours.SelectListItems == null)
            {
                //model.SupportHours.ColumnCount = 2;
                //model.SupportHours.CollectionTitle = "Support Hours";
                model.SupportHours.SelectListItems = _repository.GetSupportHours().Where(x => x.SupportHoursName != "ALL").Select(x => new SelectListItem()
                {
                    Selected = (x.SupportHoursID.ToString() == model.SupportHours.ChosenValue),
                    Text = x.SupportHoursName,
                    Value = x.SupportHoursID.ToString(),
                }).ToList();
                //model.SupportHours.MultiSelect = false;
            }
            #endregion

            #region SupportDays
            if (model.SupportDays.SelectListItems == null)
            {
                //model.SupportDays.ColumnCount = 3;
                //model.SupportDays.CollectionTitle = "Support Days";
                model.SupportDays.SelectListItems = _repository.GetSupportDays().Where(x => x.SupportDaysName != "ALL").Select(x => new SelectListItem()
                {
                    Selected = (x.SupportDaysID.ToString() == model.SupportDays.ChosenValue),
                    Text = x.SupportDaysName,
                    Value = x.SupportDaysID.ToString(),
                }).ToList();
                //model.SupportDays.MultiSelect = false;
            }
            #endregion

            #region SupportTerritories
            if (model.SupportTerritories.SelectListItems == null)
            {
                //model.SupportTerritories.ColumnCount = 3;
                //model.SupportTerritories.CollectionTitle = "Customer service location";
                model.SupportTerritories.SelectListItems = _repository.GetSupportTerritories().Select(x => new SelectListItem()
                {
                    Selected = (x.SupportTerritoryID.ToString() == model.SupportTerritories.ChosenValue),
                    Text = x.SupportTerritoryName,
                    Value = x.SupportTerritoryID.ToString(),
                }).ToList();
                //model.SupportTerritories.MultiSelect = false;
            }
            #endregion

            #region PaymentOptions
            if (model.PaymentOptions == null)
            {
                model.PaymentOptions.ColumnCount = 4;
                model.PaymentOptions.CollectionTitle = "Payment Options";
                model.PaymentOptions.SelectListItems = _repository.GetPaymentOptions().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.PaymentOptionName,
                    Value = x.PaymentOptionID.ToString(),
                }).ToList();
                model.PaymentOptions.MultiSelect = true;
            }
            #endregion

            #region LicenceTypeMinimum
            if (model.LicenceTypeMinimum.SelectListItems == null)
            {
                //model.LicenceTypeMinimum.ColumnCount = 1;
                //model.LicenceTypeMinimum.CollectionTitle = "Minimum Users";
                model.LicenceTypeMinimum.SelectListItems = _repository.GetNumberOfUsers(false).Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
                {
                    Selected = (x.UserValue.ToString() == model.LicenceTypeMinimum.ChosenValue),
                    Text = x.UserValue.ToString(),
                    Value = x.UserValue.ToString(),
                }).ToList();
                //model.LicenceTypeMinimum.MultiSelect = false;
            }
            #endregion

            #region LicenceTypeMaximum
            if (model.LicenceTypeMaximum.SelectListItems == null)
            {
                //model.LicenceTypeMaximum.ColumnCount = 1;
                //model.LicenceTypeMaximum.CollectionTitle = "Maximum Users";
                model.LicenceTypeMaximum.SelectListItems = _repository.GetNumberOfUsers(false).Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
                {
                    Selected = (x.UserValue.ToString() == model.LicenceTypeMaximum.ChosenValue),
                    Text = x.UserValue.ToString(),
                    Value = x.UserValue.ToString(),
                }).ToList();
                //model.LicenceTypeMaximum.MultiSelect = false;
            }
            #endregion

            #region FreeTrialPeriods
            if (model.FreeTrialPeriods.SelectListItems == null)
            {
                //model.FreeTrialPeriods.ColumnCount = 1;
                //model.FreeTrialPeriods.CollectionTitle = "Free Trial";
                model.FreeTrialPeriods.SelectListItems = _repository.GetFreeTrialPeriods().Select(x => new SelectListItem()
                {
                    Selected = (x.FreeTrialPeriodID.ToString() == model.FreeTrialPeriods.ChosenValue),
                    Text = x.FreeTrialPeriodName,
                    Value = x.FreeTrialPeriodID.ToString(),
                }).ToList();
                //model.FreeTrialPeriods.MultiSelect = false;
            }
            #endregion

            #region MinimumContracts
            if (model.MinimumContracts.SelectListItems == null)
            {
                //model.MinimumContracts.ColumnCount = 1;
                //model.MinimumContracts.CollectionTitle = "Minimum Contract";
                model.MinimumContracts.SelectListItems = _repository.GetMinimumContracts().Select(x => new SelectListItem()
                {
                    Selected = (x.MinimumContractID.ToString() == model.MinimumContracts.ChosenValue),
                    Text = x.MinimumContractName,
                    Value = x.MinimumContractID.ToString(),
                }).ToList();
                //model.MinimumContracts.MultiSelect = false;
            }
            #endregion

            #region PaymentFrequencies
            if (model.PaymentFrequencies.SelectListItems == null)
            {
                //model.PaymentFrequencies.ColumnCount = 1;
                //model.PaymentFrequencies.CollectionTitle = "Payment Frequency";
                model.PaymentFrequencies.SelectListItems = _repository.GetPaymentFrequencies().Select(x => new SelectListItem()
                {
                    Selected = (x.PaymentFrequencyID.ToString() == model.PaymentFrequencies.ChosenValue),
                    Text = x.PaymentFrequencyName,
                    Value = x.PaymentFrequencyID.ToString(),
                }).ToList();
                //model.PaymentFrequencies.MultiSelect = false;
            }
            #endregion

            #region Product Reviews
            model.CloudApplicationProductReviewsContainerModel = GetInputModelFromViewData(true).CloudApplicationProductReviewsContainerModel;
            #endregion

            #region User Reviews
            model.CloudApplicationUserReviewsContainerModel = GetInputModelFromViewData(true).CloudApplicationUserReviewsContainerModel;
            #endregion

            #region Documents
            model.CloudApplicationDocumentsContainerModel = GetInputModelFromViewData(true).CloudApplicationDocumentsContainerModel;
            #endregion

            #region Video File Extensions
            if (HasVideo())
            {

                if (model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0] != null)
                {
                    //model.VideoExtensions.ColumnCount = 1;
                    //model.VideoExtensions.CollectionTitle = "Video Extensions";
                    model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoExtensions.SelectListItems = ModelHelpers.GetVideoExtensions(Logger).SelectListItems;
                    //model.VideoExtensions.MultiSelect = false;
                }
            }
            #endregion

            #region Video Domains
            if (HasVideo())
            {
                if (model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoDomains != null)
                {
                    //model.VideoDomains.ColumnCount = 1;
                    //model.VideoDomains.CollectionTitle = "Video Domains";
                    model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoDomains.SelectListItems = ModelHelpers.GetVideoDomains(Logger).SelectListItems;
                    model.CustomSession = CustomSession;
                    //model.VideoExtensions.MultiSelect = false;
                }
            }
            #endregion

            #region  Document Types
            if (model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[0] != null)
            {
                //model.VideoExtensions.ColumnCount = 1;
                //model.VideoExtensions.CollectionTitle = "Video Extensions";
                model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[0].CloudApplicationDocumentFileFormats.SelectListItems = ModelHelpers.ConstructDocumentFileFormats().SelectListItems;
                model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[0].CloudApplicationDocumentTypes.SelectListItems = ModelHelpers.ConstructDocumentTypes().SelectListItems;
                //model.VideoExtensions.MultiSelect = false;
            }
            #endregion

            return model;
        }
        #endregion

        #region ConstructEmptyCloudApplicationInputModel - DEPRECATED
        //private CloudApplicationInputModel ConstructEmptyCloudApplicationInputModel()
        //{
        //    var model = new CloudApplicationInputModel(CustomSession);

        //    #region Categories
        //    model.Categories.ColumnCount = 2;
        //    model.Categories.CollectionTitle = "Category";
        //    model.Categories.SelectListItems = this.GetCategories().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.CategoryName,
        //        Value = x.CategoryID.ToString(),
        //    }).ToList();
        //    model.Categories.MultiSelect = false;
        //    #endregion

        //    //model.Features.ColumnCount = 2;
        //    //model.Features.CollectionTitle = "Features";
        //    //model.Features.SelectListItems = _repository.GetFeatures(1).Select(x => new SelectListItem()
        //    //{
        //    //    Selected = false,
        //    //    Text = x.FeatureName,
        //    //    Value = x.FeatureID.ToString(),
        //    //}).ToList();
        //    //model.Features.MultiSelect = true;

        //    #region Devices
        //    model.Devices.ColumnCount = 2;
        //    model.Devices.CollectionTitle = "Devices";
        //    model.Devices.SelectListItems = _repository.GetDevices().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.DeviceName,
        //        Value = x.DeviceID.ToString(),
        //    }).ToList();
        //    model.Devices.MultiSelect = true;
        //    #endregion

        //    #region MobilePlatforms
        //    model.MobilePlatforms.ColumnCount = 2;
        //    model.MobilePlatforms.CollectionTitle = "Mobile Platforms";
        //    model.MobilePlatforms.SelectListItems = _repository.GetMobilePlatforms().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.MobilePlatformName,
        //        Value = x.MobilePlatformID.ToString(),
        //    }).ToList();
        //    model.MobilePlatforms.MultiSelect = true;
        //    #endregion

        //    #region OperatingSystems
        //    model.OperatingSystems.ColumnCount = 2;
        //    model.OperatingSystems.CollectionTitle = "Mobile Platforms";
        //    model.OperatingSystems.SelectListItems = _repository.GetOperatingSystems().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.OperatingSystemName,
        //        Value = x.OperatingSystemID.ToString(),
        //    }).ToList();
        //    model.OperatingSystems.MultiSelect = true;
        //    #endregion

        //    #region Browsers
        //    model.Browsers.ColumnCount = 2;
        //    model.Browsers.CollectionTitle = "Browsers supported";
        //    model.Browsers.SelectListItems = _repository.GetBrowsers().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.BrowserName,
        //        Value = x.BrowserID.ToString(),
        //    }).ToList();
        //    model.Browsers.MultiSelect = true;
        //    #endregion

        //    #region Languages
        //    model.Languages.ColumnCount = 3;
        //    model.Languages.CollectionTitle = "Languages";
        //    model.Languages.SelectListItems = _repository.GetLanguages().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.LanguageName,
        //        Value = x.LanguageID.ToString(),
        //    }).ToList();
        //    model.Languages.MultiSelect = true;
        //    #endregion

        //    #region SupportTypes
        //    model.SupportTypes.ColumnCount = 4;
        //    model.SupportTypes.CollectionTitle = "Support Types";
        //    model.SupportTypes.SelectListItems = _repository.GetSupportTypes().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.SupportTypeName,
        //        Value = x.SupportTypeID.ToString(),
        //    }).ToList();
        //    model.SupportTypes.MultiSelect = true;
        //    #endregion

        //    #region SupportHours
        //    model.SupportHours.ColumnCount = 2;
        //    model.SupportHours.CollectionTitle = "Support Hours";
        //    model.SupportHours.SelectListItems = _repository.GetSupportHours().Where(x => x.SupportHoursName != "ALL").Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.SupportHoursName,
        //        Value = x.SupportHoursID.ToString(),
        //    }).ToList();
        //    model.SupportHours.MultiSelect = false;
        //    #endregion

        //    #region SupportDays
        //    model.SupportDays.ColumnCount = 3;
        //    model.SupportDays.CollectionTitle = "Support Days";
        //    model.SupportDays.SelectListItems = _repository.GetSupportDays().Where(x => x.SupportDaysName != "ALL").Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.SupportDaysName,
        //        Value = x.SupportDaysID.ToString(),
        //    }).ToList();
        //    model.SupportDays.MultiSelect = false;
        //    #endregion

        //    #region SupportTerritories
        //    model.SupportTerritories.ColumnCount = 3;
        //    model.SupportTerritories.CollectionTitle = "Customer service location";
        //    model.SupportTerritories.SelectListItems = _repository.GetSupportTerritories().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.SupportTerritoryName,
        //        Value = x.SupportTerritoryID.ToString(),
        //    }).ToList();
        //    model.SupportTerritories.MultiSelect = false;
        //    #endregion

        //    #region PaymentOptions
        //    model.PaymentOptions.ColumnCount = 4;
        //    model.PaymentOptions.CollectionTitle = "Payment Options";
        //    model.PaymentOptions.SelectListItems = _repository.GetPaymentOptions().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.PaymentOptionName,
        //        Value = x.PaymentOptionID.ToString(),
        //    }).ToList();
        //    model.PaymentOptions.MultiSelect = true;
        //    #endregion

        //    #region LicenceTypeMinimum
        //    model.LicenceTypeMinimum.ColumnCount = 1;
        //    model.LicenceTypeMinimum.CollectionTitle = "Minimum Users";
        //    model.LicenceTypeMinimum.SelectListItems = _repository.GetNumberOfUsers().Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.UserValue.ToString(),
        //        Value = x.UserValue.ToString(),
        //    }).ToList();
        //    model.LicenceTypeMinimum.MultiSelect = false;
        //    #endregion

        //    #region LicenceTypeMaximum
        //    model.LicenceTypeMaximum.ColumnCount = 1;
        //    model.LicenceTypeMaximum.CollectionTitle = "Maximum Users";
        //    model.LicenceTypeMaximum.SelectListItems = _repository.GetNumberOfUsers().Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.UserValue.ToString(),
        //        Value = x.UserValue.ToString(),
        //    }).ToList();
        //    model.LicenceTypeMaximum.MultiSelect = false;
        //    #endregion

        //    #region FreeTrialPeriods
        //    model.FreeTrialPeriods.ColumnCount = 1;
        //    model.FreeTrialPeriods.CollectionTitle = "Free Trial";
        //    model.FreeTrialPeriods.SelectListItems = _repository.GetFreeTrialPeriods().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.FreeTrialPeriodName,
        //        Value = x.FreeTrialPeriodID.ToString(),
        //    }).ToList();
        //    model.FreeTrialPeriods.MultiSelect = false;
        //    #endregion

        //    #region MinimumContracts
        //    model.MinimumContracts.ColumnCount = 1;
        //    model.MinimumContracts.CollectionTitle = "Minimum Contract";
        //    model.MinimumContracts.SelectListItems = _repository.GetMinimumContracts().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.MinimumContractName,
        //        Value = x.MinimumContractID.ToString(),
        //    }).ToList();
        //    model.MinimumContracts.MultiSelect = false;
        //    #endregion

        //    #region PaymentFrequencies
        //    model.PaymentFrequencies.ColumnCount = 1;
        //    model.PaymentFrequencies.CollectionTitle = "Payment Frequency";
        //    model.PaymentFrequencies.SelectListItems = _repository.GetPaymentFrequencies().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x.PaymentFrequencyName,
        //        Value = x.PaymentFrequencyID.ToString(),
        //    }).ToList();
        //    model.PaymentFrequencies.MultiSelect = false;
        //    #endregion

        //    #region Video File Format Extensions
        //    //model.VideoExtensions.ColumnCount = 1;
        //    //model.VideoExtensions.CollectionTitle = "Video Extensions";
        //    //model.VideoExtensions.SelectListItems = _repository.GetVideoExtensions().Select(x => new SelectListItem()
        //    //{
        //    //    Selected = false,
        //    //    Text = x,
        //    //    Value = x,
        //    //}).ToList();
        //    //model.VideoExtensions.MultiSelect = false;
        //    #endregion

        //    #region Video File Domains
        //    //model.VideoDomains.ColumnCount = 1;
        //    //model.VideoDomains.CollectionTitle = "Video Domains";
        //    //model.VideoDomains.SelectListItems = _repository.GetVideoDomains().Select(x => new SelectListItem()
        //    //{
        //    //    Selected = false,
        //    //    Text = x,
        //    //    Value = x,
        //    //}).ToList();
        //    //model.VideoDomains.MultiSelect = false;
        //    #endregion

        //    #region Videos
        //    model.Videos = new List<CloudApplicationVideoModel>();
        //    model.Videos.Add(new CloudApplicationVideoModel());

        //    model.Videos[0].CloudApplicationVideoExtensions.ColumnCount = 1;
        //    model.Videos[0].CloudApplicationVideoExtensions.CollectionTitle = "Video Extensions";
        //    model.Videos[0].CloudApplicationVideoExtensions.SelectListItems = _repository.GetVideoExtensions().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x,
        //        Value = x,
        //    }).ToList();
        //    model.Videos[0].CloudApplicationVideoExtensions.MultiSelect = false;

                    
        //    model.Videos[0].CloudApplicationVideoDomains.ColumnCount = 1;
        //    model.Videos[0].CloudApplicationVideoDomains.CollectionTitle = "Video Domains";
        //    model.Videos[0].CloudApplicationVideoDomains.SelectListItems = _repository.GetVideoDomains().Select(x => new SelectListItem()
        //    {
        //        Selected = false,
        //        Text = x,
        //        Value = x,
        //    }).ToList();
        //    model.Videos[0].CloudApplicationVideoDomains.MultiSelect = false;
                    
        //    #endregion

        //    return model;
        //}
        #endregion

        #region ConstructCloudApplicationInputModel
        private CloudApplicationInputModel ConstructCloudApplicationInputModel(CloudApplication model)
        {
            try
            {
                var inputModel = GetInputModelFromViewData(false);

                //inputModel.ApplicationCostOneOff = model.ApplicationCostOneOff;

                inputModel.CloudApplicationID = model.CloudApplicationID;

                ReconstructSelectLists(inputModel, model);

                #region MISCELLANEOUS COSTS
                //MISC COSTS
                inputModel.PayAsYouGo = model.PayAsYouGo;
                inputModel.OneOffCostWhole = (int)model.ApplicationCostOneOff;
                inputModel.OneOffCostFraction = (int)((model.ApplicationCostOneOff - (int)model.ApplicationCostOneOff) * 100);
                #endregion

                #region ANNUAL COSTS
                //ANNUAL COSTS
                inputModel.ApplicationCostPerAnnumWhole = (int)model.ApplicationCostPerAnnum;
                inputModel.ApplicationCostPerAnnumFraction = (int)((model.ApplicationCostPerAnnum - (int)model.ApplicationCostPerAnnum) * 100);

                inputModel.ApplicationCostPerAnnumFromWhole = (int)model.ApplicationCostPerAnnumFrom;
                inputModel.ApplicationCostPerAnnumFromFraction = (int)((model.ApplicationCostPerAnnumFrom - (int)model.ApplicationCostPerAnnumFrom) * 100);

                inputModel.ApplicationCostPerAnnumToWhole = (int)model.ApplicationCostPerAnnumTo;
                inputModel.ApplicationCostPerAnnumToFraction = (int)((model.ApplicationCostPerAnnumTo - (int)model.ApplicationCostPerAnnumTo) * 100);

                inputModel.ApplicationCostPerAnnumPOA = model.ApplicationCostPerAnnumPOA;
                inputModel.ApplicationCostPerAnnumSuffix = "";

                inputModel.ApplicationCostPerAnnumOffered = model.ApplicationCostPerAnnumOffered;
                inputModel.ApplicationCostPerAnnumFree = model.ApplicationCostPerAnnumFree;
                inputModel.ApplicationCostPerAnnumAvailable = model.ApplicationCostPerAnnumAvailable;

                inputModel.ApplicationCostPerAnnumIsForUnlimitedUsers = model.ApplicationCostPerAnnumIsForUnlimitedUsers ?? false;
                #endregion

                #region MONTHLY COSTS
                //MONTHLY COSTS
                inputModel.ApplicationCostPerMonthWhole = (int)model.ApplicationCostPerMonth;
                inputModel.ApplicationCostPerMonthFraction = (int)((model.ApplicationCostPerMonth - (int)model.ApplicationCostPerMonth) * 100);

                inputModel.ApplicationCostPerMonthFromWhole = (int)model.ApplicationCostPerMonthFrom;
                inputModel.ApplicationCostPerMonthFromFraction = (int)((model.ApplicationCostPerMonthFrom - (int)model.ApplicationCostPerMonthFrom) * 100);

                inputModel.ApplicationCostPerMonthToWhole = (int)model.ApplicationCostPerMonthTo;
                inputModel.ApplicationCostPerMonthToFraction = (int)((model.ApplicationCostPerMonthTo - (int)model.ApplicationCostPerMonthTo) * 100);

                inputModel.ApplicationCostPerMonthPOA = model.ApplicationCostPerMonthPOA;
                inputModel.ApplicationCostPerMonthSuffix = model.ApplicationCostPerMonthSuffix;

                inputModel.ApplicationCostPerMonthOffered = model.ApplicationCostPerMonthOffered;
                inputModel.ApplicationCostPerMonthFree = model.ApplicationCostPerMonthFree;
                inputModel.ApplicationCostPerMonthAvailable = model.ApplicationCostPerMonthAvailable;

                inputModel.ApplicationCostPerMonthIsForUnlimitedUsers = model.ApplicationCostPerMonthIsForUnlimitedUsers ?? false;
                #endregion

                //MISCELLANEOUS
                inputModel.Brand = model.Brand;
                inputModel.CallsPackageCostPerMonth = model.CallsPackageCostPerMonth;
                inputModel.CloudApplicationLogo = model.CloudApplicationLogo;
                inputModel.CompanyURL = model.CompanyURL;
                inputModel.DemoOffered = model.DemoOffered;
                inputModel.Description = model.Description;
                inputModel.FacebookFollowers = model.FacebookFollowers;
                inputModel.FacebookName = model.FacebookName;
                inputModel.FacebookURL = model.FacebookURL;
                inputModel.LinkedInCompanyID = model.LinkedInCompanyID;
                inputModel.LinkedInFollowers = model.LinkedInFollowers;
                inputModel.LinkedInURL = model.LinkedInURL;
                inputModel.MaximumMeetingAttendees = model.MaximumMeetingAttendees;
                inputModel.MaximumWebinarAttendees = model.MaximumWebinarAttendees;
                inputModel.Options = model.Options;
                inputModel.ServiceName = model.ServiceName;
                inputModel.BuyURL = model.BuyURL;
                inputModel.TryURL = model.TryURL;

                #region SETUP FEE
                if (model.SetupFee != null)
                {

                    decimal result = 0;
                    if (model.SetupFee.SetupFeeName.ToUpperInvariant() == "POA")
                    {
                        inputModel.SetupFeeIsPOA = true;
                    }
                    else
                    {
                        inputModel.SetupFeeIsPOA = false;
                    }
                    if (model.SetupFee.SetupFeeName.ToUpperInvariant() == "NO")
                    {
                        inputModel.NoSetupFee = true;
                    }
                    else
                    {
                        inputModel.NoSetupFee = false;
                    }

                    try
                    {
                        result = Convert.ToDecimal(model.SetupFee.SetupFeeName);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        inputModel.SetupFeeWhole = (int)(Convert.ToDecimal(result));
                        inputModel.SetupFeeFraction = (int)((Convert.ToDecimal(result) - (int)Convert.ToDecimal(result)) * 100);
                    }
                    //if (int.TryParse(model.SetupFee.SetupFeeName,out result))
                    //{
                    //inputModel.SetupFeeWhole = (int)(Convert.ToDecimal(model.SetupFee.SetupFeeName));
                    //inputModel.SetupFeeFraction = (int)((Convert.ToDecimal(model.SetupFee.SetupFeeName) - (int)Convert.ToDecimal(model.SetupFee.SetupFeeName))*100);
                    //}
                }
                #endregion

                inputModel.Title = model.Title;
                inputModel.TwitterFollowers = model.TwitterFollowers;
                inputModel.TwitterName = model.TwitterName;
                inputModel.TwitterURL = model.TwitterURL;
                inputModel.VideoTrainingSupport = model.VideoTrainingSupport;

                #region Vendor
                inputModel.Vendor = new VendorModel()
                {
                    VendorLogo = model.Vendor != null ? model.Vendor.VendorLogo.Logo : null,
                    VendorName = model.Vendor != null ? model.Vendor.VendorName : null,
                    VendorLogoFileName = model.Vendor != null ? model.Vendor.VendorLogoFileName : null,
                    VendorLogoFullURL = model.Vendor != null ? model.Vendor.VendorLogoFullURL : null,
                };
                #endregion

                #region Categories
                inputModel.Categories.ColumnCount = 2;
                inputModel.Categories.CollectionTitle = "Category";
                inputModel.Categories.MultiSelect = false;
                #endregion

                if (CustomSession.AddMode)
                {
                    inputModel.Categories.ChosenValue = inputModel.Categories.ChosenValue == null ? testCategoryID.ToString() : inputModel.Categories.ChosenValue;
                }
                if (CustomSession.EditMode)
                {
                    //inputModel.Categories.ChosenValue = testCategoryID.ToString();
                    inputModel.Categories.ChosenValue = model.Category.CategoryID.ToString();
                    testCategoryID = model.Category.CategoryID;
                }

                inputModel.Categories.SelectListItems.Find(x => x.Value == inputModel.Categories.ChosenValue).Selected = true;
                int chosenCategory = int.Parse(inputModel.Categories.ChosenValue);

                #region STATUSES
                inputModel.Statuses.ColumnCount = 1;
                inputModel.Statuses.CollectionTitle = "Status";
                inputModel.Statuses.MultiSelect = false;
                inputModel.Statuses.ChosenValue = model.CloudApplicationStatus.StatusID.ToString();

                inputModel.AddDate = model.AddDate;
                inputModel.LastUpdateDate = model.LastUpdateDate;
                #endregion

                #region Features
                inputModel.Features.ColumnCount = 1;
                inputModel.Features.CollectionTitle = "Features";
                inputModel.Features.SelectListItems = this.GetFeaturesForChosenCategory(chosenCategory).Select(x => new SelectListItemFeature()
                {
                    Selected = false,
                    Text = x.Feature.FeatureName,
                    Value = x.Feature.FeatureID.ToString(),

                    CostWhole = (int)System.Math.Truncate(x.Cost),
                    CostFraction = (int)(x.Cost - System.Math.Truncate(x.Cost)),
                    Count = (int)x.Count,
                    CountSuffix = x.CountSuffix,
                    //Include = x.Include,
                    IncludeExtraCost = false,
                    HasCount = x.HasCount,
                    OutputDisplayDescriptor = x.OutputDisplayDescriptor,
                    HasBooleanAndCount = x.CanBeBooleanAndDataDriven,
                    IsUnlimited = x.Count == 16384,

                }).ToList();
                inputModel.Features.MultiSelect = true;

                RefreshCloudApplicationFeatures(inputModel.CloudApplicationID, inputModel.Features);

                #endregion

                #region Applications
                inputModel.Applications.ColumnCount = 1;
                inputModel.Applications.CollectionTitle = "Applications";
                inputModel.Applications.SelectListItems = this.GetApplicationsForChosenCategory(chosenCategory).Select(x => new SelectListItemFeature()
                {
                    Selected = false,
                    Text = x.Feature.FeatureName,
                    Value = x.Feature.FeatureID.ToString(),

                    CostWhole = (int)System.Math.Truncate(x.Cost),
                    CostFraction = (int)(x.Cost - System.Math.Truncate(x.Cost)),
                    Count = (int)x.Count,
                    CountSuffix = x.CountSuffix,
                    //Include = x.Include,
                    IncludeExtraCost = false,
                    HasCount = x.HasCount,
                    OutputDisplayDescriptor = x.OutputDisplayDescriptor,
                    HasBooleanAndCount = x.CanBeBooleanAndDataDriven,

                }).ToList();
                inputModel.Applications.MultiSelect = true;

                RefreshCloudApplicationApplications(inputModel.CloudApplicationID, inputModel.Applications);
                #endregion

                #region Devices
                if (inputModel.Devices != null)
                {
                    inputModel.Devices.ColumnCount = 2;
                    inputModel.Devices.CollectionTitle = "Devices";
                    inputModel.Devices.SelectListItems = _repository.GetDevices().Select(x => new SelectListItem()
                    {
                        Selected = false,
                        Text = x.DeviceName,
                        Value = x.DeviceID.ToString(),
                    }).ToList();
                    inputModel.Devices.MultiSelect = true;
                }
                #endregion

                #region MobilePlatforms
                inputModel.MobilePlatforms.ColumnCount = 2;
                inputModel.MobilePlatforms.CollectionTitle = "Mobile Platforms";
                inputModel.MobilePlatforms.SelectListItems = _repository.GetMobilePlatforms().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.MobilePlatformName,
                    Value = x.MobilePlatformID.ToString(),
                }).ToList();
                inputModel.MobilePlatforms.MultiSelect = true;
                HydrateCloudApplicationMobilePlatforms(testCategoryID, inputModel.MobilePlatforms.SelectListItems, model.MobilePlatforms);
                #endregion

                #region OperatingSystems
                inputModel.OperatingSystems.ColumnCount = 2;
                inputModel.OperatingSystems.CollectionTitle = "Mobile Platforms";
                inputModel.OperatingSystems.SelectListItems = _repository.GetOperatingSystems().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.OperatingSystemName,
                    Value = x.OperatingSystemID.ToString(),
                }).ToList();
                inputModel.OperatingSystems.MultiSelect = true;

                HydrateCloudApplicationOperatingSystems(testCategoryID, inputModel.OperatingSystems.SelectListItems, model.OperatingSystems);
                #endregion

                #region Browsers
                inputModel.Browsers.ColumnCount = 2;
                inputModel.Browsers.CollectionTitle = "Browsers supported";
                inputModel.Browsers.SelectListItems = _repository.GetBrowsers().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.BrowserName,
                    Value = x.BrowserID.ToString(),
                }).ToList();
                inputModel.Browsers.MultiSelect = true;
                HydrateCloudApplicationBrowsers(testCategoryID, inputModel.Browsers.SelectListItems, model.Browsers);
                #endregion

                #region Languages
                inputModel.Languages.ColumnCount = 3;
                inputModel.Languages.CollectionTitle = "Languages";
                inputModel.Languages.SelectListItems = _repository.GetLanguages().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.LanguageName,
                    Value = x.LanguageID.ToString(),
                }).ToList();
                inputModel.Languages.MultiSelect = true;
                HydrateCloudApplicationLanguages(testCategoryID, inputModel.Languages.SelectListItems, model.Languages);
                #endregion

                #region SupportTypes
                inputModel.SupportTypes.ColumnCount = 4;
                inputModel.SupportTypes.CollectionTitle = "Support Types";
                inputModel.SupportTypes.SelectListItems = _repository.GetSupportTypes().Select(x => new SelectListItemSupportType()
                {
                    Selected = false,
                    Text = x.SupportTypeName,
                    Value = x.SupportTypeID.ToString(),
                    IsPassive = x.IsPassive,

                }).ToList();
                inputModel.SupportTypes.MultiSelect = true;

                HydrateCloudApplicationSupportTypes(testCategoryID, inputModel.SupportTypes.SelectListItems, model.SupportTypes);
                #endregion

                #region ApplicationHasActiveSupport

                inputModel.ApplicationHasActiveSupport = ModelHelpers.ApplicationHasActiveSupport(inputModel.SupportTypes.SelectListItems);
                #endregion

                #region SupportHours
                //inputModel.SupportHours.ColumnCount = 2;
                //inputModel.SupportHours.CollectionTitle = "Support Hours";
                //inputModel.SupportHours.SelectListItems = _repository.GetSupportHoursAll().Where(x => x.SupportHoursName != "ALL").Select(x => new SelectListItem()
                //{
                //    Selected = false,
                //    Text = x.SupportHoursName,
                //    Value = x.SupportHoursID.ToString(),
                //}).ToList();
                //inputModel.SupportHours.MultiSelect = false;
                //HydrateCloudApplicationSupportHours(testCategoryID, inputModel.SupportHours.SelectListItems, model.SupportHours);
                //inputModel.SupportHours.ChosenValue = model.SupportHours.SupportHoursID.ToString();

                inputModel.SupportHoursFrom.ColumnCount = 3;
                inputModel.SupportHoursFrom.CollectionTitle = "Support Hours From";
                //inputModel.SupportHoursFrom.SelectListItems = _repository.GetSupportHoursAll().Select(x => new SelectListItem()
                //{
                //    Selected = false,
                //    Text = x.SupportHoursName,
                //    Value = x.SupportHoursID.ToString(),
                //}).ToList();

                inputModel.SupportHoursFrom.MultiSelect = false;
                HydrateCloudApplicationSupportHoursFrom(testCategoryID, inputModel.SupportHoursFrom, model.SupportHours);
                //inputModel.SupportHoursFrom.ChosenValue = model.SupportHours.SupportHoursID.ToString();


                inputModel.SupportHoursTo.ColumnCount = 3;
                inputModel.SupportHoursTo.CollectionTitle = "Support Hours To";
                //inputModel.SupportHoursTo.SelectListItems = _repository.GetSupportHoursAll().Select(x => new SelectListItem()
                //{
                //    Selected = false,
                //    Text = x.SupportHoursName,
                //    Value = x.SupportHoursID.ToString(),
                //}).ToList();
                inputModel.SupportHoursTo.MultiSelect = false;
                HydrateCloudApplicationSupportHoursTo(testCategoryID, inputModel.SupportHoursTo, model.SupportHours);
                //inputModel.SupportHoursTo.ChosenValue = model.SupportHours.SupportHoursID.ToString();

                #endregion

                #region SupportDays

                inputModel.NumberOfSupportDays.ColumnCount = 3;
                inputModel.NumberOfSupportDays.CollectionTitle = "Number Of Support Days";
                inputModel.NumberOfSupportDays.MultiSelect = false;
                inputModel.NumberOfSupportDays.ChosenValue = model.SupportDays != null ? ModelHelpers.GetNumberOfContiguousDays(model.SupportDays.SupportDaysName).ToString() : null;

                inputModel.SupportDays.ColumnCount = 3;
                inputModel.SupportDays.CollectionTitle = "Support Days";
                inputModel.SupportDays.ChosenValue = model.SupportDays != null ? model.SupportDays.SupportDaysName : null;
                //inputModel.SupportDays.SelectListItems = _repository.GetSupportDays().Where(x => x.SupportDaysName != "ALL").Select(x => new SelectListItem()
                //{
                //    Selected = false,
                //    Text = x.SupportDaysName,
                //    Value = x.SupportDaysID.ToString(),
                //}).ToList();
                inputModel.SupportDays.MultiSelect = false;

                HydrateCloudApplicationSupportDays(testCategoryID, inputModel.SupportDays.SelectListItems, model.SupportDays);

                #endregion

                #region SupportTerritories
                inputModel.SupportTerritories.ColumnCount = 3;
                inputModel.SupportTerritories.CollectionTitle = "Customer service location";
                inputModel.SupportTerritories.MultiSelect = false;
                HydrateCloudApplicationSupportTerritories(testCategoryID, inputModel.SupportTerritories, model.SupportTerritories);
                #endregion

                #region PaymentOptions
                inputModel.PaymentOptions.ColumnCount = 2;
                inputModel.PaymentOptions.CollectionTitle = "Payment Options";
                inputModel.PaymentOptions.SelectListItems = _repository.GetPaymentOptions().Select(x => new SelectListItem()
                {
                    Selected = false,
                    Text = x.PaymentOptionName,
                    Value = x.PaymentOptionID.ToString(),
                }).ToList();
                inputModel.PaymentOptions.MultiSelect = true;
                HydrateCloudApplicationPaymentOptions(testCategoryID, inputModel.PaymentOptions.SelectListItems, model.PaymentOptions);
                #endregion

                #region LicenceTypeMinimum
                inputModel.LicenceTypeMinimum.ColumnCount = 1;
                inputModel.LicenceTypeMinimum.CollectionTitle = "Minimum Users";
                inputModel.LicenceTypeMinimum.MultiSelect = false;
                inputModel.LicenceTypeMinimum.CanInputOther = true;
                inputModel.LicenceTypeMinimum.OtherIsNumeric = true;
                inputModel.LicenceTypeMinimum.HasNoOption = false;
                inputModel.LicenceTypeMinimum.HasUnlimitedOption = false;
                HydrateCloudApplicationLicenceTypeMinimum(testCategoryID, inputModel.LicenceTypeMinimum.SelectListItems, model.LicenceTypeMinimum);
                inputModel.LicenceTypeMinimum.ChosenValue = model.LicenceTypeMinimum != null ? model.LicenceTypeMinimum.LicenceTypeMinimumName.ToString() : null;
                #endregion

                #region LicenceTypeMaximum
                inputModel.LicenceTypeMaximum.ColumnCount = 1;
                inputModel.LicenceTypeMaximum.CollectionTitle = "Maximum Users";
                inputModel.LicenceTypeMaximum.MultiSelect = false;
                inputModel.LicenceTypeMaximum.CanInputOther = true;
                inputModel.LicenceTypeMaximum.OtherIsNumeric = true;
                inputModel.LicenceTypeMaximum.HasNoOption = false;
                inputModel.LicenceTypeMaximum.HasUnlimitedOption = true;
                inputModel.LicenceTypeMaximum.IsUnlimited = (model.LicenceTypeMaximum != null ? model.LicenceTypeMaximum.LicenceTypeMaximumName == 16384 : false);
                HydrateCloudApplicationLicenceTypeMaximum(testCategoryID, inputModel.LicenceTypeMaximum.SelectListItems, model.LicenceTypeMaximum);
                inputModel.LicenceTypeMaximum.ChosenValue = model.LicenceTypeMaximum != null ? model.LicenceTypeMaximum.LicenceTypeMaximumName.ToString() : null;
                #endregion

                #region FreeTrialPeriods
                inputModel.FreeTrialPeriods.ColumnCount = 1;
                inputModel.FreeTrialPeriods.CollectionTitle = "Free Trial";
                inputModel.FreeTrialPeriods.MultiSelect = false;
                inputModel.FreeTrialPeriods.CanInputOther = true;
                inputModel.FreeTrialPeriods.OtherIsNumeric = true;
                inputModel.FreeTrialPeriods.HasNoOption = true;
                inputModel.FreeTrialPeriods.IsNo = false;
                inputModel.FreeTrialPeriods.ChosenValue = model.FreeTrialPeriod != null ? model.FreeTrialPeriod.FreeTrialPeriodID.ToString() : null;
                #endregion

                #region MinimumContracts
                inputModel.MinimumContracts.ColumnCount = 1;
                inputModel.MinimumContracts.CollectionTitle = "Minimum Contract";
                inputModel.MinimumContracts.MultiSelect = false;
                inputModel.MinimumContracts.CanInputOther = true;
                inputModel.MinimumContracts.OtherIsNumeric = true;
                inputModel.MinimumContracts.HasNoOption = true;
                HydrateCloudApplicationMinimumContract(testCategoryID, inputModel.MinimumContracts.SelectListItems, model.MinimumContract);
                inputModel.MinimumContracts.ChosenValue = model.MinimumContract != null ? model.MinimumContract.MinimumContractID.ToString() : null;

                if (model.MinimumContract != null)
                {
                    if (model.MinimumContract.MinimumContractName.ToUpperInvariant() == "NO")
                    {
                        inputModel.MinimumContracts.IsNo = true;
                    }
                    else
                    {
                        inputModel.MinimumContracts.IsNo = false;
                    }
                }
                else
                {
                    inputModel.MinimumContracts.IsNo = true;
                }
                #endregion

                #region PaymentFrequencies
                inputModel.PaymentFrequencies.ColumnCount = 1;
                inputModel.PaymentFrequencies.CollectionTitle = "Payment Frequency";
                inputModel.PaymentFrequencies.MultiSelect = false;

                HydrateCloudApplicationPaymentFrequency(testCategoryID, inputModel.PaymentFrequencies.SelectListItems, model.PaymentFrequency);
                if (model.ApplicationCostOneOff == 0)
                {
                    if (model.PaymentFrequency != null)
                    {
                        inputModel.PaymentFrequencies.ChosenValue = model.PaymentFrequency.PaymentFrequencyID.ToString();
                    }
                    else
                    {
                        inputModel.PaymentFrequencies.ChosenValue = _repository.FindPaymentFrequencyByName("One-Off").PaymentFrequencyID.ToString();
                    }
                }
                else
                {
                    inputModel.PaymentFrequencies.ChosenValue = _repository.FindPaymentFrequencyByName("One-Off").PaymentFrequencyID.ToString();
                }

                #endregion

                #region Product Reviews
                if (model.CloudApplicationProductReviews != null)
                {
                    inputModel.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews = model.CloudApplicationProductReviews
                        //.Where(x => x.CloudApplicationProductReviewStatus.StatusName.ToUpper() == "LIVE")
                        .Select(x => new CloudApplicationProductReviewModel()
                        {
                            Persisted = true,
                            CloudApplicationProductReviewDate = x.CloudApplicationProductReviewDate,
                            CloudApplicationProductReviewHeadline = x.CloudApplicationProductReviewHeadline,
                            CloudApplicationProductReviewPublisherName = x.CloudApplicationProductReviewPublisherName,
                            CloudApplicationProductReviewText = x.CloudApplicationProductReviewText,
                            CloudApplicationProductReviewURL = x.CloudApplicationProductReviewURL,
                            CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(x.CloudApplicationProductReviewURLDocumentFormat.CloudApplicationDocumentFormatShortName).CloudApplicationDocumentFormatShortName,
                            IsBrokenLink = false,
                            RowID = x.UniqueRowID,
                            CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats(),
                            IsLive = x.CloudApplicationProductReviewStatus.StatusName.ToUpper() == "LIVE",
                            CloudApplicationProductReviewID = x.CloudApplicationProductReviewID,
                            CloudApplicationID = inputModel.CloudApplicationID,

                        }).ToList();
                }

                AddNewCloudApplicationProductReview(inputModel);
                #endregion

                #region User Reviews
                if (model.CloudApplicationUserReviews != null)
                {
                    //inputModel.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(inputModel, model);
                    inputModel.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = HydrateCloudApplicationUserReviews(inputModel, model);
                }


                AddNewCloudApplicationUserReview(inputModel);
                #endregion

                #region Documents
                if (model.CloudApplicationDocuments != null)
                {
                    inputModel.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments = model.CloudApplicationDocuments
                        //.Where(x => x.CloudApplicationDocumentStatus.StatusName.ToUpper() == "LIVE")
                        .Select(x => new CloudApplicationDocumentModel()
                    {
                        Persisted = true,
                        CloudApplicationDocumentType = new CloudApplicationDocumentTypeModel()
                        {
                            CloudApplicationDocumentTypeID = x.CloudApplicationDocumentType.CloudApplicationDocumentTypeID,
                            CloudApplicationDocumentTypeName = x.CloudApplicationDocumentType.CloudApplicationDocumentTypeName,
                        },
                        CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes(),
                        CloudApplicationDocumentFileFormats = ModelHelpers.ConstructDocumentFileFormats("URL Link"),
                        CloudApplicationDocumentFileName = x.CloudApplicationDocumentFileName,
                        CloudApplicationDocumentPhysicalFilePath = x.CloudApplicationDocumentPhysicalFilePath,
                        CloudApplicationDocumentTitle = x.CloudApplicationDocumentTitle,
                        CloudApplicationDocumentURL = x.CloudApplicationDocumentURL,
                        RowID = x.UniqueRowID,
                        CloudApplicationDocument = x.CloudApplicationDocumentImage.CloudApplicationDocumentBytes,
                        IsLive = x.CloudApplicationDocumentStatus.StatusName.ToUpper() == "LIVE",
                        CloudApplicationDocumentFileFormat = x.CloudApplicationDocumentFormat.CloudApplicationDocumentFormatShortName,
                        CloudApplicationDocumentID = x.CloudApplicationDocumentID,
                        CloudApplicationDocumentReleaseDate = x.CloudApplicationDocumentReleaseDate,
                        //CloudApplicationDocumentPostedFile = GetCloudApplicationDocumentPostedFile(x),
                        CloudApplicationID = model.CloudApplicationID,
                        
                    }).ToList();
                }

                inputModel.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.ForEach(x => GetCloudApplicationDocumentPostedFile(x));
                AddNewCloudApplicationDocument(inputModel);
                #endregion


                #region Currency
                inputModel.Currency.ColumnCount = 1;
                inputModel.Currency.CollectionTitle = "Currency";
                inputModel.Currency.MultiSelect = false;
                //inputModel.Currency.CanInputOther = true;
                //inputModel.Currency.OtherIsNumeric = true;
                HydrateCloudApplicationCurrency(testCategoryID, inputModel.Currency.SelectListItems, model.CloudApplicationCurrency);
                inputModel.Currency.ChosenValue = model.CloudApplicationCurrency != null ? model.CloudApplicationCurrency.CurrencyID.ToString() : null;
                #endregion

                #region Timezone
                inputModel.Timezone.ColumnCount = 1;
                inputModel.Timezone.CollectionTitle = "Currency";
                inputModel.Timezone.MultiSelect = false;
                //inputModel.Currency.CanInputOther = true;
                //inputModel.Currency.OtherIsNumeric = true;
                HydrateCloudApplicationTimeZone(testCategoryID, inputModel.Timezone.SelectListItems, model.SupportHoursTimeZone);
                inputModel.Timezone.ChosenValue = model.SupportHoursTimeZone != null ? model.SupportHoursTimeZone.TimeZoneID.ToString() : null;
                #endregion

                if (HasVideo())
                {
                    AddVideoToInputModel(model, inputModel, "MP4");
                }


                return inputModel;
            }
            catch (Exception ex)
            {
                ClearViewData();
                throw new Exception("Error constructing cloud application input model for : " + model.Brand + "/" + model.ServiceName + " (ID=" + model.CloudApplicationID.ToString() + "). The error message was : " + ex.Message);
            }
        }
        #endregion

        #region GetCloudApplicationDocumentPostedFile
        //private System.Web.HttpPostedFile GetCloudApplicationDocumentPostedFile(CloudApplicationDocumentModel model)
        private void GetCloudApplicationDocumentPostedFile(CloudApplicationDocumentModel model)
        {
            ////byte[] postedFileBytes = new byte[model.CloudApplicationDocumentPostedFile.InputStream.Length];
            //byte[] postedFileBytes = new byte[model.CloudApplicationDocumentPostedFile.InputStream.Length];
            //model.CloudApplicationDocumentPostedFile.InputStream.Read(postedFileBytes, 0, (int)model.CloudApplicationDocumentPostedFile.InputStream.Length);
            //    model.CloudApplicationDocument = postedFileBytes;
            //System.Web.HttpPostedFile file = new System.Web.HttpPostedFile();
            //file.SaveAs("bollocks");
            //model.CloudApplicationDocumentPostedFile.SaveAs("bollocks");
            //return model.CloudApplicationDocumentPostedFile;
            //model.CloudApplicationDocumentPostedFile.SaveAs("bollocks");
            //return file;

        }
        #endregion

        #region ReconstructSelectLists
        private void ReconstructSelectLists(CloudApplicationInputModel inputModel, CloudApplication model)
        {
            inputModel.Categories.SelectListItems = ModelHelpers.GetCategories(this.CustomSession,_repository).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.CategoryName,
                Value = x.CategoryID.ToString(),
            }).ToList();

            inputModel.Currency.SelectListItems = _repository.GetCurrencies().Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.CurrencyShortName,
                Value = x.CurrencyID.ToString(),
            }).ToList();

            inputModel.FreeTrialPeriods.SelectListItems = _repository.GetFreeTrialPeriods().Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.FreeTrialPeriodName,
                Value = x.FreeTrialPeriodID.ToString(),
            }).ToList();

            inputModel.LicenceTypeMaximum.SelectListItems = _repository.GetNumberOfUsers(false).Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.UserValue.ToString(),
                Value = x.UserValue.ToString(),
            }).ToList();

            inputModel.LicenceTypeMinimum.SelectListItems = _repository.GetNumberOfUsers(false).Where(x => x.UserValue != 16384).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.UserValue.ToString(),
                Value = x.UserValue.ToString(),
            }).ToList();

            inputModel.MinimumContracts.SelectListItems = _repository.GetMinimumContracts().Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.MinimumContractName,
                Value = x.MinimumContractID.ToString(),
            }).ToList();

            inputModel.NumberOfSupportDays.SelectListItems = ModelHelpers.ConstructListOfIntegers(minimumContiguousSupportDays, maximumContiguousSupportDays).SelectListItems;

            inputModel.PaymentFrequencies.SelectListItems = _repository.GetPaymentFrequencies().Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.PaymentFrequencyName,
                Value = x.PaymentFrequencyID.ToString(),
            }).ToList();

            inputModel.Statuses.SelectListItems = ModelHelpers.GetStatuses(this.CustomSession,_repository).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.StatusName,
                Value = x.StatusID.ToString(),
            }).ToList();

            if (model.SupportDays != null)
            {
                //inputModel.SupportDays.SelectListItems = this.ConstructContiguousDays(inputModel.NumberOfSupportDays.ChosenValue != null ? int.Parse(inputModel.NumberOfSupportDays.ChosenValue) : defaultContiguousSupportDays).SelectListItems;
                inputModel.SupportDays.SelectListItems = ModelHelpers.ConstructContiguousDays(inputModel.NumberOfSupportDays.ChosenValue != null ? int.Parse(inputModel.NumberOfSupportDays.ChosenValue) : ModelHelpers.GetNumberOfContiguousDays(model.SupportDays.SupportDaysName),_repository).SelectListItems;
            }
            inputModel.SupportHoursFrom.SelectListItems = ModelHelpers.ConstructListOfTimes(0, 2400, supportHoursStepInterval, "00:00").SelectListItems;

            inputModel.SupportHoursTo.SelectListItems = ModelHelpers.ConstructListOfTimes(0, 2400, supportHoursStepInterval, "00:00").SelectListItems;

            inputModel.SupportTerritories.SelectListItems = _repository.GetSupportTerritories().Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.SupportTerritoryName,
                Value = x.SupportTerritoryID.ToString(),
            }).ToList();

            inputModel.Timezone.SelectListItems = _repository.GetTimeZones(true).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.TimeZoneName,
                Value = x.TimeZoneID.ToString(),
            }).ToList();

        }
        #endregion

        #region AddVideoToInputModel
        private void AddVideoToInputModel(CloudApplication model, CloudApplicationInputModel inputModel, string defaultVideoExtension)
        {
            #region Video File Extensions
            //inputModel.VideoExtensions.ColumnCount = 1;
            //inputModel.VideoExtensions.CollectionTitle = "Video Extensions";
            //inputModel.VideoExtensions.SelectListItems = _repository.GetVideoExtensions().Select(x => new SelectListItem()
            //{
            //    Selected = false,
            //    Text = x,
            //    Value = x,
            //}).ToList();
            //inputModel.VideoExtensions.MultiSelect = false;
            #endregion

            #region Video Domains
            //inputModel.VideoDomains.ColumnCount = 1;
            //inputModel.VideoDomains.CollectionTitle = "Video Domains";
            //inputModel.VideoDomains.SelectListItems = _repository.GetVideoDomains().Select(x => new SelectListItem()
            //{
            //    Selected = false,
            //    Text = x,
            //    Value = x,
            //}).ToList();
            //inputModel.VideoDomains.MultiSelect = false;
            #endregion

            #region Videos
            if (model.CloudApplicationVideos != null)
            {
                //inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos = model.CloudApplicationVideos.Where(s => s.CloudApplicationVideoStatus.StatusName.ToUpper() == "LIVE").Select(x => new CloudApplicationVideoModel(CustomSession)
                inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos = model.CloudApplicationVideos.Where(s => s.CloudApplicationVideoStatus.StatusName.ToUpper() == "LIVE").Take(1).Select(x => new CloudApplicationVideoModel(CustomSession)
                {
                    CloudApplicationVideoFileFormat = x.CloudApplicationVideoFileFormat,
                    CloudApplicationVideoFileName = x.CloudApplicationVideoFileName,
                    CloudApplicationVideoURL = x.CloudApplicationVideoURL,
                    IsLive = x.CloudApplicationVideoStatus.StatusName.ToUpper() == "LIVE",
                    IsLocalDomain = x.IsLocalDomain,
                    IsYouTubeStream = x.IsYouTubeStream,
                    CloudApplicationVideoDomains = new SelectListItemCollection()
                    {
                        ColumnCount = 1,
                        CollectionTitle = "Video Domains",
                        SelectListItems = ModelHelpers.GetVideoDomains(Logger).SelectListItems,
                        MultiSelect = false,
                        ChosenValue = x.IsLocalDomain ? "CompareCloudware" : "HTTP",
                        OtherNumeric = 1,
                    },
                    CloudApplicationVideoExtensions = new SelectListItemCollection()
                    {
                        ColumnCount = 1,
                        CollectionTitle = "Video Domains",
                        SelectListItems = ModelHelpers.GetVideoExtensions(Logger).SelectListItems,
                        MultiSelect = false,
                        ChosenValue = x.CloudApplicationVideoFileFormat == null ? defaultVideoExtension : x.CloudApplicationVideoFileFormat,
                        OtherNumeric = 1,
                    },
                    ReadyToPlay = true,
                    CloudApplicationVideoID = x.CloudApplicationVideoID,
                    CloudApplicationVideoStatus = x.CloudApplicationVideoStatus.StatusName,
                }).ToList();


                inputModel.CloudApplicationVideosContainerModel.NoVideo = inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos.Count > 0 ? inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoStatus.ToUpper() == "DELETED" : true;

                if (inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos.Count == 0)
                {
                    inputModel.CloudApplicationVideosContainerModel.CloudApplicationVideos.Add(new CloudApplicationVideoModel()
                    {
                        CloudApplicationVideoFileFormat = "MP4",
                        CloudApplicationVideoFileName = "",
                        CloudApplicationVideoURL = "",
                        IsLive = false,
                        IsLocalDomain = false,
                        IsYouTubeStream = false,
                        CloudApplicationVideoDomains = new SelectListItemCollection()
                        {
                            ColumnCount = 1,
                            CollectionTitle = "Video Domains",
                            SelectListItems = ModelHelpers.GetVideoDomains(Logger).SelectListItems,
                            MultiSelect = false,
                            ChosenValue = "HTTP",
                            OtherNumeric = 1,
                        },
                        CloudApplicationVideoExtensions = new SelectListItemCollection()
                        {
                            ColumnCount = 1,
                            CollectionTitle = "Video Domains",
                            SelectListItems = ModelHelpers.GetVideoExtensions(Logger).SelectListItems,
                            MultiSelect = false,
                            ChosenValue = defaultVideoExtension,
                            OtherNumeric = 1,
                        },
                        ReadyToPlay = false,
                        //CloudApplicationVideoID = x.CloudApplicationVideoID,
                        CloudApplicationVideoStatus = "ADDED",
                    });
                }

            }
            #endregion
        }
        #endregion

        #region GetFeaturesForChosenCategory
        private List<CloudApplicationFeatureModel> GetFeaturesForChosenCategory(int categoryID)
        {
            var features = _repository.GetFeatures(categoryID).Select(x => new CloudApplicationFeatureModel()
            {
                CloudApplicationFeatureID = x.FeatureID,
                Cost = 0,
                Count = 0,
                CountSuffix = "",
                Feature = new FeatureModel()
                {
                    FeatureID = x.FeatureID,
                    FeatureName = x.FeatureName,
                },
                //Include = false,
                //IncludeCount = false,
                //IncludeCountSuffix = false,
                //IncludeExtraCost = false,
                IsOptional = false,
                HasCount = x.HasCount,
                OutputDisplayDescriptor = x.OutputDisplayDescriptor,
                CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven,
                
            }).ToList();

            return features;
        }
        #endregion

        #region GetApplicationsForChosenCategory
        private List<CloudApplicationFeatureModel> GetApplicationsForChosenCategory(int categoryID)
        {
            var features = _repository.GetApplications(categoryID).Select(x => new CloudApplicationFeatureModel()
            {
                CloudApplicationFeatureID = x.FeatureID,
                Cost = 0,
                Count = 0,
                CountSuffix = "",
                Feature = new FeatureModel()
                {
                    FeatureID = x.FeatureID,
                    FeatureName = x.FeatureName,
                },
                //Include = false,
                //IncludeCount = false,
                //IncludeCountSuffix = false,
                //IncludeExtraCost = false,
                IsOptional = false,
                //HasCount = x.HasCount,
                //OutputDisplayDescriptor = x.OutputDisplayDescriptor,


            }).ToList();

            return features;
        }
        #endregion

        #region ConstructCloudApplicationFromCloudApplicationInputModel
        private CloudApplication ConstructCloudApplicationFromCloudApplicationInputModel(CloudApplicationInputModel model)
        {
            CloudApplication ca = null;
            try
            {
                #region VARIABLES
                var displaySocialNetworking = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSocialNetworkingContainer"]);
                var displayProductReviews = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorProductReviewsContainer"]);
                var displayUserReviews = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorUserReviewsContainer"]);
                var displayDocuments = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorDocumentsContainer"]);
                var displayApplicationLogo = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorApplicationLogoContainer"]);
                var displayVideo = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorVideoContainer"]);
                var displayFeatures = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorFeaturesContainer"]);
                var displayApplicationCosts = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorApplicationCostsContainer"]);
                var displaySupportDays = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSupportDaysContainer"]);
                var displaySupportHours = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSupportHoursContainer"]);
                var displayVendorMainDetails = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorMainDetailsContainer"]);
                var displayCategories = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayCategoriesContainer"]);
                var displayServiceOverview = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorServiceOverviewContainer"]);
                var displayOperatingSystems = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorOperatingSystemsContainer"]);
                var displaySupportTypes = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSupportTypesContainer"]);
                var displaySupportTerritories = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSupportTerritoriesContainer"]);
                var displayMobilePlatforms = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorMobilePlatformsContainer"]);
                var displayBrowsers = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorBrowsersContainer"]);
                var displayLanguages = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorLanguagesContainer"]);
                var displayLicenceTypeMinimum = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorLicenceTypeMinimumContainer"]);
                var displayLicenceTypeMaximum = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorLicenceTypeMaximumContainer"]);
                var displayVideoTraining = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorVideoTrainingContainer"]);
                var displayFreeTrialPeriod = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorFreeTrialPeriodContainer"]);
                var displaySetupFee = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorSetupFeeContainer"]);
                var displayMinimumContract = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorMinimumContractContainer"]);
                var displayPaymentFrequency = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorPaymentFrequencyContainer"]);
                var displayPaymentOptions = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorPaymentOptionsContainer"]);
                var displayApplicationCurrency = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorApplicationCurrencyContainer"]);
                var displayTimezone = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorApplicationTimezoneContainer"]);
                var displayApplications = Convert.ToBoolean(ConfigurationManager.AppSettings["DisplayVendorApplicationsContainer"]);
                #endregion

                model.ApplicationHasActiveSupport = ModelHelpers.ApplicationHasActiveSupport(model.SupportTypes.SelectListItems);

                Vendor v = new Vendor()
                {
                    VendorName = model.Vendor.VendorName,
                    VendorLogoFileName = model.Vendor.VendorLogoFileName,
                    //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                    VendorLogoFullURL = model.Vendor.VendorLogoFullURL,
                    VendorLogo = new VendorLogo()
                    {
                        //Logo = System.IO.File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                        Logo = model.Vendor.VendorLogo,
                    }
                };

                ca = GetModelFromViewData(model.CloudApplicationID);
                //ca.AddDate = DateTime.Now;
                ca.ApplicationContentStatusID = -1; //??

                #region COSTS
                //ca.ApplicationCostOneOff = model.ApplicationCostOneOff;
                ca.ApplicationCostPerAnnum = model.ApplicationCostPerAnnumWhole + (decimal)model.ApplicationCostPerAnnumFraction / 100;
                ca.ApplicationCostPerAnnumFrom = model.ApplicationCostPerAnnumFromWhole + (decimal)model.ApplicationCostPerAnnumFromFraction / 100;
                ca.ApplicationCostPerAnnumPOA = model.ApplicationCostPerAnnumPOA;
                //ca.ApplicationCostPerAnnumSuffix = model.ApplicationCostPerAnnumSuffix;
                ca.ApplicationCostPerAnnumTo = model.ApplicationCostPerAnnumToWhole + (decimal)model.ApplicationCostPerAnnumToFraction / 100;
                ca.ApplicationCostPerAnnumIsForUnlimitedUsers = model.ApplicationCostPerAnnumIsForUnlimitedUsers;
                ca.ApplicationCostPerAnnumFree = model.ApplicationCostPerAnnumFree;
                ca.ApplicationCostPerAnnumAvailable = model.ApplicationCostPerAnnumAvailable;
                ca.ApplicationCostPerAnnumOffered = model.ApplicationCostPerAnnumOffered;

                ca.ApplicationCostPerMonth = model.ApplicationCostPerMonthWhole + (decimal)model.ApplicationCostPerMonthFraction / 100;
                ca.ApplicationCostPerMonthFrom = model.ApplicationCostPerMonthFromWhole + (decimal)model.ApplicationCostPerMonthFromFraction / 100;
                ca.ApplicationCostPerMonthPOA = model.ApplicationCostPerMonthPOA;
                ca.ApplicationCostPerMonthSuffix = model.ApplicationCostPerMonthSuffix;
                ca.ApplicationCostPerMonthTo = model.ApplicationCostPerMonthToWhole + (decimal)model.ApplicationCostPerMonthToFraction / 100;
                ca.ApplicationCostPerMonthIsForUnlimitedUsers = model.ApplicationCostPerMonthIsForUnlimitedUsers;
                ca.ApplicationCostPerMonthFree = model.ApplicationCostPerMonthFree;
                ca.ApplicationCostPerMonthAvailable = model.ApplicationCostPerMonthAvailable;
                ca.ApplicationCostPerMonthOffered = model.ApplicationCostPerMonthOffered;
                #endregion

                ca.ApprovalAssignedPersonID = model.ApprovalAssignedPersonID; //??
                ca.ApprovalStatusID = model.ApprovalStatusID; //??
                ca.Brand = model.Vendor.VendorName;

                #region BROWSERS
                ca.Browsers = model.Browsers.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindBrowserByName(x.Text))
                    .ToList();
                #endregion

                ca.CallsPackageCostPerMonth = model.CallsPackageCostPerMonth; //??

                #region CATEGORY
                if (CustomSession.AddMode)
                {
                    ca.Category = model.Categories.SelectListItems.Where(x => x.Value == model.Categories.ChosenValue)
                        .Select(x => _repository.FindCategoryByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    //ca.Category = _repository.FindCategoryByID(int.Parse(model.Categories.ChosenValue));
                }
                #endregion

                #region APPLICATIONS
                ca.CloudApplicationApplications.ForEach(x => DeleteUnselectedApplicationDetails(x, model.Applications.SelectListItems.Where(a => a.Selected).ToList()));
                //ca.CloudApplicationApplications = model.Applications.SelectListItems.Where(x => x.Selected)
                //    .Select(x =>
                //        _repository.FindCloudApplicationApplicationByName(x.Text, model.CloudApplicationID, ca.Category.CategoryID, true) != null
                //        ? _repository.FindCloudApplicationApplicationByName(x.Text, model.CloudApplicationID, ca.Category.CategoryID, true)
                //        : _repository.FindApplicationByName(x.Text, ca.Category.CategoryID, true)
                //            )
                //    .ToList();


                UpdateApplicationsDetails(ca.CloudApplicationApplications, model.Applications.SelectListItems, ca);

                //ca.CloudApplicationFeatures = new List<CloudApplicationFeature>();

                if (model.Applications.SelectListItems != null)
                {
                    var numberBasedApplications = model.Applications.SelectListItems.Where(x => x.HasCount).Where(x => x.Count > 0)
                        //.Select(x => _repository.FindFeatureByName(x.Text, ca.Category.CategoryID)) 
                        .ToList();

                    foreach (SelectListItemFeature slif in numberBasedApplications)
                    {
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).AdditionalInformation = caf.AdditionalInformation;
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).Cost = caf.Cost;
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).Count = caf.Count;
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).CountSuffix = caf.CountSuffix;
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).IncludeExtraCost = caf.IncludeExtraCost;
                        //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).IsOptional = caf.IsOptional;
                        CloudApplicationApplication caf = _repository.FindApplicationByName(slif.Text, ca.Category.CategoryID, true);

                        caf.AdditionalInformation = "";
                        caf.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
                        //caf.Count = slif.Count;
                        caf.Count = ModelHelpers.FormatDataStorageValueForBytes(slif);
                        caf.CountSuffix = slif.CountSuffix;
                        caf.IncludeExtraCost = slif.IncludeExtraCost;
                        caf.IsOptional = slif.IsOptional;

                        //ca.CloudApplicationFeatures.Add(caf);

                    }
                }
                #endregion

                #region FEATURES
                ca.CloudApplicationFeatures.ForEach(x => DeleteUnselectedFeatureDetails(x, model.Features.SelectListItems.Where(a => a.Selected).ToList()));
                //ca.CloudApplicationFeatures = model.Features.SelectListItems.Where(x => x.Selected)
                //    .Select(x =>
                //        _repository.FindCloudApplicationFeatureByName(x.Text, model.CloudApplicationID, ca.Category.CategoryID, true) != null
                //        ? _repository.FindCloudApplicationFeatureByName(x.Text, model.CloudApplicationID, ca.Category.CategoryID, true)
                //        : _repository.FindFeatureByName(x.Text,ca.Category.CategoryID,true)
                //        //{
                //            //AdditionalInformation = "",
                //            //CloudApplication = ca,
                //            //CloudApplicationFeatureStatus = _repository.FindStatusByName("LIVE"),
                //            //Cost = x.CostWhole + (decimal)x.CostFraction / 100,
                //            //Count = x.Count,
                //            //CountSuffix = x.CountSuffix,
                //            //Feature = _repository.FindFeatureByName(x.Text,ca.Category.CategoryID,true),
                //        //}
                //            )
                //    .ToList();


                UpdateFeaturesDetails(ca.CloudApplicationFeatures, model.Features.SelectListItems, ca);

                //ca.CloudApplicationFeatures = new List<CloudApplicationFeature>();

                var numberBasedFeatures = model.Features.SelectListItems.Where(x => (x.HasCount && x.Count > 0) || x.IsUnlimited)
                    //.Select(x => _repository.FindFeatureByName(x.Text, ca.Category.CategoryID)) 
                    .ToList();

                foreach (SelectListItemFeature slif in numberBasedFeatures)
                {
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).AdditionalInformation = caf.AdditionalInformation;
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).Cost = caf.Cost;
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).Count = caf.Count;
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).CountSuffix = caf.CountSuffix;
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).IncludeExtraCost = caf.IncludeExtraCost;
                    //numberBasedFeatures.Find(x => x.Feature.FeatureName.ToUpper().StartsWith(caf.Feature.FeatureName)).IsOptional = caf.IsOptional;
                    //CloudApplicationFeature caf = _repository.FindFeatureByName(slif.Text, ca.Category.CategoryID,true);
                    CloudApplicationFeature caf = ca.CloudApplicationFeatures.Where(x => x.Feature.FeatureName == slif.Text).FirstOrDefault();

                    if (caf != null)
                    {
                        caf.AdditionalInformation = "";
                        caf.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
                        caf.Count = !slif.IsUnlimited ? ModelHelpers.FormatDataStorageValueForBytes(slif) : 16384;
                        caf.CountSuffix = slif.CountSuffix;
                        caf.IncludeExtraCost = slif.IncludeExtraCost;
                        caf.IsOptional = slif.IsOptional;
                    }
                    //ca.CloudApplicationFeatures.Add(caf);

                }
                #endregion

                #region LOGO
                ca.CloudApplicationLogo = model.CloudApplicationLogo; //NOT USED
                #endregion

                ca.CompanyURL = model.CompanyURL;
                ca.Description = model.Description;

                #region DEVICES
                ca.Devices = model.Devices != null ? model.Devices.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindDeviceByName(x.Text))
                    .ToList() : null;
                #endregion

                ca.FacebookFollowers = model.FacebookFollowers;
                ca.FacebookName = model.FacebookName;
                ca.FacebookURL = model.FacebookURL;

                #region FREE TRIAL PERIOD
                if (CustomSession.AddMode)
                {
                    ca.FreeTrialPeriod = model.FreeTrialPeriods.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindFreeTrialPeriodByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    ca.DemoOffered = model.DemoOffered; //??
                    if (model.DemoOffered)
                    {
                        ca.FreeTrialPeriod = _repository.FindFreeTrialPeriodByName("NO");
                    }
                    else
                    {
                        ca.FreeTrialPeriod = _repository.FindFreeTrialPeriodByID(int.Parse(model.FreeTrialPeriods.ChosenValue));
                    }
                }
                #endregion

                #region STATUS
                if (CustomSession.AddMode)
                {
                    ca.CloudApplicationStatus = _repository.FindStatusByName("MEDIATION");
                    //ca.IsLive = false;
                }
                if (CustomSession.EditMode)
                {
                    if (model.ApplyStatusAtVendorLevel)
                    {
                        _repository.SetStatusAtVendorLevel(ca.Vendor.VendorID, int.Parse(model.Statuses.ChosenValue));
                    }
                    //ca.CloudApplicationStatus = _repository.FindStatusByName("LIVE");
                    //ca.IsLive = true;
                    else
                    {
                        ca.CloudApplicationStatus = _repository.FindStatusByID(int.Parse(model.Statuses.ChosenValue));
                    }
                }
                ca.LastUpdateDate = DateTime.Now;
                #endregion

                #region LANGUAGES
                ca.Languages = model.Languages.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindLanguageByName(x.Text))
                    .ToList();
                #endregion

                ca.LastFacebookPing = DateTime.Now;
                ca.LastLinkedInPing = DateTime.Now;
                ca.LastTwitterPing = DateTime.Now;


                #region LICENCE TYPES
                if (CustomSession.AddMode)
                {
                    ca.LicenceTypeMaximum = model.LicenceTypeMaximum.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindLicenceTypeMaximumByName(int.Parse(x.Text)))
                        .FirstOrDefault();
                    ca.LicenceTypeMinimum = model.LicenceTypeMinimum.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindLicenceTypeMinimumByName(int.Parse(x.Text)))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    #region LICENCE TYPE MINIMUM
                    //ca.LicenceTypeMaximum = _repository.FindLicenceTypeMaximumByName(int.Parse(model.LicenceTypeMaximum.ChosenValue));
                    //ca.LicenceTypeMinimum = _repository.FindLicenceTypeMinimumByName(int.Parse(model.LicenceTypeMinimum.ChosenValue));
                    int? chosenValue = model.LicenceTypeMinimum.ChosenValue != null ? int.Parse(model.LicenceTypeMinimum.ChosenValue) : (int?)null;
                    if (model.LicenceTypeMinimum.IsUnlimited)
                    {
                        var licenceTypeMinimum = _repository.FindLicenceTypeMinimumByName(16384, true);
                        ca.LicenceTypeMinimum = licenceTypeMinimum;
                    }
                    else
                    {
                        if (model.LicenceTypeMinimum.OtherIsSelected)
                        {
                            chosenValue = model.LicenceTypeMinimum.OtherIsNumeric ? model.LicenceTypeMinimum.OtherNumeric : int.Parse(model.LicenceTypeMinimum.Other);
                        }
                        if (chosenValue != null)
                        {
                            var licenceTypeMinimum = _repository.FindLicenceTypeMinimumByName((int)chosenValue, true);
                            if (licenceTypeMinimum == null)
                            {
                                LicenceTypeMinimum ltm = new LicenceTypeMinimum()
                                {
                                    LicenceTypeMinimumName = (int)chosenValue,
                                    LicenceTypeMinimumStatus = _repository.FindStatusByName("LIVE"),
                                };
                                _repository.AddLicenceTypeMinimum(ltm);
                                ca.LicenceTypeMinimum = ltm;
                            }
                            else
                            {
                                ca.LicenceTypeMinimum = licenceTypeMinimum;
                            }
                        }
                        else
                        {
                            throw new Exception("Fail on minimum users");
                        }
                    }
                    #endregion

                    #region LICENCE TYPE MAXIMUM
                    chosenValue = model.LicenceTypeMaximum.ChosenValue != null ? int.Parse(model.LicenceTypeMaximum.ChosenValue) : (int?)null;
                    if (model.LicenceTypeMaximum.IsUnlimited)
                    {
                        var licenceTypeMaximum = _repository.FindLicenceTypeMaximumByName(16384, true);
                        ca.LicenceTypeMaximum = licenceTypeMaximum;
                    }
                    else
                    {
                        if (model.LicenceTypeMaximum.OtherIsSelected)
                        {
                            chosenValue = model.LicenceTypeMaximum.OtherIsNumeric ? model.LicenceTypeMaximum.OtherNumeric : int.Parse(model.LicenceTypeMaximum.Other);
                        }
                        if (chosenValue != null)
                        {
                            var licenceTypeMaximum = _repository.FindLicenceTypeMaximumByName((int)chosenValue, true);
                            if (licenceTypeMaximum == null)
                            {
                                LicenceTypeMaximum ltm = new LicenceTypeMaximum()
                                {
                                    LicenceTypeMaximumName = (int)chosenValue,
                                    LicenceTypeMaximumStatus = _repository.FindStatusByName("LIVE"),
                                };
                                _repository.AddLicenceTypeMaximum(ltm);
                                ca.LicenceTypeMaximum = ltm;
                            }
                            else
                            {
                                ca.LicenceTypeMaximum = licenceTypeMaximum;
                            }
                        }
                        else
                        {
                            throw new Exception("Fail on maximum users");
                        }
                    }
                    #endregion

                }
                #endregion

                ca.LinkedInCompanyID = model.LinkedInCompanyID;
                ca.LinkedInFollowers = model.LinkedInFollowers;
                ca.LinkedInURL = model.LinkedInURL;
                ca.MaximumMeetingAttendees = model.MaximumMeetingAttendees; //NOT USED
                ca.MaximumWebinarAttendees = model.MaximumWebinarAttendees; //NOT USED

                #region MINIMUM CONTRACT
                if (CustomSession.AddMode)
                {
                    ca.MinimumContract = model.MinimumContracts.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindMinimumContractByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    int? chosenValue = model.MinimumContracts.ChosenValue != null ? int.Parse(model.MinimumContracts.ChosenValue) : (int?)null;
                    if (model.MinimumContracts.IsNo)
                    {
                        ca.MinimumContract = _repository.FindMinimumContractByName("NO");
                    }
                    else if (model.MinimumContracts.OtherIsSelected)
                    {
                        chosenValue = model.MinimumContracts.OtherIsNumeric ? model.MinimumContracts.OtherNumeric : int.Parse(model.MinimumContracts.Other);
                    }
                    else
                    {
                        ca.MinimumContract = _repository.FindMinimumContractByID(int.Parse(model.MinimumContracts.ChosenValue));
                    }

                }
                #endregion

                #region MOBILE PLATFORMS
                ca.MobilePlatforms = model.MobilePlatforms != null ? model.MobilePlatforms.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindMobilePlatformByName(x.Text))
                    .ToList() : null;
                #endregion

                #region OPERATING SYSTEMS
                if (displayOperatingSystems)
                {
                    ca.OperatingSystems = model.OperatingSystems != null ? model.OperatingSystems.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindOperatingSystemByName(x.Text))
                        .ToList() : ca.OperatingSystems;
                }
                #endregion

                ca.Options = model.Options;//??
                ca.PayAsYouGo = model.PayAsYouGo;

                #region PAYMENT FREQUENCY
                if (CustomSession.AddMode)
                {
                    ca.PaymentFrequency = model.PaymentFrequencies.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindPaymentFrequencyByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    ca.PaymentFrequency = _repository.FindPaymentFrequencyByID(int.Parse(model.PaymentFrequencies.ChosenValue));
                }
                #endregion

                #region PAYMENT OPTIONS
                ca.PaymentOptions = model.PaymentOptions.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindPaymentOptionByName(x.Text))
                    .ToList();
                #endregion


                #region USER REVIEWS
                if (CustomSession.AddMode)
                {
                    //ca.CloudApplicationUserReviews = model.CloudApplicationUserReviews.Where(r => r.Persisted).Select(x => new CloudApplicationUserReview()
                    ca.CloudApplicationUserReviews = model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(r => r.Persisted).Select(x => new CloudApplicationUserReview()
                        {
                            CloudApplicationUserReviewEaseOfUse = x.CloudApplicationUserReviewEaseOfUse * 20,
                            CloudApplicationUserReviewFunctionality = x.CloudApplicationUserReviewFunctionality * 20,
                            CloudApplicationUserReviewOverallRating = x.CloudApplicationUserReviewOverallRating * 20,
                            CloudApplicationUserReviewValueForMoney = x.CloudApplicationUserReviewValueForMoney * 20,
                            CloudApplicationUserReviewCompany = x.CloudApplicationUserReviewCompany,
                            CloudApplicationUserReviewForename = x.CloudApplicationUserReviewForename,
                            CloudApplicationUserReviewSurname = x.CloudApplicationUserReviewSurname,
                            CloudApplicationUserReviewTitle = x.CloudApplicationUserReviewTitle,
                            CloudApplicationUserReviewText = x.CloudApplicationUserReviewText,
                            CloudApplicationUserReviewEmployeeCount = x.ChosenEmployeeCount,
                            CloudApplicationUserReviewIndustry = _repository.GetIndustry(x.ChosenIndustryID),
                            UniqueRowID = x.RowID,
                            CloudApplicationUserReviewStatus = _repository.FindStatusByName(x.CloudApplicationUserReviewStatus),
                        })
                        .ToList();
                }

                if (CustomSession.EditMode)
                {
                    //foreach (CloudApplicationUserReviewModel caurm in model.CloudApplicationUserReviews)
                    //{
                    //    CloudApplicationUserReview caur = ca.CloudApplicationUserReviews.Find(x => x.CloudApplicationUserReviewID == caurm.CloudApplicationUserReviewID);
                    //    if (caur != null)
                    //    {
                    //        caur.CloudApplicationEaseOfUse = caurm.CloudApplicationEaseOfUse * 20;
                    //        caur.CloudApplicationFunctionality = caurm.CloudApplicationFunctionality * 20;
                    //        caur.CloudApplicationOverallRating = caurm.CloudApplicationOverallRating * 20;
                    //        caur.CloudApplicationValueForMoney = caurm.CloudApplicationValueForMoney * 20;
                    //        caur.CloudApplicationRatingReviewerCompany = caurm.CloudApplicationRatingReviewerCompany;
                    //        caur.CloudApplicationRatingReviewerForename = caurm.CloudApplicationRatingReviewerForename;
                    //        caur.CloudApplicationRatingReviewerSurname = caurm.CloudApplicationRatingReviewerSurname;
                    //        caur.CloudApplicationRatingReviewerTitle = caurm.CloudApplicationRatingReviewerTitle;
                    //        caur.CloudApplicationRatingText = caurm.CloudApplicationRatingText;
                    //        caur.CloudApplicationReviewEmployeeCount = caurm.ChosenEmployeeCount;
                    //        caur.CloudApplicationReviewIndustry = _repository.GetIndustry(caurm.ChosenIndustryID);
                    //        //caur.UniqueRowID = caurm.RowID;
                    //        //caur.IsLive = caurm.IsLive;

                    //    }
                    //}

                    //foreach (CloudApplicationUserReviewModel caurm in model.CloudApplicationUserReviews)
                    foreach (CloudApplicationUserReviewModel caurm in model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews)
                    {
                        if (!caurm.IsLive && caurm.Persisted)
                        {
                            //deleted in model but exists in database
                            CloudApplicationUserReview caur = ca.CloudApplicationUserReviews.Find(x => x.CloudApplicationUserReviewID == caurm.CloudApplicationUserReviewID);
                            if (caur != null)
                            {
                                caur.CloudApplicationUserReviewStatus = _repository.FindStatusByName("DELETED");
                            }
                        }
                        else if (!caurm.IsLive && !caurm.Persisted)
                        {

                        }
                        else if (caurm.AddMode)
                        {
                            ca.CloudApplicationUserReviews.Add(new CloudApplicationUserReview()
                            {
                                CloudApplicationUserReviewEaseOfUse = caurm.CloudApplicationUserReviewEaseOfUse * 20,
                                CloudApplicationUserReviewFunctionality = caurm.CloudApplicationUserReviewFunctionality * 20,
                                CloudApplicationUserReviewOverallRating = caurm.CloudApplicationUserReviewOverallRating * 20,
                                CloudApplicationUserReviewValueForMoney = caurm.CloudApplicationUserReviewValueForMoney * 20,
                                CloudApplicationUserReviewCompany = caurm.CloudApplicationUserReviewCompany,
                                CloudApplicationUserReviewForename = caurm.CloudApplicationUserReviewForename,
                                CloudApplicationUserReviewSurname = caurm.CloudApplicationUserReviewSurname,
                                CloudApplicationUserReviewTitle = caurm.CloudApplicationUserReviewTitle,
                                CloudApplicationUserReviewText = caurm.CloudApplicationUserReviewText,
                                CloudApplicationUserReviewEmployeeCount = caurm.ChosenEmployeeCount,
                                CloudApplicationUserReviewIndustry = _repository.GetIndustry(caurm.ChosenIndustryID),
                                UniqueRowID = caurm.RowID,
                                CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE"),
                                CloudApplicationUserReviewDate = DateTime.Now,
                            });
                        }
                        else
                        {
                            //must be edited
                            CloudApplicationUserReview caur = ca.CloudApplicationUserReviews.Find(x => x.CloudApplicationUserReviewID == caurm.CloudApplicationUserReviewID);
                            if (caur != null)
                            {
                                //caur.CloudApplication = ;
                                caur.CloudApplicationUserReviewCompany = caurm.CloudApplicationUserReviewCompany;
                                //caur.CloudApplicationUserReviewDate = DateTime.Now;
                                caur.CloudApplicationUserReviewEaseOfUse = caurm.CloudApplicationUserReviewEaseOfUse * 20;
                                caur.CloudApplicationUserReviewEmployeeCount = caurm.ChosenEmployeeCount;
                                caur.CloudApplicationUserReviewForename = caurm.CloudApplicationUserReviewForename;
                                caur.CloudApplicationUserReviewFunctionality = caurm.CloudApplicationUserReviewFunctionality * 20;
                                //caur.CloudApplicationUserReviewID = caurm.CloudApplicationUserReviewCompany;
                                caur.CloudApplicationUserReviewIndustry = _repository.GetIndustry(caurm.ChosenIndustryID);
                                caur.CloudApplicationUserReviewOverallRating = caurm.CloudApplicationUserReviewOverallRating * 20;
                                caur.CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE");
                                caur.CloudApplicationUserReviewSurname = caurm.CloudApplicationUserReviewSurname;
                                caur.CloudApplicationUserReviewText = caurm.CloudApplicationUserReviewText;
                                caur.CloudApplicationUserReviewTitle = caurm.CloudApplicationUserReviewTitle;
                                caur.CloudApplicationUserReviewValueForMoney = caurm.CloudApplicationUserReviewValueForMoney * 20;
                            }

                        }
                    }
                    
                    //ca.CloudApplicationUserReviews = ca.CloudApplicationUserReviews
                    //    //.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE")
                    //    .ToList();
                    
                }
                #endregion

                #region RATINGS
                RefreshOverallCloudApplicationUserReviewRatings(ca);
                #endregion

                #region PRODUCT REVIEWS
                if (CustomSession.AddMode)
                {
                    ca.CloudApplicationProductReviews = model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(r => r.Persisted).Select(x => new CloudApplicationProductReview()
                        {
                            CloudApplication = ca,
                            CloudApplicationProductReviewDate = x.CloudApplicationProductReviewDate,
                            CloudApplicationProductReviewHeadline = x.CloudApplicationProductReviewHeadline,
                            //CloudApplicationReviewPhysicalFileName = x.CloudApplicationReviewURL,
                            CloudApplicationProductReviewPublisherName = x.CloudApplicationProductReviewPublisherName,
                            CloudApplicationProductReviewText = x.CloudApplicationProductReviewText,
                            CloudApplicationProductReviewURL = x.CloudApplicationProductReviewURL,
                            CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(x.CloudApplicationProductReviewURLDocumentFormat),
                            IsDocument = (x.CloudApplicationProductReviewURLDocumentFormat == "DOC" || x.CloudApplicationProductReviewURLDocumentFormat == "PDF"),
                            CloudApplicationProductReviewStatus = _repository.FindStatusByName(x.CloudApplicationProductReviewStatus),
                            IsBrokenLink = x.IsBrokenLink,
                            UniqueRowID = x.RowID,
                        })
                        .ToList();
                }
                if (CustomSession.EditMode)
                {
                    foreach (CloudApplicationProductReviewModel caprm in model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews)
                    {
                        if (!caprm.IsLive && caprm.Persisted)
                        {
                            //deleted in model but exists in database
                            CloudApplicationProductReview capr = ca.CloudApplicationProductReviews.Find(x => x.CloudApplicationProductReviewID == caprm.CloudApplicationProductReviewID);
                            if (capr != null)
                            {
                                capr.CloudApplicationProductReviewStatus = _repository.FindStatusByName("DELETED");
                            }
                        }
                        else if (!caprm.IsLive && !caprm.Persisted)
                        {

                        }
                        else if (caprm.AddMode)
                        {
                            ca.CloudApplicationProductReviews.Add(new CloudApplicationProductReview()
                            {
                                //CloudApplication = caurm.CloudApplicationUserReviewEaseOfUse * 20,
                                CloudApplicationProductReviewDate = caprm.CloudApplicationProductReviewDate,
                                CloudApplicationProductReviewHeadline = caprm.CloudApplicationProductReviewHeadline,
                                //CloudApplicationProductReviewID = caurm.CloudApplicationUserReviewValueForMoney * 20,
                                CloudApplicationProductReviewPhysicalFileName = "",
                                CloudApplicationProductReviewPublisherName = caprm.CloudApplicationProductReviewPublisherName,
                                CloudApplicationProductReviewStatus = _repository.FindStatusByName("LIVE"),
                                CloudApplicationProductReviewText = caprm.CloudApplicationProductReviewText,
                                CloudApplicationProductReviewURL = caprm.CloudApplicationProductReviewURL,
                                CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(caprm.CloudApplicationProductReviewURLDocumentFormat),
                                IsBrokenLink = caprm.IsBrokenLink,
                                IsDocument = (caprm.CloudApplicationProductReviewURLDocumentFormat == "DOC" || caprm.CloudApplicationProductReviewURLDocumentFormat == "PDF"),
                                UniqueRowID = caprm.RowID,
                            });
                        }
                        else
                        {
                            //must be edited
                            CloudApplicationProductReview capr = ca.CloudApplicationProductReviews.Find(x => x.CloudApplicationProductReviewID == caprm.CloudApplicationProductReviewID);
                            if (capr != null)
                            {
                                //capr.CloudApplication = ;
                                capr.CloudApplicationProductReviewDate = caprm.CloudApplicationProductReviewDate;
                                capr.CloudApplicationProductReviewHeadline = caprm.CloudApplicationProductReviewHeadline;
                                //capr.CloudApplicationProductReviewID = caprm.CloudApplicationProductReviewID;
                                capr.CloudApplicationProductReviewPhysicalFileName = "";
                                capr.CloudApplicationProductReviewPublisherName = caprm.CloudApplicationProductReviewPublisherName;
                                capr.CloudApplicationProductReviewStatus = _repository.FindStatusByName("LIVE");
                                capr.CloudApplicationProductReviewText = caprm.CloudApplicationProductReviewText;
                                capr.CloudApplicationProductReviewURL = caprm.CloudApplicationProductReviewURL;
                                capr.CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(caprm.CloudApplicationProductReviewURLDocumentFormat);
                                capr.IsBrokenLink = caprm.IsBrokenLink;
                                capr.IsDocument = (caprm.CloudApplicationProductReviewURLDocumentFormat == "DOC" || caprm.CloudApplicationProductReviewURLDocumentFormat == "PDF");
                                capr.UniqueRowID = caprm.RowID;
                            }

                        }
                    }
                }
                #endregion

                ca.SearchResultWeighting = 12345;
                ca.ServiceName = model.ServiceName;
                ca.BuyURL = model.BuyURL;
                ca.TryURL = model.TryURL;

                #region SETUP FEE
                //string setupFeeName = "£" + (model.SetupFeeWhole + (decimal)model.SetupFeeFraction / 100).ToString("0.00");
                if (model.NoSetupFee)
                {
                    SetupFee existingSetupFee = _repository.FindSetupFeeByName("NO");
                    ca.SetupFee = existingSetupFee;
                }
                else if (model.SetupFeeIsPOA)
                {
                    SetupFee existingSetupFee = _repository.FindSetupFeeByName("POA");
                    ca.SetupFee = existingSetupFee;
                }
                else if (model.SetupFeeWhole > 0 && model.SetupFeeFraction > 0)
                {
                    string setupFeeName = (model.SetupFeeWhole + (decimal)model.SetupFeeFraction / 100).ToString("0.00");
                    SetupFee existingSetupFee = _repository.FindSetupFeeByName(setupFeeName);
                    if (existingSetupFee == null)
                    {
                        ca.SetupFee = new SetupFee()
                        {
                            SetupFeeName = setupFeeName,
                            SetupFeeStatus = _repository.FindStatusByName("LIVE"),
                        };
                    }
                    else
                    {
                        ca.SetupFee = existingSetupFee;
                    }
                }
                else
                {
                    //ca.SetupFee = new SetupFee() { SetupFeeName = setupFeeName };
                }
                //ca.SetupFee = model.MinimumContracts.SelectListItems.Where(x => x.Selected)
                //    .Select(x => _repository.FindMinimumContractByName(x.Text))
                //    .First();

                #endregion

                #region SUPPORT DAYS
                if (CustomSession.AddMode)
                {
                    ca.SupportDays = model.SupportDays.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindSupportDaysByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    if (model.ApplicationHasActiveSupport)
                    {
                        if (model.SupportDays.ChosenValue != null)
                        {
                            var supportDays = _repository.FindSupportDaysByName(model.SupportDays.ChosenValue, true);
                            if (supportDays == null)
                            {
                                SupportDays sd = new SupportDays()
                                {
                                    SupportDaysName = model.SupportDays.ChosenValue,
                                    SupportDaysStatus = _repository.FindStatusByName("LIVE"),
                                };
                                _repository.AddSupportDays(sd);
                                ca.SupportDays = sd;
                            }
                            else
                            {
                                ca.SupportDays = supportDays;
                            }
                        }
                    }
                    else
                    {
                        ca.SupportDays = null;
                    }
                }
                #endregion

                #region SUPPORT HOURS
                if (CustomSession.AddMode)
                {
                    ca.SupportHours = model.SupportHours.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindSupportHoursByName(x.Text))
                        .FirstOrDefault();
                }
                if (CustomSession.EditMode)
                {
                    if (model.ApplicationHasActiveSupport)
                    {
                        //ca.SupportHours = _repository.FindSupportHoursByID(int.Parse(model.SupportHours.ChosenValue));
                        if (model.SupportHoursFrom.ChosenValue != null && model.SupportHoursTo.ChosenValue != null)
                        {
                            ca.SupportHours = _repository.FindSupportHoursByName(int.Parse(model.SupportHoursFrom.ChosenValue), int.Parse(model.SupportHoursTo.ChosenValue));
                        }
                    }
                    else
                    {
                        ca.SupportHours = null;
                    }
                }
                #endregion

                //ca.SupportOffered = model.supportoffered;//??

                #region SUPPORT TERRITORIES
                if (CustomSession.AddMode)
                {
                    ca.SupportTerritories = model.SupportTerritories.SelectListItems.Where(x => x.Selected)
                        .Select(x => _repository.FindSupportTerritoryByName(x.Text))
                        .ToList();
                }
                if (CustomSession.EditMode)
                {
                    if (model.ApplicationHasActiveSupport)
                    {
                        if (model.SupportTerritories.ChosenValue != null)
                        {
                            ca.SupportTerritories = new List<SupportTerritory>()
                    {
                        _repository.FindSupportTerritoryByID(int.Parse(model.SupportTerritories.ChosenValue))
                    };
                        }
                        else
                        {
                            ca.SupportTerritories = null;
                        }
                    }
                    else
                    {
                        ca.SupportTerritories = null;
                    }
                }
                #endregion

                #region SUPPORT TYPES
                ca.SupportTypes = model.SupportTypes.SelectListItems.Where(x => x.Selected)
                    .Select(x => _repository.FindSupportTypeByName(x.Text))
                    .ToList();
                #endregion

                #region DOCUMENTS
                //ca.Documents = model.Documents;

                if (CustomSession.AddMode)
                {
                    ca.CloudApplicationDocuments = model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(r => r.Persisted).Select(x => new CloudApplicationDocument()
                    {
                        CloudApplication = ca,
                        CloudApplicationDocumentImage = new CloudApplicationDocumentImage()
                        {
                            CloudApplicationDocumentBytes = x.CloudApplicationDocument,
                        },
                        CloudApplicationDocumentFileName = x.CloudApplicationDocumentFileName,
                        CloudApplicationDocumentPhysicalFilePath = x.CloudApplicationDocumentPhysicalFilePath,
                        CloudApplicationDocumentTitle = x.CloudApplicationDocumentTitle,
                        CloudApplicationDocumentType = _repository.FindCloudApplicationDocumentTypeByName(x.CloudApplicationDocumentType.CloudApplicationDocumentTypeName),
                        CloudApplicationDocumentURL = x.CloudApplicationDocumentURL,
                        CloudApplicationDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(x.CloudApplicationDocumentFileFormat),
                        CloudApplicationDocumentStatus = _repository.FindStatusByName(x.CloudApplicationDocumentStatus),
                        UniqueRowID = x.RowID,
                        

                    })
                    .ToList();
                }
                if (CustomSession.EditMode)
                {
                    foreach (CloudApplicationDocumentModel cadm in model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments)
                    {
                        if (!cadm.IsLive && cadm.Persisted)
                        {
                            //deleted in model but exists in database
                            CloudApplicationDocument cad = ca.CloudApplicationDocuments.Find(x => x.CloudApplicationDocumentID == cadm.CloudApplicationDocumentID);
                            if (cad != null)
                            {
                                cad.CloudApplicationDocumentStatus = _repository.FindStatusByName("DELETED");
                            }
                        }
                        else if (!cadm.IsLive && !cadm.Persisted)
                        {

                        }
                        else if (cadm.AddMode)
                        {
                            ca.CloudApplicationDocuments.Add(new CloudApplicationDocument()
                            {
                                //CloudApplication = caurm.CloudApplicationUserReviewEaseOfUse * 20,
                                CloudApplicationDocumentFileName = cadm.CloudApplicationDocumentFileName,
                                CloudApplicationDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(cadm.CloudApplicationDocumentFileFormat),
                                //CloudApplicationDocumentID = caurm.CloudApplicationUserReviewValueForMoney * 20,
                                CloudApplicationDocumentImage = new CloudApplicationDocumentImage()
                                {
                                    //DocumentBytes = System.IO.File.ReadAllBytes(model.DocumentPhysicalFilePath + model.DocumentFileName),
                                    CloudApplicationDocumentBytes = cadm.CloudApplicationDocument,
                                    CloudApplicationDocumentImageStatus = _repository.FindStatusByName("LIVE"),
                                },
                                CloudApplicationDocumentPhysicalFilePath = cadm.CloudApplicationDocumentPhysicalFilePath,
                                CloudApplicationDocumentReleaseDate = cadm.CloudApplicationDocumentReleaseDate,
                                CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE"),
                                CloudApplicationDocumentTitle = cadm.CloudApplicationDocumentTitle,
                                CloudApplicationDocumentType = _repository.FindCloudApplicationDocumentTypeByName(cadm.CloudApplicationDocumentType.CloudApplicationDocumentTypeName),
                                CloudApplicationDocumentURL = cadm.CloudApplicationDocumentURL,
                                UniqueRowID = cadm.RowID,
                            });
                        }
                        else
                        {
                            //must be edited
                            CloudApplicationDocument cad = ca.CloudApplicationDocuments.Find(x => x.CloudApplicationDocumentID == cadm.CloudApplicationDocumentID);
                            if (cad != null)
                            {
                                //CloudApplication = caurm.CloudApplicationUserReviewEaseOfUse * 20,
                                cad.CloudApplicationDocumentFileName = cadm.CloudApplicationDocumentFileName;
                                cad.CloudApplicationDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(cadm.CloudApplicationDocumentFileFormat);
                                //CloudApplicationDocumentID = caurm.CloudApplicationUserReviewValueForMoney * 20,
                                cad.CloudApplicationDocumentImage = new CloudApplicationDocumentImage()
                                {
                                    //DocumentBytes = System.IO.File.ReadAllBytes(model.DocumentPhysicalFilePath + model.DocumentFileName),
                                    CloudApplicationDocumentBytes = cadm.CloudApplicationDocument,
                                    CloudApplicationDocumentImageStatus = _repository.FindStatusByName("LIVE"),
                                };
                                cad.CloudApplicationDocumentPhysicalFilePath = cadm.CloudApplicationDocumentPhysicalFilePath;
                                cad.CloudApplicationDocumentReleaseDate = cadm.CloudApplicationDocumentReleaseDate;
                                cad.CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE");
                                cad.CloudApplicationDocumentTitle = cadm.CloudApplicationDocumentTitle;
                                cad.CloudApplicationDocumentURL = cadm.CloudApplicationDocumentURL;
                                cad.UniqueRowID = cadm.RowID;
                            }

                        }
                    }
                }
                #endregion

                ca.Title = model.Title; //NOT USED
                ca.TwitterFollowers = model.TwitterFollowers;
                ca.TwitterName = model.TwitterName;
                ca.TwitterURL = model.TwitterURL;

                if (CustomSession.AddMode)
                {
                    ca.Vendor = v;
                }

                #region VIDEO
                if (CustomSession.EditMode)
                {

                    foreach (CloudApplicationVideoModel cavm in model.CloudApplicationVideosContainerModel.CloudApplicationVideos)
                    {
                        CloudApplicationVideo cav = ca.CloudApplicationVideos.Find(x => x.CloudApplicationVideoID == cavm.CloudApplicationVideoID);
                        if (cav != null)
                        {
                            cav.CloudApplicationVideoFileFormat = cavm.CloudApplicationVideoFileFormat;
                            cav.CloudApplicationVideoFileName = cavm.CloudApplicationVideoFileName;
                            cav.CloudApplicationVideoURL = cavm.CloudApplicationVideoURL;
                            if (model.CloudApplicationVideosContainerModel.NoVideo)
                            {
                                cav.CloudApplicationVideoStatus = _repository.FindStatusByName("DELETED");
                            }
                            else
                            {
                                cav.CloudApplicationVideoStatus = _repository.FindStatusByName(cavm.CloudApplicationVideoStatus);
                            }
                            cav.IsLocalDomain = cavm.IsLocalDomain;
                            cav.IsYouTubeStream = cavm.IsYouTubeStream;
                        }
                        else
                        {
                            cav = new CloudApplicationVideo()
                            {
                                CloudApplication = ca,
                                CloudApplicationVideoFileFormat = cavm.CloudApplicationVideoFileFormat,
                                CloudApplicationVideoFileName = cavm.CloudApplicationVideoFileName,
                                CloudApplicationVideoStatus = _repository.FindStatusByName("LIVE"),
                                CloudApplicationVideoURL = cavm.CloudApplicationVideoURL,
                                IsLocalDomain = cavm.IsLocalDomain,
                                IsYouTubeStream = cavm.IsYouTubeStream,
                            };
                            ca.CloudApplicationVideos.Add(cav);
                        }
                    }
                }

                //ca.Videos = new List<CloudApplicationVideo>() { new CloudApplicationVideo() 
                //{  
                //    CloudApplicationVideoFileFormat = model.Videos[0].CloudApplicationVideoFileFormat,
                //    CloudApplicationVideoFileName = model.Videos[0].CloudApplicationVideoFileName,
                //    CloudApplicationVideoURL = model.Videos[0].CloudApplicationVideoURL,
                //    IsLive = model.Videos[0].IsLive,
                //    IsLocalDomain = model.Videos[0].IsLocalDomain,
                //    IsYouTubeStream = model.Videos[0].IsYouTubeStream,
                //}
                //};
                #endregion

                #region VIDEO TRAINING
                ca.VideoTrainingSupport = model.VideoTrainingSupport;
                #endregion
                //_repository.Insert<CloudApplication>(ca);
                //_repository.AddCloudApplication(ca);

                #region CURRENCY
                if (CustomSession.EditMode)
                {
                    ca.CloudApplicationCurrency = _repository.FindCurrencyByID(int.Parse(model.Currency.ChosenValue));
                }
                #endregion

                #region TIMEZONE
                if (CustomSession.EditMode)
                {
                    if (model.ApplicationHasActiveSupport)
                    {
                        if (model.Timezone.ChosenValue != null)
                        {
                            ca.SupportHoursTimeZone = _repository.FindTimeZoneByID(int.Parse(model.Timezone.ChosenValue));
                        }
                    }
                    else
                    {
                        ca.SupportHoursTimeZone = null;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                string errorMessage = "Error saving cloud application ID : " + ca.CloudApplicationID.ToString() + ". The error message was : " + ex.Message;
                throw new Exception(errorMessage);
            }
            return ca;
        }
        #endregion

        #region UpdateFeaturesDetails
        private void UpdateFeaturesDetails(List<CloudApplicationFeature> cafList, List<SelectListItemFeature> featureList, CloudApplication ca)
        {
            foreach (SelectListItemFeature slif in featureList.Where(x => x.Selected))
            {
                CloudApplicationFeature caf = cafList.Where(x => x.Feature.FeatureName == slif.Text).FirstOrDefault();
                if (caf == null)
                {
                    ca.CloudApplicationFeatures.Add(new CloudApplicationFeature()
                    {
                        AdditionalInformation = "",
                        CloudApplication = ca,
                        CloudApplicationFeatureStatus = _repository.FindStatusByName("LIVE"),
                        Cost = slif.CostWhole + (decimal)slif.CostFraction / 100,
                        //caf.Count = slif.Count;
                        Count = ModelHelpers.FormatDataStorageValueForBytes(slif),
                        CountSuffix = slif.CountSuffix,
                        Feature = _repository.FindFeatureByName(slif.Text,ca.Category.CategoryID).Feature,
                        IncludeExtraCost = slif.IncludeExtraCost,
                        IsOptional = slif.IsOptional,
                    });
                }
                else
                {
                    caf.AdditionalInformation = "";
                    //caa.CloudApplication = ca;
                    caf.CloudApplicationFeatureStatus = _repository.FindStatusByName("LIVE");
                    caf.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
                    //caf.Count = slif.Count;
                    caf.Count = ModelHelpers.FormatDataStorageValueForBytes(slif);
                    caf.CountSuffix = slif.CountSuffix;
                    //caf.Feature = _repository.findf;
                    caf.IncludeExtraCost = slif.IncludeExtraCost;
                    caf.IsOptional = slif.IsOptional;

                }
            }
            //foreach (CloudApplicationApplication caf in caaList)
            //{
            //    //if (caf.CloudApplication == null)
            //    //{
            //        SelectListItemFeature slif = featureList.Where(x => x.Text == caf.Feature.FeatureName).FirstOrDefault();
            //        if (slif != null)
            //        {
            //            caf.AdditionalInformation = "";
            //            caf.CloudApplication = ca;
            //            caf.CloudApplicationApplicationStatus = _repository.FindStatusByName("LIVE");
            //            caf.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
            //            //caf.Count = slif.Count;
            //            caf.Count = base.FormatDataStorageValueForBytes(slif);
            //            caf.CountSuffix = slif.CountSuffix;
            //            //caf.Feature = _repository.findf;
            //            caf.IncludeExtraCost = slif.IncludeExtraCost;
            //            caf.IsOptional = slif.IsOptional;
            //        }
            //    //}
            //}
        }
        #endregion

        #region UpdateApplicationsDetails
        private void UpdateApplicationsDetails(List<CloudApplicationApplication> caaList, List<SelectListItemFeature> featureList, CloudApplication ca)
        {
            if (featureList != null)
            {
                foreach (SelectListItemFeature slif in featureList.Where(x => x.Selected))
                {
                    CloudApplicationApplication caa = caaList.Where(x => x.Feature.FeatureName == slif.Text).FirstOrDefault();
                    if (caa == null)
                    {
                        ca.CloudApplicationApplications.Add(new CloudApplicationApplication()
                            {
                                AdditionalInformation = "",
                                CloudApplication = ca,
                                CloudApplicationApplicationStatus = _repository.FindStatusByName("LIVE"),
                                Cost = slif.CostWhole + (decimal)slif.CostFraction / 100,
                                //caf.Count = slif.Count;
                                Count = ModelHelpers.FormatDataStorageValueForBytes(slif),
                                CountSuffix = slif.CountSuffix,
                                Feature = _repository.FindApplicationByName(slif.Text,ca.Category.CategoryID,true).Feature,
                                IncludeExtraCost = slif.IncludeExtraCost,
                                IsOptional = slif.IsOptional,
                            });
                    }
                    else
                    {
                        caa.AdditionalInformation = "";
                        //caa.CloudApplication = ca;
                        caa.CloudApplicationApplicationStatus = _repository.FindStatusByName("LIVE");
                        caa.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
                        //caf.Count = slif.Count;
                        caa.Count = ModelHelpers.FormatDataStorageValueForBytes(slif);
                        caa.CountSuffix = slif.CountSuffix;
                        //caf.Feature = _repository.findf;
                        caa.IncludeExtraCost = slif.IncludeExtraCost;
                        caa.IsOptional = slif.IsOptional;

                    }
                }
                //foreach (CloudApplicationApplication caf in caaList)
                //{
                //    //if (caf.CloudApplication == null)
                //    //{
                //        SelectListItemFeature slif = featureList.Where(x => x.Text == caf.Feature.FeatureName).FirstOrDefault();
                //        if (slif != null)
                //        {
                //            caf.AdditionalInformation = "";
                //            caf.CloudApplication = ca;
                //            caf.CloudApplicationApplicationStatus = _repository.FindStatusByName("LIVE");
                //            caf.Cost = slif.CostWhole + (decimal)slif.CostFraction / 100;
                //            //caf.Count = slif.Count;
                //            caf.Count = base.FormatDataStorageValueForBytes(slif);
                //            caf.CountSuffix = slif.CountSuffix;
                //            //caf.Feature = _repository.findf;
                //            caf.IncludeExtraCost = slif.IncludeExtraCost;
                //            caf.IsOptional = slif.IsOptional;
                //        }
                //    //}
                //}
            }
        }
        #endregion

        #region DeleteUnselectedFeatureDetails
        private void DeleteUnselectedFeatureDetails(CloudApplicationFeature caf, List<SelectListItemFeature> slifList)
        {
            SelectListItemFeature slif = slifList.Where(x => x.Text == caf.Feature.FeatureName && x.Selected).FirstOrDefault();
            if (slif == null)
            {
                caf.AdditionalInformation = "TEST";
                caf.CloudApplicationFeatureStatus = _repository.FindStatusByName("DELETED");
            }
        }
        #endregion

        #region DeleteUnselectedApplicationDetails
        private void DeleteUnselectedApplicationDetails(CloudApplicationApplication caa, List<SelectListItemFeature> slifList)
        {
            try
            {
                SelectListItemFeature slif = slifList.Where(x => x.Text == caa.Feature.FeatureName && x.Selected).FirstOrDefault();
                if (slif == null)
                {
                    caa.AdditionalInformation = "TEST";
                    caa.CloudApplicationApplicationStatus = _repository.FindStatusByName("DELETED");
                }
            }
            catch (Exception ex)
            {
                if (caa.Feature == null)
                {
                    throw new Exception("There is a feature ID set to null for cloud application application ID : " + caa.CloudApplicationApplicationID.ToString() + " in cloud application ID: " + caa.CloudApplication.CloudApplicationID.ToString() + "/" + caa.CloudApplication.ServiceName);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion

        #region UploadImage
        //
        // GET: /Home/UploadImage

        public ActionResult UploadImage()
        {
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                string title = "Choose a logo to upload";
                UploadImageModel uim = new UploadImageModel(CustomSession);
                uim.Title = title;
                CloudApplicationInputModel caim = new CloudApplicationInputModel(CustomSession);
                caim.UploadImageModel = uim;

                return PartialView(uim);
                //return PartialView(caim);
            }

            return View();
        }

        //
        // POST: /Home/UploadImage

        [HttpPost]
        public ActionResult UploadImage(UploadImageModel model)
        {
            //Check if all simple data annotations are valid
            if (ModelState.IsValid)
            {
                try
                {
                    Bitmap savedImage = SaveImage(model);

                    int width = savedImage.Width;
                    int height = savedImage.Height;

                    if (width != 170 || height != 50)
                    {
                        Logger.Fatal("Illegal image size : " + width.ToString() + "*" + height.ToString());
                        throw new Exception();
                    }
                    if (savedImage != null)
                    {
                        CloudApplicationInputModel caim = GetInputModelFromViewData(true);

                        MemoryStream ms = new MemoryStream();
                        savedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] stream = new byte[ms.Length];
                        ms.Read(stream, 0, (int)ms.Length);
                        ms.Close();

                        caim.Vendor.VendorLogo = ms.ToArray();

                        if (model.IsFile)
                        {
                            caim.Vendor.VendorLogoFileName = model.LocalFile.FileName;
                        }
                        if (model.IsUrl)
                        {
                            caim.Vendor.VendorLogoFileName = model.Url;
                        }
                        FixUpViewData(caim);

                        CloudApplication ca = GetModelFromViewData(model.CloudApplicationID);
                        ca.Vendor.VendorLogo.Logo = caim.Vendor.VendorLogo;
                        if (model.IsFile)
                        {
                            ca.Vendor.VendorLogoFileName = model.LocalFile.FileName;
                        }
                        if (model.IsUrl)
                        {
                            ca.Vendor.VendorLogoFileName = model.Url;
                        }
                        _repository.Update<Vendor>("-1", ca.Vendor);
                        _repository.Update<VendorLogo>("-1", ca.Vendor.VendorLogo);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            if (Request.IsAjaxRequest())
            {
                return View(model);
            }
            else
            {
                CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                return View("RegisterApplication", caim);
            }
        }
        #endregion

        #region SaveImage
        private Bitmap SaveImage(UploadImageModel model)
        {
            Bitmap savedImage = null;
            //Prepare the needed variables
            Bitmap original = null;
            var name = "newimagefile";
            var errorField = string.Empty;

            try
            {
                if (model.IsUrl)
                {
                    errorField = "Url";
                    name = GetUrlFileName(model.Url);
                    original = GetImageFromUrl(model.Url);
                }
                else if (model.IsFlickr)
                {
                    errorField = "Flickr";
                    name = GetUrlFileName(model.Flickr);
                    original = GetImageFromUrl(model.Flickr);
                }
                else if (model.LocalFile != null) // model.IsFile
                {
                    errorField = "File";
                    name = Path.GetFileNameWithoutExtension(model.LocalFile.FileName);
                    original = Bitmap.FromStream(model.LocalFile.InputStream) as Bitmap;
                }

                //If we had success so far
                if (original != null)
                {
                    Logger.Debug("Attempting to create image for cloud application : " + model.CloudApplicationID.ToString());
                    var img = CreateImage(original, model.X, model.Y, model.Width, model.Height);
                    Logger.Debug("Image created for cloud application : " + model.CloudApplicationID.ToString());

                    //Demo purposes only - save image in the file system
                    Logger.Debug("Attempting to save a copy of image for cloud application : " + model.CloudApplicationID.ToString());
                    var fn = Server.MapPath("~/Images/Uploaded/" + name + ".png");
                    img.Save(fn, System.Drawing.Imaging.ImageFormat.Png);
                    Logger.Debug("Image saved for cloud application : " + model.CloudApplicationID.ToString());

                    //Redirect to index
                    //return RedirectToAction("Index");

                    savedImage = img;
                }
                else //Otherwise we add an error and return to the (previous) view with the model data
                {
                    ModelState.AddModelError(errorField, "Your upload did not seem valid. Please try again using only correct images!");
                }
            }
            catch (Exception e)
            {
                Logger.Fatal("Could not create image for cloud application : " + model.CloudApplicationID.ToString() + ". The error message was : " + e.Message);
            }
            return savedImage;
        }
        #endregion

        #region GetUrlFileName
        /// <summary>
        /// Gets the filename that is placed under a certain URL.
        /// </summary>
        /// <param name="url">The URL which should be investigated for a file name.</param>
        /// <returns>The file name.</returns>
        string GetUrlFileName(string url)
        {
            var parts = url.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var last = parts[parts.Length - 1];
            return Path.GetFileNameWithoutExtension(last);
        }
        #endregion

        #region GetImageFromUrl
        /// <summary>
        /// Gets an image from the specified URL.
        /// </summary>
        /// <param name="url">The URL containing an image.</param>
        /// <returns>The image as a bitmap.</returns>
        Bitmap GetImageFromUrl(string url)
        {
            var buffer = 1024;
            Bitmap image = null;

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                return image;

            using (var ms = new MemoryStream())
            {
                var req = WebRequest.Create(url);

                using (var resp = req.GetResponse())
                {
                    using (var stream = resp.GetResponseStream())
                    {
                        var bytes = new byte[buffer];
                        var n = 0;

                        while ((n = stream.Read(bytes, 0, buffer)) != 0)
                            ms.Write(bytes, 0, n);
                    }
                }

                image = Bitmap.FromStream(ms) as Bitmap;
            }

            return image;
        }
        #endregion

        #region CreateImage
        /// <summary>
        /// Creates a small image out of a larger image.
        /// </summary>
        /// <param name="original">The original image which should be cropped (will remain untouched).</param>
        /// <param name="x">The value where to start on the x axis.</param>
        /// <param name="y">The value where to start on the y axis.</param>
        /// <param name="width">The width of the final image.</param>
        /// <param name="height">The height of the final image.</param>
        /// <returns>The cropped image.</returns>
        Bitmap CreateImage(Bitmap original, int x, int y, int width, int height)
        {
            var img = new Bitmap(width, height);

            using (var g = Graphics.FromImage(img))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, new Rectangle(0, 0, width, height), x, y, width, height, GraphicsUnit.Pixel);
            }

            return img;
        }

        #endregion

        #region UploadImageModal
        //
        // GET: /Home/UploadImageModal

        public ActionResult UploadImageModal()
        {
            return View();
        }


        #endregion

        #region UploadProductReview
        //
        // GET: /Home/UploadProductReview

        public ActionResult UploadProductReview()
        {
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                string title = "Choose a product review to upload";
                UploadImageModel uim = new UploadImageModel(CustomSession);
                uim.Title = title;
                CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                caim = AddNewCloudApplicationProductReview(caim);

                caim.UploadImageModel = uim;
                return PartialView(uim);
                //return PartialView(caim);
            }

            return View();
        }

        //
        // POST: /Home/UploadImage

        [HttpPost]
        //public ActionResult UploadProductReview(CloudApplicationProductReviewModel model)
        public ActionResult UploadProductReview(CloudApplicationInputModelNoValidation viewDataProductReviews, CloudApplicationProductReviewModel viewDataProductReview, string rowUploadID)
        {
            if (Request.IsAjaxRequest())
            {

                CloudApplicationProductReviewModel caprm = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(x => x.RowID.ToString() == rowUploadID).FirstOrDefault();
                if (caprm != null)
                {
                    //userReviewModels.Remove(caurm);
                    caprm = viewDataProductReview;
                    Logger.Debug("Found Product Review in ViewData");
                }
                else
                {
                    Logger.Debug("Could not find Product Review in ViewData");
                }
                //Check if all simple data annotations are valid
                //model.CloudApplicationProductReviewURLDocumentFormat = model.CloudApplicationProductReviewURLDocumentFormats.ChosenValue;
                if (ModelState.IsValid)
                {
                    //CloudApplicationInputModel caim = new CloudApplicationInputModel(CustomSession);
                    //caim.Reviews = new List<CloudApplicationReviewModel>();
                    //storedModel.Reviews.Add(model);
                    //FixUpViewData(caim);
                    //CloudApplication ca = GetModelFromViewData(model.CloudApplicationID);
                    if (!caprm.Persisted)
                    {
                        #region ADD PRODUCT REVIEW TO CONTEXT
                        caprm.AddMode = true;
                        caprm.Persisted = true;
                        caprm.IsLive = true;
                        caprm.CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(ModelHelpers.GetDocumentFileFormatShort(caprm.CloudApplicationProductReviewURLDocumentFormats.ChosenValue)).CloudApplicationDocumentFormatShortName;
                        CloudApplicationProductReviewModel updateProductReview = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Find(x => x.RowID.ToString() == rowUploadID);
                        viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Remove(updateProductReview);
                        viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Add(caprm);
                        //viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.ForEach(x => InsertIndustryModel(x));

                        AddNewCloudApplicationProductReview(viewDataProductReviews);
                        //MarkProductReviewAsAdded(model);
                        //if (ca.CloudApplicationProductReviews == null)
                        //{
                        //    ca.CloudApplicationProductReviews = new List<CloudApplicationProductReview>();
                        //}

                        //ca.CloudApplicationProductReviews.Add(new CloudApplicationProductReview()
                        //{
                        //    CloudApplication = ca,
                        //    CloudApplicationProductReviewDate = model.CloudApplicationProductReviewDate,
                        //    CloudApplicationProductReviewHeadline = model.CloudApplicationProductReviewHeadline,
                        //    CloudApplicationProductReviewPhysicalFileName = "",
                        //    CloudApplicationProductReviewPublisherName = model.CloudApplicationProductReviewPublisherName,
                        //    CloudApplicationProductReviewText = model.CloudApplicationProductReviewText,
                        //    CloudApplicationProductReviewURL = model.CloudApplicationProductReviewURL,
                        //    CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(model.CloudApplicationProductReviewURLDocumentFormat),
                        //    IsDocument = (model.CloudApplicationProductReviewURLDocumentFormat == "DOC" || model.CloudApplicationProductReviewURLDocumentFormat == "PDF"),
                        //    CloudApplicationProductReviewStatus = _repository.FindStatusByName(model.CloudApplicationProductReviewStatus),
                        //    IsBrokenLink = model.IsBrokenLink,
                        //    UniqueRowID = model.RowID,
                        //}
                        //);
                        #endregion
                    }
                    else
                    {
                        #region UPDATE PRODUCT REVIEW TO CONTEXT
                        //CloudApplicationProductReview capr = ca.CloudApplicationProductReviews.Where(x => x.UniqueRowID == model.RowID).FirstOrDefault();
                        //capr.CloudApplicationProductReviewDate = model.CloudApplicationProductReviewDate;
                        //capr.CloudApplicationProductReviewHeadline = model.CloudApplicationProductReviewHeadline;
                        //capr.CloudApplicationProductReviewPhysicalFileName = "";
                        //capr.CloudApplicationProductReviewPublisherName = model.CloudApplicationProductReviewPublisherName;
                        //capr.CloudApplicationProductReviewText = model.CloudApplicationProductReviewText;
                        //capr.CloudApplicationProductReviewURL = model.CloudApplicationProductReviewURL;
                        //capr.CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(model.CloudApplicationProductReviewURLDocumentFormat);
                        //capr.IsDocument = (model.CloudApplicationProductReviewURLDocumentFormat == "DOC" || model.CloudApplicationProductReviewURLDocumentFormat == "PDF");
                        //capr.CloudApplicationProductReviewStatus = _repository.FindStatusByName("LIVE");
                        //capr.IsBrokenLink = model.IsBrokenLink;
                        //capr.UniqueRowID = model.RowID;
                        caprm.CloudApplicationProductReviewURLDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(ModelHelpers.GetDocumentFileFormatShort(caprm.CloudApplicationProductReviewURLDocumentFormats.ChosenValue)).CloudApplicationDocumentFormatShortName;
                        CloudApplicationProductReviewModel updateProductReview = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Find(x => x.RowID.ToString() == rowUploadID);
                        viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Remove(updateProductReview);
                        viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Add(caprm);
                        //viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.ForEach(x => InsertIndustryModel(x));
                        #endregion
                    }
                    //caim = GetInputModelFromViewData(true);
                    //caim = ConstructCloudApplicationInputModel(ca);
                }
                else
                {
                    var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();
                    var result = ViewData.ModelState.SelectMany(x => x.Value.Errors
                       .Where(error => error.Exception != null)
                       .Select(error => new KeyValuePair<string, Exception>(x.Key, error.Exception)));
                    var allErrors = ModelState.Values.SelectMany(v => v.Errors);


                }
                ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationProductReviewsContainerModel";
                ModelState.Clear();
                return PartialView("ProductReviewsContainer", viewDataProductReviews.CloudApplicationProductReviewsContainerModel);
                //return PartialView("ProductReviewsContainer", caim);
            }
            else
            {
                //ModelState.Clear();
                //return PartialView("UserReviewsContainer", caim);
                return null;
            }
            //ModelState.Clear();
        }
        #endregion

        #region UploadUserReview
        #region UploadUserReview()
        public ActionResult UploadUserReview()
        {
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                string title = "Choose a user review to upload";
                UploadImageModel uim = new UploadImageModel(CustomSession);
                uim.Title = title;
                CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                caim = AddNewCloudApplicationUserReview(caim);

                caim.UploadImageModel = uim;
                return PartialView(uim);
                //return PartialView(caim);
            }

            return View();
        }
        #endregion

        [HttpPost]
        //public ActionResult UploadUserReview(CloudApplicationUserReviewModel model)
        //public ActionResult UploadUserReview(CloudApplicationInputModel viewDataUserReviews, CloudApplicationUserReviewModel viewDataUserReview, int? cloudApplicationUploadID, string rowUploadID)
        public ActionResult UploadUserReview([Bind(Exclude = "ServiceName")]CloudApplicationInputModelNoValidation viewDataUserReviews, CloudApplicationUserReviewModel viewDataUserReview, string rowUploadID)
        {
            //string rowUploadID = "11";
            if (Request.IsAjaxRequest())
            {
                CloudApplicationUserReviewModel caurm = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(x => x.RowID.ToString() == rowUploadID).FirstOrDefault();
                if (caurm != null)
                {
                    //userReviewModels.Remove(caurm);
                    caurm = viewDataUserReview;
                    Logger.Debug("Found User Review in ViewData");
                }
                else
                {
                    Logger.Debug("Could not find User Review in ViewData");
                }

                //CloudApplicationInputModel caim = null;
                //Check if all simple data annotations are valid
                //model.CloudApplicationReviewURLDocumentExtension = model.CloudApplicationReviewURLDocumentExtensions.ChosenValue;
                if (ModelState.IsValid)
                {
                    //CloudApplication ca = GetModelFromViewData(model.CloudApplicationID);
                    if (!caurm.Persisted)
                    {
                        #region ADD USER REVIEW TO CONTEXT
                        //MarkUserReviewAsAdded(caurm);
                        caurm.AddMode = true;
                        caurm.Persisted = true;
                        caurm.IsLive = true;
                        CloudApplicationUserReviewModel updateUserReview = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Find(x => x.RowID.ToString() == rowUploadID);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Remove(updateUserReview);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Add(caurm);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));

                        AddNewCloudApplicationUserReview(viewDataUserReviews);
                        
                        //if (ca.CloudApplicationUserReviews == null)
                        //{
                        //    ca.CloudApplicationUserReviews = new List<CloudApplicationUserReview>();
                        //}

                        //ca.CloudApplicationUserReviews.Add(new CloudApplicationUserReview()
                        //{
                        //    CloudApplication = ca,
                        //    CloudApplicationUserReviewEaseOfUse = model.CloudApplicationUserReviewEaseOfUse * 20,
                        //    CloudApplicationUserReviewFunctionality = model.CloudApplicationUserReviewFunctionality * 20,
                        //    CloudApplicationUserReviewOverallRating = model.CloudApplicationUserReviewOverallRating * 20,
                        //    CloudApplicationUserReviewCompany = model.CloudApplicationUserReviewCompany,
                        //    CloudApplicationUserReviewForename = model.CloudApplicationUserReviewForename,
                        //    CloudApplicationUserReviewSurname = model.CloudApplicationUserReviewSurname,
                        //    CloudApplicationUserReviewTitle = model.CloudApplicationUserReviewTitle,
                        //    CloudApplicationUserReviewText = model.CloudApplicationUserReviewText,
                        //    CloudApplicationUserReviewEmployeeCount = model.ChosenEmployeeCount,
                        //    CloudApplicationUserReviewIndustry = _repository.GetIndustry(model.ChosenIndustryID),
                        //    CloudApplicationUserReviewValueForMoney = model.CloudApplicationUserReviewValueForMoney * 20,
                        //    UniqueRowID = model.RowID,
                        //    CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE"),
                        //    CloudApplicationUserReviewDate = DateTime.Now,
                        //}
                        //);
                        #endregion
                    }
                    else
                    {
                        #region UPDATE USER REVIEW TO CONTEXT
                        //CloudApplicationUserReview caur = ca.CloudApplicationUserReviews.Where(x => x.UniqueRowID == model.RowID).FirstOrDefault();
                        //caur.CloudApplicationUserReviewEaseOfUse = model.CloudApplicationUserReviewEaseOfUse;
                        //caur.CloudApplicationUserReviewFunctionality = model.CloudApplicationUserReviewFunctionality;
                        //caur.CloudApplicationUserReviewOverallRating = model.CloudApplicationUserReviewOverallRating;
                        //caur.CloudApplicationUserReviewCompany = model.CloudApplicationUserReviewCompany;
                        //caur.CloudApplicationUserReviewForename = model.CloudApplicationUserReviewForename;
                        //caur.CloudApplicationUserReviewSurname = model.CloudApplicationUserReviewSurname;
                        //caur.CloudApplicationUserReviewTitle = model.CloudApplicationUserReviewTitle;
                        //caur.CloudApplicationUserReviewText = model.CloudApplicationUserReviewText;
                        //caur.CloudApplicationUserReviewEmployeeCount = model.ChosenEmployeeCount;
                        //caur.CloudApplicationUserReviewIndustry = _repository.GetIndustry(model.ChosenIndustryID);
                        //caur.CloudApplicationUserReviewValueForMoney = model.CloudApplicationUserReviewValueForMoney;
                        CloudApplicationUserReviewModel updateUserReview = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Find(x => x.RowID.ToString() == rowUploadID);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Remove(updateUserReview);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Add(caurm);
                        viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
                        #endregion
                    }
                    //caim = ConstructCloudApplicationInputModel(ca);
                }
                else
                {
                    var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();
                    var result = ViewData.ModelState.SelectMany(x => x.Value.Errors
                       .Where(error => error.Exception != null)
                       .Select(error => new KeyValuePair<string, Exception>(x.Key, error.Exception)));
                    var allErrors = ModelState.Values.SelectMany(v => v.Errors);

                }
                ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationUserReviewsContainerModel";
                ModelState.Clear();
                return PartialView("UserReviewsContainer", viewDataUserReviews.CloudApplicationUserReviewsContainerModel);
                //return PartialView("UserReviewsContainer", caim);
            }
            else
            {
                //ModelState.Clear();
                //return PartialView("UserReviewsContainer", caim);
                return null;
            }
        }
        #endregion

        #region InsertIndustryModel
        private void InsertIndustryModel(CloudApplicationUserReviewModel caurm)
        {
            caurm.Industries = ModelHelpers.GetIndustries(_repository);
            if (caurm.Persisted)
            {
                Industry industry = _repository.GetIndustry(caurm.ChosenIndustryID);
                caurm.ChosenIndustry = new IndustryModel()
                {
                    code = industry.Code,
                    description = industry.Description,
                    IndustryID = industry.IndustryID,
                };
            }
            else
            {
                caurm.ChosenIndustry = new IndustryModel()
                {
                    //code = 0,
                    //description = "",
                    //IndustryID = 0,
                };
            }

        }
        #endregion

        #region InsertEmployeeCount
        private void InsertEmployeeCount(CloudApplicationUserReviewModel caurm)
        {
            caurm.EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository);
        }
        #endregion

        #region InsertVideoExtensionsAndVideoDomainsModel
        private void InsertVideoExtensionsAndVideoDomainsModel(CloudApplicationVideoModel model)
        {
            string defaultVideoExtension = "MP4";
            //model.CloudApplicationVideoFileFormat = x.CloudApplicationVideoFileFormat;
            //model.CloudApplicationVideoFileName = x.CloudApplicationVideoFileName;
            //model.CloudApplicationVideoURL = x.CloudApplicationVideoURL;
            //model.IsLive = x.CloudApplicationVideoStatus.StatusName.ToUpper() == "LIVE";
            //model.IsLocalDomain = x.IsLocalDomain;
            //model.IsYouTubeStream = x.IsYouTubeStream;
            model.CloudApplicationVideoDomains = new SelectListItemCollection()
            {
                ColumnCount = 1,
                CollectionTitle = "Video Domains",
                SelectListItems = ModelHelpers.GetVideoDomains(Logger).SelectListItems,
                MultiSelect = false,
                ChosenValue = model.IsLocalDomain ? "CompareCloudware" : "HTTP",
                OtherNumeric = 1,
            };
            model.CloudApplicationVideoExtensions = new SelectListItemCollection()
            {
                ColumnCount = 1,
                CollectionTitle = "Video Domains",
                SelectListItems = ModelHelpers.GetVideoExtensions(Logger).SelectListItems,
                MultiSelect = false,
                ChosenValue = model.CloudApplicationVideoFileFormat == null ? defaultVideoExtension : model.CloudApplicationVideoFileFormat,
                OtherNumeric = 1,
            };
            //model.ReadyToPlay = true;
            //model.CloudApplicationVideoID = x.CloudApplicationVideoID;
            //model.CloudApplicationVideoStatus = x.CloudApplicationVideoStatus.StatusName;
            model.CustomSession = CustomSession;
        }
        #endregion

        #region InsertDocumentsModel
        private void InsertDocumentsModel(CloudApplicationDocumentModel model)
        {
            if (model.CloudApplicationDocumentTypes == null)
            {
                model.CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes();
                model.CloudApplicationDocumentTypes.ChosenValue = model.CloudApplicationDocumentTypes.SelectListItems.Where(x => x.Text == model.CloudApplicationDocumentType.CloudApplicationDocumentTypeName).FirstOrDefault().Text;
            }
            //model.Persisted = true;
            CloudApplicationDocumentType cloudApplicationDocumentType = _repository.FindCloudApplicationDocumentTypeByName(model.CloudApplicationDocumentTypes.ChosenValue);
            //CloudApplicationDocumentType cloudApplicationDocumentType = _repository.FindCloudApplicationDocumentTypeByName(model.CloudApplicationDocumentType.CloudApplicationDocumentTypeName);
            model.CloudApplicationDocumentType = new CloudApplicationDocumentTypeModel()
            {
                CloudApplicationDocumentTypeID = cloudApplicationDocumentType.CloudApplicationDocumentTypeID,
                CloudApplicationDocumentTypeName = cloudApplicationDocumentType.CloudApplicationDocumentTypeName,
            };
            //model.CloudApplicationDocumentFileFormats = this.ConstructDocumentFileFormats("URL Link");
            //model.CloudApplicationDocumentFileName = model.CloudApplicationDocumentFileName;
            //model.CloudApplicationDocumentPhysicalFilePath = model.CloudApplicationDocumentPhysicalFilePath;
            //model.CloudApplicationDocumentTitle = model.CloudApplicationDocumentTitle;
            //model.CloudApplicationDocumentURL = model.CloudApplicationDocumentURL;
            //model.RowID = model.RowID;
            //model.CloudApplicationDocument = model.CloudApplicationDocumentImage.CloudApplicationDocumentBytes;
            //model.IsLive = model.CloudApplicationDocumentStatus.StatusName.ToUpper() == "LIVE";
            //model.CloudApplicationDocumentFileFormat = model.CloudApplicationDocumentFormat.CloudApplicationDocumentFormatShortName;
            //model.CloudApplicationDocumentID = model.CloudApplicationDocumentID;
            //model.CloudApplicationDocumentReleaseDate = model.CloudApplicationDocumentReleaseDate;
            //model.CloudApplicationDocumentPostedFile = GetCloudApplicationDocumentPostedFile(x);
            //model.CloudApplicationID = model.CloudApplicationID;
        }
        #endregion


        #region GetModelFromViewData
        private CloudApplication GetModelFromViewData()
        {
            CloudApplication ca = (CloudApplication)TempData["CloudApplication"];
            if (ca == null)
            {
                if (CustomSession.AddMode)
                {
                    ca = _repository.GetCloudApplicationContextAdded();
                    if (ca == null)
                    {
                        ca = new CloudApplication();
                        _repository.AddCloudApplication(ca);
                    }
                }
                if (CustomSession.EditMode)
                {
                    ca = _repository.GetCloudApplicationContextModified();
                    //throw new Exception("ILLEGAL GETMODELFROMVIEWDATA");
                }
            }
            return ca;

        }
        private CloudApplication GetModelFromViewData(int cloudApplicationID)
        {
            CloudApplication ca = (CloudApplication)TempData["CloudApplication"];
            if (ca == null)
            {
                if (CustomSession.AddMode)
                {
                    ca = _repository.GetCloudApplicationContextAdded();
                    if (ca == null)
                    {
                        ca = new CloudApplication();
                        _repository.AddCloudApplication(ca);
                    }
                }
                if (CustomSession.EditMode)
                {
                    ca = _repository.GetCloudApplicationContextModified();
                    if (ca == null)
                    {
                        ca = _repository.GetCloudApplication(cloudApplicationID,false,false);
                    }
                }
            }
            return ca;
        }

        private CloudApplicationInputModel GetInputModelFromViewData(bool constructFromModelIfNull)
        {
            CloudApplicationInputModel caim = (CloudApplicationInputModel)TempData["CloudApplicationInputModel"];
            if (caim == null)
            {
                //CloudApplication ca = GetModelFromViewData();
                caim = new CloudApplicationInputModel(CustomSession);
                if (constructFromModelIfNull)
                {
                    CloudApplication ca = GetModelFromViewData();
                    caim = ConstructCloudApplicationInputModel(ca);
                }
            }
            FixUpViewData(caim);
            return caim;
        }

        private bool RefreshInputModelFromContextData()
        {
            bool retVal = true;
            try
            {
                CloudApplicationInputModel caim = new CloudApplicationInputModel(CustomSession);
                CloudApplication ca = GetModelFromViewData();
                caim = ConstructCloudApplicationInputModel(ca);
                FixUpViewData(caim);
            }
            catch (Exception e)
            {
                retVal = false;
            }
            return retVal;
        }

        #endregion

        #region FixUpViewData
        private void FixUpViewData(CloudApplicationInputModel model)
        {
            if (model.CustomSession == null)
            {
                int x = 0;
            }
            TempData["CloudApplicationInputModel"] = model;
            //_repository.AddCloudApplication(ConstructCloudApplicationFromCloudApplicationInputModel(model));
        }
        #endregion

        #region ClearViewData
        private void ClearViewData()
        {
            TempData.Clear();
        }
        #endregion

        #region LinkIsValid
        [HttpPost]
        public bool LinkIsValid(string url)
        {
            bool retVal = true;

            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            HttpWebResponse myHttpWebResponse;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                HttpStatusCode statusCode = myHttpWebResponse.StatusCode;
            }
            catch (WebException we)
            {
                retVal = false;
                //Logger.Error("BROKEN REVIEW LINK", we);
                //cam.Reviews.Remove(carm);
            }
            return retVal;
        }
        #endregion

        #region AddNewCloudApplicationProductReview
        public CloudApplicationInputModel AddNewCloudApplicationProductReview(CloudApplicationInputModel model)
        {
            if (model.CloudApplicationProductReviewsContainerModel == null)
            {
                model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews = new List<CloudApplicationProductReviewModel>();
            }

            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Add(new CloudApplicationProductReviewModel()
            {
                CloudApplicationProductReviewHeadline = "Review Headline",
                CloudApplicationProductReviewDate = DateTime.Now,
                CloudApplicationProductReviewPublisherName = "Publisher Name",
                CloudApplicationProductReviewText = "Text about the application",
                CloudApplicationProductReviewURL = "Review URL",
                //CloudApplicationReviewURLDocumentExtension = x.CloudApplicationReviewURLDocumentExtension,
                IsBrokenLink = true,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = true,
                CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats(),
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationProductReviewStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.ChosenValue = "URL";
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormat = model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.ChosenValue;
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.OtherNumeric = 1;

            FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }
        #endregion

        #region AddNewCloudApplicationProductReview
        public CloudApplicationInputModelNoValidation AddNewCloudApplicationProductReview(CloudApplicationInputModelNoValidation model)
        {
            if (model.CloudApplicationProductReviewsContainerModel == null)
            {
                model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews = new List<CloudApplicationProductReviewModel>();
            }

            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Add(new CloudApplicationProductReviewModel()
            {
                CloudApplicationProductReviewHeadline = "Review Headline",
                CloudApplicationProductReviewDate = DateTime.Now,
                CloudApplicationProductReviewPublisherName = "Publisher Name",
                CloudApplicationProductReviewText = "Text about the application",
                CloudApplicationProductReviewURL = "Review URL",
                //CloudApplicationReviewURLDocumentExtension = x.CloudApplicationReviewURLDocumentExtension,
                IsBrokenLink = true,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = false,
                CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats(),
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationProductReviewStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.ChosenValue = "URL";
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormat = model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.ChosenValue;
            model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews[model.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Count - 1].CloudApplicationProductReviewURLDocumentFormats.OtherNumeric = 1;

            //FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }
        #endregion

        #region AddNewCloudApplicationUserReview
        public CloudApplicationInputModel AddNewCloudApplicationUserReview(CloudApplicationInputModel model)
        {
            if (model.CloudApplicationUserReviewsContainerModel == null)
            {
                //model.CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
                model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
            }

            //model.CloudApplicationUserReviews.Add(new CloudApplicationUserReviewModel()
            model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Add(new CloudApplicationUserReviewModel()
            {
                //ChosenEmployeeCount = 0,
                //ChosenIndustry = null,
                //ChosenIndustryID = 0,
                //CloudApplicationEaseOfUse = 0,
                //CloudApplicationFunctionality = 0,
                //CloudApplicationOverallRating = 0,
                //CloudApplicationRatingEmployeeCount = 0,
                CloudApplicationUserReviewCompany = "Company",
                CloudApplicationUserReviewForename = "Forename",
                CloudApplicationUserReviewSurname = "Surname",
                CloudApplicationUserReviewTitle = "Title",
                CloudApplicationUserReviewText = "Text about the review",
                CloudApplicationUserReviewValueForMoney = 0,
                EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository),
                Industries = ModelHelpers.GetIndustries(_repository),
                //IndustryID = 0,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = true,
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            //model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtensions.ChosenValue = "URL";
            //model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtension = model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtensions.ChosenValue;

            FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }
        #endregion

        #region AddNewCloudApplicationUserReview
        public CloudApplicationInputModelNoValidation AddNewCloudApplicationUserReview(CloudApplicationInputModelNoValidation model)
        {
            if (model.CloudApplicationUserReviewsContainerModel == null)
            {
                //model.CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
                model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
            }

            //model.CloudApplicationUserReviews.Add(new CloudApplicationUserReviewModel()
            model.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Add(new CloudApplicationUserReviewModel()
            {
                //ChosenEmployeeCount = 0,
                ChosenIndustry = new IndustryModel()
                {
                    code = 0,
                    description = "",
                    IndustryID = 0,
                },
                ChosenIndustryID = 0,
                //CloudApplicationEaseOfUse = 0,
                //CloudApplicationFunctionality = 0,
                //CloudApplicationOverallRating = 0,
                //CloudApplicationRatingEmployeeCount = 0,
                CloudApplicationUserReviewCompany = "Company",
                CloudApplicationUserReviewForename = "Forename",
                CloudApplicationUserReviewSurname = "Surname",
                CloudApplicationUserReviewTitle = "Title",
                CloudApplicationUserReviewText = "Text about the review",
                CloudApplicationUserReviewValueForMoney = 0,
                EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository),
                Industries = ModelHelpers.GetIndustries(_repository),
                //IndustryID = 0,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = true,
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationUserReviewStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            //model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtensions.ChosenValue = "URL";
            //model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtension = model.Reviews[model.Reviews.Count - 1].CloudApplicationReviewURLDocumentExtensions.ChosenValue;

            //FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }
        #endregion

        #region AddNewCloudApplicationDocument
        public CloudApplicationInputModel AddNewCloudApplicationDocument(CloudApplicationInputModel model)
        {
            if (model.CloudApplicationDocumentsContainerModel == null)
            {
                model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments = new List<CloudApplicationDocumentModel>();
            }

            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Add(new CloudApplicationDocumentModel()
            {
                //ChosenEmployeeCount = 0,
                //ChosenIndustry = null,
                //ChosenIndustryID = 0,
                //CloudApplicationEaseOfUse = 0,
                //CloudApplicationFunctionality = 0,
                //CloudApplicationOverallRating = 0,
                //CloudApplicationRatingEmployeeCount = 0,
                //DocumentType = "PDF",
                CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes(),
                CloudApplicationDocumentFileFormats = ModelHelpers.ConstructDocumentFileFormats("URL Link"),
                CloudApplicationDocumentFileName = "Filename",
                CloudApplicationDocumentPhysicalFilePath = "Path",
                CloudApplicationDocumentTitle = "Title",
                CloudApplicationDocumentURL = "URL",
                //IndustryID = 0,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = true,
                //Document = new byte[],
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentFileFormats.ChosenValue = "PDF";
            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentTypes.ChosenValue = "WHITE";
            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentFileFormats.OtherNumeric = 1;
            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentTypes.OtherNumeric = 1;

            //FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }

        public CloudApplicationInputModelNoValidation AddNewCloudApplicationDocument(CloudApplicationInputModelNoValidation model)
        {
            if (model.CloudApplicationDocumentsContainerModel == null)
            {
                model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments = new List<CloudApplicationDocumentModel>();
            }

            model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Add(new CloudApplicationDocumentModel()
            {
                //ChosenEmployeeCount = 0,
                //ChosenIndustry = null,
                //ChosenIndustryID = 0,
                //CloudApplicationEaseOfUse = 0,
                //CloudApplicationFunctionality = 0,
                //CloudApplicationOverallRating = 0,
                //CloudApplicationRatingEmployeeCount = 0,
                //DocumentType = "PDF",
                CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes(),
                CloudApplicationDocumentFileFormats = ModelHelpers.ConstructDocumentFileFormats("URL Link"),
                CloudApplicationDocumentFileName = "Filename",
                CloudApplicationDocumentPhysicalFilePath = "Path",
                CloudApplicationDocumentTitle = "Title",
                CloudApplicationDocumentURL = "URL",
                //IndustryID = 0,
                Persisted = false,
                RowID = Guid.NewGuid(),
                AddMode = true,
                //Document = new byte[],
                IsLive = false,
                CloudApplicationID = model.CloudApplicationID,
                CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE").StatusName,
            });
            //model.CloudApplicationDocuments[model.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentFileFormats.ChosenValue = "PDF";
            //model.CloudApplicationDocuments[model.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentTypes.ChosenValue = "WHITE";
            //model.CloudApplicationDocuments[model.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentFileFormats.OtherNumeric = 1;
            //model.CloudApplicationDocuments[model.CloudApplicationDocuments.Count - 1].CloudApplicationDocumentTypes.OtherNumeric = 1;

            //FixUpViewData(model);
            //GetInputModelFromViewData(true);
            return model;
        }
        
        #endregion

        #region MarkProductReviewAsAdded
        private bool MarkProductReviewAsAdded(CloudApplicationProductReviewModel model)
        {
            try
            {
                model.AddMode = false;
                model.Persisted = true;
                model.IsLive = true;
                //CloudApplicationInputModel caim = GetInputModelFromViewData(false);
                //caim.CloudApplicationProductReviews.Find(x => x.AddMode).AddMode = false;
                //caim.CloudApplicationProductReviews.Find(x => !x.Persisted).Persisted = true;
                //FixUpViewData(caim);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region MarkUserReviewAsAdded
        private bool MarkUserReviewAsAdded(CloudApplicationUserReviewModel model)
        {
            try
            {
                model.AddMode = false;
                model.Persisted = true;
                model.IsLive = true;
                //CloudApplicationInputModel caim = GetInputModelFromViewData(false);
                ////caim.CloudApplicationUserReviews.Find(x => x.AddMode).AddMode = false;
                ////caim.CloudApplicationUserReviews.Find(x => !x.Persisted).Persisted = true;
                //caim.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Find(x => x.AddMode).AddMode = false;
                //caim.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Find(x => !x.Persisted).Persisted = true;
                //FixUpViewData(caim);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region MarkDocumentAsAdded
        private bool MarkDocumentAsAdded(CloudApplicationDocumentModel model)
        {
            try
            {
                model.AddMode = true;
                model.Persisted = true;
                model.IsLive = true;
                //CloudApplicationInputModel caim = GetInputModelFromViewData(false);
                //caim.CloudApplicationDocuments.Find(x => x.AddMode).AddMode = false;
                //caim.CloudApplicationDocuments.Find(x => !x.CloudApplicationDocumentPersisted).CloudApplicationDocumentPersisted = true;
                //FixUpViewData(caim);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region FindProductReview
        [HttpPost]
        //public ActionResult FindProductReview(string rowID)
        public ActionResult FindProductReview(CloudApplicationInputModel viewDataProductReviews, string rowID)
        {
            //var test = GetInputModelFromViewData(true).CloudApplicationProductReviewsContainerModel;
            //CloudApplicationProductReviewModel caprm = GetInputModelFromViewData(true).CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            CloudApplicationProductReviewModel caprm = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            
            viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.ForEach(x => x.CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats());
            caprm.CloudApplicationProductReviewURLDocumentFormats.ChosenValue = _repository.FindCloudApplicationDocumentFormatByShortName(caprm.CloudApplicationProductReviewURLDocumentFormat).CloudApplicationDocumentFormatURLHeaderName;
            //viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
            //viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));
            
            return PartialView("UploadProductReview", caprm);
        }
        #endregion

        #region FindUserReview
        [HttpPost]
        //public ActionResult FindUserReview(string rowID)
        public ActionResult FindUserReview(CloudApplicationInputModel viewDataUserReviews, string rowID)
        {
            //var test = GetInputModelFromViewData(true).CloudApplicationUserReviewsContainerModel;
            //CloudApplicationUserReviewModel caurm = GetInputModelFromViewData(true).CloudApplicationUserReviews.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            //CloudApplicationUserReviewModel caurm = GetInputModelFromViewData(true).CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            CloudApplicationUserReviewModel caurm = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
            viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));

            return PartialView("UploadUserReview", caurm);
        }
        #endregion

        #region DeleteUserReview
        [HttpPost]
        public ActionResult DeleteUserReview(CloudApplicationInputModel viewDataUserReviews, int? cloudApplicationDeleteID, string rowDeleteID)
        {
            Logger.Debug("DeleteUserReview - Getting Row ID : " + rowDeleteID);

            CloudApplicationUserReviewModel caurm = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(x => x.RowID.ToString() == rowDeleteID).Where(x => x.IsLive).FirstOrDefault();
            if (caurm != null)
            {
                //userReviewModels.Remove(caurm);
                caurm.IsLive = false;
                Logger.Debug("Found User Review in ViewData");
            }
            else
            {
                Logger.Debug("Could not find User Review in ViewData");
            }
            viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));

            ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationUserReviewsContainerModel";
            ModelState.Clear();
            return PartialView("UserReviewsContainer", viewDataUserReviews.CloudApplicationUserReviewsContainerModel);

        }
        #endregion

        #region DeleteProductReview
        [HttpPost]
        public ActionResult DeleteProductReview(CloudApplicationInputModel viewDataProductReviews, int? cloudApplicationDeleteID, string rowDeleteID)
        {
            Logger.Debug("DeleteUserReview - Getting Row ID : " + rowDeleteID);

            //List<CloudApplicationProductReviewModel> productReviewModels = GetInputModelFromViewData(true).CloudApplicationProductReviews;
            CloudApplicationProductReviewModel caprm = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(x => x.RowID.ToString() == rowDeleteID).Where(x => x.IsLive).FirstOrDefault();
            if (caprm != null)
            {
                caprm.IsLive = false;
                //productReviewModels.Remove(caprm);
                Logger.Debug("Found Product Review in ViewData");
            }
            else
            {
                Logger.Debug("Could not find Product Review in ViewData");
            }

            ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationProductReviewsContainerModel";
            ModelState.Clear();
            return PartialView("ProductReviewsContainer", viewDataProductReviews.CloudApplicationProductReviewsContainerModel);

        }
        #endregion

        #region DeleteDocument
        [HttpPost]
        public ActionResult DeleteDocument(CloudApplicationInputModel viewDataDocuments, int? cloudApplicationDeleteID, string rowDeleteID)
        {
            Logger.Debug("DeleteUserReview - Getting Row ID : " + rowDeleteID);

            //CloudApplicationDocumentModel cadm = GetInputModelFromViewData(true).CloudApplicationDocuments.Where(x => x.RowID.ToString() == rowDeleteID).FirstOrDefault();
            CloudApplicationDocumentModel cadm = viewDataDocuments.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(x => x.RowID.ToString() == rowDeleteID).Where(x => x.IsLive).FirstOrDefault();
            if (cadm != null)
            {
                cadm.IsLive = false;
                //documentModels.Remove(dm);
                Logger.Debug("Found Document in ViewData");
            }
            else
            {
                Logger.Debug("Could not find Document in ViewData");
            }

            ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationDocumentsContainerModel";
            ModelState.Clear();
            return PartialView("DocumentsContainer", viewDataDocuments.CloudApplicationDocumentsContainerModel);


        }
        #endregion

        #region FindDocument
        [HttpPost]
        //public ActionResult FindDocument(string rowID)
        public ActionResult FindDocument(CloudApplicationInputModel viewDataDocuments, string rowID)
        {
            //var test = GetInputModelFromViewData(true).CloudApplicationDocumentsContainerModel;
            //CloudApplicationDocumentModel tdm = GetInputModelFromViewData(true).CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            CloudApplicationDocumentModel cadm = viewDataDocuments.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(x => x.RowID.ToString() == rowID).FirstOrDefault();
            //viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
            //viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));
            cadm.CloudApplicationDocumentFileFormats = ModelHelpers.ConstructDocumentFileFormats();
            cadm.CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes();

            cadm.CloudApplicationDocumentFileFormats.ChosenValue = _repository.FindCloudApplicationDocumentFormatByShortName(cadm.CloudApplicationDocumentFileFormat).CloudApplicationDocumentFormatURLHeaderName;
            cadm.CloudApplicationDocumentTypes.ChosenValue = _repository.FindCloudApplicationDocumentTypeByName(cadm.CloudApplicationDocumentType.CloudApplicationDocumentTypeName).CloudApplicationDocumentTypeName;

            return PartialView("UploadDocument", cadm);
        }
        #endregion

        #region RefreshUploadProductReview
        //public ActionResult RefreshUploadProductReview()
        public ActionResult RefreshUploadProductReview([Bind(Exclude = "ServiceName")]CloudApplicationInputModelNoValidation viewDataProductReviews)
        {
            //CloudApplicationProductReviewModel carm = GetInputModelFromViewData(true).CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.Where(x => !x.Persisted).FirstOrDefault();
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.ForEach(x => x.CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats());
            //viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.ForEach(x => InsertEmployeeCount(x));
            CloudApplicationProductReviewModel caprm = viewDataProductReviews.CloudApplicationProductReviewsContainerModel.CloudApplicationProductReviews.LastOrDefault();

            if (Request.IsAjaxRequest())
            {
                return PartialView("UploadProductReview",caprm);
                //return PartialView(caim);
            }

            return View();
        }
        #endregion

        #region RefreshUploadUserReview
        //public ActionResult RefreshUploadUserReview()
        public ActionResult RefreshUploadUserReview([Bind(Exclude = "ServiceName")]CloudApplicationInputModelNoValidation viewDataUserReviews, CloudApplicationUserReviewModel viewDataUserReview, string rowUploadID)
        {
            //CloudApplicationUserReviewModel carm = GetInputModelFromViewData(true).CloudApplicationUserReviews.Where(x => !x.Persisted).FirstOrDefault();
            //CloudApplicationUserReviewModel carm = GetInputModelFromViewData(true).CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.Where(x => !x.Persisted).FirstOrDefault();
            viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
            viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));
            CloudApplicationUserReviewModel carm = viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.LastOrDefault();
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                return PartialView("UploadUserReview", carm);
                //return PartialView(caim);
            }

            return View();
        }
        #endregion

        #region RefreshUploadDocument
        //public ActionResult RefreshUploadDocument()
        public ActionResult RefreshUploadDocument([Bind(Exclude = "ServiceName")]CloudApplicationInputModelNoValidation viewDataDocuments, CloudApplicationDocumentModel viewDataDocument, string rowUploadID)
        {
            //CloudApplicationDocumentModel tdm = GetInputModelFromViewData(true).CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(x => !x.Persisted).FirstOrDefault();
            //viewDataUserReviews.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));
            CloudApplicationDocumentModel cadm = viewDataDocuments.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.LastOrDefault();
            //viewDataDocument.CloudApplicationDocumentFileFormats.SelectListItems = ConstructDocumentFileFormats().SelectListItems;
            cadm.CloudApplicationDocumentFileFormats = ModelHelpers.ConstructDocumentFileFormats();
            cadm.CloudApplicationDocumentTypes = ModelHelpers.ConstructDocumentTypes();


            //model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[0].CloudApplicationDocumentFileFormats.SelectListItems = this.ConstructDocumentFileFormats().SelectListItems;
            //model.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[0].CloudApplicationDocumentTypes.SelectListItems = this.ConstructDocumentTypes().SelectListItems;

            
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                return PartialView("UploadDocument", cadm);
                //return PartialView(caim);
            }

            return View();
        }
        #endregion

        #region RefreshFeatures
        [HttpPost]
        public ActionResult RefreshFeatures(int chosenCategory, int cloudApplicationID)
        {
            SelectListItemCollectionFeatures slic = new SelectListItemCollectionFeatures();

            slic.ColumnCount = 1;
            slic.CollectionTitle = "Features";
            slic.SelectListItems = this.GetFeaturesForChosenCategory(chosenCategory).Select(x => new SelectListItemFeature()
            {
                Selected = false,
                Text = x.Feature.FeatureName,
                Value = x.Feature.FeatureID.ToString(),

                CostWhole = (int)System.Math.Truncate(x.Cost),
                CostFraction = (int)(x.Cost - System.Math.Truncate(x.Cost)),
                Count = (int)x.Count,
                CountSuffix = x.CountSuffix,
                //Include = x.Include,
                IncludeExtraCost = false,
                HasCount = x.HasCount,
                OutputDisplayDescriptor = x.OutputDisplayDescriptor,

            }).ToList();
            slic.MultiSelect = true;

            RefreshCloudApplicationFeatures(cloudApplicationID, slic);

            return PartialView("EditorTemplates/CustomCheckBoxListFeatures",slic);
        }
        #endregion

        #region RefreshApplications
        [HttpPost]
        public ActionResult RefreshApplications(int chosenCategory, int cloudApplicationID)
        {
            
            SelectListItemCollectionFeatures slic = new SelectListItemCollectionFeatures();

            slic.ColumnCount = 1;
            slic.CollectionTitle = "Applications";
            slic.SelectListItems = this.GetApplicationsForChosenCategory(chosenCategory).Select(x => new SelectListItemFeature()
            {
                Selected = false,
                Text = x.Feature.FeatureName,
                Value = x.Feature.FeatureID.ToString(),

                CostWhole = (int)System.Math.Truncate(x.Cost),
                CostFraction = (int)(x.Cost - System.Math.Truncate(x.Cost)),
                Count = (int)x.Count,
                CountSuffix = x.CountSuffix,
                //Include = x.Include,
                IncludeExtraCost = false,
                HasCount = x.HasCount,
                OutputDisplayDescriptor = x.OutputDisplayDescriptor,

            }).ToList();
            slic.MultiSelect = true;

            RefreshCloudApplicationApplications(cloudApplicationID, slic);

            return PartialView("EditorTemplates/CustomCheckBoxListFeatures", slic);
        }
        #endregion

        #region PlayVideo
        [HttpPost]
        public ActionResult PlayVideo(CloudApplicationVideoModel cavm )
        {
            cavm.ReadyToPlay = this.CanPlayVideo(cavm);

            //return PartialView("CloudApplicationVideoModel", cavm);
            return EditorFor(cavm);
        }
        #endregion

        #region UploadVideo
        [HttpPost]
        //public ActionResult UploadVideo(CloudApplicationVideoModel model)
        public ActionResult UploadVideo(CloudApplicationInputModelNoValidation viewDataVideos, CloudApplicationVideoModel viewDataVideo)
        {
            //Check if all simple data annotations are valid
            if (ModelState.IsValid)
            {
                //CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                //caim.CloudApplicationVideosContainerModel.CloudApplicationVideos[0] = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0];


                //CloudApplication ca = GetModelFromViewData(model.CloudApplicationID);
                //ca.CloudApplicationVideos[0] = new CloudApplicationVideo()
                //    {
                //        CloudApplicationVideoFileFormat = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoExtensions.ChosenValue,
                //        //CloudApplicationVideoFileName = model.CloudApplicationVideoFileName,
                //        CloudApplicationVideoFileName = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoFile != null ? model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoFile.FileName : null,
                //        //CloudApplicationVideoURL = "http://" + model.CloudApplicationVideoURL,
                //        CloudApplicationVideoURL = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoURL,
                //        IsLocalDomain = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].IsLocalDomain,
                //        IsYouTubeStream = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].IsYouTubeStream,
                //        CloudApplicationVideoStatus = _repository.FindStatusByName("LIVE"),
                //    };

                //ca.CloudApplicationVideos[0].CloudApplicationVideoFileFormat = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoExtensions.ChosenValue;
                ////ca.CloudApplicationVideos[0].CloudApplicationVideoFileName = model.CloudApplicationVideoFileName;
                //ca.CloudApplicationVideos[0].CloudApplicationVideoFileName = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoFile != null ? model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoFile.FileName : null;
                ////ca.CloudApplicationVideos[0].CloudApplicationVideoURL = "http://" + model.CloudApplicationVideoURL;
                //ca.CloudApplicationVideos[0].CloudApplicationVideoURL = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].CloudApplicationVideoURL;
                //ca.CloudApplicationVideos[0].IsLocalDomain = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].IsLocalDomain;
                //ca.CloudApplicationVideos[0].IsYouTubeStream = model.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].IsYouTubeStream;

                //FixUpViewData(caim);
                ////SaveImage(model);
                CloudApplicationVideoModel updateVideo = viewDataVideo;
                updateVideo.CloudApplicationVideoStatus = _repository.FindStatusByName("LIVE").StatusName;
                viewDataVideos.CloudApplicationVideosContainerModel.CloudApplicationVideos.RemoveAll(x => x.CloudApplicationVideoID == viewDataVideo.CloudApplicationVideoID);
                viewDataVideos.CloudApplicationVideosContainerModel.CloudApplicationVideos.Add(updateVideo);
                //viewDataVideos.CloudApplicationVideosContainerModel.CloudApplicationVideos.ForEach(x => InsertIndustryModel(x));

            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();
                var result = ViewData.ModelState.SelectMany(x => x.Value.Errors
                   .Where(error => error.Exception != null)
                   .Select(error => new KeyValuePair<string, Exception>(x.Key, error.Exception)));
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
            }
            viewDataVideos.CloudApplicationVideosContainerModel.CloudApplicationVideos[0].ReadyToPlay = CanPlayVideo(viewDataVideos.CloudApplicationVideosContainerModel.CloudApplicationVideos[0]);
            //return PartialView("VideoContainer", model);


            if (Request.IsAjaxRequest())
            {
                //return null;
                //CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                ViewData.TemplateInfo.HtmlFieldPrefix = "CloudApplicationVideosContainerModel";
                ModelState.Clear();
                return PartialView("VideosContainer", viewDataVideos.CloudApplicationVideosContainerModel);
                //return PartialView("UserReviewsContainer", viewDataUserReviews.CloudApplicationUserReviewsContainerModel);
            }
            else
            {
                CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                return View("RegisterApplication", caim);
            }

            
            //return View(model);
        }
        #endregion

        #region CanPlayVideo
        private bool CanPlayVideo(CloudApplicationVideoModel cavm)
        {
            bool readyToPlay = true;
            //CloudApplicationVideoModel cavm = new CloudApplicationVideoModel();
            //cavm.CloudApplicationVideoExtension
            cavm.CloudApplicationVideoFileFormat = cavm.CloudApplicationVideoExtensions.ChosenValue;
            var cloudApplicationVideoDomain = cavm.CloudApplicationVideoDomains.ChosenValue;
            cavm.CustomSession = CustomSession;

            if (cloudApplicationVideoDomain == "HTTP")
            {
                cavm.IsLocalDomain = false;
                if (cavm.CloudApplicationVideoFileFormat.ToUpperInvariant() == "YOUTUBE")
                {
                    if (!cavm.CloudApplicationVideoURL.ToUpperInvariant().StartsWith("HTTP://"))
                    {
                        //cavm.CloudApplicationVideoURL = "http://" + cavm.CloudApplicationVideoURL;
                        cavm.CloudApplicationVideoURL = cavm.CloudApplicationVideoURL;
                    }
                    cavm.IsYouTubeStream = true;
                }
                if (cavm.CloudApplicationVideoURL == null)
                {
                    readyToPlay = false;
                }
            }
            else
            {
                cavm.IsLocalDomain = true;
                if (cavm.CloudApplicationVideoFile != null)
                {
                    cavm.CloudApplicationVideoFileName = cavm.CloudApplicationVideoFile.FileName;
                }
                else
                {
                    readyToPlay = false;
                }
            }
            return readyToPlay;
        }
        #endregion

        #region HasVideo
        private bool HasVideo()
        {
            return true;
        }
        #endregion

        #region ShowLogo
        public ActionResult ShowLogo(int? cloudApplicationID)
        {
            Vendor v = null;
            if (cloudApplicationID != null)
            {
                //v = GetModelFromViewData((int)cloudApplicationID).Vendor;
                v = _repository.FindVendorByCloudApplicationID((int)cloudApplicationID);
            }
            else
            {
                //Vendor v = _repository.FindVendorByID(vendorID);
                v = GetModelFromViewData().Vendor;
                //return v.VendorLogo != null ? File(v.VendorLogo, "image/jpg") : null;
                //return v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null;
            }
            if (v != null)
            {
                if (v.VendorLogo != null)
                {
                    return v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region AddChildrenToContextForDialogs
        private CloudApplication AddChildrenToContextForDialogs(CloudApplicationInputModel caim)
        {
            CloudApplication ca = GetModelFromViewData(caim.CloudApplicationID);
            if (ca.Vendor == null)
            {
                Vendor v = new Vendor()
                {
                    VendorName = "TEST VENDOR",
                    //VendorLogoFileName = "skype logo.png",
                    //VendorLogo = File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                    //VendorLogoFullURL = "//Images//Logos/Phone//",
                    VendorLogo = new VendorLogo()
                    {
                        //Logo = System.IO.File.ReadAllBytes("J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Logos\\Phone\\skype logo.png"),
                    }
                };
                ca.Vendor = v;
            }

            if (HasVideo())
            {
                if (ca.CloudApplicationVideos == null)
                {
                    CloudApplicationVideo cav = new CloudApplicationVideo()
                    {

                    };
                    ca.CloudApplicationVideos = new List<CloudApplicationVideo>();
                    ca.CloudApplicationVideos.Add(cav);
                }
            }

            if (ca.CloudApplicationProductReviews == null)
            {
                ca.CloudApplicationProductReviews = new List<CloudApplicationProductReview>();
            }

            if (ca.CloudApplicationUserReviews == null)
            {
                ca.CloudApplicationUserReviews = new List<CloudApplicationUserReview>();
            }

            if (ca.CloudApplicationDocuments == null)
            {
                ca.CloudApplicationDocuments = new List<CloudApplicationDocument>();
            }

            return ca;
        }
        #endregion

        #region UploadDocument
        //
        // GET: /Home/UploadDocument

        public ActionResult UploadDocument()
        {
            //Just to distinguish between ajax request (for: modal dialog) and normal request
            if (Request.IsAjaxRequest())
            {
                string title = "Choose a user review to upload";
                UploadImageModel uim = new UploadImageModel(CustomSession);
                uim.Title = title;
                CloudApplicationInputModel caim = GetInputModelFromViewData(true);
                caim = AddNewCloudApplicationUserReview(caim);

                caim.UploadImageModel = uim;
                return PartialView(uim);
                //return PartialView(caim);
            }

            return View();
        }

        //
        // POST: /Home/UploadDocument

        [HttpPost]
        public ActionResult UploadDocument(CloudApplicationDocumentModel model)
        {
            CloudApplicationInputModel caim = null;

            if (Request.IsAjaxRequest())
            {
                return null;
            }
            else
            {
                //model.DocumentType = model.DocumentTypes.ChosenValue;
                model.CloudApplicationDocumentFileFormat = ModelHelpers.GetDocumentFileFormatShort(model.CloudApplicationDocumentFileFormats.ChosenValue);
                model.CloudApplicationDocumentType = new CloudApplicationDocumentTypeModel()
                {
                    CloudApplicationDocumentTypeID = _repository.FindCloudApplicationDocumentTypeByName(model.CloudApplicationDocumentTypes.ChosenValue).CloudApplicationDocumentTypeID,
                    CloudApplicationDocumentTypeName = _repository.FindCloudApplicationDocumentTypeByName(model.CloudApplicationDocumentTypes.ChosenValue).CloudApplicationDocumentTypeName,
                };                 

                //Check if all simple data annotations are valid
                //model.CloudApplicationReviewURLDocumentExtension = model.CloudApplicationReviewURLDocumentExtensions.ChosenValue;
                if (ModelState.IsValid)
                {
                    //CloudApplicationInputModel caim = new CloudApplicationInputModel(CustomSession);
                    //caim.Reviews = new List<CloudApplicationReviewModel>();
                    //storedModel.Reviews.Add(model);
                    //FixUpViewData(caim);
                    caim = CustomSession.SessionVXModel;

                    if (caim.CloudApplicationDocumentsContainerModel == null)
                    {
                        caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments = new List<CloudApplicationDocumentModel>();
                    }


                    if (!model.Persisted)
                    {
                        #region ADD DOCUMENT TO CONEXT
                        CloudApplicationDocumentModel cadm = caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Find(x => x.RowID == model.RowID);
                        if (cadm != null)
                        {
                            model.AddMode = true;
                            model.Persisted = true;
                            model.IsLive = true;
                            //MarkDocumentAsAdded(model);

                            byte[] postedFileBytes = new byte[model.CloudApplicationDocumentPostedFile.InputStream.Length];
                            model.CloudApplicationDocumentPostedFile.InputStream.Read(postedFileBytes, 0, (int)model.CloudApplicationDocumentPostedFile.InputStream.Length);
                            model.CloudApplicationDocument = postedFileBytes;

                            for (int i = 0; i < caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Count; i++ )
                            {
                                if (caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[i].RowID == model.RowID)
                                {
                                    caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments[i] = model;
                                    break;
                                    //cadm = model;
                                }
                            }
                            //caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Add(model);
                            AddNewCloudApplicationDocument(caim);

                            #region DEPRECATED
                            //ca.CloudApplicationDocuments.Add(new CloudApplicationDocument()
                            //{

                            //    CloudApplication = ca,
                            //    CloudApplicationDocumentImage = new CloudApplicationDocumentImage()
                            //    {
                            //        //DocumentBytes = System.IO.File.ReadAllBytes(model.DocumentPhysicalFilePath + model.DocumentFileName),
                            //        CloudApplicationDocumentBytes = model.CloudApplicationDocument,
                            //        CloudApplicationDocumentImageStatus = _repository.FindStatusByName("LIVE"),
                            //    },
                            //    //CloudApplicationDocumentFileName = model.CloudApplicationDocumentFileName,
                            //    CloudApplicationDocumentFileName = model.CloudApplicationDocumentPostedFile.FileName,
                            //    CloudApplicationDocumentPhysicalFilePath = model.CloudApplicationDocumentPhysicalFilePath,
                            //    CloudApplicationDocumentTitle = model.CloudApplicationDocumentTitle,
                            //    CloudApplicationDocumentReleaseDate = model.CloudApplicationDocumentReleaseDate,
                            //    CloudApplicationDocumentType = _repository.FindCloudApplicationDocumentTypeByName(model.CloudApplicationDocumentTypes.ChosenValue),

                            //    CloudApplicationDocumentURL = model.CloudApplicationDocumentURL,
                            //    UniqueRowID = model.RowID,
                            //    CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE"),
                            //    CloudApplicationDocumentFormat = _repository.FindCloudApplicationDocumentFormatByShortName(model.CloudApplicationDocumentFileFormat),
                            //}
                            //);
                            #endregion
                        }
                        #endregion
                    }
                    else
                    {
                        #region UPDATE DOCUMENT TO CONTEXT
                        CloudApplicationDocumentModel cadm = caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.Where(x => x.RowID == model.RowID).FirstOrDefault();
                        cadm.CloudApplicationDocumentFileName = model.CloudApplicationDocumentFileName;
                        cadm.CloudApplicationDocumentFileFormat = _repository.FindCloudApplicationDocumentFormatByShortName(model.CloudApplicationDocumentFileFormat).CloudApplicationDocumentFormatShortName;

                        if (model.CloudApplicationDocumentPostedFile != null)
                        {
                            byte[] postedFileBytes = new byte[model.CloudApplicationDocumentPostedFile.InputStream.Length];
                            model.CloudApplicationDocumentPostedFile.InputStream.Read(postedFileBytes, 0, (int)model.CloudApplicationDocumentPostedFile.InputStream.Length);
                            //model.CloudApplicationDocument = postedFileBytes;
                            cadm.CloudApplicationDocumentImage = postedFileBytes;
                        }

                        cadm.CloudApplicationDocumentPhysicalFilePath = model.CloudApplicationDocumentPhysicalFilePath;
                        cadm.CloudApplicationDocumentTitle = model.CloudApplicationDocumentTitle;
                        cadm.CloudApplicationDocumentTypes.ChosenValue = model.CloudApplicationDocumentTypes.ChosenValue;
                        cadm.CloudApplicationDocumentURL = model.CloudApplicationDocumentURL;
                        cadm.CloudApplicationDocumentStatus = _repository.FindStatusByName("LIVE").StatusName;
                        //cadm.ThumbnailImage = null;
                        cadm.RowID = model.RowID;
                        cadm.CloudApplicationDocumentReleaseDate = model.CloudApplicationDocumentReleaseDate;
                        
                        #endregion

                    }
                    //caim = GetInputModelFromViewData(true);
                }
                else
                {
                    var errors = ModelState.Select(x => x.Value.Errors.Count > 0).ToList();
                    var result = ViewData.ModelState.SelectMany(x => x.Value.Errors
                       .Where(error => error.Exception != null)
                       .Select(error => new KeyValuePair<string, Exception>(x.Key, error.Exception)));
                    var allErrors = ModelState.Values.SelectMany(v => v.Errors);

                }
                //ModelState.Clear();
                //caim = ConstructCloudApplicationInputModel(ca);
                //CustomSession.SessionVXModel = null;
                CloudApplication ca = GetModelFromViewData(model.CloudApplicationID);
                caim.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertIndustryModel(x));
                caim.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews.ForEach(x => InsertEmployeeCount(x));
                caim.CloudApplicationVideosContainerModel.CloudApplicationVideos.ForEach(x => InsertVideoExtensionsAndVideoDomainsModel(x));
                caim.CloudApplicationDocumentsContainerModel.CloudApplicationDocuments.ForEach(x => InsertDocumentsModel(x));
                ReconstructSelectLists(caim, ca);
                return View("RegisterApplication", caim);
            }
        }
        #endregion

        #region SOCIAL NETWORKING PINGS
        [HttpPost]
        public long PingFacebook(string facebookName)
        {
            //long fans = CheckFacebookName("WebEx");
            Facebook facebook = new Facebook();
            long fans = facebook.GetFacebookFans(facebookName);
            return fans;
        }

        [HttpPost]
        public long PingLinkedIn(string linkedInName)
        {
            //long fans = CheckFacebookName("WebEx");
            LinkedIn linkedIn = new LinkedIn();
            long fans = linkedIn.GetLinkedInFollowerCount(linkedInName);
            return fans;
        }

        [HttpPost]
        public long PingTwitter(string twitterName)
        {
            //long fans = CheckFacebookName("WebEx");
            Twitter twitter = new Twitter();
            long fans = twitter.GetTwitterFollowerCount(twitterName);
            return fans;
        }

        #endregion

        #region GetContiguousSupportDays
        [HttpPost]
        public ActionResult GetContiguousSupportDays(int contiguousDaysSpan)
        {
            CloudApplicationInputModel caim = GetInputModelFromViewData(false);
            var contiguousDays = ModelHelpers.ConstructContiguousDays(contiguousDaysSpan,_repository);
            caim.SupportDays = contiguousDays;

            return PartialView("SupportDays", caim);
        }
        #endregion

        #region RefreshCloudApplicationFeatures
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void RefreshCloudApplicationFeatures(int cloudApplicationID, SelectListItemCollectionFeatures features)
        {
            var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            {
                string featureName = cloudApplicationFeature.Feature.FeatureName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItemFeature cafm = features.SelectListItems.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                if (cafm != null)
                {
                    //cafm.CloudApplicationFeatureID = cloudApplicationFeature.CloudApplicationFeatureID;
                    //cafm.Cost = cloudApplicationFeature.Cost;
                    cafm.CostWhole = (int)System.Math.Truncate(cloudApplicationFeature.Cost);
                    cafm.CostFraction = (int)((cloudApplicationFeature.Cost - System.Math.Truncate(cloudApplicationFeature.Cost))*100);
                    cafm.Count = ModelHelpers.FormatViewModelValueForBytes(cloudApplicationFeature);
                    cafm.IsUnlimited = cloudApplicationFeature.Count == 16384;
                    cafm.CountSuffix = cloudApplicationFeature.CountSuffix;
                    //cafm.Feature = cloudApplicationFeature.Feature;
                    //cafm.HasCount = false;
                    cafm.HasCount = _repository.FindFeatureByName(cloudApplicationFeature.Feature.FeatureName, testCategoryID, true).Feature.HasCount;
                    cafm.HasBooleanAndCount = cloudApplicationFeature.Feature.CanBeBooleanAndDataDriven;
                    cafm.IncludeExtraCost = cloudApplicationFeature.IncludeExtraCost;
                    cafm.IsOptional = cloudApplicationFeature.IsOptional;
                    cafm.OutputDisplayDescriptor = cloudApplicationFeature.Feature.OutputDisplayDescriptor;
                    cafm.Selected = true;

                    if (cafm.HasCount)
                    {
                        //List<GenericValueModel> values = GetComboOptionsFromApplicationFeature(FILTER_FEATURES, featureName, testCategoryID);
                        if (cafm.CountSuffix == "INT")
                        {
                            cafm.Count = cafm.Count;
                        }
                        else if (cafm.CountSuffix == "MB")
                        {
                            cafm.Count = (int)(cloudApplicationFeature.Count * 1000);
                            SelectListItemCollection values = ModelHelpers.ConstructStorageBytes();
                            cafm.CountSuffixes = values;
                        }
                        else if (cafm.CountSuffix == "GB")
                        {
                            cafm.Count = cafm.Count;
                            SelectListItemCollection values = ModelHelpers.ConstructStorageBytes();
                            cafm.CountSuffixes = values;
                        }
                        else
                        {
                            cafm.Count = cafm.Count;
                        }
                    }
                }
                //CloudApplicationFeatureID = x.FeatureID,
                //Cost = 0,
                //Count = 0,
                //CountSuffix = "",
                //Feature = new FeatureModel()
                //{
                //    FeatureID = x.FeatureID,
                //    FeatureName = x.FeatureName,
                //},
                ////Include = false,
                ////IncludeCount = false,
                ////IncludeCountSuffix = false,
                ////IncludeExtraCost = false,
                //IsOptional = false,
                //HasCount = x.HasCount,
                //OutputDisplayDescriptor = x.OutputDisplayDescriptor,


            }
        }
        #endregion

        #region RefreshCloudApplicationApplications
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void RefreshCloudApplicationApplications(int cloudApplicationID, SelectListItemCollectionFeatures features)
        {
            var cloudApplicationApplications = _repository.GetCloudApplicationApplications(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (CloudApplicationApplication cloudApplicationApplication in cloudApplicationApplications)
            {
                string featureName = cloudApplicationApplication.Feature.FeatureName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItemFeature cafm = features.SelectListItems.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationApplication.Feature.FeatureID);
                if (cafm != null)
                {
                    //cafm.CloudApplicationFeatureID = cloudApplicationFeature.CloudApplicationFeatureID;
                    //cafm.Cost = cloudApplicationFeature.Cost;
                    cafm.CostWhole = (int)System.Math.Truncate(cloudApplicationApplication.Cost);
                    cafm.CostFraction = (int)((cloudApplicationApplication.Cost - System.Math.Truncate(cloudApplicationApplication.Cost))*100);
                    //cafm.Count = (int)cloudApplicationApplication.Count;
                    cafm.Count = ModelHelpers.FormatViewModelValueForBytes(cloudApplicationApplication);
                    cafm.CountSuffix = cloudApplicationApplication.CountSuffix;
                    //cafm.Feature = cloudApplicationFeature.Feature;
                    cafm.HasCount = _repository.FindFeatureByName(cloudApplicationApplication.Feature.FeatureName,testCategoryID,true).Feature.HasCount;
                    cafm.HasBooleanAndCount = cloudApplicationApplication.Feature.CanBeBooleanAndDataDriven;
                    cafm.IncludeExtraCost = cloudApplicationApplication.IncludeExtraCost;
                    cafm.IsOptional = cloudApplicationApplication.IsOptional;
                    cafm.OutputDisplayDescriptor = cloudApplicationApplication.Feature.OutputDisplayDescriptor;
                    cafm.Selected = true;

                    if (cafm.HasCount)
                    {
                        //List<GenericValueModel> values = GetComboOptionsFromApplicationFeature(FILTER_FEATURES, featureName, testCategoryID);
                        if (cafm.CountSuffix == "INT")
                        {
                            cafm.Count = cafm.Count;
                        }
                        else if (cafm.CountSuffix == "MB")
                        {
                            cafm.Count = (int)(cloudApplicationApplication.Count * 1000);
                            SelectListItemCollection values = ModelHelpers.ConstructStorageBytes();
                            cafm.CountSuffixes = values;
                        }
                        else if (cafm.CountSuffix == "GB")
                        {
                            cafm.Count = cafm.Count;
                            SelectListItemCollection values = ModelHelpers.ConstructStorageBytes();
                            cafm.CountSuffixes = values;
                        }
                        else
                        {
                            cafm.Count = cafm.Count;
                        }
                    }

                }


            }
        }
        #endregion

        #region HydrateCloudApplicationOperatingSystems
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationOperatingSystems(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, List<Domain.Models.OperatingSystem> operatingSystems)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (Domain.Models.OperatingSystem os in operatingSystems)
            {
                string featureName = os.OperatingSystemName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == os.OperatingSystemID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportTypes
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationSupportTypes(int cloudApplicationID, List<SelectListItemSupportType> cloudApplicationItems, List<SupportType> supportTypes)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (SupportType st in supportTypes)
            {
                string featureName = st.SupportTypeName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == st.SupportTypeID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportDays
        private void HydrateCloudApplicationSupportDays(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, SupportDays supportDays)
        {
            //foreach (SupportDays sd in supportDays)
            if (supportDays != null)
            {
                string featureName = supportDays.SupportDaysName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Value == supportDays.SupportDaysName);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportHours
        private void HydrateCloudApplicationSupportHours(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, SupportHours supportHours)
        {
            //foreach (SupportDays sd in supportDays)
            {
                string featureName = supportHours.SupportHoursName.ToString();
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                if (sli != null)
                {

                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportHoursFrom
        private void HydrateCloudApplicationSupportHoursFrom(int cloudApplicationID, SelectListItemCollection cloudApplicationItems, SupportHours supportHours)
        {
            //foreach (SupportDays sd in supportDays)
            if (supportHours != null)
            {
                //string featureName = supportHours.SupportHoursName.ToString();
                string featureName = supportHours.SupportHoursFrom.ToString();
                if (featureName.ToUpper() == "24 HOURS")
                {
                    //featureName = "00:00";
                    featureName = "0";
                }
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                //SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                SelectListItem sli = cloudApplicationItems.SelectListItems.FirstOrDefault(x => x.Value == featureName);
                if (sli != null)
                {

                    sli.Selected = true;
                    cloudApplicationItems.ChosenValue = featureName;
                }
            }
            else
            {
                cloudApplicationItems.ChosenValue = null;
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportHoursTo
        private void HydrateCloudApplicationSupportHoursTo(int cloudApplicationID, SelectListItemCollection cloudApplicationItems, SupportHours supportHours)
        {
            //foreach (SupportDays sd in supportDays)
            if (supportHours != null)
            {
                //string featureName = supportHours.SupportHoursName.ToString();
                string featureName = supportHours.SupportHoursTo.ToString();
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                if (featureName.ToUpper() == "24 HOURS")
                {
                    //featureName = "24:00";
                    featureName = "0";
                }
                //SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                SelectListItem sli = cloudApplicationItems.SelectListItems.FirstOrDefault(x => x.Value == featureName);
                if (sli != null)
                {
                    sli.Selected = true;
                    cloudApplicationItems.ChosenValue = featureName;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationSupportTerritories
        private void HydrateCloudApplicationSupportTerritories(int cloudApplicationID, SelectListItemCollection cloudApplicationItems, List<SupportTerritory> supportTerritories)
        {
            if (supportTerritories != null)
            {
                foreach (SupportTerritory st in supportTerritories)
                {
                    string featureName = st.SupportTerritoryName.ToString();
                    //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                    SelectListItem sli = cloudApplicationItems.SelectListItems.FirstOrDefault(x => x.Text == featureName);
                    if (sli != null)
                    {
                        //sli.Selected = true;
                        cloudApplicationItems.ChosenValue = sli.Value.ToString();
                    }
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationMobilePlatforms
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationMobilePlatforms(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, List<MobilePlatform> mobilePlatforms)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            if (mobilePlatforms != null)
            {
                foreach (MobilePlatform mp in mobilePlatforms)
                {
                    string featureName = mp.MobilePlatformName;
                    //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                    SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == mp.MobilePlatformID);
                    if (sli != null)
                    {
                        sli.Selected = true;
                    }
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationBrowsers
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationBrowsers(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, List<Browser> browsers)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (Browser b in browsers)
            {
                string featureName = b.BrowserName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == b.BrowserID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationLanguages
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationLanguages(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, List<Language> languages)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (Language l in languages)
            {
                string featureName = l.LanguageName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == l.LanguageID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationLicenceTypeMinimum
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationLicenceTypeMinimum(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, LicenceTypeMinimum licenceType)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            //foreach (LicenceTypeMinimum l in licenceTypes)
            //{
            if (licenceType != null)
            {
                string featureName = licenceType.LicenceTypeMinimumName.ToString();
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == licenceType.LicenceTypeMinimumID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
            //}
        }
        #endregion

        #region HydrateCloudApplicationLicenceTypeMaximum
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationLicenceTypeMaximum(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, LicenceTypeMaximum licenceType)
        {
            try
            {
                if (licenceType != null)
                {
                    //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
                    //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
                    //foreach (LicenceTypeMinimum l in licenceTypes)
                    //{
                    string featureName = licenceType.LicenceTypeMaximumName.ToString();
                    //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                    SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == licenceType.LicenceTypeMaximumID);
                    if (sli != null)
                    {
                        sli.Selected = true;
                    }
                    //}
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error hydrating licence type maximum. The error message was : " + ex.Message);
            }
        }
        #endregion

        #region HydrateCloudApplicationFreeTrialPeriod
        private void HydrateCloudApplicationFreeTrialPeriod(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, FreeTrialPeriod freeTrialPeriod)
        {
            //foreach (SupportDays sd in supportDays)
            {
                string featureName = freeTrialPeriod.FreeTrialPeriodName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                if (sli != null)
                {

                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationMinimumContract
        private void HydrateCloudApplicationMinimumContract(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, MinimumContract minimumContract)
        {
            try
            {
                if (minimumContract != null)
                {
                    //foreach (SupportDays sd in supportDays)
                    {
                        string featureName = minimumContract.MinimumContractName;
                        //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                        SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                        if (sli != null)
                        {

                            sli.Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error hydrating minimum contract. The error message was : " + ex.Message);
            }
        }
        #endregion

        #region HydrateCloudApplicationPaymentFrequency
        private void HydrateCloudApplicationPaymentFrequency(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, PaymentFrequency paymentFrequency)
        {
            if (paymentFrequency != null)
            {
                //foreach (SupportDays sd in supportDays)
                {
                    string featureName = paymentFrequency.PaymentFrequencyName;
                    //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                    SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => x.Text == featureName);
                    if (sli != null)
                    {

                        sli.Selected = true;
                    }
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationPaymentOptions
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationPaymentOptions(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, List<PaymentOption> paymentOptions)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            foreach (PaymentOption po in paymentOptions)
            {
                string featureName = po.PaymentOptionName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == po.PaymentOptionID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
        }
        #endregion

        #region HydrateCloudApplicationCurrency
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationCurrency(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, Currency currency)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            //foreach (PaymentOption po in paymentOptions)
            //{
            if (currency != null)
            {
                string featureName = currency.CurrencyName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == currency.CurrencyID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
            //}
        }
        #endregion

        #region HydrateCloudApplicationTimeZone
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private void HydrateCloudApplicationTimeZone(int cloudApplicationID, List<SelectListItem> cloudApplicationItems, Domain.Models.TimeZone timezone)
        {
            //var cloudApplicationFeatures = _repository.GetCloudApplicationFeatures(cloudApplicationID).ToList();
            //foreach(CloudApplicationFeature cloudApplicationFeature in cloudApplicationFeatures)
            //foreach (PaymentOption po in paymentOptions)
            //{
            if (timezone != null)
            {
                string featureName = timezone.TimeZoneName;
                //CloudApplicationFeatureModel cafm = features.FirstOrDefault(x => int.Parse(x.Value) == cloudApplicationFeature.Feature.FeatureID);
                SelectListItem sli = cloudApplicationItems.FirstOrDefault(x => int.Parse(x.Value) == timezone.TimeZoneID);
                if (sli != null)
                {
                    sli.Selected = true;
                }
            }
            //}
        }
        #endregion

        #region HydrateCloudApplicationUserReviews
        //private void RefreshCloudApplicationFeatures(int cloudApplicationID, List<CloudApplicationFeatureModel> features)
        private List<CloudApplicationUserReviewModel> HydrateCloudApplicationUserReviews(CloudApplicationInputModel inputModel, CloudApplication model)
        {
            //inputModel.CloudApplicationUserReviews = model.CloudApplicationUserReviews
            inputModel.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews = model.CloudApplicationUserReviews
                //.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE")
                .Select(x => new CloudApplicationUserReviewModel()
            {
                Persisted = true,
                ChosenEmployeeCount = x.CloudApplicationUserReviewEmployeeCount,
                ChosenIndustry = new IndustryModel()
                {
                    code = x.CloudApplicationUserReviewIndustry.Code,
                    description = x.CloudApplicationUserReviewIndustry.Description,
                    IndustryID = x.CloudApplicationUserReviewIndustry.IndustryID,
                },
                ChosenIndustryID = x.CloudApplicationUserReviewIndustry.IndustryID,
                CloudApplicationUserReviewEaseOfUse = x.CloudApplicationUserReviewEaseOfUse / 20,
                CloudApplicationUserReviewFunctionality = x.CloudApplicationUserReviewFunctionality / 20,
                CloudApplicationUserReviewOverallRating = x.CloudApplicationUserReviewOverallRating / 20,
                CloudApplicationUserReviewEmployeeCount = x.CloudApplicationUserReviewEmployeeCount,
                CloudApplicationUserReviewCompany = x.CloudApplicationUserReviewCompany,
                CloudApplicationUserReviewForename = x.CloudApplicationUserReviewForename,
                CloudApplicationUserReviewSurname = x.CloudApplicationUserReviewSurname,
                CloudApplicationUserReviewTitle = x.CloudApplicationUserReviewTitle,
                CloudApplicationUserReviewText = x.CloudApplicationUserReviewText,
                CloudApplicationUserReviewValueForMoney = x.CloudApplicationUserReviewValueForMoney / 20,
                EmployeeCount = ModelHelpers.GetNumberOfUsers(_repository),
                Industries = ModelHelpers.GetIndustries(_repository),
                //IndustryID = 0,
                RowID = x.UniqueRowID,
                IsLive = x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE",
                CloudApplicationUserReviewID = x.CloudApplicationUserReviewID,
                CloudApplicationID = model.CloudApplicationID,
            })

            .ToList();
            //return inputModel.CloudApplicationUserReviews;
            return inputModel.CloudApplicationUserReviewsContainerModel.CloudApplicationUserReviews;
        }
        #endregion

        #region SetContainersCollapsed
        private void SetContainersCollapsed(CloudApplicationInputModel model)
        {
        model.SocialNetworkingContainerCollapsed = true;
        model.ProductReviewsContainerCollapsed = true;
        model.UserReviewsContainerCollapsed = true;
        model.DocumentsContainerCollapsed = true;
        model.ApplicationLogoContainerCollapsed = true;
        model.VideoContainerCollapsed = true;
        model.FeaturesContainerCollapsed = true;
        model.ApplicationCostsContainerCollapsed = true;
        model.SupportDaysContainerCollapsed = true;
        model.SupportHoursContainerCollapsed = true;
        model.VendorMainDetailsContainerCollapsed = true;
        model.CategoriesContainerCollapsed = true;
        model.ServiceOverviewContainerCollapsed = true;
        model.OperatingSystemsContainerCollapsed = true;
        model.SupportTypesContainerCollapsed = true;
        model.SupportTerritoriesContainerCollapsed = true;
        model.MobilePlatformsContainerCollapsed = true;
        model.BrowsersContainerCollapsed = true;
        model.LanguagesContainerCollapsed = true;
        model.LicenceTypeMinimumContainerCollapsed = true;
        model.LicenceTypeMaximumContainerCollapsed = true;
        model.VideoTrainingContainerCollapsed = true;
        model.FreeTrialPeriodContainerCollapsed = true;
        model.SetupFeeContainerCollapsed = true;
        model.MinimumContractContainerCollapsed = true;
        model.PaymentFrequencyContainerCollapsed = true;
        model.PaymentOptionsContainerCollapsed = true;
        model.ApplicationCurrencyContainerCollapsed = true;
        model.TimezoneContainerCollapsed = true;
        model.ApplicationsContainerCollapsed = true;
        }
        #endregion

        #region ConstructSelectLists
        private void ConstructSelectLists(CloudApplicationInputModel inputModel)
        {
            inputModel.Categories.SelectListItems = ModelHelpers.GetCategories(this.CustomSession,_repository).Select(x => new SelectListItem()
            {
                Selected = false,
                Text = x.CategoryName,
                Value = x.CategoryID.ToString(),
            }).ToList();

        }
        #endregion

        #region CopyUserReviewsToOtherBrands
        private void CopyUserReviewsToOtherBrands(CloudApplication caMaster)
        {
            IList<CloudApplication> allBrands = _repository.GetCloudApplications(caMaster.Vendor.VendorID, caMaster.Category.CategoryID,true).Where(x => x.CloudApplicationID != caMaster.CloudApplicationID).ToList();
            foreach (CloudApplication ca in allBrands)
            {
                if (ca.CloudApplicationID != caMaster.CloudApplicationID)
                {
                    //ca.CloudApplicationUserReviews.ForEach(x => _repository.Delete<CloudApplicationUserReview>("-1", x));
                    while (ca.CloudApplicationUserReviews.Count > 0)
                    {
                        CloudApplicationUserReview caur = ca.CloudApplicationUserReviews[0];
                        _repository.Delete<CloudApplicationUserReview>("-1", caur);
                        //ca.CloudApplicationUserReviews.Remove(caur);
                    }

                    ca.CloudApplicationUserReviews = caMaster.CloudApplicationUserReviews.Select(x => new CloudApplicationUserReview()
                    {
                        CloudApplication = ca,
                        CloudApplicationUserReviewCompany = x.CloudApplicationUserReviewCompany,
                        CloudApplicationUserReviewDate = x.CloudApplicationUserReviewDate,
                        CloudApplicationUserReviewEaseOfUse = x.CloudApplicationUserReviewEaseOfUse,
                        CloudApplicationUserReviewEmployeeCount = x.CloudApplicationUserReviewEmployeeCount,
                        CloudApplicationUserReviewForename = x.CloudApplicationUserReviewForename,
                        CloudApplicationUserReviewFunctionality = x.CloudApplicationUserReviewFunctionality,
                        CloudApplicationUserReviewID = x.CloudApplicationUserReviewID,
                        CloudApplicationUserReviewIndustry = x.CloudApplicationUserReviewIndustry,
                        CloudApplicationUserReviewOverallRating = x.CloudApplicationUserReviewOverallRating,
                        CloudApplicationUserReviewStatus = x.CloudApplicationUserReviewStatus,
                        CloudApplicationUserReviewSurname = x.CloudApplicationUserReviewSurname,
                        CloudApplicationUserReviewText = x.CloudApplicationUserReviewText,
                        CloudApplicationUserReviewTitle = x.CloudApplicationUserReviewTitle,
                        CloudApplicationUserReviewValueForMoney = x.CloudApplicationUserReviewValueForMoney,
                        UniqueRowID = Guid.NewGuid(),
                    }).ToList();
                    RefreshOverallCloudApplicationUserReviewRatings(ca);
                    //_repository.Update<CloudApplication>("-1", ca);
                    _repository.Update<CloudApplication>("-1", ca, RefreshMode.ClientWins);
                }
            }
        }
        #endregion

        #region CopyProductReviewsToOtherBrands
        private void CopyProductReviewsToOtherBrands(CloudApplication caMaster)
        {
            IList<CloudApplication> allBrands = _repository.GetCloudApplications(caMaster.Vendor.VendorID,caMaster.Category.CategoryID,true).Where(x => x.CloudApplicationID != caMaster.CloudApplicationID).ToList();
            foreach (CloudApplication ca in allBrands)
            {
                if (ca.CloudApplicationID != caMaster.CloudApplicationID)
                {
                    //ca.CloudApplicationProductReviews.ForEach(x => _repository.Delete<CloudApplicationProductReview>("-1", x));
                    while (ca.CloudApplicationProductReviews.Count > 0)
                    {
                        CloudApplicationProductReview capr = ca.CloudApplicationProductReviews[0];
                        _repository.Delete<CloudApplicationProductReview>("-1", capr);
                        //ca.CloudApplicationProductReviews.Remove(capr);
                    }

                    ca.CloudApplicationProductReviews = caMaster.CloudApplicationProductReviews.Select(x => new CloudApplicationProductReview()
                    {
                        CloudApplication = ca,
                        CloudApplicationProductReviewDate = x.CloudApplicationProductReviewDate,
                        CloudApplicationProductReviewHeadline = x.CloudApplicationProductReviewHeadline,
                        CloudApplicationProductReviewPhysicalFileName = x.CloudApplicationProductReviewPhysicalFileName,
                        CloudApplicationProductReviewPublisherName = x.CloudApplicationProductReviewPublisherName,
                        CloudApplicationProductReviewStatus = x.CloudApplicationProductReviewStatus,
                        CloudApplicationProductReviewText = x.CloudApplicationProductReviewText,
                        CloudApplicationProductReviewURL = x.CloudApplicationProductReviewURL,
                        CloudApplicationProductReviewURLDocumentFormat = x.CloudApplicationProductReviewURLDocumentFormat,
                        IsBrokenLink = x.IsBrokenLink,
                        IsDocument = x.IsDocument,
                        UniqueRowID = Guid.NewGuid(),
                    }).ToList();
                    //_repository.Update<CloudApplication>("-1", ca);
                    _repository.Update<CloudApplication>("-1", ca, RefreshMode.ClientWins);
                }
            }
        }
        #endregion

        #region CopyDocumentsToOtherBrands
        private void CopyDocumentsToOtherBrands(CloudApplication caMaster)
        {
            IList<CloudApplication> allBrands = _repository.GetCloudApplications(caMaster.Vendor.VendorID, caMaster.Category.CategoryID,true).Where(x => x.CloudApplicationID != caMaster.CloudApplicationID).ToList();
            foreach (CloudApplication ca in allBrands)
            {
                if (ca.CloudApplicationID != caMaster.CloudApplicationID)
                {
                    //ca.CloudApplicationDocuments.ForEach(x => _repository.Delete<CloudApplicationDocument>("-1", x));
                    while (ca.CloudApplicationDocuments.Count > 0)
                    {
                        CloudApplicationDocument cad = ca.CloudApplicationDocuments[0];
                        _repository.Delete<CloudApplicationDocument>("-1", cad);
                        //ca.CloudApplicationDocuments.Remove(cad);
                    }

                    ca.CloudApplicationDocuments = caMaster.CloudApplicationDocuments.Select(x => new CloudApplicationDocument()
                    {
                        CloudApplication = ca,
                        CloudApplicationDocumentFileName = x.CloudApplicationDocumentFileName,
                        CloudApplicationDocumentFormat = x.CloudApplicationDocumentFormat,
                        CloudApplicationDocumentImage = x.CloudApplicationDocumentImage,
                        CloudApplicationDocumentPhysicalFilePath = x.CloudApplicationDocumentPhysicalFilePath,
                        CloudApplicationDocumentReleaseDate = x.CloudApplicationDocumentReleaseDate,
                        CloudApplicationDocumentStatus = x.CloudApplicationDocumentStatus,
                        CloudApplicationDocumentTitle = x.CloudApplicationDocumentTitle,
                        CloudApplicationDocumentType = x.CloudApplicationDocumentType,
                        CloudApplicationDocumentURL = x.CloudApplicationDocumentURL,
                        ThumbnailImage = x.ThumbnailImage,
                        UniqueRowID = Guid.NewGuid(),
                    }).ToList();
                    //_repository.Update<CloudApplication>("-1", ca);
                    _repository.Update<CloudApplication>("-1", ca, RefreshMode.ClientWins);
                }
            }
        }
        #endregion

        #region CopyLanguagesToOtherBrands
        private void CopyLanguagesToOtherBrands(CloudApplication caMaster)
        {
            IList<CloudApplication> allBrands = _repository.GetCloudApplications(caMaster.Vendor.VendorID,caMaster.Category.CategoryID,true).Where(x => x.CloudApplicationID != caMaster.CloudApplicationID).ToList();
            foreach (CloudApplication ca in allBrands)
            {
                if (ca.CloudApplicationID != caMaster.CloudApplicationID)
                {
                    Logger.Info("Copying " + caMaster.Languages.Count().ToString() + " languages from " + caMaster.ServiceName + " to " + ca.ServiceName + " ( " + caMaster.Languages.Where(x => x.LanguageStatus.StatusName.ToUpper()=="LIVE").Count().ToString() + " ) LIVE" );
                    //for (int i = 0; i < ca.Languages.Count; i++)
                    //foreach (Language l in ca.Languages)
                    while (ca.Languages.Count > 0)
                    {
                        //_repository.Delete<Language>("-1", l);
                        Language l = ca.Languages[0];
                        ca.Languages.Remove(l);
                    }
                    Logger.Info("Deleted existing languages from " + ca.ServiceName + ". Application now contains " + ca.Languages.Count.ToString() + " languages");
                    foreach (Language l in caMaster.Languages)
                    {
                        ca.Languages.Add(l);
                    }
                    Logger.Info("Added existing languages to " + ca.ServiceName + ". Application now contains " + ca.Languages.Count.ToString() + " languages");
                    //ca.Languages = caMaster.Languages;
                    //_repository.Update<CloudApplication>("-1", ca);
                    try
                    {
                        Logger.Info("Attempting to update languages from " + caMaster.ServiceName + " to " + ca.ServiceName);
                        _repository.Update<CloudApplication>("-1", ca, RefreshMode.ClientWins);
                    }
                    catch (Exception e)
                    {
                        Logger.Fatal("Could not update languages from " + caMaster.ServiceName + " to " + ca.ServiceName + ". The error was : " + e.Message);

                    }
                }
            }
        }
        #endregion

        #region SaveSerializedFormToSession
        [HttpPost]
        public ActionResult SaveSerializedFormToSession(CloudApplicationInputModel model)
        {
            CustomSession.SessionVXModel = model;
            return null;
        }
        #endregion

        #region RefreshOverallCloudApplicationUserReviewRatings
        private void RefreshOverallCloudApplicationUserReviewRatings(CloudApplication ca)
        {
            if (ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Count() > 0)
            {
                ca.AverageOverallRating = (decimal)ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Sum(x => x.CloudApplicationUserReviewOverallRating) / ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Count();
                ca.AverageEaseOfUse = (decimal)ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Sum(x => x.CloudApplicationUserReviewEaseOfUse) / ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Count();
                ca.AverageValueForMoney = (decimal)ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Sum(x => x.CloudApplicationUserReviewValueForMoney) / ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Count();
                ca.AverageFunctionality = (decimal)ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Sum(x => x.CloudApplicationUserReviewFunctionality) / ca.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus.StatusName.ToUpper() == "LIVE").Count();
            }
            else
            {
                ca.AverageOverallRating = 0;
                ca.AverageEaseOfUse = 0;
                ca.AverageValueForMoney = 0;
                ca.AverageFunctionality = 0;
            }
        }
        #endregion
    }
}

