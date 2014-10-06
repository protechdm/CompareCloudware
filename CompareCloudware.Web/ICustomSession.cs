namespace CompareCloudware.Web
{
    using System;

    public interface ICustomSession
    {
        string DetectedBrowser { get; set; }

        string DetectedBrowserID { get; set; }

        //bool JavaScriptEnabled { get; set; }

        string EMail { get; set; }
        string Forename { get; set; }
        string Surname { get; set; }
        string Company { get; set; }
        string Telephone { get; set; }
        int NumberOfUsers { get; set; }

        bool HasSearchResults { get; set; }

        bool AddMode { get; set; }
        bool EditMode { get; set; }

        bool DummyVXMode { get; set; }

        CompareCloudware.Web.Models.CloudApplicationInputModel SessionVXModel { get; set; }

        string DetectedAgent { get; set; }
        bool DetectedBrowserIsAPhone { get; set; }
        bool DetectedBrowserIsAnIPAD { get; set; }

        int? PersonID { get; set; }
        bool VisitedViaCategory { get; set; }

        bool ShowDiagnostics { get; set; }
        bool? BetaSplashShown { get; set; }
        bool? AutoShowRegisterOrUpdate { get; set; }

        int? SelectedCategoryID { get; set; }
        string SelectedCategoryName { get; set; }

        bool ShowSearchTextBox { get; set; }

    }
}

