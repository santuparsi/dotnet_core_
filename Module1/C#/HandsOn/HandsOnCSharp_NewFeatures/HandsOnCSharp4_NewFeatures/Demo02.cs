using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp4_NewFeatures
{
    class Demo02
    {
        static void Main(string[] args)
        {
            dynamic stud = new Student();

            stud.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
            stud.DisplayStudentInfo("1");// run-time error, no compile-time error
            stud.FakeMethod();// run-time error, no compile-time error
          
        }
    }

    public class Student
    {
        public void DisplayStudentInfo(int id)
        {
        }
    }
}

