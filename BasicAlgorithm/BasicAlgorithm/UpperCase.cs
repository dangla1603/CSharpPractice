using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class UpperCase
    {
        public void LastThree(string str)
        {

            // Operand1 ? Operand2 : Operand 3
            // if str.length <3 -> upper str
            // if not, remove last 3 and add upper last 3
            //return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();

            //using if statement
            if (str.Length < 3)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.Remove(str.Length-3) + str.Substring(str.Length-3).ToUpper());
            }

        }
    }
}
