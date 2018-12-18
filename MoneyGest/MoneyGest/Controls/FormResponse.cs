using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyGest.Controls
{
    public class FormResponse : JsonResult
    {
        public class Response
        {
            public bool succes { get; set; }
            protected Response() { }
        }
        protected FormResponse()
        {
            JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        }
        public void SetResponse(Response response)
        {
            Data = response;
        }
    }

    public class FormSuccesResponse : FormResponse
    {
        public class SuccesResponse : Response
        {
            public bool redirect { get; set; }
            public string message { get; set; }
            public string fallback_url { get; set; }
            public bool redirect_to_fallback { get; set; }
        }
        public FormSuccesResponse() : this("Succes") { }
        public FormSuccesResponse(string responseMessage) : this(responseMessage, true) { }
        public FormSuccesResponse(string responseMessage, bool redirect) : this(responseMessage, redirect, false) { }
        public FormSuccesResponse(string responseMessage, bool redirect, bool redirectToFallBack)
        {
            SetResponse(new SuccesResponse() { succes = true, redirect = redirect, redirect_to_fallback = redirectToFallBack, message = responseMessage });
        }
    }

    public class FormErrorResponse : FormResponse
    {
        public class ErrorResponse : Response
        {
            public string message { get; set; }
            public string exception_details { get; set; }
        }
        public FormErrorResponse() : this("") { }
        public FormErrorResponse(string exceptionMessage) : this("Error", exceptionMessage) { }
        public FormErrorResponse(string errorMessage, string exceptionMessage)
        {
            SetResponse(new ErrorResponse() {succes=false, message = errorMessage, exception_details = exceptionMessage });
        }
    }
}
