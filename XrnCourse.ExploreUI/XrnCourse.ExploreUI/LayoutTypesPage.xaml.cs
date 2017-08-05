using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.ExploreUI.LayoutPages;

namespace XrnCourse.ExploreUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LayoutTypesPage : ContentPage
	{
		public LayoutTypesPage ()
		{
			InitializeComponent ();
		}

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnStackLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void btnGridLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayoutPage());
        }

        private async void btnAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void btnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }
    }
}