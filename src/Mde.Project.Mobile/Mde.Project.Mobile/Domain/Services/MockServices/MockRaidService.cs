using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class MockRaidService : IEventService<RaidModel>
    {
        private static List<RaidModel> raidEvents = new List<RaidModel>
        {
            new RaidModel
            {
                Id ="20",
                InstanceName =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 10)
            },
            new RaidModel
            {
                Id ="21",
                InstanceName =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 17)
            },
            new RaidModel
            {
                Id ="23",
                InstanceName =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 24)
            }
        };

        public Task<RaidModel> AddAsync(RaidModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<RaidModel> AddCharacterToInstance(string id, CharacterModel character)
        {
            throw new NotImplementedException();
        }

        public Task<RaidModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RaidModel>> GetAll()
        {
            return Task.FromResult(raidEvents.AsEnumerable());
        }

        public Task<IEnumerable<RaidModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<RaidModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(r => r.Id.Equals(id)); 
        }

        public Task<RaidModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RaidModel>> GetUpcomingEvents()
        {
            throw new NotImplementedException();
        }

        public Task<RaidModel> RemoveCharacterFromInstance(string eventId, string characterId)
        {
            throw new NotImplementedException();
        }

        public Task<RaidModel> UpdateAsync(RaidModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
