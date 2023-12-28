using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class RentPage : ContentPage
{
    public RentPage(RentVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (RentVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}