using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{

    class Demo
    {
        public static bool ValidateMobile(string mobileno)
        {
            string pattern = @"^[+]91 [6789]\d{9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(mobileno);
              
        }
        static void Main()
        {
            if (ValidateMobile("+91 9568906000"))
            {
                //ErrorInfo.ErrorMessage="Valid Mobile No";
                Console.WriteLine("Valid Mobile No");
            }
            else
             
            Console.WriteLine("Invalid Mobile No");
            Console.ReadKey();
        }
       
    }
}
