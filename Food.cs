using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Food
    {
        public string FoodItem { get; set; }
        public string FoodPrice { get; set; }

        public Food(string foodItem, string foodPrice)
        {
            this.FoodItem = foodItem;
            this.FoodPrice = FoodPrice;
        }

        public Food()
        {

        }


    }
}
