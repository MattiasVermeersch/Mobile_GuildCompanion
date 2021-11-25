using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface ICharacterRepository : IRepository<Character>
    {
        Task<IEnumerable<Character>> GetByUserIdAsync(string id);
    }
}
