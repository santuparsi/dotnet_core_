using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Runtime.Serialization.Json;
namespace HandsOnSerialization
{
    class SOAPSerializationDemo
    {
        public static void Serialization()
        {
            try
            {
                Employee employee = new Employee() { Eid = 1, Ename = "Rohan", Salary = 32000 };
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream("D://emp2.xml", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, employee);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Employee Deserialize()
        {
            try
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream("D://emp2.xml", FileMode.Open, FileAccess.Read))
                {
                    Employee employee = formatter.Deserialize(stream) as Employee;
                    return employee;
                }

                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               throw ex;
            }
        }
        static void Main()
        {
            Serialization();
            Employee employee = Deserialize();
            Console.WriteLine($"{employee.Eid} {employee.Ename} {employee.Salary}");
            Console.ReadKey();
        }
    }
}
