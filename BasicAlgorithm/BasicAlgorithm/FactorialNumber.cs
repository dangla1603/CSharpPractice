using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    /// <summary>
    ///     formula for Factorial 
    ///     
    ///     n! = n * (n -1)!
    ///     
    ///     for example:
    ///     5! = 5 * 4 * 3 * 2 * 1
    ///     
    /// </summary>
    public class FactorialNumber
    {
        public void InputNumber (int number)
        {
            int total = 1;
            for (int i = 1; i <= number ; i++)
            {
               total *= i;
                
            }
            Console.WriteLine("The Factorial of {0} is: {1}\n", number, total);
        }
    }
}
