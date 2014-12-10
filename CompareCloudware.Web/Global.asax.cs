using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CompareCloudware.Web.FluentSecurity;
using CompareCloudware.Web.Controllers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using CompareCloudware.Web.Plumbing;
using CompareCloudware.Web.Helpers;
using CompareCloudware.Web.Models;
using System.Configuration;
//using System.Web.WebPages;

namespace CompareCloudware.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static IWindsorContainer container { get; private set; }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleSecurityAttribute(), 0);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.IgnoreRoute("{*error}", new { error = @"(.*/)?error(/.*)?" });
            //routes.IgnoreRoute("WindowToOpenOnTryBuy/{WindowToOpenOnTryBuy}");
            routes.IgnoreRoute("Vendor/Review URL");

            //Route r = new Route("{controller}/{action}/{id}", new MvcRouteHandler())
            //{
            //    Defaults = new RouteValueDictionary(new { action = "Index", id = "" })
            //};
            //routes.Add(r);

            //routes.MapRoute(
            //    "JavascriptControl", // Route name
            //    "{controller}/{action}/{javascriptenabled}", // URL with parameters
            //    new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional, javascriptenabled = UrlParameter.Optional } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "TabResultsControl", // Route name
            //    "{controller}/{action}/{tab}", // URL with parameters
            //    new { controller = "Home", action = "HomePage", tab = UrlParameter.Optional } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "Vendor", // Route name
            //    "{controller}/{action}/{id}", // URL with parameters
            //    new { controller = "Vendor", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "Default", // Route name
            //    "{controller}/{action}/{id}", // URL with parameters
            //    new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional } // Parameter defaults
            //);

            //routes.MapRoute(
            //    name: "Search", // Route name
            //    url: "{*url}", // URL with parameters,
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "IndexCustom",
            //        id = UrlParameter.Optional
            //    }
            //);
            //routes.MapRoute(
            //    "corporate", // Route name
            //    "corporate", // URL with parameters
            //    new { controller = "Home", action = "CorporateInformation", activeTab = 0 } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "ContactUs", // Route name
            //    "ContactUs", // URL with parameters
            //    new { controller = "Home", action = "CorporateInformation", activeTab = 6 } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "SiteMap", // Route name
            //    "SiteMap", // URL with parameters
            //    new { controller = "Home", action = "SitemapPage" } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "PrivacyPolicy", // Route name
            //    "PrivacyPolicy", // URL with parameters
            //    new { controller = "Home", action = "PrivacyPolicyPage" } // Parameter defaults
            //);

            //routes.MapRoute(
            //    "UserTermsOfUse", // Route name
            //    "UserTermsOfUse", // URL with parameters
            //    new { controller = "Home", action = "UserTermsOfUsePage" } // Parameter defaults
            //);

            routes.MapRoute(
                "WindowToOpenOnTryBuy", // Route name
                "WindowToOpenOnTryBuy/{WindowToOpenOnTryBuy}", // URL with parameters
                new { controller = "Home", action = "WindowToOpenOnTryBuy", category = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "InsertApplicationRequest", // Route name
                "{anything}/InsertApplicationRequest", // URL with parameters
                new { controller = "Home", action = "InsertApplicationRequest", whichTab = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "EMailApplicationRequest", // Route name
                "{anything}/EMailApplicationRequest", // URL with parameters
                new { controller = "Home", action = "EMailApplicationRequest", whichTab = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "SearchResultsTabChanged", // Route name
                "Home/SearchResultsTabChanged/{whichTab}", // URL with parameters
                new { controller = "Home", action = "SearchResultsTabChanged", whichTab = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "ShowLogo", // Route name
                "Home/ShowLogo/{vendorID}", // URL with parameters
                new { controller = "Home", action = "ShowLogo", vendorID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "ShowLogoVendor", // Route name
                "Vendor/ShowLogo/{cloudApplicationID}", // URL with parameters
                new { controller = "Vendor", action = "ShowLogo", cloudApplicationID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "ShowImage", // Route name
                "Home/ShowImage/{documentID}", // URL with parameters
                new { controller = "Home", action = "ShowImage", documentID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "ShowMPU", // Route name
                "Home/ShowMPU", // URL with parameters
                new { controller = "Home", action = "ShowMPU" } // Parameter defaults
            );

            routes.MapRoute(
                "ShowSkyScraper", // Route name
                "Home/ShowSkyScraper", // URL with parameters
                new { controller = "Home", action = "ShowSkyScraper" } // Parameter defaults
            );

            routes.MapRoute(
                "RedirectShowDocument", // Route name
                "Home/RedirectShowDocument/{documentID}", // URL with parameters
                new { controller = "Home", action = "RedirectShowDocument", documentID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "ShowPortrait", // Route name
                "Home/ShowPortrait/{contentTextID}", // URL with parameters
                new { controller = "Home", action = "ShowPortrait", contentTextID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "GetThumbnail", // Route name
                "GetThumbnail", // URL with parameters
                new { controller = "Home", action = "GetThumbnail" } // Parameter defaults
            );

            
            routes.MapRoute(
                "CloudwareExplained", // Route name
                "Home/HeaderModel/{tab}", // URL with parameters
                new { controller = "Home", action = "HeaderModel", tab = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "CloudwareExplainedPage", // Route name
                "Home/CloudwareExplainedPage", // URL with parameters
                new { controller = "Home", action = "CloudwareExplainedPage" } // Parameter defaults
            );

            routes.MapRoute(
                "CloudwareExplainedPartial", // Route name
                "Home/CloudwareExplainedPartial", // URL with parameters
                new { controller = "Home", action = "CloudwareExplainedPartial" } // Parameter defaults
            );

            routes.MapRoute(
                "AutoComplete", // Route name
                "AutoComplete", // URL with parameters
                new { controller = "Home", action = "AutoComplete" } // Parameter defaults
            );

            routes.MapRoute(
                "UserReview", // Route name
                "UserReview", // URL with parameters
                new { controller = "Home", action = "UserReview" } // Parameter defaults
            );

            routes.MapRoute(
                "HasActiveSupport", // Route name
                "HasActiveSupport", // URL with parameters
                new { controller = "Home", action = "HasActiveSupport" } // Parameter defaults
            );

            routes.MapRoute(
                "RegisterCloudware", // Route name
                "become-a-partner", // URL with parameters
                new { controller = "Home", action = "RegisterExternal" } // Parameter defaults
            );

            routes.MapRoute(
                "Category", // Route name
                "Home/CategoryPage/{id}", // URL with parameters
                new { controller = "Home", action = "CategoryPage", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "HomePage", // Route name
                "HomePage", // URL with parameters
                new { controller = "Home", action = "HomePage" } // Parameter defaults
            );

            routes.MapRoute(
                "HomePageFirstTime", // Route name
                "HomePageFirstTime", // URL with parameters
                new { controller = "Home", action = "HomePageFirstTime" } // Parameter defaults
            );

            routes.MapRoute(
                "SearchPage", // Route name
                "SearchPage", // URL with parameters
                new { controller = "Home", action = "SearchPage" } // Parameter defaults
            );

            routes.MapRoute(
                "SearchPagePartial", // Route name
                "SearchPagePartial", // URL with parameters
                new { controller = "Home", action = "SearchPagePartial" } // Parameter defaults
            );

            routes.MapRoute(
                "Comparing", // Route name
                "Comparing", // URL with parameters
                new { controller = "Home", action = "Comparing" } // Parameter defaults
            );

            routes.MapRoute(
                "TakingToSelectionWithPrompt", // Route name
                "TakingToSelectionWithPrompt", // URL with parameters
                new { controller = "Home", action = "TakingToSelectionWithPrompt" } // Parameter defaults
            );

            routes.MapRoute(
                name: "TakeToSelection", // Route name
                url: "TakeToSelection/{cloudApplicationID}", // URL with parameters
                defaults:new { controller = "Home", action = "TakeToSelection", cloudApplicationID = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "SearchResultsCount", // Route name
                "SearchResultsCount", // URL with parameters
                new { controller = "Home", action = "SearchResultsCount" } // Parameter defaults
            );

            routes.MapRoute(
                "SearchResultsPartial", // Route name
                "SearchResultsPartial", // URL with parameters
                new { controller = "Home", action = "SearchResultsPartial" } // Parameter defaults
            );

            routes.MapRoute(
                "SearchFiltersPartial", // Route name
                "SearchFiltersPartial", // URL with parameters
                new { controller = "Home", action = "SearchFiltersPartial" } // Parameter defaults
            );

            routes.MapRoute(
                "GetNextSearchResultsPage", // Route name
                "GetNextSearchResultsPage", // URL with parameters
                new { controller = "Home", action = "GetNextSearchResultsPage" } // Parameter defaults
            );

            routes.MapRoute(
                "GetNextGlobalSearchResultsPage", // Route name
                "GetNextGlobalSearchResultsPage", // URL with parameters
                new { controller = "Home", action = "GetNextGlobalSearchResultsPage", page = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "CloudApplication", // Route name
                "Home/CloudApplication", // URL with parameters
                new { controller = "Home", action = "CloudApplication" } // Parameter defaults
            );

            //routes.MapRoute(
            //    "register", // Route name
            //    "Home/RegisterExternal", // URL with parameters
            //    new { controller = "Home", action = "RegisterExternal" } // Parameter defaults
            //);

            routes.MapRoute(
                "SiteMapXml", // Route name
                "sitemap.xml", // URL with parameters
                new { controller = "Site", action = "SiteMapXml" } // Parameter defaults
            );

            routes.MapRoute(
                "RobotsText", // Route name
                "robots.txt", // URL with parameters
                new { controller = "Site", action = "RobotsText" } // Parameter defaults
            );





            routes.MapRoute(
                "Home External", // Route name
                "home", // URL with parameters
                new { controller = "Home", action = "HomePage" } // Parameter defaults
            );

            routes.MapRoute(
                "cloudware-explained", // Route name
                "cloudware-explained", // URL with parameters
                new { controller = "Home", action = "CloudwareExplainedPage" } // Parameter defaults
            );

            routes.MapRoute(
                "corporate", // Route name
                "corporate", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 0 } // Parameter defaults
            );

            routes.MapRoute(
                "about", // Route name
                "about", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 0 } // Parameter defaults
            );

            routes.MapRoute(
                "management-team", // Route name
                "management-team", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 1 } // Parameter defaults
            );

            routes.MapRoute(
                "vision", // Route name
                "vision", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 2 } // Parameter defaults
            );

            routes.MapRoute(
                "faqs", // Route name
                "faqs", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 3 } // Parameter defaults
            );

            routes.MapRoute(
                "careers", // Route name
                "careers", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 4 } // Parameter defaults
            );

            routes.MapRoute(
                "press", // Route name
                "press", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 5 } // Parameter defaults
            );

            routes.MapRoute(
                "contact", // Route name
                "contact", // URL with parameters
                new { controller = "Home", action = "CorporateInformation", activeTab = 6 } // Parameter defaults
            );

            routes.MapRoute(
                "register", // Route name
                "register", // URL with parameters
                new { controller = "Home", action = "RegisterExternal" } // Parameter defaults
            );

            routes.MapRoute(
                "privacy", // Route name
                "privacy", // URL with parameters
                new { controller = "Home", action = "PrivacyPolicyPage" } // Parameter defaults
            );

            routes.MapRoute(
                "terms", // Route name
                "terms", // URL with parameters
                new { controller = "Home", action = "UserTermsOfUsePage" } // Parameter defaults
            );

            routes.MapRoute(
                "sitemap", // Route name
                "sitemap", // URL with parameters
                new { controller = "Home", action = "SitemapPage" } // Parameter defaults
            );

            routes.MapRoute(
                "DummyVXMode", // Route name
                "SetDummyVXMode", // URL with parameters
                new
                {
                    controller = "Home",
                    action = "SetDummyVXMode"
                }
            );

            routes.MapRoute(
                "Vendor", // Route name
                "Vendor/IndexCustom/cloudApplicationID", // URL with parameters
                new
                {
                    controller = "Vendor",
                    action = "IndexCustom",
                    clodApplicationID = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                "AccountLogon", // Route name
                "Account/Logon", // URL with parameters
                new
                {
                    controller = "Account",
                    action = "Logon"
                    //,
                    //cloudApplicationID = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                "VendorEdit", // Route name
                "Vendor/EditApplication", // URL with parameters
                new
                {
                    controller = "Vendor",
                    action = "EditApplication"
                    //,
                    //cloudApplicationID = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                "GlobalSearchResults", // Route name
                "global/{term}", // URL with parameters
                new
                {
                    controller = "Home",
                    action = "GlobalSearchResults",
                    //,
                    term = UrlParameter.Optional,
                    liveApplicationsOnly = true,
                }
            );

            routes.MapRoute(
                "VX", // Route name
                "VX", // URL with parameters
                new
                {
                    controller = "Home",
                    action = "Index",
                    //,
                    showDiagnostics = true,
                }
            );

            routes.MapRoute(
                "VendorSave", // Route name
                "Vendor/RegisterApplication", // URL with parameters
                new
                {
                    controller = "Vendor",
                    action = "RegisterApplication"
                    //,
                    //cloudApplicationID = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                "VendorUploadImage", // Route name
                "Vendor/UploadImage", // URL with parameters
            new
            {
                controller = "Vendor",
                action = "UploadImage"
                //,
                //cloudApplicationID = UrlParameter.Optional
            }
                );

            routes.MapRoute(
                    "ThanksForComing", // Route name
                    //"thanksforcoming/{categoryname}", // URL with parameters
                    "thanksforcoming", // URL with parameters
                    new
                    {
                        controller = "Home",
                        action = "ThanksForComing"
                        ,
                        model = UrlParameter.Optional
                    }

            );

            routes.MapRoute(
                    "PartnerProgramme", // Route name
                //"thanksforcoming/{categoryname}", // URL with parameters
                    "partnerprogramme", // URL with parameters
                    new
                    {
                        controller = "Home",
                        action = "PartnerProgrammePage"
                        ,
                        model = UrlParameter.Optional
                    }

            );



            routes.MapRoute(
                    "BusinessPartner", // Route name
                    "admin/businesspartner", // URL with parameters
                    new
                    {
                        controller = "Admin",
                        action = "BusinessPartner"
                        ,
                        cloudApplicationRequestId = UrlParameter.Optional
                    }

            );

            routes.MapRoute(
                    "StrategicPartner", // Route name
                    "admin/strategicpartner", // URL with parameters
                    new
                    {
                        controller = "Admin",
                        action = "StrategicPartner"
                        ,
                        cloudApplicationRequestId = UrlParameter.Optional
                    }

            );

            routes.MapRoute(
                    "ReferRewardr", // Route name
                    "admin/referreward", // URL with parameters
                    new
                    {
                        controller = "Admin",
                        action = "ReferReward"
                        ,
                        cloudApplicationRequestId = UrlParameter.Optional
                    }

            );

            routes.MapRoute(
                    "SendToColleague", // Route name
                    "admin/sendtocolleague", // URL with parameters
                    new
                    {
                        controller = "Admin",
                        action = "SendToColleague"
                        ,
                        cloudApplicationRequestId = UrlParameter.Optional
                    }

            );

            routes.MapRoute(
                "Shop", // Route name
                "Shop", // URL with parameters,
                new
                {
                    controller = "Home",
                    action = "Shop"
                }
            );

            routes.MapRoute(
                name: "RandomShop", // Route name
                url: "{theCategory}/{theShop}", // URL with parameters,
                defaults: new
                {
                    controller = "Home",
                    action = "Shop",
                    category = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "RandomCategory", // Route name
                url: "{theCategory}", // URL with parameters,
                defaults: new
                {
                    controller = "Home",
                    action = "Category",
                    category = UrlParameter.Optional
                }
            );

            //routes.MapRoute(
            //"NotFound",
            //"{*url}",
            //new { controller = "Home", action = "IndexCustom", id = HttpContext.Current.Request.Url.PathAndQuery }
            //);

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
                //new { controller = "Site", action = "SiteMapXml", id = UrlParameter.Optional } // Parameter defaults
                //new { controller = "Site", action = "RobotsText", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            new SecurityBootstrapper().Execute();
            //StaticSecurityBootstrapper.SetupFluentSecurity();
            container = new WindsorContainer().Install(FromAssembly.This());
            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
            //DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone")
            //{
            //    ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
            //      ("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            //});
            
            //SecurityConfigurator.Configure(configuration =>
            //    {
            //        configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
            //        configuration.For<HomeController>().DenyAnonymousAccess();
            //        configuration.For<AccountController>(ac => ac.LogOn()).Ignore();
            //    });
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Add(new NoScriptRazorViewEngine());

            //ModelBinders.Binders.Add(typeof(HeaderModel), container.Resolve<EditViewModelBinder>());
            ModelBinders.Binders.Add(typeof(HeaderModel), new CustomModelBinder(container.Kernel));

            ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());
        }

        protected void Application_End()
        {
            container.Dispose();
        }

        protected void Session_End(Object sender, EventArgs e)
        {
            //bool testMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"]);
            //string homePageURL = testMode ? ConfigurationManager.AppSettings["HomePageURLDev"] : ConfigurationManager.AppSettings["HomePageURLLive"];
            //Response.AppendHeader("Refresh", "1 home.htm");
        }

        //protected void Page_init(object sender, EventArgs e)
        //{
        //    if (Context.Session != null)
        //    {
        //        if (Session.IsNewSession)
        //        {
        //            HttpCookie newSessionIdCookie = Request.Cookies["ASP.NET_SessionId"];
        //            if (newSessionIdCookie != null)
        //            {
        //                string newSessionIdCookieValue = newSessionIdCookie.Value;
        //                if (newSessionIdCookieValue != String.Empty)
        //                {
        //                    // This means Session was timed Out and New Session was started
        //                    Response.Redirect("Login.aspx");
        //                }
        //            }
        //        }
        //    }
        //}

        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    HttpContext ctx = HttpContext.Current;

        //    if (ctx.Session != null)
        //    {
        //        if (ctx.Session.IsNewSession)
        //        {
        //            string sessionCookie = ctx.Request.Headers["Cookie"];
        //            if ((null != sessionCookie) && (sessionCookie.IndexOf("ASP.NET_SessionId") >= 0))
        //            {
        //                UrlHelper helper = new UrlHelper(filterContext.RequestContext);
        //                String url = helper.Action(this.RedirectAction, this.RedirectController);
        //                ctx.Response.Redirect(url);
        //            }
        //        }
        //    }

        //    base.OnActionExecuting(filterContext);
        //}
    }
}