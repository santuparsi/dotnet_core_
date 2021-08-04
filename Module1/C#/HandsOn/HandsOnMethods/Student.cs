using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Student
    {
        public int sId;
        public string sName;
        public int age;
        public static string school;
        public void Details()
        {
            //display student details
            Console.WriteLine("ID:{0} Name:{1} Age:{2} School:{3}", sId, sName, age, school);
        }
    }
    class Test_Student
    {
        static void Main()
        {
            Student.school = "DPS";
            Student s1 = new Student() { sId = 1, sName = "Rohan", age = 10 };
            s1.Details();
            Student s2 = new Student() { sId = 2, sName = "Jeson", age = 10 };
            s2.Details();
        }
    }
   
}
