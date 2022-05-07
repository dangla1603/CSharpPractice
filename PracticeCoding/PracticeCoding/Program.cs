using System;

namespace PracticeCoding
{
    internal class Program
    {
        /// <summary>
        ///     QUESTIONS: 
        ///     1: How to reverse a string?
        ///     2: How to find if the given string is a palindrome or not?
        ///     3: How to reverse the order of words in a given string?
        ///     4: How to reverse each word in a given string?
        ///     5: How to count the occurrence of each character in a string?
        ///     6: How to remove duplicate characters from a string?
        ///     7: How to find all possible substring of a given string?
        ///     8: How to perform Left circular rotation of an array?
        ///     9: How to perform Right circular rotation of an array?
        ///     10: How to find if a positive integer is a prime number or not?
        ///     11: How to find the sum of digits of a positive integer?
        ///     12: How to find second largest integer in an array using only one loop?
        ///     13: How to find third largest integer in an array using only one loop?
        ///     14: How to convert a two-dimensional array to a one-dimensional array?
        ///     15: How to convert a one-dimensional array to a two-dimensional array?
        ///     16: How to find the angle between hour and minute hands of a clock at any given time?
        ///     17: Explain Bubble Sort Algorithm In C#
        ///     18: Explain Quick Sort Algorithm In C#
        ///     19: Explain Merge Sort Algorithm In C#
        ///     20: Explain Insertion Sort Algorithm In C#
        ///     21: Explain Selection Sort Algorithm In C#
        ///     22: Explain Binary Search In C#
        /// </summary>

        static void Main(string[] args)
        {

            int[] a = new int[] {8,8} ;

            Console.WriteLine(find_total(a));

        }

        public static int find_total(int[] my_numbers)
        {
            int total = 0;
            int evenNumber = 0;
            int oddNumber = 0;
            int encounter = 0;
            Console.WriteLine(my_numbers.Length);
            for (int index = 0; index < my_numbers.Length; index++)
            {
               
                if (my_numbers[index] % 2 == 0 && my_numbers[index] != 8)
                {
                    evenNumber += 1;
                }
                else if (my_numbers[index] % 2 != 0)
                {
                    oddNumber += 3;
                }else if (my_numbers[index] == 8)
                    {
                    encounter += 5;
                    }
                total = evenNumber + oddNumber + encounter;

            }
            return total;
        }
    }
}
