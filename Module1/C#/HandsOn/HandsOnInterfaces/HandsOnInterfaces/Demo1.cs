using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
   class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
    }
    interface IStudentRepository
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        Student[] GetStudents();
    }
    class StudentRepository : IStudentRepository
    {
        public Student[] students = new Student[4];
        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudents()
        {
            throw new NotImplementedException();
        }
    }
    class Demo1
    {
    }
}
