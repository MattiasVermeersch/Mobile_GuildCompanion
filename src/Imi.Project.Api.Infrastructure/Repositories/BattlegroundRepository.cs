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
    public class BattlegroundRepository : Repository<Battleground>, IBattlegroundRepository
    {
        public BattlegroundRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Battleground> GetAllAsync()
        {
            return _dbContext.Battlegrounds.AsNoTracking()
                .Include(b => b.BattlegroundCharacters)
                    .ThenInclude(bg => bg.Character);
        }

        public override async Task<Battleground> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(b => b.Id.Equals(id));
        }

        public async Task<IEnumerable<Battleground>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(b => b.BattlegroundCharacters.Any(bg => bg.CharacterId.Equals(id)))
                .ToListAsync();
        }

        public async Task<Battleground> AddCharacterAsync(Guid id, Character character)
        {
            var battleground = _dbContext.Battlegrounds.Find(id);
            var characterToAdd = _dbContext.Characters.Find(id);

            battleground.BattlegroundCharacters = new List<BattlegroundCharacter>();

            battleground.BattlegroundCharacters.Add(new BattlegroundCharacter
            {
                Battleground = battleground,
                Character = characterToAdd
            });

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(id);
        }

        public async Task<Battleground> DeleteCharacterAsync(Guid battleGroundId, Guid characterId)
        {
            var battleground = _dbContext.Battlegrounds.Find(battleGroundId);

            var battleGroundCharacters = _dbContext.BattlegroundCharacters.ToList();
            var charToRemove = battleGroundCharacters
                .Where(bc => bc.BattlegroundId.Equals(battleGroundId))
                .Where(bc => bc.CharacterId.Equals(characterId))
                .SingleOrDefault();

            _dbContext.BattlegroundCharacters.Remove(charToRemove);

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(battleGroundId);
        }
    }
}
