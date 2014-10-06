using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportArea
    public class SupportArea
    {
        public virtual int SupportAreaID { get; set; }
        public virtual string SupportAreaName { get; set; }
        public virtual Status SupportAreaStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
