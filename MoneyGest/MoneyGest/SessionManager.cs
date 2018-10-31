using System.Web;
using ServicesLayer.Authorization;
using Common;




namespace MoneyGest
{
    public class SessionManager
    {
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
        private static void SetSession<T>(string sessionId, T value)
        {
            HttpContext.Current.Session[sessionId] = value;
        }

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
        public static AutorizationManager AutorizationManager
        {
            get
            {
                return GetSession<AutorizationManager>(Constants.SessionKey.AutentificationInfo);
            }
            set
            {
                SetSession<AutorizationManager>(Constants.SessionKey.AutentificationInfo, value);
            }
        }

        public static void ClearAndAbandonSession()
        {
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
        }





    }
}