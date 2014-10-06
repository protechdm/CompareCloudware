namespace CompareCloudware.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Web.Mvc;

    public static class FormCollectionExtensions
    {
        public static string GetSubmitButtonName(this FormCollection formCollection)
        {
            return formCollection.GetSubmitButtonName(false);
        }

        public static string GetSubmitButtonName(this FormCollection formCollection, bool throwOnError)
        {
            string imageButton = (from x in formCollection.Keys.OfType<string>()
                where x.EndsWith(".x")
                select x).SingleOrDefault<string>();
            string textButton = (from x in formCollection.Keys.OfType<string>()
                where x.StartsWith("Submit_")
                select x).SingleOrDefault<string>();
            if (textButton != null)
            {
                return textButton.Substring("Submit_".Length);
            }
            if (imageButton != null)
            {
                return imageButton.Substring(0, imageButton.Length - 2);
            }
            if (throwOnError)
            {
                throw new ApplicationException("No button found");
            }
            return null;
        }
    }
}

