using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using TweetSharp;
//using TweetSharp.Twitter.Service;
using Hammock.Authentication.OAuth;
using System.Diagnostics;

namespace FaceSharp.Samples.WinForm
{
    public class AuthorizeLinkedIn
    {
        public AuthorizeLinkedIn()
        {
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
            //twitterService.SendTweet("A Simple Tweet from a Simple Twitter Client");
            //Console.WriteLine("Enter a Tweet");
            //string tweetMessage;

            //while (true)
            //{
            //    tweetMessage = Console.ReadLine();
            //    if (tweetMessage.ToLower() == "exit")
            //    {
            //        break;
            //    }
            //    twitterService.SendTweet(tweetMessage);
            //}

            var x = twitterService.ListFollowerIdsOf("_glynster_",-1);
            var y = twitterService.ListFollowerIdsOf("compcloudware", -1);
            
        }

        #region ConsumerKey & ConsumerSecret
        private static string ConsumerSecret
        {
            get { return ConfigurationManager.AppSettings["ConsumerSecret"]; }
        }

        private static string ConsumerKey
        {
            get { return ConfigurationManager.AppSettings["ConsumerKey"]; }
        }

        private static string AccessToken
        {
            get { return ConfigurationManager.AppSettings["AccessToken"]; }
        }
        private static string AccessTokenSecret
        {
            get { return ConfigurationManager.AppSettings["AccessTokenSecret"]; }
        }
        #endregion
    }
}
