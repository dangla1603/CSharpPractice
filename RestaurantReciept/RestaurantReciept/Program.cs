using System;

namespace RestaurantReciept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("Taco forever","123 Mainstreet, Racine, 53406",.15);

            Console.WriteLine("Restaurant name: {0}",restaurant.Name);
            Console.WriteLine("Address: {0}",restaurant.Address);
            Console.WriteLine("------------------------------------");
            restaurant.GenerateReceipt();

        }
    }
}
