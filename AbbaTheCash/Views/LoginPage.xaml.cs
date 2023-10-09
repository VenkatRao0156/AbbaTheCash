using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (LoginVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}