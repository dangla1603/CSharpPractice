using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;                                      // Declaration
            x = 123;                                    // initialization

            int y = 12345;                              // declaration + initialization

            int age = 21;                               // integer
            double height = 300.5;                      // decimal number
            char gender = 'm';
            string name = "John";


            // constants = immutable values which are known at compile time
            //             and do not change for the life of the program

            const double pi = 3.14;


            // type casting = converting a value to a different data type
            //                useful when we accept user input (string)
            //                different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            //convert integer to string
            int e = 1234;
            string f = Convert.ToString(e);

            /*Console.WriteLine(f);

            Console.ReadKey();*/


            //----------------------------------------------------//
            // User input

            Console.WriteLine("What is your name ? ");
            //Readline() is used to read some input
            String myName = Console.ReadLine();

            Console.WriteLine("What is your name ? ");
            //Readline() is used to read some input
            int myAge = Convert.ToInt32(Console.ReadLine());


            /*Console.WriteLine("Hello " + myName);
            Console.ReadKey();*/

            //----------------------------------------------------//
            // Arithmetric operators

            int number = 5;

            // there are 3 different ways to increment a variable

            // number = number + 1;
            // number += 1;
            // number++;


            // finding remainder

            int remainder = number % 2; 
        }
    }
}
