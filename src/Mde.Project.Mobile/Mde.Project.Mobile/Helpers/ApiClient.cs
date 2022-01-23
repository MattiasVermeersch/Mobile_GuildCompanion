using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

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
        public static async Task<T> GetAsync<T>(string url, bool useToken = true)
        {
            using(HttpClient client = new HttpClient(GetClientHandler()))
            {
                if(useToken)
                {
                    await SetJWTHeaderForClient(client);
                }

                string response = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        public static async Task<T> PostAsync<T>(string url, object data, bool useToken = true)
        {
            using(HttpClient client = new HttpClient(GetClientHandler()))
            {
                if (useToken)
                {
                    await SetJWTHeaderForClient(client);
                }

                var response = await client.PostAsync(url, GetDataAsStringContent(data));
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        public static async Task<T> PutAsync<T>(string url, object data, bool useToken = true)
        {
            using (HttpClient client = new HttpClient(GetClientHandler()))
            {
                if (useToken)
                {
                    await SetJWTHeaderForClient(client);
                }

                var response = await client.PutAsync(url, GetDataAsStringContent(data));
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        public static async Task<T> DeleteAsync<T>(string url, bool useToken = true)
        {
            using (HttpClient client = new HttpClient(GetClientHandler()))
            {
                if (useToken)
                {
                    await SetJWTHeaderForClient(client);
                }

                var response = await client.DeleteAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(json);

                return result;
            }
        }

        private static async Task<string> GetToken()
        {
            return await SecureStorage.GetAsync(ApiConstants.TokenKey);
        }

        private static async Task SetJWTHeaderForClient(HttpClient client)
        {
            var authHeader = new AuthenticationHeaderValue("Bearer", await GetToken());
            client.DefaultRequestHeaders.Authorization = authHeader;
        }

        private static StringContent GetDataAsStringContent(object data)
        {
            return new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        }
    }
}
