using System.Windows.Input;

namespace AbbaTheCash.ViewModels
{

    public class ContactUsVM : BaseVM
    {
        public ICommand PhoneTapCommand { set; get; }
        public ICommand WhatsAppTapCommand { set; get; }
        public ICommand EmailTapCommand { set; get; }

        public ContactUsVM()
        {
            PhoneTapCommand = new Command(MakePhoneCall);
            WhatsAppTapCommand = new Command(SendWhatsAppMessage);
            EmailTapCommand = new Command(MakeEmail);
        }

        private void MakePhoneCall()
        {
            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Default.Open("+919959027777");
        }

        private async void SendWhatsAppMessage()
        {
            var message = "Hello!";
            var number = "+919959027777";
            bool supportsUri = await Launcher.Default.CanOpenAsync($"whatsapp://send?phone=+{number}&text={message}");
            if (supportsUri)
                await Launcher.Default.OpenAsync($"whatsapp://send?phone=+{number}&text={message}");
            else
                await App.Current.MainPage.DisplayAlert("Error", "Unable to open WhatsApp.", "OK");
        }

        private async void MakeEmail()
        {
            if (Email.Default.IsComposeSupported)
            {
                string subject = "Email From Venkatrao";
                string body = "Write your concern/query here!";
                string toEmailID = "venkatrao0156@gmail.com";
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

        public async override void OnHardBackButtonPressed()
        {
            var exit = await App.Current.MainPage.DisplayAlert("Exit App?", "Are you want to exit the app?", "Yes", "No");
            if (exit)
            {
                Environment.Exit(0);
            }
        }
    }
}
