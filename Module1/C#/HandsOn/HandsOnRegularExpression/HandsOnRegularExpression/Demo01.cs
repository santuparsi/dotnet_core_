using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo01
    {
        static void Main()
        {
            // Input strings to Match 
            // valid mobile number 
            string[] str = {"9925612824",
          "8238783138", "028-1245-1830"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                            isValidMobileNumber(s) ? "is" : "is not");
            }

            Console.ReadKey();
        }
        // method containing the regex 
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[6-9][0-9]{9}$)|(^\+[0-9]{2}\s+[0-9]\s+
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            // Class Regex Repesents an 
            // immutable regular expression. 
            //   Format                Pattern 
            // xxxxxxxxxx           ^[0 - 9]{ 10}$ 
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$ 
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$ 
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate 
            // a string or to ensure that a string 
            // conforms to a particular pattern. 
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
    }
}
