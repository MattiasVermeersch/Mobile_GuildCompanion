using Mde.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IAllEventsService
    {
        Task<ICollection<EventListItemModel>> ListAllAsync();
        Task<int> GetNumberOfTodaysSubscribedEvents();
        Task<ICollection<EventListItemModel>> ListAllPvpAsync();
        Task<ICollection<EventListItemModel>> ListAllPveAsync();
    }
}