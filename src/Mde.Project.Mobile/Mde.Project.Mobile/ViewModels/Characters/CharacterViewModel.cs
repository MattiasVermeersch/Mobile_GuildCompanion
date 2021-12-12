using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class CharacterViewModel : ViewModelBase
    {
        private readonly ICharactersService _characterService;

        public CharacterViewModel(ICharactersService characterService)
        {
            _characterService = characterService;
            Title = "My Characters";
        }

        #region Properties
        private IEnumerable<CharacterModel> characters;
        public IEnumerable<CharacterModel> Characters
        {
            get => characters;
            set => SetProperty(ref characters, value);
        }

        private CharacterModel selectedCharacter;
        public CharacterModel SelectedCharacter
        {
            get => selectedCharacter;
            set
            {
                Shell.Current.DisplayAlert("Selected", value.Id, "OK");
                SetProperty(ref selectedCharacter, value);
            }
        }
        #endregion

        #region Commands
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetCharactersList();

            IsBusy = false;
        }

        public async Task GetCharactersList()
        {
            Characters = await _characterService.GetCharacters();
        }
        #endregion
    }
}
