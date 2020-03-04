using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class FacebookLink : FacebookPost
    {
        public string LinkPath;

        public FacebookLink(string i_LinkTitle, string i_LinkPath, FacebookAppDataManager i_DataManager) : base(i_LinkTitle, i_DataManager)
        {
            LinkPath = i_LinkPath;
        }

        public override void Post()
        {
            try
            {
                DataManager.PostLinkOnYourWall(LinkPath, PostTitle);
            }
            catch
            {
                throw;
            }
        }
    }
}
