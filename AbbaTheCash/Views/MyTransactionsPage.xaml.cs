using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class MyTransactionsPage : ContentPage
{
	public MyTransactionsPage(MyTransactionsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}