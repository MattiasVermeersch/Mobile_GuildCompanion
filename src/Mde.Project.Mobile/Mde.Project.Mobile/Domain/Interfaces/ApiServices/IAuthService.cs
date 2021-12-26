﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<bool> Login(string username, string password);
        Task<string> GetToken();
        Task<bool> IsAuthenticated();
    }
}
