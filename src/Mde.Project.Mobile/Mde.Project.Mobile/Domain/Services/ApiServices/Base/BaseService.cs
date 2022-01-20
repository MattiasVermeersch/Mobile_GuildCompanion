using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class BaseService<T> : IBaseService<T>
        where T : class
    {
        protected string _url;

        public BaseService()
        {
            _url = ApiConstants.ApiBaseUrl;
        }

        public async Task<T> AddAsync(T entity)
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
    }
}
