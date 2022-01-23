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
    public class PersonalEventsViewModel : ViewModelBase
    {
        protected readonly IAllEventsService _service;
        public PersonalEventsViewModel(IAllEventsService service)
        {
            _service = service;
            Title = "My Events";
            SelectedCommand = new AsyncCommand<object>(Selected);
        }
        #region Properties
        private IEnumerable<EventListItemModel> events;
        public IEnumerable<EventListItemModel> Events
        {
            get => events;
            set => SetProperty(ref events, value);
        }

        private EventListItemModel selectedEvent;
        public EventListItemModel SelectedEvent
        {
            get => selectedEvent;
            set => SetProperty(ref selectedEvent, value);
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
            await GetEventsList();

            IsBusy = false;
        }
        private async Task GetEventsList()
        {
            var userEvents = await _service.ListAllAsync();
            if(userEvents.Count == 0)
            {
                HasData = false;
            }
            else
            {
                Events = userEvents;
                HasData = true;
            }
        }
        private async Task Selected(object args)
        {
            var eventItem = args as EventListItemModel;

            if (eventItem is null) return;

            var route = $"{nameof(DetailEventPage)}?EventId={eventItem.Id}&EventType={eventItem.Type}";
            await Shell.Current.GoToAsync(route);
        }
        #endregion
    }
}
