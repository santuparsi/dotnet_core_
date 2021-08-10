using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Student
    {
        private int sId;
        private string sName;
        public int Sid
        {
            get { return sId; }
            set
            {
                if (value > 0)
                    sId = value;
                else
                    Console.WriteLine("Invalid ID");
            }
        }
        public string Sname
        {
            get { return sName; }
            set
            {
                if (value != null)
                    sName = value;
                else
                    Console.WriteLine("Name should not null");
            }
        }
    }
    class Test_Student
    {
        static void Main()
        {
            Student s = new Student();
            s.Sid = -1;
            s.Sname = null;
            Console.WriteLine("ID:{0} and Name:{1}", s.Sid, s.Sname);
        }
    }
}
