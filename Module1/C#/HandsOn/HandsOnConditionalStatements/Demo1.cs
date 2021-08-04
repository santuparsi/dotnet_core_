using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Demo1
    {
        static void Main()
        {
            int no = 12;
            if (no % 2 == 0)
            {
                Console.WriteLine("{0} is even", no);
            }
            else
                Console.WriteLine("{0} is Odd", no);
            int a = 100;
            int b = 90;
            if(a>b)
            {
                Console.WriteLine("{0} is Max", a);
                Console.WriteLine("{0} is Min", b);
            }
            else
            {
                Console.WriteLine("{0} is Max", b);
                Console.WriteLine("{0} is Min", a);
            }
        }
    }
}
