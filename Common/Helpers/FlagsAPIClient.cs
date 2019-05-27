using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Common.Helpers
{
    public class FlagsAPIClient
    {
        public static T GetAsync<T>(string scheme, string baseAddress, string path, Dictionary<string,string> keyValuePairs = null)
        {
            using (HttpClient client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder(scheme, baseAddress)
                {
                    Port = -1,
                    Path = path
                };

                if (keyValuePairs != null)
                {
                    System.Collections.Specialized.NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);
                    foreach (string param in keyValuePairs.Keys)
                    {
                        query[param] = keyValuePairs[param];
                    }
                    builder.Query = query.ToString();
                }

                HttpResponseMessage theResponse = client.GetAsync(builder.Uri).Result;

                if (!theResponse.IsSuccessStatusCode)
                {
                    APIError aPIError = JsonConvert.DeserializeObject<APIError>(theResponse.Content.ReadAsStringAsync().Result);
                    aPIError.MessageDetail += $"HTTP response: {theResponse.StatusCode.ToString()} ";
                    throw new Exception($"Message: {aPIError.Message} MessageDetail:{aPIError.MessageDetail}");

                }

                T Q = JsonConvert.DeserializeObject<T>(theResponse.Content.ReadAsStringAsync().Result);
                return Q;
            }
            
        }
    }
}
