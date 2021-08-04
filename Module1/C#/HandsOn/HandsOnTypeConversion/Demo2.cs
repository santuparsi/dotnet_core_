using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo2
    {
        static void Main()
        {
            //using Parse() method
            //Parse() method convert string to any premitive data type value
            string s = "123";
            int i = int.Parse(s);
            short s1 = short.Parse(s);
            byte b = byte.Parse(s);
            double d = double.Parse(s);
            float f = float.Parse("234.45");
            decimal dm = decimal.Parse(s);
            //i = int.Parse("ACBB"); exception
           string s11= "true";
            bool b11 = bool.Parse(s11);
            string s12 = "D";
            char ch = char.Parse(s12); //convert string into char.
            Console.WriteLine(f);
            Console.WriteLine(ch);
            Console.WriteLine(i);
        }
    }
}
