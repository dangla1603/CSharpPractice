using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReciept
{
    public class Restaurant
    {
        // normally when we declare attributes of the class
        // we set the instance variables as private

        //instance variables
        private string name;
        private string address;
        private double gratuityRate;

        //properties
        public string Name { get; set; }

        public string Address { get; set; }


        //not allow negative value
        public double GratuityRate
        {
            get
            {
                return gratuityRate;
            }
            set {
                if (value > 0)
                {
                    gratuityRate = value;

                }
            } 
        }



        public Restaurant(){}

        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;

        }


        public void GenerateReceipt()
        {
            // because price is local variable so it doesn't come with default value
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;
            int people;

            while (price != -1)
            {
                subtotal += price;
                Console.WriteLine("Enter price of food item: [ -1 to quit ] ");
                price = Convert.ToDouble(Console.ReadLine());
                
            }

            // check the number in party
            Console.WriteLine("------------------------------");
            Console.WriteLine("Number people in the party: ");
            
            people = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");

            if (people >= 6) {
                gratuityAmount = subtotal * gratuityRate;
            }

            grandTotal = subtotal + gratuityAmount;


            // formal :C for currency, :P for percentage
            Console.WriteLine("Subtotal: {0:C}", subtotal);
            Console.WriteLine("{0:P} Gratuity : {1:C}",gratuityRate, gratuityAmount);
            Console.WriteLine("Total:{0:C} ", grandTotal);

        }

    }
}
