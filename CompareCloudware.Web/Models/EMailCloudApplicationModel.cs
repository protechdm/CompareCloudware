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

    public class EMailCloudApplicationModel : BaseModel
    {
        public EMailCloudApplicationModel()
        {
        }

        public EMailCloudApplicationModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int CloudApplicationID { get; set; }

        [UIHint("CustomTextBox"), DataType(DataType.EmailAddress), RegularExpression(@"^[A-Za-z0-9_\+-]+(\.[A-Za-z0-9_\+-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.([A-Za-z]{2,4})$", ErrorMessage = "Not a valid EMail address"), Display(Name = "Email"), DisplayName("By email")]
        [ValidateEMailTakingToSelectionWithPrompt]
        public string EMailAddress { get; set; }

        public string CloudApplicationURL { get; set; }

    }
}

