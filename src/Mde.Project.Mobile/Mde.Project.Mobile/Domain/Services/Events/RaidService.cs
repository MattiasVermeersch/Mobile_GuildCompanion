using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class RaidService : IEventService<RaidModel>
    {
        private static List<RaidModel> raidEvents = new List<RaidModel>
        {
            new RaidModel
            {
                Id ="20",
                Name =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 10),
                Bosses = 12,
                BossesDown = 11
            },
            new RaidModel
            {
                Id ="21",
                Name =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 17),
                Bosses = 12,
                BossesDown = 11
            },
            new RaidModel
            {
                Id ="23",
                Name =  "Sanctum of Domination",
                Date = new DateTime(2021, 04, 24),
                Bosses = 12,
                BossesDown = 12
            }
        };

        public Task<IEnumerable<RaidModel>> GetAll()
        {
            return Task.FromResult(raidEvents.AsEnumerable());
        }

        public async Task<RaidModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(r => r.Id.Equals(id)); 
        }
    }
}
