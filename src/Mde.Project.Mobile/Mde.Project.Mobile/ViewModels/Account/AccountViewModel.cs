using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        protected readonly IAccountService _accountService;
        public AccountViewModel(IAccountService accountService)
        {
            _accountService = accountService;
            Title = "My Account";

            SaveProfileCommand = new AsyncCommand(SaveProfileAsync);
            TakePhotoCommand = new AsyncCommand(TakePhotoAsync);
            EditCommand = new AsyncCommand(ChangeProfileState);
            CancelCommand = new AsyncCommand(ChangeProfileState);
        }

        #region Properties
        string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        string city;
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set => SetProperty(ref birthDate, value);
        }

        string address;
        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        string fullName;
        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }

        string battleNetId;
        public string BattleNetId
        {
            get => battleNetId;
            set => SetProperty(ref battleNetId, value);
        }

        ImageSource profilePicture;
        public ImageSource ProfilePicture
        {
            get => profilePicture;
            set => SetProperty(ref profilePicture, value);
        }

        bool isEdit;
        public bool IsEdit
        {
            get => isEdit;
            set => SetProperty(ref isEdit, value);
        }

        bool isRead;
        public bool IsRead
        {
            get => isRead;
            set => SetProperty(ref isRead, value);
        }

        public AsyncCommand SaveProfileCommand { get; }
        public AsyncCommand TakePhotoCommand { get; }
        public AsyncCommand EditCommand { get; }
        public AsyncCommand CancelCommand { get; }

        #endregion

        #region Commands
        public async override Task GetData()
        {
            IsRead = true;
            IsBusy = true;

            await base.GetData();
            await GetProfile();

            IsBusy = false;
        }
        #endregion

        async Task GetProfile()
        {
            var account = await _accountService.GetProfile();
            var photoPath = await _accountService.GetProfilePicture();

            //await LoadPhotoAsync(photo);

            if (account != null) await SetProperties(account, photoPath);
        }

        async Task SetProperties(AccountModel account, string photoPath)
        {
            Email = account.Email;
            City = account.City;
            BirthDate = account.BirthDate;
            Address = account.Address;
            FullName = account.FullName;
            BattleNetId = account.BattleNetId;
            ProfilePicture = photoPath;
            await Task.CompletedTask;
        }
        private async Task ChangeProfileState()
        {
            IsRead = !IsRead;
            IsEdit = !IsEdit;
            await Task.CompletedTask;
        }
        async Task SaveProfileAsync()
        {
            AccountModel currentAccount = new AccountModel
            {
                Email = Email,
                City = City,
                BirthDate = BirthDate,
                Address = Address,
                FullName = FullName,
                BattleNetId = BattleNetId
            };

            if(await _accountService.SaveProfile(currentAccount))
            {
                await ChangeProfileState();
                await Shell.Current.DisplayAlert("Success", "Your account info has been saved.", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Your account info has not been saved, try again", "OK");
            }
        }

        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                
                if(photo != null)
                {
                    await LoadPhotoAsync(photo);

                    await Shell.Current.DisplayAlert("Success", "Your new profile picture is taken.", "OK");
                }
            }

            catch (FeatureNotSupportedException fnsEx) 
            { 
                await Shell.Current.DisplayAlert("Error", $"{fnsEx.Message}", "OK"); 
            }

            catch (PermissionException psEx) 
            {
                await Shell.Current.DisplayAlert("Error", $"{psEx.Message}", "OK");
            }
            
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"{ex.Message}", "OK");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            //when canceled
            if(photo == null)
            {
                return;
            }

            //save the image into local storage
            var newFile = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);

            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            await _accountService.SaveProfilePicture(newFile);

            ProfilePicture = newFile;
        }
    }
}
