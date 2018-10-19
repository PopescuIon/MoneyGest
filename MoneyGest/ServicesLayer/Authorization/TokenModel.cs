using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Authorization
{
    public class TokenModel
    {
        public string acces_token { get; set; }
        public string token_type { get; set; }
        public string expires_in{ get; set; }
        public string refresh_token { get; set; }
        public string loginName{ get; set; }
        public string imp { get; set; }
        public string client { get; set; }
        public int loginId { get; set; }
    }
}
