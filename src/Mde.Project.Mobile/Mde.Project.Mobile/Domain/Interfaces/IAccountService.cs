using Mde.Project.Mobile.Domain.Models;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IAccountService
    {
        Task<AccountModel> GetProfile();
        Task SaveProfile(AccountModel profile);
    }
}