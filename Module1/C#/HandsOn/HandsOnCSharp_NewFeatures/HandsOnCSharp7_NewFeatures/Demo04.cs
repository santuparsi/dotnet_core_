using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp7_NewFeatures
{
    //Pattern matching
    class Demo04
    {
        static void Main(string[] args)
        {
            //Example 1   
            dynamic myData = 1;
            var myData2 = myData is string ? "String" : "Not a string";
            var myData3 = myData is string ? myData :"Invalid Data";
            WriteLine(myData2);
            WriteLine(myData3);
            //Example 2   
            var x = 10;
            dynamic y = 20;
            var sum = y is int ? $"{y * x}" : "Invalid data";
            WriteLine(sum);
        }
    }
}
