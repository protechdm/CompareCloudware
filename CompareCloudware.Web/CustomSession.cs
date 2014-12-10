namespace CompareCloudware.Web
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Configuration;

    public class CustomSession : ICustomSession
    {
        public CustomSession()
        {
            if (ConfigurationManager.AppSettings["TestMode"] != null)
            {
                TestMode = Convert.ToBoolean(ConfigurationManager.AppSettings["TestMode"].ToString());
            }
        }
        public string DetectedBrowser { get; set; }

        public string DetectedBrowserID { get; set; }

        //public bool JavaScriptEnabled { get; set; }


        public string EMail { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int? NumberOfUsers { get; set; }

        public bool HasSearchResults { get; set; }



        public string Company { get; set; }
        public string Telephone { get; set; }

        public bool AddMode { get; set; }
        public bool EditMode { get; set; }

        public bool DummyVXMode { get; set; }
        public CompareCloudware.Web.Models.CloudApplicationInputModel SessionVXModel { get; set; }

        public string DetectedAgent { get; set; }
        public bool DetectedBrowserIsAPhone { get; set; }
        public bool DetectedBrowserIsAnIPAD { get; set; }

        public int? PersonID { get; set; }
        public bool VisitedViaCategory { get; set; }

        public bool ShowDiagnostics { get; set; }
        public bool? BetaSplashShown { get; set; }
        public bool? AutoShowRegisterOrUpdate { get; set; }

        public int? SelectedCategoryID { get; set; }
        public string SelectedCategoryName { get; set; }

        public bool ShowSearchTextBox { get; set; }

        public bool TestMode { get; set; }

    }
}

