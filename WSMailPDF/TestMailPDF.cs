using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using Castle.Core.Logging;
//using CompareCloudware.Web;
//using CompareCloudware.Web.Helpers;
//using CompareCloudware.Web.Models;
//using CompareCloudware.Web.Controllers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
//using CompareCloudware.Domain.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Hosting;
using System.Threading;
using System.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Moq;
using System.Collections.Specialized;
using System.Net;
//using MvcIntegrationTestFramework.Hosting;
//using MvcIntegrationTestFramework.Browsing;

namespace WSMailPDF
{
    public partial class TestMailPDF : ServiceBase
    {
        //private IContainer components;
        private EventLog el;
        private TimerCallback timerDelegate;
        private System.Threading.Timer serviceTimer;
        private string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
        private int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
        private int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
        EMailHost myAppHost;
        //string view;
        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        //public ILogger Logger { get; set; }
    
        public TestMailPDF()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // MailPDF
            // 
            this.ServiceName = "COMPARE CLOUDWARE EMAILER";

        }

        private void CreateHost()
        {
            myAppHost = (EMailHost)ApplicationHost.CreateApplicationHost(
                        typeof(EMailHost), "/", @"J:\CompareCloudwareVideo\CompareCloudware.Web");
        }

        #region OnStart
        protected override void OnStart(string[] args)
        {
            //Initilaize the single point queue for storing and acknowledging all the folder changed events.
            //this.ServiceMail();

            //Log event to a simple text file in case database has not been started.
            //Logger.Debug("Entered site");
            //Log event to database as normal.
            //Logger.Debug("Entered site");

            myAppHost = (EMailHost)ApplicationHost.CreateApplicationHost(
                        typeof(EMailHost), "/", @"J:\CompareCloudwareVideo\CompareCloudware.Web");
            el = new System.Diagnostics.EventLog(eventLogFile);
                el.Source = eventLogFile;
                el.WriteEntry("Starting timer");
                timerDelegate = new TimerCallback(DoWork);
                serviceTimer = new System.Threading.Timer(timerDelegate, null, dueTime, interval);
                el.WriteEntry("Started timer");
        }
        #endregion

        #region OnStop
        protected override void OnStop()
        {
            //Log event to a simple text file in case database has not been started.
            //Logger.Debug("Entered site");
            //Log event to database as normal.
            //Logger.Debug("Entered site");
        }
        #endregion

        private void DoWork(object state)
        {
            try
            {
                serviceTimer.Change(Timeout.Infinite, Timeout.Infinite);
                el.WriteEntry("Started ServiceMail");
                ServiceMail();
                el.WriteEntry("Finished ServiceMail");
                //DoDummyWork();
                serviceTimer.Change(dueTime, interval);
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in DoWork() : " + e.Message);
            }
        }

