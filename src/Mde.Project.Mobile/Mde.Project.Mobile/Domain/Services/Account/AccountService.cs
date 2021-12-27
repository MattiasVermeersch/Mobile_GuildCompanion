using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AccountService : IAccountService
    {
        protected static string fullPath = Path.Combine(FileSystem.AppDataDirectory, AppConstants.AccountSettingsFileName);

        private static AccountModel dummyAccount = new AccountModel
        {
            UserName = "ageydon0@marriott.com",
            Email = "ageydon0@marriott.com",
            City = "Brugge",
            BirthDate = new DateTime(1993, 02, 05),
            Address = "6 Gale Plaza",
            FullName = "Aldwin Geydon",
            BattleNetId = "Alderaan#2208",
            AvatarPath = "default_avatar_icon.png"
        };

        public async Task<AccountModel> GetProfile()
        {
            //check if account settings file exists
            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                var accountSettings = JsonConvert.DeserializeObject<AccountModel>(json);
                return await Task.FromResult(accountSettings);
                
            }
            else
            {
                return await Task.FromResult(dummyAccount);
            }
           
        }

        public Task<bool> SaveProfile(AccountModel account)
        {
            var json = JsonConvert.SerializeObject(account, 
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
            
            File.WriteAllText(fullPath, json);

            return Task.FromResult(true);
        }
    }
}
