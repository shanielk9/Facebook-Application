using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class FacebookPhoto : FacebookPost
    {
        public string PhotoPath { get; private set; }

        public FacebookPhoto(string i_PhotoTitle, string i_PhotoPath, FacebookAppDataManager i_DataManager) : base(i_PhotoTitle, i_DataManager)
        {
            PhotoPath = i_PhotoPath;
        }

        public override void Post()
        {
            try
            {
                DataManager.PostphotoOnYourWall(PhotoPath, PostTitle);
            }
            catch
            {
                throw;
            }
        }
    }
}
