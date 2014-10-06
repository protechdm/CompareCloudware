using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region ContentText
    public class ContentText
    {
        public virtual int ContentTextID { get; set; }
        public virtual string ContentTextData { get; set; }
        public virtual byte[] ContentTextGraphic { get; set; }
        public virtual ContentTextType ContentTextType { get; set; }
        public virtual int BodyOrder { get; set; }
        public virtual string CompositeID { get; set; }
        public virtual string NiceName { get; set; }
        public virtual bool IsEmailLink { get; set; }
        public virtual bool IsUnderline { get; set; }
        public virtual bool IsBold { get; set; }
        public virtual bool IsHyperLink { get; set; }
        public virtual string HyperLinkURL { get; set; }
        public virtual bool IsBulleted { get; set; }
        public virtual bool IsNumbered { get; set; }
        public virtual string NumberSuffix { get; set; }
        public virtual int NumberOrder { get; set; }
        public virtual bool? IsDate { get; set; }

        public virtual bool? LineBreakBefore { get; set; }
        public virtual bool? LineBreakAfter { get; set; }

        public virtual Status ContentTextStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
