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
    public class FlagController : ApiController
    {
        private FlagLogic flagLogic = new FlagLogic();

        // GET: api/CountryFlag

        public string Get() => "Not Implemented";

        public IEnumerable<Flag> GetAll(int all) => flagLogic.GetFlags();

        // GET: api/CountryFlag/5
        //public string Get(int id)
        //{
        //    return "value";
        //}


        public IEnumerable<Flag> GetRandomFlags(int quantity) => flagLogic.GetRandomFlags(quantity);

        public Question GetQuestion(Guid aspNetUserId) => flagLogic.GetQuestion(aspNetUserId);

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
