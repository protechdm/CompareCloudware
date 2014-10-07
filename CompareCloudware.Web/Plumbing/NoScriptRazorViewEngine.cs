namespace CompareCloudware.Web.Plumbing
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class NoScriptRazorViewEngine : RazorViewEngine
    {
        private static string[] NoScriptPartialFormats = new string[] { "~/Views/Shared/NoScript/{0}.cshtml", "~/Views/{1}/PartialPages/NoScript/{0}.cshtml" };

        public NoScriptRazorViewEngine()
        {
            base.PartialViewLocationFormats = base.ViewLocationFormats.Union<string>(NoScriptPartialFormats).ToArray<string>();
        }
    }
}

