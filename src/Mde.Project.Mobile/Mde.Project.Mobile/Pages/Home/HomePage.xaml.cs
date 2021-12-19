using Autofac;
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
    public partial class HomePage : ContentPage
    {       
        public HomePage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<HomeViewModel>();

            BindingContext = viewModel;

            viewModel.RefreshCommand.ExecuteAsync();
        }
    }
}