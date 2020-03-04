using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class MemoriesSearch
    {
        private const string k_NoAccessMessage = "There is no access to user's ";
        private const string k_NoAccessToDetailsMessage = "There is no access to this detail in ";

        private List<Image> m_MemoriesOfPhotosList;
        private FacebookObjectCollection<FacebookObjectWrapper> m_FacebookObjectWrapper;

        private DateTime m_StartDate;
        private DateTime m_EndDate;

        public MemoriesSearch()
        {
            m_MemoriesOfPhotosList = new List<Image>();
            m_FacebookObjectWrapper = new FacebookObjectCollection<FacebookObjectWrapper>();
        }

        private string getEmptyStringMessage(string i_StringToAdd)
        {
            string msg = string.Format("No {0} in these dates!", i_StringToAdd);

            return msg;
        }

        public List<Image> GetMemoriesOfPhotos(bool i_IsOneDay, DateTime i_StartDate, DateTime i_EndDate, FacebookObjectCollection<Photo> i_PhotosList)
        {
            m_StartDate = i_StartDate;
            m_MemoriesOfPhotosList.Clear();

            if (i_PhotosList != null)
            {
                if (i_IsOneDay)
                {
                    foreach (Photo photo in i_PhotosList)
                    {
                        if (photo.CreatedTime.Value.Date == m_StartDate.Date)
                        {
                            m_MemoriesOfPhotosList.Add(photo.ImageNormal);
                        }
                    }
                }
                else
                {
                    m_EndDate = i_EndDate;

                    foreach (Photo photo in i_PhotosList)
                    {
                        if ((photo.CreatedTime.Value.Date >= m_StartDate.Date) && (photo.CreatedTime.Value.Date <= m_EndDate.Date))
                        {
                            m_MemoriesOfPhotosList.Add(photo.ImageNormal);
                        }
                    }
                }
            }

            return m_MemoriesOfPhotosList;
        }

        public FacebookObjectCollection<FacebookObjectWrapper> GetMemoriesOfFriends(bool i_IsOneDay, DateTime i_StartDate, DateTime i_EndDate, FacebookObjectCollection<User> i_FriendList)
        {
            m_StartDate = i_StartDate;
            m_FacebookObjectWrapper.Clear();

            if (i_FriendList == null)
            {
                throw new Exception(k_NoAccessMessage + "friends!");
            }
            else
            {
                try
                {
                    if (i_IsOneDay)
                    {
                        foreach (User friend in i_FriendList)
                        {
                            if (friend.Birthday == m_StartDate.Date.ToShortDateString())
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(friend));
                            }
                        }
                    }
                    else
                    {
                        m_EndDate = i_EndDate;

                        foreach (User friend in i_FriendList)
                        {
                            if ((friend.UpdateTime.Value.Date >= m_StartDate.Date) && (friend.UpdateTime.Value.Date <= m_EndDate.Date))
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(friend));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception(k_NoAccessToDetailsMessage + "friend's user");
                }
            }

            if (m_FacebookObjectWrapper.Count == 0)
            {
                throw new Exception(getEmptyStringMessage("friends"));
            }

            return m_FacebookObjectWrapper;
        }

        public FacebookObjectCollection<FacebookObjectWrapper> GetMemoriesOfPosts(bool i_IsOneDay, DateTime i_StartDate, DateTime i_EndDate, FacebookObjectCollection<Post> i_PostList)
        {
            m_StartDate = i_StartDate;
            m_FacebookObjectWrapper.Clear();

            if (i_PostList == null)
            {
                throw new Exception(k_NoAccessMessage + " posts!");
            }
            else
            {
                try
                {
                    if (i_IsOneDay)
                    {
                        foreach (Post post in i_PostList)
                        {
                            if (post.CreatedTime.Value.Date == m_StartDate.Date)
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(post));
                            }
                        }
                    }
                    else
                    {
                        m_EndDate = i_EndDate;

                        foreach (Post post in i_PostList)
                        {
                            if ((post.CreatedTime.Value.Date >= m_StartDate.Date) && (post.CreatedTime.Value.Date <= m_EndDate.Date))
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(post));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception(k_NoAccessToDetailsMessage + "posts");
                }
            }

            if (m_FacebookObjectWrapper.Count == 0)
            {
                throw new Exception(getEmptyStringMessage("post"));
            }

            return m_FacebookObjectWrapper;
        }

        public FacebookObjectCollection<FacebookObjectWrapper> GetMemoriesOfEvents(bool i_IsOneDay, DateTime i_StartDate, DateTime i_EndDate, FacebookObjectCollection<Event> i_EventsList)
        {
            m_StartDate = i_StartDate;
            m_FacebookObjectWrapper.Clear();

            if (i_EventsList == null)
            {
                throw new Exception(k_NoAccessMessage + "events!");
            }
            else
            {
                try
                {
                    if (i_IsOneDay)
                    {
                        foreach (Event fbEvent in i_EventsList)
                        {
                            if (fbEvent.StartTime.Value.Date == m_StartDate.Date)
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(fbEvent));
                            }
                        }
                    }
                    else
                    {
                        m_EndDate = i_EndDate;

                        foreach (Event fbEvent in i_EventsList)
                        {
                            if ((fbEvent.StartTime.Value.Date >= m_StartDate.Date) && (fbEvent.StartTime.Value.Date <= m_EndDate.Date))
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(fbEvent));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception(k_NoAccessToDetailsMessage + "events");
                }
            }

            if (m_FacebookObjectWrapper.Count == 0)
            {
                throw new Exception(getEmptyStringMessage("events"));
            }

            return m_FacebookObjectWrapper;
        }

        public FacebookObjectCollection<FacebookObjectWrapper> GetMemoriesOfGroups(bool i_IsOneDay, DateTime i_StartDate, DateTime i_EndDate, FacebookObjectCollection<Group> i_GroupsList)
        {
            m_StartDate = i_StartDate;
            m_FacebookObjectWrapper.Clear();

            if (i_GroupsList == null)
            {
                throw new Exception(k_NoAccessMessage + " groups!");
            }
            else
            {
                try
                {
                    if (i_IsOneDay)
                    {
                        foreach (Group group in i_GroupsList)
                        {
                            if (group.UpdateTime.Value.Date == m_StartDate.Date)
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(group));
                            }
                        }
                    }
                    else
                    {
                        m_EndDate = i_EndDate;

                        foreach (Group group in i_GroupsList)
                        {
                            if ((group.UpdateTime.Value.Date >= m_StartDate.Date) && (group.UpdateTime.Value.Date <= m_EndDate.Date))
                            {
                                m_FacebookObjectWrapper.Add(new FacebookObjectWrapper(group));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception(k_NoAccessToDetailsMessage + "groups");
                }

                if (m_FacebookObjectWrapper.Count == 0)
                {
                    throw new Exception(getEmptyStringMessage("groups"));
                }
            }

            return m_FacebookObjectWrapper;
        }
    }
}
