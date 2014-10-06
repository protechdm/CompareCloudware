using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Domain.Models
{
    #region VendorDashboard
    public class VendorDashboard
    {
        public virtual int VendorDashboardID { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual VendorDashboardRole VendorDashboardRole { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual Status VendorDashboardStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion


}
