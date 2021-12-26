using Autofac;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<RegisterViewModel>();

            BindingContext = viewModel;

            viewModel.RefreshCommand.ExecuteAsync();
        }
    }
}