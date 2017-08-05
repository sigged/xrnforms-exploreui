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
    public partial class TabsExamplePage : TabbedPage
    {
        public TabsExamplePage()
        {
            InitializeComponent();
        }

        private void btnFirstTab_Clicked(object sender, EventArgs e)
        {
            CurrentPage = this.Children[0];
        }
    }
}