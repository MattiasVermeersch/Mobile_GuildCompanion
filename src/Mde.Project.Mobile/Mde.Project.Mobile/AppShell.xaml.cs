using Mde.Project.Mobile.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            #region Routing
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(EventsPage), typeof(EventsPage));
            Routing.RegisterRoute(nameof(CharactersPage), typeof(CharactersPage));
            Routing.RegisterRoute(nameof(AccountPage), typeof(AccountPage));
            #endregion

        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}