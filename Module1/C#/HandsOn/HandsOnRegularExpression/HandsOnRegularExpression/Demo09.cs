using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo09
    {
        static void Main()
        {
            // This will the return 
            // the one digit character 
            Regex regex = new Regex(@"\d{2}");

            Match match = regex.Match("I am 19 years old");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

        }
    }
}
