using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class CloudApplicationFeatureModel
    {
        public int CloudApplicationFeatureID { get; set; }
        public decimal Cost { get; set; }

        public decimal Count { get; set; }
        public string CountSuffix { get; set; }
        public FeatureModel Feature { get; set; }
        //public bool Include { get; set; }
        //public bool IncludeCount { get; set; }
        //public bool IncludeCountSuffix { get; set; }
        public bool IncludeExtraCost { get; set; }
        public bool IsOptional { get; set; }
        public bool HasCount { get; set; }
        public string OutputDisplayDescriptor { get; set; }
        public bool CanBeBooleanAndDataDriven { get; set; }
    }
}

