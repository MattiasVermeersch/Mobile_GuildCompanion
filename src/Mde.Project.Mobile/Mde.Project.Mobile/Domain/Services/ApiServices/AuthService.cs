using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Helpers;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Mde.Project.Mobile.Domain.Services
{
    public class AuthService : IAuthService
    {
        protected TokenReader _tokenReader = new TokenReader();
        protected IAccountService _accountService;

        public AuthService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<bool> Login(string email, string password)
        {
            try
            {
                var loginRequest = new
                {
                    email,
                    password
                };

                var result = await ApiClient.PostAsync<LoginModel>(ApiConstants.ApiLoginUrl, loginRequest, false);

                if (result.SignInSucceeded)
                {
                    await SecureStorage.SetAsync(ApiConstants.TokenKey, result.Token);
                    await SecureStorage.SetAsync(ApiConstants.UserKey, result.UserId);
                }
                    

                return result.SignInSucceeded;
            }
            catch
            {
                throw;
            }
        }

        public async Task<string> GetToken()
        {
            return await SecureStorage.GetAsync(ApiConstants.TokenKey);
        }

        public async Task<bool> IsAuthenticated()
        {
            var token = await GetToken();
            return !string.IsNullOrWhiteSpace(token) &&
                !_tokenReader.IsExpired(token);
        }

        public void Logout()
        {
            SecureStorage.RemoveAll();
        }

        public async Task<bool> RegisterNewUser(string firstName, string lastName,
            string email, string city, string address, DateTime birthDate, 
            string password, string confirmPassword)
        {
            try
            {
                var registerRequest = new
                {
                    firstName,
                    lastName,
                    email,
                    password,
                    confirmPassword,
                    city,
                    address,
                    birthDate
                };

                var result = await ApiClient.PostAsync<RegisterModel>(ApiConstants.ApiRegisterUrl, registerRequest, false);

                if (result.Error != null)
                {
                    //save the registered user's account info
                    var accountModel = new AccountModel
                    {
                        FullName = $"{firstName} {lastName}",
                        Email = email,
                        City = city,
                        Address = address,
                        BirthDate = birthDate,
                        BattleNetId = null
                    };

                    await _accountService.SaveProfile(accountModel);
                    return true;
                }
                else return false;
            }
            catch
            {
                throw;
            }
        }
    }
}
