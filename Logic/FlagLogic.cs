using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FlagLogic
    {
        private FlagDataAccess _dataAccess = new FlagDataAccess();

        public void AddFlag(Flag Flag)
        {
            Flag.ID = Guid.NewGuid();
            _dataAccess.AddFlag(Flag);
        } 
        
        public Question GetQuestion(Guid aspNetUserID)
        {
            List<Flag> flags = new List<Flag>();

            Flag firstFlag = GetRandomFlags(1).First();

            flags.Add(firstFlag);
            flags.AddRange(GetRandomFlags(2));

            Question Q = new Question()
            {
                ID = Guid.NewGuid(),
                AspNetUserID = aspNetUserID,
                TimeStamp = DateTime.Now,
                FlagChoices = flags,
                CorrectAnswer = firstFlag.ID,
                QuestionText = firstFlag.Description
            };
            _dataAccess.AddQuestion(Q);
            return Q;
        }

        public IEnumerable<Flag> GetFlags()
        {
            return _dataAccess.GetFlags();
        }

        public IEnumerable<Flag> GetRandomFlags(int quantity)
        {
            int maxFlagIndexNo = _dataAccess.GetMaxFlagIndexNo();
            List<Flag> randomFlags = new List<Flag>();

            Random random = new Random();

            for (int i = 1; i <= quantity; i++)
            {
                randomFlags.Add(
                    _dataAccess.GetFlagByIndexNo(
                        random.Next(1, maxFlagIndexNo + 1)
                    )
                );
            }

            return randomFlags;
        }

        public bool SubmitAnswer(Guid questionID,Guid userAnswer)
        {
            Answer A = new Answer()
            {
                QuestionID = questionID,
                UserAnswer = userAnswer
            };

            Question Q = _dataAccess.SubmitAnswer(A);

            return Q.UserAnswer == Q.CorrectAnswer;
        }

    }
}
