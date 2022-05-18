using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class QuestionOne
    {
        public void ReverseString(string str)
        {
            char[] array = str.ToCharArray();
            string newStr = string.Empty;

            for( int index = array.Length-1; index >= 0; index--)
            {
                newStr += array[index];
            }

            Console.WriteLine(newStr);
        }
    }
}
