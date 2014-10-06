using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Domain.Models
{
    #region Profile
    public class Profile
    {
        public virtual int ProfileID { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual VendorDashboard VendorDashboard { get; set; }
        public virtual Status ProfileStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion


}
