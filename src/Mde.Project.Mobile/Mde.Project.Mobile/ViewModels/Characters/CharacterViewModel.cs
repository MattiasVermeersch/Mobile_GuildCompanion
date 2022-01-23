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
        public AsyncCommand<object> SelectedCommand { get; }
        public AsyncCommand AddCommand { get; }

        public CharacterViewModel(ICharactersService characterService)
        {
            _characterService = characterService;
            Title = "My Characters";

            SelectedCommand = new AsyncCommand<object>(Selected);
            AddCommand = new AsyncCommand(ToCreatePage);
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
            set => SetProperty(ref selectedCharacter, value);
        }

        private bool hasData;
        public bool HasData
        {
            get => hasData;
            set => SetProperty(ref hasData, value);
        }

        private bool hasNoData;
        public bool HasNoData
        {
            get => hasNoData;
            set => SetProperty(ref hasNoData, value);
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
            var characters = await _characterService.GetCharactersByUserIdAsync();
            if(characters == null)
            {
                HasNoData = true;
                HasData = false;
            }
            else
            {
                Characters = characters;
                HasNoData = false;
                HasData = true;
            }
        }

        private async Task Selected(object args)
        {
            var character = args as CharacterModel;

            if (character is null) return;

            var route = $"{nameof(CharacterDetailPage)}?CharacterId={character.Id}";
            await Shell.Current.GoToAsync(route);
        }

        private async Task ToCreatePage()
        {
            //do not pass a CharacterId to the page, this will set page to create mode
            var route = $"{nameof(CharacterDetailPage)}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
