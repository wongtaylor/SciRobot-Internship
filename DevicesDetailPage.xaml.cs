using System;
using System.Collections.Generic;
using System.Diagnostics;
using Devices.Models;
using Xamarin.Forms;

namespace Devices
{
    public partial class DevicesDetailPage : ContentPage
    {
        public DevicesDetailPage(AcroDevices device)
        {
			if (device == null)
				throw new ArgumentNullException();

			BindingContext = device;

            InitializeComponent();
            Configure.IsEnabled = false;
        }

        void Connect_Clicked(object sender, System.EventArgs e)
        {
            Configure.IsEnabled = true;
        }

        void Disconnect_Clicked(object sender, System.EventArgs e)
        {
            Configure.IsEnabled = false;
            MotionSensor.IsEnabled = false;
            MotionData.IsEnabled = false;
            MusicPlayer.IsEnabled = false;
        }

        async void Configure_Clicked(object sender, System.EventArgs e)
        {
            var action = await DisplayActionSheet("Configuring...", "Cancel", null, "Update", "Sync");
            Debug.WriteLine("Action: " + action);
            DisplayAlert("Action", action, "OK");

              //Enable switches under configure
            MotionSensor.IsEnabled = true;
            MotionData.IsEnabled = true;
            MusicPlayer.IsEnabled = true;
        }

        void Sensor_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            if (e.Value == true)
				DisplayAlert("Motion Sensor", "On", "OK");
			else
				DisplayAlert("Motion Sensor", "Off", "OK");
        }

		void Data_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
			if (e.Value == true)
				DisplayAlert("Motion Data", "On", "OK");
			else
				DisplayAlert("Motion Data", "Off", "OK");
		}

		void Music_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
			if (e.Value == true)
				DisplayAlert("Music Player", "On", "OK");
			else
				DisplayAlert("Music Player", "Off", "OK");      
        }
	}
}
