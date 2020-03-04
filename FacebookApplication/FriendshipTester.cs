using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class FriendshipTester : IFriendshipTestInitializer
    {
        private const int k_NumberOfQuestions = 6;
        private readonly string[] r_ListOfMonth = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        private readonly string[] r_ListOfCities =
       {
            "Rishon LeZion",
            "Tel Aviv",
            "Jerusalem",
            "Beit Shemesh",
            "Petah Tikva",
            "Bat Yam",
            "Holon",
            "Herzeliya",
            "Rehovot"
        };

        public QuestionsInitializer[] QuestionsForm { get; set; }

        public User CurrentUser { get; set; }

        public int Score { get; private set; }

        public FriendshipTester()
        {
            Reset();
        }

        public QuestionsInitializer[] InitializeQuestions(FacebookAppDataManager i_DataManager)
        {
            QuestionsInitializer[] questionsFormToReturn = new QuestionsInitializer[k_NumberOfQuestions];

            questionsFormToReturn[0] = new QuestionsInitializer(i_DataManager.UserAge);

            if (i_DataManager.UserPostsList != null)
            {
                questionsFormToReturn[1] = new QuestionsInitializer(i_DataManager.UserPostsList[0].CreatedTime.Value.Date);
            }
            else
            {
                questionsFormToReturn[1] = new QuestionsInitializer();
            }

            if (i_DataManager.UserAlbums != null)
            {
                questionsFormToReturn[2] = new QuestionsInitializer(i_DataManager.UserAlbums.Count);
            }
            else
            {
                questionsFormToReturn[2] = new QuestionsInitializer();
            }

            if (!string.IsNullOrEmpty(i_DataManager.UserLocation))
            {
                questionsFormToReturn[3] = new QuestionsInitializer(i_DataManager.UserLocation, r_ListOfCities);
            }
            else
            {
                questionsFormToReturn[3] = new QuestionsInitializer("Not declare", r_ListOfCities);
            }

            questionsFormToReturn[4] = new QuestionsInitializer(i_DataManager.UserMonthOfBirth.ToString(), r_ListOfMonth);

            if (i_DataManager.UserFriends != null)
            {
                questionsFormToReturn[5] = new QuestionsInitializer(i_DataManager.UserFriends.Count);
            }
            else
            {
                questionsFormToReturn[5] = new QuestionsInitializer();
            }

            QuestionsForm = questionsFormToReturn;
            CurrentUser = i_DataManager.LoggedInUser;

            return questionsFormToReturn;
        }

        public int GetScore(int[] i_ArrayOfUserAnswers)
        {
            int score = 0;

            for (int i = 0; i < k_NumberOfQuestions; i++)
            {
                if (!isInitializeAnswer(QuestionsForm[i]))
                {
                    Score++;
                }
                else
                {
                    if (checkIfAnswerCorrect(QuestionsForm[i], i_ArrayOfUserAnswers[i]))
                    {
                        Score++;
                    }
                }
            }

            return score;
        }

        private bool checkIfAnswerCorrect(QuestionsInitializer i_QuestionToCheck, int i_UserChoise)
        {
            bool isCorrect = false;

            if (i_QuestionToCheck.checkIfCorrectAnswer(i_UserChoise))
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        private bool isInitializeAnswer(QuestionsInitializer i_QuestionToCheck)
        {
            bool isInit = false;

            if (i_QuestionToCheck.m_CorrectIndex >= 0)
            {
                isInit = true;
            }

            return isInit;
        }

        public void Reset()
        {
            CurrentUser = null;
            QuestionsForm = null;
            Score = 0;
        }
    }
}
