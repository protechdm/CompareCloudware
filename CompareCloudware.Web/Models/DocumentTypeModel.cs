using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationDocumentTypeModel
    {
        public int CloudApplicationDocumentTypeID { get; set; }

        [Display(Name = "Type")]
        public string CloudApplicationDocumentTypeName { get; set; }
    }
}

