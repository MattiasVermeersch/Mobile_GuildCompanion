using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ApiRaidService : BaseEventService<RaidModel>, IRaidService
    {
        public ApiRaidService()
        {
            _url = ApiConstants.ApiRaidsUrl;
        }
    }
}
