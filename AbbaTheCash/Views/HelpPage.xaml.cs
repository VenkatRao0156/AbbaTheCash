using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class HelpPage : ContentPage
{
	public HelpPage(HelpVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}