using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class CheckNumber
    {
        public void CheckThisNumber(int x)
        {
            ;
            if(x % 3 == 0 || x % 7 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
