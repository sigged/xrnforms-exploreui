using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.ExploreUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Label label = new Label();
            var pfText = new OnPlatform<string>();
            pfText.Platforms.Add(new On { Platform = new List<string> { "iOS" }, Value = "Apples", });
            pfText.Platforms.Add(new On { Platform = new List<string> { "Android" }, Value = "Bots" });
            pfText.Platforms.Add(new On { Platform = new List<string> { "Windows" }, Value = "Windows" });
            label.Text = pfText;
            myLayout.Children.Add(label);

            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    label.BackgroundColor = Color.LightBlue;
                    break;
                case Device.Android:
                    label.BackgroundColor = Color.LightGreen;
                    break;
                default: //windows, winphone and all others
                    label.BackgroundColor = Color.Wheat;
                    break;
            }

        }
    }
}
