using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.Project.Mobile.Droid
{
    [Activity(Label = "Guild Companion", Icon = "@drawable/emc_logo", Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        { 
            base.OnCreate(savedInstanceState, persistentState); 
        } 
        
        // Launches the startup task
        protected override void OnResume() 
        { 
            base.OnResume(); 
            Task startupWork = new Task(() => { SimulateStartup(); }); 
            startupWork.Start(); 
        } 
        
        // Prevent the back button from canceling the startup process
        public override void OnBackPressed() { } 
        
        // Simulates background work that happens behind the splash screen
        async void SimulateStartup() 
        { 
            Log.Debug("Guild Companion", "Performing some startup work that takes a bit of time.");
#if DEBUG
            await Task.Delay(500); // Simulate a bit of startup work.
#endif
            Log.Debug("Guild Companion", "Startup work is finished - starting MainActivity."); 
            StartActivity(new Intent(Application.Context, typeof(MainActivity))); }
    }
}