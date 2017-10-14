using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayActionSheet("Sync with", "Cancel", null, "Twitter", "Facebook", "Linkedin");
        }
    }
}
