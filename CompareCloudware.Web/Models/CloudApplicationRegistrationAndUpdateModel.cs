using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationRegistrationAndUpdateModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationRegistrationAndUpdateModel()
        {
        }

        public CloudApplicationRegistrationAndUpdateModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public bool IsCloudwareUpdate { get; set; }
        public bool ShowConfirmationDialog { get; set; }
        public bool ShowTCAcceptDialog { get; set; }
        public string ConfirmationDialogTitle { get; set; }
        public string ConfirmationDialogMessage1 { get; set; }
        public string ConfirmationDialogMessage2 { get; set; }

        [Required(ErrorMessage = "Please supply your first name")]
        public string Forename { get; set; }
        [Required(ErrorMessage = "Please supply your surname")]
        public string Surname { get; set; }

        //[UIHint("OneToFiveWithHalves"), DisplayName("Ease of use"), Display(Name = "Ease of use")]
        [Required(ErrorMessage = "Please supply your position")]
        public string Position { get; set; }
        //[UIHint("OneToFiveWithHalves"), DisplayName("Functionality"), Display(Name = "Functionality")]
        [Required(ErrorMessage = "Please supply your company")]
        public string Company { get; set; }
        //[UIHint("OneToFiveWithHalves"), DisplayName("Overall"), Display(Name = "Overall")]
        [Required(ErrorMessage = "Please supply a valid email"), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address")]
        public string EMail { get; set; }
        //[UIHint("OneToFiveWithHalves"), DisplayName("Value for money"), Display(Name = "Value for money")]
        [Required(ErrorMessage = "Please supply your telephone")]
        public string Telephone { get; set; }

        //[UIHint("CustomTextBox"), DisplayName("Company name (not displayed)"), Display(Name = "Company name (not displayed)")]
        //[Required]
        [Required(ErrorMessage = "Please supply your country")]
        public string Country { get; set; }
        
        //[UIHint("CustomTextBox"), DisplayName("First Name (not displayed)"), Display(Name = "First Name (not displayed)")]
        //[Required]
        [Required(ErrorMessage = "Please supply the cloud service name")]
        public string CloudApplicationServiceName { get; set; }

        [Required(ErrorMessage = "Please supply some update details")]
        public string CloudApplicationUpdateDetails { get; set; }

        public List<SupportCategoryModel> SupportCategories { get; set; }

        public string SupportCategoryOther { get; set; }

        [Mandatory(ErrorMessage = "You must agree to the Terms to register.")]
        public bool TermsAndConditions { get; set; }

        [DisplayName("Tick here to join our Compare Cloudware user group"), Display(Name = "Tick here to join our Compare Cloudware user group")]
        //[DisplayName("Tick here"), Display(Name = "Tick here")]
        public bool JoinUserGroup { get; set; }

        public bool AutoShow { get; set; }
    }

    public class MandatoryAttribute : ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            return (!(value is bool) || (bool)value);
        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationType = "mandatory";
            yield return rule;
        }
    }
}

