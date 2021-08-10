using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo06
    {
        // Main Method 
        static void Main()
        {

            // This will return if shyam exist 
            // at the beginning of the line 
            Regex regex = new Regex(@"^Shyam");

            Match match = regex.Match("Shyam is my pet name");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
