using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        protected readonly IAuthService _authService;
        public ShellViewModel(IAuthService authService)
        {
            _authService = authService;

            //Commands
            LogoutCommand = new AsyncCommand(Logout);
        }

        public ICommand LogoutCommand { get; }

        async Task Logout()
        {
           _authService.Logout();
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
