using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class I
    {
        public I()
        {
            Console.WriteLine("I is base Class");
        }
    }
    class J:I
    {
        public J()
        {
            Console.WriteLine("J is Derive Class ");
        }
    }
    class Demo3
    {
        static void Main()
        {
            J obj = new J(); //first base class constructor executed then derivec class construnctor executed.
            

        }
    }
}
