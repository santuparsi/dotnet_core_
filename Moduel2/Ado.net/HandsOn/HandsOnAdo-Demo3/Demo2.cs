using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnAdo_Demo3
{
    //Dataset DML
    class Demo2
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
        SqlDataAdapter dataAdapter = null;
        DataSet ds = null;
        SqlCommandBuilder cb;
        public Demo2()
        {
            dataAdapter = new SqlDataAdapter("Select * from Product", connection);
            cb = new SqlCommandBuilder(dataAdapter);
            //initiate Dataset
            ds = new DataSet();
            dataAdapter.Fill(ds, "P");
            //set primary key to dataset table
            ds.Tables[0].PrimaryKey = new DataColumn[1] { ds.Tables[0].Columns["Pid"] };//setting pk to Pid
        }
        public void AddProduct(Product product)
        {
            DataRow dataRow = ds.Tables[0].NewRow();
            dataRow["Pid"] = product.Pid;
            dataRow["Pname"] = product.Pname;
            dataRow["Price"] = product.Price;
            dataRow["Stock"] = product.Stock;
            //add new row to row collection
            ds.Tables[0].Rows.Add(dataRow);
            dataAdapter.Update(ds, "P");
        }
        public void DeleteProduct(int Pid)
        {
            ds.Tables[0].Rows.Find(Pid).Delete(); //row will be deleted
            dataAdapter.Update(ds, "P");
        }
        public void GetProduct(int Pid)
        {
            DataRow dr = ds.Tables[0].Rows.Find(Pid);
            if (dr != null)
            {
                Console.WriteLine("{0} {1} {2} {3}",

                    dr[0], dr[1], dr[2], dr[3]);
            }
            else
                Console.WriteLine("Invalid Id");
        }
        public void UpdateProduct(int Pid,int price,int stock)
        {
            ds.Tables[0].Rows.Find(Pid)["Price"]=price;
            ds.Tables[0].Rows.Find(Pid)["Stock"] = stock;
            dataAdapter.Update(ds, "P");
        }
    }
    class Test
    {
        static void Main()
        {
            Demo2 obj = new Demo2();
            //  Product p = new Product() { Pid = 2343, Pname = "PPP", Stock = 10, Price = 10 };
            // obj.AddProduct(p);
            //obj.GetProduct(2343);
          //  obj.UpdateProduct(2343, 100, 100);
            //obj.GetProduct(2343);
             obj.DeleteProduct(2343);
            obj.GetProduct(2343);


        }
    }
}
