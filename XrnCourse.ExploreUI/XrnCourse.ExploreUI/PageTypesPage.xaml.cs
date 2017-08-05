using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTypesPage : ContentPage
    {
        public PageTypesPage()
        {
            InitializeComponent();
        }

        private async void btnNavigationPage_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation page?", 
                @"Guess what..\n
You're using a navigation page right now!

Just click one of the button below and watch it happen.", 
                "A'ight");
        }

        private async void btnTabbedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabsExamplePage());
        }

        private async void btnMasterDetailPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterDetailExamplePage());
        }

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        
    }
}