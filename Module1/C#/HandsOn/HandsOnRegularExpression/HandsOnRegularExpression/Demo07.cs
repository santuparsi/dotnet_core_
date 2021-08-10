using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo07
    {
        public static void Main()
        {

            // This return parth if it 
            // exist at the end of the line 
            Regex regex = new Regex(@"Parth$");

            Match match = regex.Match("My name is Parth");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
