using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region PaymentOption
    public class PaymentOption
    {
        public virtual int PaymentOptionID { get; set; }
        public virtual string PaymentOptionName { get; set; }
        public virtual Status PaymentOptionStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
