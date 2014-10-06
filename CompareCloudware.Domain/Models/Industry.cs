using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Industry
    public class Industry
    {
        public virtual int IndustryID { get; set; }
        public virtual int Code { get; set; }
        //public virtual List<string> groups { get; set; }
        public virtual string Description { get; set; }
        public virtual Status IndustryStatus { get; set; }
    }
    #endregion

    public class AllIndustries
    {
        public Industry[] Industries;
    }

}
