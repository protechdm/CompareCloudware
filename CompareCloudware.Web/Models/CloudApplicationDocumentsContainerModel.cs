using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationDocumentsContainerModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationDocumentsContainerModel()
        {
        }

        public CloudApplicationDocumentsContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            CloudApplicationDocuments = new List<CloudApplicationDocumentModel>();
        }

        [Display(Name = "Apply all documents to all vendor brands :")]
        public bool ApplyDocumentsAtVendorLevel { get; set; }

        //[Display(Name = "Ratings:")]
        public List<CloudApplicationDocumentModel> CloudApplicationDocuments { get; set; }

    }
}

