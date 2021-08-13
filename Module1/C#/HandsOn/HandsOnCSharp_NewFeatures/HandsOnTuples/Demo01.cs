using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTuples
{
    class Demo01
    {
        static void Main()
        {
            // Create a 3-tuple  
            var author = new Tuple<string, string, int>("Mahesh Chand", "ADO.NET Programming", 2003);

            // Display author info  
            System.Console.WriteLine("Author {0} wrote his first book titled {1} in {2}.", author.Item1, author.Item2, author.Item3);

            // Create a 5-tuple  
            var pubAuthor = Tuple.Create("Mahesh Chand", "Graphics Programming with GDI+", "Addison Wesley", 2004, 49.95);

            System.Console.WriteLine("Author {0} wrote his fourth book titled {1} for {2} in {3}. Price: {4}", pubAuthor.Item1, pubAuthor.Item2, pubAuthor.Item3, pubAuthor.Item4, pubAuthor.Item5);
        }
    }
}
