using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.LayoutPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
        }

        private void sliderA_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtSliderA.Text = sliderA.Value.ToString("N0");
        }

        private void txtSliderA_Completed(object sender, EventArgs e)
        {
            int sliderVal = 0;
            if (int.TryParse(txtSliderA.Text, out sliderVal))
                sliderA.Value = sliderVal;
            else
                txtSliderA.Text = sliderA.Value.ToString("N0");
        }
    }
}