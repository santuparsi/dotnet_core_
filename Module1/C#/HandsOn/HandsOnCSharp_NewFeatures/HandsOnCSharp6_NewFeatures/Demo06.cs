using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp6_NewFeatures
{
    //Exception filters
    class Demo06
    {
        static void Main(string[] args)
        {
            int val1;
            int val2=1;
            try
            {
                WriteLine("Enter first value :");
                val1 = int.Parse(ReadLine());
                WriteLine("Enter Next value :");
                val2 = int.Parse(ReadLine());
                WriteLine("Div : {0}", (val1 / val2));
            }
            catch (Exception ex) when (val2==0)
            {
                WriteLine("Can't be Division by zero");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            ReadLine();
        }
    }
}
