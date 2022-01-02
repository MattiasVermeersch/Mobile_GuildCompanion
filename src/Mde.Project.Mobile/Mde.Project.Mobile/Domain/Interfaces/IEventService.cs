using Mde.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IEventService<T>
        where T : EventModelBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
    }
}