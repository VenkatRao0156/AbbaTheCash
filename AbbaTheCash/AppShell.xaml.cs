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
    }
}
