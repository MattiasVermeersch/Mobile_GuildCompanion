using Autofac;
using Mde.Project.Mobile.ViewModels;
using Mde.Project.Mobile.IoC;
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
    public partial class RaidsPage : ContentPage
    {
        public RaidsPage()
        {
            InitializeComponent();

            (BindingContext as RaidViewModel).RefreshCommand.ExecuteAsync();
        }
    }
}