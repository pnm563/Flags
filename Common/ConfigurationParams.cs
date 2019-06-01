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

        public const string WCAPIHost = "APIHost";
        public const string WCAPIURLScheme = "APIURLScheme";

        public const string FlagsURN = "/api/Flag";

        public const string FlagsAllURN = FlagsURN + "/GetAll";

        public const string FlagsRandomURN = FlagsURN + "/GetRandomFlags";

        public const string FlagQuestionURN = FlagsURN + "/GetQuestion";

        public const string SubmitAnswerURN = FlagsURN + "/SubmitAnswer";

    }

    

    
}
