using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class RaidViewModel : ViewModelBase
    {
        private readonly IEventService<RaidModel> _raidService;

        public RaidViewModel()
        {
            _raidService = DependencyService.Get<IEventService<RaidModel>>();
            Title = "PvE";
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
                AppShell.Current.DisplayAlert("Selected", value.Id, "OK");
                SetProperty(ref selectedRaid, value);
            }
        }
        #endregion

        #region Commands
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetRaidsList();

            IsBusy = false;
        }

        async Task GetRaidsList()
        {
            Raids = await _raidService.GetAll();

            //this is a comment
            Title = "Still PvP";
        }
        #endregion
    }
}
