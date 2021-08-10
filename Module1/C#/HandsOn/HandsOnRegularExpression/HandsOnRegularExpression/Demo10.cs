using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo10
    {
        // Main Method 
        static void Main()
        {

            // This will return one character either 
            // a or b or c which will come first 
            Regex regex = new Regex(@"[abc][a-z]{2,}");

            Match match = regex.Match("abcdef890");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
