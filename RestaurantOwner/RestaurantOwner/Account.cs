using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOwner
{
    public class Account
    {
        //variables
        private string userName;
        private string password;

        //properties
        public string UserName { get; set; }
        public string Password { get; set; }

        //Constructor
        public Account() { }

        public Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        // toString
        public void displayInformation()
        {
            Console.WriteLine("UserName: {0}", UserName);
            Console.WriteLine("Password: {0}", Password);
            Console.WriteLine("-----------------------");
        }
    }
}
