using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Domain.Models
{
    #region VendorDashboardRole
    public class VendorDashboardRole
    {
        public virtual int VendorDashboardRoleID { get; set; }
        public virtual int DashboardRoleID { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual Status VendorDashboardStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
