using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp7_NewFeatures
{
    //Local functions or nested functions
    public class Subject
    {
        public string SubjectName
        {
            get;
            set;
        }
        public decimal Marks
        {
            get;
            set;
        }
    }
    class Demo02
    {
        public static void PrintStudentMarks(int studentId, params Subject[] subjects)
        {
            WriteLine($"Student Id {studentId} Total Marks: {CalculateMarks()}");
            WriteLine($"Subject wise marks");
            foreach (var subject in subjects)
            {
                WriteLine($"Subject Name: {subject.SubjectName} \t Marks: {subject.Marks}");
            }
            decimal CalculateMarks()
            {
                decimal totalMarks = 0;
                foreach (var subject in subjects)
                {
                    totalMarks += subject.Marks;
                }
                return totalMarks;
            }
        }
        static void Main(string[] args)
        {
            PrintStudentMarks(101, new Subject
            {
                SubjectName = "Math",
                Marks = 96
            }, new Subject
            {
                SubjectName = "physics",
                Marks = 88
            }, new Subject
            {
                SubjectName = "Chem",
                Marks = 91
            });
        }
    }

}
