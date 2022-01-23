using Autofac;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Services;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<AccountViewModel>();

            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            (BindingContext as AccountViewModel).RefreshCommand.ExecuteAsync();
        }
    }
}