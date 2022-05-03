using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class CheckLargest
    {
        public void LargestNumber(int a, int b, int c) 
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
            }else if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
