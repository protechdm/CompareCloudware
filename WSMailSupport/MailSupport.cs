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
//using CompareCloudware.Web.Controllers;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.Domain.Models;
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

namespace WSMailSupport
{
    #region MailSupport
    public partial class MailSupport : ServiceBase
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

        public MailSupport()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // MailPDF
            // 
            this.ServiceName = "COMPARE CLOUDWARE SUPPORT EMAILER";

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
            Logger.WriteEntry("Starting SUPPORT EMAILER timer");
            timerDelegate = new TimerCallback(DoWork);
            serviceTimer = new System.Threading.Timer(timerDelegate, null, dueTime, interval);
            Logger.WriteEntry("Started SUPPORT EMAILER timer");
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
                Logger.WriteEntry("Started SUPPORT EMAILER ServiceMail");

                Logger.WriteEntry("Loading SUPPORT EMAILER DI Container");
                IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                Logger.WriteEntry("Loaded SUPPORT EMAILER DI Container");
                //myAppHost = new MyAppHost(Logger);
                emailHost = (EMailHost)container.Resolve<EMailHost>();
                Logger.WriteEntry("Resolved SUPPORT EMAILER EMail Host");

                view = emailHost.ServiceSupportMailRequests();
                Logger.WriteEntry("Finished ServiceMail");
            }
            catch (Exception e)
            {
                el.WriteEntry("Error in ServiceMail() : " + e.Message);
            }
        }
        #endregion

    }
    #endregion

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


        #region ServiceSupportMailRequests
        public bool ServiceSupportMailRequests()
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
                List<SupportAreaQA> requests = null;
                _logger.Source = eventLogFile;
                _logger.WriteEntry("Started SUPPORT EMAILER servicing process");

                #region DI
                try
                {
                    IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
                    //HomeController hc = container.Resolve<HomeController>();
                    _context = container.Resolve<CompareCloudwareContext>();
                    _repository = container.Resolve<QueryRepository>();
                    _logger.WriteEntry("Successfully resolved SUPPORT EMAILER DI");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in SUPPORT EMAILER DI : " + e.Message, EventLogEntryType.Error);
                }
                #endregion

                _logger.WriteEntry("Getting SUPPORT EMAILER email support requests");

                #region GET UNSERVICED REQUESTS
                try
                {
                    if (_repository != null)
                    {
                        //_logger.WriteEntry("Getting a currency...");
                        //var test = _repository.GetCurrencyBySymbol("£");
                        //_logger.WriteEntry("Successfully called database");
                        //_logger.WriteEntry("Successfully fetched a currency : " + test.CurrencyName);

                        requests = _repository.GetUnservicedSupportAreaQAs().ToList();
                        _logger.WriteEntry("Successfully fetched " + requests.Count.ToString() + " SUPPORT EMAILER email requests.");
                    }
                    else
                    {
                        _logger.WriteEntry("Could not set SUPPORT EMAILER repository", EventLogEntryType.Error);
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
                    _logger.WriteEntry("Error in fetching SUPPORT EMAILER unserviced requests : " + message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                #endregion
                try
                {
                    foreach (SupportAreaQA saqa in requests)
                    {
                        try
                        {
                            ServiceSupportMailRequest(saqa,_repository);
                        }
                        catch (Exception e)
                        {
                            _logger.WriteEntry("Error in servicing SUPPORT EMAILER request ID : " + e.Message, EventLogEntryType.Error);
                        }
                    }


                    _logger.WriteEntry("Finished SUPPORT EMAILER servicing process");
                }
                catch (Exception e)
                {
                    _logger.WriteEntry("Error in overall servicing process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                }
                return true;
            }
            catch (Exception e)
            {
                _logger.WriteEntry("Error in starting SUPPORT EMAILER process : " + e.Message + ". Stack trace : " + e.StackTrace, EventLogEntryType.Error);
                return false;
            }
        }
        #endregion

        private void ServiceSupportMailRequest(SupportAreaQA saqa,ICompareCloudwareRepository _repository)
        {
            MailRequest mr = null;
            ISendEMail sm = _mail;

            try
            {


                #region CONSTRUCT EMAIL AND EXECUTE EMAIL
                if (saqa.SubmittedPerson != null)
                {
                    bool useTestEMailAddress = Convert.ToBoolean(ConfigurationManager.AppSettings["UseTestEMailAddress"]);
                    if (useTestEMailAddress)
                    {
                        _logger.WriteEntry("Using TEST mail address", EventLogEntryType.Warning);
                    }

                    string mailTo = !useTestEMailAddress ? ConfigurationManager.AppSettings["SMTPMailTo"] : ConfigurationManager.AppSettings["SMTPMailToTest"];
                    string categoryList = "";

                    foreach(SupportAreaQACategory sc in saqa.SupportAreaQACategories)
                    {
                        categoryList += sc.SupportCategory.SupportCategoryName.Trim() + " ";
                    }

                    categoryList += saqa.SupportCategoryOther != null ? saqa.SupportCategoryOther : null;

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
                            {"FirstName", saqa.SubmittedPerson.Forename.Trim()},
                            {"Surname", saqa.SubmittedPerson.Surname},
                            {"Position", saqa.SubmittedPerson.Position},
                            {"Company", saqa.SubmittedPerson.Company},
                            {"EMail", saqa.SubmittedPerson.EMail},
                            {"Telephone", saqa.SubmittedPerson.Telephone},
                            {"Country", saqa.SubmittedPerson.PersonCountry},
                            {"CategoryList", categoryList },
                            {"IsInUserGroup", saqa.SubmittedPerson.IsInUserGroup != null ? ((bool)saqa.SubmittedPerson.IsInUserGroup ? "Yes" : "No") : "No"},
                            {"UpdateDetails", saqa.Question },
                        }
                    };

                    if (saqa.SupportArea.SupportAreaName.Trim().ToUpper() == "REGISTRATION")
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameNewProvider"];
                        mr.MailSubject = ConfigurationManager.AppSettings["MailSubjectNewProvider"];
                    }
                    else if (saqa.SupportArea.SupportAreaName.Trim().ToUpper() == "CONTENT")
                    {
                        mr.MailTemplateResourceName = ConfigurationManager.AppSettings["MailTemplateResourceNameExistingProvider"];
                        mr.MailSubject = ConfigurationManager.AppSettings["MailSubjectExistingProvider"];
                    }
                    else
                    {
                        throw new Exception("Invalid support area name");
                    }

                    _logger.WriteEntry("Sending email to address : " + mailTo + " for REQUEST ID:" + saqa.SupportAreaQAID.ToString(), EventLogEntryType.Information);
                    sm.Execute(saqa.SubmittedPerson, mr);
                    _logger.WriteEntry("Successfully sent email to address : " + mailTo + " for REQUEST ID:" + saqa.SupportAreaQAID.ToString(), EventLogEntryType.Information);
                }
                else
                {
                    _logger.WriteEntry("Could not locate person ID for request ID " + saqa.SupportAreaQAID.ToString(), EventLogEntryType.Error);
                }
                #endregion

                #region MARK REQUEST AS SERVICED
                _repository.MarkSupportAreaQAAsServiced(saqa.SupportAreaQAID);
                #endregion
            }
            catch (SmtpException ex)
            {
                #region SMTP ERROR
                    _logger.WriteEntry("Error in emailing confirmation for request ID " + saqa.SupportAreaQAID.ToString() + ". Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                    _logger.WriteEntry("Host :" + mr.SMTPClientHost, EventLogEntryType.Information);
                    _logger.WriteEntry("User :" + mr.SMTPNetworkCredentialsClientUserID, EventLogEntryType.Information);
                    _logger.WriteEntry("Password :" + mr.SMTPNetworkCredentialsClientUserPassword, EventLogEntryType.Information);
                    _logger.WriteEntry("EMailAddress :" + mr.SMTPClientUserEMailAddress, EventLogEntryType.Information);
                    _logger.WriteEntry("SSL :" + mr.SMTPEnableSSL.ToString(), EventLogEntryType.Information);
                    _logger.WriteEntry("Port :" + mr.SMTPPort, EventLogEntryType.Information);
                #endregion
                _repository.MarkSupportAreaQAAsServiced(saqa.SupportAreaQAID);
            }
            catch (Exception ex)
            {
                _logger.WriteEntry("General error :" + ex.Message + " - Stack trace : " + ex.StackTrace, EventLogEntryType.Error);
                int x = 1;
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
        bool Execute(Person p, MailRequest mr);
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
                    .Create();

                message.From = new MailAddress(mr.SMTPClientUserEMailAddress, mr.SMTPClientUserDisplayName);

                string[] addresses = mr.MailTo.Split(';');
                foreach (string address in addresses)
                {
                    message.To.Add(address);
                    //message.To.Add("protechdm@yahoo.com");
                }
                //message.CC.Add("protechdm@yahoo.com");

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
