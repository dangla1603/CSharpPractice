using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class OrStatement
    {
        //check two given integers, and return true if one of them is 30 or if their sum is 30
        public void CheckSum(int x, int y)
        {
            int sumThis = x + y;

            if (x == 30 || y == 30 || sumThis == 30)
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
