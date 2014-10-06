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
using CompareCloudware.Web.Helpers;
//using CompareCloudware.Web.Models;
//using CompareCloudware.Web.Controllers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.Domain.Models;
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
using System.Net;
using System.Net.Mail;
using Alpinely.TownCrier;
using System.Runtime;

namespace WSMailPDF
{
    #region NewMailPDF
    public partial class NewMailPDF : ServiceBase
    {
        //private IContainer components;
        private EventLog el;
        private TimerCallback timerDelegate;
        private System.Threading.Timer serviceTimer;
        private string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
        private int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
        private int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
        EMailHost emailHost;
        bool view;
        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        //public ILogger Logger { get; set; }

        public NewMailPDF()
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

        public EventLog Logger
        {
            get
            {
                if (el == null)
                {
                    el = new System.Diagnostics.EventLog(eventLogFile);
                    el.Source = eventLogFile;
                }
                return el;
            }
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

            //myAppHost = (MyAppHost)ApplicationHost.CreateApplicationHost(
            //            typeof(MyAppHost), "/", @"J:\CompareCloudware\CompareCloudware.Web");
            //myAppHost = new MyAppHost(Logger);
            //el = new System.Diagnostics.EventLog(eventLogFile);
            Logger.Source = eventLogFile;
            Logger.WriteEntry("Starting timer");
            timerDelegate = new TimerCallback(DoWork);
            serviceTimer = new System.Threading.Timer(timerDelegate, null, dueTime, interval);
            Logger.WriteEntry("Started timer");
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

        #region DoWork
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
        #endregion

        #region ServiceMail
        public void ServiceMail()
        {
            try
            {
                Logger.WriteEntry("Started ServiceMail");

                Logger.WriteEntry("Loading DI Container");
                IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                Logger.WriteEntry("Loaded DI Container");
                //myAppHost = new MyAppHost(Logger);
                emailHost = (EMailHost)container.Resolve<EMailHost>();
                Logger.WriteEntry("Resolved EMail Host");

                view = emailHost.ServiceCloudApplicationMailRequests();
                Logger.WriteEntry("Finished ServiceMail");
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceMail() : " + e.Message);
            }
        }
        #endregion

        #region DoDummyWork
        public void DoDummyWork()
        {
            el.WriteEntry("Started dummy work");
            for (Int64 i = 1; i < 10000000000; i++)
            {

            }
            el.WriteEntry("Finished dummy work");
        }
        #endregion
    }
    #endregion

    public class CustomWebBrowser
    {
        private CloudApplicationWebBrowserDocumentCompletedEventArgs _args;
        private WebBrowser _browser;
        private EventLog el;
        private string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
        private EventLog _logger;
        private ISendEMail _mail;

        public CustomWebBrowser(CloudApplicationWebBrowserDocumentCompletedEventArgs args, EventLog logger, ISendEMail mail)
        {
            _args = args;
            //_browser = new WebBrowser();
            //_browser.DocumentCompleted += browser_DocumentCompleted;
            //_browser.Navigate(args.Url);
            _logger = logger;
            _mail = mail;

        }

