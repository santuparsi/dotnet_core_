using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo05
    {
        // Main Method 
        static void Main()
        {

            // This return any pattern like b, ab 
            Regex regex = new Regex(@"a?b");

            Match match = regex.Match("aaaabcd");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
