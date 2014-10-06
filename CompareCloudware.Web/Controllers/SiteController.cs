using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Auction.Web.Domain.Queries;
//using Auction.Web.Models;
//using Auction.Web.Utility;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Linq;
using CompareCloudware.Domain.Models;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Controllers
//namespace Auction.Web.Controllers
{
    [AllowAnonymous]
    public class SiteController : BaseController
    {
        private const string SitemapsNamespace = "http://www.sitemaps.org/schemas/sitemap/0.9";

        public SiteController(ICustomSession session, ICompareCloudwareRepository repository, ISiteAnalyticsLogger _SiteAnalyticsLogger)
            :base(session, repository,_SiteAnalyticsLogger)
        {
        }

        //public ActionResult AllowCookies(string ReturnUrl)
        //{
        //    CookieConsent.SetCookieConsent(Response, true);
        //    return RedirectToLocal(ReturnUrl);
        //}

        //public ActionResult NoCookies(string ReturnUrl)
        //{
        //    CookieConsent.SetCookieConsent(Response, false);
        //    // if we got an ajax submit, just return 200 OK, else redirect back
        //    if (Request.IsAjaxRequest())
        //        return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
        //    else
        //        return RedirectToLocal(ReturnUrl);
        //}


        [OutputCache(Duration = 60 * 60 * 24 * 365, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult FacebookChannel()
        {
            return View();
        }

        [OutputCache(Duration = 60 * 60 * 24, Location = System.Web.UI.OutputCacheLocation.Any)]
        public FileContentResult RobotsText()
        {
            var content = new StringBuilder("User-agent: *" + Environment.NewLine);

            if (string.Equals(ConfigurationManager.AppSettings["SiteStatus"], "live", StringComparison.InvariantCultureIgnoreCase))
            {
                content.Append("Disallow: ").Append("/Account" + Environment.NewLine);
                content.Append("Disallow: ").Append("/Vendor" + Environment.NewLine);
                content.Append("Disallow: ").Append("/Error" + Environment.NewLine);
                content.Append("Disallow: ").Append("/signalr" + Environment.NewLine);
                content.Append("Disallow: ").Append("/Admin" + Environment.NewLine);
                content.Append("Disallow: ").Append("/Search" + Environment.NewLine);

                // exclude content pages with NoSearch set to "true"
                //var items = Query(new GetSeoContentPages(noSearch: true));
                var items = _repository.GetDisallowedContentPages();
                foreach (var item in items)
                {
                    content.Append("Disallow: ").Append(Url.Action("ContentPage", "Page", new { area = "", slug = item.Slug })).Append(Environment.NewLine);
                }
                content.Append("Sitemap: ").Append("https://").Append(ConfigurationManager.AppSettings["HostName"]).Append("/sitemap.xml" + Environment.NewLine);

            }
            else
            {
                // disallow indexing for test and dev servers
                content.Append("Disallow: /" + Environment.NewLine);
            }


            return File(
                    Encoding.UTF8.GetBytes(content.ToString()),
                    "text/plain");
        }

        [NonAction]
        private IEnumerable<CompareCloudware.Domain.Models.SiteMapNode> GetSitemapNodes()
        {
            List<CompareCloudware.Domain.Models.SiteMapNode> nodes = new List<CompareCloudware.Domain.Models.SiteMapNode>();

            nodes.Add(new CompareCloudware.Domain.Models.SiteMapNode(this.ControllerContext.RequestContext, new { area = "", controller = "Home", action = "Index" })
            {
                Frequency = SiteMapFrequencyEnum.Always,
                Priority = 0.8
            });

            //var items = Query(new GetSeoContentPages(false));
            var items = _repository.GetContentPages();
            foreach (var item in items)
            {
                //nodes.Add(new CompareCloudware.Domain.Models.SiteMapNode(this.ControllerContext.RequestContext, new { area = "", controller = "Page", action = "ContentPage", id = item.Slug })
                //nodes.Add(new CompareCloudware.Domain.Models.SiteMapNode(this.ControllerContext.RequestContext, new { area = "", controller = "", action = item.Slug, id = "" })
                nodes.Add(new CompareCloudware.Domain.Models.SiteMapNode(item.Slug)
                {
                    Frequency = item.Frequency,
                    Priority = 1,
                    LastModified = item.Modified
                });
            }

            return nodes;
        }

        [NonAction]
        private string GetSitemapXml()
        {
            XElement root;
            XNamespace xmlns = SitemapsNamespace;

            var nodes = GetSitemapNodes();

            root = new XElement(xmlns + "urlset");


            foreach (var node in nodes)
            {
                root.Add(
                new XElement(xmlns + "url",
                    new XElement(xmlns + "loc", Uri.EscapeUriString(node.Url)),
                    node.Priority == null ? null : new XElement(xmlns + "priority", node.Priority.Value.ToString("F1", CultureInfo.InvariantCulture)),
                    node.LastModified == null ? null : new XElement(xmlns + "lastmod", node.LastModified.Value.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzz")),
                    node.Frequency == null ? null : new XElement(xmlns + "changefreq", node.Frequency.Value.ToString().ToLowerInvariant())
                    ));
            }

            using (var ms = new MemoryStream())
            {
                using (var writer = new StreamWriter(ms, Encoding.UTF8))
                {
                    root.Save(writer);
                }

                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }


        [HttpGet]
        [OutputCache(Duration = 24 * 60 * 60, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult SitemapXml()
        {
            Trace.WriteLine("sitemap.xml was requested. User Agent: " + Request.Headers.Get("User-Agent"));

            var content = GetSitemapXml();
            return Content(content, "application/xml", Encoding.UTF8);
        }

        public ActionResult Google(string id)
        {
            if (ConfigurationManager.AppSettings["GoogleId"] == id)
                return View(model: id);
            else
                return new HttpNotFoundResult();
        }
    }
}
