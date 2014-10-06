using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsServiceWrapper
{
    public partial class ConnectionFetcher : Form
    {
        public ConnectionFetcher()
        {
            InitializeComponent();
        }
        private string _connectionString;
        private SqlConnectionStringBuilder _connBuilder;
        public string ConnectionString
        {
            get
            {
                return _connectionString; 
            }
            set
            {
                _connectionString = value; 
            }
        }

        private void ConnectionFetcher_Load(object sender, EventArgs e)
        {
            _connBuilder = new SqlConnectionStringBuilder(_connectionString);            
            txtServerName.Text = _connBuilder.DataSource;
            if (_connBuilder.IntegratedSecurity)
            {
                rdoWindowsAuthentication.Checked = true; 
            }
            else
            {
                rdoSqlServerAuthentication.Checked = true; ;
                txtUserName.Text = _connBuilder.UserID;
                txtPassword.Text = _connBuilder.Password;
            }
            //cboDataBaseName.SelectedText = _connBuilder.InitialCatalog;
            cboDataBaseName.Text = _connBuilder.InitialCatalog; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _connectionString = GetConnectionString(true); 
            this.DialogResult = DialogResult.OK;
        }
        public string GetConnectionString(bool isDataBaseName)
        {
            _connBuilder = new SqlConnectionStringBuilder();
            _connBuilder.DataSource = txtServerName.Text;
            if (rdoWindowsAuthentication.Checked)
            {
                _connBuilder.IntegratedSecurity = true; ;
            }
            else
            {
                _connBuilder.IntegratedSecurity = false;
                _connBuilder.UserID = txtUserName.Text;
                _connBuilder.Password = txtPassword.Text;
            }
            if(isDataBaseName)
                _connBuilder.InitialCatalog = cboDataBaseName.Text;
            else
                _connBuilder.InitialCatalog = "master";
            return _connBuilder.ConnectionString;            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cboDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = GetConnectionString(false);
            sqlconn.Open();

            string sqlQuery = "Select Name From SysDatabases order by Name";

            SqlCommand sqlcmd = new SqlCommand(sqlQuery, sqlconn);
            SqlDataReader reader = sqlcmd.ExecuteReader();

            List<string> dblist = new List<string>();
            cboDataBaseName.Items.Clear(); 
            while (reader.Read())
            {
                cboDataBaseName.Items.Add(reader.GetValue(0).ToString());
                dblist.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close(); 
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {            
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = GetConnectionString(true);
                sqlconn.Open();

                string sqlQuery = "Select 'abc'";

                SqlCommand sqlcmd = new SqlCommand(sqlQuery, sqlconn);
                sqlcmd.ExecuteNonQuery();
               MessageBox.Show("Test connection is Succeeded" );
            }
            catch (SqlException ex)
            {
                if (rdoSqlServerAuthentication.Checked)
                {
                    MessageBox.Show("Login failed for user :" + txtUserName.Text);  
                }
                else
                {
                    MessageBox.Show("Login failed for user :" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString());
                }
            }
        }

        private void rdoWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void rdoSqlServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }
    }
}