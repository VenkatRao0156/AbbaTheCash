using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace AbbaTheCash.ViewModels
{
    public partial class AppShellVM : BaseVM
    {
        [ObservableProperty]
        string versionName = "Version v" + AppInfo.Current.VersionString;

        [ObservableProperty]
        string userName = "VenkatRao M";

        public ICommand ContactUsCommand => new Command(ContactUs);
        public ICommand SignOutCommand => new Command(SignOut);
        public ICommand ExitCommand => new Command(Exit);

        public async void ContactUs()
        {
            string action = await App.Current.MainPage.DisplayActionSheet
                ("Contact Us", "Ok", null, "Phone No: 9959027777", "WhatsApp: 9959027777", "Email: venkatrao0156@gmail.com");

            switch (action)
            {
                case "Phone No: 9959027777":
                    if (PhoneDialer.Default.IsSupported)
                        PhoneDialer.Default.Open("9959027777");
                    break;
                case "WhatsApp: 9959027777":
                    SendWhatsAppMessage("9959027777");
                    break;
                case "Email: venkatrao0156@gmail.com":
                    MakeEmail("venkatrao0156@gmail.com");
                    break;
                default: break;
            }
        }

        private async void MakeEmail(string toEmailID)
        {
            if (Email.Default.IsComposeSupported)
            {
                string subject = "Email From Venkatrao";
                string body = "Write your concern/query here!";
                string[] recipients = new[] { toEmailID };

                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    BodyFormat = EmailBodyFormat.PlainText,
                    To = new List<string>(recipients)
                };

                await Email.Default.ComposeAsync(message);
            }
        }

        private async void SendWhatsAppMessage(string number)
        {
            var message = "Hello!";
            bool supportsUri = await Launcher.Default.CanOpenAsync($"whatsapp://send?phone=+{number}&text={message}");
            if (supportsUri)
                await Launcher.Default.OpenAsync($"whatsapp://send?phone=+{number}&text={message}");
            else
                await App.Current.MainPage.DisplayAlert("Error", "Unable to open WhatsApp.", "OK");
        }

        public async void SignOut()
        {
            var exit = await App.Current.MainPage.DisplayAlert("SignOut?", "Are you want to SignOut the app?", "Yes", "No");
            if (exit)
            {
                await Shell.Current.GoToAsync("///login");
            }
        }

        public async void Exit()
        {
            var exit = await App.Current.MainPage.DisplayAlert("Exit App?", "Are you want to exit the app?", "Yes", "No");
            if (exit)
            {
                Environment.Exit(0);
            }
        }

        public override void OnHardBackButtonPressed()
        {

        }
    }
}
