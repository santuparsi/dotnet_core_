using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6_NewFeatures
{
    //Expression–Bodied Methods
    class Demo08
    {
       //public static string Greet(string name)
       // {
       //     return name;
       // }
        public static string Greet(string name) => "Hello " + name;
        public static double Square(double d) => d * d;
        static void Main()
        {
            Console.WriteLine(Greet("Sachin"));
            Console.WriteLine(Square(12));
        }
    }
}
