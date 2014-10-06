using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region LicenceTypeMinimum
    public class LicenceTypeMinimum
    {
        public virtual int LicenceTypeMinimumID { get; set; }
        public virtual int LicenceTypeMinimumName { get; set; }
        public virtual Status LicenceTypeMinimumStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

    #region LicenceTypeMaximum
    public class LicenceTypeMaximum
    {
        public virtual int LicenceTypeMaximumID { get; set; }
        public virtual int LicenceTypeMaximumName { get; set; }
        public virtual Status LicenceTypeMaximumStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
