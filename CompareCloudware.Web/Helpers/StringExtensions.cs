namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Configuration;
    using System.Runtime.CompilerServices;

    public static class StringExtensions
    {
        public static string AddImagePath(this string imageName)
        {
            return (ConfigurationManager.AppSettings["LogosFolder"].ToString() + imageName);
        }
    }
}

