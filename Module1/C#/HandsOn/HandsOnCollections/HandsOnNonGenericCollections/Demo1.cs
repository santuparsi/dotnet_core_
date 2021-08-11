using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    class Demo1
    {
        static void Main()
        {
            Student s1 = new Student() { Sid = 1, Sname = "Rohan", Age = 20 };
            Student s2 = new Student() { Sid = 2, Sname = "Charan", Age = 12 };
            //add objects to Arraylist
            ArrayList list = new ArrayList() { s1, s2 };
            list.Add(new Student() { Sid = 3, Sname = "Karan", Age = 10 });
            Student s = list[0] as Student; //converrs object into student
            foreach (Student item in list)
                Console.WriteLine("{0} {1} {2}", item.Sid, item.Sname, item.Age);
        }
    }
}
