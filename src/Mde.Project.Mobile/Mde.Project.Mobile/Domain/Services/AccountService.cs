using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AccountService : IAccountService
    {
        private static AccountModel dummyAccount = new AccountModel
        {
            UserName = "ageydon0@marriott.com",
            Email = "ageydon0@marriott.com",
            City = "Brugge",
            BirthDate = new DateTime(1993, 02, 05),
            Address = "6 Gale Plaza",
            FullName = "Aldwin Geydon",
            BattleNetId = "Alderaan#2208"
        };

        public async Task<AccountModel> GetProfile()
        {
            return await Task.FromResult(dummyAccount);
        }

        public async Task SaveProfile(AccountModel profile)
        {
            dummyAccount = await Task.FromResult(profile);
        }
    }
}
