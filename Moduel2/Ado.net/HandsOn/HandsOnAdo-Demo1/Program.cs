using System;
using System.Data.SqlClient;
namespace HandsOnAdo_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = null;
           //Read Product table data
           try
            {
                connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from Product", connection);
                SqlDataReader reader=command.ExecuteReader();
                if(reader.HasRows)
                {
                   while(reader.Read())
                    {
                        Console.WriteLine($"ID: {reader[0]} Name: {reader[1]} Price: {reader["Price"]} Stock: {reader["Stock"]}");
                    }
                }
                else

                {
                    Console.WriteLine("Reader is Empty..");
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close(); //close connection
            }
        }
    }
}
