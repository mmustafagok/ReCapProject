using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------");

            carManager.Add(new Car 
            {
                Id=4,
                BrandId=2,
                ColorId=1,
                DailyPrice=125,
                ModelYear= 2016,
                Description= "Audi A3, Siyah, 125 TL, 2016 model"
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------");

            carManager.Delete(new Car {Id=1 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------");

            carManager.Update( new Car 
            {
                Id = 2,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 300,
                ModelYear = 2018,
                Description = "BMW i8, Beyaz, 300 TL, 2018 model"

            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------------------------------");



        }
    }
}
