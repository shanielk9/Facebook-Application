using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class CacheFriendshipTester : IFriendshipTestInitializer
    {
        private User m_CurrentUser;

        private Dictionary<string, QuestionsInitializer[]> m_CachedFriendshipTestValues;

        private FriendshipTester m_FriendshipTester;

        public User CurrentUser
        {
            get { return m_CurrentUser; }
            set
            {
                m_CurrentUser = value;
                m_FriendshipTester.Reset();
            }
        }

        public int Score
        {
            get { return m_FriendshipTester.Score; }
        }

        public QuestionsInitializer[] QuestionsForm
        {
            get
            {
                if (m_FriendshipTester.QuestionsForm == null)
                {
                    m_FriendshipTester.Reset();

                    if (m_CachedFriendshipTestValues.ContainsKey(CurrentUser.Id))
                    {
                        m_FriendshipTester.QuestionsForm = m_CachedFriendshipTestValues[CurrentUser.Id];
                        m_FriendshipTester.CurrentUser = CurrentUser;
                    }
                    else
                    {
                        m_FriendshipTester.QuestionsForm = InitializeQuestions(new FacebookAppDataManager(CurrentUser));
                    }
                }

                return m_FriendshipTester.QuestionsForm;
            }
        }

        public CacheFriendshipTester()
        {
            m_CachedFriendshipTestValues = new Dictionary<string, QuestionsInitializer[]>();
            m_FriendshipTester = new FriendshipTester();
        }

        public QuestionsInitializer[] InitializeQuestions(FacebookAppDataManager i_FriendDataManager)
        {
            QuestionsInitializer[] questionsFormToReturn;

            if (m_CachedFriendshipTestValues != null && m_CachedFriendshipTestValues.ContainsKey(CurrentUser.Id))
            {
                questionsFormToReturn = m_CachedFriendshipTestValues[CurrentUser.Id];
            }
            else
            {
                questionsFormToReturn = m_FriendshipTester.InitializeQuestions(i_FriendDataManager);
                saveFriendshipQuestionsToCache(i_FriendDataManager.UserId, questionsFormToReturn);
            }

            return questionsFormToReturn;
        }

        private void saveFriendshipQuestionsToCache(string i_id, QuestionsInitializer[] i_Questions)
        {
            m_CachedFriendshipTestValues[i_id] = i_Questions;
        }

        public int GetScore(int[] i_ArrayOfUserAnswers)
        {
            return m_FriendshipTester.GetScore(i_ArrayOfUserAnswers);
        }
    }
}