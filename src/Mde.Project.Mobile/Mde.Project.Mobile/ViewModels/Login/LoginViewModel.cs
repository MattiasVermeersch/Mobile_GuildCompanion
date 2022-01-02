using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mde.Project.Mobile.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IAuthService _authService;
        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;

            //Defaults for props
            Title = "Login";
            EmailTitle = "Email";
            PasswordTitle = "Password";

            //Commands
            LoginCommand = new AsyncCommand(LoggingIn);
            RegisterCommand = new AsyncCommand(GoToRegister); 
        }

        #region Properties
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        
        public string EmailTitle { get; }
        public string PasswordTitle { get; }

        public string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }
        #endregion

        #region Methods
        async Task LoggingIn()
        {
            if(!string.IsNullOrWhiteSpace(Password) || !string.IsNullOrWhiteSpace(Email))
            {
                var loginSuccess = await _authService.Login(Email, Password);

                if (!loginSuccess)
                    await App.Current.MainPage.DisplayAlert("Error", "Your Email or Password is incorrect.", "OK");
            
                else
                {
                    Email = null;
                    Password = null;
                    await AppShell.Current.GoToAsync($"//{nameof(HomePage)}");
                }
                    
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Please fill in your Email and Password.", "OK");
            }
        }

        async Task GoToRegister()
        {
            await AppShell.Current.GoToAsync($"{nameof(RegisterPage)}");
        }
        #endregion

    }
}
