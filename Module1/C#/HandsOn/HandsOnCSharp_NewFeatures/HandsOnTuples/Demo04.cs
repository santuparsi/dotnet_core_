using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTuples
{
    class Demo04
    {
        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it  
            var author = new Tuple<string, string, int>(
            "Mahesh Chand", "Programming C#", 2002);
            return author;
        }
        //C#7.0
        // tuple return type  
        public static (string, string, long) TupleReturnLiteral(long id)
        {

            string name = string.Empty;
            string title = string.Empty;
            long year = 0;

            if (id == 1000)
            {
                name = "Santhosh Parsi";
                title = "React Programming";
                year = 2020;
            }

            // tuple literal  
            return (name, title, year);

        }
        // tuple return type with more readable
        public static (string name, string title, long year) TupleReturnLiteral1(long id)
        {

            string name = string.Empty;
            string title = string.Empty;
            long year = 0;

            if (id == 1000)
            {

                name = "Mahesh Chand";
                title = "ADO.NET Programming";
                year = 2003;
            }

            // tutle literal  
            return (name, title, year);

        }
        static void Main()
        {
            var author2 = GetTupleMethod();
            Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.", author2.Item1, author2.Item2, author2.Item3);
            var author = TupleReturnLiteral(1000);
            Console.WriteLine($"Author {author.Item1} {author.Item2} {author.Item3} ");
            var author1 = TupleReturnLiteral1(1000);
            Console.WriteLine($"Author {author1.name} {author1.title} {author1.year} ");
        }
    }
}
