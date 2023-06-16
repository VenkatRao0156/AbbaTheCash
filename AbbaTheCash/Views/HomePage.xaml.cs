using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}