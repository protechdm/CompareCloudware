using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using System.Dynamic;

namespace FacebookingTest
{
    public class AuthorizeFacebook
    {
        public void GetFriends()
        {
            var client = new FacebookClient();
            
            //client.Query(String.Format("SELECT uid, name FROM user WHERE uid IN (SELECT uid2 FROM friend WHERE uid1 = {0})", me.id));
            dynamic result = client.Get("skype");
            long likes = result.likes;
            //dynamic parameters = new ExpandoObject();
            //parameters.q = query;
            //dynamic results = client.Get("/fql", parameters);
        }
    }
}
