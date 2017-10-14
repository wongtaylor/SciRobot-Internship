using System;
using System.Collections.Generic;
using System.Linq;
using Devices.Models;
using Xamarin.Forms;

namespace Devices
{
    public partial class ListPage : ContentPage
    {
        private static string randstr;

        public ListPage()
        {
            InitializeComponent();

            randstr = " 1";
            listView.ItemsSource = GetDevices(randstr);
        }

        void Switch_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
           label.IsVisible = e.Value;
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, 10);
            randstr = " " + num;

            listView.ItemsSource = GetDevices(randstr);
            listView.EndRefresh();
        }

        IEnumerable<AcroDevices> GetDevices(string str = null)
        {
			var devices = new List<AcroDevices> {
				new AcroDevices{
					Name = "UUID 1",
					BatteryLevel = "100%"},
				new AcroDevices{
					Name = "UUID 2",
					BatteryLevel = "<10%"},
				new AcroDevices{
					Name = "UUID 3",
					BatteryLevel = "50%"
				},
				new AcroDevices{
					Name = "UUID 4",
					BatteryLevel = "75%"
				},
				new AcroDevices{
					Name = "UUID 5",
					BatteryLevel = "20%"
				},
				new AcroDevices{
					Name = "UUID 6",
					BatteryLevel = "90%"
				},
				new AcroDevices{
					Name = "UUID 7",
					BatteryLevel = "50%"
				},
				new AcroDevices{
					Name = "UUID 8",
					BatteryLevel = "70%"
				},
				new AcroDevices{
					Name = "UUID 9",
					BatteryLevel = "60%"
				},
				new AcroDevices{
					Name = "UUID 10",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 20",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 30",
					BatteryLevel = "80%"
				},
                new AcroDevices{
					Name = "UUID 40",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 50",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 55",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 62",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 68",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 63",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 71",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 88",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 92",
					BatteryLevel = "80%"
				},
				new AcroDevices{
					Name = "UUID 87",
					BatteryLevel = "80%"
				}
			};

            if(String.IsNullOrWhiteSpace(str))
                return devices;

            return devices.Where(c => c.Name.Contains(str));
        }

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var device = e.SelectedItem as AcroDevices;
            await Navigation.PushAsync(new DevicesDetailPage(device));

			//deselect the name
			listView.SelectedItem = null;
		}

    }
}
