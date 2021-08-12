using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Demo1
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the File Path");
                string path = Console.ReadLine();
                FileInfo obj = new FileInfo(path);
                if (obj.Exists)
                {
                    Console.WriteLine("Name: " + obj.Name);
                    obj.CopyTo("D://Demo1.txt");
                    Console.WriteLine("Created Date: "+obj.CreationTime);
                }
                else
                    Console.WriteLine("Invalid File Path");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
