using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using CompareCloudware.Web.Models;
using System.Web.Mvc;
using System.Collections.Generic;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationReviewModel : BaseModel
    {
        public CloudApplicationReviewModel()
        {
            this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public CloudApplicationReviewModel(ICustomSession session)
        {
            base.CustomSession = session;
            this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public int CloudApplicationReviewID { get; set; }
        public int CloudApplicationID { get; set; }

        [Required, Display(Name = "Review Date:")]
        public DateTime CloudApplicationReviewDate { get; set; }
        
        [Required, Display(Name = "Headline:"), MaxLength(500)]
        public string CloudApplicationReviewHeadline { get; set; }
        
        [Required, Display(Name = "Publisher Name:"), MaxLength(500)]
        public string CloudApplicationReviewPublisherName { get; set; }
        
        [Required, Display(Name = "Review Text:"), MaxLength(500)]
        public string CloudApplicationReviewText { get; set; }
        
        [Required, Display(Name = "Review URL:"), MaxLength(500)]
        public string CloudApplicationReviewURL { get; set; }
        
        [Required, Display(Name = "Review Document:"), MaxLength(500)]
        public string CloudApplicationReviewURLDocumentExtension { get; set; }

        [Display(Name = "Review Document Type:")]
        [UIHint("CustomCheckBoxList")]
        public SelectListItemCollection CloudApplicationReviewURLDocumentExtensions { get; set; }
        
        [Display(Name = "Link Broken?")]
        public bool IsBrokenLink { get; set; }

        [Display(Name = "Persisted?")]
        public bool Persisted { get; set; }

        [Display(Name = "Row ID")]
        public Guid RowID { get; set; }

        public bool AddMode { get; set; }

        #region ConstructDocumentTypes
        private SelectListItemCollection ConstructDocumentTypes()
        {
            SelectListItemCollection docTypes = new SelectListItemCollection();

            docTypes.SelectListItems = new List<SelectListItem>();
            docTypes.SelectListItems.Add(new SelectListItem() { Text = "URL Link", Value = "HTML" });
            docTypes.SelectListItems.Add(new SelectListItem() { Text = "PDF Document", Value = "PDF" });
            docTypes.SelectListItems.Add(new SelectListItem() { Text = "Word Document", Value = "DOC" });
            return docTypes;
        }
        #endregion

    }
}
