using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo04
    {
        public static void Main()
        {

            // this will return any pattern 
            // like ab, aab, aaab, .... 
            Regex regex = new Regex(@"a+b");
            Match match = regex.Match("caaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
       
}

