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
    [Authorize(Policy = "OnlyUsersWithCharacters")]
    [Route("api/[controller]")]
    [ApiController]
    public class DungeonsController : ControllerBase
    {
        private readonly IDungeonService _dungeonService;

        public DungeonsController(IDungeonService dungeonService)
        {
            _dungeonService = dungeonService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dungeons = await _dungeonService.ListAllAsync();

            return Ok(dungeons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dungeon = await _dungeonService.GetByIdAsync(id);

            if(dungeon == null)
            {
                return NotFound($"A dungeon with ID {id} could not be found.");
            }

            return Ok(dungeon);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DungeonRequestDto dungeonRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dungeonResponse = await _dungeonService.AddAsync(dungeonRequest);
            return CreatedAtAction(nameof(Get), new { id = dungeonResponse.Id }, dungeonResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DungeonRequestDto dungeonRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dungeonResponse = await _dungeonService.UpdateAsync(dungeonRequest);

            return Ok(dungeonResponse);
        }

        [HttpPut("/api/dungeons/{id}/character")]
        public async Task<IActionResult> PutAddCharacterToDungeon(Guid id, CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dungeonResponse = await _dungeonService.AddCharacterAsync(id, characterRequest);

            return Ok(dungeonResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var dungeon = await _dungeonService.GetByIdAsync(id);

            if (dungeon == null)
            {
                return NotFound($"Dungeon with ID {id} could not be found.");
            }

            await _dungeonService.DeleteAsync(id);
            return Ok();
        }

        [HttpDelete("/api/dungeons/{dungeonId}/character/{characterId}")]
        public async Task<IActionResult> DeleteCharacterFromDungeon(Guid dungeonId, Guid characterId)
        {
            var dungeon = await _dungeonService.GetByIdAsync(dungeonId);

            if (dungeon == null)
            {
                return NotFound($"Dungeon with ID {dungeonId} could not be found.");
            }

            var dungeonResponse = await _dungeonService.DeleteCharacterAsync(dungeonId, characterId);

            return Ok(dungeonResponse);
        }
    }
}
