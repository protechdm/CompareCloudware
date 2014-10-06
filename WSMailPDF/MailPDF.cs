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
using CompareCloudware.Web;
using CompareCloudware.Web.Helpers;
using CompareCloudware.Web.Models;
using CompareCloudware.Web.Controllers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.Domain.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Hosting;
using System.Threading;
using System.Configuration;

namespace WSMailPDF
{
    public partial class MailPDF : ServiceBase
    {
        private IContainer components;
        private EventLog el;
        private TimerCallback timerDelegate;
        private System.Threading.Timer serviceTimer;
        private string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
        private int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
        private int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
        MyAppHost myAppHost;
        string view;
        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        //public ILogger Logger { get; set; }
    
        public MailPDF()
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

        #region OnStart
        protected override void OnStart(string[] args)
        {
            //Initilaize the single point queue for storing and acknowledging all the folder changed events.
            //this.ServiceMail();

            //Log event to a simple text file in case database has not been started.
            //Logger.Debug("Entered site");
            //Log event to database as normal.
            //Logger.Debug("Entered site");

            myAppHost = (MyAppHost)ApplicationHost.CreateApplicationHost(
                        typeof(MyAppHost), "/", @"J:\CompareCloudware\CompareCloudware.Web");
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
                ServiceMail();
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
            try
            {
                el.WriteEntry("Started ServiceMail");
                view = myAppHost.RenderHomeIndexAction();
                el.WriteEntry("Finished ServiceMail");

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

        public void DoDummyWork()
        {
            el.WriteEntry("Started dummy work");
            for (Int64 i = 1; i < 10000000000; i++)
            {

            }
            el.WriteEntry("Finished dummy work");
        }
    }

    public class MyAppHost : MarshalByRefObject
    {
        private EventLog el;
        public string RenderHomeIndexAction()
        {
            string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
            string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
            string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
            int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
            int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
            el = new System.Diagnostics.EventLog(eventLogFile);
            el.Source = eventLogFile;
            string retVal = "";
            try
            {
                el.WriteEntry("Started process");

                ICustomSession CustomSession = new CustomSession();

                CloudCompareContext _context = new CloudCompareContext();
                ICloudCompareRepository _repository = new QueryRepository(_context);
                CloudApplicationModel localDestination;

                List<CloudApplicationRequest> requests = _repository.GetUnservicedCloudApplicationRequests().ToList();

                //HomeController hc = new HomeController(null, _repository);
                var controller = new HomeController(null, _repository);
                //var controller = new AccountController();
                using (var writer = new StringWriter())
                {
                    try
                    {
                        //var httpContext = new HttpContext(new HttpRequest("", "http://localhost:3785", ""), new HttpResponse(writer));
                        var httpContext = new HttpContext(new HttpRequest("", webSiteLocationContext, ""), new HttpResponse(writer));
                        if (HttpContext.Current != null) throw new NotSupportedException("httpcontext was already set");
                        HttpContext.Current = httpContext;
                        var controllerName = controller.GetType().Name;

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
                            new { controller = "Home", action = "TestMail", id = UrlParameter.Optional } // Parameter defaults
                        );

                        var routeData = new RouteData(routes[5], new MvcRouteHandler());
                        routeData.Values.Add("controller", "Home");
                        routeData.Values.Add("action", razorPageForPDF);
                        
                        var controllerContext = new ControllerContext(new HttpContextWrapper(httpContext), routeData, controller);

                        foreach (CloudApplicationRequest car in requests)
                        {
                            localDestination = controller.ConstructCloudApplicationModel(_repository.GetCloudApplication(car.CloudApplicationID), null);
                            controllerContext.Controller.ViewData.Model = localDestination;
                            var res = controller.PrintResult3();
                            res.ExecuteResult(controllerContext);

                            AdditionalOutput localao = new AdditionalOutput();
                            //localao.OutputFileName = "test.htm";
                            localao.PDFEngineType = PDFEngineType.ASPPDF;

                            Person p = _repository.GetPersonByPersonID(car.PersonID);

                            //string x = sc.SendSearchResultToRAZORAndCreatePDF(destination, 1, "~/documents/", "test.pdf", true, ao);
                            string fileName = localDestination.ServiceName.Trim() + ".pdf";
                            //string x = SendSearchResultToRAZORAndCreatePDF(localDestination, 1, "~/documents/", fileName, true, localao);

                            //MemoryStream y = hc.SendSearchResultToRAZORAndReturnPDFStream(localDestination, 1, "~/documents/", fileName, true, localao);
                            MemoryStream y = controller.SendHTMLStringAndReturnPDFStream(writer.ToString(), 1, null, fileName, true, localao);
                            byte[] b = y.ToArray();
                            //string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/documents/");
                            //System.IO.File.WriteAllBytes(serverFilePath + "test2.pdf", b);
                            SendEmail sm = new SendEmail();
                            y.Position = 0;
                            sm.Execute(p, car, y, fileName);

                            _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);

                        }
                        HttpContext.Current = null;
                        el.WriteEntry("Finished process");
                    }
                    catch (Exception e)
                    {
                        el.WriteEntry("Error in inner process : " + e.Message);
                    }
                    return writer.ToString();
                }
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in outer process : " + e.Message);
                return e.Message;
            }
        }
    }
}
