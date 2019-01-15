using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigurationParams
    {
        public const string WCCountryFlagCreateAPIFailed = "Error1";
        public const string WCCountryFlagCreateFormInvalid = "Error2";

        public const string WCAPIURL = "APIURL";

        public const string FlagsURN = "/api/CountryFlag";

        public const string FlagsChunkedURN = "/api/CountryFlag/GetChunks?chunkSize=3";

    }

    

    
}
