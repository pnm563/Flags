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
        public void AddCountryFlag(CountryFlag countryFlag)
        {
            FlagDataAccess dataAccess = new FlagDataAccess();
            dataAccess.AddCountryFlag(countryFlag);
        }
    }
}
