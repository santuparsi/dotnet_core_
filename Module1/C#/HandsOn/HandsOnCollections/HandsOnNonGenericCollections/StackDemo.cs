using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack obj = new Stack();
            //add items
            obj.Push("Rose");
            obj.Push("Tulips");
            obj.Push("Jasmine");
            obj.Push("Marigold");
            obj.Push("Lilly");
            //access always last item
            string s = obj.Peek() as string; //returns lilly
            obj.Pop(); //last item i.e lilly removed.
            foreach (var k in obj)
                Console.WriteLine(k);
        }
    }
}
