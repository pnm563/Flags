using Common;
using Common.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace FlagsBackend.Filters
{
    public class GenAPIExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            Exception ex = context.Exception;

            List<string> exceptionDetail = ExceptionInfo.RecurseInnerExceptions(ex);

            APIError aPIError = new APIError()
            {
                Message = "Exception raised!",
                MessageDetail = String.Join("|", exceptionDetail)
            };

            string JSONAPIError = JsonConvert.SerializeObject(aPIError);

            throw new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(JSONAPIError),
                    ReasonPhrase = "Critical Exception"
                }
            );
        }
    }
}