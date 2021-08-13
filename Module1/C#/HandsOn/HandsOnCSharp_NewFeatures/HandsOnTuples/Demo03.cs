using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTuples
{
    class Demo03
    {
        public static void SetTupleMethod(Tuple<string, string, int> tupleAuthor)
        {
            var author2 = tupleAuthor;
            Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.",
            author2.Item1, author2.Item2, author2.Item3);
        }
        static void Main()
        {
            SetTupleMethod(new Tuple<string, string, int>(
"Mike Gold", "Code UML", 2005));
        }
    }
}
