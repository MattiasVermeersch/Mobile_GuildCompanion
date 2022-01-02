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
    public class MockAccountService : IAccountService
    {
        protected static string accountSettingsPath = Path.Combine(FileSystem.AppDataDirectory, AppConstants.AccountSettingsFileName);
        protected static string profilePicPath = Path.Combine(FileSystem.AppDataDirectory, AppConstants.ProfilePicFileName);
        protected bool IsSuccess;

        private static AccountModel dummyAccount = new AccountModel
        {
            Email = "ageydon0@marriott.com",
            City = "Brugge",
            BirthDate = new DateTime(1993, 02, 05),
            Address = "6 Gale Plaza",
            FullName = "Aldwin Geydon",
            BattleNetId = "Alderaan#2208"
        };

        public async Task<AccountModel> GetProfile()
        {
            //check if account settings file exists
            if (File.Exists(accountSettingsPath))
            {
                string json = File.ReadAllText(accountSettingsPath);
                var accountSettings = JsonConvert.DeserializeObject<AccountModel>(json);
                return await Task.FromResult(accountSettings);
            }
            else
            {
                return await Task.FromResult(dummyAccount);
            }
        }
        public Task<string> GetProfilePicture()
        {
            if(File.Exists(profilePicPath))
            {
                string path = File.ReadAllText(profilePicPath);
                if(string.IsNullOrEmpty(path))
                {
                    return Task.FromResult("default_avatar_icon.png");
                }
                else return Task.FromResult(path);
            }
            else
            {
                return Task.FromResult("default_avatar_icon.png");
            }
        }

        public Task<bool> SaveProfilePicture(string photofile)
        {
            File.WriteAllText(profilePicPath, photofile);

            IsSuccess = File.Exists(profilePicPath);

            return Task.FromResult(IsSuccess);
        }

        public Task<bool> SaveProfile(AccountModel account)
        {
            var json = JsonConvert.SerializeObject(account, 
                new JsonSerializerSettings()
                { 
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            
            File.WriteAllText(accountSettingsPath, json);

            IsSuccess = File.Exists(accountSettingsPath);

            return Task.FromResult(IsSuccess);
        }
    }
}
