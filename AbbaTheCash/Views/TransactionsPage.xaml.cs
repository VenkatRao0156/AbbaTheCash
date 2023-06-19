using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class TransactionsPage : ContentPage
{
	public TransactionsPage(TransactionsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}