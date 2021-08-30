using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnAdo_Demo2
{
    class Demo1
    {
        static void Main()
        {
            try
            {
                 SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
                SqlCommand command = new SqlCommand("GetNameById", connection)
                {
                    CommandType=System.Data.CommandType.StoredProcedure
                };
                SqlParameter p1 = new SqlParameter()
                {
                    Value = 3457,
                    ParameterName = "@Pid",
                    DbType = System.Data.DbType.Int32,
                    Direction = System.Data.ParameterDirection.Input
                };
                SqlParameter p2 = new SqlParameter()
                {
                   
                    ParameterName = "@Pname",
                    Size=30,
                    DbType=System.Data.DbType.String,
                    Direction = System.Data.ParameterDirection.Output
                };
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                connection.Open();
                command.ExecuteNonQuery();
                string product_name = p2.Value.ToString(); ;
                Console.WriteLine(product_name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
