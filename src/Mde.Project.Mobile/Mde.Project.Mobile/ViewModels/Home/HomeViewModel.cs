using Autofac;
using Mde.Project.Mobile.Domain.Interfaces;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.Pages;
using MvvmHelpers.Commands;
using Plugin.Toasts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Project.Mobile.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IAllEventsService _service;

        public HomeViewModel(IAllEventsService service)
        {
            _service = service;
            Title = "Home";
            NotificationCommand = new AsyncCommand(ShowNotification);
            SelectedCommand = new AsyncCommand<object>(Selected);
        }

        #region Properties
        public int Count { get; set; }

        private IEnumerable<EventListItemModel> pvpEvents;
        public IEnumerable<EventListItemModel> PvpEvents
        {
            get => pvpEvents;
            set => SetProperty(ref pvpEvents, value);
        }

        private IEnumerable<EventListItemModel> pveEvents;
        public IEnumerable<EventListItemModel> PveEvents
        {
            get => pveEvents;
            set => SetProperty(ref pveEvents, value);
        }

        private EventListItemModel selectedEvent;
        public EventListItemModel SelectedEvent
        {
            get => selectedEvent;
            set => SetProperty(ref selectedEvent, value);
        }

        private bool hasPveEvents;
        public bool HasPveEvents
        {
            get => hasPveEvents;
            set => SetProperty(ref hasPveEvents, value);
        }

        private bool hasPvpEvents;
        public bool HasPvpEvents
        {
            get => hasPvpEvents;
            set => SetProperty(ref hasPvpEvents, value);
        }
        #endregion

        #region Commands
        public AsyncCommand NotificationCommand { get; }
        public AsyncCommand<object> SelectedCommand { get; }
        #endregion

        #region Methods
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await GetEventsCount();
            await GetPveEventsList();
            await GetPvpEventsList();

            IsBusy = false;
        }

        private async Task GetEventsCount()
        {
            var events = await _service.ListAllAsync();

            Count = events.Count;
        }

        private async Task GetPveEventsList()
        {
            var events = await _service.ListAllPveAsync();

            if(events.Count == 0)
            {
                HasPveEvents = false;
            }
            else
            {
                HasPveEvents = true;
                PveEvents = events;
            }
            await Task.CompletedTask;
        }

        private async Task GetPvpEventsList()
        {
            var events = await _service.ListAllPvpAsync();

            if (events.Count == 0)
            {
                HasPvpEvents = false;
            }
            else
            {
                HasPvpEvents = true;
                PvpEvents = events;
            }
            await Task.CompletedTask;
        }

        private async Task Selected(object args)
        {
            var eventItem = args as EventListItemModel;

            if (eventItem is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={eventItem.Id}&EventType={eventItem.Type}";
            await Shell.Current.GoToAsync(route);
        }

        async Task ShowNotification()
        {
            if (Count > 0)
            {
                var notificator = DependencyService.Get<IToastNotificator>();

                //Description right now is a placeholder. When ApiService is implemented the relevant variables will be used.
                var options = new NotificationOptions()
                {
                    Title = "You have events today!",
                    Description = "Check it out!",
                    IsClickable = true,
                    WindowsOptions = new WindowsOptions()
                    {
                        LogoUri = "wow_icon.png"
                    },
                    ClearFromHistory = true,
                    AllowTapInNotificationCenter = false,
                    AndroidOptions = new AndroidOptions()
                    {
                        HexColor = "#8cde95",
                        ForceOpenAppOnNotificationTap = true
                    }
                };

                var result = await notificator.Notify(options);
                if (result.Action == NotificationAction.Clicked)
                {
                    await Shell.Current.GoToAsync($"{nameof(PersonalEventsPage)}");
                }
            }
        }
        #endregion

    }
}
