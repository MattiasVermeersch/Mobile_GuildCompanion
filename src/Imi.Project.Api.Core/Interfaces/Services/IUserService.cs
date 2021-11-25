using Imi.Project.Api.Core.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDto>> ListAllAsync();
        Task<UserResponseDto> GetByIdAsync(string id);
        Task<UserResponseDto> AddAsync(RegisterUserRequestDto registerUserRequestDto);
        Task<UserResponseDto> UpdateAsync(UserRequestDto userRequestDto);
        Task DeleteAsync(string id);
        Task<LoginUserResponseDto> LoginUser(LoginUserRequestDto loginUserRequestDto);
    }
}
