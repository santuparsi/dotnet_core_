using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp7_NewFeatures
{
    //Local functions or nested functions
    class Demo03
    {
        private static int GetFactorialUsingLocal(int number)
        {
            if (number < 0) throw new ArgumentException("negative number", nameof(number));
            else if (number == 0) return 1;
            int result = number;
            while (number > 1)
            {
               Multiply(number - 1);
                
                number--;
            }
           // void Multiply(int x) => result = result * x;
            void Multiply(int x)
            {
                 result = result * x;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //BigInteger factorial = GetFactorial(9000);  
            int factorial = GetFactorialUsingLocal(5);
            Console.WriteLine(factorial);
        }
    }
}
