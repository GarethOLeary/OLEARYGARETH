using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyApp
{
	public class ListPageModel 
	{
        public ObservableCollection<ListModel> MyListCollector { get; set; }


        public ListPageModel()
        {


            MyListCollector = new ObservableCollection<ListModel>()
            {
                new ListModel(){id = 1 ,   Country = "Azerbaijan" , City = "Baku" },
                new ListModel(){ id = 2 ,  Country  = "Denmark" , City = "Copenhagen" },
                new ListModel(){ id = 3 ,  Country  = "England" , City = "London" },
                new ListModel(){ id = 4 ,  Country  = "Germany" , City = "Munich" },
                 new ListModel(){id = 5 ,  Country  = "Holland" , City = "Amsterdam" },
                new ListModel(){ id = 6 ,  Country  = "Hungary" , City = "Budapest" },
                new ListModel(){ id = 7 ,  Country  = "Ireland" , City = "Dublin" },
                new ListModel(){ id = 8 ,  Country  = "Italy" , City = "Rome" },
                 new ListModel(){id = 9 ,  Country  = "Romania" , City = "Bucharest" },
                new ListModel(){ id = 10 , Country  = "Russia" , City = "Saint Petersburg" },
                new ListModel(){ id = 11 ,  Country  = "Scotland" , City = "Glasgow" },
                new ListModel(){ id = 12 ,  Country  = "Spain" , City = "Bilbao" }
            };

        }
    }
}