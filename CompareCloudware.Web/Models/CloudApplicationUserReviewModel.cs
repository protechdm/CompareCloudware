using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationUserReviewModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationUserReviewModel()
        {
        }

        public CloudApplicationUserReviewModel(ICustomSession session)
        {
            base.CustomSession = session;
        }
        public int CloudApplicationUserReviewID { get; set; }
        public int CloudApplicationID { get; set; }

        [UIHint("OneToFiveWithHalves"), DisplayName("Ease of use"), Display(Name = "Ease of use")]
        public decimal CloudApplicationUserReviewEaseOfUse { get; set; }
        [UIHint("OneToFiveWithHalves"), DisplayName("Functionality"), Display(Name = "Functionality")]
        public decimal CloudApplicationUserReviewFunctionality { get; set; }
        [UIHint("OneToFiveWithHalves"), DisplayName("Overall"), Display(Name = "Overall")]
        public decimal CloudApplicationUserReviewOverallRating { get; set; }
        [UIHint("OneToFiveWithHalves"), DisplayName("Value for money"), Display(Name = "Value for money")]
        public decimal CloudApplicationUserReviewValueForMoney { get; set; }

        [UIHint("CustomTextBox"), DisplayName("Company name (not displayed)"), Display(Name = "Company name (not displayed)")]
        [Required]
        public string CloudApplicationUserReviewCompany { get; set; }
        
        [UIHint("CustomTextBox"), DisplayName("First Name (not displayed)"), Display(Name = "First Name (not displayed)")]
        [Required]
        public string CloudApplicationUserReviewForename { get; set; }
        [UIHint("CustomTextBox"), DisplayName("Surname (not displayed)"), Display(Name = "Surname (not displayed)")]
        [Required]
        public string CloudApplicationUserReviewSurname { get; set; }
        
        
        [UIHint("CustomTextBox"), DisplayName("Job title (not displayed)"), Display(Name = "Job title (not displayed)")]
        [Required]
        public string CloudApplicationUserReviewTitle { get; set; }
        [UIHint("CustomMultiLineTextBox"), DisplayName("Review"), Display(Name = "Review")]
        [Required]
        public string CloudApplicationUserReviewText { get; set; }


        //[Required, UIHint("OneToFiveWithHalves"), DisplayName("Company type"), Display(Name = "Company type")]
        //public string CloudApplicationRatingCompanyType { get; set; }
        [UIHint("OneToFiveWithHalves"), DisplayName("Company employees"), Display(Name = "Company employees")]
        public int CloudApplicationUserReviewEmployeeCount { get; set; }

        //[UIHint("CustomSelectCategory"), Display(Name = "Categories")]
        public IList<IndustryModel> Industries { get; set; }
        //public int IndustryID { get; set; }
        [Display(Name = "Industry")]
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

        [Display(Name = "Persisted?")]
        public bool Persisted { get; set; }

        [Display(Name = "Row ID")]
        public Guid RowID { get; set; }

        public bool AddMode { get; set; }
        public bool IsLive { get; set; }

        public string CloudApplicationUserReviewStatus { get; set; }

    }
}

