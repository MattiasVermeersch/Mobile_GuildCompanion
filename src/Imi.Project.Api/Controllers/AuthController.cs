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
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto registerUser)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userResponse = await _userService.AddAsync(registerUser);

            var errorResult = userResponse.Error;

            if (errorResult != null && !errorResult.Succeeded)
            {
                foreach (var error in errorResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            return Ok(userResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserRequestDto login)
        {
            var loginResponse = await _userService.LoginUser(login);

            if (!loginResponse.SignInSucceeded) return Unauthorized();

            return Ok(loginResponse);
        }
    }
}
