using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
//using Castle.Core.Logging;
using CompareCloudware.Web.Helpers;
using System.Web;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.Web.Models
{
    public class BaseModel
    {
        private ICustomSession _session;

        //public ILogger Logger { get; set; }

        //public BaseModel(ILogger logger)
        //{
        //    Logger = logger;
        //}

        public ICustomSession CustomSession 
        {
            get
            {
                return _session;
            }
            set
            {
                if (value != null)
                {
                    //Logger.Fatal("SESSION EXPIRED");
                    //HttpRequestBase request = new HttpRequestWrapper(System.Web.HttpContext.Current.Request);
                    //SiteActivities.Log(request);
                    //throw new SessionExpiredException();
                    if (value.DetectedBrowserID == null)
                    {
                        //System.Web.HttpContext.Current.Server.Transfer("home.htm");
                        //System.Web.HttpContext.Current.Response.Redirect("home.htm",true);


                        //var bc = HttpContext.Current.Request.Browser;
                        //value.DetectedBrowser = bc.Browser;
                        //value.DetectedBrowserID = bc.Id;
                        //value.JavaScriptEnabled = true;

                        HttpRequestBase request = new HttpRequestWrapper(System.Web.HttpContext.Current.Request);
                        //string returnURL = request.Url.ToString();
                        //System.Web.HttpContext.Current.Response.Redirect("http://localhost:81/home.htm?returnUrl="+returnURL,true);
                        
                        SiteActivities.Log(request);

                        if (HttpContext.Current.Session.SessionID == null)
                        {
                            throw new SessionExpiredException();
                        }
                        else
                        {
                            _session = value;
                        }
                    }
                    else
                    {
                        _session = value;
                    }
                }
            } 
        }

        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public void SetMetaData(ContentPageModel contentPage)
        {
            MetaTitle = contentPage.MetaTitle;
            MetaKeywords = contentPage.MetaKeywords;
            MetaDescription = contentPage.MetaDescription;
        }
    }

    public class SessionExpiredException : Exception { };
}

