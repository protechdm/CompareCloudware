using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region PaymentFrequency
    public class PaymentFrequency
    {
        public virtual int PaymentFrequencyID { get; set; }
        public virtual string PaymentFrequencyName { get; set; }
        public virtual Status PaymentFrequencyStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
