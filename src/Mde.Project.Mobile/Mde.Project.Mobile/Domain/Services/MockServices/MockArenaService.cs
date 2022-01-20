using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class MockArenaService : IEventService<ArenaModel>
    {
        private static List<ArenaModel> arenaEvents = new List<ArenaModel>
        {
            new ArenaModel
            {
                Id = "41",
                InstanceName = "Circle of Blood",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "42",
                InstanceName = "Hook Point",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "43",
                InstanceName = "Tol'Viron",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "44",
                InstanceName = "Ashamane's Fall",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            }
        };

        public Task<ArenaModel> AddAsync(ArenaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<ArenaModel> AddCharacterToInstance(string id, CharacterModel character)
        {
            throw new NotImplementedException();
        }

        public Task<ArenaModel> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArenaModel>> GetAll()
        {
            return Task.FromResult(arenaEvents.AsEnumerable());
        }

        public Task<IEnumerable<ArenaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ArenaModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(a => a.Id.Equals(id));
        }

        public Task<ArenaModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ArenaModel> UpdateAsync(ArenaModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
