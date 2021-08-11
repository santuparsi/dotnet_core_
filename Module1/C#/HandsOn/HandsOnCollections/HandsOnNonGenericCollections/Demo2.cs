using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    interface IStudentRepositroy
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        ArrayList GetStudents();
        void DeleteStudent(int id);
        void UpdateStudent(int id, int age);
    }
    class StudentRepository : IStudentRepositroy
    {
        ArrayList list = new ArrayList();
        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public void DeleteStudent(int id)
        {
           for(int i=0;i<list.Count;i++)
            {
                if(((Student)list[i]).Sid==id)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        public Student GetStudent(int id)
        {
           foreach(Student s in list)
            {
                if (s.Sid.Equals(id))
                {
                    return s;
                }
            }
            return null;
        }

        public ArrayList GetStudents()
        {
            return list;
        }

        public void UpdateStudent(int id, int age)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (((Student)list[i]).Sid == id)
                {
                    ((Student)list[i]).Age = age;
                }
            }
        }
    }

    class Demo2
    {
        static void Main()
        {
            //write menu driven code to test all the student repository functions.
        }
    }
}
