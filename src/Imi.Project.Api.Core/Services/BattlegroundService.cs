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
    public class BattlegroundService : IBattlegroundService
    {
        private readonly IBattlegroundRepository _battlegroundRepository;
        private readonly IMapper _mapper;

        public BattlegroundService(IBattlegroundRepository battlegroundRepo, IMapper mapper)
        {
            _battlegroundRepository = battlegroundRepo;
            _mapper = mapper;
        }

        public async Task<BattlegroundResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _battlegroundRepository.GetByIdAsync(id);

            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<BattlegroundResponseDto>> ListAllAsync()
        {
            var result = await _battlegroundRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<BattlegroundResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<BattlegroundResponseDto>> GetByCharacterId(Guid id)
        {
            var result = await _battlegroundRepository.GetByCharacterId(id);

            var dto = _mapper.Map<IEnumerable<BattlegroundResponseDto>>(result);
            return dto;
        }

        public async Task<BattlegroundResponseDto> AddAsync(BattlegroundRequestDto battlegroundRequest)
        {
            var battleground = _mapper.Map<Battleground>(battlegroundRequest);
            var result = await _battlegroundRepository.AddAsync(battleground);
            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task<BattlegroundResponseDto> UpdateAsync(BattlegroundRequestDto battlegroundRequest)
        {
            var battleground = _mapper.Map<Battleground>(battlegroundRequest);
            var result = await _battlegroundRepository.UpdateAsync(battleground);
            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _battlegroundRepository.DeleteAsync(id);
        }

        public async Task<BattlegroundResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _battlegroundRepository.AddCharacterAsync(id, character);
            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task<BattlegroundResponseDto> DeleteCharacterAsync(Guid battleGroundId, Guid characterId)
        {
            var result = await _battlegroundRepository.DeleteCharacterAsync(battleGroundId, characterId);
            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }
    }
}
