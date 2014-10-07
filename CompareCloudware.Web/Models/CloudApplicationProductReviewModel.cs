using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using CompareCloudware.Web.Models;
using System.Web.Mvc;
using System.Collections.Generic;
//using EntityFramework;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationProductReviewModel : BaseModel
    {
        public CloudApplicationProductReviewModel()
        {
            //this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public CloudApplicationProductReviewModel(ICustomSession session)
        {
            base.CustomSession = session;
            //this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public int CloudApplicationProductReviewID { get; set; }
        public int CloudApplicationID { get; set; }

        [Display(Name = "Review Date:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CloudApplicationProductReviewDate { get; set; }
        
        //[Display(Name = "Headline:"), MaxLength(500)]
        public string CloudApplicationProductReviewHeadline { get; set; }
        
        //[Display(Name = "Publisher:"), MaxLength(500)]
        public string CloudApplicationProductReviewPublisherName { get; set; }
        
        //[Display(Name = "Review Text:"), MaxLength(1000)]
        public string CloudApplicationProductReviewText { get; set; }
        
        //[Display(Name = "URL:"), MaxLength(500)]
        public string CloudApplicationProductReviewURL { get; set; }
        
        //[Display(Name = "Format:"), MaxLength(500)]
        public string CloudApplicationProductReviewURLDocumentFormat { get; set; }

        [Display(Name = "Review Document Type:")]
        [UIHint("CustomCheckBoxList")]
        public SelectListItemCollection CloudApplicationProductReviewURLDocumentFormats { get; set; }
        
        [Display(Name = "Link Broken?")]
        public bool IsBrokenLink { get; set; }

        [Display(Name = "Persisted?")]
        public bool Persisted { get; set; }

        [Display(Name = "Row ID")]
        public Guid RowID { get; set; }

        public bool AddMode { get; set; }
        public bool IsLive { get; set; }

        public string CloudApplicationProductReviewStatus { get; set; }

    }
}
