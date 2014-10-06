using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    public class GenericSingleValue
    {
        public string ValueAsString { get; set; }
        public decimal ValueAsDecimal { get; set; }
        public string ValueSuffix { get; set; }
        public string OutputDisplayType { get; set; }
        public string OutputDisplayDescriptor { get; set; }
    }

}

