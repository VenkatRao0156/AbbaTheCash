
#if __ANDROID__
using Android.Content.Res;

using Microsoft.Maui.Controls.Compatibility.Platform.Android;

#endif
namespace AbbaTheCash;

public partial class App : Application
{
    public static Realms.Sync.App RealmApp;
    public App()
	{
		InitializeComponent();

        RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);

        MainPage = new AppShell();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (handler, view) =>
        {
#if __ANDROID__
            (handler.PlatformView as Android.Views.View).SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Transparent.ToAndroid());
#endif
        });
    }
}
