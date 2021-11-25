using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IArenaService _arenaService;
        private readonly IBattlegroundService _battlegroundService;
        private readonly IDungeonService _dungeonService;
        private readonly IRaidService _raidService;

        public CharactersController(ICharacterService characterService,
            IArenaService arenaService, IBattlegroundService battlegroundService,
            IDungeonService dungeonService, IRaidService raidService)
        {
            _characterService = characterService;
            _arenaService = arenaService;
            _battlegroundService = battlegroundService;
            _dungeonService = dungeonService;
            _raidService = raidService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var characters = await _characterService.ListAllAsync();

            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var character = await _characterService.GetByIdAsync(id);

            if(character == null)
            {
                return NotFound($"No character with ID {id} could be found.");
            }

            return Ok(character);
        }

        [HttpGet("{id}/arenas")]
        public async Task<IActionResult> GetArenasByCharacterId(Guid id)
        {
            var characters = await _arenaService.GetByCharacterId(id);

            return Ok(characters);
        }

        [HttpGet("{id}/battlegrounds")]
        public async Task<IActionResult> GetBattlegroundsByCharacterId(Guid id)
        {
            var characters = await _battlegroundService.GetByCharacterId(id);

            return Ok(characters);
        }

        [HttpGet("{id}/dungeons")]
        public async Task<IActionResult> GetDungeonsByCharacterId(Guid id)
        {
            var characters = await _dungeonService.GetByCharacterId(id);

            return Ok(characters);
        }

        [HttpGet("{id}/raids")]
        public async Task<IActionResult> GetRaidsByCharacterId(Guid id)
        {
            var characters = await _raidService.GetByCharacterId(id);

            return Ok(characters);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Post(CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var characterResponse = await _characterService.AddAsync(characterRequest);
            return CreatedAtAction(nameof(Get), new { id = characterResponse.Id }, characterResponse);
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<IActionResult> Put(CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var characterResponse = await _characterService.UpdateAsync(characterRequest);
            return Ok(characterResponse);
        }

        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var character = await _characterService.GetByIdAsync(id);

            if(character == null)
            {
                return BadRequest($"Character with ID {id} could not be found.");
            }

            await _characterService.DeleteAsync(id);
            return Ok();
        }
    }
}
