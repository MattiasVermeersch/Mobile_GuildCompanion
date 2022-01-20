using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class ArenaViewModel : ViewModelBase
    {
        private readonly IArenaService _arenaService;

        public ArenaViewModel(IArenaService arenaService)
        {
            _arenaService = arenaService;
            Title = "PvP";
        }

        #region Properties
        private IEnumerable<ArenaModel> arenas;
        public IEnumerable<ArenaModel> Arenas
        {
            get => arenas;
            set => SetProperty(ref arenas, value);
        }

        private ArenaModel selectedArena;
        public ArenaModel SelectedArena
        {
            get => selectedArena;
            set
            {
                AppShell.Current.DisplayAlert("Selected", value.Id, "OK");
                SetProperty(ref selectedArena, value);
            }
        }
        #endregion

        #region Commands
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetArenasList();

            IsBusy = false;
        }

        async Task GetArenasList()
        {
            Arenas = await _arenaService.GetAllAsync();
            foreach(var arena in Arenas)
            {
                arena.InstanceName = $"{arena.Mode}v{arena.Mode}";
            }
        }
        #endregion
    }
}
