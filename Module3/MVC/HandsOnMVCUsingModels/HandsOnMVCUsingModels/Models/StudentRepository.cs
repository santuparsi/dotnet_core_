using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingModels.Models
{
    public class StudentRepository
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){Sid=1,Sname="Ram",Age=10},
            new Student(){Sid=2,Sname="Krishna",Age=11},
            new Student(){Sid=3,Sname="Raghu",Age=10}
        };
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudent(int id)
        {
            return students.SingleOrDefault(s => s.Sid == id);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
