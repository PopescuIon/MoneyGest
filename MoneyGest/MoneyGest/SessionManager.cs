using System.Web;
using ServicesLayer.Authorization;
using Common;




namespace MoneyGest
{
    public class SessionManager
    {
        public static TokenModel Autentification
        {
            get
            {
                return GetSession<TokenModel>(Constants.SessionKey.AutentificationInfo);
            }
            set
            {
                SetSession<TokenModel>(Constants.SessionKey.AutentificationInfo, value);
            }
        }

        private static T GetSession<T>(string sessionId)
        {
            T val = default(T);
            var session = HttpContext.Current.Session;
            if (session[sessionId] != null)
            {
                val = (T)session[sessionId];
            }
            return val;
        }
        private  static void SetSession<T>(string sessionId, T value)
        {
            HttpContext.Current.Session[sessionId] = value;
        }
        

    }
}