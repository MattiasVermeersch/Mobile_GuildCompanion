using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class LoginUserResponseDto
    {
        public string Token { get; set; }
        public bool SignInSucceeded { get; set; } = true;
        public string UserId { get; set; }
    }
}
