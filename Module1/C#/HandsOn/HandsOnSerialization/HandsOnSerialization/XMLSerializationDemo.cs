using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace HandsOnSerialization
{
    class XMLSerializationDemo
    {
        public static void Serialization()
        {
            try
            {
                Employee employee = new Employee() { Eid = 1, Ename = "Rohan", Salary = 32000 };
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));
                using (FileStream stream = new FileStream("D://emp.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, employee);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Employee Deserialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));
                using (FileStream stream = new FileStream("D://emp.xml", FileMode.Open, FileAccess.Read))
                {
                    Employee employee = serializer.Deserialize(stream) as Employee;
                    return employee;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static void Serialization1() //serialize list of employees
        {
            try
            {
                Employee employee = new Employee() { Eid = 1, Ename = "Rohan", Salary = 32000 };
                Employee employee1 = new Employee() { Eid = 2, Ename = "Ram", Salary = 32000 };
                Employee employee2 = new Employee() { Eid = 3, Ename = "Raghu", Salary = 32000 };
                List<Employee> employees = new List<Employee>() { employee, employee1, employee2 };
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                using (FileStream stream = new FileStream("D://emp1.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, employees);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<Employee> Deserialize1()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                using (FileStream stream = new FileStream("D://emp1.xml", FileMode.Open, FileAccess.Read))
                {
                    List<Employee> employees = serializer.Deserialize(stream) as List<Employee>;
                    return employees;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        static void Main()
        {
           //// Serialization();
           // Employee e = Deserialize();
           // Console.WriteLine(e.Ename);
            Serialization1();
            //List<Employee> employees = Deserialize1();
            //foreach(Employee employee in employees)
            //Console.WriteLine($"{employee.Eid} {employee.Ename} {employee.Salary}");
            Console.ReadKey();
        }
    }
}
