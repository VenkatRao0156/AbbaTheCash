using AbbaTheCash.Views;

namespace AbbaTheCash;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("login", typeof(LoginPage));
        Routing.RegisterRoute("signup", typeof(SignUpPage));
        Routing.RegisterRoute("home", typeof(HomePage));
        Routing.RegisterRoute("forgot", typeof(ForgotPWPage));
        Routing.RegisterRoute("paymentDetails", typeof(PaymentDetailsPage));
        Routing.RegisterRoute("transactions", typeof(TransactionsPage));
        Routing.RegisterRoute("myCards", typeof(MyCardsPage));
        Routing.RegisterRoute("myPayee", typeof(MyPayeePage));
        Routing.RegisterRoute("settings", typeof(SettingsPage));
        Routing.RegisterRoute("help", typeof(HelpPage));
    }
}
