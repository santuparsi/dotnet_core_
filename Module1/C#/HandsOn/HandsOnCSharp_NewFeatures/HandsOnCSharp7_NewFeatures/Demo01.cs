using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp7_NewFeatures
{
    //Local functions or nested functions
    class Demo01
    {
        static void f()
        {
           string Greet(string name)
            {
                return "Hello " + name;
            }
            Console.WriteLine(Greet("ROhan"));
        }
        
        static void Main(string[] args)
        {
            void Add(int x, int y)
            {
                WriteLine($"Sum of {x} and {y} is : {x + y}");
            }
            void Multiply(int x, int y)
            {
                WriteLine($"Multiply of {x} and {y} is : {x * y}");
                Add(30, 10);
            }
            Add(20, 50);
            Multiply(20, 50);
        }
    }
}
