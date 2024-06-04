﻿using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetDetailsPage : ContentPage
{
    public PlanetDetailsPage(Planet planet)
    {
        InitializeComponent();

        this.BindingContext = planet;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}