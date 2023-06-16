using System;
using CommunityToolkit.Mvvm.Input;

namespace AbbaTheCash.ViewModels
{
    public partial class HomeVM : BaseVM
    {
        // button click event is not working plase follow ICommond(old proces)
           
        [RelayCommand]
        public async void PayBill()
        {
            await Shell.Current.GoToAsync("paymentDetails");
        }

        [RelayCommand]
        public async void PayRent()
        {
            await Shell.Current.GoToAsync("paymentDetails");
        }

        [RelayCommand]
        public async void EducationFee()
        {
            await Shell.Current.GoToAsync("paymentDetails");
        }

        [RelayCommand]
        public async void OfficeBill()
        {
            await Shell.Current.GoToAsync("paymentDetails");
        }
    }
}

