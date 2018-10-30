using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IdentityModel.Tokens;
using ServicesLayer.Authorization;
using MoneyGest.Helpers;
using System.Net.Http;
using System.Threading.Tasks;
 

namespace MoneyGest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult>  Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = null;
                bool autentificationPath = true;
                using (var client=new HttpClientHelper(null,autentificationPath))
                {
                    HttpContent content = new FormUrlEncodedContent(
                        new[] {
                            new  KeyValuePair<string, string>("grant_type", "password")
                        });
                    client.DefaultRequestHeaders.Add(Common.Constants.HeaderParameterNames.LoginName, model.LoginName);
                    client.DefaultRequestHeaders.Add(Common.Constants.HeaderParameterNames.Password, model.Password);

                    response = await client.PostAsync("", content);
                   // var token=await response.Content.ReadAsStringAsync<TokenModel>()
                }
            }
            return Json(new { succes=true},JsonRequestBehavior.AllowGet);
        }
        //public static bool SsoAuth(string acces_token)
        //{
        //    if (acces_token == null) return false;
        //    jwt
        //}
    }
}