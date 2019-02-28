using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace JACWebAPI.MessageHandlers
{
    public class APIKeyMessageHandler : DelegatingHandler
    {
        private const string APIKeyValue = "abc123";

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage hrm, CancellationToken cvt)
        {
            bool validKey = false;
            IEnumerable<string> requestHeaders;

            if (hrm.Method == HttpMethod.Get)
            {



                var checkIfApiKeyExists = hrm.Headers.TryGetValues("ApiKey", out requestHeaders);

                if (checkIfApiKeyExists)
                {
                    if (requestHeaders.FirstOrDefault().Equals(APIKeyValue))
                    {
                        validKey = true;
                    }
                }

                if (!validKey)
                {
                    return hrm.CreateResponse(HttpStatusCode.Forbidden, "Invalid API Key");
                }
            }

            var response = await base.SendAsync(hrm, cvt);
            return response;
       
          
        }
    }
}