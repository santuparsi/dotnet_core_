using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpression
{
    class Demo15
    {
        static bool ValidateTime(string input)
        {
            string pattern = "^((1[0-2]|0?[1-9]):([0-5][0-9]) ?([AaPp][Mm]))$";
            //string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|\]){8,32}$";
            if (Regex.IsMatch(input, pattern))
                return true;
            else
                return false;
        }
        static bool ValidatePassword(string input)
        {
           string pattern = "^(?=.*[0-9])"
                     + "(?=.*[a-z])(?=.*[A-Z])"
                     + "(?=.*[@#$%^&+=])"
                     + "(?=\\S+$).{8,20}$";
            //string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|\]){8,32}$";
            if (Regex.IsMatch(input, pattern))
                return true;
            else
                return false;
        }
        static bool ValidateUsername(string input)
        {
            string pattern = "^[a-z]{5,10}$";
            if (Regex.IsMatch(input, pattern,RegexOptions.IgnoreCase))
                return true;
            else
                return false;
        }
        public static bool ValidateMobile(string mobileno)
        {
            string pattern = @"^[6789]\d{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mobileno))
                return true;
            else
                return false;
        }

        static void Main()
        {
            if (ValidateTime("5:30 AM"))
            {
                Console.WriteLine("Valid Time");
            }
            else
                Console.WriteLine("Invalid TIme");
        }
    }
}
