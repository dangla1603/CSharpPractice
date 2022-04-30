using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneContact
{
    public class Contact
    {
        
        
        // empty constructor
        public Contact()
        {

        }

        // constructor with parameters
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }


        public string Name { get; set; }
        public string Number { get; set; }

    }

}
