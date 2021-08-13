using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
namespace Day10.HandsOnSerialization
{
    [DataContract]
    class Student
    {
        [DataMember]
        public int Sid { get; set; }
        [DataMember]
        public string Sname { get; set; }
    }
    class Demo04
    {
        private static void JSONSerialize(Student obj)
        {
           
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
            string path = @"D:\\student.json";
            
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                jsonSer.WriteObject(stream, obj);
            }
          
        }
        private static Student JSONDeSerialize()
        {

            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
            string path = @"D:\\student.json";

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return jsonSer.ReadObject(stream) as Student;
            }

        }
        private static void JSONListSerialize()
        {

            List<Student> list = new List<Student>()
            {
                new Student(){Sid=1,Sname="Ram"},
                new Student(){Sid=2,Sname="Krishna"},
                new Student(){Sid=3,Sname="Bheem"},
            };
            //Student[] list = new Student[3]
            //{
            //    new Student(){Sid=1,Sname="Ram"},
            //    new Student(){Sid=2,Sname="Krishna"},
            //    new Student(){Sid=3,Sname="Bheem"},
            //};
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(List<Student>));
            string path = @"D:\\list1.json";

            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                jsonSer.WriteObject(stream, list);
            }

        }
        static void Main()
        {
            //Student s = new Student() { Sid = 1, Sname = "Ram" };
            //JSONSerialize(s);
            //Student s1 = JSONDeSerialize();
            //Console.WriteLine("{0} {1}", s1.Sid, s1.Sname);
            JSONListSerialize();
            Console.ReadKey();
        }
    }
}
