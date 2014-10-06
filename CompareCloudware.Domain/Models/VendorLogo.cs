using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Domain.Models
{
    #region VendorLogo
    public class VendorLogo
    {
        public virtual int VendorLogoID { get; set; }
        //[Required]
        //[MaxLength(100)]
        //public virtual string VendorName { get; set; }
        //public virtual string VendorLogoFullURL { get; set; }
        //public virtual string VendorLogoFileName { get; set; }
        //[Column(TypeName="image")]
        public virtual byte[] Logo { get; set; }

        public virtual Status VendorLogoStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        //public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
