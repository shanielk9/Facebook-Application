using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public interface IFriendshipTestInitializer
    {
        QuestionsInitializer[] InitializeQuestions(FacebookAppDataManager i_DataManager);

        QuestionsInitializer[] QuestionsForm { get; }

        User CurrentUser { get; set; }

        int Score { get; }

        int GetScore(int[] i_ArrayOfUserAnswers);
    }
}
