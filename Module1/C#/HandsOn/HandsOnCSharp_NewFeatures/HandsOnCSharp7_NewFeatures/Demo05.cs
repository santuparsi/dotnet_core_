using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace HandsOnCSharp7_NewFeatures
{
    class Demo05
    {
        //enhancements for out
        static void Main()
        {
            string s = "26-Novvvv-2016";
            if (DateTime.TryParse(s, out DateTime date))
            {
                WriteLine(date);
            }
            WriteLine(date);
          
        }
    }

}