        #region ServiceMail
        public void ServiceMail()
        {
            IWindsorContainer container2 = new WindsorContainer().Install(FromAssembly.This());
            HomeController hc2 = container2.Resolve<HomeController>();
            try
            {
                CompareCloudwareContext _context = new CompareCloudwareContext();
                QueryRepository _repository = new QueryRepository(_context);
                CreateHost();
                //CustomSession session = new CustomSession();
                //session.DetectedBrowserID = "WINDOWSSERVICE";
                //HomeController controller = new HomeController(session,(ICompareCloudwareRepository)_repository);


                //IWindsorContainer container = new WindsorContainer().Install(FromAssembly.Named("CompareCloudware.Web"));

                string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];

                using (var writer = new StringWriter())
                {
                    try
                    {
                        //var httpContext = new HttpContext(new HttpRequest("PrintResult3", webSiteLocationContext, ""), new HttpResponse(writer));
                        HttpContextBase httpContext = FakeHTTPContext();
                        System.Web.Routing.RouteCollection routes = new System.Web.Routing.RouteCollection();
                        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                        routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

                        Route r = new Route("{controller}.mvc/{action}/{id}", new MvcRouteHandler())
                        {
                            Defaults = new RouteValueDictionary(new { action = "Index", id = "" })
                        };
                        routes.Add(r);

                        routes.MapRoute(
                            "JavascriptControl", // Route name
                            "{controller}/{action}/{javascriptenabled}", // URL with parameters
                            new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional, javascriptenabled = UrlParameter.Optional } // Parameter defaults
                        );

                        routes.MapRoute(
                            "TabResultsControl", // Route name
                            "{controller}/{action}/{tab}", // URL with parameters
                            new { controller = "Home", action = "HomePage", tab = UrlParameter.Optional } // Parameter defaults
                        );

                        routes.MapRoute(
                            "Default", // Route name
                            "{controller}/{action}/{id}", // URL with parameters
                            new { controller = "Home", action = "PrintResult3", id = UrlParameter.Optional } // Parameter defaults
                        );

                        var routeData = new RouteData(routes[2], new MvcRouteHandler());
                        //var routeData = new RouteData();
                        routeData.Values.Add("controller", "Home");
                        routeData.Values.Add("action", razorPageForPDF);

                        //httpContext.Request.Browser = new capabilities();

                        IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                        HomeController hc = container.Resolve<HomeController>();
                        CloudApplicationModel cam = hc.ConstructCloudApplicationModel(_repository.GetCloudApplication(1,false), null);
                        //SearchPageModel cpm = (SearchPageModel)v.Model;
                        //CloudApplicationModel cam = (CloudApplicationModel)cpm.ContainerModel.ChosenCloudApplicationModel;
                        //var controllerContext = new ControllerContext(new HttpContextWrapper(httpContext), routeData, hc);
                        var controllerContext = new ControllerContext(new RequestContext(httpContext,routeData), hc);
                        controllerContext.Controller.ViewData.Model = cam;
                        //var res = hc.PrintResult3();
                        //res.ExecuteResult(controllerContext);
                        //controllerContext.Controller.ViewData.Model = cam;

                        hc.ControllerContext = controllerContext;
                        //ViewResult viewResult = hc.CloudApplication(1, null) as ViewResult;
                        //ViewResult viewResult = hc.About() as ViewResult;
                        //ViewContext viewContext = new ViewContext(hc.ControllerContext, viewResult.View, hc.ViewData, hc.TempData, writer);
                        //viewResult.View.Render(viewContext, writer);
                        //var res = hc.Index("1","true");
                        var res = hc.PrintResult3(1);

                        
                        //ViewEngineResult viewResult = ViewEngines.Engines.FindView(hc.ControllerContext, razorPageForPDF, null);
                        //CustomViewEngine cve = new CustomViewEngine();
                        //ViewEngineResult viewResult = cve.FindView(hc.ControllerContext, razorPageForPDF, null, false);
                        //ViewContext viewContext = new ViewContext(hc.ControllerContext, viewResult.View, hc.ViewData, hc.TempData, writer);
                        
                        //viewResult.View.Render(viewContext, writer);
                        //viewResult.ViewEngine.ReleaseView(hc.ControllerContext, viewResult.View);
                        //myAppHost.RenderHomeIndexAction();
                        //TestResult t = new TestResult();
                        //t.ExecuteResult(controllerContext);

                        res.ExecuteResult(controllerContext);

                    }
                    catch
                    {
                        //el.WriteEntry("Error in outer process : " + e.Message);
                        //return e.Message;
                    }
                }

                //RenderRazorView.RenderViewToString(hc, "PrintResult3", cam);

                
                
                
                //AdditionalOutput localao = new AdditionalOutput();
                //localao.OutputFileName = "test.htm";
                //localao.PDFEngineType = PDFEngineType.ASPPDF;
                //MemoryStream y = hc.SendSearchResultToRAZORAndReturnPDFStream(cam, 1, null, "test.pdf", true, localao);
                //byte[] b = y.ToArray();
                //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");
                //System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);

                
                
                //ViewResult viewResult = controller.CloudApplication(1,null) as ViewResult;
                
                //view = myAppHost.RenderHomeIndexAction();

                //foreach (CloudApplicationRequest car in requests)
                //{
                //    localDestination = hc.ConstructCloudApplicationModel(_repository.GetCloudApplication(car.CloudApplicationID),null);
                //    AdditionalOutput localao = new AdditionalOutput();
                //    //localao.OutputFileName = "test.htm";
                //    localao.PDFEngineType = PDFEngineType.ASPPDF;

                //    Person p = _repository.GetPersonByPersonID(car.PersonID);

                //    //string x = sc.SendSearchResultToRAZORAndCreatePDF(destination, 1, "~/documents/", "test.pdf", true, ao);
                //    string fileName = localDestination.ServiceName.Trim() + ".pdf";
                //    //string x = SendSearchResultToRAZORAndCreatePDF(localDestination, 1, "~/documents/", fileName, true, localao);

