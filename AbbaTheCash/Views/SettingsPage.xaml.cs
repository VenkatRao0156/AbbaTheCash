using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}