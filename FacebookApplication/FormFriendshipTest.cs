using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class FormFriendshipTest : Form
    {
        private FacebookAppDataManager m_DataManager;
        private FormFacebookApplication m_FacebookAppFormToReturn;
        private IFriendshipTestInitializer m_FriendshipTester;

        public FormFriendshipTest(FacebookAppDataManager i_DataManager, FormFacebookApplication i_FBAFormToReturn)
        {
            InitializeComponent();
            m_DataManager = i_DataManager;
            m_FacebookAppFormToReturn = i_FBAFormToReturn;
        }

        private void FriendshipTestForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonChooseFriend_Click(object sender, EventArgs e)
        {
            initializeUserFriends();
            panelChooseFriends.Visible = true;
        }

        private void initializeUserFriends()
        {
            foreach (User friend in m_DataManager.UserFriends)
            {
                checkedListBoxFriends.Items.Add(friend.Name);
            }
        }

        private void CreateTester(User i_User)
        {
            if(m_FriendshipTester == null)
            {
                m_FriendshipTester = new CacheFriendshipTester();
            }

            m_FriendshipTester.CurrentUser = i_User;
        }

        private void buttonSelectRandomFriend_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, m_DataManager.UserFriends.Count);
            User selectedFriendUser = m_DataManager.UserFriends[randomIndex];
            CreateTester(selectedFriendUser);
            FormFriendshipTestQuestion formQuestions = new FormFriendshipTestQuestion(selectedFriendUser, this, m_DataManager, m_FriendshipTester);
            formQuestions.Show();
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            m_FacebookAppFormToReturn.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (checkedListBoxFriends.CheckedItems.Count > 0)
            {
                string selectedFriendName = checkedListBoxFriends.SelectedItem.ToString();
                User selectedFriendUser = getSelectedUser(selectedFriendName);
                CreateTester(selectedFriendUser);
                FormFriendshipTestQuestion formQuestions = new FormFriendshipTestQuestion(selectedFriendUser, this, m_DataManager, m_FriendshipTester);
                formQuestions.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a friend!");
            }
        }

        private User getSelectedUser(string i_FriendName)
        {
            User selectedFriend = new User();

            foreach (User friend in m_DataManager.UserFriends)
            {
                if (friend.Name == i_FriendName)
                {
                    selectedFriend = friend;
                }
            }

            return selectedFriend;
        }

        private void checkedListBoxFriends_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxFriends.SelectedIndex;

            // loop to set all items checked or unchecked
            for (int i = 0; i < checkedListBoxFriends.Items.Count; i++)
            {
                if (i != selectedIndex)
                {
                    checkedListBoxFriends.SetItemChecked(i, false);
                }
            }
        }
    }
}
