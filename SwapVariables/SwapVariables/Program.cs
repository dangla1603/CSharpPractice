using System;

namespace SwapVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To be able to swap variables
            // using a temporary variable 
            /*define swap(x,y)
                temp:= x
                x:=y
                y:=temp*/

            int num1, num2, tempNum;

            Console.Write("\nInput first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput second number: ");
            num2 = int.Parse(Console.ReadLine());

            tempNum = num1;
            num1 = num2;
            num2 = tempNum;

            //Printing result after swapping
            Console.Write("\nResult: ");
            Console.Write("\nfirst Number: " + num1);
            Console.Write("\nsecond Number: " + num2);
        }
    }
}
