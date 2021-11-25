using Imi.Project.Api.Core.Dtos.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class UserResponseDto : BaseIdentityDto
    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public IdentityResult Error { get; set; }
        public ICollection<SimpleCharacterResponseDto> Characters { get; set; }
    }
}
