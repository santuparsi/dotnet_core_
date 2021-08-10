using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo12
    {
        static void Main()
        {

            // This will return other x, 
            // y and z character 
            Regex regex = new Regex(@"[^x-z]");

            Match match = regex.Match("xmax");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
