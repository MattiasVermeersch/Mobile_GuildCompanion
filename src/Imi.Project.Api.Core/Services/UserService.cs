using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserResponseDto> GetByIdAsync(string id)
        {
            var result = await _userRepository.GetByIdAsync(id);

            var dto = _mapper.Map<UserResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<UserResponseDto>> ListAllAsync()
        {
            var result = await _userRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<UserResponseDto>>(result);
            return dto;
        }

        public async Task<UserResponseDto> AddAsync(RegisterUserRequestDto registerUserRequestDto)
        {
            var user = _mapper.Map<User>(registerUserRequestDto);

            user.FullName = registerUserRequestDto.FirstName + " " + registerUserRequestDto.LastName;
            user.UserName = registerUserRequestDto.Email;

            var result = await _userRepository.AddAsync(user);
            var dto = _mapper.Map<UserResponseDto>(result);

            dto.Error = result.IdentityError;

            return dto;
        }

        public async Task<UserResponseDto> UpdateAsync(UserRequestDto userRequestDto)
        {
            userRequestDto.UserName = userRequestDto.Email.Split('@')[0];
            var user = _mapper.Map<User>(userRequestDto);
            var result = await _userRepository.UpdateAsync(user, userRequestDto.Role);
            var dto = _mapper.Map<UserResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(string id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<LoginUserResponseDto> LoginUser(LoginUserRequestDto loginUserRequestDto)
        {
            var user = await _userRepository.LoginUser(loginUserRequestDto.Email, loginUserRequestDto.Password, false, false);

            var success = user.SignInSucceeded;

            if (!success)
            {
                return new LoginUserResponseDto { SignInSucceeded = false };
            }

            var response = new LoginUserResponseDto
            {
                Token = user.Token,
                UserId = user.Id
            };

            return response;
        }
    }
}
