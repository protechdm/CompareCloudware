using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationFeature
    public class CloudApplicationFeature
    {
        public virtual int CloudApplicationFeatureID { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual Feature Feature { get; set; }
        //public virtual bool Include { get; set; } //NOT USED
        public virtual bool IncludeExtraCost { get; set; }
        public virtual decimal Cost { get; set; }
        //public virtual bool IncludeCount { get; set; } //NOT USED
        public virtual decimal Count { get; set; }
        //public virtual bool IncludeCountSuffix { get; set; } //NOT USED
        public virtual string CountSuffix { get; set; }
        public virtual bool IsOptional { get; set; }
        public virtual Status CloudApplicationFeatureStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual string AdditionalInformation { get; set; }


    }
    #endregion
}
