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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text) || 
               string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                await DisplayAlert("Form error", "Please fill in the form!", "OK");
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                await DisplayAlert("Password error", "The passwords don't match!", "Let's fix this");
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}