using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace CompareCloudware.Domain.Models
{
    public class SiteMapNode
    {
        public virtual int SiteMapNodeID { get; set; }
        public virtual string Url { get; set; }
        public virtual DateTime? LastModified { get; set; }
        public virtual SiteMapFrequencyEnum? Frequency { get; set; }
        public virtual double? Priority { get; set; }
        public virtual byte[] RowVersion { get; set; }


        public SiteMapNode(string url)
        {
            Url = url;
            Priority = null;
            Frequency = null;
            LastModified = null;
        }

        public SiteMapNode(RequestContext request, object routeValues)
        {
            Url = GetUrl(request, new RouteValueDictionary(routeValues));
            Priority = null;
            Frequency = null;
            LastModified = null;
        }

        private string GetUrl(RequestContext request, RouteValueDictionary values)
        {
            var routes = RouteTable.Routes;
            var data = routes.GetVirtualPathForArea(request, values);
            var data2 = routes.GetVirtualPath(request, values).VirtualPath;

            if (data == null)
            {
                return null;
            }

            var baseUrl = request.HttpContext.Request.Url;
            var relativeUrl = data.VirtualPath;

            return request.HttpContext != null &&
                   (request.HttpContext.Request != null && baseUrl != null)
                       ? new Uri(baseUrl, relativeUrl).AbsoluteUri
                       : null;
        }



    }

    public enum SiteMapFrequencyEnum : short
    {
        Never,
        Yearly,
        Monthly,
        Weekly,
        Daily,
        Hourly,
        Always
    }
}