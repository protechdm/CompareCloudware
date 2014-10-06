using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Domain.Models
{
    #region VendorDashboardRolePerson
    public class VendorDashboardRolePerson
    {
        public virtual int VendorDashboardRolePersonID { get; set; }
        public virtual VendorDashboardRole VendorDashboardRole { get; set; }
        public virtual Person Person { get; set; }
        public virtual Status VendorDashboardRolePersonStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
