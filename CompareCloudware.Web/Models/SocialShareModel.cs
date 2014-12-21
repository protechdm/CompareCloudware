using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class SocialShareModel : BaseModel
    {
        public SocialShareModel()
        {
        }

        public SocialShareModel(ICustomSession session, int categoryID)
        {
            base.CustomSession = session;
            StorageAndBackupText = "I’ve just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #storage #backup";
            EMailText = "I’ve just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #webmail #email";
            ConferencingText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #conferencing #video";
            CRMText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #crm #customermanagement";
            FinancialText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software @compcloudware #accounts #software #accounting";
            ComunicationsText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #phone #iptelephony";
            OfficeText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #software #officetools";
            ProjectManagementText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #projectmanagement";
            SecurityText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware #security #antivirus";
            DefaultText = "Just found a great deal on www.comparecloudware.com. Choose from >1000 business software and services @compcloudware";

            switch (categoryID)
            {
                case 1: SocialShareText = this.ComunicationsText;
                    break;
                case 2: SocialShareText = this.CRMText;
                    break;
                case 3: SocialShareText = this.ConferencingText;
                    break;
                case 4: SocialShareText = this.EMailText;
                    break;
                case 5: SocialShareText = this.OfficeText;
                    break;
                case 6: SocialShareText = this.StorageAndBackupText;
                    break;
                case 7: SocialShareText = this.ProjectManagementText;
                    break;
                case 8: SocialShareText = this.FinancialText;
                    break;
                case 9: SocialShareText = this.SecurityText;
                    break;
                default: SocialShareText = this.DefaultText;
                    break;
            }
        }

        public string StorageAndBackupText { get; set; }
        public string EMailText { get; set; }
        public string ConferencingText { get; set; }
        public string CRMText { get; set; }
        public string FinancialText { get; set; }
        public string ComunicationsText { get; set; }
        public string OfficeText { get; set; }
        public string ProjectManagementText { get; set; }
        public string SecurityText { get; set; }
        public string SocialShareText { get; set; }
        public string DefaultText { get; set; }
    }
}

