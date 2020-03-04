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
using FacebookApplication;

namespace FacebookApplication
{
    public partial class FormLogin : Form
    {
        private const int k_CollectionLimit = 10;
        private const float k_FbApiVersion = 2.8f;
        private const string k_AppId = "1390142697810102";         
        private static readonly string[] sr_Permission =
            {
            "public_profile",
            "user_photos",
            "user_location",
            "user_birthday",
            "user_friends",
            "user_gender",
            "user_posts",
            "email",
            "user_events",
            "manage_pages",
            "groups_access_member_info"
        };
     
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public FormLogin()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = k_CollectionLimit;
            FacebookWrapper.FacebookService.s_FbApiVersion = k_CollectionLimit;
            AppSettings.Instance.LoadFromFile();
        }
          
        private void loginAndInit()
        {
            try
            {
                m_LoginResult = FacebookService.Login(k_AppId, sr_Permission);
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    AppSettings.Instance.RememberUser = this.checkBoxRememberUser.Checked;
                    FormFacebookApplication fbAppForm = new FormFacebookApplication(m_LoggedInUser);
                    fbAppForm.ShowDialog();
                    this.Invoke(new Action(this.Close));
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage);
                }
            }
            catch 
            {
                MessageBox.Show("Login Failed. Please try again later.");
                this.Invoke(new Action(this.Close));
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                if (AppSettings.Instance.RememberUser && !string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
                {
                    this.checkBoxRememberUser.Checked = AppSettings.Instance.RememberUser;
                    connectAsRememberedUser();
                }
            }
            catch
            {
                MessageBox.Show("The connection faild. Please try again"); 
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (!AppSettings.Instance.IsLoggedOut)
            {
                AppSettings.Instance.RememberUser = this.checkBoxRememberUser.Checked;
                if (AppSettings.Instance.RememberUser)
                {
                    AppSettings.Instance.LastAccessToken = m_LoginResult.AccessToken;
                }
                else
                {
                    AppSettings.Instance.LastAccessToken = null;
                }
            }
            else
            {
                AppSettings.Instance.ResetToDefaultSettings();
            }
            
            AppSettings.Instance.SaveToFile();
        }

        private void connectAsRememberedUser()
        {
            m_LoginResult = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            FormFacebookApplication fbAppForm = new FormFacebookApplication(m_LoggedInUser);
            fbAppForm.ShowDialog();
            this.Invoke(new Action(this.Close));
        }
    }
}
