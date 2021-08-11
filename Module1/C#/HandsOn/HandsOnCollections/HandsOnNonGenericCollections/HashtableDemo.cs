using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class HashtableDemo
    {
        static void Main()
        {
            Hashtable hs1 = new Hashtable()
            {
                [1234]="Rohan",
                [2345]="Karan",
                ['c']="Canada"
            };
            Hashtable hs = new Hashtable();
            //add items(key is not be duplicate or null)
            hs.Add(1023, "Rohan");
            hs.Add(2345, "Karan");
            hs.Add(3456, "Uday");
            hs.Add(7898, "Manoj");
            //adding key and value from input
            Console.WriteLine("Enter Id");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string value = Console.ReadLine();
            hs.Add(key, value);
            //access value using key
            string name = hs[2345] as string;
            //remove key-value pair
            hs.Remove(1023); //key-value pair will remove
            //check key existence
            hs.Contains(2345); //returns bool values
            //access all key-value pairs
            foreach(var k in hs.Keys)
            {
                Console.WriteLine("Key:{0} Value:{1}", k, hs[k]);
            }
        }
    }
}
