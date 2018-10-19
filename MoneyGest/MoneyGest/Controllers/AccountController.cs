using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IdentityModel.Tokens;

namespace MoneyGest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        //public static bool SsoAuth(string acces_token)
        //{
        //    if (acces_token == null) return false;
        //    jwt
        //}
    }
}