using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class FacebookStatus : FacebookPost
    {
        public FacebookStatus(string i_StatusText, FacebookAppDataManager i_DataManager) : base(i_StatusText, i_DataManager)
        {
        }

        public override void Post()
        {
            try
            {
                DataManager.PostStatusOnYourWall(PostTitle);
            }
            catch
            {
                throw;
            }
        }
    }
}
