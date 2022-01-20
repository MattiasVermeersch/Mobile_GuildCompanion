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
    public class BaseEventService<T> : BaseService<T>, IEventService<T>
        where T : EventModelBase
    {
        public async Task<T> AddCharacterToInstance(string id, CharacterModel character)
        {
            var outEntity = await ApiClient.PutAsync<T>($"{_url}/{id}/{ApiConstants.Character}", character);
            return outEntity;
        }
    }
}
