using System;

namespace Condition_Statement_Practice
{
    //Writing if-else statment that takes two integer variables and print the higher one.
    class CompareVariable
    {
        public int x;
        public int y;
        public void HigherVariable(int x, int y)
        {
            // check the condition to see if x > y
            if(x > y)
            {
                Console.WriteLine("The answers is: " + x);
            }
            else
            {
                Console.WriteLine("The answers is: " + y);
            }
        }
    }

    //Writing statement that comparing three integer variables and print the highest one.
    class HighestVariable
    {
        public int a;
        public int b;
        public int c;

        public void BigNumber(int a, int b, int c)
        {
            if ( a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("bigest number is : " + a);
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine("Bigest number is: " + b);
                }
                else
                {
                    Console.WriteLine("Bigestt number is " + c);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
       /*     // Initialize the CompareVariable Class
            CompareVariable compareVariable = new CompareVariable();

            //input the first variable
            Console.WriteLine("Please Enter first variable: ");
            int x = int.Parse(Console.ReadLine());

            //input the second variable
            Console.WriteLine("Please Enter second variable: ");
            int y = int.Parse(Console.ReadLine());

            //print out the result
            compareVariable.HigherVariable(x,y);*/


            //initialize the HighestVariable class
            HighestVariable highestVariable = new HighestVariable();

            //input the first variable
            Console.WriteLine("Please Enter first variable: ");
            int a = int.Parse(Console.ReadLine());

            //input the second variable
            Console.WriteLine("Please Enter first variable: ");
            int b = int.Parse(Console.ReadLine());

            //input the third variable
            Console.WriteLine("Please Enter first variable: ");
            int c = int.Parse(Console.ReadLine());

            //print out result
            highestVariable.BigNumber(a,b,c);
        }


    }
    
}
