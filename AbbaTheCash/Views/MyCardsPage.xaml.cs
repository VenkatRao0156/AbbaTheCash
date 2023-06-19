using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class MyCardsPage : ContentPage
{
	public MyCardsPage(MyCardsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}