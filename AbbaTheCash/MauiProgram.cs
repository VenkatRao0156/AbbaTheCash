using AbbaTheCash.ViewModels;
using AbbaTheCash.Views;
using Microsoft.Extensions.Logging;

namespace AbbaTheCash;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<LoginVM>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomeVM>();
        builder.Services.AddSingleton<ForgotPWPage>();
        builder.Services.AddSingleton<ForgotPWVM>();
        builder.Services.AddSingleton<SignUpPage>();
        builder.Services.AddSingleton<SignUpVM>();
        builder.Services.AddSingleton<PaymentDetailsPage>();
        builder.Services.AddSingleton<PaymentDetailsVM>();
        builder.Services.AddSingleton<TransactionsPage>();
        builder.Services.AddSingleton<TransactionsVM>();
        builder.Services.AddSingleton<MyCardsPage>();
        builder.Services.AddSingleton<MyCardsVM>();
        builder.Services.AddSingleton<MyPayeePage>();
        builder.Services.AddSingleton<MyPayeeVM>();
        builder.Services.AddSingleton<SettingsPage>();
        builder.Services.AddSingleton<SettingsVM>();
        builder.Services.AddSingleton<HelpPage>();
        builder.Services.AddSingleton<HelpVM>();
        return builder.Build();
	}
}