using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Xml;

namespace WindowsServiceWrapper
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        private string SERVICE_NAME = WindowsServiceWrapper.Properties.Settings.Default.SERVICE_NAME;
        ServiceController sc ;
        private void EcoConfiguration_Load(object sender, EventArgs e)
        {
            sc = new ServiceController(SERVICE_NAME);
            lvService.View = View.Details; 
            lvService.CheckBoxes = false;
            lvService.Columns.Clear();
            lvService.Activation = ItemActivation.TwoClick;
            lvService.Columns.Add("Service Name", 158, HorizontalAlignment.Left);
           // lvService.Columns.Add("Service Description", 150, HorizontalAlignment.Right);
            lvService.Columns.Add("Status", 100, HorizontalAlignment.Right);
            ChangeStatusOfContextMenu();
            RefreshData();
            GetSettingValues();
        }
        private void RefreshData()
        {
            sc.Refresh(); 
            lvService.Items.Clear(); 
            System.Windows.Forms.ListViewItem itmp = new System.Windows.Forms.ListViewItem(SERVICE_NAME);
            itmp.BackColor = System.Drawing.Color.Silver;
            itmp.ForeColor = System.Drawing.Color.Navy; itmp.Checked = true;
            System.Windows.Forms.ListViewItem.ListViewSubItem itms1 =
                new System.Windows.Forms.ListViewItem.ListViewSubItem(itmp, "Economics Ingester Service");
            System.Windows.Forms.ListViewItem.ListViewSubItem itms2 =
                new System.Windows.Forms.ListViewItem.ListViewSubItem(itmp, sc.Status.ToString());
           // itmp.SubItems.Add(itms1);
            itmp.SubItems.Add(itms2);
            lvService.Items.Add(itmp); 
        }
        //private void RefreshStatus()
        //{
        //    System.Windows.Forms.ListViewItem itmp = lvService.Items[SERVICE_NAME];
        //    System.Windows.Forms.ListViewItem.ListViewSubItem itms2 = itmp.SubItems[1];
        //    itms2.Text = sc.Status.ToString();
        //}

        public void ChangeStatusOfContextMenu()
        {
            sc.Refresh();
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                Start.Enabled = true;
                Stop.Enabled = false;
            }
            if (sc.Status == ServiceControllerStatus.Running)
            {
                Stop.Enabled = true;
                Start.Enabled = false;
            }
            RefreshData();
        }
        //public void WriteToTaskBar(string errorMessage)
        //{

        //}
        private void GetSettingValues()
        {
            XmlDocument dom = new XmlDocument();
            dom.Load(WindowsServiceWrapper.Properties.Settings.Default.ConfiguredFileName);
            XmlElement xmlConnElement = (XmlElement)dom.SelectSingleNode
                ("//configuration/connectionStrings/add[@name='Connection String']");
            txtConnectionString.Text = xmlConnElement != null?xmlConnElement.GetAttribute("connectionString").ToString():"";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            sc.Refresh();
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);  
            }
            ChangeStatusOfContextMenu();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            sc.Refresh();
            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            ChangeStatusOfContextMenu();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            sc.Refresh();
            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            sc.Start();
            sc.WaitForStatus(ServiceControllerStatus.Running);
            ChangeStatusOfContextMenu();
        }
        List<string> messages = new List<string>(); 
        public void AssignLogValues(string log,string severity)
        {
            if (!messages.Contains(log))
            {
                messages.Add(log);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            sc.Refresh(); 
            if (sc.Status == ServiceControllerStatus.Running)
            {
              
                MessageBox.Show ("Please Stop the service before updating any entry");
                return;
            }
            XmlDocument dom = new XmlDocument();
            dom.Load(WindowsServiceWrapper.Properties.Settings.Default.ConfiguredFileName);
            XmlElement xmlConnElement = (XmlElement)dom.SelectSingleNode
                ("//configuration/connectionStrings/add[@name='Connection String']");
            xmlConnElement.SetAttribute("connectionString", txtConnectionString.Text);


            dom.Save(WindowsServiceWrapper.Properties.Settings.Default.ConfiguredFileName);
            MessageBox.Show ("Data is saved successfully");

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private ConnectionFetcher obj;
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if(obj == null)
                obj = new ConnectionFetcher();
            obj.ConnectionString = txtConnectionString.Text;
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txtConnectionString.Text = obj.GetConnectionString(true) ; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
            GetSettingValues();
        }
    }
}