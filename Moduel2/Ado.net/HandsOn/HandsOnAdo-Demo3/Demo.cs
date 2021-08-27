using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnAdo_Demo3
{
    class Demo
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
        SqlDataAdapter dataAdapter = null;
        DataSet data = null;
        public Demo()
        {
            dataAdapter = new SqlDataAdapter("Select * from Product", connection);
            //initiate Dataset
            data = new DataSet();
            dataAdapter.Fill(data, "P");
        }
        public void GetAllRecords()
        {
            DataTable dataTable = data.Tables["P"];//returns Datatable
          foreach(DataRow dr in dataTable.Rows)
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr["Stock"]}");
            }
        }
        public void GetRow(int idx)
        {
            if(idx<data.Tables["P"].Rows.Count)
            {
                DataRow dr = data.Tables["P"].Rows[idx];
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr["Stock"]}");
            }
            else
            {
                Console.WriteLine("Invalid Row No");
            }
        }

    }
}
