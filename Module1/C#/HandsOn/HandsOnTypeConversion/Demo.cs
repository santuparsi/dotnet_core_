using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo
    {
        static void Main()
        {
            byte b = 123;
            //implicit conversion
            int i = b;
            short s = b;
            long l = b;
            double d = b;
            i = 100;
            l = i;
            d = i;
        }
    }
}
