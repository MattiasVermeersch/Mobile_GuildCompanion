using Autofac;
using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.IoC;
using Mde.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
{
    [QueryProperty(nameof(EventId), nameof(EventId))]
    [QueryProperty(nameof(EventType), nameof(EventType))]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailEventPage : ContentPage
    {
        public string EventId { get; set; }
        public string EventType { get; set; }
        public DetailEventPage()
        {
            InitializeComponent();
            var viewModel = IoCResolver.Container.Resolve<EventDetailViewModel>();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            var parameters = new EventParameters{ Id = EventId, Type = EventType };
            (BindingContext as EventDetailViewModel).GetDetailCommand.ExecuteAsync(parameters);
        }
    }
}