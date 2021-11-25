using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IArenaRepository : IRepository<Arena>
    {
        Task<IEnumerable<Arena>> GetByCharacterId(Guid id);
        Task<Arena> AddCharacterAsync(Guid id, Character character);
        Task<Arena> DeleteCharacterAsync(Guid arenaId, Guid characterId);
    }
}
