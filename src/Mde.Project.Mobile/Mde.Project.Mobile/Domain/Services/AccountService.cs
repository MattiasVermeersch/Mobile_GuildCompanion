using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AccountService
    {
        private DummyProfile dummyProfile = new DummyProfile();

        public DummyProfile GetDummyProfile()
        {
            return dummyProfile;
        }
    }
}
