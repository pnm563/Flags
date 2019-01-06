using Common;
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
    public class CountryFlagController : ApiController
    {
        private FlagLogic flagLogic = new FlagLogic();

        // GET: api/CountryFlag
        public IEnumerable<CountryFlag> Get()
        {
            return flagLogic.GetCountryFlags();
        }

        // GET: api/CountryFlag/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CountryFlag
        [GenAPIExceptionFilter]
        public void Post([FromBody]CountryFlag theCountryFlag)
        {
            flagLogic.AddCountryFlag(theCountryFlag);
        }

        // PUT: api/CountryFlag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CountryFlag/5
        public void Delete(int id)
        {
        }

    }
}
