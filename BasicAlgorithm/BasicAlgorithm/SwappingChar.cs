using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    //exchange the first and last characters in a given string and return the new string
    public class SwappingChar
    {
        public void SwapString(string thisString)
        {
            // convert string into array
            char[] array = thisString.ToCharArray();

            //using temp to get the first char 
            char temp = array[0];

            //swapping first with last 
            array[0] = array[array.Length - 1];
            
            //initialzation the last with temp
            array[array.Length - 1] = temp;

            Console.WriteLine(array);
        }
    }
}
