using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Mde.Project.Mobile.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            Title = "Login";
            EmailTitle = "Email";
            PasswordTitle = "Password";

            LoginCommand = new Command(LoggingIn);
            RegisterCommand = new Command(GoToRegister); 
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
        async void LoggingIn()
        {
            if (string.IsNullOrWhiteSpace(Email) || Email.ToLower() != "mvermeersch")
                await App.Current.MainPage.DisplayAlert("Error", "Your credentials do not grant you access!", "OK");
            
            else 
                await AppShell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

        async void GoToRegister()
        {
            await AppShell.Current.GoToAsync($"{nameof(RegisterPage)}");
        }
        #endregion

    }
}
