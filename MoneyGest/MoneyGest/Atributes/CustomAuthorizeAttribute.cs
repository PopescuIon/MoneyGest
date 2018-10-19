using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyGest.Atributes
{   [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method,Inherited =true,AllowMultiple =true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (SessionManager.Autentification == null)
            {
                var context = filterContext.RequestContext.HttpContext;
                var @params = context.Request.Params;
                if (string.IsNullOrEmpty(@params["sso_acces_token"]) )
                {

                }
            }
            base.HandleUnauthorizedRequest(filterContext);
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }
        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return base.OnCacheAuthorization(httpContext);
        }
    }

}