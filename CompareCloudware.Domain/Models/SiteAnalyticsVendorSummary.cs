using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Contracts.Repositories;

namespace CompareCloudware.Domain.Models
{
    public class SiteAnalyticsVendorSummary : IValidate
    {
        public virtual Int32 CloudApplicationID { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string Brand { get; set; }
        public virtual Int32 Impressions { get; set; }
        public virtual Int32 ComparisonResultImpressions { get; set; }
        public virtual Int32 ShopVisits { get; set; }
        public virtual Int32 ShopContentConsumption { get; set; }
        public virtual Int32 ShopLeads { get; set; }
        public virtual Int32 ShopEMails { get; set; }
        public virtual Int32 ClickCompareButtons { get; set; }
        public virtual Int32 ClickDashboardAndSearchTextBox { get; set; }

        public void Validate(ChangeAction action)
        {
            //    if (action == ChangeAction.Insert)
            //    {
            //        //prevent double-posting of Comments
            //        if (this.ActionID == 0)
            //            throw new InvalidOperationException(
            //        "An action must be specified");
            //    }
        }
    }
}
