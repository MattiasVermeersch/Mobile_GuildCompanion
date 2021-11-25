using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
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
    public class ArenasController : ControllerBase
    {
        private readonly IArenaService _arenaService;
        public ArenasController(IArenaService arenaService)
        {
            _arenaService = arenaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var arenas = await _arenaService.ListAllAsync();

            return Ok(arenas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var arena = await _arenaService.GetByIdAsync(id);

            if(arena == null)
            {
                return NotFound($"Arena with ID {id} could not be found.");
            }

            return Ok(arena);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ArenaRequestDto arenaRequest)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var arenaResponse = await _arenaService.AddAsync(arenaRequest);
            return CreatedAtAction(nameof(Get), new { id = arenaResponse.Id }, arenaResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ArenaRequestDto arenaRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var arenaResponse = await _arenaService.UpdateAsync(arenaRequest);

            return Ok(arenaResponse);
        }

        [HttpPut("/api/arenas/{id}/character")]
        public async Task<IActionResult> PutAddCharacterToArena(Guid id, CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var arenaResponse = await _arenaService.AddCharacterAsync(id, characterRequest);

            return Ok(arenaResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var arena = await _arenaService.GetByIdAsync(id);

            if (arena == null)
            {
                return NotFound($"Arena with ID {id} could not be found.");
            }

            await _arenaService.DeleteAsync(id);
            return Ok();
        }

        [HttpDelete("/api/arenas/{arenaId}/character/{characterId}")]
        public async Task<IActionResult> DeleteCharacterFromArena(Guid arenaId, Guid characterId)
        {
            var arena = await _arenaService.GetByIdAsync(arenaId);

            if(arena == null)
            {
                return NotFound($"Arena with ID {arenaId} could not be found.");
            }

            var arenaResponse = await _arenaService.DeleteCharacterAsync(arenaId, characterId);

            return Ok(arenaResponse);
        }
    }
}