                //    //MemoryStream y = hc.SendSearchResultToRAZORAndReturnPDFStream(localDestination, 1, "~/documents/", fileName, true, localao);
                //    MemoryStream y = hc.SendSearchResultToRAZORAndReturnPDFStream(localDestination, 1, null, fileName, true, localao);
                //    byte[] b = y.ToArray();
                //    //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");
                //    //System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
                //    SendEmail sm = new SendEmail();
                //    y.Position = 0;
                //    sm.Execute(p, car, y, fileName);
                //}
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceMail() : " + e.Message);
            }
        }
        #endregion

        #region FakeHTTPContext
        public static HttpContextBase FakeHTTPContext()
        {
            var browser = new Mock<HttpBrowserCapabilitiesBase>(MockBehavior.Strict);
            var context = new Mock<HttpContextBase>(MockBehavior.Strict);
            var request = new Mock<HttpRequestBase>(MockBehavior.Strict);
            var response = new Mock<HttpResponseBase>(MockBehavior.Default);
            var session = new Mock<HttpSessionStateBase>(MockBehavior.Strict);
            var server = new Mock<HttpServerUtilityBase>(MockBehavior.Default);
            var cookies = new HttpCookieCollection();
            cookies.Add(new HttpCookie("test"));
            var items = new ListDictionary();

            browser.Setup(b => b.IsMobileDevice).Returns(false);

            request.Setup(r => r.Cookies).Returns(cookies);
            request.Setup(r => r.ValidateInput());
            request.Setup(r => r.UserAgent).Returns("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11");
            response.Setup(r => r.Cookies).Returns(cookies);

            request.Setup(r => r.Browser).Returns(browser.Object);

            context.Setup(ctx => ctx.Items).Returns(items);

            context.Setup(r => r.Response).Returns(response.Object);

            context.SetupGet(ctx => ctx.Request).Returns(request.Object);
            context.SetupGet(ctx => ctx.Response).Returns(response.Object);
            context.SetupGet(ctx => ctx.Session).Returns(session.Object);
            context.SetupGet(ctx => ctx.Server).Returns(server.Object);

            //request.Setup(r => r.Path).Returns(ConfigurationManager.AppSettings["WebSiteLocationContext"]);
            //request.Setup(r => r.RawUrl).Returns("/home.mvc/PrintResult3");
            context.SetupGet(x => x.Request.ApplicationPath).Returns("/home.mvc/PrintResult3");
            
            //request.SetupGet(r => r.Cookies).Returns(new HttpCookieCollection());
            //context.Setup(ctx => ctx.Request.Cookies).Returns(new HttpCookieCollection());
            //request.SetupGet(r => r.UserAgent).Returns("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11");
            

            return context.Object;
        }
        #endregion

        public void WithWebClient()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("http://localhost:81/Home.mvc/PrintResult3?cloudApplicationID=1");
                //string result = wc.DownloadString("http://localhost:81/Home.mvc/CloudApplication?cloudApplicationID=1");
                string result2 = result;
            }

        }

        //public void WithIntegrationFramework()
        //{
        //    AppHost appHost = new AppHost("J:\\CompareCloudwareVideo\\CompareCloudware.Web");
        //    appHost.SimulateBrowsingSession(browsingSession =>
        //    {
        //        RequestResult result = browsingSession.ProcessRequest("home/index");

        //        // Routing config should match "home" controller
        //        //Assert.AreEqual("home", result.ActionExecutedContext.RouteData.Values["controller"]);

        //        // Should have rendered the "index" view
        //        ActionResult actionResult = result.ActionExecutedContext.Result;
        //        //Assert.IsInstanceOf(typeof(ViewResult), actionResult);
        //        //Assert.AreEqual("index", ((ViewResult)actionResult).ViewName);

        //        // App should not have had an unhandled exception
        //        //Assert.IsNull(result.ResultExecutedContext.Exception);
        //    });
        //    Debugger.Break();
        //}

        public void DoDummyWork()
        {
            el.WriteEntry("Started dummy work");
            for (Int64 i = 1; i < 10000000000; i++)
            {

            }
            el.WriteEntry("Finished dummy work");
        }
    }

    public class capabilities : HttpBrowserCapabilities
    {
        public override bool IsMobileDevice
        {
            get
            {
                return false;
            }
        }
    }

    #region MyAppHost
    //public class MyAppHost : MarshalByRefObject
    //{
    //    private EventLog el;
    //    public string RenderHomeIndexAction()
    //    {
    //        string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
    //        string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
    //        string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
    //        int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
    //        int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
    //        el = new System.Diagnostics.EventLog(eventLogFile);
    //        el.Source = eventLogFile;
    //        string retVal = "";
    //        return null;
    //        //try
    //        //{
    //        //    el.WriteEntry("Started process");

    //        //    ICustomSession CustomSession = new CustomSession();

    //        //    CompareCloudwareContext _context = new CompareCloudwareContext();
    //        //    ICompareCloudwareRepository _repository = new QueryRepository(_context);
    //        //    CloudApplicationModel localDestination;

    //        //    List<CloudApplicationRequest> requests = _repository.GetUnservicedCloudApplicationRequests().ToList();

    //        //    //HomeController hc = new HomeController(null, _repository);
    //        //    var controller = new HomeController(null, _repository);
    //        //    //var controller = new AccountController();
    //        //    using (var writer = new StringWriter())
    //        //    {
    //        //        try
    //        //        {
    //        //            //var httpContext = new HttpContext(new HttpRequest("", "http://localhost:3785", ""), new HttpResponse(writer));
    //        //            var httpContext = new HttpContext(new HttpRequest("", webSiteLocationContext, ""), new HttpResponse(writer));
    //        //            if (HttpContext.Current != null) throw new NotSupportedException("httpcontext was already set");
    //        //            HttpContext.Current = httpContext;
    //        //            var controllerName = controller.GetType().Name;

    //        //            System.Web.Routing.RouteCollection routes = new System.Web.Routing.RouteCollection();
    //        //            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
    //        //            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

    //        //            Route r = new Route("{controller}.mvc/{action}/{id}", new MvcRouteHandler())
    //        //            {
    //        //                Defaults = new RouteValueDictionary(new { action = "Index", id = "" })
    //        //            };
    //        //            routes.Add(r);

    //        //            routes.MapRoute(
    //        //                "JavascriptControl", // Route name
    //        //                "{controller}/{action}/{javascriptenabled}", // URL with parameters
    //        //                new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional, javascriptenabled = UrlParameter.Optional } // Parameter defaults
    //        //            );

    //        //            routes.MapRoute(
    //        //                "TabResultsControl", // Route name
    //        //                "{controller}/{action}/{tab}", // URL with parameters
    //        //                new { controller = "Home", action = "HomePage", tab = UrlParameter.Optional } // Parameter defaults
    //        //            );

    //        //            routes.MapRoute(
    //        //                "Default", // Route name
    //        //                "{controller}/{action}/{id}", // URL with parameters
    //        //                new { controller = "Home", action = "TestMail", id = UrlParameter.Optional } // Parameter defaults
    //        //            );

    //        //            var routeData = new RouteData(routes[5], new MvcRouteHandler());
    //        //            routeData.Values.Add("controller", "Home");
    //        //            routeData.Values.Add("action", razorPageForPDF);
                        
    //        //            var controllerContext = new ControllerContext(new HttpContextWrapper(httpContext), routeData, controller);

    //        //            foreach (CloudApplicationRequest car in requests)
    //        //            {
    //        //                localDestination = controller.ConstructCloudApplicationModel(_repository.GetCloudApplication(car.CloudApplicationID,false), null);
    //        //                controllerContext.Controller.ViewData.Model = localDestination;
    //        //                var res = controller.PrintResult3();
    //        //                res.ExecuteResult(controllerContext);

    //        //                AdditionalOutput localao = new AdditionalOutput();
    //        //                //localao.OutputFileName = "test.htm";
    //        //                localao.PDFEngineType = PDFEngineType.ASPPDF;

    //        //                Person p = _repository.GetPersonByPersonID(car.PersonID);

    //        //                //string x = sc.SendSearchResultToRAZORAndCreatePDF(destination, 1, "~/documents/", "test.pdf", true, ao);
    //        //                string fileName = localDestination.ServiceName.Trim() + ".pdf";
    //        //                //string x = SendSearchResultToRAZORAndCreatePDF(localDestination, 1, "~/documents/", fileName, true, localao);

    //        //                //MemoryStream y = hc.SendSearchResultToRAZORAndReturnPDFStream(localDestination, 1, "~/documents/", fileName, true, localao);
    //        //                MemoryStream y = controller.SendHTMLStringAndReturnPDFStream(writer.ToString(), 1, null, fileName, true, localao);
    //        //                byte[] b = y.ToArray();
    //        //                //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");
    //        //                //System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
    //                        SendEmail sm = new SendEmail();
    //        //                y.Position = 0;
    //        //                sm.Execute(p, car, y, fileName);

    //        //                _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);

    //        //            }
    //        //            HttpContext.Current = null;
    //        //            el.WriteEntry("Finished process");
    //        //        }
    //        //        catch (Exception e)
    //        //        {
    //        //            el.WriteEntry("Error in inner process : " + e.Message);
    //        //        }
    //        //        return writer.ToString();
    //        //    }
    //        //}
    //        //catch (Exception e)
    //        //{
    //        //    el.WriteEntry("Error in outer process : " + e.Message);
    //        //    return e.Message;
    //        //}
    //    }
    //}
    #endregion
}
