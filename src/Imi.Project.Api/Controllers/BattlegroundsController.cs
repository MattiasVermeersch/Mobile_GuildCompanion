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
    [Authorize(Policy = "RegisteredForAWeek")]
    [Route("api/[controller]")]
    [ApiController]
    public class BattlegroundsController : ControllerBase
    {
        private readonly IBattlegroundService _battlegroundService;
        public BattlegroundsController(IBattlegroundService battlegroundService)
        {
            _battlegroundService = battlegroundService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var battleGrounds = await _battlegroundService.ListAllAsync();

            return Ok(battleGrounds);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var battleGround = await _battlegroundService.GetByIdAsync(id);

            if(battleGround == null)
            {
                return NotFound($"Battleground with ID {id} could not be found.");
            }

            return Ok(battleGround);
        }

        [HttpPost]
        public async Task<IActionResult> Post(BattlegroundRequestDto battlegroundRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var battlegroundResponse = await _battlegroundService.AddAsync(battlegroundRequest);
            return CreatedAtAction(nameof(Get), new { id = battlegroundResponse.Id }, battlegroundResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put(BattlegroundRequestDto battlegroundRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var battlegroundResponse = await _battlegroundService.UpdateAsync(battlegroundRequest);

            return Ok(battlegroundResponse);
        }

        [HttpPut("/api/battlegrounds/{id}/character")]
        public async Task<IActionResult> PutAddCharacterToBattleground(Guid id, CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var battlegroundResponse = await _battlegroundService.AddCharacterAsync(id, characterRequest);

            return Ok(battlegroundResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var battleground = await _battlegroundService.GetByIdAsync(id);

            if (battleground == null)
            {
                return NotFound($"Battleground with ID {id} could not be found.");
            }

            await _battlegroundService.DeleteAsync(id);
            return Ok();
        }

        [HttpDelete("/api/battlegrounds/{battleGroundId}/character/{characterId}")]
        public async Task<IActionResult> DeleteCharacterFromBattleground(Guid battleGroundId, Guid characterId)
        {
            var battleground = await _battlegroundService.GetByIdAsync(battleGroundId);

            if (battleground == null)
            {
                return NotFound($"Battleground with ID {battleGroundId} could not be found.");
            }

            var battlegroundResponse = await _battlegroundService.DeleteCharacterAsync(battleGroundId, characterId);

            return Ok(battlegroundResponse);
        }
    }
}
