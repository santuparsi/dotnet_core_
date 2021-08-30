using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAdo_Demo3
{
    class Demo4
    {
        //Dataset wit LInq
        static void Main()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
            SqlDataAdapter dataAdapter = null;
            DataSet ds = null;
            dataAdapter = new SqlDataAdapter("Select * from Product", connection);
            //initiate Dataset
            ds = new DataSet();
            dataAdapter.Fill(ds, "P");
            //Fetching data from Dataset using
            var productSource = ds.Tables["P"].AsEnumerable();
            DataTable table = (from t in productSource
                               where t.Field<int>("price") > 100
                               select t).CopyToDataTable();
            foreach(DataRow r in table.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]} {r[3]}");
            }
        }
    }
}
