using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    //create a new string with the last char added at the front and back of a given string of length 1 or more
    public class AddChar
    {
        public string AddToThis(string simple)
        {
            //get the last char from string
            var s = simple.Substring(simple.Length - 1);
            //return adding the last char into first and last position of the string
            return s + simple + s;
        }
    }
}
