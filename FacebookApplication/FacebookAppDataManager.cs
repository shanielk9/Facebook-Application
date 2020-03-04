using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class FacebookAppDataManager
    {
        private const int k_AgeNotDeclare = -1;
        private const string k_NotDeclareInfo = "Not declare";
        private readonly List<IDataInitializeObserver> m_DataInitializeObservers = new List<IDataInitializeObserver>();
       
        public User LoggedInUser { get; private set; }

        public FacebookObjectCollection<Post> UserPostsList { get; private set; }

        public FacebookObjectCollection<User> UserFriends { get; private set; }

        public FacebookObjectCollection<string> UserBasicInfo { get; private set; }

        public FacebookObjectCollection<Photo> UserPhotos { get; private set; }

        public FacebookObjectCollection<Album> UserAlbums { get; private set; }

        public FacebookObjectCollection<Event> UserEvents { get; private set; }

        public FacebookObjectCollection<Group> UserGroups { get; private set; }

        public string ProfilePicURL { get; private set; }

        public string CoverPicURL { get; private set; }

        public string UserName { get; private set; }

        public int UserAge { get; private set; }

        public int UserYearOfBirth { get; private set; }

        public int UserMonthOfBirth { get; private set; }

        public int UserDayOfBirth { get; private set; }

        public string UserId { get; private set; }

        public string UserLocation { get; private set; }

        public FacebookAppDataManager()
        {
        }

        public void InitializeUserData(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            UserName = LoggedInUser.Name;
            ProfilePicURL = LoggedInUser.PictureNormalURL;
            CoverPicURL = setCoverPhoto();

            initializeBasicInfo();
            initializePostsList();
            initializeFriendsList();
            initializeGroupsList();
            initializeEventsList();
            initializePhotosList();
            setUserAge();
            setUserId();
            setUserLocation();
            doWhenDataInitialize();     
        }

        public FacebookAppDataManager(User i_LoggedInUser)
        {
            InitializeUserData(i_LoggedInUser);
        }

        public void AttachObserver(IDataInitializeObserver i_DataInitializeObserver)
        {
            m_DataInitializeObservers.Add(i_DataInitializeObserver);
        }

        public void DetachObserver(IDataInitializeObserver i_DataInitializeObserver)
        {
            m_DataInitializeObservers.Remove(i_DataInitializeObserver);
        }

        private void doWhenDataInitialize()
        {
            notifyAllDataInitializedObservers();
        }

        private void notifyAllDataInitializedObservers()
        {
           foreach(IDataInitializeObserver observer in m_DataInitializeObservers)
            {
                observer.AllDataInitialized();
            }
        }

        public void PostphotoOnYourWall(string i_PhotoPath, string i_Title)
        {
            try
            {
                Post postedPhoto = LoggedInUser.PostPhoto(i_PhotoPath, i_Title);
                MessageBox.Show("Photo Id: ", postedPhoto.Id);
            }
            catch
            {
                throw;
            }
        }

        public void PostLinkOnYourWall(string i_LinkPath, string i_Title)
        {
            try
            {
                Link postedLink = LoggedInUser.PostLink(i_LinkPath, i_Title);
                MessageBox.Show("Link Id: ", postedLink.Id);
            }
            catch
            {
                throw;
            }
        }

        public bool PostOnYourFriendWall(string i_MessageToFriend, string i_FriendId)
        {
            bool isPosted;
            try
            {
                LoggedInUser.PostStatus(i_MessageToFriend, i_FriendId);
                isPosted = true;
            }
            catch(Exception)
            {
                isPosted = false;
            }

            return isPosted;
        }

        public void PostStatusOnYourWall(string i_Message)
        {
            try
            {
                Status postedStatus = LoggedInUser.PostStatus(i_Message);
                MessageBox.Show("Status Id: ", postedStatus.Id);
            }
            catch
            {
                throw;
            }
        }

        private void setUserLocation()
        {
            try
            {
                UserLocation = LoggedInUser.Location.Name;
            }
            catch (Exception)
            {
                UserLocation = string.Empty;
            }
        }

        private void setUserId()
        {
            try
            {
                UserId = LoggedInUser.Id;
            }
            catch (Exception)
            {
                UserId = string.Empty;
            }
        }

        private void setUserAge()
        {
            UserAge = 0;
            if (LoggedInUser.Birthday != string.Empty)
            {
                string[] dateOfBirth = LoggedInUser.Birthday.Split('/');
                UserYearOfBirth = int.Parse(dateOfBirth[2]);
                UserMonthOfBirth = int.Parse(dateOfBirth[0]);
                UserDayOfBirth = int.Parse(dateOfBirth[1]);

                UserAge = DateTime.Now.Year - UserYearOfBirth;

                if (DateTime.Now.Month < UserMonthOfBirth)
                {
                    UserAge = UserAge - 1;
                }

                if (DateTime.Now.Month == UserMonthOfBirth)
                {
                    if (DateTime.Now.DayOfYear < UserDayOfBirth)
                    {
                        UserAge = UserAge - 1;
                    }
                }
            }
            else
            {
                UserAge = k_AgeNotDeclare;
                UserDayOfBirth = -1;
                UserMonthOfBirth = -1;
                UserYearOfBirth = -1;
            }
        }

        private void initializePhotosList()
        {
            UserPhotos = new FacebookObjectCollection<Photo>();
            UserAlbums = new FacebookObjectCollection<Album>();

            try
            {
                foreach (Album album in LoggedInUser.Albums)
                {
                    UserAlbums.Add(album);

                    foreach (Photo photo in album.Photos)
                    {
                        UserPhotos.Add(photo);
                    }
                }
            }
            catch (Exception)
            {
                UserPhotos = null;
                UserAlbums = null;
            }
        }

        private void initializeGroupsList()
        {
            UserGroups = new FacebookObjectCollection<Group>();
            try
            {
                foreach (Group group in LoggedInUser.Groups)
                {
                    UserGroups.Add(group);
                }
            }
            catch (Exception)
            {
                UserGroups = null;
            }
        }

        private void initializeEventsList()
        {
            UserEvents = new FacebookObjectCollection<Event>();
            try
            {
                foreach (Event fbEvent in LoggedInUser.Events)
                {
                    UserEvents.Add(fbEvent);
                }
            }
            catch (Exception)
            {
                UserEvents = null;
            }
        }

        private void initializeFriendsList()
        {
            UserFriends = new FacebookObjectCollection<User>();
            try
            {
                foreach (User friend in LoggedInUser.Friends)
                {
                    UserFriends.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            catch (Exception)
            {
                UserFriends = null;
            }
        }

        private void initializePostsList()
        {
            UserPostsList = new FacebookObjectCollection<Post>();
            try
            {
                if (LoggedInUser.Posts.Count > 0)
                {
                    foreach (Post post in LoggedInUser.Posts)
                    {
                        UserPostsList.Add(post);
                    }
                }
            }
            catch (Exception)
            {
                UserPostsList = null;
            }
        }

        private void initializeBasicInfo()
        {
            UserBasicInfo = new FacebookObjectCollection<string>();
            try
            {
                if (LoggedInUser.Gender != null)
                {
                    UserBasicInfo.Add("Gender: " + LoggedInUser.Gender);
                }
                else
                {
                    UserBasicInfo.Add("Gender: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.Birthday != null)
                {
                    UserBasicInfo.Add("Birthday date: " + LoggedInUser.Birthday);
                }
                else
                {
                    UserBasicInfo.Add("Birthday date: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.Location.Name != null)
                {
                    UserBasicInfo.Add("Location: " + LoggedInUser.Location.Name);
                }
                else
                {
                    UserBasicInfo.Add("Location: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.Email != null)
                {
                    UserBasicInfo.Add("Email: " + LoggedInUser.Email);
                }
                else
                {
                    UserBasicInfo.Add("Email: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.RelationshipStatus != null)
                {
                    UserBasicInfo.Add("Relationship Status: " + LoggedInUser.RelationshipStatus);
                }
                else
                {
                    UserBasicInfo.Add("Relationship Status: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.Educations != null)
                {
                    UserBasicInfo.Add("Educations: " + LoggedInUser.Educations[0].ToString());
                }
                else
                {
                    UserBasicInfo.Add("Educations: " + k_NotDeclareInfo);
                }

                if (LoggedInUser.WorkExperiences != null)
                {
                    UserBasicInfo.Add("Work: " + LoggedInUser.WorkExperiences[0].ToString());
                }
                else
                {
                    UserBasicInfo.Add("Work: " + k_NotDeclareInfo);
                }
            }
            catch (Exception)
            {
                UserBasicInfo.Add("Cannot retrive info");
            }
        }

        private string setCoverPhoto()
        {
            string coverPhotoURL = string.Empty;

            try
            {
                foreach (Album album in LoggedInUser.Albums)
                {
                    string name = album.Name.ToLower();
                    if (name == "cover photos")
                    {
                        coverPhotoURL = album.Photos[0].PictureNormalURL;
                    }
                }
            }
            catch (Exception)
            {
                coverPhotoURL = string.Empty;
            }

            return coverPhotoURL;
        }
    }
}