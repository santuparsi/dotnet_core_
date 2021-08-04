using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Student
    {
        public int studentId;
        public string studentName;
        public int age;
        public static string schoolName;
        public static string className;
    class Test_Student
    {
       static void Main()
        {
            Student.schoolName = "DPS";
            Student.className = "II";
            Student s1 = new Student();
            s1.studentId = 2345;
            s1.age = 10;
            s1.studentName = "Rohan";
            Console.WriteLine("{0} {1} {2} {3} {4}", s1.studentId, s1.studentName, s1.age, Student.schoolName, Student.className);
            Student s2 = new Student();
            s2.studentId = 7898;
            s2.studentName = "Cherry";
            s2.age = 10;
            Console.WriteLine("{0} {1} {2} {3} {4}", s2.studentId, s2.studentName, s2.age, Student.schoolName, Student.className);

            Student.schoolName = "HPS";
            Student.className = "III";
            Student s3 = new Student();
            s3.studentId = 2345;
            s3.age = 10;
            s3.studentName = "Rose";
            Console.WriteLine("{0} {1} {2} {3} {4}", s3.studentId, s3.studentName, s3.age, Student.schoolName, Student.className);
            Student s4 = new Student();
            s4.studentId = 7898;
            s4.studentName = "Tim";
            s4.age = 10;
            Console.WriteLine("{0} {1} {2} {3} {4}", s4.studentId, s4.studentName, s4.age, Student.schoolName, Student.className);
        }

       
    }

}
