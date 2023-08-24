using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOfGroceryItemsDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> GroceryPriceDetails { get; set; }

        public ViewModel()
        {
            GroceryPriceDetails = new ObservableCollection<Model>();
            GroceryPriceDetails.Add(new Model() { GroceryItems = "Milk (1 L)", USPrice = 1.03, UKPrice = 1.05 });
            GroceryPriceDetails.Add(new Model() { GroceryItems = "White Bread (500 g)", USPrice = 3.54, UKPrice = 1.08 });
            GroceryPriceDetails.Add(new Model() { GroceryItems = "White Rice (1 kg)", USPrice = 4.56, UKPrice = 1.42 });
            GroceryPriceDetails.Add(new Model() { GroceryItems = "Eggs (12)", USPrice = 4.40, UKPrice = 2.27 });
            GroceryPriceDetails.Add(new Model() { GroceryItems = "Chicken Fillets(1 kg)", USPrice = 12.00, UKPrice = 5.89 }); ;
            GroceryPriceDetails.Add(new Model() { GroceryItems = "Cheese (1 kg)", USPrice = 12.87, UKPrice = 6.13 });
            GroceryPriceDetails.Add(new Model() { GroceryItems = "Beef Round (1 kg)", USPrice = 15.21, UKPrice = 9.15 });

          
        }
    }
}
