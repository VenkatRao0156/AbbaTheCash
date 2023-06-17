using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Realms.Sync;

namespace AbbaTheCash.ViewModels
{
    public partial class LoginVM : BaseVM
    {
        [ObservableProperty]
        string phoneNumber;

        [ObservableProperty]
        string pswd;

        public ICommand ForgotCommand { set; get; }
        public ICommand SignUpCommand { set; get; }

        public LoginVM()
        {
            ForgotCommand = new Command(OnForgotPW);
            SignUpCommand = new Command(OnSignUp);
        }

        [RelayCommand]
        public async void Login()
        {
             var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword("123456789", "123456789"));
            //var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(emailID, pswd));
            if (user != null)
            {
                await Shell.Current.GoToAsync("//home");
               // await Shell.Current.GoToAsync("home");
            }
        }

        public async void OnSignUp()
        {
            await Shell.Current.GoToAsync("//signup");
        }

        public async void OnForgotPW()
        {
            await Shell.Current.GoToAsync("//forgot");
        }
    }
}