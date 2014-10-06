using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region ContentTextType
    public class ContentTextType
    {
        public virtual int ContentTextTypeID { get; set; }
        public virtual string ContentTextTypeName { get; set; }
        public virtual Status ContentTextTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
