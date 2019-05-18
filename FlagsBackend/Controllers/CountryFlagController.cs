using Common;
using Common.Helpers;
using FlagsBackend.Filters;
using Logic;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlagsBackend.Controllers
{
    [GenAPIExceptionFilter]
    public class CountryFlagController : ApiController
    {
        private FlagLogic flagLogic = new FlagLogic();

        // GET: api/CountryFlag
        
        public IEnumerable<CountryFlag> Get()
        {
            return flagLogic.GetCountryFlags();
        }

        // GET: api/CountryFlag/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
           

        public IEnumerable<CountryFlag> GetRandomCountryFlags(int quantity)
        {
            return flagLogic.GetRandomCountryFlags(quantity);
        }

        // POST: api/CountryFlag

        //public void Post([FromBody]CountryFlag theCountryFlag)
        //{
        //    flagLogic.AddCountryFlag(theCountryFlag);
        //}

        //// PUT: api/CountryFlag/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/CountryFlag/5
        //public void Delete(int id)
        //{
        //}

    }
}
