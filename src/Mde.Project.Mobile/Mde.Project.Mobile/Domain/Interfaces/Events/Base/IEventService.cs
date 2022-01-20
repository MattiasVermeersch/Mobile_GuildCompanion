using Mde.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IEventService<T> : IBaseService<T>
        where T : EventModelBase
    {
        Task<T> AddCharacterToInstance(string id, CharacterModel character);
    }
}