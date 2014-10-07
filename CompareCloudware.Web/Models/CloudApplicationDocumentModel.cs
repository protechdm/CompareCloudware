using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;
using System.Web;


namespace CompareCloudware.Web.Models
{

    public class CloudApplicationDocumentModel
    {
        public int CloudApplicationID { get; set; }

        [Display(Name = "File Name")]
        public string CloudApplicationDocumentFileName { get; set; }

        [Display(Name = "File Posted")]
        public HttpPostedFileBase CloudApplicationDocumentPostedFile { get; set; }

        public int CloudApplicationDocumentID { get; set; }

        [Display(Name = "File Path")]
        public string CloudApplicationDocumentPhysicalFilePath { get; set; }

        [Display(Name = "Title")]
        public string CloudApplicationDocumentTitle { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CloudApplicationDocumentReleaseDate { get; set; }

        [UIHint("CustomCheckBoxList"), Display(Name = "Document File Format")]
        public SelectListItemCollection CloudApplicationDocumentFileFormats { get; set; }
        //public string DocumentFileFormat { get; set; }

        [UIHint("CustomCheckBoxList"), Display(Name = "Document Type")]
        public SelectListItemCollection CloudApplicationDocumentTypes { get; set; }

        [Display(Name = "Type")]
        public CloudApplicationDocumentTypeModel CloudApplicationDocumentType { get; set; }
        //public string DocumentType { get; set; }

        [Display(Name = "Format")]
        public string CloudApplicationDocumentFileFormat { get; set; }

        [Display(Name = "URL")]
        public string CloudApplicationDocumentURL { get; set; }

        [Display(Name = "Document")]
        public byte[] CloudApplicationDocument { get; set; }

        [Display(Name = "Image")]
        public byte[] CloudApplicationDocumentImage { get; set; }

        [Display(Name = "Persisted?")]
        public bool Persisted { get; set; }

        [Display(Name = "Row ID")]
        public Guid RowID { get; set; }

        public bool AddMode { get; set; }
        public bool IsLive { get; set; }

        public string CloudApplicationDocumentStatus { get; set; }

    }
}

