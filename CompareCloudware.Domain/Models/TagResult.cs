using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region TagResult
    public class TagResult
    {
        public virtual Tag Tag { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual string TagTypeWhenTagTypeIsNull { get; set; }
        public virtual int? VendorID { get; set; }
        public virtual string VendorName { get; set; }
        public virtual string ShopTagName { get; set; }
        public virtual int? TagCategoryID { get; set; }
        public virtual string TagCategoryName { get; set; }
        public virtual int TagTypeID { get; set; }
        public virtual int CloudApplicationCategoryID { get; set; }
        public virtual string CloudApplicationCategoryName { get; set; }
        public virtual string CloudApplicationCategoryTagName { get; set; }
        public virtual string CloudApplicationShopTagName { get; set; }
    }
    #endregion

}
