using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationProductReviewsContainerModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationProductReviewsContainerModel()
        {
        }

        public CloudApplicationProductReviewsContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            CloudApplicationProductReviews = new List<CloudApplicationProductReviewModel>();
        }

        [Display(Name = "Apply all product reviews to all vendor brands :")]
        public bool ApplyProductReviewsAtVendorLevel { get; set; }

        //[Display(Name = "Ratings:")]
        public List<CloudApplicationProductReviewModel> CloudApplicationProductReviews { get; set; }

    }
}

