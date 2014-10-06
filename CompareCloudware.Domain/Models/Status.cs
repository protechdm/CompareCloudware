using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Status
    public class Status
    {
        public virtual int StatusID { get; set; }
        public virtual string StatusName { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
