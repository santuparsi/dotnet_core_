using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    interface IStudentRepository<T>
    {
       void AddStudent(T item);
        List<T> GetStudents();
        T GetStudentById(int id);
    }
    class StudentReposiotry : IStudentRepository<Student>
    {
        List<Student> list = new List<Student>();
        public void AddStudent(Student item)
        {
            list.Add(item);
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
    class ListDemo2
    {
    }
}
