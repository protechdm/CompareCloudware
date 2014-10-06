using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.Specialized;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Helpers
{

    [DataContract]
    public enum PDFEngineType
    {
        [EnumMember]
        ASPPDF = 0,
        [EnumMember]
        EVOPDF = 2,
        [EnumMember]
        PDFTRON = 1
    }
}

