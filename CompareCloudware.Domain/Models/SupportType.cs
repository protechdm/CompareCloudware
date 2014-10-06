using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportType
    public class SupportType
    {
        public virtual int SupportTypeID { get; set; }
        public virtual string SupportTypeName { get; set; }
        public virtual bool SupportTypeClassedAsActive { get; set; }
        public virtual bool IsPassive { get; set; }
        public virtual Status SupportTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
