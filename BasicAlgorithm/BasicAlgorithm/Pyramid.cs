using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class Pyramid
    {
        /// <summary>
        ///                     1   2   3   4   5
        ///                     
        ///                 1           *
        ///                 
        ///                 2         *   *   
        ///                 
        ///                 3       *   *   *   
        ///                 
        ///                 4     *   *   *   *      
        /// 
        /// 
        /// </summary>
        public void PyramidWithStars(int row)
        {
            for (int i = 1; i <= row; i++) // Total number of layer for pramid  
            {
                for (int space = 1; space <= (row - i); space++) // Loop For Space  
                    Console.Write(" ");
                for (int number = 1; number <= i; number++) //increase the value  
                    Console.Write(number);
                for (int number = (i - 1); number >= 1; number--) //decrease the value  
                    Console.Write(number);
                Console.WriteLine();
            }
        }
    }
}
