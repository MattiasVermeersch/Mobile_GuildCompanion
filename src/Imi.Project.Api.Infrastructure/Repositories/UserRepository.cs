using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UserRepository : UserManagerRepository<User>, IUserRepository
    {
        private readonly JWTConfiguration _jWTConfiguration;
        public UserRepository(UserManager<User> userManager, 
            SignInManager<User> signInManager,
            JWTConfiguration jWTConfiguration
            ) 
            : base(userManager, signInManager) 
        {
            _jWTConfiguration = jWTConfiguration;
        }

        public override IQueryable<User> GetAllAsync()
        {
            return _userManager.Users
                .Include(u => u.Characters);
        }

        public override async Task<User> GetByIdAsync(string id)
        {
            var user = await GetAllAsync().SingleOrDefaultAsync(u => u.Id.Equals(id));
            user.Roles = await _userManager.GetRolesAsync(user);
            return user;
        }

        public override async Task<IEnumerable<User>> ListAllAsync()
        {
            var users = await GetAllAsync().ToListAsync();
            foreach(var user in users)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return users;
        }

        public override async Task<User> AddAsync(User user)
        {
            var password = user.Password;
            
            var result = await _userManager.CreateAsync(user, password);
            await _userManager.AddToRoleAsync(user, "GuildMember");

            if(!result.Succeeded) { 
                user.IdentityError = result;
                await _userManager.DeleteAsync(user);
                return user; 
            }

            
            User newUser = await _userManager.FindByEmailAsync(user.Email);
            await _userManager.AddClaimAsync(newUser,
                new Claim("registration-date", DateTime.UtcNow.ToString("yyyy-MM-dd")));

            string hasCharacters;
            if (newUser.Characters == null) hasCharacters = "false";
            else hasCharacters = "true";

            await _userManager.AddClaimAsync(newUser,
                new Claim("has-characters", hasCharacters));

            return newUser;
        }

        public async Task<User> UpdateAsync(User user, string role)
        {
            var userToEdit = await _userManager.FindByIdAsync(user.Id);

            userToEdit.BirthDate = user.BirthDate;
            userToEdit.Email = user.Email;
            userToEdit.Address = user.Address;
            userToEdit.FullName = user.FullName;
            userToEdit.City = user.City;

            var editUser = await _userManager.UpdateAsync(userToEdit);
            var result = editUser.Succeeded;
            var error = editUser.Errors;
            var userRole = await _userManager.GetRolesAsync(user);
            if(userRole.Contains(role))
            {
                await _userManager.RemoveFromRolesAsync(user, userRole);
                await _userManager.AddToRoleAsync(user, role);
            }
            return user;
        }

        public override async Task<User> LoginUser(string email, string password, bool isPersistent, bool lockoutOnFailure) {
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent, lockoutOnFailure);

            if(!result.Succeeded)
            {
                return new User { SignInSucceeded = false } ;
            }

            var user = await _userManager.FindByEmailAsync(email);

            JwtSecurityToken token = await GenerateTokenAsync(user);

            string serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

            user.Token = serializedToken;

            return user;
        }

        public async Task<User> UpdateClaims(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userClaims = await _userManager.GetClaimsAsync(user);
            Claim newClaim;

            var userCharacters = user.Characters.Where(c => c.IsDeleted == false).ToList();
            var characterCount = userCharacters.Count;
            if (characterCount == 0) newClaim = new Claim("has-characters", "false");
            else newClaim = new Claim("has-characters", "true");

            foreach(var userClaim in userClaims)
            {
                if(userClaim.Type == "has-characters" && userClaim.Value != newClaim.Value)
                {
                    await _userManager.RemoveClaimAsync(user, userClaim);
                    await _userManager.AddClaimAsync(user, newClaim);
                }
            }
            return user;
        }

        public async Task<User> GetUserByCharacterIdAsync(Guid id)
        {
            var user = await GetAllAsync().Where(u => u.Characters.Any(c => c.Id.Equals(id))).SingleOrDefaultAsync();
            return user;
        }

        private async Task<JwtSecurityToken> GenerateTokenAsync(User user)
        {
            var claims = new List<Claim>(); 
            
            // Loading the user Claims 
            var userClaims = await _userManager.GetClaimsAsync(user); 
            claims.AddRange(userClaims); 
            
            // Loading the roles and put them in a claim of a Role ClaimType 
            var roleClaims = await _userManager.GetRolesAsync(user); 
            foreach (var roleClaim in roleClaims) 
            { 
                claims.Add(new Claim(ClaimTypes.Role, roleClaim)); 
            } 
            var expirationDays = _jWTConfiguration.TokenExpirationDays; 
            var siginingKey = Encoding.UTF8.GetBytes(_jWTConfiguration.SigningKey); 
            var token = new JwtSecurityToken ( 
                issuer: _jWTConfiguration.Issuer, 
                audience: _jWTConfiguration.Audience, 
                claims: claims, 
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)), 
                notBefore: DateTime.UtcNow, 
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(siginingKey), 
                    SecurityAlgorithms.HmacSha256) 
                ); 
            
            return token;
        }
    }
}
