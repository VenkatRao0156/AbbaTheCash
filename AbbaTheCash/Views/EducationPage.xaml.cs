using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class EducationPage : ContentPage
{
    public EducationPage(EducationVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override bool OnBackButtonPressed()
    {
        var vm = (EducationVM)BindingContext;
        vm.OnHardBackButtonPressed();
        return true;
    }
}