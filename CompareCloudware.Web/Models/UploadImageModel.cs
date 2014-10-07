using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Models
{

    public class UploadImageModel : BaseModel
    {
        public UploadImageModel()
        {
        }

        public UploadImageModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int CloudApplicationID { get; set; }

        [Display(Name = "Internet URL")]
        public string Url { get; set; }

        public bool IsUrl { get; set; }

        [Display(Name = "Flickr image")]
        public string Flickr { get; set; }

        public bool IsFlickr { get; set; }

        [Display(Name = "Local file")]
        public HttpPostedFileBase LocalFile { get; set; }

        public bool IsFile { get; set; }

        [Range(0, int.MaxValue)]
        public int X { get; set; }

        [Range(0, int.MaxValue)]
        public int Y { get; set; }

        [Range(1, int.MaxValue)]
        public int Width { get; set; }

        [Range(1, int.MaxValue)]
        public int Height { get; set; }

        public string Title { get; set; }
    }
}

