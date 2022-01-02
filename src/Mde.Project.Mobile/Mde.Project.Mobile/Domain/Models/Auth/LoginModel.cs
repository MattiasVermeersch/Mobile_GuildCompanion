using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Models
{
    public class LoginModel
    {
        public string Token { get; set; }
        public bool SignInSucceeded { get; set; }
        public string UserId { get; set; }
    }
}
