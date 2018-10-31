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
        public string  categoria { get; set; }
        public string  messagio { get; set; }
        public ErrorResultModel()
        {
            categoria = string.Empty;
            messagio = string.Empty;
        }
    }
}
