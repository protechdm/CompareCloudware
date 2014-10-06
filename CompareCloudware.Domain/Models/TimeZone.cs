using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region TimeZone
    public class TimeZone
    {
        public virtual int TimeZoneID { get; set; }
        public virtual string TimeZoneName { get; set; }
        public virtual int GMTDifference { get; set; }
        public virtual bool IgnoreFilterPredicate { get; set; }
        public virtual Status TimeZoneStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
