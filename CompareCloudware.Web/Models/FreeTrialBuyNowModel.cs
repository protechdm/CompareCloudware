using CompareCloudware.Web;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CompareCloudware.Web.Validation;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class FreeTrialBuyNowModel : BaseModel
        //, IValidatableObject
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];
        public FreeTrialBuyNowModel()
        {
        }

        public FreeTrialBuyNowModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int CloudApplicationID { get; set; }
        public int CategoryID { get; set; }

        [DisplayName("Buy now"), Display(Name="Buy now")]
        //[ValidateFreeTrialBuyNow]
        public bool BuyNow { get; set; }

        [Display(Name="Company"), DataType(DataType.Text), UIHint("CustomTextBox"), DisplayName("Company")]
        public string Company { get; set; }

        //[UIHint("CustomTextBox"), Required, DataType(DataType.EmailAddress), Display(Name="Email"), DisplayName("Email")]
        //[UIHint("EmailTextBox"), Required(ErrorMessage = "EMail Required"), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address"), Display(Name = "Email")]
        [UIHint("CustomTextBox"), DataType(DataType.EmailAddress), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address"), Display(Name = "Email"), DisplayName("Email")]
        [ValidateEMailFreeTrial]
        public string EMailAddress { get; set; }

        [UIHint("CustomTextBox"), DataType(DataType.EmailAddress), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address"), Display(Name = "Colleague Email"), DisplayName("Email")]
        [ValidateEMailFreeTrial]
        public string EMailAddressColleague { get; set; }

        [UIHint("CustomMultiLineTextBox"), DisplayName("Type your message here"), Display(Name = "Type your message here"),Required]
        public string MessageToColleague { get; set; }

        [UIHint("CustomTextBox"), DisplayName("First Name"), Display(Name="First Name")]
        public string Forename { get; set; }

        [Display(Name = "FREE Trial"), DisplayName("FREE Trial")]
        //[ValidateFreeTrialBuyNow]
        public bool FreeTrial { get; set; }

        [Range(1,9999), DisplayName("Users"), Display(Name="Users"), UIHint("CustomTextBoxInt"), DataType(DataType.Text)]
        public int NumberOfEmployees { get; set; }

        [DataType(DataType.Text), UIHint("CustomTextBox"), Display(Name="Surname"), DisplayName("Surname")]
        public string Surname { get; set; }

        [Display(Name="Phone"), DataType(DataType.PhoneNumber), UIHint("CustomTextBox"), DisplayName("Phone")]
        public string Telephone { get; set; }

        [Display(Name = "Job title"), UIHint("CustomTextBox"), DisplayName("Job title")]
        public string JobTitle { get; set; }

        //public System.Collections.Generic.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!BuyNow && !FreeTrial)
        //    {
        //        yield return new ValidationResult("Please select either BUY NOW or FREE TRIAL");
        //    }
        //}

        //[UIHint("CustomSelectCategory"), Display(Name = "RequestTypes")]
        //public IList<RequestTypeModel> RequestTypes { get; set; }

        [Display(Name="Request"), DisplayName("Request")]
        public int RequestTypeID { get; set; }

        //[DisplayName(termsAndConditions), Display(Name = termsAndConditions)]
        //[ValidateFreeTrialBuyNow]
        [TC("TermsAndConditions")]
        public bool TermsAndConditions { get; set; }

        public string CloudApplicationName { get; set; }

        public string CloudApplicationNumberOfUsers { get; set; }



    }
}

