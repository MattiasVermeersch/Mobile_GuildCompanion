using Mde.Project.Mobile.Domain.Models;
using Mde.Project.Mobile.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Project.Mobile.Pages
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
            profile = await _accountService.GetProfile();
            
            //Fill labels with account info
            lblName.Text = profile.Name;
            lblEmail.Text = profile.Email;
            lblDiscordId.Text = profile.DiscordID;

            //Fill entries with account info
            txtName.Text = profile.Name;
            txtEmail.Text = profile.Email;
            txtDiscordId.Text = profile.DiscordID;

            SwitchVisibility();
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            SwitchVisibility();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            DummyProfile newProfile = new DummyProfile
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                DiscordID = txtDiscordId.Text
            };

            await _accountService.SaveProfile(newProfile);

            OnAppearing();
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            SwitchVisibility();
        }

        private void SwitchVisibility()
        {
            //Set labels with info and edit button to invisible
            lblName.IsVisible = !lblName.IsVisible;
            lblEmail.IsVisible = !lblEmail.IsVisible;
            lblDiscordId.IsVisible = !lblDiscordId.IsVisible;
            btnEdit.IsVisible = !btnEdit.IsVisible;

            //Make Entries and save/cancel button visible
            txtName.IsVisible = !txtName.IsVisible;
            txtEmail.IsVisible = !txtEmail.IsVisible;
            txtDiscordId.IsVisible = !txtDiscordId.IsVisible;
            btnSave.IsVisible = !btnSave.IsVisible;
            btnCancel.IsVisible = !btnCancel.IsVisible;
        }
    }
}