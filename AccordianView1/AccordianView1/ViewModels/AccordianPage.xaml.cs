using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccordianView1.ViewModels
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccordianPage : ContentPage
	{
		public AccordianPage ()
		{
			InitializeComponent ();
            BindingContext = new AccordianViewModel();
        }
	}
}