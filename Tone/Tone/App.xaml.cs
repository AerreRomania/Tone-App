﻿using System;
using Tone.ViewModels;
using Tone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
