using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class BattlegroundService : IEventService<BattlegroundModel>
    {
        private static List<BattlegroundModel> battlegroundEvents = new List<BattlegroundModel>
        {
            new BattlegroundModel
            {
                Id = "51",
                Name = "Warsong Gulch",
                Date = new DateTime(2021, 06, 17),
                IsWon = true
            },
            new BattlegroundModel
            {
                Id = "52",
                Name = "Eye of the Storm",
                Date = new DateTime(2021, 06, 17)
            },
            new BattlegroundModel
            {
                Id = "53",
                Name = "Battle for Gilneas",
                Date = new DateTime(2021, 06, 17)
            },
            new BattlegroundModel
            {
                Id = "54",
                Name = "Temple of Kotmogu",
                Date = new DateTime(2021, 06, 17)
            }
        };

        public Task<IEnumerable<BattlegroundModel>> GetAll()
        {
            return Task.FromResult(battlegroundEvents.AsEnumerable());
        }

        public async Task<BattlegroundModel> GetById(string id)
        {
            return (await GetAll()).FirstOrDefault(b => b.Id.Equals(id));
        }
    }
}
