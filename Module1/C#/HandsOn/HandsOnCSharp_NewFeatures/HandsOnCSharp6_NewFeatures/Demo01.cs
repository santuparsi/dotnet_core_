using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace HandsOnCSharp6_NewFeatures
{
    //using static
    class Demo01
    {
        static void Main()
        {
            WriteLine("Enter ID");
            int i = ToInt32(ReadLine());
            WriteLine("ID: " + i);
        }
    }
}
