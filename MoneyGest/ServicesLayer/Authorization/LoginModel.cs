using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServicesLayer.Authorization
{
    public class LoginModel
    {

        [Required(ErrorMessage ="Login not valid")]
        public string LoginName { get; set; }

    
        [Required(ErrorMessage = "Password not valid")]
        public string Password { get; set; }
    }
}
