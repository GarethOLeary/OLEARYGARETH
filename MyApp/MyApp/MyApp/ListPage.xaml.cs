using MyApp.countrypages;
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
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
            BindingContext = new ListPageModel();
        }

        async private void Flowlistview_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            

            var selecteditem = e.Item as ListModel;

            switch (selecteditem.id)
            {

                case 1:
                    await Navigation.PushAsync(new Page1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Page2());
                    break;
                case 3:
                    await Navigation.PushAsync(new Page3());
                    break;
                case 4:
                    await Navigation.PushAsync(new Page4());
                    break;
                case 5:
                    await Navigation.PushAsync(new Page5());
                    break;
                case 6:
                    await Navigation.PushAsync(new Page6());
                    break;
                case 7:
                    await Navigation.PushAsync(new Page7());
                    break;
                case 8:
                    await Navigation.PushAsync(new Page8());
                    break;
                case 9:
                    await Navigation.PushAsync(new Page9());
                    break;
                case 10:
                    await Navigation.PushAsync(new Page10());
                    break;
                case 11:
                    await Navigation.PushAsync(new Page11());
                    break;
                case 12:
                    await Navigation.PushAsync(new Page12());
                    break;




            }
            ((ListView)sender).SelectedItem = null;
        }

        
    }
}