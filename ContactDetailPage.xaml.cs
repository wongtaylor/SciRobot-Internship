using System;
using System.Collections.Generic;
using PracticeXaml.Models;
using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            BindingContext = contact;

            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayActionSheet("Share", "Cancel", null, "Email", "Text", "Facebook");
            DisplayAlert("Shared by", response, "OK");
        }
    }
}
