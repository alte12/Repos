using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercice_1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        int x;
        Random rnd;
        string[] quotes;
        public QuotesPage ()
		{
			InitializeComponent ();
            quotes = new string[10];
            rnd = new Random();
            quotes[0] = "Don't cry because it's over, smile because it happened.";
            quotes[1] = "Be yourself; everyone else is already taken.";
            quotes[2] = "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.";
            quotes[3] = "So many books, so little time.";
            quotes[4] = "Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind.";
            quotes[5] = "A room without books is like a body without a soul.";
            quotes[6] = "You know you're in love when you can't fall asleep because reality is finally better than your dreams.";
            quotes[7] = "You only live once, but if you do it right, once is enough.";
            quotes[8] = "Be the change that you wish to see in the world.";
            quotes[9] = "In three words I can sum up everything I've learned about life: it goes on.";
            showQuote();
        }

        void showQuote()
        {        
            x = rnd.Next(0, 9);
            label.Text = quotes[x];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            showQuote();
        }
    }
}