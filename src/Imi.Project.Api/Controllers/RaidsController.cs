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
    [Authorize(Policy = "RegisteredForAWeek")]
    [Route("api/[controller]")]
    [ApiController]
    public class RaidsController : ControllerBase
    {
        private readonly IRaidService _raidService;
        
        public RaidsController(IRaidService raidService)
        {
            _raidService = raidService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var raids = await _raidService.ListAllAsync();

            return Ok(raids);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var raid = await _raidService.GetByIdAsync(id);

            if(raid == null)
            {
                return NotFound($"Raid with ID {id} could not be found.");
            }

            return Ok(raid);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RaidRequestDto raidRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var raidResponse = await _raidService.AddAsync(raidRequest);
            return CreatedAtAction(nameof(Get), new { id = raidResponse.Id }, raidResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put(RaidRequestDto raidRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var raidResponse = await _raidService.UpdateAsync(raidRequest);

            return Ok(raidResponse);
        }

        [HttpPut("/api/raids/{id}/character")]
        public async Task<IActionResult> PutAddCharacterToRaid(Guid id, CharacterRequestDto characterRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var raidResponse = await _raidService.AddCharacterAsync(id, characterRequest);

            return Ok(raidResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var raid = await _raidService.GetByIdAsync(id);

            if (raid == null)
            {
                return NotFound($"Raid with ID {id} could not be found.");
            }

            await _raidService.DeleteAsync(id);
            return Ok();
        }

        [HttpDelete("/api/raids/{raidId}/character/{characterId}")]
        public async Task<IActionResult> DeleteCharacterFromRaid(Guid raidId, Guid characterId)
        {
            var raid = await _raidService.GetByIdAsync(raidId);

            if (raid == null)
            {
                return NotFound($"Raid with ID {raidId} could not be found.");
            }

            var raidResponse = await _raidService.DeleteCharacterAsync(raidId, characterId);

            return Ok(raidResponse);
        }
    }
}
