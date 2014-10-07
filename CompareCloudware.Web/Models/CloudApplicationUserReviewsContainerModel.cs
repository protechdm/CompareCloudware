using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationUserReviewsContainerModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationUserReviewsContainerModel()
        {
        }

        public CloudApplicationUserReviewsContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            CloudApplicationUserReviews = new List<CloudApplicationUserReviewModel>();
        }

        [Display(Name = "Apply all user reviews to all vendor brands :")]
        public bool ApplyUserReviewsAtVendorLevel { get; set; }

        [Display(Name = "Ratings:")]
        public List<CloudApplicationUserReviewModel> CloudApplicationUserReviews { get; set; }

    }
}

