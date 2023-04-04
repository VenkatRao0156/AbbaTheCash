using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AbbaTheCash.ViewModels
{
	public partial class SignUpVM:BaseVM
	{
        [ObservableProperty]
        string firstName;

        [ObservableProperty]
        string lastName;

        [ObservableProperty]
        string phoneNumber;

        [ObservableProperty]
        string emailID;

        [ObservableProperty]
        string panCard;

        [ObservableProperty]
        string pswd;

        [RelayCommand]
        public async void SignUp()
        {
            await Shell.Current.GoToAsync("///login");
        }

        public ICommand SignInCommand { set; get; }

        public SignUpVM()
        {
            SignInCommand = new Command(OnSignIn);
        }

        private async void OnSignIn(object obj)
        {
            await Shell.Current.GoToAsync("///login");
        }
    }
}

