using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HandsOnCSharp6_NewFeatures
{
    //Null-Conditional Operator
    class Employee
    {
        public string Name { get; set; }
        public Address EmployeeAddress { get; set; }
    }
    class Address
    {
        public string HomeAddress { get; set; }
        public string OfficeAddress { get; set; }
    }

    class Demo07
    {
        static void Main()
        {

            Employee emp = new Employee();
            if(emp!=null)
            {
                Console.WriteLine(emp.Name);
            }
            emp.Name = "Nitin";
            emp.EmployeeAddress = new Address()
            {
                HomeAddress = "Chennai Sec 10",
                OfficeAddress = "Delhi Sec 16"
            };
            WriteLine((emp?.Name) + "  " + (emp?.EmployeeAddress?.HomeAddress ?? "No Address"));
            Console.WriteLine();
            Employee emp1 = new Employee();
            emp.Name = "Nitin";
          
            WriteLine((emp1?.Name) + "  " + (emp1?.EmployeeAddress?.HomeAddress ?? "No Address"));
            ReadLine();
        }
    }
}
