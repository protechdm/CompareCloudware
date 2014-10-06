using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.ServiceProcess;
using WSMailPDF;
using WSMailSupport;
using WSMailTryBuy;

namespace WindowsServiceWrapper
{
    static class Program
    {
       
        static Configuration objConfiguration;
        static NotifyIcon appIcon;
        static System.Timers.Timer timer;
        static ServiceController sc;
        private static string SERVICE_NAME = WindowsServiceWrapper.Properties.Settings.Default.SERVICE_NAME;

        static ContextMenu mnu;

        /// <summary>
        /// The main entry point for the application.
        /// A simple wrapper app which allows the developer to see the current status of a Windows Service
        /// without using Control Panel>Services.
        /// The application uses a timer to refresh the "status" of a Windows Service. Obviously
        /// the status can be changed manually through Control Panel>Services, but you can also use
        /// this app to change the status also.
        /// Nothing complicated, just a simple "right-click" context menu which allows you to start
        /// and stop the service.
        /// Note that the service name ( SERVICE_NAME ) is read from the App.Config, you must ensure
        /// that the Windows Service itself has it's "DISPLAYNAME" property equal to the App.Config
        /// setting, or else this app will not be able to find the service in the registry and conseqently
        /// fire it up!!!
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.EventLog el;

            el = new System.Diagnostics.EventLog("CC_EMAIL");
            //,"DEV",);
            if (!System.Diagnostics.EventLog.SourceExists("CC_EMAIL"))
            {
                System.Diagnostics.EventLog.CreateEventSource("CC_EMAIL", "CC_EMAIL");
            }
            el.Source = "CC_EMAIL";
            //el.WriteEntry("Starting timer");
            //TestMailPDF m = new TestMailPDF();
            //m.WithWebClient();

            //COMMENT WHEN BUILDING THE SERVICE!!
            //MAIL PDF
            //NewMailPDF m = new NewMailPDF();
            //m.ServiceMail();
            ////m.WithIntegrationFramework();
            //return;

            //MAIL SUPPORT
            //MailSupport ms = new MailSupport();
            //ms.ServiceMail();
            //return;

            //MAIL TRY/BUY
            MailTryBuy ms = new MailTryBuy();
            ms.ServiceMail();
            return;

            System.Threading.Mutex appSingleTon = new Mutex(false, "Service Monitor");
            if (appSingleTon.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Program.IntializeIcon();
                Microsoft.Win32.SystemEvents.SessionEnded += new
                        Microsoft.Win32.SessionEndedEventHandler(SystemEvent_SessionEnded);
                timer = new System.Timers.Timer(10000);
                timer.Elapsed += new System.Timers.ElapsedEventHandler(ServiceChecker);
                timer.Enabled = true;
                sc = new ServiceController(SERVICE_NAME);


                Application.Run();
            }
            appSingleTon.Close();
       
        }

        /// <summary>
        /// The delegated method to execute in conjunction with the timer. Simply refreshes the context
        /// menu depending on the status of the service.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void ServiceChecker(object source, System.Timers.ElapsedEventArgs e)
        {
            sc.Refresh();
            try
            {
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    appIcon.Icon = WindowsServiceWrapper.Properties.Resources.ServiceStart;
                    appIcon.Text = "Service Monitor";
                }
                else if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    appIcon.Icon = WindowsServiceWrapper.Properties.Resources.ServiceStop;
                    appIcon.Text = "Service Stopped !!!";
                }

                if (sc.Status != ServiceControllerStatus.Running)
                {
                    //sc.Start();
                    mnu.MenuItems["Start Compare Cloudware EMailer Service"].Enabled = true;
                    mnu.MenuItems["Stop Compare Cloudware EMailer Service"].Enabled = false;
                }
                else
                {
                    mnu.MenuItems["Start Compare Cloudware EMailer Service"].Enabled = false;
                    mnu.MenuItems["Stop Compare Cloudware EMailer Service"].Enabled = true;
                }
            }
            catch
            {

            }

        }

        /// <summary>
        /// Construct the toolbar icon, context menu and click events.
        /// </summary>
        private static void IntializeIcon()
        {
            appIcon = new NotifyIcon();
            appIcon.Icon = WindowsServiceWrapper.Properties.Resources.ServiceStart;
            appIcon.Visible = true;
            mnu = new ContextMenu();
            
            MenuItem configItem = new MenuItem("Configuration Manager");
            configItem.DefaultItem = true;
            configItem.Click += new EventHandler(ConfigItem_Click);
            mnu.MenuItems.Add(configItem);
            mnu.MenuItems.Add("-");

            MenuItem startItem = new MenuItem("Start Compare Cloudware EMailer Service");
            startItem.Click += new EventHandler(StartItem_Click);
            startItem.Name = "Start Compare Cloudware EMailer Service";
            mnu.MenuItems.Add(startItem);
            mnu.MenuItems.Add("-");

            MenuItem stopItem = new MenuItem("Stop Compare Cloudware EMailer Service");
            stopItem.Click += new EventHandler(StopItem_Click);
            stopItem.Name = "Stop Compare Cloudware EMailer Service";
            mnu.MenuItems.Add(stopItem);
            mnu.MenuItems.Add("-");


            MenuItem closeItem = new MenuItem("Exit");
            closeItem.Click += new EventHandler(CloseItem_Click);
            mnu.MenuItems.Add(closeItem);
            appIcon.ContextMenu = mnu;
            appIcon.Text = "Compare Cloudware EMailer Service Monitor";
            appIcon.DoubleClick += new EventHandler(ConfigItem_Click);
            
        }

        /// <summary>
        /// FOR FUTURE USE!!!
        /// Not used at present, was going to use so that the database connection could be
        /// tested from the machine/context that was running the Windows Service.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ConfigItem_Click(object sender, EventArgs e)
        {
            if (objConfiguration == null)
                objConfiguration = new Configuration();
            try
            {
                objConfiguration.Visible = true;
            }
            catch
            {
                objConfiguration = new Configuration();
                objConfiguration.Visible = true;
            }
        }

        #region Click Events
        private static void StartItem_Click(object sender, EventArgs e)
        {
            if (sc.Status != ServiceControllerStatus.Running)
            {
                sc.Start();
                mnu.MenuItems["Start Compare Cloudware EMailer Service"].Enabled = false;
                mnu.MenuItems["Stop Compare Cloudware EMailer Service"].Enabled = true;
            }
            //objConfiguration.Close();
            //appIcon.Visible = true;
        }

        private static void StopItem_Click(object sender, EventArgs e)
        {
            if (sc.Status != ServiceControllerStatus.Stopped)
            {
                sc.Stop();
                mnu.MenuItems["Start Compare Cloudware EMailer Service"].Enabled = true;
                mnu.MenuItems["Stop Compare Cloudware EMailer Service"].Enabled = false;
            }
            
            //objConfiguration.Close();
            //appIcon.Visible = true;
        }
        
        private static void CloseItem_Click(object sender, EventArgs e)
        {
            if (objConfiguration != null)
                objConfiguration.Close();
            appIcon.Visible = false;
            Application.Exit();
        }
        #endregion

        private static void SystemEvent_SessionEnded(object sender, Microsoft.Win32.SessionEndedEventArgs e)
        {
            if (objConfiguration != null)
                objConfiguration.Close();
            appIcon.Visible = false;
            Application.Exit(); 
        }
    }
}