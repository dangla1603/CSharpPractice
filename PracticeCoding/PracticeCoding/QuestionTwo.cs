using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class QuestionTwo
    {
        public void Palindrome(string str)
        {
            char[] array = str.ToCharArray();
            string newStr = string.Empty;
            for (int index = array.Length - 1; index >= 0; index--)
            {
                newStr += array[index];
            }

            if ( str == newStr)
            {
                Console.WriteLine("{0} is Palidrome",str);
            }
            else
            {
                Console.WriteLine("{0} is not Palidrome",str);
            }
        }
    }
}
