using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbaTheCash.ViewModels
{
    public class RentVM : BaseVM
    {
        public RentVM()
        {
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
