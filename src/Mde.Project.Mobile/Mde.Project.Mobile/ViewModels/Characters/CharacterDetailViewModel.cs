using FluentValidation;
using Mde.Project.Mobile.Domain.Constants;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Validators;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class CharacterDetailViewModel : ViewModelBase
    {
        private readonly ICharactersService _characterService;
        private CharacterModel currentCharacter;
        private IValidator characterValidator;

        public CharacterDetailViewModel(ICharactersService characterService)
        {
            _characterService = characterService;
            characterValidator = new CharacterValidator();

            GetDetailCommand = new AsyncCommand<string>(GetDataById);
            SaveCommand = new AsyncCommand(OnSave);
            DeleteCommand = new AsyncCommand(OnDelete);
            EditCommand = new AsyncCommand(OnEdit);
            CancelCommand = new AsyncCommand(OnCancel);
            BackCommand = new AsyncCommand(OnBack);
        }

        #region Properties
        private string pageTitle;
        public string PageTitle
        {
            get => pageTitle;
            set => SetProperty(ref pageTitle, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string selectedClass;
        public string SelectedClass
        {
            get => selectedClass;
            set => SetProperty(ref selectedClass, value);
        }

        private IEnumerable<string> classes;
        public IEnumerable<string> Classes
        {
            get => classes;
            set => SetProperty(ref classes, value);
        }

        private string selectedRole;
        public string SelectedRole
        {
            get => selectedRole;
            set => SetProperty(ref selectedRole, value);
        }

        private IEnumerable<string> roles;
        public IEnumerable<string> Roles
        {
            get => roles;
            set => SetProperty(ref roles, value);
        }

        private int level;
        public int Level
        {
            get => level;
            set => SetProperty(ref level, value);
        }

        private int itemLevel;
        public int ItemLevel
        {
            get => itemLevel;
            set => SetProperty(ref itemLevel, value);
        }

        private int arenaRating;
        public int ArenaRating
        {
            get => arenaRating;
            set => SetProperty(ref arenaRating, value);
        }

        private int battlegroundRating;
        public int BattlegroundRating
        {
            get => battlegroundRating;
            set => SetProperty(ref battlegroundRating, value);
        }

        private bool isRead;
        public bool IsRead
        {
            get => isRead;
            set => SetProperty(ref isRead, value);
        }

        private bool isEdit;
        public bool IsEdit
        {
            get => isEdit;
            set => SetProperty(ref isEdit, value);
        }

        private bool isCreateForm;
        public bool IsCreateForm
        {
            get => isCreateForm;
            set => SetProperty(ref isCreateForm, value);
        }

        private bool isEditForm;
        public bool IsEditForm 
        {
            get => isEditForm;
            set => SetProperty(ref isEditForm, value);
        }
        #endregion

        #region Error Properties
        private string nameError;
        public string NameError
        {
            get => nameError;
            set => SetProperty(ref nameError, value);
        }
        private bool nameErrorIsVisible;
        public bool NameErrorIsVisible 
        {
            get => nameErrorIsVisible;
            set => SetProperty(ref nameErrorIsVisible, value);
        }

        private string classError;
        public string ClassError
        {
            get => classError;
            set => SetProperty(ref classError, value);
        }
        private bool classErrorIsVisible;
        public bool ClassErrorIsVisible
        {
            get => classErrorIsVisible;
            set => SetProperty(ref classErrorIsVisible, value);
        }

        private string roleError;
        public string RoleError
        {
            get => roleError;
            set => SetProperty(ref roleError, value);
        }
        private bool roleErrorIsVisible;
        public bool RoleErrorIsVisible
        {
            get => roleErrorIsVisible;
            set => SetProperty(ref roleErrorIsVisible, value);
        }

        private string levelError;
        public string LevelError
        {
            get => levelError;
            set
            {
                SetProperty(ref levelError, value);
            }

        }
        private bool levelErrorIsVisible;
        public bool LevelErrorIsVisible
        {
            get => levelErrorIsVisible;
            set => SetProperty(ref levelErrorIsVisible, value);
        }

        private string itemLevelError;
        public string ItemLevelError
        {
            get => itemLevelError;
            set => SetProperty(ref itemLevelError, value);
        }
        private bool itemLevelErrorIsVisible;
        public bool ItemLevelErrorIsVisible
        {
            get => itemLevelErrorIsVisible;
            set => SetProperty(ref itemLevelErrorIsVisible, value);
        }

        #endregion

        #region Commands
        public AsyncCommand<string> GetDetailCommand { get; }
        public AsyncCommand EditCommand { get; }
        public AsyncCommand CancelCommand { get; }
        public AsyncCommand BackCommand { get; }
        public AsyncCommand SaveCommand { get; }
        public AsyncCommand DeleteCommand { get; }
        #endregion

        public async Task GetDataById(string id)
        {
            currentCharacter = new CharacterModel();

            if (id == null)
            {
                IsCreateForm = true;
                IsEdit = true;
                IsRead = false;
            }
            else
            {
                IsRead = true;
                IsCreateForm = false;
                IsEdit = false;
                currentCharacter = await _characterService.GetByIdAsync(id);
            }
            
            await SetPropertiesInForm(currentCharacter);
        }

        private async Task SetPropertiesInForm(CharacterModel character)
        {
            Classes = GetClasses();
            Roles = GetRoles();

            PageTitle = "Create new Character";

            if(character.Id != null)
            {
                PageTitle = $"{character.Name} details";
                Name = character.Name;
                SelectedClass = character.Class;
                SelectedRole = character.Role;
                Level = character.Level;
                ItemLevel = character.ItemLevel;
                ArenaRating = character.ArenaRating;
                BattlegroundRating = character.BattlegroundRating;
            }

            await Task.CompletedTask;
        }

        private async Task OnSave()
        {
            IsBusy = true;
            await SaveCharacterState();

            if (Validate(currentCharacter))
            {
                if (IsCreateForm)
                {
                    var newCharacter = await _characterService.AddAsync(currentCharacter);
                    await GetDataById(newCharacter.Id);
                }
                else
                {
                    var updatedCharacter = await _characterService.UpdateAsync(currentCharacter);
                    await GetDataById(updatedCharacter.Id);
                }
            }

            IsCreateForm = false;
            IsEditForm = false;
            IsRead = true;
            IsEdit = false;
            IsBusy = false;
        }

        private async Task OnDelete()
        {
            var response = await Shell.Current
                .DisplayPromptAsync("Are you sure?", 
                $"Type in 'DELETE' to delete {Name}");

            if (!string.IsNullOrEmpty(response) && response.ToUpper().Equals("DELETE"))
            {
                IsBusy = true;
                await _characterService.DeleteAsync(currentCharacter.Id);
                IsBusy = false;
                await Shell.Current.DisplayAlert("Success", "Your character has been deleted.", "OK");
                
                await OnBack();
            }
        }

        private async Task OnBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        private async Task OnEdit()
        {
            IsCreateForm = false;
            IsEditForm = true;
            IsRead = false;
            IsEdit = true;
            await Task.CompletedTask;
        }

        private async Task OnCancel()
        {
            IsCreateForm = false;
            IsEditForm = false;
            IsRead = true;
            IsEdit = false;
            await Task.CompletedTask;
        }

        private async Task SaveCharacterState()
        {
            var userId = await SecureStorage.GetAsync(ApiConstants.UserKey);
            currentCharacter.Name = Name;
            currentCharacter.Class = SelectedClass;
            currentCharacter.Role = SelectedRole;
            currentCharacter.Level = Level;
            currentCharacter.ItemLevel = ItemLevel;
            currentCharacter.ArenaRating = ArenaRating;
            currentCharacter.BattlegroundRating = BattlegroundRating;
            currentCharacter.UserId = userId;
        }

        private bool Validate(CharacterModel character)
        {
            NameError = string.Empty;
            ClassError = string.Empty;
            RoleError = string.Empty;
            LevelError = string.Empty;
            ItemLevelError = string.Empty;

            NameErrorIsVisible = false;
            ClassErrorIsVisible = false;
            RoleErrorIsVisible = false;
            LevelErrorIsVisible = false;
            ItemLevelErrorIsVisible = false;

            var validationContext = new ValidationContext<CharacterModel>(character);
            var result = characterValidator.Validate(validationContext);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    if (error.PropertyName.Equals(nameof(character.Name)))
                    {
                        NameError = error.ErrorMessage;
                        NameErrorIsVisible = true;
                    }
                    if (error.PropertyName.Equals(nameof(character.Class)))
                    {
                        ClassError = error.ErrorMessage;
                        ClassErrorIsVisible = true;
                    }
                    if (error.PropertyName.Equals(nameof(character.Role)))
                    {
                        RoleError = error.ErrorMessage;
                        RoleErrorIsVisible = true;
                    }
                    if (error.PropertyName.Equals(nameof(character.Level)))
                    {
                        LevelError = error.ErrorMessage;
                        LevelErrorIsVisible = true;
                    }
                    if (error.PropertyName.Equals(nameof(character.ItemLevel)))
                    {
                        ItemLevelError = error.ErrorMessage;
                        ItemLevelErrorIsVisible = true;
                    }
                }
            }

            return result.IsValid;
        }

        private IEnumerable<string> GetClasses()
        {
            var classes = new List<string>
            {
                "Warrior",
                "Paladin",
                "Hunter",
                "Rogue",
                "Priest",
                "Shaman",
                "Mage",
                "Warlock",
                "Monk",
                "Druid",
                "Demon Hunter",
                "Death Knight"
            };

            return classes;
        }

        private IEnumerable<string> GetRoles()
        {
            var roles = new List<string>
            {
                "Dps",
                "Tank",
                "Healer"
            };

            return roles;
        }
    }
}
