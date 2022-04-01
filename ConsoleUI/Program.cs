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
            CarGetAll(carManager);

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

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //CustomerAdd(customerManager);
            //CustomerGetAll(customerManager);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            


        }

        private static void CustomerAdd(CustomerManager customerManager)
        {
            customerManager.Insert(new Customer { UserId = 1, CompanyName = "KodlamaIO" });
        }

        private static void CustomerGetAll(CustomerManager customerManager)
        {
            var resultCustomerListed = customerManager.GetAll().Data;
            foreach (var customer in resultCustomerListed)
            {
                Console.WriteLine(customer.UserId + " " + customer.CompanyName);
            }
        }

        private static void BrandDelete(BrandManager brandManager)
        {
            var result = brandManager.GetById(5);
            brandManager.Delete(result.Data);
        }

        private static void BrandUpdate(BrandManager brandManager)
        {
            var result = brandManager.GetById(3);
            result.Data.Name = "FIAT";
            brandManager.Update(result.Data);
        }

        private static void BrandGetById(BrandManager brandManager)
        {
            var result = brandManager.GetById(3);
            Console.WriteLine(result.Data.Name);
        }

        private static void BrandInsert(BrandManager brandManager)
        {
            brandManager.Insert(new Brand { Name = "Porsche" });
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (Brand brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Id : " + brand.Id + " " + brand.Name);
            }
        }

        private static void ColorDelete(ColorManager colorManager)
        {
            var result = colorManager.GetById(5);
            colorManager.Delete(result.Data);
        }

        private static void ColorUpdate(ColorManager colorManager)
        {
            var result = colorManager.GetById(6);
            result.Data.Name = "Gray";
            colorManager.Update(result.Data);
        }

        private static void ColorGetById(ColorManager colorManager)
        {
            var result = colorManager.GetById(4);
            Console.WriteLine(result.Data.Name);
        }

        private static void ColorInsert(ColorManager colorManager)
        {
            colorManager.Insert(new Color { Name = "Purple" });
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            foreach (Color color in result.Data)
            {
                Console.WriteLine("Id : " + color.Id + " " + color.Name);
            }
        }

        private static void CarDelete(CarManager carManager)
        {
            var result = carManager.GetById(1007);
            carManager.Delete(result.Data);
        }

        private static void CarUpdate(CarManager carManager)
        {
            var result = carManager.GetById(8);
            result.Data.Description = "Fiat 500L";
            result.Data.DailyPrice = 500;
            var resultCarUpdate = carManager.Update(result.Data);
        }

        private static void CarGetAll(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Id : " + car.Id + " " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarAdd(CarManager carManager)
        {
            carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = 2020, Description = "Fiat Egea" });
        }

        private static void CarGetById(CarManager carManager)
        {
            var result = carManager.GetById(2);
            Console.WriteLine(result.Data.Description);
        }
    }
}
