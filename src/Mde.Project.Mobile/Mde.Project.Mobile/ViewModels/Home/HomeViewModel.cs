using Autofac;
using Mde.Project.Mobile.IoC;
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
        public HomeViewModel()
        {
            Title = "Home";
        }

        #region Properties

        #endregion

        #region Methods
        public override async Task GetData()
        {
            IsBusy = true;

            await base.GetData();
            await ShowNotification();

            IsBusy = false;
        }

        async Task ShowNotification()
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
            if(result.Action == NotificationAction.Clicked)
            {
                await Shell.Current.DisplayAlert("Alert","You clicked to see your events.", "OK");
            }
        }
        #endregion

    }
}
