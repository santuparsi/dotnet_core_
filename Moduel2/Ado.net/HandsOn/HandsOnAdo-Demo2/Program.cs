using System;
using HandsOnAdo_Demo2.Entities;
using HandsOnAdo_Demo2.Repositoires;
using System.Collections.Generic;
namespace HandsOnAdo_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProductRepository repository = new ProductRepository();
                do
                {
                    Console.WriteLine("1.AddProduct");
                    Console.WriteLine("2.UpdateProduct");
                    Console.WriteLine("3.DeleteProduct");
                    Console.WriteLine("4.GetProductById");
                    Console.WriteLine("5.GetProducts");
                    Console.WriteLine("6.Exit");
                    Console.WriteLine("Enter your choice");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                Product product = new Product();
                                //getting values from user
                                product.Pid = new Random().Next(1000, 9999); //genereated random value between 1000 and 9999
                                Console.WriteLine("Enter Product Name");
                                product.Pname = Console.ReadLine();
                                Console.WriteLine("Enter Product Price");
                                product.Price = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Stock");
                                product.Stock = int.Parse(Console.ReadLine());
                                repository.AddProduct(product);
                            }
                            break;
                        case 2:
                            {
                                Product product = new Product();
                                //getting values from user
                                Console.WriteLine("Enter Product Id");
                                product.Pid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Product Price");
                                product.Price = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Stock");
                                product.Stock = int.Parse(Console.ReadLine());
                                repository.UpdateProduct(product);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter Product Id");
                                var pid = int.Parse(Console.ReadLine());
                                repository.DeleteProduct(pid);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter Product Id");
                                var pid = int.Parse(Console.ReadLine());
                                Product product = repository.GetProduct(pid);
                                if (product != null)
                                {
                                    Console.WriteLine($"Name:{product.Pname} Price:{product.Price} Stock:{product.Stock}");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid product Id");
                                }
                            }
                            break;
                        case 5:
                            {
                                List<Product> products = repository.GetProducts();
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"ID:{product.Pid} Name:{product.Pname} Price:{product.Price} Stock:{product.Stock}");
                                }
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0); //exit application
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                            }
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
