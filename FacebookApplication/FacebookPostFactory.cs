using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class FacebookPostFactory
    {
        public static FacebookPost CreateFacebookPost(FacebookPost.ePostType i_PostType, string i_Title, string i_Path, FacebookAppDataManager i_DataManager)
        {
            FacebookPost facebookPostToReturn = null;

            switch (i_PostType)
            {
                case FacebookPost.ePostType.Status:
                    facebookPostToReturn = new FacebookStatus(i_Title, i_DataManager);
                    break;

                case FacebookPost.ePostType.Photo:
                    facebookPostToReturn = new FacebookPhoto(i_Title, i_Path, i_DataManager);
                    break;

                case FacebookPost.ePostType.Link:
                    facebookPostToReturn = new FacebookLink(i_Title, i_Path, i_DataManager);
                    break;
            }

            return facebookPostToReturn;
        }
    }
}
