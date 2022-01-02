using Mde.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface ICharactersService
    {
        Task<CharacterModel> GetCharacterById(string characterId);
        Task<IEnumerable<CharacterModel>> GetCharacters();
    }
}