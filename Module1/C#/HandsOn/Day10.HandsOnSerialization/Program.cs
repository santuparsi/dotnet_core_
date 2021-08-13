using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Day10.HandsOnSerialization
{
   

    class Program
    {
        static void Serialize(Employee e)
        {
            string path = @"D:\CAPGEMINI\Training-HandsOn\C#\Day10\emp.bat";
            BinaryFormatter obj = new BinaryFormatter();
            using (FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                obj.Serialize(fs, e);
            }

        }
        static Employee Deserialize()
        {
            string path = @"D:\CAPGEMINI\Training-HandsOn\C#\Day10\emp.bat";
            BinaryFormatter obj = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Employee e=obj.Deserialize(fs) as Employee;
                return e;
            }
        }
        public static void SList()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Salary=1000},
                 new Employee(){Eid=1,Ename="Rohan",Salary=1000}
            };
            string path = @"D:\CAPGEMINI\Training-HandsOn\C#\Day10\list.bat";
            BinaryFormatter obj = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                obj.Serialize(fs, list);
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee() { Eid = 1, Ename = "Rohan", Salary = 12000 };
            Serialize(e);
            Employee e1= Deserialize();
            Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);

        }
    }
}
