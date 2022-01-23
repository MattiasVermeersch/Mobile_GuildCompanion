using Autofac;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DungeonsPage : ContentPage
    {
        public DungeonsPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<DungeonViewModel>();

            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            (BindingContext as DungeonViewModel).RefreshCommand.ExecuteAsync();
        }
    }
}