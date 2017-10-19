using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetingPage : ContentPage
	{
        public GreetingPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
            var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(0),
                iOS = new Thickness(0, 20, 0, 0)
            };
            Padding = x;
		}
	}
}