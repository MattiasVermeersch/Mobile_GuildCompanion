using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class DungeonService : IEventService<DungeonModel>
    {
        private static List<DungeonModel> dungeonEvents = new List<DungeonModel>
        {
            new DungeonModel
            {
                Id = "10",
                Name = "De Other Side",
                Date = DateTime.Now,
                Difficulty = "Heroic",
                Success = true
            },
            new DungeonModel
            {
                Id = "11",
                Name = "Halls of Atonement",
                Date = new DateTime(2021, 03, 21),
                Difficulty = "Normal",
                Success = true
            },
            new DungeonModel
            {
                Id = "12",
                Name = "Spires of Ascension",
                Date = new DateTime(2021, 04, 21),
                Difficulty = "Mythic",
                Key = 5,
                Success = true
            }
        };

        public Task<IEnumerable<DungeonModel>> GetAll()
        {
            return Task.FromResult(dungeonEvents.AsEnumerable());
        }

        public async Task<DungeonModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(d => d.Id.Equals(id));
        }
    }
}
