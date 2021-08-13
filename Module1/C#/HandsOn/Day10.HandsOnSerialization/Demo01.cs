using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Day10.HandsOnSerialization
{
    //XML-Serialization and Deserilization
    class Demo01
    {
        static void Serialize(Employee e)
        {
            string path = @"D:\CAPGEMINI\Training-HandsOn\C#\Day10\emp.xml";
            XmlSerializer obj = new XmlSerializer(typeof(Employee));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                obj.Serialize(fs, e);
            }

        }
        static Employee Deserialize()
        {
            string path = @"D:\CAPGEMINI\Training-HandsOn\C#\Day10\emp.xml";
            XmlSerializer obj = new XmlSerializer(typeof(Employee));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return obj.Deserialize(fs) as Employee;
            }
        }
        static void Main()
        {
            Employee e = new Employee() { Eid = 1, Ename = "Rohan", Salary = 12000 };
            Serialize(e);
           Employee e1 = Deserialize();
           Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
        }
    }
}
