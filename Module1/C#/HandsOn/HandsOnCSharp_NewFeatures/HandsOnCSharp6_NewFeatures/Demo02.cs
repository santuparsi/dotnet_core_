using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6_NewFeatures
{
    //Auto property initializer
    class Emp
    {
        public string Name { get; set; } = "nitin";
        public int Age { get; set; } = 25;
        public int Salary { get; } = 999;
    }
    class Demo02
    {
        static void Main()
        {
            Emp obj = new Emp();
            obj.Name = "Rohan"; //earlier syntax
            
        }
    }
}
