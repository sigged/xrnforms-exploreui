using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.ViewTypePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextualViewsPage : ContentPage
    {
        public TextualViewsPage()
        {
            InitializeComponent();

            lblSmallNamed.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
        }

        private void txtChat_Completed(object sender, EventArgs e)
        {
            txtReverseChat.Text = new string(txtChat.Text.ToCharArray().Reverse().ToArray());
        }

        private void txtChat_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblNumberChars.Text = $"{e.NewTextValue.Length} chars";
        }
    }
}