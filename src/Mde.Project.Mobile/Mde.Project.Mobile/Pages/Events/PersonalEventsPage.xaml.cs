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
    public partial class PersonalEventsPage : ContentPage
    {
        public PersonalEventsPage()
        {
            InitializeComponent();

            var viewModel = IoCResolver.Container.Resolve<PersonalEventsViewModel>();

            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            (BindingContext as PersonalEventsViewModel).RefreshCommand.ExecuteAsync();
        }
    }
}