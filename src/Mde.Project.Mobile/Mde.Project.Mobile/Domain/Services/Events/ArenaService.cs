using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ArenaService : IEventService<ArenaModel>
    {
        private static List<ArenaModel> arenaEvents = new List<ArenaModel>
        {
            new ArenaModel
            {
                Id = "41",
                Name = "Circle of Blood",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "42",
                Name = "Hook Point",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "43",
                Name = "Tol'Viron",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            },
            new ArenaModel
            {
                Id = "44",
                Name = "Ashamane's Fall",
                Date = new DateTime(2021, 06, 21),
                Mode = "2v2",
            }
        };

        public Task<IEnumerable<ArenaModel>> GetAll()
        {
            return Task.FromResult(arenaEvents.AsEnumerable());
        }

        public async Task<ArenaModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(a => a.Id.Equals(id));
        }
    }
}
