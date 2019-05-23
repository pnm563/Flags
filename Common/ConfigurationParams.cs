using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConfigurationParams
    {
        public const string WCFlagCreateAPIFailed = "Error1";
        public const string WCFlagCreateFormInvalid = "Error2";

        public const string WCAPIURL = "APIURL";

        public const string FlagsURN = "/api/Flag";

        public const string FlagsAllURN = FlagsURN + "/GetAll?all=1";

        public const string FlagsRandomURN = FlagsURN + "/GetRandomFlags?quantity=3";

        public const string FlagQuestionURN = FlagsURN + "/GetQuestion?aspNetUserID={0}";

    }

    

    
}
