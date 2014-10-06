using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region OperatingSystem
    public class OperatingSystem
    {
        public virtual int OperatingSystemID { get; set; }
        public virtual string OperatingSystemName { get; set; }
        public virtual Status OperatingSystemStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
