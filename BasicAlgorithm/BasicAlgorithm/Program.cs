using System;

namespace BasicAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            SumOfTwoInteger sumOfTwoInteger = new SumOfTwoInteger();
            sumOfTwoInteger.Total(1,2);
            sumOfTwoInteger.Total(2,2);
            Console.WriteLine("------------------------");

            //check two given integers, and return true if one of them is 30 or if their sum is 30
            OrStatement orStatement = new OrStatement();
            orStatement.CheckSum(30, 0);
            orStatement.CheckSum(0, 30);
            orStatement.CheckSum(5, 25);
            orStatement.CheckSum(20, 25);
            Console.WriteLine("------------------------");

            //create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged
            SubString subString = new SubString();
            subString.addIf("this is Dang");
            Console.WriteLine("------------------------");

            //remove the character in a given position of a given string
            RemoveCharFromString removeCharFromString = new RemoveCharFromString();
            removeCharFromString.RemoveChar("This",0);
            removeCharFromString.RemoveChar("This",1);
            removeCharFromString.RemoveChar("This",2);
            removeCharFromString.RemoveChar("This",3);

            //exchange the first and last characters in a given string and return the new string
            SwappingChar swappingChar = new SwappingChar();
            swappingChar.SwapString("This");
            swappingChar.SwapString("Abcd");
            Console.WriteLine("------------------------");


            //create a new string with the last char added at the front and back of a given string of length 1 or more
            AddChar addChar = new AddChar();
            Console.WriteLine(addChar.AddToThis("This"));
            Console.WriteLine("------------------------");

            //check if a given positive number is a multiple of 3 or a multiple of 7
            CheckNumber checkNumber = new CheckNumber();
            checkNumber.CheckThisNumber(3);
            checkNumber.CheckThisNumber(7);
            checkNumber.CheckThisNumber(5);
            Console.WriteLine("------------------------");

            //check the largest number among three given integers.
            CheckLargest checkLargest = new CheckLargest();
            checkLargest.LargestNumber(1,2,3);
            checkLargest.LargestNumber(6, 7, 4);
            checkLargest.LargestNumber(10, 5, 2);
            Console.WriteLine("------------------------");

            //24. convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters
            UpperCase upperCase = new UpperCase();
            upperCase.LastThree("today is my day");
            upperCase.LastThree("day");
            Console.WriteLine("------------------------");

            //28. check if the first appearance of "a" in a given string is immediately followed by another "a"
            CheckForChar checkForChar = new CheckForChar();
            Console.WriteLine(checkForChar.ThisChar("caabb"));
            Console.WriteLine(checkForChar.ThisChar("babaaba"));
            Console.WriteLine(checkForChar.ThisChar("aaaaa"));
            Console.WriteLine("------------------------");

            //Using For loop
            //display the pattern like right angle triangle using an asterisk
            RightAngleTriangle rightAngleTriangle = new RightAngleTriangle();
            rightAngleTriangle.NumberAngle(5);
            rightAngleTriangle.AngleWithNumber(5);
            rightAngleTriangle.AngleWithSameNumber(5);
            rightAngleTriangle.AngleIncreaseByOne(4);
            Console.WriteLine("------------------------");

            //make such a pattern like a pyramid with an asterisk
            Pyramid pyramid = new Pyramid();
            pyramid.PyramidWithStars(5);
            Console.WriteLine("------------------------");


            //calculate the factorial of a given number
            FactorialNumber factorialNumber = new FactorialNumber();
            factorialNumber.InputNumber(5);
            Console.WriteLine("------------------------");

            //to display the n terms of even natural number and their sum
            FindEvenNumber findEvenNumber = new FindEvenNumber();
            findEvenNumber.TotalEvenNumber(10);
            Console.WriteLine("------------------------");
        }
    }
}
