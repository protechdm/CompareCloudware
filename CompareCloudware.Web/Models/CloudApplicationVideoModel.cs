using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using CompareCloudware.Web.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web;
using System.Xml;

namespace CompareCloudware.Web.Models
{
    #region CloudApplicationVideoModel
    public class CloudApplicationVideoModel : BaseModel
    {
        public CloudApplicationVideoModel()
        {
            //this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public CloudApplicationVideoModel(ICustomSession session)
        {
            base.CustomSession = session;
            //this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public CloudApplicationVideoModel(ICustomSession session, HttpRequestBase request)
        {
            //HttpRequestBase request = this.Request;
            if (request != null)
            {
                if (request.UserAgent != null)
                {
                    session.DetectedAgent = request.UserAgent;
                    session.DetectedBrowserIsAPhone = request.UserAgent.ToUpperInvariant().Contains("PHONE");
                    session.DetectedBrowserIsAnIPAD = request.UserAgent.ToUpperInvariant().Contains("IPAD");
                }
            }
            base.CustomSession = session;
            //this.CloudApplicationReviewURLDocumentExtensions = ConstructDocumentTypes();
        }

        public int CloudApplicationID { get; set; }
        public int CloudApplicationVideoID { get; set; }
        public bool IsLocalDomain { get; set; }
        public bool IsLive { get; set; }
        public bool IsYouTubeStream { get; set; }

        [Display(Name="Video URL:")]
        public string CloudApplicationVideoURL { get; set; }
        
        [Display(Name = "File name:")]
        public string CloudApplicationVideoFileName { get; set; }
        
        public HttpPostedFileBase CloudApplicationVideoFile { get; set; }

        [Display(Name = "File format:")]
        public string CloudApplicationVideoFileFormat { get; set; }
        [Display(Name = "Link broken?")]
        public bool IsBrokenLink { get; set; }

        public CloudApplicationModel CloudApplication { get; set; }

        //[Required, Display(Name = "Video Format:"), MaxLength(500)]
        //public string CloudApplicationVideoExtension { get; set; }

        //[Required, Display(Name = "Video Domain:"), MaxLength(500)]
        //public string CloudApplicationVideoDomain { get; set; }

        [Display(Name = "Video Formats:")]
        [UIHint("CustomRadioButtonList")]
        public SelectListItemCollection CloudApplicationVideoExtensions { get; set; }

        [Display(Name = "Video Domain:")]
        [UIHint("CustomRadioButtonList")]
        public SelectListItemCollection CloudApplicationVideoDomains { get; set; }

        public bool ReadyToPlay { get; set; }

        public string CloudApplicationVideoStatus { get; set; }

        public int? Width { get; set; }

        public AspectRatio AspectRatio { get; set; }

        public string AddAttributesToVideo(string video)
        {

            XmlDocument videoXml = new XmlDocument();
            videoXml.LoadXml(video);

            XmlNode objectElement = videoXml.SelectSingleNode("object");
            XmlNode allowFullScreen = videoXml.CreateNode(XmlNodeType.Element,"param",null);

            XmlAttribute paramName = videoXml.CreateAttribute("name");
            paramName.Value = "allowFullScreen";

            XmlAttribute paramValue = videoXml.CreateAttribute("value");
            paramValue.Value = "true";

            allowFullScreen.Attributes.Append(paramName);
            allowFullScreen.Attributes.Append(paramValue);

            objectElement.AppendChild(allowFullScreen);

            return videoXml.OuterXml;
        }

    }
    #endregion

    public enum AspectRatio
    {
        Ratio16x9 = 1,
        Ratio4x3 = 2
    }
}

