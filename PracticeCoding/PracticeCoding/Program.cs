﻿using System;

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
            /// </summary>
            /// Question 1
            /// because string is immutable so we need to use .ToCharArray() method to convert string into charArray
            /// using for loop to loop through each char of the array
            /// </summary>
            QuestionOne answerOne = new QuestionOne();
            Console.WriteLine("Answer for Question 1 is: ");
            answerOne.ReverseString("Hello");
            Console.WriteLine("-----------------------------");

            /// </summary>
            /// Question 2
            /// Definition of Palindrome that is a word or sequence that reads the same backward as forward
            /// example: madam , racecar
            /// to solve this problem, we need to use given string, reverse it using for loop and store it into temp variable
            /// then we compare the original value with temp variable, if they are equal then the string is Palindrome
            /// </summary>
            QuestionTwo answerTwo = new QuestionTwo();
            Console.WriteLine("Answer for Question 2 is: ");
            answerTwo.Palindrome("madam");
            answerTwo.Palindrome("Father");
            Console.WriteLine("-----------------------------");

            /// </summary>
            /// Question 10
            /// To solve this problem. We know 0 and 1 is not prime, so we need condition to check if the number is equal 0 or 1,
            /// if yes, we stop. if not, we move to next step. At this step, we will use for loop, we know the number is prime if it has 1 and
            /// number itself which is 2. so if the given number % the increment number from for loop = 2 -> that number is prime
            /// 
            /// </summary>
            QuestionTen answerTen = new QuestionTen();
            Console.WriteLine("Answer for Question 10 is: ");
            int test1 = 3;
            int test2 = 2;
            if (answerTen.IsPrime(test1))
            {
                Console.WriteLine("It is Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            if (answerTen.IsPrime(test2))
            {
                Console.WriteLine("It is Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            
            Console.WriteLine("-----------------------------");
            /// </summary>
            /// Question 12
            /// To solve this problem. First, we need to initial Largest = 0 & SecondLargest = 0, then we use for loop to loop through the length
            /// Of the array. We set the condition, if current index > largest, we will initial the current secondLargest to current Largest and 
            /// current largest will equal to current index and so on. We also need another condition to see if the current index is larger than 
            /// current secondLargest and smaller than current Largest.
            /// </summary>
            QuestionTwelve answerTwelve = new QuestionTwelve();
            int[] thisInt = { 5,3,4 };
            Console.WriteLine("Answer for Question 12 is: ");
            answerTwelve.SecondLarge(thisInt);
            Console.WriteLine("-----------------------------");
            // the method to indicate even or odd numbers from the list
            // if list has even number, add 1
            // if list has odd number, add 3
            // if list has number 8 , add 5
            // print out total count
            int[] a = new int[] {8,8} ;

            

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
