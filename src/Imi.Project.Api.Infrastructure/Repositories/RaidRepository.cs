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
    public class RaidRepository : Repository<Raid>, IRaidRepository
    {
        public RaidRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Raid> GetAllAsync()
        {
            return _dbContext.Raids.AsNoTracking()
                .Include(r => r.RaidCharacters)
                    .ThenInclude(rc => rc.Character);
        }

        public override async Task<Raid> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(r => r.Id.Equals(id));
        }

        public async Task<IEnumerable<Raid>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(r => r.RaidCharacters.Any(rc => rc.CharacterId.Equals(id)))
                .ToListAsync();
        }

        public async Task<Raid> AddCharacterAsync(Guid id, Character character)
        {
            var raid = _dbContext.Raids.Find(id);
            var characterToAdd = _dbContext.Characters.Find(character.Id);

            raid.RaidCharacters = new List<RaidCharacter>();

            raid.RaidCharacters.Add(new RaidCharacter
            {
                Raid = raid,
                Character = characterToAdd
            });

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(id);
        }

        public async Task<Raid> DeleteCharacterAsync(Guid raidId, Guid characterId)
        {
            var raid = _dbContext.Raids.Find(raidId);

            var raidCharacters = _dbContext.RaidCharacters.ToList();
            var charToRemove = raidCharacters
                .Where(dc => dc.RaidId.Equals(raidId))
                .Where(dc => dc.CharacterId.Equals(characterId))
                .SingleOrDefault();

            _dbContext.RaidCharacters.Remove(charToRemove);

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(raidId);
        }
    }
}
