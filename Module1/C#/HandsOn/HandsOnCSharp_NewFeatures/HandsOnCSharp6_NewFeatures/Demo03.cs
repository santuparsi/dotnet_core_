using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6_NewFeatures
{
    class Demo03
    {
        //Dictionary Initializer
        static void Main()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"Nitin","Noida" },
                {"Sonu","Barut" }
            };
            Dictionary<string, string> dicStr = new Dictionary<string, string>()
            {
                ["Nitin"] = "Noida",
                ["Sonu"] = "Baraut",
                ["Rahul"] = "Delhi",
            };
            dicStr["Mohan"] = "Noida";
            foreach (var item in dicStr)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
            Console.WriteLine("********************************************************************");
            Dictionary<int, string> dicInt = new Dictionary<int, string>()
            {
                [1] = "Nitin",
                [2] = "Sonu",
                [3] = "Mohan"
            };
            dicInt.Add(5, "Tanjua");
            dicInt[4] = "Rahul";
            foreach (var item in dicInt)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
            Console.Read();
        }
    }
}
