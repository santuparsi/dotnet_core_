using System;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 25, 67, 78, 9 };
            list.Add(10);
            list.Add(23);
            list.Add(35);
            list.Insert(0, 100);
            //access the value
            int k = Convert.ToInt32(list[1]);
            //display all the values
            //remove item
            list.Remove(25); //25 is removed
            list.RemoveAt(2); ; //value at 2nd index removed
            Console.WriteLine("no of Items:{0} ", list.Count);
            if (list.Count > 0)
            {
                foreach (var n in list)
                {
                    Console.WriteLine(n);
                }
            }
            if (list.Contains(35))
            {
                Console.WriteLine("item is there");
            }
            else
                Console.WriteLine("wrong item.");
        }
    }
}
