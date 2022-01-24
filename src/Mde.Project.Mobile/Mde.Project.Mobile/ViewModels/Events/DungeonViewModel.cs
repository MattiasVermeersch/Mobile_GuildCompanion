using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class DungeonViewModel : ViewModelBase
    {
        private readonly IDungeonService _dungeonService;
        public DungeonViewModel(IDungeonService dungeonService)
        {
            _dungeonService = dungeonService;
            Title = "PvE";

            SelectedCommand = new AsyncCommand<object>(Selected);
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
                SetProperty(ref selectedDungeon, value);
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
            await GetdungeonsList();

            IsBusy = false;
        }

        async Task GetdungeonsList()
        {
            var dungeons = await _dungeonService.GetUpcomingEvents();

            if(dungeons == null) HasData = false;
            else
            {
                HasData = true;
                Dungeons = dungeons;
            }
        }

        private async Task Selected(object args)
        {
            var dungeon = args as DungeonModel;

            if (dungeon is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={dungeon.Id}&EventType={nameof(dungeon)}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
