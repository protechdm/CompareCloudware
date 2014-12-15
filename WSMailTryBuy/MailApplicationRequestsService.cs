using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
//using System.Windows.Forms;
using System.IO;
//using Castle.Core.Logging;
//using CompareCloudware.Web;
//using CompareCloudware.Web.Helpers;
//using CompareCloudware.Web.Models;
using CompareCloudware.Web.Controllers;
using CompareCloudware.Web.Helpers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.Domain.Models;
using CompareCloudware.Web.Models.EMailTemplateModels;
using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;
//using System.Web.Hosting;
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

namespace WSMailTryBuy
{
    #region MailTryBuy
    public partial class MailApplicationRequestsService : ServiceBase
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

        public MailApplicationRequestsService()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.el = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.el)).BeginInit();
            // 
            // MailApplicationRequestsService
            // 
            this.ServiceName = "COMPARE CLOUDWARE APPLICATION REQUESTS EMAILER";
            ((System.ComponentModel.ISupportInitialize)(this.el)).EndInit();


            //try
            //{
            if (!System.Diagnostics.EventLog.SourceExists(eventLogFile))
            {

                System.Diagnostics.EventLog.CreateEventSource(eventLogFile, eventLogFile);
            }
            Logger.Source = eventLogFile;

            Logger.WriteEntry("BOLLCOKS");
            //}
            //catch (Exception e)
            //{
            //    eventLogFile = "Application";

            //}
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
            Logger.WriteEntry("Starting APPLICATION REQUESTS EMAILER timer");
            timerDelegate = new TimerCallback(DoWork);
            serviceTimer = new System.Threading.Timer(timerDelegate, null, dueTime, interval);
            Logger.WriteEntry("Started APPLICATION REQUESTS EMAILER timer");
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
                ServiceTryBuy();
                ServicePartnerProgramme();
                ServiceSendToColleague();
                //DoDummyWork();
                serviceTimer.Change(dueTime, interval);
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in DoWork() : " + e.Message);
            }
        }
        #endregion

        #region ServiceTryBuy
        public void ServiceTryBuy()
        {
            try
            {
                Logger.WriteEntry("Started APPLICATION REQUESTS EMAILER ServiceMail");

                Logger.WriteEntry("Loading APPLICATION REQUESTS EMAILER DI Container");
                IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                Logger.WriteEntry("Loaded APPLICATION REQUESTS EMAILER DI Container");
                //myAppHost = new MyAppHost(Logger);
                emailHost = (EMailHost)container.Resolve<EMailHost>();
                Logger.WriteEntry("Resolved APPLICATION REQUESTS EMAILER EMail Host");

                view = emailHost.ServiceTryBuyMailRequests();
                Logger.WriteEntry("Finished ServiceMail");
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceMail() : " + e.Message);
            }
        }
        #endregion

        #region ServicePartnerProgramme
        public void ServicePartnerProgramme()
        {
            try
            {
                Logger.WriteEntry("Started PARTNER PROGRAMME EMAILER ServiceMail");

                Logger.WriteEntry("Loading PARTNER PROGRAMME EMAILER DI Container");
                IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                Logger.WriteEntry("Loaded PARTNER PROGRAMME EMAILER DI Container");
                //myAppHost = new MyAppHost(Logger);
                emailHost = (EMailHost)container.Resolve<EMailHost>();
                Logger.WriteEntry("Resolved PARTNER PROGRAMME EMAILER EMail Host");

                view = emailHost.ServicePartnerProgrammeMailRequests();
                Logger.WriteEntry("Finished ServicePartnerProgrammeMailRequests");
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceBusinessPartner() : " + e.Message);
            }
        }
        #endregion

        #region ServiceSendToColleague
        public void ServiceSendToColleague()
        {
            try
            {
                Logger.WriteEntry("Started SEND TO COLLEAGUE EMAILER ServiceMail");

                Logger.WriteEntry("Loading SEND TO COLLEAGUE EMAILER DI Container");
                IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                Logger.WriteEntry("Loaded SEND TO COLLEAGUE EMAILER DI Container");
                //myAppHost = new MyAppHost(Logger);
                emailHost = (EMailHost)container.Resolve<EMailHost>();
                Logger.WriteEntry("Resolved SEND TO COLLEAGUE EMAILER EMail Host");

                view = emailHost.ServiceSendToColleagueMailRequests();
                Logger.WriteEntry("Finished ServiceSendToColleagueMailRequests");
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceSendToColleagueMailRequests() : " + e.Message);
            }
        }
        #endregion

    }
    #endregion

    public class EMailHost
    {
        private EventLog _logger;
        private ISendEMail _mail;
        private static readonly int BusinessPartnerID = int.Parse(ConfigurationManager.AppSettings["BusinessPartnerID"]);
        private static readonly int StrategicPartnerID = int.Parse(ConfigurationManager.AppSettings["StrategicPartnerID"]);
        private static readonly int ReferRewardPartnerID = int.Parse(ConfigurationManager.AppSettings["ReferRewardPartnerID"]);
        private static readonly int MailColleagueID = int.Parse(ConfigurationManager.AppSettings["SendToColleagueID"]);

        public EMailHost(EventLog logger, ISendEMail mail)
        {
            if (logger.Source == null)
            {
                throw new Exception("Source must be set on the event logger");
            }
            _logger = logger;
            _mail = mail;
        }


        #region ServiceTryBuyMailRequests
        public bool ServiceTryBuyMailRequests()
        {
            try
            {
                string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
                //string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                //string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
                //string razorPageForHTML = ConfigurationManager.AppSettings["RazorPageForHTML"];
                //int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
                //int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
                //bool saveToTestFile = Convert.ToBoolean(ConfigurationManager.AppSettings["SaveToTestFile"]);
                //string testFileNamePDF = ConfigurationManager.AppSettings["TestFileName"];
                //string testFileNameHTML = ConfigurationManager.AppSettings["TestFileNameAsHTML"];
                //string razorPageSourceName = ConfigurationManager.AppSettings["RazorPageSourceName"];

                ICompareCloudwareContext _context;
                ICompareCloudwareRepository _repository = null;
                List<CloudApplicationRequest> requests = null;
                _logger.Source = eventLogFile;
                _logger.WriteEntry("Started TRY/BUY EMAILER servicing process");

                #region DI
                try
                {
                    IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                    //HomeController hc = container.Resolve<HomeController>();
                    _context = container.Resolve<CompareCloudwareContext>();
                    _repository = container.Resolve<QueryRepository>();
                    _logger.WriteEntry("Successfully resolved TRY/BUY EMAILER DI");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in TRY/BUY EMAILER DI : " + e.Message, EventLogEntryType.Error);
                }
                #endregion

                _logger.WriteEntry("Getting TRY/BUY EMAILER email support requests");

                #region GET UNSERVICED REQUESTS
                try
                {
                    if (_repository != null)
                    {
                        //_logger.WriteEntry("Getting a currency...");
                        //var test = _repository.GetCurrencyBySymbol("£");
                        //_logger.WriteEntry("Successfully called database");
                        //_logger.WriteEntry("Successfully fetched a currency : " + test.CurrencyName);

                        requests = _repository.GetUnservicedCloudApplicationTryBuyRequests().ToList();
                        _logger.WriteEntry("Successfully fetched " + requests.Count.ToString() + " TRY/BUY EMAILER email requests.");
                    }
                    else
                    {
                        _logger.WriteEntry("Could not set TRY/BUY EMAILER repository", EventLogEntryType.Error);
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
                    _logger.WriteEntry("Error in fetching TRY/BUY unserviced requests : " + message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                #endregion
                try
                {
                    foreach (CloudApplicationRequest car in requests)
                    {
                        try
                        {
                            ServiceTryBuyMailRequest(car, _repository);
                        }
                        catch (Exception e)
                        {
                            _logger.WriteEntry("Error in servicing TRY/BUY EMAILER request ID : " + e.Message, EventLogEntryType.Error);
                        }
                    }


                    _logger.WriteEntry("Finished TRY/BUY EMAILER servicing process");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in overall servicing process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                _context = null;
                _repository = null;
                requests = null;

                return true;
            }
            catch (Exception e)
            {
                _logger.WriteEntry("Error in starting TRY/BUY EMAILER process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        #region ServiceTryBuyMailRequest
        private void ServiceTryBuyMailRequest(CloudApplicationRequest car, ICompareCloudwareRepository _repository)
        {
            MailRequest mr = null;
            ISendEMail sm = _mail;

            try
            {


                #region CONSTRUCT EMAIL AND EXECUTE EMAIL
                if (car.PersonID != null)
                {
                    bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                    if (useTestEMailAddress)
                    {
                        _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                    }

                    string mailTo = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPMailTo"] : ConfigurationManager.AppSettings["SMTPMailToTest"];

                    Person p = _repository.GetPersonByPersonID(car.PersonID);
                    if (p == null)
                    {
                        throw new Exception("Could not find person in repository with ID : " + car.PersonID.ToString());
                    }

                    CloudApplication ca = _repository.GetCloudApplicationAsReadOnly(car.CloudApplicationID);
                    if (ca == null)
                    {
                        throw new Exception("Could not find cloud application in repository with ID : " + car.CloudApplicationID.ToString());
                    }

                    mr = new MailRequest()
                    {
                        MailTo = mailTo,
                        SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                        SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                        SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                        SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                        SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                        SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                        SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),

                        MailTemplateResourceTokens = new Dictionary<string, string>()
                        {
                            {"FirstName", p.Forename.Trim()},
                            {"Surname", p.Surname},
                            {"Position", p.Position},
                            {"Company", p.Company},
                            {"EMail", p.EMail},
                            {"Telephone", p.Telephone},
                            {"Country", p.PersonCountry},
                            {"CloudApplication", ca.Brand + " - " + ca.ServiceName},
                            {"NumberOfUsers", ca.LicenceTypeMinimum.LicenceTypeMinimumName + " - " + ca.LicenceTypeMaximum.LicenceTypeMaximumName},
                        }
                    };

                    if (car.RequestTypeID == 1)
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameTry"];
                        mr.MailSubject = ConfigurationManager.AppSettings["MailSubjectTry"] + " for " + ca.Brand + " - " + ca.ServiceName + " (" + ca.CloudApplicationID.ToString() + ")";
                    }
                    else if (car.RequestTypeID == 2)
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                        mr.MailSubject = ConfigurationManager.AppSettings["MailSubjectBuy"] + " for " + ca.Brand + " - " + ca.ServiceName + " (" + ca.CloudApplicationID.ToString() + ")";
                    }
                    else
                    {
                        throw new Exception("Invalid request type");
                    }

                    _logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                    sm.Execute(p, mr);
                    _logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);

                    p = null;
                    ca = null;
                    mr = null;

                }
                else
                {
                    _logger.WriteEntry("Could not locate person ID for request ID " + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Error);
                }
                #endregion

                #region MARK REQUEST AS SERVICED
                _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
                #endregion
            }
            catch (SmtpException ex)
            {
                #region SMTP ERROR
                _logger.WriteEntry("Error in emailing confirmation for request ID " + car.CloudApplicationRequestID.ToString() + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);
                #endregion
                _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
            }
            catch (Exception ex)
            {
                _logger.WriteEntry("General error :" + ex.Message + " - Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                int x = 1;
            }
        }
        #endregion

        #region ServicePartnerProgrammeMailRequests
        public bool ServicePartnerProgrammeMailRequests()
        {
            try
            {
                string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
                string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                //string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
                string razorPageForHTML = null;
                int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
                int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
                bool saveToTestFile = Convert.ToBoolean(ConfigurationManager.AppSettings["SaveToTestFile"]);
                string testFileNamePDF = ConfigurationManager.AppSettings["TestFileName"];
                string testFileNameHTML = ConfigurationManager.AppSettings["TestFileNameAsHTML"];
                //string razorPageSourceName = ConfigurationManager.AppSettings["RazorPageSourceName"];
                HomeController hc = null;

                ICompareCloudwareContext _context;
                ICompareCloudwareRepository _repository = null;
                List<CloudApplicationRequest> requests = null;
                _logger.Source = eventLogFile;
                _logger.WriteEntry("Started PARTNER PROGRAMME EMAILER servicing process");

                #region DI
                try
                {
                    IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                    //hc = container.Resolve<HomeController>();
                    _context = container.Resolve<CompareCloudwareContext>();
                    _repository = container.Resolve<QueryRepository>();
                    hc = new HomeController(null, _repository, null);
                    _logger.WriteEntry("Successfully resolved PARTNER PROGRAMME EMAILER DI");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in PARTNER PROGRAMME EMAILER DI : " + e.Message, EventLogEntryType.Error);
                }
                #endregion

                _logger.WriteEntry("Getting PARTNER PROGRAMME EMAILER email support requests");

                #region GET UNSERVICED REQUESTS
                try
                {
                    if (_repository != null)
                    {
                        requests = _repository.GetUnservicedBusinessPartnerRequests()
                            .Union(_repository.GetUnservicedStrategicPartnerRequests())
                            .Union(_repository.GetUnservicedReferRewardRequests())

                            .ToList();
                        ;
                        _logger.WriteEntry("Successfully fetched " + requests.Count.ToString() + " PARTNER PROGRAMME EMAILER email requests.");
                    }
                    else
                    {
                        _logger.WriteEntry("Could not set PARTNER PROGRAMME EMAILER repository", EventLogEntryType.Error);
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
                    _logger.WriteEntry("Error in fetching PARTNER PROGRAMME unserviced requests : " + message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
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
                            #region CONSTRUCT RAZOR VIEW AS HTML
                            try
                            {
                                switch (car.RequestTypeID)
                                {
                                    case (int)RequestTypeEnum.BusinessPartner: razorPageForHTML = ConfigurationManager.AppSettings["BusinessPartnerControllerActionForHTML"];
                                        break;
                                    case (int)RequestTypeEnum.StrategicPartner: razorPageForHTML = ConfigurationManager.AppSettings["StrategicPartnerControllerActionForHTML"];
                                        break;
                                    case (int)RequestTypeEnum.ReferRewardPartner: razorPageForHTML = ConfigurationManager.AppSettings["ReferRewardControllerActionForHTML"];
                                        break;

                                }

                                if (razorPageForHTML != null)
                                {
                                    razorViewAddress = webSiteLocationContext + "/" + razorPageForHTML + "?cloudApplicationRequestID=" + car.CloudApplicationRequestID.ToString();
                                    _logger.WriteEntry("Constructing razor view for " + razorViewAddress);
                                    using (WebClient wc = new WebClient())
                                    {
                                        razorViewAsHTML = wc.DownloadString(razorViewAddress);

                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                _logger.WriteEntry("Could not construct razor page. The error was : " + e.Message, EventLogEntryType.Error);
                            }
                            #endregion

                            ServicePartnerProgrammeMailRequest(razorViewAsHTML, car, _repository);

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

        #region ServicePartnerProgrammeMailRequest
        private void ServicePartnerProgrammeMailRequest(string html, CloudApplicationRequest car, ICompareCloudwareRepository _repository)
        {
            MailRequest mr = null;
            ISendEMail sm = _mail;

            try
            {


                #region CONSTRUCT EMAIL AND EXECUTE EMAIL TO CC - DEPRECATED
                //bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                //if (useTestEMailAddress)
                //{
                //    _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                //}

                //string mailTo = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPMailTo"] : ConfigurationManager.AppSettings["SMTPMailToTest"];

                //mr = new MailRequest()
                //{
                //    MailTo = mailTo,
                //    SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                //    SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                //    SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                //    SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                //    SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                //    SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                //    SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),
                //};

                //if (car.RequestTypeID == BusinessPartnerID)
                //{
                //    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameTry"];
                //    mr.MailSubject = ConfigurationManager.AppSettings["BusinessPartnerMailSubject"];
                //}
                //else if (car.RequestTypeID == StrategicPartnerID)
                //{
                //    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                //    mr.MailSubject = ConfigurationManager.AppSettings["StrategicPartnerMailSubject"];
                //}
                //else if (car.RequestTypeID == ReferRewardPartnerID)
                //{
                //    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                //    mr.MailSubject = ConfigurationManager.AppSettings["ReferRewardPartnerMailSubject"];
                //}
                //else
                //{
                //    throw new Exception("Invalid request type");
                //}

                //_logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                //sm.Execute(html, mr);
                //_logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);

                //mr = null;

                #endregion

                bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                string mailTo = null;

                #region CONSTRUCT EMAIL AND EXECUTE EMAIL
                if (car.PersonID != null)
                {
                    if (useTestEMailAddress)
                    {
                        _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                    }

                    mailTo = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPPartnerProgrammeReceiptMailTo"] : ConfigurationManager.AppSettings["SMTPMailToTest"];

                    Person p = _repository.GetPersonByPersonID(car.PersonID);
                    if (p == null)
                    {
                        throw new Exception("Could not find person in repository with ID : " + car.PersonID.ToString());
                    }

                    mr = new MailRequest()
                    {
                        MailTo = mailTo,
                        SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                        SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                        SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                        SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                        SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                        SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                        SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),

                        MailTemplateResourceTokens = new Dictionary<string, string>()
                        {
                            {"FirstName", p.Forename.Trim()},
                            {"Surname", p.Surname},
                            {"Position", p.Position},
                            {"Company", p.Company},
                            {"EMail", p.EMail},
                            {"Telephone", p.Telephone},
                            {"Country", p.PersonCountry},
                        }
                    };

                    if (car.RequestTypeID == 4)
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBusinessPartner"];
                        mr.MailSubject = ConfigurationManager.AppSettings["BusinessPartnerReceiptMailSubject"];
                    }
                    else if (car.RequestTypeID == 5)
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameStrategicPartner"];
                        mr.MailSubject = ConfigurationManager.AppSettings["StrategicPartnerReceiptMailSubject"];
                    }
                    else if (car.RequestTypeID == 6)
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameReferRewardPartner"];
                        mr.MailSubject = ConfigurationManager.AppSettings["ReferRewardPartnerReceiptMailSubject"];
                    }
                    else
                    {
                        throw new Exception("Invalid request type");
                    }

                    _logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                    sm.Execute(p, mr);
                    _logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);

                    p = null;
                    mr = null;

                }
                else
                {
                    _logger.WriteEntry("Could not locate person ID for request ID " + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Error);
                }
                #endregion

                #region CONSTRUCT EMAIL AND EXECUTE EMAIL TO REQUESTOR
                useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                if (useTestEMailAddress)
                {
                    _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                }

                mailTo = _repository.GetPersonByPersonID(car.PersonID).EMail;

                mr = new MailRequest()
                {
                    MailTo = mailTo,
                    SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                    SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                    SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                    SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                    SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                    SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                    SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),
                };

                if (car.RequestTypeID == BusinessPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameTry"];
                    mr.MailSubject = ConfigurationManager.AppSettings["BusinessPartnerMailSubject"];
                }
                else if (car.RequestTypeID == StrategicPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                    mr.MailSubject = ConfigurationManager.AppSettings["StrategicPartnerMailSubject"];
                }
                else if (car.RequestTypeID == ReferRewardPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                    mr.MailSubject = ConfigurationManager.AppSettings["ReferRewardPartnerMailSubject"];
                }
                else
                {
                    throw new Exception("Invalid request type");
                }

                _logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                sm.Execute(html, mr);
                _logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);

                mr = null;

                #endregion

                #region MARK REQUEST AS SERVICED
                _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
                #endregion
            }
            catch (SmtpException ex)
            {
                #region SMTP ERROR
                //_logger.WriteEntry("Error in emailing confirmation for request ID " + car.CloudApplicationRequestID.ToString() + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);
                #endregion
                //_repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
            }
            catch (Exception ex)
            {
                _logger.WriteEntry("General error :" + ex.Message + " - Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                int x = 1;
            }
        }
        #endregion

        #region ServiceSendToColleagueMailRequests
        public bool ServiceSendToColleagueMailRequests()
        {
            try
            {
                string eventLogFile = ConfigurationManager.AppSettings["EventLogFile"];
                string webSiteLocationContext = ConfigurationManager.AppSettings["WebSiteLocationContext"];
                //string razorPageForPDF = ConfigurationManager.AppSettings["RazorPageForPDF"];
                string razorPageForHTML = null;
                int dueTime = int.Parse(ConfigurationManager.AppSettings["DueTime"]);
                int interval = int.Parse(ConfigurationManager.AppSettings["Interval"]);
                bool saveToTestFile = Convert.ToBoolean(ConfigurationManager.AppSettings["SaveToTestFile"]);
                string testFileNamePDF = ConfigurationManager.AppSettings["TestFileName"];
                string testFileNameHTML = ConfigurationManager.AppSettings["TestFileNameAsHTML"];
                //string razorPageSourceName = ConfigurationManager.AppSettings["RazorPageSourceName"];
                HomeController hc = null;

                ICompareCloudwareContext _context;
                ICompareCloudwareRepository _repository = null;
                List<CloudApplicationRequest> requests = null;
                _logger.Source = eventLogFile;
                _logger.WriteEntry("Started SEND TO COLLEAGUE EMAILER servicing process");

                #region DI
                try
                {
                    IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                    //hc = container.Resolve<HomeController>();
                    _context = container.Resolve<CompareCloudwareContext>();
                    _repository = container.Resolve<QueryRepository>();
                    hc = new HomeController(null, _repository, null);
                    _logger.WriteEntry("Successfully resolved SEND TO COLLEAGUE EMAILER DI");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in SEND TO COLLEAGUE EMAILER DI : " + e.Message, EventLogEntryType.Error);
                }
                #endregion

                _logger.WriteEntry("Getting SEND TO COLLEAGUE EMAILER email support requests");

                #region GET UNSERVICED REQUESTS
                try
                {
                    if (_repository != null)
                    {
                        requests = _repository.GetUnservicedSendToColleagueRequests()
                            .ToList();
                        ;
                        _logger.WriteEntry("Successfully fetched " + requests.Count.ToString() + " SEND TO COLLEAGUE EMAILER email requests.");
                    }
                    else
                    {
                        _logger.WriteEntry("Could not set SEND TO COLLEAGUE EMAILER repository", EventLogEntryType.Error);
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
                    _logger.WriteEntry("Error in fetching SEND TO COLLEAGUE unserviced requests : " + message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
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
                            #region CONSTRUCT RAZOR VIEW AS HTML
                            try
                            {
                                switch (car.RequestTypeID)
                                {
                                    case (int)RequestTypeEnum.BusinessPartner: razorPageForHTML = ConfigurationManager.AppSettings["BusinessPartnerControllerActionForHTML"];
                                        break;
                                    case (int)RequestTypeEnum.StrategicPartner: razorPageForHTML = ConfigurationManager.AppSettings["StrategicPartnerControllerActionForHTML"];
                                        break;
                                    case (int)RequestTypeEnum.ReferRewardPartner: razorPageForHTML = ConfigurationManager.AppSettings["ReferRewardPartnerControllerActionForHTML"];
                                        break;
                                    case (int)RequestTypeEnum.SendToColleague: razorPageForHTML = ConfigurationManager.AppSettings["SendToColleagueControllerActionForHTML"];
                                        break;

                                }

                                if (razorPageForHTML != null)
                                {
                                    razorViewAddress = webSiteLocationContext + "/" + razorPageForHTML + "?cloudApplicationRequestID=" + car.CloudApplicationRequestID.ToString();
                                    _logger.WriteEntry("Constructing razor view for " + razorViewAddress);
                                    using (WebClient wc = new WebClient())
                                    {
                                        razorViewAsHTML = wc.DownloadString(razorViewAddress);

                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                _logger.WriteEntry("Could not construct razor page. The error was : " + e.Message, EventLogEntryType.Error);
                            }
                            #endregion

                            ServiceSendToColleagueMailRequest(razorViewAsHTML, car, _repository);

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

        #region ServiceSendToColleagueMailRequest
        private void ServiceSendToColleagueMailRequest(string html, CloudApplicationRequest car, ICompareCloudwareRepository _repository)
        {
            MailRequest mr = null;
            ISendEMail sm = _mail;

            try
            {


                #region CONSTRUCT EMAIL AND EXECUTE EMAIL
                bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                if (useTestEMailAddress)
                {
                    _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                }

                string mailTo = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPMailTo"] : ConfigurationManager.AppSettings["SMTPMailToTest"];

                mr = new MailRequest()
                {
                    MailTo = mailTo,
                    SMTPClientHost = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientHost"] : ConfigurationManager.AppSettings["SMTPClientHostTest"],
                    SMTPClientUserDisplayName = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserDisplayName"] : ConfigurationManager.AppSettings["SMTPClientUserDisplayNameTest"],
                    SMTPClientUserEMailAddress = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPClientUserEMailAddress"] : ConfigurationManager.AppSettings["SMTPClientUserEMailAddressTest"],
                    SMTPNetworkCredentialsClientUserID = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserID"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserIDTest"],
                    SMTPNetworkCredentialsClientUserPassword = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPassword"] : ConfigurationManager.AppSettings["SMTPNetworkCredentialsClientUserPasswordTest"],
                    SMTPEnableSSL = !useTestEMailAddress ? Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSL"]) : Convert.ToBoolean(ConfigurationManager.AppSettings["SMTPEnableSSLTest"]),
                    SMTPPort = !useTestEMailAddress ? int.Parse(ConfigurationManager.AppSettings["SMTPPort"]) : int.Parse(ConfigurationManager.AppSettings["SMTPPortTest"]),
                };

                if (car.RequestTypeID == BusinessPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameTry"];
                    mr.MailSubject = ConfigurationManager.AppSettings["BusinessPartnerMailSubject"];
                }
                else if (car.RequestTypeID == StrategicPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                    mr.MailSubject = ConfigurationManager.AppSettings["StrategicPartnerMailSubject"];
                }
                else if (car.RequestTypeID == ReferRewardPartnerID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                    mr.MailSubject = ConfigurationManager.AppSettings["ReferRewardPartnerMailSubject"];
                }
                else if (car.RequestTypeID == MailColleagueID)
                {
                    //mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameBuy"];
                    var person = _repository.GetPersonByPersonID(car.PersonID);
                    var colleague = _repository.FindRecommender(person.PersonID);

                    mr.MailSubject = colleague.Introducer.Forename + " " + colleague.Introducer.Surname + " " + ConfigurationManager.AppSettings["SendToColleagueMailSubject"];
                }
                else
                {
                    throw new Exception("Invalid request type");
                }

                _logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);
                sm.Execute(html, mr);
                _logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + car.CloudApplicationRequestID.ToString(), EventLogEntryType.Information);

                mr = null;

                #endregion

                #region MARK REQUEST AS SERVICED
                _repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
                #endregion
            }
            catch (SmtpException ex)
            {
                #region SMTP ERROR
                //_logger.WriteEntry("Error in emailing confirmation for request ID " + car.CloudApplicationRequestID.ToString() + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);
                #endregion
                //_repository.MarkCloudApplicationRequestAsServiced(car.CloudApplicationRequestID);
            }
            catch (Exception ex)
            {
                _logger.WriteEntry("General error :" + ex.Message + " - Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                int x = 1;
            }
        }
        #endregion

    }



    #region MAILREQUEST CLASS
    public class MailRequest
    {
        public string MailTemplateResourceName { get; set; }
        public Dictionary<string, string> MailTemplateResourceTokens { get; set; }
        public string MailHTML { get; set; }
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
        bool Execute(Person p, MailRequest mr);
        bool Execute(string html, MailRequest mr);
    }

    public class SendEMail : ISendEMail
    {
        public bool Execute(Person p, MailRequest mr)
        {
            bool retVal = true;
            try
            {
                var templateStream = this.GetType().Assembly.GetManifestResourceStream(mr.MailTemplateResourceName);
                var sr = new StreamReader(templateStream);
                var template = sr.ReadToEnd();

                var factory = new MergedEmailFactory(new TemplateParser());

                var tokenValues = mr.MailTemplateResourceTokens;

                MailMessage message = factory
                    .WithTokenValues(tokenValues)
                    .WithSubject(mr.MailSubject)
                    .WithMarkdownBody(template)
                    //.WithHtmlBodyFromFile
                    .Create();

                message.From = new MailAddress(mr.SMTPClientUserEMailAddress, mr.SMTPClientUserDisplayName);

                string[] addresses = mr.MailTo.Split(';');
                foreach (string address in addresses)
                {
                    message.To.Add(address);
                }

                var smtpClient = new SmtpClient();
                smtpClient.Host = mr.SMTPClientHost;
                smtpClient.Credentials = new NetworkCredential(mr.SMTPNetworkCredentialsClientUserID, mr.SMTPNetworkCredentialsClientUserPassword);
                smtpClient.EnableSsl = mr.SMTPEnableSSL;

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

        public bool Execute(string html, MailRequest mr)
        {
            bool retVal = true;
            try
            {
                var templateStream = mr.MailTemplateResourceName != null ? this.GetType().Assembly.GetManifestResourceStream(mr.MailTemplateResourceName) : null;
                var sr = templateStream != null ? new StreamReader(templateStream) : null;
                var template = sr != null ? sr.ReadToEnd() : null;

                var factory = new MergedEmailFactory(new TemplateParser());

                var tokenValues = mr.MailTemplateResourceTokens;

                MailMessage message = factory
                    .WithTokenValues(tokenValues)
                    .WithSubject(mr.MailSubject)
                    .WithHtmlBody(html)
                    .Create();

                message.From = new MailAddress(mr.SMTPClientUserEMailAddress, mr.SMTPClientUserDisplayName);

                string[] addresses = mr.MailTo.Split(';');
                foreach (string address in addresses)
                {
                    message.To.Add(address);
                }

                var smtpClient = new SmtpClient();
                smtpClient.Host = mr.SMTPClientHost;
                smtpClient.Credentials = new NetworkCredential(mr.SMTPNetworkCredentialsClientUserID, mr.SMTPNetworkCredentialsClientUserPassword);
                smtpClient.EnableSsl = mr.SMTPEnableSSL;

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
