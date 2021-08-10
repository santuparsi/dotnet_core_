using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Currency
    {
        public static double 
            RTD(double rupees,double dp=78.3)
        {
            return rupees / dp;
        }
        public static double DTR(double dollers,double dp=78.3)
        {
            return dollers * dp;
        }
    }
}
