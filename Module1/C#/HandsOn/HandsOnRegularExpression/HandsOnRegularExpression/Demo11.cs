using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo11
    {
        static void Main()
        {

            // This will return any character  
            // between x and z inclusive 
            Regex regex = new Regex(@"[x-z]");

            Match match = regex.Match("xmax");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
