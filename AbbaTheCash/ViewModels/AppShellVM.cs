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

        [ObservableProperty]
        string phoneNumber = "+919959027777";

        [ObservableProperty]
        string emailID = "venkatrao0156@gmail.com";

        public ICommand LogOutCommand => new Command(LogOut);

        public async void LogOut()
        {
            var exit = await App.Current.MainPage.DisplayAlert("LogOut?", "Are you want to LogOut the app?", "Yes", "No");
            if (exit)
            {
                await Shell.Current.GoToAsync("///login");
            }
        }

        public override void OnHardBackButtonPressed()
        {

        }
    }
}
