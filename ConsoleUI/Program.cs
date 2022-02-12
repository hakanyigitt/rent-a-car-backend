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

            //carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 0, ModelYear = 2020, Description = "BMW 520d" });
            //carManager.Add(new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 250, ModelYear = 2008, Description = "Fiat Linea" });
            //carManager.Add(new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 750, ModelYear = 2016, Description = "Mercedes A180" });
            //carManager.Add(new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 850, ModelYear = 2022, Description = "Mercedes E250" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
