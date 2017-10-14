using System;
using System.Collections.Generic;
using System.Linq;
using PracticeXaml.Models;
using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class ListPage : ContentPage
    {
        void Follow_Clicked(object sender, System.EventArgs e)
        {
            Button follow = (Button)sender;
            var contact = follow.CommandParameter as Contact;
            DisplayAlert("Now following", contact.Name, "OK" );
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        IEnumerable<ContactGroup> GetContacts(string searchText = null){
			var contacts = new List<ContactGroup>{
				new ContactGroup("C", "C"){
					new Contact{ Name = "Chris", 
                        ImageUrl = "http://orig05.deviantart.net/0df9/f/2009/066/e/0/nature_scenery_icon_04_by_devilstrap.jpg",
                        Status = "Let's catch up!"}
				},
				new ContactGroup("J", "J"){
					new Contact{ Name = "Julia", 
                        ImageUrl = "http://www.thunderbay.ca/Assets/City+Services+Guide/images/animals.jpg",
						Status = "Go Beavers!"}
				},
				new ContactGroup("M", "M"){
					new Contact{ Name = "Michael", 
                        ImageUrl = "http://inhabitat.com/nyc/wp-content/blogs.dir/2/files/2016/04/New-Aging-Skyler-Skyscraper-100x100.jpg",
					    Status = "That building is beautiful"},

					new Contact{ Name = "Mike", 
                        ImageUrl = "https://cdn.allwallpaper.in/wallpapers/100x100/251/landscapes-nature-land-bora-100x100-wallpaper.jpg",
					    Status = "Hey, wanna chill?"}
				},
				new ContactGroup("T", "T"){
					new Contact{ Name = "Taylor", 
                        ImageUrl = "http://www.animaatjes.de/avatare/avatare/strand/strand-avatar-animaatjes-208.jpg",
					    Status = "Up for an adventure?"}
				},
				new ContactGroup("V", "V"){
					new Contact{ Name = "Vanessa", 
                        ImageUrl = "http://www.picgifs.com/avatars/avatars/flowers-and-nature/avatars-flowers-and-nature-870992.jpg",
						Status = "Ready for a vacation"}
				}
			};

            if(String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Title.StartsWith(searchText));
		}

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
              //get activity indicator at top of screen
            listView.ItemsSource = GetContacts();
              //activity indicator disappears
            listView.EndRefresh();
        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Display Alert", "Add", "OK");
        }

        public ListPage()
        {
            InitializeComponent();
              //initialize list view
            listView.ItemsSource = GetContacts();
        }
    }
}
