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
    public partial class FormFacebookApplication : Form, IDataInitializeObserver
    { 
        private const string k_EmptyStringMessage = "Please fill all required fields :)";
        private readonly Image r_DefaultCoverPhoto = Properties.Resources.Cover_photo;
        private FacebookAppDataManager m_DataManager;
        private User m_LoggedInUser;

        public FormFacebookApplication(User i_LoggedInUser)
        {
            InitializeComponent();
            initializeLabelUserName();
            m_LoggedInUser = i_LoggedInUser;
            new Thread(initializeDataManager).Start();
        }

        private void initializeDataManager()
        {
            m_DataManager = new FacebookAppDataManager();
            m_DataManager.AttachObserver(this as IDataInitializeObserver);
            m_DataManager.InitializeUserData(m_LoggedInUser);
        }

        public void AllDataInitialized()
        {
            populateUIFromFacebookData();
            MessageBox.Show("Welcome To Facebook! :)");
            enableButtons();
        }

        private void enableButtons()
        {
            buttonMemories.Invoke(new Action(() => buttonMemories.Enabled = true));
            buttonFriendshipTest.Invoke(new Action(() => buttonFriendshipTest.Enabled = true));
            buttonAlbums.Invoke(new Action(() => buttonAlbums.Enabled = true));
            buttonLogout.Invoke(new Action(() => buttonLogout.Enabled = true));
            buttonPost.Invoke(new Action(() => buttonPost.Enabled = true));
            tabControlPostItems.Invoke(new Action(() => tabControlPostItems.Enabled = true));
        }

        private void populateUIFromFacebookData()
        {
            labelUserName.Invoke(new Action(() => labelUserName.Text = m_DataManager.UserName));
            new Thread(getProfileAndCoverPhotos).Start();
            new Thread(fetchBasicInfo).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchPosts).Start();
        }

        private void getProfileAndCoverPhotos()
        {
            UserPicbox.Invoke(new Action(() => UserPicbox.LoadAsync(m_DataManager.ProfilePicURL)));
            if (m_DataManager.CoverPicURL != string.Empty)
            {
                pictureBoxCoverPhoto.Invoke(new Action(
                    () => pictureBoxCoverPhoto.LoadAsync(m_DataManager.CoverPicURL)));
            }
            else
            {
                pictureBoxCoverPhoto.Invoke(new Action(
                    () => pictureBoxCoverPhoto.Image = r_DefaultCoverPhoto));
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_DataManager.UserPostsList)
            {
                if (post.Message != null)
                {
                    listBoxTimeline.Invoke(new Action(() => listBoxTimeline.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxTimeline.Invoke(new Action(() => listBoxTimeline.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxTimeline.Invoke(new Action(() => listBoxTimeline.Items.Add(string.Format("..."))));
                }
            }

            if (m_DataManager.UserPostsList.Count == 0)
            {
                listBoxTimeline.Invoke(new Action(() => listBoxTimeline.Items.Add("No posts")));
            }
        }

        private void fetchFriends()
        {
            foreach (User friend in m_DataManager.UserFriends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend.FirstName + " " + friend.LastName)));
            }

            if (m_DataManager.UserFriends.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No Friends")));
            }
        }

        private void fetchBasicInfo()
        {
            foreach (string info in m_DataManager.UserBasicInfo)
            {
                listBoxInfo.Invoke(new Action(() => listBoxInfo.Items.Add(info)));
            }
        }

        private void logout()
        {
            try
            {
                FacebookService.Logout(null);
                MessageBox.Show("Logged out successfuly!");
                AppSettings.Instance.IsLoggedOut = true;
                this.Invoke(new Action(this.Close));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCan't logout!");
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void textBoxPost_Click(object sender, EventArgs e)
        {
            textBoxPost.Clear();
        }

        private void textBoxSearchFriend_Click(object sender, EventArgs e)
        {
            textBoxSearchFriend.Clear();
        }

        private void checkValidPhotoAndPost()
        {
            if (labelPhotoPath.Text == string.Empty || textBoxPhotoTitle.Text == string.Empty
                || (labelPhotoPath.Text == string.Empty && textBoxPhotoTitle.Text == string.Empty))
            {
                MessageBox.Show(k_EmptyStringMessage);
            }
            else
            {
                PostItem(textBoxPhotoTitle.Text, labelPhotoPath.Text);
            }
        }

        private void checkValidLinkAndPost()
        {
            if (textBoxLinkPath.Text == string.Empty || textBoxLinkTitle.Text == string.Empty
                || (textBoxLinkPath.Text == string.Empty && textBoxLinkTitle.Text == string.Empty))
            {
                MessageBox.Show(k_EmptyStringMessage);
            }
            else
            {
                if (!Uri.IsWellFormedUriString(textBoxLinkPath.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Please enter a valid link!");
                }
                else
                {
                    PostItem(textBoxLinkTitle.Text, textBoxLinkPath.Text);
                }
            }
        }

        private void checkValidStatusAndPost()
        {
            if (textBoxPost.Text == string.Empty)
            {
                MessageBox.Show(k_EmptyStringMessage);
            }
            else
            {
                PostItem(textBoxPost.Text, null);
            }
        }

        private void PostItem(string i_Title, string i_Path)
        {
            FacebookPost.ePostType ePostType = (FacebookPost.ePostType)tabControlPostItems.SelectedIndex;
            FacebookPost itemToPost = FacebookPostFactory.CreateFacebookPost(ePostType, i_Title, i_Path, m_DataManager);
            try
            {
                itemToPost.Post();
                MessageBox.Show(ePostType.ToString() + " Posted successfully!");
            }
            catch
            {
                MessageBox.Show("Something went wrong... Can't post the " + ePostType.ToString() + " :(");
            }
        }

        private void FacebookApplicationForm_Load(object sender, EventArgs e)
        {
        }

        private void textBoxSearchFriend_TextChanged(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            int lenght = textBoxSearchFriend.Text.Count();

            foreach (User friend in m_DataManager.UserFriends)
            {
                if (friend.Name.StartsWith(textBoxSearchFriend.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend.Name)));
                }
            }

            if (listBoxFriends.Items.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No match!")));
            }
        }

        private void buttonMemories_Click(object sender, EventArgs e)
        {
            FormMemories memoriesForm = new FormMemories(m_DataManager, this);
            this.Hide();
            memoriesForm.ShowDialog();
        }

        private void initializeLabelUserName()
        {
            var pos = this.PointToScreen(labelUserName.Location);
            pos = pictureBoxCoverBackground.PointToClient(pos);
            labelUserName.Parent = pictureBoxCoverBackground;
            labelUserName.Location = pos;
            labelUserName.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            FormFetchAlbums newFormFetch = new FormFetchAlbums(m_DataManager);
            newFormFetch.Show();
        }

        private void textBoxPhotoTitle_Click(object sender, EventArgs e)
        {
            textBoxPhotoTitle.Clear();
        }

        private void textBoxLinkPath_Click(object sender, EventArgs e)
        {
            textBoxLinkPath.Clear();
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = "jpg files(*.jpg)|*.jpg|gif files (*.gif)|*.gif|png files(*.png)|*.png| bmp files(*.bmp)|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelPhotoPath.Text = openFileDialog.FileName;
            }
        }

        private void textBoxLinkTitle_Click(object sender, EventArgs e)
        {
            textBoxLinkTitle.Clear();
        }

        private void buttonFriendshipTest_Click(object sender, EventArgs e)
        {
            if (m_DataManager.UserFriends.Count > 0)
            {
                FormFriendshipTest friendshipTestForm = new FormFriendshipTest(m_DataManager, this);
                this.Hide();
                friendshipTestForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't have any friends :(\nTry to add some !");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            switch (tabControlPostItems.SelectedTab.Name)
            {
                case "Link":
                    checkValidLinkAndPost();
                    break;
                case "Photo":
                    checkValidPhotoAndPost();
                    break;
                case "Status":
                    checkValidStatusAndPost();
                    break;
                default:
                    break;
            }
        }
    }
}
