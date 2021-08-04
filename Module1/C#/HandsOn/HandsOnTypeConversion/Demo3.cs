using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo3
    {
        static void Main()
        {
            int k = 100;
            //casting
            byte b = (byte)k; //convert int to byte
            short s = (short)k; //convert int to short
            long l = 3243;
            k = (int)l; //convert long to int
            double d = 34.45;
            l = (long)d; //convert double to long
            k= (int)d;//convert double to int
        }
    }
}
