using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp6_NewFeatures
{
    class Demo04
    {
        //nameof Expression
        //nameof expression will return string leteral of the name of the property or a methods.
        static void Main(string[] args)
            {
                Employee emp = new Employee();
            WriteLine("ID: {0}", emp.Id);
                WriteLine("{0} : {1}", nameof(Employee.Id), emp.Id);
                WriteLine("{0} : {1}", nameof(Employee.Name), emp.Name);
                WriteLine("{0} : {1}", nameof(Employee.Salary), emp.Salary);
                ReadLine();
            }
        class Employee
        {
            public int Id { get; set; } = 101;
            public string Name { get; set; } = "Nitin";
            public int Salary { get; set; } = 9999;
        }
    }
}
