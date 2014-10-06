using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using System.Dynamic;

namespace CompareCloudware.SocialNetworking
{
    public class Facebook
    {
        public long GetFacebookFans(string vendorName)
        {
            long likes = 0;
            string id = "";
            bool errorThrown = false;
            var client = new FacebookClient();

            //client.Query(String.Format("SELECT uid, name FROM user WHERE uid IN (SELECT uid2 FROM friend WHERE uid1 = {0})", me.id));
            dynamic result;
            try
            {
                result = client.Get(vendorName);
                if (result != null)
                {
                    id = result.id;
                    likes = result.likes;
                }
            }
            catch (Exception e)
            {
                errorThrown = true;
            }
            finally
            {
            }

            if (errorThrown)
            {
                try
                {
                    result = client.Get(vendorName.ToUpperInvariant());
                    if (result != null)
                    {
                        likes = result.likes;
                    }
                }
                catch (Exception e)
                {
                    errorThrown = true;
                }

            }
            return likes;
        }
    }
}
