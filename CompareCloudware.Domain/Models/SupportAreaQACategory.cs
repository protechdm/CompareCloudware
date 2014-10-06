using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportAreaQACategory
    public class SupportAreaQACategory
    {
        public virtual int SupportAreaQACategoryID { get; set; }
        public virtual SupportAreaQA SupportAreaQA { get; set; }
        public virtual SupportCategory SupportCategory { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
