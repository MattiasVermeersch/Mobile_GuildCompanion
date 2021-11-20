using Mde.Project.Mobile.Domain.Services;
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
    public partial class CharactersPage : ContentPage
    {
        private readonly CharactersService _characterService;
        public CharactersPage()
        {
            InitializeComponent();

            _characterService = new CharactersService();
        }

        protected override void OnAppearing()
        {
            charactersList.ItemsSource = _characterService.GetCharacters();
        }
    }
}