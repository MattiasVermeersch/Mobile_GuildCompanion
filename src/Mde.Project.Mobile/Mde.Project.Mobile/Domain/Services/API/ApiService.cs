using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Domain.Services
{
    public class ApiService<T> where T : class 
    {
        static string _baseUrl = "https://localhost:5001/api/";
        static HttpClient _client;

        public ApiService(HttpClient client)
        {
            _client = client;

            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetAllAsync(string endPoint)
        {
            string url = $"{_client.BaseAddress}/{endPoint}";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> GetByIdAsync(string endPoint, string id)
        {
            string url = $"{_client.BaseAddress}/{endPoint}/{id}";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
