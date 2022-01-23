using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class MockCharactersService : ICharactersService
    {
        private static List<CharacterModel> characters = new List<CharacterModel>
        {
            new CharacterModel
            {
                Id = "1",
                Name = "Aerenthil",
                Class = "Demon Hunter",
                Level = 60,
                ItemLevel = 238,
                ArenaRating =  0,
                BattlegroundRating = 0,
                UserId = "1"
            },
            new CharacterModel
            {
                Id = "2",
                Name = "Ghortak",
                Class = "Death Knight",
                Level = 60,
                ItemLevel = 243,
                ArenaRating =  0,
                BattlegroundRating = 0,
                UserId = "1"
            },
            new CharacterModel
            {
                Id = "3",
                Name = "Bauglir",
                Class = "Druid",
                Level = 60,
                ItemLevel = 238,
                ArenaRating =  1425,
                BattlegroundRating = 850,
                UserId = "2"
            },
            new CharacterModel
            {
                Id = "4",
                Name = "Liutasil",
                Class = "Paladin",
                Level = 60,
                ItemLevel = 170,
                ArenaRating =  0,
                BattlegroundRating = 192,
                UserId = "2"
            },
            new CharacterModel
            {
                Id = "5",
                Name = "Yoriko",
                Class = "Shaman",
                Level = 60,
                ItemLevel = 239,
                ArenaRating =  2458,
                BattlegroundRating = 1608,
                UserId = "3"
            },
            new CharacterModel
            {
                Id = "6",
                Name = "Elen",
                Class = "Warlock",
                Level = 60,
                ItemLevel = 170,
                ArenaRating =  0,
                BattlegroundRating = 0,
                UserId = "3",
                IsDeleted = true
            }
        };

        public Task<IEnumerable<CharacterModel>> GetCharacters()
        {
            return Task.FromResult(characters.AsEnumerable());
        }

        public async Task<CharacterModel> GetCharacterById(string id)
        {
            return (await GetCharacters()).FirstOrDefault(c => c.Id.Equals(id));
        }

        public Task<IEnumerable<CharacterModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CharacterModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CharacterModel> AddAsync(CharacterModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<CharacterModel> UpdateAsync(CharacterModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<CharacterModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CharacterModel>> GetCharactersByUserIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
