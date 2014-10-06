using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Feature
    public class Feature
    {
        public virtual int FeatureID { get; set; }
        public virtual string FeatureName { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual int FeatureColumnNumber { get; set; }
        public virtual int FeatureRowNumber { get; set; }
        public virtual bool IsDataDriven { get; set; }
        public virtual string DataDrivenField { get; set; }

        public virtual bool IsDataFloorDriven { get; set; }
        public virtual bool IsDataCeilingDriven { get; set; }

        public virtual string OutputDisplayType { get; set; }
        public virtual string OutputDisplayDescriptor { get; set; }
        public virtual byte[] RowVersion { get; set; }

        public virtual bool HasCount { get; set; }
        public virtual bool HasCountSuffix { get; set; }

        public virtual bool CanBeBooleanAndDataDriven { get; set; }

        public virtual bool SuppressFilterBehaviour { get; set; }
        public virtual Feature ParentFeature { get; set; }

        public virtual FeatureType FeatureType { get; set; }

        public virtual Status FeatureStatus { get; set; }

    }
    #endregion
}
