﻿using AbbaTheCash.ViewModels;

namespace AbbaTheCash.Views;

public partial class ForgotPWPage : ContentPage
{
	public ForgotPWPage(ForgotPWVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}