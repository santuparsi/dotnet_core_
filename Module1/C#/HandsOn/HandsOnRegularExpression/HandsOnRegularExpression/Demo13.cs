using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo13
    {
        static void Main()
        {

            // This will return pattern  
            // will cd, cdcd, cdcdcd, ... 
            Regex regex = new Regex(@"(cd)+");

            Match match = regex.Match("cdcdcde");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
