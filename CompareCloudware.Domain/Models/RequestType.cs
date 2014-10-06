using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region RequestType
    public class RequestType
    {
        public virtual int RequestTypeID { get; set; }
        public virtual string RequestTypeName { get; set; }
        public virtual Status RequestTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
