using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SearchResult
    public class SearchResult
    {
        public virtual int CloudApplicationID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual string VendorName { get; set; }
        public virtual string VendorLogoURL { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string Description { get; set; }
        
        public virtual decimal ApplicationCostPerMonth { get; set; }
        public virtual string ApplicationCostPerMonthExtra { get; set; }
        public bool ApplicationCostPerMonthFree { get; set; }
        public bool ApplicationCostPerMonthOffered { get; set; }
        
        public virtual decimal ApplicationCostPerAnnum { get; set; }
        public bool ApplicationCostPerAnnumFree { get; set; }
        public bool ApplicationCostPerAnnumOffered { get; set; }

        public virtual decimal ApplicationCostOneOff { get; set; }
        public virtual decimal CallsPackageCostPerMonth { get; set; }
        public virtual SetupFee SetupFee { get; set; }
        public virtual FreeTrialPeriod FreeTrialPeriod { get; set; }

        public virtual Int64 Rank { get; set; }

        public virtual int CategoryID { get; set; }
        public virtual string CloudApplicationCategoryTag { get; set; }
        public virtual string CloudApplicationShopTag { get; set; }

    }
    #endregion

}
