using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SetupFee
    public class SetupFee
    {
        public virtual int SetupFeeID { get; set; }
        public virtual string SetupFeeName { get; set; }
        public virtual Status SetupFeeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
