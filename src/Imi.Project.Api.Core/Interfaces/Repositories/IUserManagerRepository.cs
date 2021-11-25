using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IUserManagerRepository<T> : IBaseRepository<T, string>
        where T : IdentityUser
    {
        public Task<T> LoginUser(string email, string password, bool isPersistent, bool lockoutOnFailure);
    }
}
