using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class CheckForChar
    {
        public bool ThisChar(string str)
        {
            var counter = 0;
            for( var index =0; index < str.Length;index++)
            {
                if (str[index].Equals("a")) counter++;
                if (str.Substring(index, 2).Equals("aa") && counter <2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
