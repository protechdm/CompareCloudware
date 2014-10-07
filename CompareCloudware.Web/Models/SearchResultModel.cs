using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class SearchResultModel : BaseModel
    {
        public SearchResultModel() { }

        public SearchResultModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public decimal ApplicationCostOneOff { get; set; }
        public decimal ApplicationCostPerAnnum { get; set; }
        public bool ApplicationCostPerAnnumFree { get; set; }
        public bool ApplicationCostPerAnnumOffered { get; set; }

        
        public decimal ApplicationCostPerMonth { get; set; }
        public string ApplicationCostPerMonthExtra { get; set; }
        public bool ApplicationCostPerMonthFree { get; set; }
        public bool ApplicationCostPerMonthOffered { get; set; }
        
        
        public decimal CallsPackageCostPerMonth { get; set; }

        
        public int CloudApplicationID { get; set; }
        public string Description { get; set; }
        public FreeTrialPeriodModel FreeTrialPeriod { get; set; }
        public string ServiceName { get; set; }
        public SetupFeeModel SetupFee { get; set; }
        public int VendorID { get; set; }
        public string VendorLogoURL { get; set; }
        public string VendorName { get; set; }

        public int TabLayoutPosition { get; set; }

        public string CloudApplicationCategoryTag { get; set; }
        public string CloudApplicationShopTag { get; set; }

    }
}

