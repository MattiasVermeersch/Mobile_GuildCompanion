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
    public class RegisterViewModel : ViewModelBase
    {
        protected readonly IAuthService _authService;
        public RegisterViewModel(IAuthService authService)
        {
            _authService = authService;
            Title = "Register here";

            //Commands
            SubmitCommand = new AsyncCommand(SubmitRegistration);
            CancelCommand = new AsyncCommand(CancelRegistration);
        }

        #region Properties

        #region Commands
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        #endregion

        #region Entries
        string firstName;
        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        string lastName;
        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        string city;
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        string address;
        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => SetProperty(ref birthDate, value);
        }

        string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        string confirmPassword;
        public string ConfirmPassword 
        { 
            get => confirmPassword; 
            set => SetProperty( ref confirmPassword, value);
        }

        #endregion

        #endregion

        #region Methods
        async Task CancelRegistration()
        {
            await AppShell.Current.GoToAsync($"..");
        }

        async Task SubmitRegistration()
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("Error", "All entries need to be filled in!", "OK");
                return;
            }
                    
            if (Password != ConfirmPassword) 
                await App.Current.MainPage.DisplayAlert("Error", "The passwords need to match!", "OK");

            else
            {
                //Save the information through API call here then Login and navigate to HomePage
                await _authService.RegisterNewUser(FirstName, LastName, Email, City, Address, BirthDate, Password, ConfirmPassword);

                await App.Current.MainPage.DisplayAlert("Alert", "You have successfully registered!", "OK");
                await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
        }
        #endregion
    }
}
