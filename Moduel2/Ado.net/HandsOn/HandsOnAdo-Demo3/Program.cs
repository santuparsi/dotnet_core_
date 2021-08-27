using System;
using System.Data.SqlClient;
namespace HandsOnAdo_Demo3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Demo obj = new Demo();
                //obj.GetAllRecords();
                Console.WriteLine("ENter Row No");
                int row_index = int.Parse(Console.ReadLine());
                obj.GetRow(row_index);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
