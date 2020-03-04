using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class FacebookObjectWrapper
    {
        private FacebookObject m_FacebookObject;

        public FacebookObjectWrapper(FacebookObject i_FacebookObject)
        {
            m_FacebookObject = i_FacebookObject;
        }

        public override string ToString()
        {
            string tostring;

            switch(m_FacebookObject)
            {
                case User user:
                    tostring = user.Birthday + " " + user.Name;
                    break;
                case Event fbEvent:
                    tostring = fbEvent.StartTime.Value.ToShortDateString() + " " + fbEvent.Name;
                    break;
                case Group group:
                    tostring = group.UpdateTime.Value.ToShortDateString() + " " + group.Name;
                    break;
                case Post post:
                    tostring = post.CreatedTime.Value.ToShortDateString() + " " + post.Message;
                    break;
                default:
                    tostring = m_FacebookObject.ToString();
                    break;
            }

            return tostring;
        }
    }
}
