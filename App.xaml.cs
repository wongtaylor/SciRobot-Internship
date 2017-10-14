using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticeXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Tabbed feature
            MainPage = new MainPage();

            //List of contacts
            //MainPage = new ListPage();

            //Navigation between welcome and introduction pages
             /*MainPage = new NavigationPage(new WelcomePage())
             {
                 BarTextColor = Color.White,
                 BarBackgroundColor = Color.Gray
             };
             */

              //simple master detail
            //MainPage = new NavigationPage(new ContactsPage());
        }
    }
}
