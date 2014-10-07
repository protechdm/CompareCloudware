using CompareCloudware.Web;
using CompareCloudware.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class GlobalSearchResultModelOneColumn : BaseModel
    {
        public GlobalSearchResultModelOneColumn()
        {
        }

        public GlobalSearchResultModelOneColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public decimal ApplicationCostOneOff { get; set; }

        public decimal ApplicationCostPerAnnum { get; set; }
        public decimal ApplicationCostPerAnnumFrom { get; set; }
        public decimal ApplicationCostPerAnnumTo { get; set; }
        public bool ApplicationCostPerAnnumPOA { get; set; }
        public bool ApplicationCostPerAnnumFree { get; set; }
        public bool ApplicationCostPerAnnumOffered { get; set; }


        public decimal ApplicationCostPerMonth { get; set; }
        public decimal ApplicationCostPerMonthFrom { get; set; }
        public decimal ApplicationCostPerMonthTo { get; set; }
        public bool ApplicationCostPerMonthPOA { get; set; }
        public bool ApplicationCostPerMonthFree { get; set; }
        public bool ApplicationCostPerMonthOffered { get; set; }
        public string ApplicationCostPerMonthExtra { get; set; }

        public bool PayAsYouGo { get; set; }

        public decimal CallsPackageCostPerMonth { get; set; }
        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        public int CloudApplicationID { get; set; }
        public string Description { get; set; }
        public string FreeTrialPeriod { get; set; }
        public bool IsLastInCollection { get; set; }
        public List<LanguageModel> Languages { get; set; }
        public bool MoreInfoVisible { get; set; }
        public List<OperatingSystemModelSearchResults> OperatingSystems { get; set; }
        public SearchResultDisplayFormat ResultDisplayFormat { get; set; }
        public int SearchResultID { get; set; }
        public string ServiceName { get; set; }
        public string SetupFee { get; set; }
        public SupportDaysModel SupportDays { get; set; }
        public SupportHoursModel SupportHours { get; set; }
        public List<SupportTypeModel> SupportTypes { get; set; }
        public int VendorID { get; set; }
        public byte[] VendorLogo { get; set; }
        public string VendorLogoURL { get; set; }
        public string VendorName { get; set; }

        public string CloudApplicationCategoryTag { get; set; }
        public string CloudApplicationShopTag { get; set; }

        public CurrencyModel Currency { get; set; }

    }
}

