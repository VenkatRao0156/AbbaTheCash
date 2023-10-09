using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (HomeVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}