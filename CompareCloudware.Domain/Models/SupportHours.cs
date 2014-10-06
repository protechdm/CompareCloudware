using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportHours
    public class SupportHours
    {
        public virtual int SupportHoursID { get; set; }
        public virtual string SupportHoursName { get; set; }
        public virtual int SupportHoursFrom { get; set; }
        public virtual int SupportHoursTo { get; set; }
        public virtual bool IgnoreFilterPredicate { get; set; }
        public virtual Status SupportHoursStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
