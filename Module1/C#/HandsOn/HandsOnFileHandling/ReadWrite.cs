using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class ReadWrite
    {
        public static void Read(string path)
        {
            using(StreamReader sr=new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        public static void Write(string path)
        {
           using(StreamWriter sw=new StreamWriter(path,true))
            {
                string content = "All glitters are not gold..";
                sw.WriteLine(content);

            }
        }
        public static void WriteList(string path)
        {
            List<Student> list = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                 new Student(){Sid=2,Sname="Charan",Age=10},
                  new Student(){Sid=3,Sname="Ram",Age=10},
            };
            foreach (var item in list)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string content = string.Format("ID:{0} Name:{1} Age:{2}", item.Sid, item.Sname, item.Age);
                    sw.WriteLine(content+Environment.NewLine);

                }
            }
        }
    }

    class Test_ReadWrite
    {
        static void Main()
        {
            Console.WriteLine("Enter Path");
            string path = Console.ReadLine();
            //ReadWrite.Read(path);
            ReadWrite.WriteList(path);
        }
    }
    
}
