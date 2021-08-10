﻿using System;
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
            if (regex.IsMatch(mobileno))
                return true;
            else
                return false;
        }
        static void Main()
        {
            if (ValidateMobile("+91 956890000"))
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
