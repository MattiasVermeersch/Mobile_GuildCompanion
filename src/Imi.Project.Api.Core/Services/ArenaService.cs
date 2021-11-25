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
    public class ArenaService : IArenaService
    {
        private readonly IArenaRepository _arenaRepository;
        private readonly IMapper _mapper;

        public ArenaService(IArenaRepository arenaRepo, IMapper mapper)
        {
            _arenaRepository = arenaRepo;
            _mapper = mapper;
        }

        public async Task<ArenaResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _arenaRepository.GetByIdAsync(id);

            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<ArenaResponseDto>> ListAllAsync()
        {
            var result = await _arenaRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<ArenaResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<ArenaResponseDto>> GetByCharacterId(Guid id)
        {
            var result = await _arenaRepository.GetByCharacterId(id);

            var dto = _mapper.Map<IEnumerable<ArenaResponseDto>>(result);
            return dto;
        }

        public async Task<ArenaResponseDto> AddAsync(ArenaRequestDto arenaRequestDto)
        {
            var arena =  _mapper.Map<Arena>(arenaRequestDto);
            var result = await _arenaRepository.AddAsync(arena);
            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task<ArenaResponseDto> UpdateAsync(ArenaRequestDto arenaRequestDto)
        {
            var arena = _mapper.Map<Arena>(arenaRequestDto);
            var result = await _arenaRepository.UpdateAsync(arena);
            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _arenaRepository.DeleteAsync(id);
        }

        public async Task<ArenaResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _arenaRepository.AddCharacterAsync(id, character);
            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task<ArenaResponseDto> DeleteCharacterAsync(Guid arenaId, Guid characterId)
        {
            var result = await _arenaRepository.DeleteCharacterAsync(arenaId, characterId);
            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }
    }
}
