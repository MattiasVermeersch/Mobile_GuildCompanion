using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AccountService
    {
        private static DummyProfile dummyProfile = new DummyProfile
        {
            Name = "John Doe",
            Email = "johnDoe@mail.com",
            DiscordID = "JohnDiscord#3001"
        };

        public async Task<DummyProfile> GetProfile()
        {
            return await Task.FromResult(dummyProfile);
        }

        public async Task SaveProfile(DummyProfile profile)
        {
            dummyProfile = await Task.FromResult(profile);
        }
    }
}
