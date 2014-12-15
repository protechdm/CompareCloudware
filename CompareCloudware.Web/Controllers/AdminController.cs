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
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Controllers
{
    public class AdminController : BaseController
    {
        const string SAMPLE_EMAIL = "protechdm@yahoo.com";
        const string SAMPLE_FIRSTNAME = "Glyn";

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

        const int CATEGORY_ID_PHONE = 1;
        const int CATEGORY_ID_CRM = 2;
        const int CATEGORY_ID_WEB_CONFERENCING = 3;
        const int CATEGORY_ID_EMAIL = 4;
        const int CATEGORY_ID_OFFICE = 5;
        const int CATEGORY_ID_STORAGE_AND_BACKUP = 6;
        const int CATEGORY_ID_PROJECT_MANAGEMENT = 7;
        const int CATEGORY_ID_FINANCIAL = 8;
        const int CATEGORY_ID_SECURITY = 9;

        int SEARCH_RESULTS_PER_PAGE = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPage"]);
        int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_FEATURED = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageFeatured"]);
        int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_NEW = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageNew"]);
        int SEARCH_RESULTS_PER_PAGE_HOME_PAGE_TOP10 = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageHomePageTop10"]);
        int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_FEATURED = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageFeatured"]);
        int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_NEW = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageNew"]);
        int SEARCH_RESULTS_PER_PAGE_CATEGORY_PAGE_TOP10 = int.Parse(ConfigurationManager.AppSettings["SearchResultsPerPageCategoryPageTop10"]);

        int GLOBAL_SEARCH_RESULTS_PER_PAGE = int.Parse(ConfigurationManager.AppSettings["GlobalSearchResultsPerPage"]);

        //bool DUMMY_VX_MODE = Convert.ToBoolean(ConfigurationManager.AppSettings["DummyVXMode"]);

        const string TAB_FEATURED = "TAB_FEATURED";
        const string TAB_NEW = "TAB_NEW";
        const string TAB_TOPTEN = "TAB_TOPTEN";




        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        //public ILogger Logger { get; set; }


        private bool testMode;
        private string homePageURL = null;

        //public HomeController() :base(null) { }

        public AdminController(ICustomSession session, ICompareCloudwareRepository repository, ISiteAnalyticsLogger _SiteAnalyticsLogger)
            :base(session, repository,_SiteAnalyticsLogger)
        {
            CustomSession = session;

            //_repository = repository;
            //ViewBag.CustomSession = session;
            testMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            homePageURL = testMode ? ConfigurationManager.AppSettings["HomePageURLDev"] : ConfigurationManager.AppSettings["HomePageURLLive"];
        }

        #region PrintResult3AsBytes
        public ActionResult PrintResult3AsBytes(int cloudApplicationID, int personID, string pageName, bool? saveCopy)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            try
            {
                Person p = _repository.GetPersonByPersonID(personID);
                CustomSession.Forename = p.Forename;
                CustomSession.Surname = p.Surname;

                int categoryID;
                SearchPageModel model = new SearchPageModel(CustomSession);
                //GetModelFromViewData(model);

                CloudApplicationModel cam = null;
                //CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID, true, true, RefreshMode.StoreWins);
                CloudApplication ca = _repository.GetCloudApplicationAsReadOnly(cloudApplicationID);

                categoryID = ca.Category.CategoryID;

                IList<CloudApplication> alternatives = _repository.GetCloudApplicationsByVendor(ca.Vendor.VendorID, ca.Category.CategoryID, true);

                cam = ConstructCloudApplicationModel(ca, alternatives);

                cam.CloudApplicationSearchResultModel.OutputMarkupForPDF = true;

                model.ContainerModel.ChosenCloudApplicationModel = cam;


                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, cam.CloudApplicationSearchResultModel,_repository);

                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename = CustomSession.Forename;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname = CustomSession.Surname;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees = CustomSession.NumberOfUsers;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress = CustomSession.EMail;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company = CustomSession.Company;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone = CustomSession.Telephone;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CloudApplicationID = cloudApplicationID;

                //FixUpViewData(model);

                //return View("CloudApplicationModel", model);

                //string html = this.RenderRazorViewToString("PrintResult3", model.ContainerModel.ChosenCloudApplicationModel);
                string html = this.RenderRazorViewToString(pageName, model);

                AdditionalOutput ao = new AdditionalOutput();
                ao.OutputFileName = "test.htm";
                ao.PDFEngineType = PDFEngineType.ASPPDF;

                MemoryStream y = PDFGenerator.SendHTMLStringAndReturnPDFStream(html, 1, null, null, true, ao);
                byte[] b = y.ToArray();
                string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");

                if (saveCopy ?? false)
                {
                    Logger.Info("Writing the result HTML to folder:" + serverFilePath);
                    try
                    {
                        System.IO.File.WriteAllText(serverFilePath + "test2.htm", html);
                        Logger.Info("Finished writing the result HTML to folder:" + serverFilePath);
                    }
                    catch (Exception e)
                    {
                        Logger.Fatal("Could not write the result HTML to folder:" + serverFilePath + ". The error message was:" + e.Message);

                    }

                    Logger.Info("Writing the result PDF to folder:" + serverFilePath);
                    try
                    {
                        System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
                        Logger.Info("Finished writing the result PDF to folder:" + serverFilePath);
                    }
                    catch (Exception e)
                    {
                        Logger.Fatal("Could not write the result PDF to folder:" + serverFilePath + ". The error message was:" + e.Message);

                    }
                }

                //return View("PrintResult3");
                //return Content(html);
                return new FileContentResult(b, "text/html");
            }
            catch (Exception e)
            {
                Logger.Fatal(e.Message);
                return null;
            }
        }
        #endregion

        #region PrintResult3AsHTML
        public ActionResult PrintResult3AsHTML(int cloudApplicationID, int personID, string pageName)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            try
            {
                Person p = _repository.GetPersonByPersonID(personID);
                CustomSession.Forename = p.Forename;
                CustomSession.Surname = p.Surname;

                int categoryID;
                SearchPageModel model = new SearchPageModel(CustomSession);
                //GetModelFromViewData(model);

                CloudApplicationModel cam = null;
                CloudApplication ca = _repository.GetCloudApplicationAsReadOnly(cloudApplicationID);

                categoryID = ca.Category.CategoryID;

                IList<CloudApplication> alternatives = _repository.GetCloudApplicationsByVendor(ca.Vendor.VendorID, ca.Category.CategoryID, true);

                cam = ConstructCloudApplicationModel(ca, alternatives);

                cam.CloudApplicationSearchResultModel.OutputMarkupForPDF = true;

                model.ContainerModel.ChosenCloudApplicationModel = cam;


                ModelHelpers.SetSearchResultsColumnHeaders(categoryID, cam.CloudApplicationSearchResultModel,_repository);

                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Forename = CustomSession.Forename;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Surname = CustomSession.Surname;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.NumberOfEmployees = CustomSession.NumberOfUsers;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.EMailAddress = CustomSession.EMail;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Company = CustomSession.Company;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.Telephone = CustomSession.Telephone;
                //model.ContainerModel.ChosenCloudApplicationModel.FreeTrialBuyNow.CloudApplicationID = cloudApplicationID;

                //FixUpViewData(model);
                //return View("CloudApplicationModel", model);

                //string html = this.RenderRazorViewToString("PrintResult3", model.ContainerModel.ChosenCloudApplicationModel);
                string html = this.RenderRazorViewToString(pageName, model);

                //AdditionalOutput ao = new AdditionalOutput();
                //ao.OutputFileName = "test.htm";
                //ao.PDFEngineType = PDFEngineType.ASPPDF;

                //MemoryStream y = SendHTMLStringAndReturnPDFStream(html, 1, null, null, true, ao);
                //byte[] b = y.ToArray();
                //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");

                //Logger.Info("Writing the result HTML to folder:" + serverFilePath);
                //try
                //{
                //    System.IO.File.WriteAllText(serverFilePath + "test2.htm", html);
                //    Logger.Info("Finished writing the result HTML to folder:" + serverFilePath);
                //}
                //catch (Exception e)
                //{
                //    Logger.Fatal("Could not write the result HTML to folder:" + serverFilePath + ". The error message was:" + e.Message);

                //}

                //Logger.Info("Writing the result PDF to folder:" + serverFilePath);
                //try
                //{
                //    System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
                //    Logger.Info("Finished writing the result PDF to folder:" + serverFilePath);
                //}
                //catch (Exception e)
                //{
                //    Logger.Fatal("Could not write the result PDF to folder:" + serverFilePath + ". The error message was:" + e.Message);

                //}

                //return View("PrintResult3");
                return Content(html);
                //return new FileContentResult(b, "text/html");
            }
            catch (Exception e)
            {
                Logger.Fatal(e.Message);
                return null;
            }
        }
        #endregion

        #region HTMLAsBytes
        public ActionResult HTMLAsBytes(string html)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            try
            {

                AdditionalOutput ao = new AdditionalOutput();
                ao.OutputFileName = "test.htm";
                ao.PDFEngineType = PDFEngineType.ASPPDF;

                MemoryStream y = PDFGenerator.SendHTMLStringAndReturnPDFStream(html, 1, null, null, true, ao);
                byte[] b = y.ToArray();
                string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");

                Logger.Info("Writing the result HTML to folder:" + serverFilePath);
                try
                {
                    System.IO.File.WriteAllText(serverFilePath + "test2.htm", html);
                    Logger.Info("Finished writing the result HTML to folder:" + serverFilePath);
                }
                catch (Exception e)
                {
                    Logger.Fatal("Could not write the result HTML to folder:" + serverFilePath + ". The error message was:" + e.Message);

                }

                Logger.Info("Writing the result PDF to folder:" + serverFilePath);
                try
                {
                    System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
                    Logger.Info("Finished writing the result PDF to folder:" + serverFilePath);
                }
                catch (Exception e)
                {
                    Logger.Fatal("Could not write the result PDF to folder:" + serverFilePath + ". The error message was:" + e.Message);

                }

                //return View("PrintResult3");
                //return Content(html);
                return new FileContentResult(b, "text/html");
            }
            catch (Exception e)
            {
                Logger.Fatal(e.Message);
                return null;
            }
        }
        #endregion

        #region ConstructCloudApplicationModel
        public CloudApplicationModel ConstructCloudApplicationModel(CloudApplication ca, IList<CloudApplication> alternatives)
        {
            //string xx = "";
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

            CloudApplicationModel cam = new CloudApplicationModel(CustomSession)
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
            };

            #region CloudApplicationSearchResultModel
            cam.CloudApplicationSearchResultModel = new CloudApplicationSearchResultShopModel(CustomSession)
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
            #region OperatingSystems
            cam.CloudApplicationSearchResultModel.OperatingSystems = ca.OperatingSystems.Select(x => new OperatingSystemModelSearchResults()
            {
                OperatingSystemID = x.OperatingSystemID,
                OperatingSystemName = x.OperatingSystemName,
            }).ToList();

            #endregion

            #region SupportTypes
            cam.CloudApplicationSearchResultModel.SupportTypes = ca.SupportTypes.Select(x => new SupportTypeModel()
            {
                SupportTypeID = x.SupportTypeID,
                SupportTypeName = x.SupportTypeName,
            }).ToList();
            #endregion

            #region SupportDays
            cam.CloudApplicationSearchResultModel.SupportDays = new SupportDaysModel()
            {
                SupportDaysID = ca.SupportDays != null ? ca.SupportDays.SupportDaysID : 0,
                SupportDaysName = ca.SupportDays != null ? ca.SupportDays.SupportDaysName : "",
            };
            #endregion

            #region Languages
            cam.CloudApplicationSearchResultModel.Languages = ca.Languages.Select(x => new LanguageModel()
            {
                LanguageID = x.LanguageID,
                LanguageName = x.LanguageName,
            }).ToList();
            #endregion

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

            #region Applications
            cam.CloudApplicationSearchResultModel.CloudApplicationApplications = ca.CloudApplicationApplications != null ? ca.CloudApplicationApplications.Select(x => new CloudApplicationApplicationModel()
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

            #region Currency
            cam.CloudApplicationSearchResultModel.Currency = ca.CloudApplicationCurrency != null ? new CurrencyModel(CustomSession)
            {
                CurrencyID = ca.CloudApplicationCurrency.CurrencyID,
                CurrencyName = ca.CloudApplicationCurrency.CurrencyName,
                CurrencyShortName = ca.CloudApplicationCurrency.CurrencyShortName,
                CurrencySymbol = ca.CloudApplicationCurrency.CurrencySymbol,
                ExchangeRateSterling = ca.CloudApplicationCurrency.ExchangeRateSterling,
                UseExchangeRateForSorting = useExchangeRateForSorting,
            } : null;
            #endregion

            #endregion

            #region Browsers
            cam.Browsers = ca.Browsers.Select(x => new BrowserModel(CustomSession)
            {
                BrowserColumnNumber = x.BrowserColumnNumber,
                BrowserID = x.BrowserID,
                BrowserName = x.BrowserName,
                BrowserRowNumber = x.BrowserRowNumber,
            }).ToList();
            #endregion

            #region Category
            cam.Category = new CategoryModel(CustomSession)
            {
                CategoryID = ca.Category.CategoryID,
                CategoryName = ca.Category.CategoryName,
            };
            #endregion

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

            #region Applications
            cam.CloudApplicationApplications = ca.CloudApplicationApplications != null ? ca.CloudApplicationApplications.Select(y => new CloudApplicationApplicationModel()
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

            //#region FreeTrialBuyNow
            //cam.FreeTrialBuyNow = new FreeTrialBuyNowModel(CustomSession)
            //{
            //    Forename = CustomSession != null ? CustomSession.Forename : "",
            //    Surname = CustomSession != null ? CustomSession.Surname : "",
            //    EMailAddress = CustomSession != null ? CustomSession.EMail : "",
            //    RequestTypes = this.GetRequestTypes(ca),
            //    FreeTrial = ca.FreeTrialPeriod != null,
            //    CategoryID = ca.Category.CategoryID,
            //};
            //#endregion

            #region FreeTrialPeriod
            cam.FreeTrialPeriod = new FreeTrialPeriodModel()
            {
                FreeTrialPeriodID = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodID : 0,
                FreeTrialPeriodName = ca.FreeTrialPeriod != null ? ca.FreeTrialPeriod.FreeTrialPeriodName : null,
            };
            #endregion

            #region Languages
            cam.Languages = ca.Languages.Select(x => new LanguageModel()
            {
                LanguageID = x.LanguageID,
                LanguageName = x.LanguageName,
            }).ToList();
            #endregion

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
            cam.CloudApplicationUserReviews = ca.CloudApplicationUserReviews.Select(x => new CloudApplicationUserReviewModel(CustomSession)
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
            cam.CloudApplicationProductReviews = ca.CloudApplicationProductReviews.Select(x => new CloudApplicationProductReviewModel(CustomSession)
            {
                CloudApplicationProductReviewDate = x.CloudApplicationProductReviewDate,
                CloudApplicationProductReviewHeadline = x.CloudApplicationProductReviewHeadline,
                CloudApplicationProductReviewID = x.CloudApplicationProductReviewID,
                CloudApplicationProductReviewPublisherName = x.CloudApplicationProductReviewPublisherName,
                CloudApplicationProductReviewText = x.CloudApplicationProductReviewText,
                CloudApplicationProductReviewURL = x.CloudApplicationProductReviewURL,
                CloudApplicationProductReviewURLDocumentFormat = x.CloudApplicationProductReviewURLDocumentFormat.CloudApplicationDocumentFormatShortName,
                CloudApplicationProductReviewURLDocumentFormats = ModelHelpers.ConstructDocumentFileFormats(),
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
            cam.CloudApplicationVideos = ca.CloudApplicationVideos != null ? ca.CloudApplicationVideos.Select(x => new CloudApplicationVideoModel(CustomSession, this.Request)
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
                        cam.CloudApplicationModelAlternatives.Add(capp.ConstructCloudApplicationModelAlternatives(CustomSession));
                        //var d = alternatives.ForEach(x => x.ConstructCloudApplicationModelAlternatives());
                    }
                }
            }
            //cam.FreeTrialBuyNow.Surname = "w";
            //cam.FreeTrialBuyNow.Company = "w";
            //cam.FreeTrialBuyNow.Telephone = "w";

            cam.CloudApplicationUserReviewModel = new CloudApplicationUserReviewModel(CustomSession);
            cam.CloudApplicationUserReviewModel.Industries = ModelHelpers.GetIndustries(_repository);
            cam.CloudApplicationUserReviewModel.EmployeeCount = ModelHelpers.GetNumberOfUsers(true,_repository);

            //cam = CheckForBrokenLinks(cam, true);
            return cam;

        }


        #endregion

        #region RenderRazorViewToString
        //public string RenderRazorViewToString(string viewName, CloudApplicationModel model)
        public string RenderRazorViewToString(string viewName, SearchPageModel model)
        {
            ViewData.Model = model;
            //var html = this.RenderView("about");
            //return html;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                
                return sw.GetStringBuilder().ToString();
            }
        }
        #endregion

       
        #region CloudApplication
        [SessionExpireFilter]
        public ActionResult CloudApplication(int cloudApplicationID)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            //testMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            //homePageURL = testMode ? ConfigurationManager.AppSettings["HomePageURLDev"] : ConfigurationManager.AppSettings["HomePageURLLive"];

            //HttpRequestBase request = new HttpRequestWrapper(System.Web.HttpContext.Current.Request);
            //string returnURL = request.Url.ToString();
            //System.Web.HttpContext.Current.Response.Redirect(homePageURL + "?returnUrl=" + returnURL, true);
            //return null;

            return RedirectToAction("CloudApplication", "Home", new { cloudApplicationID = cloudApplicationID, scripting = true });
        }
        #endregion

        #region CategoryPage
        [SessionExpireFilter]
        public ActionResult CategoryPage(int categoryID, CategoryPageModel model2)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            return RedirectToAction("CategoryPage", "Home", new { categoryID = categoryID });
        }
        #endregion

        #region RedirectShowDocument
        public ActionResult RedirectShowDocument(int documentID)
        {
            var bc = Request.Browser;
            //int x = bc.EcmaScriptVersion.Major;

            CustomSession.DetectedBrowser = bc.Browser;
            CustomSession.DetectedBrowserID = bc.Id;

            return RedirectToAction("RedirectShowDocument", "Home", new { documentID = documentID });
        }
        #endregion

        #region Header
        public virtual ActionResult EMailHeaderModel()
        {
            return PartialView("EMailTemplates/HeaderModel");
        }
        #endregion

        #region Footer
        public virtual ActionResult EMailFooterModel()
        {
            return PartialView("EMailTemplates/FooterModel");
        }
        #endregion

        #region BusinessPartner
        public ActionResult BusinessPartner(int cloudApplicationRequestId)
        {
            var car = _repository.GetCloudApplicationRequest(cloudApplicationRequestId);
            var person = _repository.GetPersonByPersonID(car.PersonID);

            CompareCloudware.Web.Models.EMailTemplateModels.BusinessPartnerModel model = new Models.EMailTemplateModels.BusinessPartnerModel();
            model.Forename = person.Forename;
            model.Surname = person.Surname;
            model.Vendorname = person.Company;
            model.Email = person.EMail;
            //return View("EMailTemplates/BusinessPartner", model);
            return View("EMailTemplates/become-a-BP-auto-respond", model);
            //return PartialView("EMailTemplates/EMailBoilerplate");
        }
        #endregion

        #region StrategicPartner
        public ActionResult StrategicPartner(int cloudApplicationRequestId)
        {
            var car = _repository.GetCloudApplicationRequest(cloudApplicationRequestId);
            var person = _repository.GetPersonByPersonID(car.PersonID);

            CompareCloudware.Web.Models.EMailTemplateModels.StrategicPartnerModel model = new Models.EMailTemplateModels.StrategicPartnerModel();
            model.Forename = person.Forename;
            model.Surname = person.Surname;
            model.Vendorname = person.Company;
            model.Email = person.EMail;
            //return View("EMailTemplates/StrategicPartner", model);
            return View("EMailTemplates/BP-SP_email_auto-respond", model);
            
            //return PartialView("EMailTemplates/EMailBoilerplate");
        }
        #endregion

        #region ReferRewardPartner
        public ActionResult ReferReward(int cloudApplicationRequestId)
        {
            var car = _repository.GetCloudApplicationRequest(cloudApplicationRequestId);
            var person = _repository.GetPersonByPersonID(car.PersonID);

            CompareCloudware.Web.Models.EMailTemplateModels.ReferRewardPartnerModel model = new Models.EMailTemplateModels.ReferRewardPartnerModel();
            model.Forename = person.Forename;
            model.Surname = person.Surname;
            model.Vendorname = person.Company;
            model.Email = person.EMail;
            return View("EMailTemplates/ReferRewardPartner", model);
            //return PartialView("EMailTemplates/EMailBoilerplate");
        }
        #endregion

        #region SendToColleague
        public ActionResult SendToColleague(int cloudApplicationRequestId)
        {
            var car = _repository.GetCloudApplicationRequest(cloudApplicationRequestId);
            var person = _repository.GetPersonByPersonID(car.PersonID);
            var ca = _repository.GetCloudApplicationAsReadOnly(car.CloudApplicationID);
            var colleague = _repository.FindRecommender(person.PersonID);
            string homePageURL = ConfigurationManager.AppSettings["HomePageURLLive"];

            CompareCloudware.Web.Models.EMailTemplateModels.SendToColleagueModel model = new Models.EMailTemplateModels.SendToColleagueModel();
            model.CloudApplicationName = ca.ServiceName;
            model.CloudApplicationURL = homePageURL + _repository.GetShopURL(ca.CloudApplicationID);
            model.ColleagueEmail = person.EMail;
            model.ColleagueForename = person.Forename;
            model.ColleagueSurname = person.Surname;
            model.RecommenderForename = colleague.Introducer.Forename;
            model.RecommenderSurname = colleague.Introducer.Surname;
            model.RecommenderEMail = colleague.Introducer.EMail;
            model.Message = car.RequestData;
            //return View("EMailTemplates/SendToColleague", model);
            return View("EMailTemplates/forward-to-a-colleague", model);
            //return PartialView("EMailTemplates/EMailBoilerplate");
        }
        #endregion

    }

}
