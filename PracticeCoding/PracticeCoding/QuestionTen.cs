using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class QuestionTen
    {
        public Boolean IsPrime(int i)
        {
            if ( i == 0 || i == 1)
            {
                return false;
            }

            int counter = 0;
            for (int j = 0; j <= i; j++)
            {
                if ( j % i == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            if(counter != 2)
            {
                return false;
            }
            return true;
        }
    }
}
