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
    public class RaidViewModel : ViewModelBase
    {
        private readonly IRaidService _raidService;

        public RaidViewModel(IRaidService raidService)
        {
            _raidService = raidService;
            Title = "PvE";

            SelectedCommand = new AsyncCommand<object>(Selected);
        }

        #region Properties
        private IEnumerable<RaidModel> raids;
        public IEnumerable<RaidModel> Raids
        {
            get => raids;
            set => SetProperty(ref raids, value);
        }

        private RaidModel selectedRaid;
        public RaidModel SelectedRaid
        {
            get => selectedRaid;
            set
            {
                SetProperty(ref selectedRaid, value);
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
            await GetRaidsList();

            IsBusy = false;
        }

        async Task GetRaidsList()
        {
            var raids = await _raidService.GetUpcomingEvents();

            if(raids == null) HasData = false;
            else
            {
                HasData = true;
                Raids = raids;
            }
        }

        private async Task Selected(object args)
        {
            var raid = args as RaidModel;

            if (raid is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={raid.Id}&EventType={nameof(raid)}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
