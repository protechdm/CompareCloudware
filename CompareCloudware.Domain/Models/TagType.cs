using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region TagType
    public class TagType
    {
        public virtual int TagTypeID { get; set; }
        public virtual string TagTypeName { get; set; }
        public virtual Status TagTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
