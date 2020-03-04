using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class QuestionsInitializer
    {
        private const int k_UninitializeQuestionIndex = -1;
        private const int k_NumOfAnswersToShow = 4;
        public int m_CorrectIndex;
        public string[] m_Amswers;
        private Random m_RandomCustomizeAnswer;

        public QuestionsInitializer()
        {
            basicInitialize();
            m_CorrectIndex = k_UninitializeQuestionIndex;
        }

        public QuestionsInitializer(int i_CorrectAnswer)
        {
            basicInitialize();
            int minPossibleAnswer = 0, maxPossibleAnswer = 0;
            getIntagerRange(out minPossibleAnswer, out maxPossibleAnswer, i_CorrectAnswer);
            initializeCorrectAnswer(i_CorrectAnswer.ToString());
            initializeRandomAnswers(minPossibleAnswer, maxPossibleAnswer);
        }

        public QuestionsInitializer(string i_CorrectAnswer, string[] i_ListOfChoices)
        {
            basicInitialize();
            initializeCorrectAnswer(i_CorrectAnswer);
            initializeRandomAnswersFromArray(0, i_ListOfChoices.Count(), i_ListOfChoices);
        }

        public QuestionsInitializer(DateTime i_CorrectAnswer)
        {
            basicInitialize();
            initializeCorrectAnswer(i_CorrectAnswer.ToShortDateString());

            DateTime maxDayTimeRange, minDayTimeRange = i_CorrectAnswer.Subtract(TimeSpan.FromDays(10));
            getDateTimeRange(minDayTimeRange, out maxDayTimeRange, i_CorrectAnswer);
            initializeRandomDateTimeAnswers(minDayTimeRange, maxDayTimeRange);
        }

        private void basicInitialize()
        {
            m_Amswers = new string[k_NumOfAnswersToShow];
            m_RandomCustomizeAnswer = new Random();
            m_CorrectIndex = m_RandomCustomizeAnswer.Next(0, k_NumOfAnswersToShow - 1);
        }

        private void getIntagerRange(out int io_MinRange, out int io_MaxRange, int i_CorrectAnswer)
        {
            int range = getRangeForOption(i_CorrectAnswer);

            if (range == 0)
            {
                ////To be able to fill all of the possible answers without duplicateds
                range = k_NumOfAnswersToShow / 2;
            }

            if (i_CorrectAnswer - range < 0)
            {
                io_MinRange = 0;
                io_MaxRange = io_MinRange + ((range * 2) + 1);
            }
            else
            {
                io_MinRange = i_CorrectAnswer - range;
                io_MaxRange = i_CorrectAnswer + range;
            }

            if ((io_MaxRange - io_MinRange) < k_NumOfAnswersToShow)
            {
                if (io_MinRange - (range * k_NumOfAnswersToShow) < 0)
                {
                    io_MinRange = 0;
                    io_MaxRange = io_MinRange + (range * k_NumOfAnswersToShow);
                }
                else
                {
                    io_MinRange = i_CorrectAnswer - (range * k_NumOfAnswersToShow);
                    io_MaxRange = i_CorrectAnswer + (range * k_NumOfAnswersToShow);
                }
            }
        }

        private void initializeCorrectAnswer(string i_CorrectAnswer)
        {
            m_Amswers[m_CorrectIndex] = i_CorrectAnswer;
        }

        private void initializeRandomAnswers(int i_MinPossibleAnswer, int i_MaxPossibleAnswer)
        {
            string randomAnswer = m_RandomCustomizeAnswer.Next(i_MinPossibleAnswer, i_MaxPossibleAnswer).ToString();
            for (int i = 0; i < k_NumOfAnswersToShow; i++)
            {
                if (i != m_CorrectIndex)
                {
                    do
                    {
                        randomAnswer = m_RandomCustomizeAnswer.Next(i_MinPossibleAnswer, i_MaxPossibleAnswer).ToString();
                    }
                    while (appearInArry(randomAnswer, m_Amswers));

                    m_Amswers[i] = randomAnswer;
                }
            }
        }

        private void initializeRandomAnswersFromArray(int i_MinPossibleAnswer, int i_MaxPossibleAnswer, string[] i_ArrayOfChoices)
        {
            int randomIndexAnswer = m_RandomCustomizeAnswer.Next(i_MinPossibleAnswer, i_MaxPossibleAnswer);
            string randomAnswer = i_ArrayOfChoices[randomIndexAnswer];

            for (int i = 0; i < k_NumOfAnswersToShow; i++)
            {
                if (i != m_CorrectIndex)
                {
                    do
                    {
                        randomIndexAnswer = m_RandomCustomizeAnswer.Next(i_MinPossibleAnswer, i_MaxPossibleAnswer);
                        randomAnswer = i_ArrayOfChoices[randomIndexAnswer];
                    }
                    while (appearInArry(randomAnswer, m_Amswers));

                    m_Amswers[i] = randomAnswer;
                }
            }
        }

        private void getDateTimeRange(DateTime i_MinDateTime, out DateTime io_MaxDateTime, DateTime i_CorrectAnswer)
        {
            DateTime dateToCheck = i_CorrectAnswer.AddDays(10);
            if (DateTime.Today < dateToCheck)
            {
                io_MaxDateTime = DateTime.Today;
            }
            else
            {
                io_MaxDateTime = dateToCheck;
            }
        }

        private void initializeRandomDateTimeAnswers(DateTime i_MinDateTime, DateTime i_MaxDateTime)
        {
            List<string> dateTimeOptions = createDateTimeArray(i_MinDateTime, i_MaxDateTime);
            int randomIndex = m_RandomCustomizeAnswer.Next(0, dateTimeOptions.Count());
            string randomTime = dateTimeOptions[randomIndex];

            for (int i = 0; i < k_NumOfAnswersToShow; i++)
            {
                if (i != m_CorrectIndex)
                {
                    do
                    {
                        randomIndex = m_RandomCustomizeAnswer.Next(0, 10);
                        randomTime = dateTimeOptions[randomIndex]; 
                    }
                    while (appearInArry(randomTime, m_Amswers));

                    m_Amswers[i] = randomTime;
                }
            }
        }

        private List<string> createDateTimeArray(DateTime i_MinDateTime, DateTime i_MaxDateTime)
        {
            List<string> listOfDateTime = new List<string>();

            while (i_MinDateTime <= i_MaxDateTime)
            {
                listOfDateTime.Add(i_MinDateTime.ToShortDateString());
                i_MinDateTime = i_MinDateTime.AddDays(1);
            }

            return listOfDateTime;
        }

        private bool appearInArry(string i_ToCheckIfAppearInArry, string[] i_Arry)
        {
            bool isAppear = false;

            for (int i = 0; i < i_Arry.Count(); i++)
            {
                if (i_Arry[i] != null)
                {
                    if (i_Arry[i].ToLower() == i_ToCheckIfAppearInArry.ToLower())
                    {
                        isAppear = true;
                    }
                }
            }

            return isAppear;
        }

        public bool checkIfCorrectAnswer(int i_UserChoise)
        {
            bool isCorrect = false;

            if (i_UserChoise == m_CorrectIndex)
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        public int getRangeForOption(int i_MiddleOption)
        {
            int range = (i_MiddleOption * 10) / 100;

            return range;
        }
    }
}