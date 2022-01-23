using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class MockDungeonService : IEventService<DungeonModel>
    {
        private static List<DungeonModel> dungeonEvents = new List<DungeonModel>
        {
            new DungeonModel
            {
                Id = "10",
                InstanceName = "De Other Side",
                Date = DateTime.Now,
                Difficulty = "Heroic",
                Success = true
            },
            new DungeonModel
            {
                Id = "11",
                InstanceName = "Halls of Atonement",
                Date = new DateTime(2021, 03, 21),
                Difficulty = "Normal",
                Success = true
            },
            new DungeonModel
            {
                Id = "12",
                InstanceName = "Spires of Ascension",
                Date = new DateTime(2021, 04, 21),
                Difficulty = "Mythic",
                Key = 5,
                Success = true
            }
        };

        public Task<DungeonModel> AddAsync(DungeonModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<DungeonModel> AddCharacterToInstance(string id, CharacterModel character)
        {
            throw new NotImplementedException();
        }

        public Task<DungeonModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DungeonModel>> GetAll()
        {
            return Task.FromResult(dungeonEvents.AsEnumerable());
        }

        public Task<IEnumerable<DungeonModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DungeonModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(d => d.Id.Equals(id));
        }

        public Task<DungeonModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DungeonModel> RemoveCharacterFromInstance(string eventId, string characterId)
        {
            throw new NotImplementedException();
        }

        public Task<DungeonModel> UpdateAsync(DungeonModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
