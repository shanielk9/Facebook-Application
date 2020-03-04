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
    public partial class FormFriendshipTestQuestion : Form
    {
        private const int k_NumberOfQuestions = 6;
        private const string k_MessageToFriend = "Hi!\nI just played in our friendship test :)\nMy score is:";

        private readonly Image r_GifGoodScore = Properties.Resources.giphyClapping;
        private readonly Image r_GifBadScore = Properties.Resources.giphySad;
        private CheckedListBox[] m_ListOfQuestionListBox;
        private User m_CurrectFriend;
        private FacebookAppDataManager m_UserDataManager;
        private FacebookAppDataManager m_FriendDataManager;
        private IFriendshipTestInitializer m_FriendshipTester;
        private FormFriendshipTest m_FriendshipTestForm;

        public FormFriendshipTestQuestion(User i_Friend, FormFriendshipTest i_FriendshipForm, FacebookAppDataManager i_UserDateManager, IFriendshipTestInitializer i_FriendshipTester)
        {
            InitializeComponent();
            m_UserDataManager = i_UserDateManager;
            m_CurrectFriend = i_Friend;
            m_FriendshipTester = i_FriendshipTester;
            m_FriendshipTestForm = i_FriendshipForm;
            m_ListOfQuestionListBox = new CheckedListBox[] { checkedListBoxQuestion1, checkedListBoxQuestion2, checkedListBoxQuestion3, checkedListBoxQuestion4, checkedListBoxQuestion5, checkedListBoxQuestion6 };
            new Thread(initializeFriendInfo).Start();  
        }

        private void initializeFriendInfo()
        {
            m_FriendDataManager = new FacebookAppDataManager(m_CurrectFriend);
            pictureBoxFriendPhoto.Invoke(new Action(() => pictureBoxFriendPhoto.LoadAsync(m_FriendDataManager.ProfilePicURL)));
            initializeQuestions();
            buttonSubmit.Invoke(new Action(() => buttonSubmit.Enabled = true));
        }

        private void initializeQuestions()
        {
            int i = 0;

            foreach (QuestionsInitializer question in m_FriendshipTester.QuestionsForm)
            {
                initializeCheckBoxAnswers(question, m_ListOfQuestionListBox[i]);
                i++;
            }
        }

        private void initializeCheckBoxAnswers(QuestionsInitializer i_QuestionToConvert, CheckedListBox i_CheckListToFill)
        {
            i_CheckListToFill.Invoke(new Action(() => i_CheckListToFill.Items.Clear()));
            foreach (string answer in i_QuestionToConvert.m_Amswers)
            {
                i_CheckListToFill.Invoke(new Action(() => i_CheckListToFill.Items.Add(answer)));
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool isTestFinished = true;
            foreach (CheckedListBox checkedListBox in m_ListOfQuestionListBox)
            {
                if (checkedListBox.SelectedIndex < 0) 
                {
                    MessageBox.Show("Please answer all the questions");
                    isTestFinished = false;
                    break;
                }
            }

            if (isTestFinished)
            {
                m_FriendshipTester.GetScore(getUserChoises());
                initializeScoreOnScreen();
            }
        }

        private void ShowOrHideQuestionsComponents(bool i_VisibleOptionChoice)
        {
            foreach (CheckedListBox checkedListBox in m_ListOfQuestionListBox)
            {
                checkedListBox.Visible = i_VisibleOptionChoice;
            }

            buttonSubmit.Visible = i_VisibleOptionChoice;
            labelQuestion1.Visible = i_VisibleOptionChoice;
            labelQuestion2.Visible = i_VisibleOptionChoice;
            labelQuestion3.Visible = i_VisibleOptionChoice;
            labelQuestion4.Visible = i_VisibleOptionChoice;
            labelQuestion5.Visible = i_VisibleOptionChoice;
            labelQuestion6.Visible = i_VisibleOptionChoice;
        }

        private void initializeLableScore()
        {
            string lableText = string.Empty;

            if (m_FriendshipTester.Score > (k_NumberOfQuestions / 2))
            {
                lableText = "Wow!!!!\nYou such a good friend!\n";
            }
            else
            {
                lableText = "Too Bad :(\nYou'r knowledge is not so good...\n";
            }

            lableText = lableText + "YOUR SCORE:\n" + m_FriendshipTester.Score + " / " + k_NumberOfQuestions.ToString();

            labelScore.Text = lableText;
        }

        private void initializeScoreOnScreen()
        {
            ShowOrHideQuestionsComponents(false);
            labelScore.Visible = true;
            initializeLableScore();
            initializeScoreGif();
            buttonTryAgain.Visible = true;
            pictureBoxEndTestGif.Visible = true;
            buttonShare.Text += m_FriendDataManager.UserName;
            buttonShare.Visible = true;
        }

        private void initializeScoreGif()
        {
            if (m_FriendshipTester.Score > (k_NumberOfQuestions / 2))
            {
                pictureBoxEndTestGif.Image = r_GifGoodScore;
            }
            else
            {
                pictureBoxEndTestGif.Image = r_GifBadScore;
            }
        }

        private int[] getUserChoises()
        {
            int[] userChoises = new int[k_NumberOfQuestions];

            for (int i = 0; i < k_NumberOfQuestions; i++)
            {
                if (m_FriendshipTester.QuestionsForm[i].m_CorrectIndex != -1)
                {
                    userChoises[i] = m_ListOfQuestionListBox[i].SelectedIndex;
                }
                else
                {
                    userChoises[i] = -1;
                }
            }

            return userChoises;
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            m_FriendshipTestForm.Show();
            this.Close();
        }

        private void checkedListBoxQuestion1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion1, checkedListBoxQuestion1.SelectedIndex, e);
        }

        private void checkedListBoxQuestion2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion2, checkedListBoxQuestion2.SelectedIndex, e);
        }

        private void checkedListBoxQuestion3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion3, checkedListBoxQuestion3.SelectedIndex, e);
        }

        private void checkedListBoxQuestion4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion4, checkedListBoxQuestion4.SelectedIndex, e);
        }

        private void checkedListBoxQuestion5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion5, checkedListBoxQuestion5.SelectedIndex, e);
        }

        private void checkedListBoxQuestion6_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CancleMultiplyChoisesOption(checkedListBoxQuestion6, checkedListBoxQuestion6.SelectedIndex, e);
        }

        private void CancleMultiplyChoisesOption(CheckedListBox i_CheckedListBox, int i_selectedIndex, ItemCheckEventArgs i_e)
        {
            if (i_e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < i_CheckedListBox.Items.Count; ++i)
                {
                    i_CheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            shareScoreOnFriendWall();
        }

        private void shareScoreOnFriendWall()
        {
            if (m_UserDataManager.PostOnYourFriendWall(getPostText(), m_FriendDataManager.UserId))
            {
                MessageBox.Show("Posted succesfully! :)");
            }
            else
            {
                MessageBox.Show("Something went wrong! Cant post :(");
            }
        }

        private string getPostText()
        {
            string textToRetun = k_MessageToFriend + m_FriendshipTester.Score.ToString();
            return textToRetun;
        }
    }
}
