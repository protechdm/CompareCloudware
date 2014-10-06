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
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        public ILogger Logger { get; set; }
        protected readonly ICompareCloudwareRepository _repository;
        protected ICustomSession CustomSession { get; set; }
        protected ISiteAnalyticsLogger _siteAnalyticsLogger;

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

        const string TAB_CLOUDWARE_EXPLAINED = "TAB_CLOUDWARE_EXPLAINED";
        const string TAB_10_REASONS_FOR_USING_CLOUDWARE = "TAB_10_REASONS_FOR_USING_CLOUDWARE";
        const string TAB_WHAT_DOES_MY_BUSINESS_NEED_TO_RUN_CLOUDWARE = "TAB_WHAT_DOES_MY_BUSINESS_NEED_TO_RUN_CLOUDWARE";

        const string TAB_ABOUT_US = "TAB_ABOUT_US";
        const string TAB_MANAGEMENT_TEAM = "TAB_MANAGEMENT_TEAM";
        const string TAB_VISION = "TAB_VISION";
        const string TAB_FAQS = "TAB_FAQS";
        const string TAB_CAREERS = "TAB_CAREERS";
        const string TAB_PRESS = "TAB_PRESS";
        const string TAB_CONTACT_US = "TAB_CONTACT_US";

        public BaseController(ICustomSession session, ICompareCloudwareRepository repository, ISiteAnalyticsLogger _SiteAnalyticsLogger)
        {
            _repository = repository;
            _siteAnalyticsLogger = _SiteAnalyticsLogger;
            //session.ShowSearchTextBox = true;

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            // Log the error that occurred.
               Logger.Fatal(DateTime.Now.ToString() + " - Generic Error occured", filterContext.Exception);
            // Output a nice error page
            if (filterContext.HttpContext.IsCustomErrorEnabled)
            {
                base.OnException(filterContext);
                filterContext.ExceptionHandled = true;

                if(filterContext.Exception.GetType() == typeof(CategoryNotFoundException))
                {
                    View("PageNotFound", new BaseModel() { CustomSession = CustomSession }).ExecuteResult(ControllerContext);
                }
                else if (filterContext.Exception.GetType() == typeof(ShopNotFoundException))
                {
                    View("PageNotFound", new BaseModel() { CustomSession = CustomSession }).ExecuteResult(ControllerContext);
                }
                else
                {
                    View("Error").ExecuteResult(ControllerContext);
                }
            }
        }

        #region Header
        public virtual ActionResult xHeaderModel()
        {
            //string button = fc.GetSubmitButtonName();
            HeaderModel hm = new HeaderModel(null);

            hm.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
            hm.CustomSession = this.CustomSession;
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            return PartialView("HeaderModel", hm);
        }

        //public virtual ActionResult HeaderModel(HeaderModel hm)
        //{
        //    //string button = fc.GetSubmitButtonName();
        //    //HeaderModel h = new HeaderModel();

        //    hm.Categories = ModelHelpers.GetCategories(this.CustomSession, _repository);
        //    hm.CustomSession = this.CustomSession;
        //    //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

        //    return PartialView("HeaderModel", hm);
        //}

        public virtual ActionResult HeaderModel(HeaderModel hm, CustomSession session)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();

            hm.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
            hm.CustomSession = this.CustomSession;
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            return PartialView("HeaderModel", hm);
        }

        public virtual ActionResult Search(HeaderModel hm, FormCollection fc)
        {
            _siteAnalyticsLogger.Log(_repository, ActionType.ClickSearchAutoComplete, null, null, CustomSession.PersonID);

            var cloudApplicationIDKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("chosenID")).ElementAt(0);
            if (fc[cloudApplicationIDKey] == "ILLEGAL")
            {
                var searchTextKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("search")).ElementAt(0);
                string searchText = fc[searchTextKey];
                return RedirectToAction("GlobalSearchResults", new { term = searchText, liveApplicationsOnly = (CustomSession.DummyVXMode == false) });

            }
            else
            {
                int cloudApplicationID = int.Parse(fc[cloudApplicationIDKey]);

                var searchTextKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("search")).ElementAt(0);
                string searchText = fc[searchTextKey];

                if (cloudApplicationID == 0)
                {
                    return RedirectToAction("GlobalSearchResults", new { term = searchText, liveApplicationsOnly = (CustomSession.DummyVXMode == false) });
                }
                else
                {
                    return RedirectToAction("CloudApplication", new { cloudApplicationID = cloudApplicationID });
                }
            }
        }

        [HttpPost]
        public virtual ActionResult HeaderModel(HeaderModel hm, FormCollection fc)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();
            string dummyVXMode = fc["CUSTOMSESSION.DUMMYVXMODE"];
            if (dummyVXMode != null)
            {
                CustomSession.DummyVXMode = dummyVXMode.ToUpper().StartsWith("TRUE");
            }

                //.SingleOrDefault()
            ;

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

                    CustomSession.VisitedViaCategory = false;

                    switch (icon.ElementAt(0).Replace("ICON_", "").Replace(".x", "").Replace(".y", ""))
                    {
                        case "TWITTER": return RedirectToAction("TwitterModel");
                        case "FACEBOOK": return RedirectToAction("FacebookModel");
                        case "LINKEDIN": return RedirectToAction("LinkedInModel");
                        case "GOOGLE": return RedirectToAction("GoogleModel");
                        case "BROADCAST": return RedirectToAction("BroadcastModel");
                        case "SEARCH":
                            
                            _siteAnalyticsLogger.Log(_repository, ActionType.ClickSearchAutoComplete,null,null,CustomSession.PersonID);
            
                            var cloudApplicationIDKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("chosenID")).ElementAt(0);
                            if (fc[cloudApplicationIDKey] == "ILLEGAL")
                            {
                                var searchTextKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("search")).ElementAt(0);
                                string searchText = fc[searchTextKey];
                                return RedirectToAction("GlobalSearchResults", new { term = searchText, liveApplicationsOnly = (CustomSession.DummyVXMode == false) });

                            }
                            else
                            {
                                int cloudApplicationID = int.Parse(fc[cloudApplicationIDKey]);

                                var searchTextKey = fc.Keys.OfType<string>().Where(x => x.StartsWith("search")).ElementAt(0);
                                string searchText = fc[searchTextKey];

                                if (cloudApplicationID == 0)
                                {
                                    return RedirectToAction("GlobalSearchResults", new { term = searchText, liveApplicationsOnly = (CustomSession.DummyVXMode == false) });
                                }
                                else
                                {
                                    return null;
                                    return RedirectToAction("CloudApplication", new { cloudApplicationID = cloudApplicationID });
                                }
                            }
                        //break;
                        case "CLOUDWARE_EXPLAINED": 
                            return RedirectToRoute("cloudware-explained");
                            break;
                    }
                }
                //return RedirectToAction("CategoryPage", new { categoryID = 1 });
                hm.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
                hm.CustomSession = CustomSession;
                return PartialView("HeaderModel", hm);
            }
            else
            {
                var pressedButton = categoryButton.ElementAt(0);
                int chosenCategoryID = int.Parse(pressedButton.Replace("CATEGORY_BUTTON_", "").Replace(".x", "").Replace(".y", ""));

                //hm.Categories = this.GetCategories();
                //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

                ViewBag.VisibleResultsTab = 1;

                //return RedirectToAction("CategoryPage", new { categoryID = chosenCategoryID });
                //return View("CategoryPage", ModelHelpers.ConstructCategoryPage(chosenCategoryID,_siteAnalyticsLogger,this.CustomSession,_repository));//todo
                //return View("CategoryPage", model);
                return null;
            }
        }

        #endregion

        #region Footer
        public virtual ActionResult FooterModel(HeaderModel hm)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();

            hm.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);
            hm.CustomSession = CustomSession;
            //var y = hm.Categories.Where(x => x.CategoryID == 1).FirstOrDefault().CategoryID;

            CloudApplicationRegistrationAndUpdateModel carm = new CloudApplicationRegistrationAndUpdateModel(CustomSession);
            carm.SupportCategories = _repository.GetSupportCategories().Select(x => new SupportCategoryModel()
            {
                SupportCategoryID = x.SupportCategoryID,
                SupportCategoryName = x.SupportCategoryName,
            }
            ).ToList();
            carm.AutoShow = CustomSession.AutoShowRegisterOrUpdate ?? false;
            hm.CloudApplicationRegistrationModel = carm;

            return PartialView("FooterModel", hm);
        }

        [HttpPost]
        public virtual ActionResult FooterModel(HeaderModel hm, FormCollection fc)
        {
            //string button = fc.GetSubmitButtonName();
            //HeaderModel h = new HeaderModel();
            var categoryButton = fc
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("CATEGORY_BUTTON_"))
                //.SingleOrDefault()
            ;

            hm.CustomSession = CustomSession;

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
                hm.Categories = ModelHelpers.GetCategories(this.CustomSession,_repository);

                CloudApplicationRegistrationAndUpdateModel carm = new CloudApplicationRegistrationAndUpdateModel(CustomSession);
                carm.SupportCategories = _repository.GetSupportCategories().Select(x => new SupportCategoryModel()
                {
                    SupportCategoryID = x.SupportCategoryID,
                    SupportCategoryName = x.SupportCategoryName,
                }
                ).ToList();
                hm.CloudApplicationRegistrationModel = carm;

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







        #region AutoComplete
        //[HttpPost]
        //public ActionResult AutoComplete(string searchText)
        public ActionResult AutoComplete(string acRows, string term, bool liveApplicationsOnly)
        {
            Logger.Debug("AutoComplete#1 - " + DateTime.Now.TimeOfDay.ToString());
            string searchText = term;
            bool dummyVXMode = CustomSession.DummyVXMode;
            Logger.Debug("AutoComplete#2 - " + DateTime.Now.TimeOfDay.ToString());

            //bool liveApplicationsOnly = (CustomSession.DummyVXMode = false);

            var results = _repository.GetApplicationsFromTags(searchText,liveApplicationsOnly).ToList();

            Logger.Debug("AutoComplete#3 - " + DateTime.Now.TimeOfDay.ToString());
            var retVal = results.Select(x => new TagModel()
            {
                Category = new CategoryModel()
                {
                    CategoryID = x.Tag != null
                                    //? x.Tag.Category.CategoryID
                                    ? (int)x.TagCategoryID
                                    : x.TagTypeWhenTagTypeIsNull == "CATEGORYNAME" ? -1 : -1,
                    CategoryName = x.Tag != null
                                    //? x.Tag.Category.CategoryName
                                    ? x.TagCategoryName
                                    : x.TagTypeWhenTagTypeIsNull == "CATEGORYNAME" ? x.CloudApplication.Category.CategoryName : "NONE",
                },
                TagID = x.Tag != null ? x.Tag.TagID : -1,
                TagName = x.Tag != null ? x.Tag.TagName : x.TagTypeWhenTagTypeIsNull,
                TagType = new TagTypeModel()
                {
                    TagTypeID = x.Tag != null
                                    //? x.Tag.TagType.TagTypeID
                                    ? x.TagTypeID
                                    : x.TagTypeWhenTagTypeIsNull == "CATEGORYNAME" ? -1 : -1,
                    TagTypeName = x.TagTypeWhenTagTypeIsNull,
                },
                CloudApplicationModel = new CloudApplicationAutoCompleteModel()
                {
                    Category = new CategoryModel()
                    {
                        //CategoryID = x.CloudApplication.Category.CategoryID,
                        CategoryID = x.CloudApplicationCategoryID,
                        //CategoryName = x.CloudApplication.Category.CategoryName,
                        CategoryName = x.CloudApplicationCategoryName,
                    },
                    Vendor = new VendorModel()
                    {
                        VendorID = x.VendorID,
                        VendorName = x.VendorName,
                    },
                    CloudApplicationID = x.CloudApplication.CloudApplicationID,
                    ServiceName = x.CloudApplication.ServiceName ?? "MISSING",
                    Title = x.CloudApplication.Title,
                    //CategoryTag = x.CloudApplication.CloudApplicationCategoryTag.TagName,
                    CategoryTag = x.CloudApplicationCategoryTagName,
                    //ShopTag = x.CloudApplication.CloudApplicationShopTag.TagName,
                    //ShopTag = x.ShopTagName,
                    ShopTag = x.CloudApplicationShopTagName,
                    ShopTagURL = x.CloudApplication.ServiceName.ToLower().Replace(" ", "-") ?? "MISSING",
                }
            })
            .Where(x => !dummyVXMode ? (x.CloudApplicationModel != null && x.CloudApplicationModel.ServiceName != null ? x.CloudApplicationModel.ServiceName.Trim().Length > 0 : false) : true)
            .ToList()
            ;

            #region "ALL ICON"
            Logger.Debug("AutoComplete#4 - " + DateTime.Now.TimeOfDay.ToString());
            var selSearch = new List<AutocompleteRow>();
            selSearch.Add(new AutocompleteRow()
            {

                category = "Search",
                label = "ALL",
                tagModel = new TagModel()
                {
                    Category = new CategoryModel()
                    {
                        CategoryID = -1,
                        CategoryName = "SEARCH",
                        SearchFilterID = -1,
                        Selected = false,
                    },
                    CloudApplicationModel = new CloudApplicationAutoCompleteModel()
                    {
                        CategoryTag = "global",
                        ShopTag = term,
                    },
                    TagID = -1,
                    TagName = "SEARCH",
                    TagType = new TagTypeModel()
                    {
                        TagTypeID = -1,
                        TagTypeName = "SEARCH",
                    }
                },
                value = term,
                vendorID = -1,
            });
            #endregion

            Logger.Debug("AutoComplete#5 - " + DateTime.Now.TimeOfDay.ToString());
            var selVendors = retVal
                    .Where(v => v.TagName.ToUpper() == "VENDOR")
                    .Select(v => new AutocompleteRow
                    {
                        category = "Vendors",
                        label = v.CloudApplicationModel.Vendor != null ? v.CloudApplicationModel.Vendor.VendorName : "MISSING",
                        value = v.CloudApplicationModel.ServiceName.ToString(),
                        tagModel = v,
                        vendorID = v.CloudApplicationModel.Vendor != null ? v.CloudApplicationModel.Vendor.VendorID : 1,


                        labelAsURL = v.CloudApplicationModel.ShopTagURL,
                    
                    
                    })
                //.ToList<AutocompleteRow>()
                    ;

            //var selCategories = retVal
            //    .Where(c => c.TagName.ToUpper() == "CATEGORYNAME")
            //    .Select(c => new AutocompleteRow
            //    {
            //        category = c.Category.CategoryName,
            //        label = c.CloudApplicationModel.ServiceName,
            //        value = c.CloudApplicationModel.ServiceName.ToString(),
            //        tagModel = c,
            //    })
            //    .ToList<AutocompleteRow>();

            Logger.Debug("AutoComplete#6 - " + DateTime.Now.TimeOfDay.ToString());
            var selApplications = retVal
                .Where(a => a.TagName.ToUpper() == "SERVICENAME")
                .Select(a => new AutocompleteRow
                {
                    category = "Applications",
                    label = a.CloudApplicationModel.ServiceName,
                    labelAsURL = a.CloudApplicationModel.ShopTagURL,
                    value = a.CloudApplicationModel.Vendor != null ? a.CloudApplicationModel.Vendor.VendorName : "MISSING",
                    tagModel = a,
                    vendorID = a.CloudApplicationModel.Vendor != null ? a.CloudApplicationModel.Vendor.VendorID : 1,
                })
                //.ToList<AutocompleteRow>()
                ;

            #region TAGS DEPRECATED
            //var selPrimaryTags = retVal
            //    .Where(p => p.TagType.TagTypeName.ToUpper() == "PRIMARY")
            //     //.Where(p => p.TagID > 0)
            //     .Select(p => new AutocompleteRow { 
            //         category = "Primary Tags", 
            //         label = p.CloudApplicationModel.ServiceName, 
            //         value = p.CloudApplicationModel.ServiceName.ToString(),
            //         tagModel = p,
            //     })
            //     //.Take(10)
            //     .ToList<AutocompleteRow>();

            //var selSecondaryTags = retVal
            //    .Where(s => s.TagType.TagTypeName.ToUpper() == "SECONDARY")
            //    //.Where(p => p.TagID > 0)
            //     .Select(s => new AutocompleteRow { 
            //         category = "Secondary Tags", 
            //         label = s.CloudApplicationModel.ServiceName, 
            //         value = s.CloudApplicationModel.ServiceName.ToString(),
            //         tagModel = s,
            //     })
            //    //.Take(10)
            //     .ToList<AutocompleteRow>();

            //var selTertiaryTags = retVal
            //    .Where(t => t.TagType.TagTypeName.ToUpper() == "TERTIARY")
            //    //.Where(p => p.TagID > 0)
            //    .Select(t => new AutocompleteRow { 
            //        category = "Tertiary Tags", 
            //        label = t.CloudApplicationModel.ServiceName, 
            //        value = t.CloudApplicationModel.ServiceName.ToString(),
            //        tagModel = t,
            //    })
            //    //.Take(10)
            //    .ToList<AutocompleteRow>();

            //var selPhraseTags = retVal
            //    .Where(p => p.TagType.TagTypeName.ToUpper() == "PHRASE")
            //    //.Where(p => p.TagID > 0)
            //    .Select(p => new AutocompleteRow { 
            //        category = "Phrase Tags", 
            //        label = p.CloudApplicationModel.ServiceName, 
            //        value = p.CloudApplicationModel.ServiceName.ToString(),
            //        tagModel = p,
            //    })
            //    //.Take(10)
            //    .ToList<AutocompleteRow>();

            //var selVernacularTags = retVal
            //    .Where(v => v.TagType.TagTypeName.ToUpper() == "VERNACULAR")
            //    //.Where(p => p.TagID > 0)
            //    .Select(v => new AutocompleteRow { 
            //        category = "Vernacular Tags", 
            //        label = v.CloudApplicationModel.ServiceName, 
            //        value = v.CloudApplicationModel.ServiceName.ToString(),
            //        tagModel = v,
            //    })
            //    //.Take(10)
            //    .ToList<AutocompleteRow>();
            #endregion

            Logger.Debug("AutoComplete#7 - " + DateTime.Now.TimeOfDay.ToString());
            var selTags = (from tags in retVal
                           where
                                   tags.TagType.TagTypeName.ToUpper() == "PRIMARY" ||
                                   tags.TagType.TagTypeName.ToUpper() == "SECONDARY" ||
                                   tags.TagType.TagTypeName.ToUpper() == "TERTIARY" ||
                                   tags.TagType.TagTypeName.ToUpper() == "PHRASE" ||
                                   tags.TagType.TagTypeName.ToUpper() == "VERNACULAR"
                           select new AutocompleteRow()
                           {
                               category = tags.CloudApplicationModel.Category.CategoryName,
                               label = tags.CloudApplicationModel.ServiceName,
                               value = tags.CloudApplicationModel.Vendor != null ? tags.CloudApplicationModel.Vendor.VendorName : "MISSING",
                               tagModel = tags,
                               vendorID = tags.CloudApplicationModel.Vendor != null ? tags.CloudApplicationModel.Vendor.VendorID : 1,
                           })
                //.Take(10)
                //.ToList().OrderBy(x => x.category)
                            ;

            //selVernacularTags.RemoveAll(x => selPhraseTags.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));
            //selVernacularTags.RemoveAll(x => selCategories.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));

            //selPhraseTags.RemoveAll(x => selTertiaryTags.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));
            //selTertiaryTags.RemoveAll(x => selSecondaryTags.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));
            //selSecondaryTags.RemoveAll(x => selPrimaryTags.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));
            //selPrimaryTags.RemoveAll(x => selApplications.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID));

            //selApplications.RemoveAll(
            //    x =>
            //    selCategories.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID)
            //);

            //selCategories.RemoveAll(
            //    x =>
            //    selVendors.Any(y => y.tagModel.CloudApplicationModel.CloudApplicationID == x.tagModel.CloudApplicationModel.CloudApplicationID)
            //);

            Logger.Debug("AutoComplete#8 - " + DateTime.Now.TimeOfDay.ToString());
            var selSearchList = selSearch.ToList();

            Logger.Debug("AutoComplete#9 - " + DateTime.Now.TimeOfDay.ToString());
            var selVendorsList = selVendors.ToList();

            Logger.Debug("AutoComplete#10 - " + DateTime.Now.TimeOfDay.ToString());
            var selApplicationsList = selApplications.ToList();

            Logger.Debug("AutoComplete#11 - " + DateTime.Now.TimeOfDay.ToString());
            var selTagsList = selTags.ToList();

            Logger.Debug("AutoComplete#12 - " + DateTime.Now.TimeOfDay.ToString());
            var list = selSearch
                .Union(selVendors)
                //.Union(selCategories)
                .Union(selApplications)
                //.Union(selPrimaryTags)
                //.Union(selSecondaryTags)
                //.Union(selTertiaryTags)
                //.Union(selPhraseTags)
                //.Union(selVernacularTags)
                .Union(selTags)
                .ToList<AutocompleteRow>()
                ;

            var list2 = selSearchList
    .Union(selVendorsList)
                //.Union(selCategories)
    .Union(selApplicationsList)
                //.Union(selPrimaryTags)
                //.Union(selSecondaryTags)
                //.Union(selTertiaryTags)
                //.Union(selPhraseTags)
                //.Union(selVernacularTags)
    .Union(selTagsList)
    .ToList<AutocompleteRow>()
    ;

            Logger.Debug("AutoComplete#13 - " + DateTime.Now.TimeOfDay.ToString());
            //AutocompleteRow.SetLabelShortToRows(list);
            AutocompleteRow.SetLabelShortToRows(list2);
            Logger.Debug("AutoComplete#14 - " + DateTime.Now.TimeOfDay.ToString());
            //return Json(list, JsonRequestBehavior.AllowGet);
            return Json(list2, JsonRequestBehavior.AllowGet);

            //TagModel t = new TagModel();
            //return Json(retVal.ToArray(), JsonRequestBehavior.AllowGet);

        }
        #endregion

        #region GetThumbnail
        public ActionResult GetThumbnail(int vendorID, string vendorName)
        {
            //Logger.Debug("Get#1 - " + DateTime.Now.TimeOfDay.ToString());
            //int vendorID = 1;
            Vendor v;
            try
            {
                if (vendorName == "ALL")
                {
                    string filePath = "~/Images/Logos/CCW_All.png";
                    string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath(filePath);
                    FileStream ms = new FileStream(serverFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] stream = new byte[ms.Length];
                    ms.Read(stream, 0, (int)ms.Length);
                    ms.Close();
                    v = new Vendor()
                    {
                        VendorLogo = new VendorLogo()
                        {
                            Logo = stream,
                        },
                    };
                }
                else
                {
                    v = _repository.FindVendorByID(vendorID);
                }
            }
            catch (Exception e)
            {
                v = null;
            }
            //return v != null ? v.VendorLogo != null ? File(v.VendorLogo, "image/jpg") : null : null;
            //return v != null ? v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null : null;
            //Logger.Debug("Get#2 - " + DateTime.Now.TimeOfDay.ToString());
            return v != null ? v.VendorLogo.Logo != null ? File(v.VendorLogo.Logo, "image/jpg") : null : null;
        }
        #endregion







        #region CorporateInformation
        public ActionResult CorporateInformation(int activeTab)
        {
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            ContentTextsModel model = new ContentTextsModel(CustomSession);
            model = ModelHelpers.GetCorporateInformationData(model,_repository);

            //model.AboutUsVisible = true;
            model.ActiveTab = activeTab;

                return View("CorporateInformationPage", model);
            {
                model.AboutUsVisible = false;
                model.ManagementTeamVisible = false;
                model.VisionVisible = false;
                model.FAQsVisible = false;
                model.CareersVisible = false;
                model.PressVisible = false;
                model.ContactUsVisible = false;

                switch (activeTab)
                {
                    case 0:
                        model.AboutUsVisible = true;
                        break;
                    case 1:
                        model.ManagementTeamVisible = true;
                        break;
                    case 2:
                        model.VisionVisible = true;
                        break;
                    case 3:
                        model.FAQsVisible = true;
                        break;
                    case 4:
                        model.CareersVisible = true;
                        break;
                    case 5:
                        model.PressVisible = true;
                        break;
                    case 6:
                        model.ContactUsVisible = true;
                        break;
                    default:
                        model.AboutUsVisible = true;
                        break;

                }
                return View("CorporateInformationPageNoScript", model);
            }
        }
        #endregion



        #region CloudwareExplainedPageNoScript
        public ActionResult CloudwareExplainedPageNoScript(string showPage, bool scripting)
        {
            ContentTextsModel model = new ContentTextsModel(CustomSession);
            model = ModelHelpers.GetCloudwareExplainedData(model,_repository);
            model.CloudwareExplainedVisible = (showPage == TAB_CLOUDWARE_EXPLAINED);
            model.TenReasonsForUsingCloudwareVisible = (showPage == TAB_10_REASONS_FOR_USING_CLOUDWARE);
            model.WhatDoesMyBusinessNeedToRunCloudwareVisible = (showPage == TAB_WHAT_DOES_MY_BUSINESS_NEED_TO_RUN_CLOUDWARE);

            return View("CloudwareExplainedPageNoScript", model);
        }
        #endregion

        #region CorporateInformationPageNoScript
        public ActionResult CorporateInformationPageNoScript(string showPage, bool scripting, string compositeID)
        {
            ContentTextsModel model = new ContentTextsModel(CustomSession);
            model = ModelHelpers.GetCorporateInformationData(model,_repository);
            model.AboutUsVisible = (showPage == TAB_ABOUT_US);
            model.ManagementTeamVisible = (showPage == TAB_MANAGEMENT_TEAM);
            model.VisionVisible = (showPage == TAB_VISION);
            model.FAQsVisible = (showPage == TAB_FAQS);
            model.CareersVisible = (showPage == TAB_CAREERS);
            model.PressVisible = (showPage == TAB_PRESS);
            model.ContactUsVisible = (showPage == TAB_CONTACT_US);

            List<ContentTextModel> pressTabs = model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE").OrderBy(x => x.BodyOrder).ToList();
            List<ContentTextModel> pressTabDates = model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE_DATE").OrderByDescending(x => Convert.ToDateTime(x.ContentTextData)).ToList();
            List<ContentTextModel> pressTabPublishers = model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE_PUBLISHER").ToList();

            string firstPressTabDate = compositeID ?? pressTabDates[0].CompositeID;
            model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE" && x.CompositeID == firstPressTabDate).ForEach(x => x.IsVisible = true);
            model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE" && x.CompositeID != firstPressTabDate).ForEach(x => x.IsVisible = false);

            model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE_DATE" && x.CompositeID == firstPressTabDate).ForEach(x => x.IsVisible = true);
            model.ContentTexts.Where(x => x.ContentTextType.ContentTextTypeName == "PRESS_SECTION_TITLE_DATE" && x.CompositeID != firstPressTabDate).ForEach(x => x.IsVisible = false);

            return View("CorporateInformationPageNoScript", model);
        }
        #endregion




        #region ProviderTermsOfUsePage
        public ActionResult ProviderTermsOfUsePage()
        {
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            TermsAndConditionsModel model = new TermsAndConditionsModel(CustomSession);
            model = ModelHelpers.GetProviderTermsAndConditions(model,_repository);
            return View("TermsAndConditionsPage", model);
        }
        #endregion

        #region UserTermsOfUsePage
        public ActionResult UserTermsOfUsePage()
        {
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            TermsAndConditionsModel model = new TermsAndConditionsModel(CustomSession);
            model = ModelHelpers.GetUserTermsAndConditions(model,_repository);
            return View("TermsAndConditionsPage", model);
        }
        #endregion

        #region PrivacyPolicyPage
        public ActionResult PrivacyPolicyPage()
        {
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            TermsAndConditionsModel model = new TermsAndConditionsModel(CustomSession);
            model = ModelHelpers.GetPrivacyPolicyData(model,_repository);
            return View("TermsAndConditionsPage", model);
        }
        #endregion

        #region CloudwareExplained
        public ActionResult CloudwareExplainedPage()
        {
            //ModelHelpers.SetSessionVariables(Request, CustomSession);
            //ContentTextsModel model = new ContentTextsModel(CustomSession);
            //model = ModelHelpers.GetCloudwareExplainedData(model,_repository);
            //model.CloudwareExplainedVisible = true;
            //return View("CloudwareExplainedOldPage", model);

            try
            {
                CustomSession.VisitedViaCategory = false;
                CustomSession.ShowSearchTextBox = false;
                var model = ModelHelpers.ConstructCloudwareExplainedPageModel(new CloudwareExplainedPageModel(CustomSession, ModelHelpers.ConvertContentPageToContentPageModel(_repository.GetContentPage("CloudwareExplained")))
                , this.CustomSession, _repository, Request);
                return View(model);
            }
            catch (Exception ex)
            {
                Logger.Fatal("CloudwareExplainedPage exception. The exception was :" + ex.Message + ". Stacktrace : " + ex.StackTrace);
                //throw new Exception();
                return null;
            }
            //return View("Index");
        
        
        
        
        }
        #endregion

        #region CloudwareExplainedPartial
        public ActionResult CloudwareExplainedPartial()
        {
            return null;
        }
        #endregion

        #region SiteMapPage
        public ActionResult SiteMapPage()
        {
            ModelHelpers.SetSessionVariables(Request, CustomSession);
            SiteMapModel model = ModelHelpers.GetSiteMapData(this.CustomSession, _repository);
            return View("SiteMapPage", model);

        }
        #endregion




        #region RegisterCloudware
        [HttpPost]
        public virtual ActionResult RegisterCloudware(CloudApplicationRegistrationAndUpdateModel carm, FormCollection fc)
        {
            try
            {
                Person p = ModelHelpers.AddPerson(carm.Forename, carm.Surname, carm.Position, carm.Company, carm.EMail, carm.Telephone, carm.Country, carm.JoinUserGroup, _repository);
                SupportAreaQA qa = new SupportAreaQA();
                qa.SubmittedPerson = p;
                qa.QAStatus = _repository.GetQAStatus("UNASSIGNED");
                if (!carm.IsCloudwareUpdate)
                {
                    qa.Question = "Cloudware Registration";
                    qa.SupportArea = _repository.GetSupportArea("REGISTRATION");
                }
                else
                {
                    qa.Question = carm.CloudApplicationUpdateDetails;
                    qa.SupportArea = _repository.GetSupportArea("CONTENT");
                }
                qa.QuestionDate = DateTime.Now;
                qa.SupportAreaCloudApplicationServiceName = carm.CloudApplicationServiceName;
                qa.EMail = true;

                //carm.SupportCategories.Where(x => x.Selected).ForEach(y => qa.SupportAreaQACategories.Add(_repository.GetSupportCategory(y.SupportCategoryID));
                if (!carm.IsCloudwareUpdate)
                {
                    SupportAreaQACategory saqac;
                    List<SupportCategoryModel> test = carm.SupportCategories.Where(x => x.Selected).ToList();
                    foreach (SupportCategoryModel scm in test)
                    {
                        saqac = new SupportAreaQACategory();
                        saqac.SupportCategory = _repository.GetSupportCategory(scm.SupportCategoryID);
                        saqac.SupportAreaQA = qa;
                        if (qa.SupportAreaQACategories == null)
                        {
                            qa.SupportAreaQACategories = new List<SupportAreaQACategory>();
                        }
                        qa.SupportAreaQACategories.Add(saqac);
                    }
                    qa.SupportCategoryOther = carm.SupportCategoryOther;
                }

                qa.SupportAreaQAStatus = _repository.FindStatusByName("LIVE");
                _repository.AddSupportAreaQA(qa);
                //throw new Exception();
                CustomSession.AutoShowRegisterOrUpdate = false;
                return null;
            }
            catch (Exception e)
            {
                Logger.Fatal("Could not register cloudware. The error was : " + e.Message + ". Stack trace : " + e.StackTrace);
                throw new Exception();
            }
        }
        #endregion

        #region CloudApplicationRegistrationOrUpdateNoScript
        public ActionResult CloudApplicationRegistrationOrUpdateNoScript(bool update, bool scripting)
        {
            CloudApplicationRegistrationAndUpdateModel model = new CloudApplicationRegistrationAndUpdateModel(CustomSession);
            model.IsCloudwareUpdate = update;
            if (!model.IsCloudwareUpdate)
            {
                model.CloudApplicationUpdateDetails = "dummytext";
            }
            model.SupportCategories = _repository.GetSupportCategories().Select(x => new SupportCategoryModel()
            {
                SupportCategoryID = x.SupportCategoryID,
                SupportCategoryName = x.SupportCategoryName,
            }
            ).ToList();
            //model = GetCorporateInformationData(model);


            return View("CloudApplicationRegistrationOrUpdateNoScript", model);
        }

        [HttpPost]
        //public virtual ActionResult RegisterCloudware(HeaderModel hm, FormCollection fc)
        public virtual ActionResult CloudApplicationRegistrationOrUpdateNoScript(CloudApplicationRegistrationAndUpdateModel carm, FormCollection fc)
        {
            carm.ShowTCAcceptDialog = !carm.TermsAndConditions;
            if (carm.ShowTCAcceptDialog)
            {
                carm.ConfirmationDialogTitle = "Register/update cloudware";
                carm.ConfirmationDialogMessage1 = "Please accept the terms & conditions to proceed";
            }
            if (ModelState.IsValid)
            {
                Person p = ModelHelpers.AddPerson(carm.Forename, carm.Surname, carm.Position, carm.Company, carm.EMail, carm.Telephone, carm.Country, carm.JoinUserGroup, _repository);
                SupportAreaQA qa = new SupportAreaQA();
                qa.SubmittedPerson = p;
                qa.QAStatus = _repository.GetQAStatus("UNASSIGNED");
                if (!carm.IsCloudwareUpdate)
                {
                    qa.Question = "Cloudware Registration";
                    qa.SupportArea = _repository.GetSupportArea("REGISTRATION");
                }
                else
                {
                    qa.Question = carm.CloudApplicationUpdateDetails;
                    qa.SupportArea = _repository.GetSupportArea("CONTENT");
                }
                qa.QuestionDate = DateTime.Now;
                qa.SupportAreaCloudApplicationServiceName = carm.CloudApplicationServiceName;
                qa.EMail = true;

                //carm.SupportCategories.Where(x => x.Selected).ForEach(y => qa.SupportAreaQACategories.Add(_repository.GetSupportCategory(y.SupportCategoryID));
                if (!carm.IsCloudwareUpdate)
                {
                    SupportAreaQACategory saqac;
                    List<SupportCategoryModel> test = carm.SupportCategories.Where(x => x.Selected).ToList();
                    foreach (SupportCategoryModel scm in test)
                    {
                        saqac = new SupportAreaQACategory();
                        saqac.SupportCategory = _repository.GetSupportCategory(scm.SupportCategoryID);
                        saqac.SupportAreaQA = qa;
                        if (qa.SupportAreaQACategories == null)
                        {
                            qa.SupportAreaQACategories = new List<SupportAreaQACategory>();
                        }
                        qa.SupportAreaQACategories.Add(saqac);
                    }
                    qa.SupportCategoryOther = carm.SupportCategoryOther;
                }

                qa.SupportAreaQAStatus = _repository.FindStatusByName("LIVE");
                _repository.AddSupportAreaQA(qa);
                //throw new Exception();
                carm.ShowTCAcceptDialog = false;
                carm.ShowConfirmationDialog = true;
                return View(carm);
                //return null;
            }
            else
            {
                //return View("CloudApplicationRegistrationOrUpdateNoScript", carm);
                return View(carm);
            }
        }
        #endregion

        #region BetaSplashShown
        [HttpPost]
        public virtual ActionResult BetaSplashShown()
        {
            CustomSession.BetaSplashShown = true;
            return null;
        }
        #endregion

        #region BetaSplashShownNoScript
        //[HttpPost]
        //[HttpGet]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public virtual ActionResult BetaSplashShownNoScript()
        {
            CustomSession.BetaSplashShown = true;
            return RedirectToAction("HomePage", "Home", new { scripting = false });
        }
        #endregion

        #region RedisplayBetaSplashShownNoScript
        //[HttpPost]
        public virtual ActionResult RedisplayBetaSplashShownNoScript()
        {
            CustomSession.BetaSplashShown = false;
            return RedirectToAction("HomePage", "Home", new { scripting = false });
        }
        #endregion

        #region ThanksForComing
        public ActionResult ThanksForComing(BaseModel model)
        {
            //SiteMapModel model = ModelHelpers.GetSiteMapData(this.CustomSession, _repository);
            if (model.CustomSession == null)
            {
                model.CustomSession = CustomSession;
            }
            ModelHelpers.SetSessionVariables(Request, model.CustomSession);
            //BaseModel b = new BaseModel() { CustomSession = customSession };
            return View("ThanksForComing", model);

        }
        #endregion

        #region PageNotFound
        public ActionResult PageNotFound(CustomSession customSession)
        {
            //SiteMapModel model = ModelHelpers.GetSiteMapData(this.CustomSession, _repository);
            ModelHelpers.SetSessionVariables(Request, customSession);
            return View("PageNotFound", new BaseModel() { CustomSession = customSession });

        }
        #endregion

        //#region H1H2Data
        //public ActionResult H1H2Data()
        //{
        //    ContentTextsModel model = new ContentTextsModel(CustomSession);
        //    model = ModelHelpers.GetH1H2Data(model, _repository);
        //    model.CloudwareExplainedVisible = true;
        //    return View("CloudwareExplainedPage", model);
        //}
        //#endregion

        //public class CustomControllerBase : Controller
        //{
            public PartialViewResult EditorFor<TModel>(TModel model)
            {
                return PartialView("EditorTemplates/" + typeof(TModel).Name, model);
            }

            public PartialViewResult DisplayFor<TModel>(TModel model)
            {
                return PartialView("DisplayTemplates/" + typeof(TModel).Name, model);
            }
        //}

            protected ViewResult MetaDataView(string viewName, BaseModel model)
            {
                ViewBag.MetaKeywords = model.MetaKeywords;
                ViewBag.MetaDescription = model.MetaDescription;
                ViewBag.MetaTitle = model.MetaTitle;
                return View(viewName, model);
            }
    }
}
