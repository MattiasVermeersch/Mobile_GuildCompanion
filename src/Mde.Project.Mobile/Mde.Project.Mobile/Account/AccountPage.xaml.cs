using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        private readonly AccountService _accountService;
        private DummyProfile profile;
        public AccountPage()
        {
            InitializeComponent();

            _accountService = new AccountService();
        }

        protected async override void OnAppearing()
        {
            profile = await _accountService.GetDummyProfile();
            txtName.Text = profile.Name;
            txtEmail.Text = profile.Email;
            txtDiscordId.Text = profile.DiscordID;
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            //Does nothing yet.
        }
    }
}