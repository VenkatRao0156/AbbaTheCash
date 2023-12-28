using AbbaTheCash.ViewModels;
using AbbaTheCash.Views;

namespace AbbaTheCash;

public partial class AppShell : Shell
{
    public AppShell()
	{
        InitializeComponent();

        AppShellVM vm=new AppShellVM();
        BindingContext = vm;

        Routing.RegisterRoute("login", typeof(LoginPage));
        Routing.RegisterRoute("signup", typeof(SignUpPage));
        Routing.RegisterRoute("home", typeof(HomePage));
        Routing.RegisterRoute("forgot", typeof(ForgotPWPage));
        Routing.RegisterRoute("paymentDetails", typeof(PaymentDetailsPage));
        Routing.RegisterRoute("myTransactions", typeof(MyTransactionsPage));
        Routing.RegisterRoute("myCards", typeof(MyCardsPage));
        Routing.RegisterRoute("settings", typeof(SettingsPage));
        Routing.RegisterRoute("contactus", typeof(ContactUsPage));
        Routing.RegisterRoute("rentPage", typeof(RentPage));
        Routing.RegisterRoute("contactusPage", typeof(EducationPage));
    }
}
