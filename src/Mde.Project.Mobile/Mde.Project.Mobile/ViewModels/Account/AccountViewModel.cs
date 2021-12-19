using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        IAccountService _accountService;
        public AccountViewModel(IAccountService accountService)
        {
            _accountService = accountService;
            Title = "My Account";
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
        #endregion

        #region Commands
        public async override Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetProfile();

            IsBusy = false;
        }
        #endregion

        async Task GetProfile()
        {
            var account = await _accountService.GetProfile();

            if (account != null) SetProperties(account);
        }

        void SetProperties(AccountModel account)
        {
            UserName = account.UserName;
            Email = account.Email;
            City = account.City;
            BirthDate = account.BirthDate;
            Address = account.Address;
            FullName = account.FullName;
            BattleNetId = account.BattleNetId;
        }
    }
}
