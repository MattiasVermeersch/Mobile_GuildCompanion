using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Mde.Project.Mobile.Domain.Services
{
    public class BaseService<T> : IBaseService<T>
        where T : class
    {
        protected string _url;
        protected string _userId;
        public BaseService()
        {
            _url = ApiConstants.ApiBaseUrl;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            var outEntity = await ApiClient.PostAsync<T>(_url, entity);
            return outEntity;
        }

        public async Task<T> DeleteAsync(string id)
        {
            var outEntity = await ApiClient.DeleteAsync<T>($"{_url}/{id}");
            return outEntity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var outEntity = await ApiClient.GetAsync<IEnumerable<T>>(_url);
            return outEntity;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var outEntity = await ApiClient.GetAsync<T>($"{_url}/{id}");
            return outEntity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var outEntity = await ApiClient.PutAsync<T>(_url, entity);
            return outEntity;
        }

        public async Task GetStorageUserId()
        {
            _userId = await SecureStorage.GetAsync(ApiConstants.UserKey);
        }
    }
}
