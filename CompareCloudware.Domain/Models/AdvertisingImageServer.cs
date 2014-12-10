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
        
        public virtual int? NextMPUCRMID { get; set; }
        public virtual int? NextMPUEMailID { get; set; }
        public virtual int? NextMPUFinancialID { get; set; }
        public virtual int? NextMPUOfficeID { get; set; }
        public virtual int? NextMPUProjectManagementID { get; set; }
        public virtual int? NextMPUSecurityID { get; set; }
        public virtual int? NextMPUStorageAndBackupID { get; set; }
        public virtual int? NextMPUVoiceID { get; set; }
        public virtual int? NextMPUWebConferencingID { get; set; }

        public virtual int? NextSkyscraperCRMID { get; set; }
        public virtual int? NextSkyscraperEMailID { get; set; }
        public virtual int? NextSkyscraperFinancialID { get; set; }
        public virtual int? NextSkyscraperOfficeID { get; set; }
        public virtual int? NextSkyscraperProjectManagementID { get; set; }
        public virtual int? NextSkyscraperSecurityID { get; set; }
        public virtual int? NextSkyscraperStorageAndBackupID { get; set; }
        public virtual int? NextSkyscraperVoiceID { get; set; }
        public virtual int? NextSkyscraperWebConferencingID { get; set; }

        public virtual int? NextMPUMarketingID { get; set; }
        public virtual int? NextMPUWebsiteID { get; set; }
        public virtual int? NextMPUCreativeID { get; set; }
        public virtual int? NextMPUBusinessIntelligenceReportingID { get; set; }
        public virtual int? NextMPUHostingID { get; set; }
        public virtual int? NextMPUHRID { get; set; }
        public virtual int? NextMPUPaymentsID { get; set; }
        public virtual int? NextMPUBusinessAndOperationsID { get; set; }
        public virtual int? NextMPUSalesID { get; set; }

        public virtual int? NextSkyscraperMarketingID { get; set; }
        public virtual int? NextSkyscraperWebsiteID { get; set; }
        public virtual int? NextSkyscraperCreativeID { get; set; }
        public virtual int? NextSkyscraperBusinessIntelligenceReportingID { get; set; }
        public virtual int? NextSkyscraperHostingID { get; set; }
        public virtual int? NextSkyscraperHRID { get; set; }
        public virtual int? NextSkyscraperPaymentsID { get; set; }
        public virtual int? NextSkyscraperBusinessAndOperationsID { get; set; }
        public virtual int? NextSkyscraperSalesID { get; set; }

        public virtual bool? IsServing { get; set; }

        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
