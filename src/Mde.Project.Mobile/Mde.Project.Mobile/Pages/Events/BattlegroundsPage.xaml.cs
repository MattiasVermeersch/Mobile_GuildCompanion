using Autofac;
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
    public partial class BattlegroundsPage : ContentPage
    {
        public BattlegroundsPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<BattlegroundViewModel>();

            BindingContext = viewModel;

            viewModel.RefreshCommand.ExecuteAsync();
        }
    }
}