using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class RemoveCharFromString
    {
        public void RemoveChar(string thisSentence, int thisChar)
        {
            // using Remove(int StartIndex, int count ) 
            Console.WriteLine(thisSentence.Remove(thisChar, 1));
        }
    }
}
