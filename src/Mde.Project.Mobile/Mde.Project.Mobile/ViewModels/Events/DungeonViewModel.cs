using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class DungeonViewModel : ViewModelBase
    {
        private readonly IEventService<DungeonModel> _dungeonService;
        public DungeonViewModel()
        {
            _dungeonService = DependencyService.Get<IEventService<DungeonModel>>();
            Title = "PvE";
        }

        #region Properties
        private IEnumerable<DungeonModel> dungeons;
        public IEnumerable<DungeonModel> Dungeons
        {
            get => dungeons;
            set => SetProperty(ref dungeons, value);
        }

        private DungeonModel selectedDungeon;
        public DungeonModel SelectedDungeon
        {
            get => selectedDungeon;
            set
            {
                AppShell.Current.DisplayAlert("Selected", value.Id, "OK");
                SetProperty(ref selectedDungeon, value);
            }
        }
        #endregion

        #region Commands
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetdungeonsList();

            IsBusy = false;
        }

        async Task GetdungeonsList()
        {
            Dungeons = await _dungeonService.GetAll();
        }
        #endregion
    }
}
