using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;

namespace AbbaTheCash.ViewModels
{
    public partial class LoginVM : BaseVM
    {
        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => OnPropertyChanged(_phoneNumber);
        }

        private string _pw;
        public string PW
        {
            get => _pw;
            set => OnPropertyChanged(_pw);
        }

        public ICommand LoginBtnCommand { get; set; }
        public ICommand ForgotCommand { set; get; }
        public ICommand SignUpCommand { set; get; }

        public LoginVM()
        {
            LoginBtnCommand = new Command(OnLogin);
            ForgotCommand = new Command(OnForgotPW);
            SignUpCommand = new Command(OnSignUp);
        }

        public async void OnLogin()
        {
            await Shell.Current.GoToAsync("home");
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

