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

        public const string CountryFlagsURN = "/api/CountryFlag";

        public const string CountryFlagsAllURN = CountryFlagsURN + "/GetAll?all=1";

        public const string CountryFlagsRandomURN = CountryFlagsURN + "/GetRandomCountryFlags?quantity=3";

        public const string CountryFlagQuestionURN = CountryFlagsURN + "/GetQuestion?aspNetUserID={0}";

    }

    

    
}
