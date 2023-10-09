using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AbbaTheCash.ViewModels
{
    public abstract class BaseVM : ObservableObject
    {
        //[ObservableProperty]
        //[NotifyPropertyChangedFor(nameof(IsNotBusy))]
        //bool isBusy;

        //public bool IsNotBusy => !IsBusy;


        public abstract void OnHardBackButtonPressed();
    }
}

