using AbbaTheCash.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace AbbaTheCash.ViewModels
{
    public partial class AppShellVM : BaseVM
    {
        [ObservableProperty]
        string versionName = "Version v" + AppInfo.Current.VersionString;

        [ObservableProperty]
        string userName = "VenkatRao M";

        public ICommand SignOutCommand => new Command(SignOut);
        public ICommand ExitCommand => new Command(Exit);

        public async void SignOut()
        {
            var exit = await App.Current.MainPage.DisplayAlert("SignOut?", "Are you want to SignOut the app?", "Yes", "No");
            if (exit)
            {
                await Shell.Current.GoToAsync("///login");
            }
        }

        public async void Exit()
        {
            var exit = await App.Current.MainPage.DisplayAlert("Exit App?", "Are you want to exit the app?", "Yes", "No");
            if (exit)
            {
                Environment.Exit(0);
            }
        }

        public override void OnHardBackButtonPressed()
        {

        }
    }
}
