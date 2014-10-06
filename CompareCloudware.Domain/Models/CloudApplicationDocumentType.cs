using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationDocumentType
    public class CloudApplicationDocumentType
    {
        public virtual int CloudApplicationDocumentTypeID { get; set; }
        public virtual string CloudApplicationDocumentTypeName { get; set; }
        public virtual Status CloudApplicationDocumentTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
