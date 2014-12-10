using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region PersonType
    public class PersonType
    {
        public virtual int PersonTypeID { get; set; }
        public virtual string PersonTypeName { get; set; }
        public virtual Status PersonTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
