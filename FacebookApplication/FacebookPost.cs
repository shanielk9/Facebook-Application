using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public abstract class FacebookPost
    {
        public enum ePostType
        {
            Status = 0,
            Photo,
            Link
        }

        public string PostTitle { get; set; }

        public FacebookAppDataManager DataManager { get; private set; }

        public FacebookPost(string i_PostTitle, FacebookAppDataManager i_DataManager)
        {
            PostTitle = i_PostTitle;
            DataManager = i_DataManager;
        }

        public abstract void Post();
    }
}
