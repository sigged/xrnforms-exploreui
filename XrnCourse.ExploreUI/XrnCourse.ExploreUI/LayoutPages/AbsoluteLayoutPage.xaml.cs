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
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationX -= 10;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationY -= 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationX += 10;
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationY += 10;
        }
    }
}