using CompareCloudware.Web;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CompareCloudware.Web.Validation;
using System.Collections.Generic;
using System.Configuration;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Models
{

    public class RegisterNowModel : BaseModel
    {
        public RegisterNowModel()
        {
        }

        public RegisterNowModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        [DisplayName("First Name"), Display(Name = "First Name"),UIHint("CustomTextBox"), Required]
        public string Forename { get; set; }

        [DataType(DataType.Text), UIHint("CustomTextBox"), Display(Name = "Surname"), DisplayName("Surname"), Required]
        public string Surname { get; set; }

        [Display(Name = "Job Title"), UIHint("CustomTextBox"), DisplayName("Job Title"), Required]
        public string JobTitle { get; set; }

        [Display(Name = "Company"), DataType(DataType.Text), UIHint("CustomTextBox"), DisplayName("Company"), Required]
        public string Company { get; set; }

        [UIHint("CustomTextBox"), DataType(DataType.EmailAddress), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address"), Display(Name = "Email"), DisplayName("Email"), Required]
        [ValidateEMailRegisterNow]
        public string EMailAddress { get; set; }

        [Display(Name = "Telephone"), DataType(DataType.PhoneNumber), UIHint("CustomTextBox"), DisplayName("Telephhone"), Required]
        public string Telephone { get; set; }

        public bool IsRegistered { get; set; }
        public bool HasPresentationVideo { get; set; }
        public bool ShowVideo { get; set; }
        public CloudApplicationVideoModel Video { get; set; }

        //[Display(Name = "Data opt-in"), DisplayName("Data opt-in"), Required]
        //public bool DataOptIn { get; set; }

        [Mandatory(ErrorMessage = "You must agree to the Terms to register.")]
        public bool TermsAndConditions { get; set; }

        public string HeaderStrap { get; set; }
        public bool ShowHeaderStrapImage { get; set; }

        public PartnerProgrammeTypeEnum PartnerProgrammeType { get; set; }


    }
}

