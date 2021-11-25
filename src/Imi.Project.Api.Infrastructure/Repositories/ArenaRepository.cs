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
    public class ArenaRepository : Repository<Arena>, IArenaRepository
    {
        public ArenaRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Arena> GetAllAsync()
        {
            return _dbContext.Arenas.AsNoTracking()
                .Include(a => a.ArenaCharacters)
                    .ThenInclude(ac => ac.Character);
        }

        public override async Task<Arena> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }

        public async Task<IEnumerable<Arena>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(a => a.ArenaCharacters.Any(ac => ac.CharacterId.Equals(id)))
                .ToListAsync();
        }

        public async Task<Arena> AddCharacterAsync(Guid id, Character character)
        {
            var arena = _dbContext.Arenas.Find(id);
            var charToAdd = _dbContext.Characters.Find(character.Id);

            arena.ArenaCharacters = new List<ArenaCharacter>();

            arena.ArenaCharacters.Add(new ArenaCharacter
            {
                Arena = arena,
                Character = charToAdd
            });

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(id);
        }

        public async Task<Arena> DeleteCharacterAsync(Guid arenaId, Guid characterId)
        {
            var arena = _dbContext.Arenas.Find(arenaId);

            var arenaCharacters = _dbContext.ArenaCharacters.ToList();
            var charToRemove = arenaCharacters
                .Where(ac => ac.ArenaId.Equals(arenaId))
                .Where(ac => ac.CharacterId.Equals(characterId))
                .SingleOrDefault();

            _dbContext.ArenaCharacters.Remove(charToRemove);

            await _dbContext.SaveChangesAsync();

            return await GetByIdAsync(arenaId);
        }
    }
}
