using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo4
    {
        static void Main()
        {
            //conversion using convert class.
            //Converting one type to another type
            string s = "345";
            int i = Convert.ToInt32(s); //converts string to int
            long l = Convert.ToInt64(s); //converts string into long
            short s2 = Convert.ToInt16(s); //convers string to short
            byte b = Convert.ToByte(s); //convert string to byte
            double d = Convert.ToDouble(s);
            float f = Convert.ToSingle(s);
            decimal dm = Convert.ToDecimal(s);
            double dd = 34.56;
            i = Convert.ToInt32(dd);
            s2 = Convert.ToInt16(dd);
            //Tostring method convert any type to string
            s = Convert.ToString(dd); //convert double to string
            s = Convert.ToString(123);
            s = Convert.ToString(true);
            s = Convert.ToString('a');

            //unsigned datatypes(allow only +ve values)
            uint ui = 1234;
            ushort us = 32093;
            ulong ul = 3240343490;
            //signed byte
            sbyte bb = -23;


        }
    }
}
