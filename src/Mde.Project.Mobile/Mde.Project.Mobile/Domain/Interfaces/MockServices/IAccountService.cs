using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IAccountService
    {
        Task<AccountModel> GetProfile();
        Task<bool> SaveProfile(AccountModel profile);
    }
}
