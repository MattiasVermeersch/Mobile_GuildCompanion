using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AccountService
    {
        private DummyProfile dummyProfile = new DummyProfile();

        public async Task<DummyProfile> GetDummyProfile()
        {
            return await Task.FromResult(dummyProfile);
        }
    }
}
