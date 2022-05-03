using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class SubString
    {
        public void addIf(string addString)
        {   
            // check the staring of string length contain "If" then print out the string
            // if not, will add "If" at the beginning of the string and print it out
            if (addString.Length > 2 && addString.Substring(0, 2).Equals("If"))
            {
                Console.WriteLine(addString);
            }
            else
            {
                addString = "If " + addString;
                Console.WriteLine(addString);
            }
            


        }
    }
}
