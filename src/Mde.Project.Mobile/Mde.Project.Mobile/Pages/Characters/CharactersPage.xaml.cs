using Autofac;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharactersPage : ContentPage
    {
        public CharactersPage()
        {
            InitializeComponent();
            
            var viewModel = IoCResolver.Container.Resolve<CharacterViewModel>();

            BindingContext = viewModel;

            viewModel.RefreshCommand.ExecuteAsync();
        }

        protected override void OnAppearing()
        {
            (BindingContext as CharacterViewModel).RefreshCommand.ExecuteAsync();
        }
    }
}