using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FlagDataAccess
    {


        public void AddCountryFlag(CountryFlag countryFlag)
        {
            countryFlag.ID = Guid.NewGuid();
            db.CountryFlags.Add(countryFlag);
            db.SaveChanges();

        }

    }
}
