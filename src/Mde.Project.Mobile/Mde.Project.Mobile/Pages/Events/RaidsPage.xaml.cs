using Autofac;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RaidsPage : ContentPage
    {
        public RaidsPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<RaidViewModel>();

            BindingContext = viewModel;

            viewModel.RefreshCommand.ExecuteAsync();
        }
    }
}