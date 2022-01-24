using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
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

            SelectedCommand = new AsyncCommand<object>(Selected);
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
                SetProperty(ref selectedBattleground, value);
            }
        }

        private bool hasData;
        public bool HasData
        {
            get => hasData;
            set => SetProperty(ref hasData, value);
        }
        #endregion

        #region Commands
        public AsyncCommand<object> SelectedCommand { get; }
        #endregion

        #region Methods
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetBattlegroundsList();

            IsBusy = false;
        }

        async Task GetBattlegroundsList()
        {
            var battlegrounds = await _battlegroundService.GetUpcomingEvents();

            if(battlegrounds == null) HasData = false;
            else
            {
                HasData = true;
                Battlegrounds = battlegrounds;
            }
        }

        private async Task Selected(object args)
        {
            var battleground = args as BattlegroundModel;

            if (battleground is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={battleground.Id}&EventType={nameof(battleground)}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
