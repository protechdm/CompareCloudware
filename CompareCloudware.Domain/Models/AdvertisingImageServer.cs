using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region AdvertisingImageServer
    public class AdvertisingImageServer
    {
        public virtual int AdvertisingImageServerID { get; set; }
        public virtual int? NextMPUID { get; set; }
        public virtual int? NextSkyscraperID { get; set; }
        public virtual int? NextCarouselHomeID { get; set; }
        
        public virtual int? NextMPUCustomerManagementID { get; set; }
        public virtual int? NextMPUEMailID { get; set; }
        public virtual int? NextMPUFinancialID { get; set; }
        public virtual int? NextMPUOfficeID { get; set; }
        public virtual int? NextMPUProjectManagementID { get; set; }
        public virtual int? NextMPUSecurityID { get; set; }
        public virtual int? NextMPUStorageAndBackupID { get; set; }
        public virtual int? NextMPUVoiceID { get; set; }
        public virtual int? NextMPUWebConferencingID { get; set; }

        public virtual int? NextSkyscraperCustomerManagementID { get; set; }
        public virtual int? NextSkyscraperEMailID { get; set; }
        public virtual int? NextSkyscraperFinancialID { get; set; }
        public virtual int? NextSkyscraperOfficeID { get; set; }
        public virtual int? NextSkyscraperProjectManagementID { get; set; }
        public virtual int? NextSkyscraperSecurityID { get; set; }
        public virtual int? NextSkyscraperStorageAndBackupID { get; set; }
        public virtual int? NextSkyscraperVoiceID { get; set; }
        public virtual int? NextSkyscraperWebConferencingID { get; set; }

        public virtual bool? IsServing { get; set; }

        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
