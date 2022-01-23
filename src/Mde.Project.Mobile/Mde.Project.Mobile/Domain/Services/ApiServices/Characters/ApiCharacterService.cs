using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ApiCharacterService : BaseService<CharacterModel>, ICharactersService
    {
        protected string _usersUrl; 
        public ApiCharacterService()
        {
            _url = ApiConstants.ApiCharactersUrl;
            _usersUrl = ApiConstants.ApiUsersUrl;
        }

        public async Task<IEnumerable<CharacterModel>> GetCharactersByUserIdAsync()
        {
            await GetStorageUserId();
            var userCharacters = await ApiClient.GetAsync<IEnumerable<CharacterModel>>($"{_usersUrl}/{_userId}/{ApiConstants.Characters}");
            return userCharacters;
        }

        public override async Task<CharacterModel> AddAsync(CharacterModel entity)
        {
            var characterRequest = new
            {
                entity.Name,
                entity.Class,
                entity.Role,
                entity.Level,
                entity.ItemLevel,
                entity.ArenaRating,
                entity.BattlegroundRating,
                entity.UserId
            };

            var response = await ApiClient.PostAsync<CharacterModel>(_url, characterRequest);
            return response;
        }
    }
}
