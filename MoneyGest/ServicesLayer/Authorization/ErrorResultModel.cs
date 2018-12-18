using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ServicesLayer.Authorization
{
   public  class ErrorResultModel
    {
        public HttpStatusCode statusCode { get; set; }
        public bool isModelState { get; set; }
        public string  category { get; set; }
        public string  message { get; set; }
        public ErrorResultModel()
        {
            category = string.Empty;
            message = string.Empty;
        }
    }
}
