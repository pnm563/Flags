using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FlagDataAccess
    {
        FlagContext db = new FlagContext();

        public void AddCountryFlag(CountryFlag countryFlag)
        {
            countryFlag.ID = Guid.NewGuid();
            db.CountryFlag.Add(countryFlag);
            db.SaveChanges();
        }

        public void AddQuestion(Question question)
        {
            question.ID = Guid.NewGuid();
            db.Question.Add(question);
            db.SaveChanges();
        }

        public IEnumerable<CountryFlag> GetCountryFlags()
        {
            return db.CountryFlag.ToList();
        }

        public int GetMaxCountryFlagIndexNo()
        {
            return db.CountryFlag.Max(f => f.IndexNo);
        }

        public CountryFlag GetCountryFlagByIndexNo(int IndexNo)
        {
            return db.CountryFlag.Where(x => x.IndexNo == IndexNo).First();
        }


    }
}
