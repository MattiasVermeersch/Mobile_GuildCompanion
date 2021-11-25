using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IDungeonService
    {
        Task<IEnumerable<DungeonResponseDto>> ListAllAsync();
        Task<DungeonResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<DungeonResponseDto>> GetByCharacterId(Guid id);
        Task<DungeonResponseDto> AddAsync(DungeonRequestDto dungeonRequest);
        Task<DungeonResponseDto> UpdateAsync(DungeonRequestDto dungeonRequest);
        Task DeleteAsync(Guid id);
        Task<DungeonResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest);
        Task<DungeonResponseDto> DeleteCharacterAsync(Guid dungeonId, Guid characterId);
    }
}
