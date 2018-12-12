using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Common;
using ServicesLayer.Authorization;

namespace MoneyGest.Helpers
{
    public class HttpClientHelper : HttpClient
    {
        private readonly string  tokenPath = ConfigurationManager.AppSettings[Constants.HeaderParameterNames.TokeEndPointPath];
        private readonly string apiPath = ConfigurationManager.AppSettings[Constants.HeaderParameterNames.ApiEndPointPath];

        public HttpClientHelper(List<MediaTypeWithQualityHeaderValue> acceptHeaders = null, bool authPath = false, TokenModel auth = null) : base()
        {
            if (authPath == true)
            {
                this.BaseAddress = new Uri(tokenPath);
                
                if (acceptHeaders != null)
                    foreach (var ah in acceptHeaders)
                        this.DefaultRequestHeaders.Accept.Add(ah);
                else
                    this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (auth != null)
                    this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth.access_token);


            }
            else
            {

            }
        }
    }
}