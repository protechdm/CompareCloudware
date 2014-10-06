using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region MinimumContract
    public class MinimumContract
    {
        public virtual int MinimumContractID { get; set; }
        public virtual string MinimumContractName { get; set; }
        public virtual Status MinimumContractStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
