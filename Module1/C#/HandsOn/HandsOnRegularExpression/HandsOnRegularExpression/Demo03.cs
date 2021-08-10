using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo03
    {
        static void Main()
        {
            // This will return any  
            // pattern b, ab, aab, ... 
            Regex regex = new Regex(@"a*b");

            Match match = regex.Match("ccaaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
