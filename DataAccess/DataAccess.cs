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

        public void AddFlag(Flag Flag)
        {
            db.Flag.Add(Flag);
            db.SaveChanges();
        }

        public void AddQuestion(Question question)
        {
            db.Question.Add(question);
            db.SaveChanges();
        }

        public IEnumerable<Flag> GetFlags()
        {
            return db.Flag.ToList();
        }

        public int GetMaxFlagIndexNo()
        {
            return db.Flag.Max(f => f.IndexNo);
        }

        public Flag GetFlagByIndexNo(int IndexNo)
        {
            return db.Flag.Where(x => x.IndexNo == IndexNo).First();
        }


    }
}
