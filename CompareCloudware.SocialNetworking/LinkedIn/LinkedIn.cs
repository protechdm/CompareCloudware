using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using TweetSharp;
//using TweetSharp.Twitter.Service;
using Hammock.Authentication.OAuth;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace CompareCloudware.SocialNetworking
{
    public class LinkedIn
    {
        private OAuthLinkedIn _oauth = new OAuthLinkedIn();

        public long GetLinkedInFollowerCount(string vendorName)
        {
            long followerCount = 0;

            //_oauth.Token = "9598bca0-b267-4f3e-a7c5-a7adf2d22bcb";
            //_oauth.TokenSecret = "1ac32278-0cf5-45ae-9bc8-eedde65024f5";
            //_oauth.Token = "euxq0ly6paev";
            //_oauth.TokenSecret = "boMb1TvGuQ72hVYW";

            _oauth.Token = ConfigurationManager.AppSettings["LinkedInAccessToken"];
            _oauth.TokenSecret = ConfigurationManager.AppSettings["LinkedInAccessTokenSecret"];
            
            //string retVal1 = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/people/~", null);
            //string retVal2 = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/universal-name=skype:(num-followers,id,name,ticker,description)", null);
            //vendorName = "skype";
            //string xml = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/universal-name=" + vendorName.ToLowerInvariant() + ":(num-followers,id,name,ticker,description)", null);

            //string id = "837959";
            string xml = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/id=" + vendorName.ToLowerInvariant() + ":(num-followers,id,name,ticker,description)", null);
            //string xml2 = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/companies/" + vendorName.ToLowerInvariant() + ":(num-followers,id,name,ticker,description)", null);
            
            //string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><company><num-followers>15947</num-followers><id>7299</id><name>Skype</name><description>Skype is about breaking down the barriers to communication and we're doing it with technology that is inventive, dependable, easy to use and affordable. We're passionate about impacting the world and even more excited to be part of a new generation of brands that are revolutionising (and disrupting!) the 21st century. Everyday Skype enables 100's of millions of people to be together, even when they're apart. We're global thinkers with offices in Hong Kong, London, Luxembourg, Moscow, New York, Palo Alto, Prague, Singapore, Stockholm, Tallinn, Tartu and Tokyo. Our wonderful offices are relaxed, funky, innovative and dog friendly - we're more like family around here. A super productive bunch, we are performance driven and dedicated to unleashing wonder! Skype is a division of Microsoft Corp. (NASDAQ: MSFT).</description></company>";

            if (xml.Length > 0)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);

                TextReader tr = new StringReader(xml);
                //StreamReader sr = new StreamReader(
                XDocument xDoc = XDocument.Load(tr);
                XElement numFollowers = (from doc in xDoc.Elements("company").Elements("num-followers") select doc).FirstOrDefault();

                //string retVal3 = _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/people/~/connections", null);

                followerCount = numFollowers.Value != null ? Convert.ToInt64(numFollowers.Value) : 0;
            }
            return followerCount;
        }

        #region ConsumerKey & ConsumerSecret
        private static string LinkedInConsumerSecret
        {
            get { return ConfigurationManager.AppSettings["LinkedInConsumerSecret"]; }
        }

        private static string LinkedInConsumerKey
        {
            get { return ConfigurationManager.AppSettings["LinkedInConsumerKey"]; }
        }

        private static string LinkedInAccessToken
        {
            get { return ConfigurationManager.AppSettings["LinkedInAccessToken"]; }
        }
        private static string LinkedInAccessTokenSecret
        {
            get { return ConfigurationManager.AppSettings["LinkedInAccessTokenSecret"]; }
        }
        #endregion
    }
}