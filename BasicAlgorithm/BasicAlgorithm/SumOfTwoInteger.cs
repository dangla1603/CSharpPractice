using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
     class SumOfTwoInteger
    {

        //compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
        public void Total(int x, int y)
        {
            
            int sum = x+y;

            if (x == y)
            {
                sum = sum * 3;
            }
            else
            {
                sum = x + y;
            }
            Console.WriteLine("sum is: {0}",sum);
        }

        
    }
}
