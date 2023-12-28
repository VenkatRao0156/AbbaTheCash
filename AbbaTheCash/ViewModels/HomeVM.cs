using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace AbbaTheCash.ViewModels
{
    public partial class HomeVM : BaseVM
    {
        public ICommand PayRentCommand { set; get; }
        public ICommand EducationFeeCommand { set; get; }
        public HomeVM()
        {
            PayRentCommand = new Command(PayRent);
            EducationFeeCommand = new Command(EducationFee);
        }

        public async void PayRent()
        {
            await Shell.Current.GoToAsync("//rentPage");
        }

        public async void EducationFee()
        {
            await Shell.Current.GoToAsync("//educationPage");
        }

        public async override void OnHardBackButtonPressed()
        {
            var exit = await App.Current.MainPage.DisplayAlert("Exit App?", "Are you want to exit the app?", "Yes", "No");
            if (exit)
            {
                Environment.Exit(0);
            }
        }
    }
}