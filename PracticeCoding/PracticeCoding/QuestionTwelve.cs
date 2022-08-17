using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class QuestionTwelve
    {
        public void SecondLarge(int[] array)
        {
            int largest = 0;
            int secondLargest = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }else if ( array[i] > secondLargest && array[i] < largest)
                {
                    secondLargest = array[i];
                }
            }
            Console.WriteLine(largest);
            Console.WriteLine(secondLargest);
            
        }
    }
}
