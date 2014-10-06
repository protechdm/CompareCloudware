using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Facebook;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace FacebookingTest
{
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();

        }

        public string ApplicationId 
        { 
            get 
            { 
                return ConfigurationManager.AppSettings["ApplicationId"]; 
            } 
        }

        public string ExtendedPermissions 
        { 
            get
            {
                return ConfigurationManager.AppSettings["ExtendedPermissions"];
            } 
        }

        public string AppSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationSecret"];
            }
        }

        public string AccessToken { get; set; }

        private void LoadAuthorize(object sender, EventArgs e)
        {
            AuthorizeFacebook af = new AuthorizeFacebook();
            af.GetFriends();

            var client = new FacebookClient();
            dynamic me = client.Get("totten");
            

            var destinationURL = String.Format(
                //@"https://www.facebook.com/dialog/oauth?client_id={0}&scope={1}&redirect_uri=http://www.facebook.com/connect/login_success.html&response_type=token",
                @"https://www.facebook.com/dialog/oauth?client_id={0}&scope={1}&redirect_uri=http://www.facebook.com/connect/login_success.html&response_type=token&req_perms=read_stream,publish_stream&ext_perm=publish_stream",
                this.ApplicationId,
                this.ExtendedPermissions);
            webBrowser.Navigated += WebBrowserNavigated;
            webBrowser.Navigate(destinationURL);

        //http://www.facebook.com/login.php?api_key={API_KEY_GOES_HERE}&next=http://www.facebook.com/connect/login_success.html&req_perms=read_stream,publish_stream
        //http://www.facebook.com/connect/prompt_permissions.php?api_key={API_KEY_GOES_HERE}&next=http://www.facebook.com/connect/login_success.html?xxRESULTTOKENxx&display=popup&ext_perm=publish_stream&profile_selector_ids={PAGE_ID_GOES_HERE}
        }

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // get token
            var url = e.Url.Fragment;
            if (url.Contains("access_token") && url.Contains("#"))
            {
                this.Hide();
                url = (new Regex("#")).Replace(url, "?", 1);
                this.AccessToken = System.Web.HttpUtility.ParseQueryString(url).Get("access_token");
                //MessageBox.Show(facebookCore.AccessToken);
                try
                {
                    //var facebooking = new FacebookingTest(facebookCore.AccessToken);
                    //facebooking.UpdateStatus();
                    var fb = new FacebookClient(this.AccessToken);
                    fb.AppId = "354378121311673";
                    fb.AppSecret = "8cbab00b01b8fb7d9ce43e576aebe576";

                    //dynamic accts = fb.Get(string.Format("/{0}/accounts", this.AccessToken));

                    string postMessage = DateTime.Now.Ticks.ToString();
                    //dynamic result = fb.Post("me/feed", new { message = postMessage });
                    //var newPostId = result.id;

                    //result = fb.Post("100690206670310/feed", new { message = postMessage });
                    //newPostId = result.id;

                    //result = fb.Post("PorcupineTreeOfficial/feed", new { message = postMessage });
                    //newPostId = result.id;

                    //https://www.facebook.com/PorcupineTreeOfficial
                    dynamic result2 = fb.Get("https://graph.facebook.com/PorcupineTreeOfficial");
                    Int64 x = result2.likes;
                    System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
                    //var x = jss.Serialize(result2);
                    //dynamic stuff = jss.Deserialize(x,typeof(List<string>));
                    dynamic myInfo = fb.Get("/me/friends");
                    foreach (dynamic friend in myInfo.data)
                    {
                        //Response.Write("Name: " + friend.name + "<br/>Facebook id: " + friend.id + "<br/><br/>");
                    }

                }
                catch (Exception exception)
                {
                    Console.Write(exception);
                }
            }

        }
    }
}
