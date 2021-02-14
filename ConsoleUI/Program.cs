using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());



            GetCarDetails(carManager);


            //ColorAdd(colorManager);

            //CarAdd(carManager);

            //ColorGetAll(colorManager);

            //BrandAdd(brandManager);

            //BrandGetAll(brandManager);

            //GetByDailyPrice(carManager);

            //CarDelete(carManager);

            //GetAll(carManager);

        }



        private static void CarDelete(CarManager carManager)
        {
            carManager.Delete(new Car
            {
                Id = 13
            });
        }

        private static void GetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetByDailyPrice(CarManager carManager)
        {
            foreach (var car in carManager.GetByDailyPrice(150, 260).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void BrandAdd(BrandManager brandManager)
        {
            brandManager.Add(new Brand
            {
                BrandName = "Volkswagen"
            }
            );
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorAdd(ColorManager colorManager)
        {
            colorManager.Add(new Color
            {
                ColorName = "Yeşil"
            });
        }

        private static void CarAdd(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                DailyPrice = -1,
                ModelYear = 2019,
                Description = "Mercedes CLA"
            }
                        );
        }

        private static void GetCarDetails(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Description + " - " + car.BrandName + " - " + car.DailyPrice + "TL");
            }
        }
    }
}
