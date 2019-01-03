using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class ExceptionInfo
    {
        public static List<string> RecurseInnerExceptions(Exception ex)
        {
            List<string> innerExceptions = new List<string>();

            while (ex != null)
            {
                innerExceptions.Add(ex.Message);
                ex = ex.InnerException;
            }

            return innerExceptions;
        }
    }
}
