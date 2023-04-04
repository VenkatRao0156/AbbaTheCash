using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage(SignUpVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}