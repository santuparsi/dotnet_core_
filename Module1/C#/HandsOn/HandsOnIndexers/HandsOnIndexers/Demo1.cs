using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexers
{
    class Demo1
    {
        static void Main()
        {
            string poem = @"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills, 
When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.";
            string server = Console.ReadLine();
            string path = server + "/WebApps/MyApps/Images";
            Console.WriteLine(path);
        }
    }
}
