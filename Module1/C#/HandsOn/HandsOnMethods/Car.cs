using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
    }
    class CarRepository
    {
        public Car[] catelog = new Car[10];
        int count = 0;
        public void AddCar(Car car)
        {
            if (count <= catelog.Length)
            {
                catelog[count] = car;
                count++;
            }
            else
                Console.WriteLine("Garaj is full");
        }
        public Car SearchCar(string make)
        {
            Car obj = null;
            foreach(var item in catelog)
            {
                if (item != null)
                {
                    if (item.Make.Equals(make))
                    {
                        obj = item;
                        break;
                    }
                }
            }
            return obj;
        }
        public Car[] GetCars()
        {
            return catelog;
        }
        public void DeleteCar(string make)
        {
           for(int i=0;i<catelog.Length;i++)
            {
                if(catelog[i].Make==make)
                {
                    catelog[i] = null;
                    break;
                }
            }
        }
        public void UpdateCar(string make,double price)
        {
            for (int i = 0; i < catelog.Length; i++)
            {
                if (catelog[i].Make == make)
                {
                    catelog[i].Price = price;
                    break;
                }
            }
        }
    }
    class Test_Car
    {
        static void Main()
        {
            CarRepository repository = new CarRepository();
            do
            {
                Console.WriteLine("1.AddCar\n2.GetCarDetails\n3.GetAllCars\n4.DeleteCar\n5.UpdateCar");
                Console.WriteLine("Enter Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            Console.WriteLine("Enter Make");
                            string make = Console.ReadLine();
                            Console.WriteLine("Enter Model");
                            string model = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Year");
                            int year = int.Parse(Console.ReadLine());
                            Car obj = new Car(make, model, year, price);
                            repository.AddCar(obj);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Make");
                            string make = Console.ReadLine();
                            Car car = repository.SearchCar(make);
                            if (car != null)
                            {
                                Console.WriteLine("Model:{0} Year:{1} Price:{2}", car.Model, car.Year, car.Price);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Make");
                            }
                        }
                        break;
                    case 3:
                        {
                            Car[] cars = repository.GetCars();
                            foreach (var car in cars)
                            {
                                if (car != null)
                                    Console.WriteLine("Model:{0} Year:{1} Price:{2}", car.Model, car.Year, car.Price);
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter Make");
                            string make = Console.ReadLine();
                            repository.DeleteCar(make);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Make");
                            string make = Console.ReadLine();
                            Console.WriteLine("Enter New Price");
                            double price = double.Parse(Console.ReadLine());
                            repository.UpdateCar(make, price);
                        }
                        break;
                }
            } while (true);
        }
    }
}
