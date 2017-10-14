using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PracticeXaml.Models;
using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));

              //deselect the name
            listView.SelectedItem = null;
        }
		void Call_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact;

			DisplayAlert("Call", contact.Name, "OK");
		}

		void Delete_Clicked(object sender, System.EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
		}

		public ContactsPage()
		{
			InitializeComponent();

            _contacts = new ObservableCollection<Contact> {
				new Contact{ Name = "Mike",
                    ImageUrl = "https://cdn.allwallpaper.in/wallpapers/100x100/251/landscapes-nature-land-bora-100x100-wallpaper.jpg",
					Status = "Hey, wanna chill?"},
				new Contact{ Name = "Michael",
					ImageUrl = "http://inhabitat.com/nyc/wp-content/blogs.dir/2/files/2016/04/New-Aging-Skyler-Skyscraper-100x100.jpg",
					Status = "That building is beautiful"},
				new Contact{ Name = "Vanessa",
                    ImageUrl = "http://www.picgifs.com/avatars/avatars/flowers-and-nature/avatars-flowers-and-nature-870992.jpg",
					Status = "Ready for a vacation"},
				new Contact{ Name = "Taylor",
                    ImageUrl = "http://www.animaatjes.de/avatare/avatare/strand/strand-avatar-animaatjes-208.jpg",
					Status = "Up for an adventure?"},
				new Contact{ Name = "Chris",
					ImageUrl = "http://orig05.deviantart.net/0df9/f/2009/066/e/0/nature_scenery_icon_04_by_devilstrap.jpg",
					Status = "Let's catch up!"}
			};

            listView.ItemsSource = _contacts;
		}
    }
}
