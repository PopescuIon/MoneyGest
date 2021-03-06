﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IdentityModel.Tokens;
using ServicesLayer.Authorization;
using MoneyGest.Helpers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Common;
using MoneyGest.Controls;

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
        public async Task<JsonResult> Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = null;
                bool autentificationPath = true;
                using (var client = new HttpClientHelper(null, autentificationPath))
                {

                    var body = new List<KeyValuePair<string, string>>
                    {
                       new KeyValuePair<string, string>("grant_type", "password"),
                       new KeyValuePair<string, string>(Common.Constants.HeaderParameterNames.LoginName, model.LoginName),
                       new KeyValuePair<string, string>(Common.Constants.HeaderParameterNames.Password, model.Password)
                    };
                    var content = new FormUrlEncodedContent(body);
                    response = await client.PostAsync("", content);
                    if (!response.IsSuccessStatusCode)
                    {
                        var er = response.Content.ReadAsAsync<ErrorResultModel>();
                        return  new FormErrorResponse(er.Result.message);
                    }
                    else
                    {
                        try
                        {
                            var tk = response.Content.ReadAsStringAsync();
                            var token = await response.Content.ReadAsAsync<TokenModel>();
                            SessionManager.Autentification = token;
                            return new FormSuccesResponse("Login Succes!!", false);
                        }
                        catch (Exception ex)
                        {
                            return new FormErrorResponse(ex.Message);
                        }


                    }
                }
            }
            return Json(new { succes = false }, JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult Logout()
        {
            if (SessionManager.Autentification != null)
            {
                SessionManager.ClearAndAbandonSession();
               
            }
            return Redirect("~/Account");
        }

    }
}