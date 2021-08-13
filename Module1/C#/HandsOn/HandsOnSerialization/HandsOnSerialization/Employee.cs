using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSerialization
{
    [Serializable]
   public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
    }
}
