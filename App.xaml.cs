﻿using Xamarin.Forms;
using System.IO;


namespace test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new testPage();
        }

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
