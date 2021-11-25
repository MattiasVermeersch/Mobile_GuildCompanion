using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class CharacterRepository : Repository<Character>, ICharacterRepository
    {
        public CharacterRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Character> GetAllAsync()
        {
            return _dbContext.Characters.AsNoTracking()
                .Include(c => c.ArenaCharacters)
                    .ThenInclude(ac => ac.Arena)
                .Include(c => c.BattlegroundCharacters)
                    .ThenInclude(bc => bc.Battleground)
                .Include(c => c.DungeonCharacters)
                    .ThenInclude(dc => dc.Dungeon)
                .Include(c => c.RaidCharacters)
                    .ThenInclude(rc => rc.Raid)
                .Include(c => c.User);
        }

        public override async Task<Character> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<IEnumerable<Character>> GetByUserIdAsync(string id)
        {
            return await GetAllAsync()
                .Where(c => c.UserId.Equals(id))
                .ToListAsync();
        }
    }
}
