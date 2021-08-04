using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo6
    {
        static void Main()
        {
            //boxing and unboxing
            //boxing is the process of converting any value type data to object type
            byte b = 100;
            short s = 4334;
            int i = 34234342;
            long j = 32434324;
            double d = 23.34;
            object o1 = b; //boxing and boxing is implicit conversion
            object o2 = s;
            object o3 = i;
            object o4 = j;
            //unboxing is the method of converting object value into value type.
            //unboxing requires explicit conversion
            object o11 = 120;
            int k = (int)o11;
            double d1 = (double)o11;
            long l1 = (long)o11;
            int k1 = Convert.ToInt32(o11);
            double d2 = Convert.ToDouble(o11);
            long l2 = Convert.ToInt64(o11);
            string str = o11.ToString(); //converts object data into string

        }
    }
}
