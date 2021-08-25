using HandsOnAdo_Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnAdo_Demo2.Repositoires
{
    class ProductRepository : IProductRepository
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
        SqlCommand command = null;
        //Adding new product details to product table.
        public void AddProduct(Product product)
        {
            try
            {
                command = new SqlCommand("insert into Product values(@Pid,@Pname,@Price,@Stock)", connection);
                //passing value to query-paramenters
                command.Parameters.AddWithValue("@Pid", product.Pid);
                command.Parameters.AddWithValue("@Pname", product.Pname);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                connection.Open(); //open connnection
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteProduct(int pid)
        {
            try
            {
                command = new SqlCommand("Delete from Product where Pid=@Pid", connection);
                command.Parameters.AddWithValue("@Pid", pid);
                connection.Open(); //open connnection
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public Product GetProduct(int pid)
        {
            try
            {
                Product product = null;
                command = new SqlCommand("Select * from Product where Pid=@Pid", connection);
                command.Parameters.AddWithValue("@Pid", pid);
                connection.Open(); //open connnection
               SqlDataReader dr= command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    product = new Product()
                    {
                        Pid = (int)dr["Pid"],
                        Pname = dr["Pname"].ToString(),
                        Price = (int)dr["Price"],
                        Stock = (int)dr["Stock"]
                    };
                }
                return product;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = null;
                command = new SqlCommand("Select * from Product", connection);
                connection.Open(); //open connnection
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    products = new List<Product>();
                   while(dr.Read())
                    {
                        products.Add(new Product()
                        {
                            Pid = (int)dr["Pid"],
                            Pname = dr["Pname"].ToString(),
                            Price = (int)dr["Price"],
                            Stock = (int)dr["Stock"]
                        });
                    }
                }
                return products;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                command = new SqlCommand("update product set Price=@Price,Stock=@Stock where Pid=@Pid", connection);
                //passing value to query-paramenters
                command.Parameters.AddWithValue("@Pid", product.Pid);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                connection.Open(); //open connnection
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
