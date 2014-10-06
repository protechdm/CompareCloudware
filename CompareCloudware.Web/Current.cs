namespace CompareCloudware.Web
{
    using CompareCloudware.Web.Models;
    using System;
    using System.Web;

    public static class Current
    {
        public static IUser User
        {
            get
            {
                return (HttpContext.Current.Session["CurrentUser"] as IUser);
            }
            set
            {
                HttpContext.Current.Session["CurrentUser"] = value;
            }
        }
    }
}

