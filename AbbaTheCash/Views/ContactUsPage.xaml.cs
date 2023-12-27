using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class ContactUsPage : ContentPage
{
    public ContactUsPage(ContactUsVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (ContactUsVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}