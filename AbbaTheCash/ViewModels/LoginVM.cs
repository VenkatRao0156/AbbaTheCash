using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
            await Shell.Current.GoToAsync("///home");
        }

        public async void OnSignUp()
        {
            await Shell.Current.GoToAsync("signup");
        }

        public async void OnForgotPW()
        {
            await Shell.Current.GoToAsync("forgot");
        }
    }
}