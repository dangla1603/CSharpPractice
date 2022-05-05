using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOwner
{
    public class RestaurantAccount
    {
        //variable
        private List<Account> accounts { get; set; } = new List<Account>();

        private List<Fridge> fridge { get; set; } = new List<Fridge>();

        //method to create account
        public void addAccount(Account account)
        {
            accounts.Add(account);

        }
        
        public string GetUserName(string name)
        {
            return name.ToString();
        }

        public string getPassword(Account pass)
        {
            return pass.ToString();
        }

        public void DisplayInformation()
        {
            foreach( var a in accounts)
            {
                a.displayInformation();
            }
        }
    }
}
