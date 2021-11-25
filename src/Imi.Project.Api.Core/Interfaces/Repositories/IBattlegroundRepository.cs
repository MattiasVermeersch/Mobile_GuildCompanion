using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IBattlegroundRepository : IRepository<Battleground>
    {
        Task<IEnumerable<Battleground>> GetByCharacterId(Guid id);
        Task<Battleground> AddCharacterAsync(Guid id, Character character);
        Task<Battleground> DeleteCharacterAsync(Guid battleGroundId, Guid characterId);
    }
}
