using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class MockBattlegroundService : IEventService<BattlegroundModel>
    {
        private static List<BattlegroundModel> battlegroundEvents = new List<BattlegroundModel>
        {
            new BattlegroundModel
            {
                Id = "51",
                InstanceName = "Warsong Gulch",
                Date = new DateTime(2021, 06, 17),
                IsWon = true
            },
            new BattlegroundModel
            {
                Id = "52",
                InstanceName = "Eye of the Storm",
                Date = new DateTime(2021, 06, 17)
            },
            new BattlegroundModel
            {
                Id = "53",
                InstanceName = "Battle for Gilneas",
                Date = new DateTime(2021, 06, 17)
            },
            new BattlegroundModel
            {
                Id = "54",
                InstanceName = "Temple of Kotmogu",
                Date = new DateTime(2021, 06, 17)
            }
        };

        public Task<BattlegroundModel> AddAsync(BattlegroundModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<BattlegroundModel> AddCharacterToInstance(string id, CharacterModel character)
        {
            throw new NotImplementedException();
        }

        public Task<BattlegroundModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BattlegroundModel>> GetAll()
        {
            return Task.FromResult(battlegroundEvents.AsEnumerable());
        }

        public Task<IEnumerable<BattlegroundModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BattlegroundModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(b => b.Id.Equals(id));
        }

        public Task<BattlegroundModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BattlegroundModel>> GetUpcomingEvents()
        {
            throw new NotImplementedException();
        }

        public Task<BattlegroundModel> RemoveCharacterFromInstance(string eventId, string characterId)
        {
            throw new NotImplementedException();
        }

        public Task<BattlegroundModel> UpdateAsync(BattlegroundModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
