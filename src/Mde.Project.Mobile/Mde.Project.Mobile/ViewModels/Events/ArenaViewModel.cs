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
    public class ArenaViewModel : ViewModelBase
    {
        private readonly IArenaService _arenaService;

        public ArenaViewModel(IArenaService arenaService)
        {
            _arenaService = arenaService;
            Title = "PvP";

            SelectedCommand = new AsyncCommand<object>(Selected);
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
                SetProperty(ref selectedArena, value);
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
            await GetArenasList();

            IsBusy = false;
        }

        async Task GetArenasList()
        {
            var arenas = await _arenaService.GetUpcomingEvents();

            if (arenas == null) HasData = false;
            else
            {
                HasData = true;
                foreach (var arena in arenas)
                {
                    arena.InstanceName = $"{arena.Mode}v{arena.Mode}";
                }
                Arenas = arenas;
            }
        }

        private async Task Selected(object args)
        {
            var arena = args as ArenaModel;

            if (arena is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={arena.Id}&EventType={nameof(arena)}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
