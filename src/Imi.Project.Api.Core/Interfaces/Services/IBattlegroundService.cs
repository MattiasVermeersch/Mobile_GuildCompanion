using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IBattlegroundService
    {
        Task<IEnumerable<BattlegroundResponseDto>> ListAllAsync();
        Task<BattlegroundResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<BattlegroundResponseDto>> GetByCharacterId(Guid id);
        Task<BattlegroundResponseDto> AddAsync(BattlegroundRequestDto battlegroundRequest);
        Task<BattlegroundResponseDto> UpdateAsync(BattlegroundRequestDto battlegroundRequest);
        Task DeleteAsync(Guid id);
        Task<BattlegroundResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest);
        Task<BattlegroundResponseDto> DeleteCharacterAsync(Guid battleGroundId, Guid characterId);
    }
}
