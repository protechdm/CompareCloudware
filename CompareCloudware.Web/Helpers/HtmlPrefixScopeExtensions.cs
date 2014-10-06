namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Web;
    using System.Web.Mvc;

    public static class HtmlPrefixScopeExtensions
    {
        private const string idsToReuseKey = "__htmlPrefixScopeExtensions_IdsToReuse_";

        public static IDisposable BeginCollectionItem(this HtmlHelper html, string collectionName)
        {
            Queue<string> idsToReuse = GetIdsToReuse(html.ViewContext.HttpContext, collectionName);
            string itemIndex = (idsToReuse.Count > 0) ? idsToReuse.Dequeue() : Guid.NewGuid().ToString();
            html.ViewContext.Writer.WriteLine(string.Format("<input type=\"hidden\" name=\"{0}.index\" autocomplete=\"off\" value=\"{1}\" />", collectionName, html.Encode(itemIndex)));
            return html.BeginHtmlFieldPrefixScope(string.Format("{0}[{1}]", collectionName, itemIndex));
        }

        public static IDisposable BeginHtmlFieldPrefixScope(this HtmlHelper html, string htmlFieldPrefix)
        {
            return new HtmlFieldPrefixScope(html.ViewData.TemplateInfo, htmlFieldPrefix);
        }

        private static Queue<string> GetIdsToReuse(HttpContextBase httpContext, string collectionName)
        {
            string key = "__htmlPrefixScopeExtensions_IdsToReuse_" + collectionName;
            Queue<string> queue = (Queue<string>) httpContext.Items[key];
            if (queue == null)
            {
                httpContext.Items[key] = queue = new Queue<string>();
                string previouslyUsedIds = httpContext.Request[collectionName + ".index"];
                if (string.IsNullOrEmpty(previouslyUsedIds))
                {
                    return queue;
                }
                foreach (string previouslyUsedId in previouslyUsedIds.Split(new char[] { ',' }))
                {
                    queue.Enqueue(previouslyUsedId);
                }
            }
            return queue;
        }

        private class HtmlFieldPrefixScope : IDisposable
        {
            private readonly string previousHtmlFieldPrefix;
            private readonly TemplateInfo templateInfo;

            public HtmlFieldPrefixScope(TemplateInfo templateInfo, string htmlFieldPrefix)
            {
                this.templateInfo = templateInfo;
                this.previousHtmlFieldPrefix = templateInfo.HtmlFieldPrefix;
                templateInfo.HtmlFieldPrefix = htmlFieldPrefix;
            }

            public void Dispose()
            {
                this.templateInfo.HtmlFieldPrefix = this.previousHtmlFieldPrefix;
            }
        }
    }
}

