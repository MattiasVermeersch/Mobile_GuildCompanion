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
    [QueryProperty(nameof(CharacterId), nameof(CharacterId))]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterDetailPage : ContentPage
    {
        public string CharacterId { get; set; }
        public CharacterDetailPage()
        {
            InitializeComponent();
            var viewModel = IoCResolver.Container.Resolve<CharacterDetailViewModel>();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            (BindingContext as CharacterDetailViewModel).GetDetailCommand.ExecuteAsync(CharacterId);
        }
    }
}