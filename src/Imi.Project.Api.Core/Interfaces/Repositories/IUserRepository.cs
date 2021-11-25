using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IUserRepository : IUserManagerRepository<User>
    {
        Task<User> UpdateClaims(string id);
        Task<User> GetUserByCharacterIdAsync(Guid id);
        Task<User> UpdateAsync(User user, string role);
    }
}
