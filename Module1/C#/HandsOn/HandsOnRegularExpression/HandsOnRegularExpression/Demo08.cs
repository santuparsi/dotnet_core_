using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo08
    {
        static void Main()
        {
            // This will return any word which  
            // contains only one letter between  
            // s and t 
            Regex regex = new Regex(@"s..t");

            Match match = regex.Match("This is my seat");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
    }
}
