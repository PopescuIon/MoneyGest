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
        private string tokenPath = ConfigurationManager.AppSettings[Constants.HeaderParameterNames.TokeEndPointPath];

        public HttpClientHelper(List<MediaTypeWithQualityHeaderValue> acceptHeaders = null, bool authPath = false, TokenModel auth = null) : base()
        {
            if (authPath == true)
            {
                this.BaseAddress = new Uri(tokenPath);
                this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
            else
            {

            }
        }
    }
}