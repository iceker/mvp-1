﻿using Microsoft.Mvp.ViewModels;
using System;

using Xamarin.Forms;

namespace Microsoft.Mvpui
{
    public partial class Settings : ContentPage
    {

        #region Constructor
        public Settings()
        {
            InitializeComponent();
        }

        #endregion

        #region Private and Protected Methods

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopModalAsync();
            return true;
        }

        private async void BtnAbout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new About());
        }

        private async void BtnSignOut_Clicked(object sender, EventArgs e)
        {
            App.CookieHelper.ClearCookie();
            LiveIdLogOnViewModel.Instance.SignOut();
            await Navigation.PushModalAsync(new LogOn());
        }

        private async void OnCloseClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        #endregion

    }
}
