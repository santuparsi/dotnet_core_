using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodOverriding
{
    class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Hello " + name;
        }
    }
    class Test_Student
    {
        public static void Main()
        {
            Student s = new Student("Sachin");
            Console.WriteLine(s);
        }
    }
}
