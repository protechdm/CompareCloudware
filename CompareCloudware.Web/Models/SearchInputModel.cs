using CompareCloudware.Web;
using CompareCloudware.Web.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CompareCloudware.Web.Validation;
using System.Configuration;

namespace CompareCloudware.Web.Models
{
    public class TC : DisplayNameAttribute
    {
        public TC()
            : base(ConfigurationManager.AppSettings["TermsAndConditions"])
        { }

        public TC(string configKey)
            :base(ConfigurationManager.AppSettings["TermsAndConditions"])
        {}

        public override string DisplayName
        {
            get
            {
                return base.DisplayName;
            }
        }
    }

    public class SearchInputModel : BaseModel
    {
        //public const string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public SearchInputModel()
        {
        }

        public SearchInputModel(ICustomSession session)
        {
            
            base.CustomSession = session;
            if (session.TestMode)
            {
                this.ChosenCategoryID = 1;
                this.ChosenNumberOfUsers = "1";
                this.Forename = "w";
                this.Surname = "w";
                this.EMail = "w@w.co.uk";
                this.TermsAndConditions = true;
            }
        }

        private void Test()
        {
            DisplayNameAttribute d = new DisplayNameAttribute();
        }

        [UIHint("CustomSelectCategory"), Display(Name="Categories")]
        public IList<CategoryModel> Categories { get; set; }

        public int CategoryID { get; set; }

        [Display(Name="Category ID")]
        public int ChosenCategoryID { get; set; }

        [Display(Name="Chosen Number Of Users")]
        //public int ChosenNumberOfUsers { get; set; }
        public string ChosenNumberOfUsers { get; set; }

        public SearchInputModelStyle DisplayStyle { get; set; }

        [UIHint("EmailTextBox"), Required(ErrorMessage="EMail Required"), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage="Not a valid EMail address"), Display(Name="email")]
        [ValidateEMail]
        public string EMail { get; set; }

        [ValidateFirstName]
        [Display(Name = "First Name"), UIHint("ForenameTextBox"), 
        RegularExpression(@"^(?!First Name).*$"), 
        Required, DisplayName("First Name")]
        public string Forename { get; set; }

        [ValidateSurname]
        [Display(Name = "Surname"), UIHint("SurnameTextBox"), 
        RegularExpression(@"^(?!Surname$).*$"), 
        Required, DisplayName("Surname")]
        public string Surname { get; set; }

        [Display(Name="Number Of Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        public int OperatingSystemID { get; set; }

        public int SearchInputID { get; set; }

        //[DisplayName(ConfigurationManager.AppSettings["TermsAndConditions"]), Display(Name = ConfigurationManager.AppSettings["TermsAndConditions"])]
        //[ValidateFreeTrialBuyNow]
        [TC("TermsAndConditions"), UIHint("TermsAndConditions")]
        public bool TermsAndConditions { get; set; }

    }
}

