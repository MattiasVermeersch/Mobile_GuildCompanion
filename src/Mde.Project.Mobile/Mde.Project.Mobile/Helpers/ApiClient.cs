using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Helpers
{
    public class ApiClient
    {
        public static HttpClientHandler GetClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();
#if DEBUG
            //allow connecting to untrusted certificates when running a DEBUG assembly
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
#endif
            return httpClientHandler;
        }
        public static async Task<T> GetAsync<T>(string url)
        {
            using(HttpClient client = new HttpClient(GetClientHandler()))
            {
                string response = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        public static async Task<T> PostAsync<T>(string url, object data)
        {
            using(HttpClient client = new HttpClient(GetClientHandler()))
            {
                var response = await client.PostAsJsonAsync(url, data);
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        public static async Task<T> PutAsync<T>(string url, object data)
        {
            using (HttpClient client = new HttpClient(GetClientHandler()))
            {
                var response = await client.PutAsJsonAsync(url, data);
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        public static async Task<T> DeleteAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient(GetClientHandler()))
            {
                var response = await client.DeleteAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }
    }
}
