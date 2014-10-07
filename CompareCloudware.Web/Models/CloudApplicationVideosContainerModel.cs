using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;

namespace CompareCloudware.Web.Models
{

    public class CloudApplicationVideosContainerModel : BaseModel
    {
        private static string termsAndConditions = ConfigurationManager.AppSettings["TermsAndConditions"];

        public CloudApplicationVideosContainerModel()
        {
        }

        public CloudApplicationVideosContainerModel(ICustomSession session)
        {
            base.CustomSession = session;
            CloudApplicationVideos = new List<CloudApplicationVideoModel>();
        }

        [Display(Name = "Apply all videos to all vendor brands :")]
        public bool ApplyVideosAtVendorLevel { get; set; }

        [Display(Name = "No video")]
        public bool NoVideo { get; set; }

        //[Display(Name = "Ratings:")]
        public List<CloudApplicationVideoModel> CloudApplicationVideos { get; set; }

    }
}

