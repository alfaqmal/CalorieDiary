﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalorieDiary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MasterDetailPage();
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
