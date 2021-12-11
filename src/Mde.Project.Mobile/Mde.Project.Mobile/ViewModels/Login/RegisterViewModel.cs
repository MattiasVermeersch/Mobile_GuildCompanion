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
        public RegisterViewModel()
        {
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
        public string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

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

        public string confirmPassword;
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
            if (string.IsNullOrWhiteSpace(Name) ||
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
                await App.Current.MainPage.DisplayAlert("Alert", "You have successfully registered! Have a look around.", "OK");
                await AppShell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
        #endregion
    }
}
