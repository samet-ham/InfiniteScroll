﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfiniteScroll
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyPage();
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
