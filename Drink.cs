using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Drink
    {
        public string DrinkItem { get; set; }
        public string DrinkPrice { get; set; }

        public Drink(string drinkItem, string drinkPrice)
        {
            this.DrinkItem = drinkItem;
            this.DrinkPrice = DrinkPrice;
        }

        public Drink()
        {

        }
    }
}
