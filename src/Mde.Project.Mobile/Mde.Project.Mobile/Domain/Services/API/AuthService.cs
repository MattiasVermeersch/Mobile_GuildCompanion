using Mde.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Mde.Project.Mobile.Domain.Models;
using Xamarin.Essentials;
using Mde.Project.Mobile.Domain.Constants;

namespace Mde.Project.Mobile.Domain.Services.API
{
    public class AuthService : IAuthService
    {
        private const string _baseUrl = "https://localhost:5001/api/auth";
        private readonly HttpClient client;

        public AuthService()
        {
            client = new HttpClient(GetClientHandler());
        }

        public async Task<bool> Login(string username, string password)
        {
            try
            {
                var loginRequest = new
                {
                    username,
                    password
                };

                var response = await client.PostAsJsonAsync(_baseUrl, loginRequest);
                var json = await response.Content.ReadAsStringAsync();

                var authResult = JsonConvert.DeserializeObject<LoginModel>(json);

                if (authResult.IsSignedIn) 
                    await SecureStorage.SetAsync(ApiConstants.TokeyKey, authResult.Token);

                return authResult.IsSignedIn;
            }
            catch
            {
                throw;
            }
            
        }

        public Task<string> GetToken()
        {
            throw new NotImplementedException();
        }
        
        public HttpMessageHandler GetClientHandler()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAuthenticated()
        {
            throw new NotImplementedException();
        }
    }
}
