using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class SortedListDemo
    {
        static void Main()
        {
            SortedList list = new SortedList()
            {
                [1234] = "Karan",
                [1000] = "Suren",
                [8909] = "Json",
                [1111] = "Peter"
            };
            list.Add(1002, "Rohan");
            list.Remove(1111);
           foreach(var key in list.Keys)
            {
                Console.WriteLine("{0} {1}", key, list[key]);
            }
        }
    }
}
