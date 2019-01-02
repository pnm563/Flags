using Models;
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
        // GET: api/CountryFlag
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value3" };
        }

        // GET: api/CountryFlag/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CountryFlag
        public void Post([FromBody]CountryFlag theCountryFlag)
        {
            string thing = "l";
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
