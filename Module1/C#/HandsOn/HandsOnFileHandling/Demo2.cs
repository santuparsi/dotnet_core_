using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Demo2
    {
        static void Main()
        {
            try
            {
                //Working with Directories
                //Create new Directory
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
                //directoryInfo.Create();
                //Get Derictories
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                foreach (var item in directories)
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
