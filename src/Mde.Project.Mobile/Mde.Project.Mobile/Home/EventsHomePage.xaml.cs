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
        private readonly EventsService eventsService;
        
        public EventsHomePage()
        {
            InitializeComponent();

            eventsService = new EventsService();

            homePveEventsList.ItemsSource = eventsService.GetPveEvents();
            homePvpEventsList.ItemsSource = eventsService.GetPvpEvents();
        }

        protected override void OnAppearing()
        {
            
        }
    }
}