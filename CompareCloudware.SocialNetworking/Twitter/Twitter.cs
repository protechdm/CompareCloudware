using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using TweetSharp;
//using TweetSharp.Twitter.Service;
using Hammock.Authentication.OAuth;
using System.Diagnostics;

namespace CompareCloudware.SocialNetworking
{
    public class Twitter
    {
        public long GetTwitterFollowerCount(string vendorName)
        {
            long followerCount = 0;
            TwitterClientInfo twitterClientInfo = new TwitterClientInfo();
            twitterClientInfo.ConsumerKey = ConsumerKey; //Read ConsumerKey out of the app.config
            twitterClientInfo.ConsumerSecret = ConsumerSecret; //Read the ConsumerSecret out the app.config

            TwitterService twitterService = new TwitterService(twitterClientInfo);
            if (string.IsNullOrEmpty(AccessToken) || string.IsNullOrEmpty(AccessTokenSecret))
            {
                //Now we need the Token and TokenSecret

                //Firstly we need the RequestToken and the AuthorisationUrl
                OAuthRequestToken requestToken = twitterService.GetRequestToken();
                Uri authUrl = twitterService.GetAuthorizationUri(requestToken);

                //authUrl is just a URL we can open IE and paste it in if we want
                Console.WriteLine("Please Allow This App to send Tweets on your behalf");
                Process.Start(authUrl.ToString()); //Launches a browser that'll go to the AuthUrl.

                //Allow the App
                Console.WriteLine("Enter the PIN from the Browser:");
                string pin = Console.ReadLine();

                OAuthAccessToken accessToken = twitterService.GetAccessToken(requestToken, pin);

                string token = accessToken.Token; //Attach the Debugger and put a break point here
                string tokenSecret = accessToken.TokenSecret; //And another Breakpoint here

                Console.WriteLine("Write Down The AccessToken: " + token);
                Console.WriteLine("Write Down the AccessTokenSecret: " + tokenSecret);

            }

            twitterService.AuthenticateWith(AccessToken, AccessTokenSecret);
            //var status = twitterService.GetRateLimitStatus();
            GetUserProfileForOptions o = new GetUserProfileForOptions();
            o.ScreenName = vendorName;
            //var user = twitterService.GetUserProfileFor(vendorName);
            var user = twitterService.GetUserProfileFor(o);
            if (user != null)
            {
                followerCount = user.FollowersCount;
            }
            return followerCount;
        }

        #region ConsumerKey & ConsumerSecret
        private static string ConsumerSecret
        {
            get { return ConfigurationManager.AppSettings["TwitterConsumerSecret"]; }
        }

        private static string ConsumerKey
        {
            get { return ConfigurationManager.AppSettings["TwitterConsumerKey"]; }
        }

        private static string AccessToken
        {
            get { return ConfigurationManager.AppSettings["TwitterAccessToken"]; }
        }
        private static string AccessTokenSecret
        {
            get { return ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]; }
        }
        #endregion
    }
}