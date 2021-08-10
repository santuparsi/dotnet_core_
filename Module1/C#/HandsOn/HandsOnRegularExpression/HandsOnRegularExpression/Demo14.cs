using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo14
    {
        static void Main()
        {

            // This will either d or e  
            // which ever comes first 
            Regex regex = new Regex(@"d|e");

            Match match = regex.Match("dedge");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
