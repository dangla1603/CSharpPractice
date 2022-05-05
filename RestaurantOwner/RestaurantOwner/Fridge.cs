using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOwner
{
    public class Fridge
    {
        //variables
        private string foodName;
        private int foodID;

        //properties
        public string FoodName { get; set; }
        public int FoodID { get; set; }

        //constructor
        public Fridge() { }
        
        public Fridge(int foodID, string foodName)
        {
            FoodName = foodName;
            FoodID = foodID;
        }
    }
}
