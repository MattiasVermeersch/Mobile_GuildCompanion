using Imi.Project.Api.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class User : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public ICollection<Character> Characters { get; set; }

        //NotMapped Roles are already in Identity
        [NotMapped]
        public IEnumerable<string> Roles { get; set; }

        //Notmapped properties to load user claims and roles for UserRepository
        [NotMapped]
        public IdentityResult IdentityError { get; set; }
        [NotMapped]
        public bool SignInSucceeded { get; set; } = true;

        //Token prop to that generating token could be performed in UserRepository
        [NotMapped]
        public string Token { get; set; }
    }
}
