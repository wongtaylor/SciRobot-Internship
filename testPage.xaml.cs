using Xamarin.Forms;
using AudioManager;
using System.IO;
using System;

namespace test
{
    public partial class testPage : ContentPage
    {
        int count = 0;
        public testPage()
        {
            InitializeComponent();
		}

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            Button btn = (Button)sender;
            string str = btn.Text;
            string sound = soundEffect(str);

            if(count != 2){
				  //greys out button to show it was pressed
                btn.TextColor = Color.FromRgb(160, 160, 160);
				btn.BackgroundColor = Color.FromRgb(160, 160, 160);
			      // background music on a loop 
                await Audio.Manager.PlayBackgroundMusic(sound);
			}
            else{
                  //Stops music when button is pressed again (count is 2)
				Audio.Manager.StopBackgroundMusic();
                  //resets color of button
                btn.TextColor = Color.FromRgb(51, 153, 255);
                btn.BackgroundColor = Color.FromRgb(51, 153, 255);
				  //Reset count to 0
                count = 0;	
			}
        }

		//Method that identifies the mp3 file name of the sound button pressed
		public string soundEffect(string str)
		{
			switch (str)
			{
				case "Shake":
					return "Tambourine.mp3";
				case "ClapTap":
					return "Cimbal.mp3";
				case "Knock":
					return "Boing.mp3";
				case "Rollwrists":
					return "waves.mp3";
				case "Lasso":
					return "FastWoosh.mp3";
				case "Figure8":
					return "wind-chime.mp3";
				case "RaiseArms":
					return "upXylophone.mp3";
				case "LowerArms":
					return "downXylophone.mp3";
				case "SwayArms":
					return "morningBirds.mp3";
			}
			return " ";
		}
    }
}
