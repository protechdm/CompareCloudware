using CompareCloudware.Web;
using CompareCloudware.Web.FluentSecurity;
using System;
using System.Linq;
using System.Web.Security;
using CompareCloudware.Domain.Contracts.Repositories;
using System.Web.Mvc;
using System.Web;
using CompareCloudware.POCOQueryRepository;
using log4net.Layout.Pattern;
using System.IO;

namespace CompareCloudware.Web.Helpers
{

    public static class SiteActivities
    {
        public static bool Log(ICompareCloudwareRepository repository, HttpRequestBase request)
        {
            repository.LogSiteActivity(request);
            return true;
        }

        public static bool Log(HttpRequestBase request)
        {
            ICompareCloudwareRepository repository = new POCOQueryRepository.QueryRepository(new CompareCloudwareContext());
            repository.LogSiteActivity(request);
            return true;
        }

        //public static bool Log(ICloudCompareRepository repository, string request)
        //{
        //    repository.LogSiteActivity(request);
        //    return true;
        //}

    }

    public class IPPatternConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (HttpContext.Current != null)
            {
                writer.Write("USER HOST ADDRESS:" + HttpContext.Current.Request.UserHostAddress);
            }
            else
            {
                writer.Write("NO USERHOSTADDRESS");
            }
        }
    }

    public class UrlPatternConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (HttpContext.Current != null)
            {
                writer.Write("URI:" + HttpContext.Current.Request.Url.AbsoluteUri);
            }
            else
            {
                writer.Write("NO URI");
            }
        }
    }

    public class UserAgentPatternConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (HttpContext.Current != null)
            {
                writer.Write("USER AGENT:" + HttpContext.Current.Request.UserAgent);
            }
            else
            {
                writer.Write("NO USERAGENT");
            }
        }
    }

    public class SessionPatternConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (HttpContext.Current != null)
            {
                writer.Write("SESSION:" + HttpContext.Current.Session.SessionID);
            }
            else
            {
                writer.Write("NO SESSION");
            }
        }
    }

}

