using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage(SignUpVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (SignUpVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}