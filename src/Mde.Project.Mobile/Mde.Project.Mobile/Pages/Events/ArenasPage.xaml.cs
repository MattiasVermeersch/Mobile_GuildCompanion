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
    public partial class ArenasPage : ContentPage
    {
        public ArenasPage()
        {
            InitializeComponent();

            //Resolve ArenaViewModel through the IoCResolver Container
            var viewModel = IoCResolver.Container.Resolve<ArenaViewModel>();

            //Bind the viewmodel to the Context of the page
            //note: this makes the <ContentPage.BindingContext> tag in the page obsolete, but removal is necessary when injecting into ctor
            BindingContext = viewModel;

            //Finally the Initialize method must be triggered when loading the page through the viewmodel object
            viewModel.RefreshCommand.ExecuteAsync();
        }
    }
}