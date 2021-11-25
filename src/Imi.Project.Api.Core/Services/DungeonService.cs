using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class DungeonService : IDungeonService
    {
        private readonly IDungeonRepository _dungeonRepository;
        private readonly IMapper _mapper;

        public DungeonService(IDungeonRepository dungeonRepo, IMapper mapper)
        {
            _dungeonRepository = dungeonRepo;
            _mapper = mapper;
        }

        public async Task<DungeonResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _dungeonRepository.GetByIdAsync(id);

            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<DungeonResponseDto>> ListAllAsync()
        {
            var result = await _dungeonRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<DungeonResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<DungeonResponseDto>> GetByCharacterId(Guid id)
        {
            var result = await _dungeonRepository.GetByCharacterId(id);

            var dto = _mapper.Map<IEnumerable<DungeonResponseDto>>(result);
            return dto;
        }

        public async Task<DungeonResponseDto> AddAsync(DungeonRequestDto dungeonRequest)
        {
            var dungeon = _mapper.Map<Dungeon>(dungeonRequest);
            var result = await _dungeonRepository.AddAsync(dungeon);
            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }

        public async Task<DungeonResponseDto> UpdateAsync(DungeonRequestDto dungeonRequest)
        {
            var dungeon = _mapper.Map<Dungeon>(dungeonRequest);
            var result = await _dungeonRepository.UpdateAsync(dungeon);
            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _dungeonRepository.DeleteAsync(id);
        }

        public async Task<DungeonResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _dungeonRepository.AddCharacterAsync(id, character);
            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }

        public async Task<DungeonResponseDto> DeleteCharacterAsync(Guid dungeonId, Guid characterId)
        {
            var result = await _dungeonRepository.DeleteCharacterAsync(dungeonId, characterId);
            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }
    }
}
