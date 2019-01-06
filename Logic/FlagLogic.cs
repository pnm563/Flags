﻿using DataAccess;
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
            dataAccess.AddCountryFlag(countryFlag);
        }

        public IEnumerable<CountryFlag> GetCountryFlags()
        {
            return dataAccess.GetCountryFlags();
        }
    }
}
