using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Tag
    public class Tag
    {
        public virtual int TagID { get; set; }
        public virtual string TagName { get; set; }
        public virtual TagType TagType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Status TagStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        //public virtual CloudApplication TagCloudApplication { get; set; }
    }
    #endregion

}
