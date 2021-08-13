using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFileHandling
{
    class Demo3
    {
        static void Main()
        {
            try
            {
                //Working with Directories
                //Create new Directory
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
                //directoryInfo.Create();
                //Get files in each Derictories
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                foreach (var item in directories)
                {
                    Console.WriteLine("Files in " + item.Name);
                    FileInfo[] files = item.GetFiles();
                    foreach (var file in files)

                        Console.WriteLine(file.Name);
                }
            }
            catch (IOException ex)
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
