using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo02
    {
        static void Main(string[] args)
        {

            // Input strings for Match 
            // valid E-mail address. 
            string[] str = {"san@gmail.com",
                  "sangmail.com",
                            "@gmail.com"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    isValidEmail(s) ? "is" : "is not");
            }

        }
        // Method to check the Email ID 
        public static bool isValidEmail(string inputEmail)
        {

            // This Pattern is use to verify the email 
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
