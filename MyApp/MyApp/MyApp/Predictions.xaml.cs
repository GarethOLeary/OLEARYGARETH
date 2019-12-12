using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Predictions : ContentPage
	{
       

        public Predictions ()
		{
			InitializeComponent ();
		}

       

        private  void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Do you want to save your prediction", 
                "Save", "Don't Save");
        }

        

        private void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}