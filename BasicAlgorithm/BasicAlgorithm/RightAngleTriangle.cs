using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class RightAngleTriangle
    {
        /// <summary>
        ///                     1   2   3   4   5
        ///                     
        ///                 1   *
        ///                 
        ///                 2   *   *
        ///                 
        ///                 3   *   *   *
        ///                 
        ///                 4   *   *   *   *
        ///                 
        ///                 5   *   *   *   *   *
        /// 
        ///                 Row number
        ///                 1   ->  1
        ///                 2   ->  2
        ///                 3   ->  3
        /// 
        /// 
        /// 
        /// </summary>

        public void NumberAngle(int row)
        {
            // first loop for row number
            for (int i = 1; i <= row; i++)
            {
                // second loop for column number
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");
            }
        }

        //display the pattern like right angle triangle with a number
        public void AngleWithNumber(int row)
        {
            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }

        //make such a pattern like right angle triangle with a number which will repeat a number in a row
        public void AngleWithSameNumber(int row)
        {
            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }

        public void AngleIncreaseByOne(int row)
        {
            int num = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.Write("\n");
            }
        }
    }
}
