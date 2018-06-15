using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccordianView1.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        public void OnXamlClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new XamlExample());

        }
        public void OnCodeClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new CodeEaxmple());

        }
    }
}