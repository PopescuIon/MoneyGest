using System;
using System.Collections.Generic;
using System.Text;
 


namespace ServicesLayer.Authorization
{
    public class TokenModel
    {

        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }
        public string userName { get; set; }
        public string loginId { get; set; }
    }
}
