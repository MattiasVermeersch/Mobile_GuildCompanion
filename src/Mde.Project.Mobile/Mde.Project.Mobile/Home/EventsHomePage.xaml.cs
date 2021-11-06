using Mde.Project.Mobile.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class EventsHomePage : ContentPage
    {
        private readonly EventsService _eventsService;
        
        public EventsHomePage()
        {
            InitializeComponent();

            _eventsService = new EventsService();
        }

        protected override void OnAppearing()
        {
            homePveEventsList.ItemsSource = _eventsService.GetPveEvents();
            homePvpEventsList.ItemsSource = _eventsService.GetPvpEvents();
        }
    }
}