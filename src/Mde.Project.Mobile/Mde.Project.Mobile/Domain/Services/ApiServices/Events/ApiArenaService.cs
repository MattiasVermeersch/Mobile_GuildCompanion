using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ApiArenaService : BaseEventService<ArenaModel>, IArenaService
    {
        public ApiArenaService()
        {
            _url = ApiConstants.ApiArenasUrl;
        }
    }
}
