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
    public class RaidService : IRaidService
    {
        private readonly IRaidRepository _raidRepository;
        private readonly IMapper _mapper;

        public RaidService(IRaidRepository raidRepo, IMapper mapper)
        {
            _raidRepository = raidRepo;
            _mapper = mapper;
        }

        public async Task<RaidResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _raidRepository.GetByIdAsync(id);

            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<RaidResponseDto>> ListAllAsync()
        {
            var result = await _raidRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<RaidResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<RaidResponseDto>> GetByCharacterId(Guid id)
        {
            var result = await _raidRepository.GetByCharacterId(id);

            var dto = _mapper.Map<IEnumerable<RaidResponseDto>>(result);
            return dto;
        }

        public async Task<RaidResponseDto> AddAsync(RaidRequestDto raidRequest)
        {
            var raid = _mapper.Map<Raid>(raidRequest);
            var result = await _raidRepository.AddAsync(raid);
            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task<RaidResponseDto> UpdateAsync(RaidRequestDto raidRequest)
        {
            var raid = _mapper.Map<Raid>(raidRequest);
            var result = await _raidRepository.UpdateAsync(raid);
            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _raidRepository.DeleteAsync(id);
        }

        public async Task<RaidResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _raidRepository.AddCharacterAsync(id, character);
            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task<RaidResponseDto> DeleteCharacterAsync(Guid raidId, Guid characterId)
        {
            var result = await _raidRepository.DeleteCharacterAsync(raidId, characterId);
            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }
    }
}
