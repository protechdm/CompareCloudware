namespace CompareCloudware.Web
{
    using Castle.Windsor;
    using Castle.Windsor.Installer;
    using CompareCloudware.Web.FluentSecurity;
    using CompareCloudware.Web.Helpers;
    using CompareCloudware.Web.Models;
    using CompareCloudware.Web.Plumbing;
    using System;
    using System.Runtime.CompilerServices;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class MvcApplication : HttpApplication
    {
        protected void Application_End()
        {
            container.Dispose();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            new SecurityBootstrapper().Execute();
            container = new WindsorContainer().Install(new IWindsorInstaller[] { FromAssembly.This() });
            WindsorControllerFactory controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Add(new NoScriptRazorViewEngine());
            ModelBinders.Binders.Add(typeof(HeaderModel), new CustomModelBinder(container.Kernel));
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleSecurityAttribute(), 0);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = "(.*/)?favicon.ico(/.*)?" });
            Route <>g__initLocal0 = new Route("{controller}.mvc/{action}/{id}", new MvcRouteHandler()) {
                Defaults = new RouteValueDictionary(new { action = "Index", id = "" })
            };
            routes.Add(<>g__initLocal0);
            routes.MapRoute("JavascriptControl", "{controller}/{action}/{javascriptenabled}", new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional, javascriptenabled = UrlParameter.Optional });
            routes.MapRoute("TabResultsControl", "{controller}/{action}/{tab}", new { controller = "Home", action = "HomePage", tab = UrlParameter.Optional });
            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        public static IWindsorContainer container
        {
            [CompilerGenerated]
            get
            {
                return <container>k__BackingField;
            }
            [CompilerGenerated]
            private set
            {
                <container>k__BackingField = value;
            }
        }
    }
}

