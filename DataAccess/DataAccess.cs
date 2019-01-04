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

    }
}