        public CloudApplicationWebBrowserDocumentCompletedEventArgs CloudApplicationWebBrowserDocumentCompletedEventArgs { get; set; }
        public WebBrowser Browser
        {
            get
            {
                return _browser;
            }
            set
            {
                _browser = value;
                _browser.DocumentCompleted += browser_DocumentCompleted;
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //void browser_DocumentCompleted(object sender, CloudApplicationWebBrowserDocumentCompletedEventArgs e)
        {
            //var br = sender as WebBrowser;

            //HtmlElement head = br.Document.GetElementsByTagName("head")[0];
            //string h = head.InnerHtml;

            //if (br.Url == e.Url)
            //{
            //    ServiceCloudApplicationMailRequest(_args);
            //    Console.WriteLine("Natigated to {0}", e.Url);
            //    Application.ExitThread();   // Stops the thread
            //}

            try
            {
                //string razorViewAddress = null;
                //string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                //string htmlPageForPDF = ConfigurationManager.AppSettings["HTMLPageForPDF"];
                byte[] razorViewAsPDF = null;
                string testFileNamePDF = _args.TestFileNamePDF;
                var br = sender as WebBrowser;
                HtmlElement body = br.Document.GetElementsByTagName("html")[0];
                string h = body.OuterHtml;
                if (br.Url == e.Url)
                {
                    AdditionalOutput ao = new AdditionalOutput();
                    ao.OutputFileName = _args.TestFileNameHTML;
                    ao.PDFEngineType = PDFEngineType.ASPPDF;

                    razorViewAsPDF = PDFGenerator.SendHTMLStringAndReturnPDFStream(h, 1, null, null, true, ao).ToArray();
                    _args.RazorViewAsPDF = razorViewAsPDF;
                    ServiceCloudApplicationMailRequest(_args);
                    File.WriteAllBytes(testFileNamePDF, razorViewAsPDF);
                    Console.WriteLine("Natigated to {0}", e.Url);
                    Application.ExitThread();   // Stops the thread
                }
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                _logger.WriteEntry("Error in DocumentCompleted method : " + ex.Message + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
            }
        
        
        
        }

        public void ServiceCloudApplicationMailRequest(CloudApplicationWebBrowserDocumentCompletedEventArgs e)
        {
            string fileName;
            Person p = null;
            MemoryStream y;
            MailRequest mr = null;
            ISendEMail sm = _mail;

            try
            {

                #region SAVE PDF & HTML
                if (e.SaveToTestFile)
                {
                    File.WriteAllBytes(e.TestFileNamePDF, e.RazorViewAsPDF);
                    File.WriteAllText(e.TestFileNameHTML, e.RazorViewAsHTML);
                }
                #endregion

                #region CONSTRUCT EMAIL AND EXECUTE EMAIL

                p = e.Repository.GetPersonByPersonID(e.CloudApplicationRequest.PersonID);

                if (p != null)
                {
                    CloudApplication ca = e.Repository.GetCloudApplicationAsReadOnly(e.CloudApplicationRequest.CloudApplicationID);
                    fileName = ca.Brand.Trim() + " - " + ca.ServiceName.Trim() + ".pdf";
                    y = new MemoryStream(e.RazorViewAsPDF);

                    bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                    if (useTestEMailAddress)
                    {
                        _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                    }
                    mr = new MailRequest()
                    {
                        MailSubject = ConfigurationManager.AppSettings["MailSubject"],
                        MailTo = p.EMail,
                        SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                        SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                        SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                        SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                        SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                        SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                        SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),
                        MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceName"],
                        MailTemplateResourceTokens = new Dictionary<string, string>()
                                        {
                                            {"CustomerName", p.Forename.Trim() + (p.Surname != null ? " " + p.Surname.Trim() : "")},
                                        }
                    };

                    _logger.WriteEntry("Sending email to address : " + p.EMail + " for application: " + fileName + " for REQUEST ID:" + e.CloudApplicationRequest.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                    sm.Execute(p, e.CloudApplicationRequest, mr, y, fileName);
                    _logger.WriteEntry("Successfully sent email to address : " + p.EMail + " for application: " + fileName + " for REQUEST ID:" + e.CloudApplicationRequest.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                }
                else
                {
                    _logger.WriteEntry("Could not locate person ID for request ID " + e.CloudApplicationRequest.PersonID.ToString(), EventLogEntryType.Error);
                }
                #endregion

                #region MARK REQUEST AS SERVICED
                e.Repository.MarkCloudApplicationRequestAsServiced(e.CloudApplicationRequest.CloudApplicationRequestID);
                #endregion
            }
            catch (SmtpException ex)
            {
                #region SMTP ERROR
                if (p != null)
                {
                    _logger.WriteEntry("Error in emailing PDF web page to " + p.EMail + " for REQUEST ID:" + e.CloudApplicationRequest.CloudApplicationRequestID.ToString() + " : " + ex.Message + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                    _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                    _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                    _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                    _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                    _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                    _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);
                }
                else
                {
                    _logger.WriteEntry("Error in emailing PDF web page for request ID " + e.CloudApplicationRequest.CloudApplicationRequestID.ToString() + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                    _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                    _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                    _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                    _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                    _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                    _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);

                }
                #endregion
                e.Repository.MarkCloudApplicationRequestAsServiced(e.CloudApplicationRequest.CloudApplicationRequestID);
            }
            catch (Exception ex)
            {
                int x = 1;
            }
        }

    }

    public class CloudApplicationWebBrowserDocumentCompletedEventArgs : WebBrowserDocumentCompletedEventArgs
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public CloudApplicationWebBrowserDocumentCompletedEventArgs(Uri url)
            : base(url)
        {

        }

        public bool SaveToTestFile { get; set; }
        public string TestFileNamePDF { get; set; }
        public string TestFileNameHTML { get; set; }
        public byte[] RazorViewAsPDF { get; set; }
        public string RazorViewAsHTML { get; set; }
        public ICompareCloudwareRepository Repository { get; set; }
        public CloudApplicationRequest CloudApplicationRequest { get; set; }
    }

    public class EMailHost
    {
        private EventLog _logger;
        private ISendEMail _mail;

        public EMailHost(EventLog logger, ISendEMail mail)
        {
            if (logger.Source == null)
            {
                throw new Exception("Source must be set on the event logger");
            }
            _logger = logger;
            _mail = mail;
        }


        #region ServiceCloudApplicationMailRequests
        public bool ServiceCloudApplicationMailRequests()
        {
            try
            {
                string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
                string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
                string razorPageForHTML = ConfigurationManager.AppSettings["RazorPageForHTML"];
                int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
                int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
                bool saveToTestFile = Convert.ToBoolean(ConfigurationManager.AppSettings["SaveToTestFile"]);
                string testFileNamePDF = ConfigurationManager.AppSettings["TestFileName"];
                string testFileNameHTML = ConfigurationManager.AppSettings["TestFileNameAsHTML"];
                string razorPageSourceName = ConfigurationManager.AppSettings["RazorPageSourceName"];

                ICompareCloudwareContext _context;
                ICompareCloudwareRepository _repository = null;
                List<CloudApplicationRequest> requests = null;
                _logger.Source = eventLogFile;
                _logger.WriteEntry("Started servicing process");

                #region DI
                try
                {
                    IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                    //HomeController hc = container.Resolve<HomeController>();
                    _context = container.Resolve<CompareCloudwareContext>();
                    _repository = container.Resolve<QueryRepository>();
                    _logger.WriteEntry("Sussessfully resolved DI");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in DI : " + e.Message, EventLogEntryType.Error);
                }
                #endregion

                _logger.WriteEntry("Getting cloud application email requests");

                #region GET UNSERVICED REQUESTS
                try
                {
                    if (_repository != null)
                    {
                        //_logger.WriteEntry("Getting a currency...");
                        //var test = _repository.GetCurrencyBySymbol("£");
                        //_logger.WriteEntry("Successfully called database");
                        //_logger.WriteEntry("Successfully fetched a currency : " + test.CurrencyName);

                        requests = _repository.GetUnservicedCloudApplicationPDFRequests().ToList();
                        _logger.WriteEntry("Successfully fetched " + requests.Count.ToString() + " email requests.");
                    }
                    else
                    {
                        _logger.WriteEntry("Could not set repository", EventLogEntryType.Error);
                    }
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    Exception inner = e.InnerException;
                    while (inner != null)
                    {
                        message += "INNER EXCEPTION MESSAGE : " + inner.Message;
                        inner = inner.InnerException;
                    }
                    _logger.WriteEntry("Error in fetching unserviced requests : " + message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                #endregion

                byte[] razorViewAsPDF = null;
                string razorViewAsHTML = null;
                string razorViewAddress = null;

                try
                {
                    foreach (CloudApplicationRequest car in requests)
                    {
                        try
                        {
                            #region CONSTRUCT RAZOR VIEW AS BYTES
                            try
                            {
                                razorViewAddress = webSiteLocationContext + "/" + razorPageForPDF + "?cloudApplicationID=" + car.CloudApplicationID.ToString() + "&personID=" + car.PersonID.ToString() + "&pageName=" + razorPageSourceName + "&saveCopy=" + saveToTestFile;
                                _logger.WriteEntry("Constructing razor view for " + razorViewAddress);
                                using (WebClient wc = new WebClient())
                                {
                                    //razorViewAsPDF = wc.DownloadData("http://localhost:81/Home.mvc/PrintResult3?cloudApplicationID=" + car.CloudApplicationID);
                                    //razorViewAsPDF = wc.DownloadData(webSiteLocationContext + "/" + razorPageForPDF + "?cloudApplicationID=" + car.CloudApplicationID);
                                    razorViewAsPDF = wc.DownloadData(razorViewAddress);
                                }
                            }
                            catch (Exception e)
                            {
                                _logger.WriteEntry("Could not construct razor page. The error was : " + e.Message, EventLogEntryType.Error);
                            }
                            #endregion

                            #region CONSTRUCT RAZOR VIEW AS HTML
                            try
                            {
                                razorViewAddress = webSiteLocationContext + "/" + razorPageForHTML + "?cloudApplicationID=" + car.CloudApplicationID.ToString() + "&personID=" + car.PersonID.ToString() + "&pageName=" + razorPageSourceName;
                                _logger.WriteEntry("Constructing razor view for " + razorViewAddress);
                                using (WebClient wc = new WebClient())
                                {
                                    //razorViewAsPDF = wc.DownloadData("http://localhost:81/Home.mvc/PrintResult3?cloudApplicationID=" + car.CloudApplicationID);
                                    //razorViewAsPDF = wc.DownloadData(webSiteLocationContext + "/" + razorPageForPDF + "?cloudApplicationID=" + car.CloudApplicationID);
                                    razorViewAsHTML = wc.DownloadString(razorViewAddress);

                                }
                            }
                            catch (Exception e)
                            {
                                _logger.WriteEntry("Could not construct razor page. The error was : " + e.Message, EventLogEntryType.Error);
                            }
                            #endregion

                            
                            //var results = doc.DocumentNode
                            //    .Descendants("div")
                            //    .Select(n => n.InnerText);

                            #region SPIN UP WEB BROWSER WITH URL FOR RAZOR PAGE
                            string url = razorViewAddress;
                            //System.Windows.Forms.WebBrowser browser = new WebBrowser();
                            CloudApplicationWebBrowserDocumentCompletedEventArgs carArgs = new CloudApplicationWebBrowserDocumentCompletedEventArgs(new Uri(url));
                            carArgs.SaveToTestFile = saveToTestFile;
                            carArgs.TestFileNameHTML = testFileNameHTML + car.CloudApplicationRequestID.ToString() + ".htm";
                            carArgs.TestFileNamePDF = testFileNamePDF + car.CloudApplicationRequestID.ToString() + ".pdf";
                            carArgs.RazorViewAsHTML = razorViewAsHTML;
                            carArgs.RazorViewAsPDF = razorViewAsPDF;
                            carArgs.Repository = _repository;
                            carArgs.CloudApplicationRequest = car;

                            var th = new Thread(() =>
                            {
                                var br = new CustomWebBrowser(carArgs,_logger,_mail);
                                br.Browser = new WebBrowser();
                                //br.Browser.DocumentCompleted += browser_DocumentCompleted;
                                br.Browser.Navigate(url);
                                Application.Run();

                                //WebBrowser br = new WebBrowser();
                                //br.DocumentCompleted += browser_DocumentCompleted;
                                //br.Navigate(url);
                                //Application.Run();
                                _logger.WriteEntry("Spinning up browser thread");
                            });
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            _logger.WriteEntry("Spun up browser thread");

                            #endregion

                            //while (th.ThreadState == System.Threading.ThreadState.Running)
                            {
                                int x = 1;
                                //Thread.Sleep(1000);
                            }
                            int y = 1;
                        }
                        catch (WebException e)
                        {
                            _logger.WriteEntry("Error in fetching PDF web page for request ID " + car.CloudApplicationRequestID.ToString() + " : " + e.Message, EventLogEntryType.Error);
                        }
                        catch (Exception e)
                        {
                            _logger.WriteEntry("Error in servicing request ID : " + e.Message, EventLogEntryType.Error);
                        }
                    }


                    _logger.WriteEntry("Finished servicing process");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in overall servicing process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                return true;
            }
            catch (Exception e)
            {
                _logger.WriteEntry("Error in starting process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //void browser_DocumentCompleted(object sender, CloudApplicationWebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                //string razorViewAddress = null;
                //string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                //string htmlPageForPDF = ConfigurationManager.AppSettings["HTMLPageForPDF"];
                byte[] razorViewAsPDF = null;
                string testFileNamePDF = ConfigurationManager.AppSettings["TestFileName"];
                var br = sender as WebBrowser;
                HtmlElement body = br.Document.GetElementsByTagName("html")[0];
                string h = body.OuterHtml;
                if (br.Url == e.Url)
                {
                    AdditionalOutput ao = new AdditionalOutput();
                    ao.OutputFileName = "test.htm";
                    ao.PDFEngineType = PDFEngineType.ASPPDF;

                    razorViewAsPDF = PDFGenerator.SendHTMLStringAndReturnPDFStream(h, 1, null, null, true, ao).ToArray();
                    //ServiceCloudApplicationMailRequest(br.CloudApplicationWebBrowserDocumentCompletedEventArgs);
                    File.WriteAllBytes(testFileNamePDF, razorViewAsPDF);
                    Console.WriteLine("Natigated to {0}", e.Url);
                    Application.ExitThread();   // Stops the thread
                }
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                _logger.WriteEntry("Error in DocumentCompleted method : " + ex.Message + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
            }
        }

    }



    #region MAILREQUEST CLASS
    public class MailRequest
    {
        public string MailTemplateResourceName { get; set; }
        public Dictionary<string, string> MailTemplateResourceTokens { get; set; }
        public string MailTo { get; set; }
        public string MailSubject { get; set; }
        public string SMTPClientUserDisplayName { get; set; }
        public string SMTPClientHost { get; set; }
        public string SMTPClientUserEMailAddress { get; set; }
        public string SMTPNetworkCredentialsClientUserID { get; set; }
        public string SMTPNetworkCredentialsClientUserPassword { get; set; }
        public bool SMTPEnableSSL { get; set; }
        public int SMTPPort { get; set; }
    }
    #endregion

    #region SENDEMAIL
    public interface ISendEMail
    {
        bool Execute(Person p, CloudApplicationRequest car, MailRequest mr, Stream attachment, string attachmentName);
    }

    public class SendEMail : ISendEMail
    //public class SendEmail
    {
        //private readonly IDataAccess _dataAccess;

        //public SendEmail(IDataAccess dataAccess)
        //{
        //    _dataAccess = dataAccess;
        //}

        //public void Execute(JobExecutionContext context)
        //public void Execute(Case newCase, User user)
        public bool Execute(Person p, CloudApplicationRequest car, MailRequest mr, Stream attachment, string attachmentName)
        {
            bool retVal = true;
            try
            {
                //string templateResourceName;
                //templateResourceName = @"CompareCloudware.Web.Helpers.Receipt.txt";

                //string subject = "Your requested cloudware application is attached";

                //switch (emailType)
                //{
                //    case EmailType.CarRented:
                //        templateResourceName = @"AvisDenmark.ApplicationServices.EmailTemplates.CarRentalEmail.txt";
                //        subject = "Car has been rented";
                //        break;
                //    case EmailType.CarReturned:
                //        templateResourceName = @"AvisDenmark.ApplicationServices.EmailTemplates.CarReturnedEmail.txt";
                //        subject = "Car has been returned";
                //        break;
                //    default:
                //        throw new InvalidOperationException("Invalid email type");
                //}

                var templateStream = this.GetType().Assembly.GetManifestResourceStream(mr.MailTemplateResourceName);
                var sr = new StreamReader(templateStream);
                var template = sr.ReadToEnd();

                var factory = new MergedEmailFactory(new TemplateParser());

                var tokenValues = mr.MailTemplateResourceTokens;

                MailMessage message = factory
                    .WithTokenValues(tokenValues)
                    .WithSubject(mr.MailSubject)
                    .WithMarkdownBody(template)
                    .Create();

                message.From = new MailAddress(mr.SMTPClientUserEMailAddress, mr.SMTPClientUserDisplayName);
                message.To.Add(p.EMail);
                //message.CC.Add("protechdm@btopenworld.com");

                Attachment a = new Attachment(attachment, attachmentName);
                message.Attachments.Add(a);

                var smtpClient = new SmtpClient();
                smtpClient.Host = mr.SMTPClientHost;
                smtpClient.Credentials = new NetworkCredential(mr.SMTPNetworkCredentialsClientUserID, mr.SMTPNetworkCredentialsClientUserPassword);
                smtpClient.EnableSsl = mr.SMTPEnableSSL;
                //smtpClient.Port = mr.SMTPPort;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtpClient.Send(message);
            }
            catch (SmtpException e)
            {
                retVal = false;
                
                throw new SmtpException(e.Message);
            }
            catch (Exception e)
            {
                retVal = false;
                throw new Exception(e.Message);
            }
            return retVal;
        }
    }
    #endregion

}
