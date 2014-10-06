using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region FeatureType
    public class FeatureType
    {
        public virtual int FeatureTypeID { get; set; }
        public virtual string FeatureTypeName { get; set; }
        public virtual Status FeatureTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
