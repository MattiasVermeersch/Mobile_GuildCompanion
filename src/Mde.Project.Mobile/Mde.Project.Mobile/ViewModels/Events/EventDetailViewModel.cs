using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Mde.Project.Mobile.ViewModels
{
    public class EventDetailViewModel : ViewModelBase
    {
        private readonly IArenaService _arenaService;
        private readonly IBattlegroundService _battlegroundService;
        private readonly IDungeonService _dungeonService;
        private readonly IRaidService _raidService;
        private readonly ICharactersService _characterService;

        public EventDetailViewModel(IArenaService arenaService,
            IBattlegroundService battlegroundService, IDungeonService dungeonService,
            IRaidService raidService, ICharactersService characterService)
        {
            _arenaService = arenaService;
            _battlegroundService = battlegroundService;
            _dungeonService = dungeonService;
            _raidService = raidService;
            _characterService = characterService;

            Title = "Detailed event view";

            GetDetailCommand = new AsyncCommand<EventParameters>(GetDataByIdAndType);
            SelectedCommand = new AsyncCommand(Selected);
            UnSubscribeCommand = new AsyncCommand(UnsubscribeCharacter);
        }

        #region Properties
        private bool isArena;
        public bool IsArena
        {
            get => isArena;
            set => SetProperty(ref isArena, value);
        }

        private bool isBattleground;
        public bool IsBattleground
        {
            get => isBattleground;
            set => SetProperty(ref isBattleground, value);
        }

        private bool isDungeon;
        public bool IsDungeon
        {
            get => isDungeon;
            set => SetProperty(ref isDungeon, value);
        }

        private bool isRaid;
        public bool IsRaid
        {
            get => isRaid;
            set => SetProperty(ref isRaid, value);
        }

        public string Id { get; set; }
        public string CharacterId { get; set; }

        private string pageTitle;
        public string PageTitle
        {
            get => pageTitle;
            set => SetProperty(ref pageTitle, value);
        }

        private string instanceName;
        public string InstanceName
        {
            get => instanceName;
            set => SetProperty(ref instanceName, value);
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        private string subscribedCharacter;
        public string SubscribedCharacter
        {
            get => subscribedCharacter;
            set => SetProperty(ref subscribedCharacter, value);
        }

        //PvP specific props
        private string mode;
        public string Mode
        {
            get => mode;
            set => SetProperty(ref mode, value);
        }

        //PvE specific props
        private string difficulty;
        public string Difficulty
        {
            get => difficulty;
            set => SetProperty(ref difficulty, value);
        }

        private int? key;
        public int? Key
        {
            get => key;
            set => SetProperty(ref key, value);
        }

        private int? bosses;
        public int? Bosses
        {
            get => bosses;
            set => SetProperty(ref bosses, value);
        }

        private bool canSubscribe;
        public bool CanSubscribe
        {
            get => canSubscribe;
            set => SetProperty(ref canSubscribe, value);
        }

        private IEnumerable<CharacterModel> playerCharacters;
        public IEnumerable<CharacterModel> PlayerCharacters
        {
            get => playerCharacters;
            set => SetProperty(ref playerCharacters, value);
        }

        private CharacterModel selectedCharacter;
        public CharacterModel SelectedCharacter
        {
            get => selectedCharacter;
            set => SetProperty(ref selectedCharacter, value);
        }

        private EventParameters Parameters { get; set; }
        #endregion

        #region Commands
        public AsyncCommand<EventParameters> GetDetailCommand { get; }
        public AsyncCommand SelectedCommand { get; }
        public AsyncCommand UnSubscribeCommand { get; }
        #endregion

        #region Methods
        public async Task GetDataByIdAndType(EventParameters parameters)
        {
            //Set all bools to false
            IsArena = false;
            IsBattleground = false;
            IsDungeon = false;
            IsRaid = false;
            Parameters = parameters;

            if (parameters.Type.Equals("arena"))
            {
                var currentEvent = await _arenaService.GetByIdAsync(parameters.Id);
                IsArena = true;
                PageTitle = "Arena Details";

                var model = new GlobalEventModel
                {
                    Id = currentEvent.Id,
                    InstanceName = $"{currentEvent.Mode}v{currentEvent.Mode}",
                    Date = currentEvent.Date,
                    Characters = currentEvent.Characters,
                    Mode = currentEvent.Mode,
                };

                await SetProperties(model);
                await GetSubscribedCharacter(model);
            }

            if (parameters.Type.Equals("battleground"))
            {
                var currentEvent = await _battlegroundService.GetByIdAsync(parameters.Id);
                IsBattleground = true;
                PageTitle = "Battleground Details";

                var model = new GlobalEventModel
                {
                    Id = currentEvent.Id,
                    InstanceName = currentEvent.InstanceName,
                    Date = currentEvent.Date,
                    Characters = currentEvent.Characters
                };

                await SetProperties(model);
                await GetSubscribedCharacter(model);
            }

            if (parameters.Type.Equals("dungeon"))
            {
                var currentEvent = await _dungeonService.GetByIdAsync(parameters.Id);
                IsDungeon = true;
                PageTitle = "Dungeon Details";

                var model = new GlobalEventModel
                {
                    Id = currentEvent.Id,
                    InstanceName = currentEvent.InstanceName,
                    Date = currentEvent.Date,
                    Characters = currentEvent.Characters,
                    Difficulty = currentEvent.Difficulty,
                    Key = currentEvent.Key,
                };

                await SetProperties(model);
                await GetSubscribedCharacter(model);
            }

            if (parameters.Type.Equals("raid"))
            {
                var currentEvent = await _raidService.GetByIdAsync(parameters.Id);
                IsRaid = true;
                PageTitle = "Raid Details";

                var model = new GlobalEventModel
                {
                    Id = currentEvent.Id,
                    InstanceName = currentEvent.InstanceName,
                    Date = currentEvent.Date,
                    Characters = currentEvent.Characters,
                    Difficulty = currentEvent.Difficulty
                };

                await SetProperties(model);
                await GetSubscribedCharacter(model);
            }
        }

        private async Task SetProperties(GlobalEventModel model)
        {
            if(model != null)
            {
                Id = model.Id;
                InstanceName = model.InstanceName;
                Date = model.Date;
                Mode = model.Mode;
                Difficulty = model.Difficulty;
                Key = model.Key;
            }
            await Task.CompletedTask;
        }

        private async Task GetSubscribedCharacter(GlobalEventModel model)
        {
            CanSubscribe = true;
            var userId = await SecureStorage.GetAsync(ApiConstants.UserKey);

            foreach (var character in model.Characters)
            {
                if (character.UserId.Equals(userId))
                {
                    CanSubscribe = false;
                    SubscribedCharacter = $"You have subscribed with {character.Name}";
                    CharacterId = character.Id;
                    break;
                }
            }

            if (CanSubscribe) PlayerCharacters = await _characterService.GetCharactersByUserIdAsync();
            
        }

        private async Task Selected()
        {
            var character = SelectedCharacter;

            if (character is null) return;

            if (IsArena) await _arenaService.AddCharacterToInstance(Id, character);
            if (IsBattleground) await _battlegroundService.AddCharacterToInstance(Id, character);
            if (IsDungeon) await _dungeonService.AddCharacterToInstance(Id, character);
            if (IsRaid) await _raidService.AddCharacterToInstance(Id, character);

            await GetDataByIdAndType(Parameters);
        }

        private async Task UnsubscribeCharacter()
        {
            if (IsArena) await _arenaService.RemoveCharacterFromInstance(Id, CharacterId);
            if (IsBattleground) await _battlegroundService.RemoveCharacterFromInstance(Id, CharacterId);
            if (IsDungeon) await _dungeonService.RemoveCharacterFromInstance(Id, CharacterId);
            if (IsRaid) await _raidService.RemoveCharacterFromInstance(Id, CharacterId);

            await GetDataByIdAndType(Parameters);
        }

        #endregion
    }
}
