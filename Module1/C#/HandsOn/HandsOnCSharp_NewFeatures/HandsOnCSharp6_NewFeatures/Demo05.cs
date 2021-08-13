using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6_NewFeatures
{
    class Demo05
    {
        //string interpolation
        static void Main()
        {
            string FirstName = "Nitin";
            string LastName = "Pandit";
            Console.WriteLine("{0}--{1}", FirstName, LastName);

            // With String Interpolation in C# 6.0  
            string output = $"{FirstName}-{LastName}";
            Console.WriteLine(output);
            Console.WriteLine($"{FirstName}--{LastName}");
          
            int a = 10;
            int b = 20;
            Console.WriteLine($"{a}*{b}={a*b}");
            int n = 5;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{n}*{i}={n * i}");
                Console.WriteLine("{0}*{1}={2}", n, i, (n * i));
            }
            Console.ReadKey();
        }
    }
}
