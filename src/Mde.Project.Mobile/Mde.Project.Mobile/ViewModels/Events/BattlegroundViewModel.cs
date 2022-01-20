using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class BattlegroundViewModel : ViewModelBase
    {
        private readonly IBattlegroundService _battlegroundService;
        public BattlegroundViewModel(IBattlegroundService battlegroundService)
        {
            _battlegroundService = battlegroundService;
            Title = "PvP";
        }

        #region Properties
        private IEnumerable<BattlegroundModel> battlegrounds;
        public IEnumerable<BattlegroundModel> Battlegrounds
        {
            get => battlegrounds;
            set => SetProperty(ref battlegrounds, value);
        }

        private BattlegroundModel selectedBattleground;
        public BattlegroundModel SelectedBattleground
        {
            get => selectedBattleground;
            set
            {
                AppShell.Current.DisplayAlert("Selected", value.Id, "OK");
                SetProperty(ref selectedBattleground, value);
            }
        }
        #endregion

        #region Commands
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetBattlegroundsList();

            IsBusy = false;
        }

        async Task GetBattlegroundsList()
        {
            Battlegrounds = await _battlegroundService.GetAllAsync();
        }
        #endregion
    }
}
