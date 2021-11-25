using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class UserRequestDto : BaseIdentityDto
    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Role { get; set; }
    }
}
