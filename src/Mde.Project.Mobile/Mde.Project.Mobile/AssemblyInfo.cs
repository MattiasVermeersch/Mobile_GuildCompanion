
using Mde.Project.Mobile.Domain.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#region Dependendy Injection
[assembly: Dependency(typeof(CharactersService))]
[assembly: Dependency(typeof(ArenaService))]
[assembly: Dependency(typeof(BattlegroundService))]
[assembly: Dependency(typeof(DungeonService))]
[assembly: Dependency(typeof(RaidService))]
#endregion