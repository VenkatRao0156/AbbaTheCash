using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}