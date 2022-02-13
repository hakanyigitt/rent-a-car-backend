using Business.Concrete;
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

            //CarAdd(carManager);
            //CarGetById(carManager);
            //CarUpdate(carManager);
            //CarDelete(carManager);
            //CarGetAll(carManager);

            ColorManager colorManager = new ColorManager(new EfColarDal());
            //ColorInsert(colorManager);
            //ColorGetById(colorManager);
            //ColorUpdate(colorManager);
            //ColorDelete(colorManager);
            //ColorGetAll(colorManager);

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //BrandInsert(brandManager);
            //BrandGetById(brandManager);
            //BrandUpdate(brandManager);
            //BrandDelete(brandManager);
            //BrandGetAll(brandManager);

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.BrandName + " - " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice+"TL");
            }
        }

        private static void BrandDelete(BrandManager brandManager)
        {
            var result = brandManager.GetById(5);
            brandManager.Delete(result);
        }

        private static void BrandUpdate(BrandManager brandManager)
        {
            var result = brandManager.GetById(3);
            result.Name = "FIAT";
            brandManager.Update(result);
        }

        private static void BrandGetById(BrandManager brandManager)
        {
            var result = brandManager.GetById(3);
            Console.WriteLine(result.Name);
        }

        private static void BrandInsert(BrandManager brandManager)
        {
            brandManager.Insert(new Brand { Name = "Porsche" });
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (Brand brand in brandManager.GetAll())
            {
                Console.WriteLine("Id : " + brand.Id + " " + brand.Name);
            }
        }

        private static void ColorDelete(ColorManager colorManager)
        {
            var result = colorManager.GetById(5);
            colorManager.Delete(result);
        }

        private static void ColorUpdate(ColorManager colorManager)
        {
            var result = colorManager.GetById(6);
            result.Name = "Gray";
            colorManager.Update(result);
        }

        private static void ColorGetById(ColorManager colorManager)
        {
            var result = colorManager.GetById(4);
            Console.WriteLine(result.Name);
        }

        private static void ColorInsert(ColorManager colorManager)
        {
            colorManager.Insert(new Color { Name = "Purple" });
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            foreach (Color color in colorManager.GetAll())
            {
                Console.WriteLine("Id : " + color.Id + " " + color.Name);
            }
        }

        private static void CarDelete(CarManager carManager)
        {
            carManager.Delete(carManager.GetById(8));
        }

        private static void CarUpdate(CarManager carManager)
        {
            var result = carManager.GetById(8);
            result.Description = "Fiat 500L";
            result.DailyPrice = 500;
            carManager.Update(result);
        }

        private static void CarGetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " " + car.Description);
            }
        }

        private static void CarAdd(CarManager carManager)
        {
            carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = 2020, Description = "Fiat Egea" });
        }

        private static void CarGetById(CarManager carManager)
        {
            var result = carManager.GetById(2);
            Console.WriteLine(result.Description);
        }
    }
}
