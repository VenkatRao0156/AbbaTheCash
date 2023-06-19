using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class PaymentDetailsPage : ContentPage
{
	public PaymentDetailsPage(PaymentDetailsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}