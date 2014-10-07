using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationRatingModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationRatingModel()
        {
        }

        public CloudApplicationRatingModel(ICustomSession session)
        {
            base.CustomSession = session;
        }
        public int CloudApplicationRatingID { get; set; }
        public int CloudApplicationID { get; set; }

        [Required, UIHint("OneToFiveWithHalves"), DisplayName("Ease of use"), Display(Name = "Ease of use")]
        public decimal CloudApplicationEaseOfUse { get; set; }
        [Required, UIHint("OneToFiveWithHalves"), DisplayName("Functionality"), Display(Name = "Functionality")]
        public decimal CloudApplicationFunctionality { get; set; }
        [Required, UIHint("OneToFiveWithHalves"), DisplayName("Overall"), Display(Name = "Overall")]
        public decimal CloudApplicationOverallRating { get; set; }
        [Required, UIHint("OneToFiveWithHalves"), DisplayName("Value for money"), Display(Name = "Value for money")]
        public decimal CloudApplicationValueForMoney { get; set; }

        [Required, UIHint("CustomTextBox"), DisplayName("Company name (not displayed)"), Display(Name = "Company name (not displayed)")]
        public string CloudApplicationRatingReviewerCompany { get; set; }
        
        [Required, UIHint("CustomTextBox"), DisplayName("First Name (not displayed)"), Display(Name = "First Name (not displayed)")]
        public string CloudApplicationRatingReviewerForename { get; set; }
        [Required, UIHint("CustomTextBox"), DisplayName("Surname (not displayed)"), Display(Name = "Surname (not displayed)")]
        public string CloudApplicationRatingReviewerSurname { get; set; }
        
        
        [Required, UIHint("CustomTextBox"), DisplayName("Job title (not displayed)"), Display(Name = "Job title (not displayed)")]
        public string CloudApplicationRatingReviewerTitle { get; set; }
        [Required, UIHint("CustomMultiLineTextBox"), DisplayName("Review"), Display(Name = "Review")]
        public string CloudApplicationRatingText { get; set; }


        //[Required, UIHint("OneToFiveWithHalves"), DisplayName("Company type"), Display(Name = "Company type")]
        //public string CloudApplicationRatingCompanyType { get; set; }
        [Required, UIHint("OneToFiveWithHalves"), DisplayName("Company employees"), Display(Name = "Company employees")]
        public int CloudApplicationRatingEmployeeCount { get; set; }

        //[UIHint("CustomSelectCategory"), Display(Name = "Categories")]
        public IList<IndustryModel> Industries { get; set; }
        public int IndustryID { get; set; }
        [Display(Name = "Category ID")]
        public int ChosenIndustryID { get; set; }

        public IndustryModel ChosenIndustry { get; set; }

        [Display(Name = "Chosen Number Of Users")]
        public int ChosenEmployeeCount { get; set; }
        [Display(Name = "Number Of Users")]
        public IList<NumberOfUsersModel> EmployeeCount { get; set; }

        [TC("TermsAndConditions")]
        public bool TermsAndConditions { get; set; }

        public bool ShowConfirmationDialog { get; set; }
        public string ConfirmationDialogTitle { get; set; }
        public string ConfirmationDialogMessage1 { get; set; }
        public string ConfirmationDialogMessage2 { get; set; }

    }
}

