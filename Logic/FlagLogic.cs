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
        private FlagDataAccess dataAccess = new FlagDataAccess();

        public void AddCountryFlag(CountryFlag countryFlag)
        {
            countryFlag.ID = Guid.NewGuid();
            dataAccess.AddCountryFlag(countryFlag);
        } 
        
        public Question GetQuestion(Guid aspNetUserID)
        {
            List<Flag> flags = new List<Flag>();

            CountryFlag firstFlag = GetRandomCountryFlags(1).First();

            flags.Add(firstFlag);
            flags.AddRange(GetRandomCountryFlags(2));

            Question Q = new Question()
            {
                ID = Guid.NewGuid(),
                AspNetUserID = aspNetUserID,
                TimeStamp = DateTime.Now,
                FlagChoices = flags,
                CorrectAnswer = firstFlag.ID,
                QuestionText = firstFlag.Description
            };
            dataAccess.AddQuestion(Q);
            return Q;
        }

        public IEnumerable<CountryFlag> GetCountryFlags()
        {
            return dataAccess.GetCountryFlags();
        }

        public IEnumerable<CountryFlag> GetRandomCountryFlags(int quantity)
        {
            int maxCountryFlagIndexNo = dataAccess.GetMaxCountryFlagIndexNo();
            List<CountryFlag> randomCountryFlags = new List<CountryFlag>();

            Random random = new Random();

            for (int i = 1; i <= quantity; i++)
            {
                randomCountryFlags.Add(
                    dataAccess.GetCountryFlagByIndexNo(
                        random.Next(1, maxCountryFlagIndexNo + 1)
                    )
                );
            }

            return randomCountryFlags;
        }

    }
}
