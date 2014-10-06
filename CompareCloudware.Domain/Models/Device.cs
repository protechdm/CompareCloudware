using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Device
    public class Device
    {
        public virtual int DeviceID { get; set; }
        public virtual string DeviceName { get; set; }
        public virtual Status DeviceStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
