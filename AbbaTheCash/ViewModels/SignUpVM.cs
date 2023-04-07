using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using Realms;
using Realms.Sync;
using AbbaTheCash.Models;

namespace AbbaTheCash.ViewModels
{
    public partial class SignUpVM : BaseVM
    {
        private Realm realm;
        private PartitionSyncConfiguration config;

        [ObservableProperty]
        string firstName;

        [ObservableProperty]
        string lastName;

        [ObservableProperty]
        string phoneNumber;

        [ObservableProperty]
        string emailID;

        [ObservableProperty]
        string panCard;

        [ObservableProperty]
        string pswd;

        [RelayCommand]
        public async void SignUp()
        {
            try
            {
                await App.RealmApp.EmailPasswordAuth.RegisterUserAsync(PhoneNumber, pswd);

                var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(PhoneNumber, pswd));

                if (user != null)
                {
                    config = new PartitionSyncConfiguration($"{App.RealmApp.CurrentUser.Id}", App.RealmApp.CurrentUser);
                    realm = Realm.GetInstance(config);
                    try
                    {
                        var todo =
                            new UserDeatilsModel
                            {
                                FirstName=FirstName,
                                LastName=LastName,
                                EmailID=EmailID,
                                PanCard=PanCard,
                                Partition = App.RealmApp.CurrentUser.Id,
                            };
                        realm.Write(() =>
                        {
                            realm.Add(todo);
                        });
                    }
                    catch (Exception ex)
                    {
                        await Application.Current.MainPage.DisplayPromptAsync("Error", ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error creating account!", "Error: " + ex.Message, "OK");
            }
        }

        public ICommand SignInCommand { set; get; }

        public SignUpVM()
        {
            SignInCommand = new Command(OnSignIn);
        }

        private async void OnSignIn()
        {
            await Shell.Current.GoToAsync("///login");
        }

        public void InitialiseRealm()
        {
            config = new PartitionSyncConfiguration($"{App.RealmApp.CurrentUser.Id}", App.RealmApp.CurrentUser);
            realm = Realm.GetInstance(config);
        }
    }
}

