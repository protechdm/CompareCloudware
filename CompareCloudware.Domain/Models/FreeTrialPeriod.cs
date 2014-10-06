using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region FreeTrialPeriod
    public class FreeTrialPeriod
    {
        public virtual int FreeTrialPeriodID { get; set; }
        public virtual string FreeTrialPeriodName { get; set; }
        public virtual Status FreeTrialPeriodStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
