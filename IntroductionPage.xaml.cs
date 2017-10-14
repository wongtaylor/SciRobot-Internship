using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //disable back button functionality on andriod and windows phones
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
