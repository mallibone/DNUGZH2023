﻿namespace MauiBlazorApp;

public partial class MainPage : ContentPage
{
    public MainPage(CounterViewModel counterViewModel)
	{
		InitializeComponent();
        BindingContext = counterViewModel;
    }
}