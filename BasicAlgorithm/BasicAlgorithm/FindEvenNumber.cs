using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class FindEvenNumber
    {
        public void TotalEvenNumber ( int num)
        {
            int sum = 0;
            Console.Write("Even numbers are: ");
            for ( int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }              
            }
            Console.WriteLine("\ntotal of even numbers is : {0}",sum);
        }
    }
}
