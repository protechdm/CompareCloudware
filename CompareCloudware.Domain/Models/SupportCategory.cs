using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportCategory
    public class SupportCategory
    {
        public virtual int SupportCategoryID { get; set; }
        public virtual string SupportCategoryName { get; set; }
        public virtual Status SupportCategoryStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
